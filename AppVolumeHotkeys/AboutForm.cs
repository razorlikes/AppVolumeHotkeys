using System.Diagnostics;
using System.Windows.Forms;

namespace AppVolumeHotkeys
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void lnkCSCore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/filoe/cscore/blob/master/license.md");
        }

        private void lnkFody_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Fody/Fody/blob/master/License.txt");
        }

        private void lnkCostura_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Fody/Costura/blob/master/license.txt");
        }
    }
}
