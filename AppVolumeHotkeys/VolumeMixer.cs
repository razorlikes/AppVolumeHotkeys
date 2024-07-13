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
    class VolumeMixer
    {
        IAudioSessionEnumerator audioSessionEnumerator;
        IMMDeviceCollection deviceCollection;

        public VolumeMixer()
        {

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

                IntPtr sessionPtr = Marshal.GetIUnknownForObject((object)session);

                IntPtr sessionControl2Ptr;
                Guid guid = typeof(IAudioSessionControl2).GUID;
                Marshal.QueryInterface(sessionPtr, ref guid, out sessionControl2Ptr);

                IAudioSessionControl2 sessionControl2 = (IAudioSessionControl2)Marshal.GetObjectForIUnknown(sessionControl2Ptr);

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

        /* --FIXUP
        public int GetApplicationVolume(int index)
        {
            return (int)(audioSessionEnumerator.GetSession(index).QueryInterface<SimpleAudioVolume>().MasterVolume * 100);
        }

        public bool GetApplicationMute(int index)
        {
            return audioSessionEnumerator.GetSession(index).QueryInterface<SimpleAudioVolume>().IsMuted;
        }

        public void SetApplicationVolume(int index, int volume)
        {
            if (volume <= 0)
                audioSessionEnumerator.GetSession(index).QueryInterface<SimpleAudioVolume>().MasterVolume = 0;
            else if (volume >= 100)
                audioSessionEnumerator.GetSession(index).QueryInterface<SimpleAudioVolume>().MasterVolume = 1;
            else
                audioSessionEnumerator.GetSession(index).QueryInterface<SimpleAudioVolume>().MasterVolume = volume / 100f;
        }

        public void SetApplicationMute(int index, bool state)
        {
            audioSessionEnumerator.GetSession(index).QueryInterface<SimpleAudioVolume>().IsMuted = state;
        }
        */
    }
}
