using CSCore.CoreAudioAPI;
using System.Collections.Generic;

namespace AppVolumeHotkeys
{
    class VolumeMixer
    {
        AudioSessionEnumerator audioSessionEnumerator;

        public VolumeMixer()
        {
            AudioSessionManager2 audioSessionManager = AudioSessionManager2.FromMMDevice(MMDeviceEnumerator.DefaultAudioEndpoint(DataFlow.Render, Role.Multimedia));
            audioSessionEnumerator = audioSessionManager.GetSessionEnumerator();
        }

        public List<string> GetSessionNames()
        {
            List<string> sessionNames = new List<string>();

            foreach (AudioSessionControl session in audioSessionEnumerator)
            {
                AudioSessionControl2 sessionControl2 = session.QueryInterface<AudioSessionControl2>();
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
    }
}
