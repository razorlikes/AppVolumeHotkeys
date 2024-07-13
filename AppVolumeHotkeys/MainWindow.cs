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
        public MainWindow()
        {
            InitializeComponent();

            unsafe { PInvoke.SetWindowTheme(new HWND(listView1.Handle.ToPointer()), "explorer", null); }

            VolumeMixer volumeMixer = new VolumeMixer();
            foreach (var item in volumeMixer.GetEndpointNames())
            {
                Console.WriteLine(item.ToString());
            }
            volumeMixer.SetEndpoint(0);
            foreach (var item in volumeMixer.GetSessionNames())
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
