using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Win32.Media.Audio;

namespace AppVolumeHotkeys
{
    internal class AppControl
    {
        private VolumeMixer volumeMixer;

        public ListViewItem listViewItem { get; set; }

        public AppControl(VolumeMixer mixer, ISimpleAudioVolume audioVolume)
        {
            volumeMixer = mixer;

            listViewItem = new ListViewItem(new string[] { "TEST1", "TestSub1", "TestSub2" }, 0);

            
        }
    }
}
