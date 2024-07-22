using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVolumeHotkeys
{
    public partial class AddingForm : Form
    {
        private VolumeMixer volumeMixer;

        public AddingForm(VolumeMixer mixer)
        {
            InitializeComponent();

            volumeMixer = mixer;

            cbxOutputDevice.DataSource = volumeMixer.GetEndpointNames();
            cbxAudioSession.DataSource = volumeMixer.GetSessionNames();
        }

        private void cbxOutputDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            volumeMixer.SetEndpoint(cbxOutputDevice.SelectedIndex);
            cbxAudioSession.DataSource = volumeMixer.GetSessionNames();
        }

        private void AddingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainWindow)this.Owner).AddAppControl(new AppControl(volumeMixer, volumeMixer.GetVolumeInterface(cbxAudioSession.SelectedIndex)));
        }
    }
}
