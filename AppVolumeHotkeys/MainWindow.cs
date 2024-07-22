using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Win32;
using Windows.Win32.Foundation;

namespace AppVolumeHotkeys
{
    public partial class MainWindow : Form
    {
        private VolumeMixer volumeMixer;
        private List<AppControl> appControls = new List<AppControl>();

        public MainWindow()
        {
            InitializeComponent();

            unsafe 
            {
                HWND listHandle = new HWND(lsvApps.Handle.ToPointer());
                //set to explorer theme
                PInvoke.SetWindowTheme(listHandle, "explorer", null);
                //disable focus rect
                PInvoke.SendMessage(listHandle, PInvoke.WM_CHANGEUISTATE, PInvoke.MAKEWPARAM((ushort)PInvoke.UIS_SET, (ushort)PInvoke.UISF_HIDEFOCUS), 0);
            }

            volumeMixer = new VolumeMixer();
            foreach (var item in volumeMixer.GetEndpointNames())
            {
                Console.WriteLine(item.ToString());
            }
            volumeMixer.SetEndpoint(0);
            foreach (var item in volumeMixer.GetSessionNames())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(volumeMixer.GetApplicationVolume(0));
            Console.WriteLine(volumeMixer.GetApplicationMute(0));

            volumeMixer.SetApplicationVolume(0, 101);
            volumeMixer.SetApplicationMute(0, false);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddingForm addingForm = new AddingForm(volumeMixer);
            addingForm.Owner = this;
            addingForm.Show();
        }

        internal void AddAppControl(AppControl app)
        {
            appControls.Add(app);
            lsvApps.Items.Add(app.listViewItem);

            if (lblNoApps.Visible)
            {
                lblNoApps.Visible = false;
            }
        }
    }
}
