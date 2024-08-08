using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Win32.Media.Audio;

namespace AppVolumeHotkeys
{
    public class AppControl
    {
        private VolumeMixer volumeMixer;

        public ListViewItem listViewItem { get; set; }

        public AppControl(VolumeMixer mixer)
        {
            volumeMixer = mixer;

            listViewItem = new ListViewItem(new string[] { "TEST1", "TestSub1", "TestSub2" }, 0);

            
        }

        internal void SetInterface(ISimpleAudioVolume volumeInterface)
        {
            //volumeInterface.GetMasterVolume(out float volume);
            //volumeInterface.GetMute(out bool mute);
            //volumeInterface.SetMasterVolume(0.5f, Guid.Empty);
            //volumeInterface.SetMute(false, Guid.Empty);
        }
    }
}
