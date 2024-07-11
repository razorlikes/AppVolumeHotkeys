using System.Collections.Generic;
using System.Data;
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
