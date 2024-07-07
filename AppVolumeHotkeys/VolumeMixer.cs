using System.Collections.Generic;
using Windows.Win32;
using Windows.Win32.Media.Audio;
using Windows.Win32.System.Com;
using Windows.Win32.System.Com.StructuredStorage;
using Windows.Win32.UI.Shell.PropertiesSystem;

namespace AppVolumeHotkeys
{
    class VolumeMixer
    {
        IAudioSessionEnumerator audioSessionEnumerator;

        public VolumeMixer()
        {

        }

        public List<string> GetEndpointNames()
        {
            IMMDeviceEnumerator deviceEnumerator;
            PInvoke.CoCreateInstance<IMMDeviceEnumerator>(typeof(MMDeviceEnumerator).GUID, null, CLSCTX.CLSCTX_ALL, out deviceEnumerator);

            IMMDeviceCollection deviceCollection;
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

        /* --FIXUP
        public List<string> GetSessionNames()
        {
            List<string> sessionNames = new List<string>();

            foreach (IAudioSessionControl session in audioSessionEnumerator)
            {
                IAudioSessionControl2 sessionControl2 = session.QueryInterface<AudioSessionControl2>();
                if (sessionControl2.DisplayName.ToLower().Contains("audiosrv.dll"))
                    sessionNames.Add("[System Sounds]");
                else
                    sessionNames.Add("[" + sessionControl2.Process.ProcessName + "] " + sessionControl2.Process.MainWindowTitle);
            }

            return sessionNames;
        }

        public void SetEndpoint(int index)
        {
            IAudioSessionManager2 audioSessionManager = IAudioSessionManager2.FromMMDevice(IMMDeviceEnumerator.EnumerateDevices(DataFlow.Render, DeviceState.Active)[index]);
            audioSessionEnumerator = audioSessionManager.GetSessionEnumerator();
        }

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
