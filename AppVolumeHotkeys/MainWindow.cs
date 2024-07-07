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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            VolumeMixer volumeMixer = new VolumeMixer();
            volumeMixer.GetEndpointNames();
        }
    }
}
