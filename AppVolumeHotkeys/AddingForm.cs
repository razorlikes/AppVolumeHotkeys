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
        private AppControl appControl;

        //constructor for adding new control
        public AddingForm(VolumeMixer mixer)
        {
            InitializeComponent();

            volumeMixer = mixer;
            appControl = new AppControl(volumeMixer);

            cbxOutputDevice.DataSource = volumeMixer.GetEndpointNames();
            cbxAudioSession.DataSource = volumeMixer.GetSessionNames();
        }

        //constructor for editing existing control
        public AddingForm(VolumeMixer mixer, AppControl app)
        {
            InitializeComponent();

            volumeMixer = mixer;
            appControl = app;

            cbxOutputDevice.DataSource = volumeMixer.GetEndpointNames();
            cbxAudioSession.DataSource = volumeMixer.GetSessionNames();
        }

        private void cbxOutputDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            volumeMixer.SetEndpoint(cbxOutputDevice.SelectedIndex);
            cbxAudioSession.DataSource = volumeMixer.GetSessionNames();
        }

        private void cbxAudioSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            appControl.SetInterface(volumeMixer.GetVolumeInterface(cbxAudioSession.SelectedIndex));
        }

        private void AddingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainWindow)this.Owner).AddAppControl(appControl);
        }
    }
}
