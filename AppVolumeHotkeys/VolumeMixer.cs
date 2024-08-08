using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.Media.Audio;
using Windows.Win32.System.Com;
using Windows.Win32.System.Com.StructuredStorage;
using Windows.Win32.UI.Shell.PropertiesSystem;

namespace AppVolumeHotkeys
{
    public class VolumeMixer
    {
        IAudioSessionEnumerator audioSessionEnumerator;
        IMMDeviceCollection deviceCollection;

        public VolumeMixer()
        {

        }

        internal T QueryInterface<T>(object obj)
        {
            IntPtr objPtr = Marshal.GetIUnknownForObject(obj);
            IntPtr interfacePtr;
            Guid guid = typeof(T).GUID;
            Marshal.QueryInterface(objPtr, ref guid, out interfacePtr);
            return (T)Marshal.GetObjectForIUnknown(interfacePtr);
        }

        public List<string> GetEndpointNames()
        {
            IMMDeviceEnumerator deviceEnumerator;
            PInvoke.CoCreateInstance<IMMDeviceEnumerator>(typeof(MMDeviceEnumerator).GUID, null, CLSCTX.CLSCTX_ALL, out deviceEnumerator);

            deviceEnumerator.EnumAudioEndpoints(EDataFlow.eRender, DEVICE_STATE.DEVICE_STATE_ACTIVE, out deviceCollection);

            List<string> endpointNames = [];

            uint devCount = 0;
            deviceCollection.GetCount(out devCount);
            for (uint i = 0; i < devCount; i++)
            {
                IMMDevice device;
                deviceCollection.Item(i, out device);

                IPropertyStore propertyStore;
                device.OpenPropertyStore(STGM.STGM_READ, out propertyStore);

                PROPVARIANT propVar;
                propertyStore.GetValue(PInvoke.PKEY_Device_FriendlyName, out propVar);

                endpointNames.Add(propVar.Anonymous.Anonymous.Anonymous.pwszVal.ToString());
            }

            return endpointNames;
        }

        public void SetEndpoint(int index)
        {
            IMMDevice device;
            deviceCollection.Item((uint)index, out device);

            object temp;
            device.Activate(typeof(IAudioSessionManager2).GUID, CLSCTX.CLSCTX_ALL, null, out temp);

            IAudioSessionManager2 audioSessionManager = (IAudioSessionManager2)temp;
            audioSessionEnumerator = audioSessionManager.GetSessionEnumerator();
        }

        public List<string> GetSessionNames()
        {
            List<string> sessionNames = [];

            int sesCount = 0;
            audioSessionEnumerator.GetCount(out sesCount);
            for (int i = 0; i < sesCount; i++)
            {
                IAudioSessionControl session;
                audioSessionEnumerator.GetSession(i, out session);
                IAudioSessionControl2 sessionControl2 = QueryInterface<IAudioSessionControl2>(session);

                PWSTR displayNamePWSTR;
                sessionControl2.GetDisplayName(out displayNamePWSTR);
                string displayName = displayNamePWSTR.ToString();

                uint processId;
                sessionControl2.GetProcessId(out processId);
                Process process = Process.GetProcessById((int)processId);                

                if (displayName.ToLower().Contains("audiosrv.dll"))
                    sessionNames.Add("[System Sounds]");
                else
                    sessionNames.Add("[" + process.ProcessName + "] " + process.MainWindowTitle);
            }

            return sessionNames;
        }

        internal int GetApplicationVolume(ISimpleAudioVolume audioVolume)
        {
            float volume;
            audioVolume.GetMasterVolume(out volume);

            return (int)(volume * 100);
        }

        internal bool GetApplicationMute(ISimpleAudioVolume audioVolume)
        {
            BOOL mute = new BOOL();
            unsafe
            {
                audioVolume.GetMute(&mute);
                return (bool)mute;
            }
        }

        internal void SetApplicationVolume(ISimpleAudioVolume audioVolume, int volume)
        {
            unsafe
            {
                if (volume <= 0)
                    audioVolume.SetMasterVolume(0, null);
                else if (volume >= 100)
                    audioVolume.SetMasterVolume(1, null);
                else
                    audioVolume.SetMasterVolume(volume / 100f, null);
            }
        }

        internal void SetApplicationMute(ISimpleAudioVolume audioVolume, bool state)
        {
            unsafe { audioVolume.SetMute(state, null); }
        }

        internal IAudioSessionControl GetSessionInterface(int index)
        {
            IAudioSessionControl session;
            audioSessionEnumerator.GetSession(index, out session);
            return session;
        }

        internal ISimpleAudioVolume GetVolumeInterface(int index)
        {
            IAudioSessionControl session;
            audioSessionEnumerator.GetSession(index, out session);
            return QueryInterface<ISimpleAudioVolume>(session);
        }
    }
}
