using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AppVolumeHotkeys
{
    public partial class MainWindow : Form
    {
        Keys VolUpHotkey, VolDownHotkey, VolUpModifier, VolDownModifier, MuteHotkey, MuteModifier, PTTHotkey;
        int VolumeSteps, AppVolume, SoftMuteLevel;
        bool AppMute;
        bool isPTTPressed = false;
        bool SoftMute = false;

        VolumeMixer volumeMixer;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(Keys vKey);

        const int WM_HOTKEY = 0x0312;

        public MainWindow()
        {
            InitializeComponent();

            notifyIcon.ContextMenuStrip = cmsTray;

            VolUpHotkey = Properties.Settings.Default.VolUpHotkey;
            VolUpModifier = Properties.Settings.Default.VolUpModifier;
            VolDownHotkey = Properties.Settings.Default.VolDownHotkey;
            VolDownModifier = Properties.Settings.Default.VolDownModifier;
            MuteHotkey = Properties.Settings.Default.MuteHotkey;
            MuteModifier = Properties.Settings.Default.MuteModifier;
            VolumeSteps = Properties.Settings.Default.LastVolStep;
            SoftMuteLevel = Properties.Settings.Default.SoftMuteLevel;
            PTTHotkey = Properties.Settings.Default.PTTHotkey;

            if (VolumeSteps != 0)
                nudVolumeSteps.Value = VolumeSteps;

            if (SoftMuteLevel != 0)
                nudSoftMuteLevel.Value = SoftMuteLevel;

            RegisterHotKey(this.Handle, 1, (int)VolUpModifier, (int)VolUpHotkey);
            RegisterHotKey(this.Handle, 2, (int)VolDownModifier, (int)VolDownHotkey);
            RegisterHotKey(this.Handle, 3, (int)MuteModifier, (int)MuteHotkey);

            var converter = new KeysConverter();

            tbxVolUpHotkey.Clear();
            if (((int)VolUpModifier & 1) != 0)
                tbxVolUpHotkey.AppendText("ALT+");
            if (((int)VolUpModifier & 2) != 0)
                tbxVolUpHotkey.AppendText("CTRL+");
            if (((int)VolUpModifier & 4) != 0)
                tbxVolUpHotkey.AppendText("SHIFT+");
            tbxVolUpHotkey.AppendText(converter.ConvertToString(VolUpHotkey));

            tbxVolDownHotkey.Clear();
            if (((int)VolDownModifier & 1) != 0)
                tbxVolDownHotkey.AppendText("ALT+");
            if (((int)VolDownModifier & 2) != 0)
                tbxVolDownHotkey.AppendText("CTRL+");
            if (((int)VolDownModifier & 4) != 0)
                tbxVolDownHotkey.AppendText("SHIFT+");
            tbxVolDownHotkey.AppendText(converter.ConvertToString(VolDownHotkey));

            tbxMuteHotkey.Clear();
            if (((int)MuteModifier & 1) != 0)
                tbxMuteHotkey.AppendText("ALT+");
            if (((int)MuteModifier & 2) != 0)
                tbxMuteHotkey.AppendText("CTRL+");
            if (((int)MuteModifier & 4) != 0)
                tbxMuteHotkey.AppendText("SHIFT+");
            tbxMuteHotkey.AppendText(converter.ConvertToString(MuteHotkey));

            tbxPTTHotkey.Clear();
            tbxPTTHotkey.AppendText(converter.ConvertToString(PTTHotkey));

            VolumeSteps = decimal.ToInt32(nudVolumeSteps.Value);

            volumeMixer = new VolumeMixer();

            cmbEndpoints.DataSource = volumeMixer.GetEndpointNames();
            cmbAppName.DataSource = volumeMixer.GetSessionNames();

            int maxwidth = 166;

            foreach (string item in cmbEndpoints.Items)
                if (maxwidth < TextRenderer.MeasureText(item, cmbEndpoints.Font).Width)
                    maxwidth = TextRenderer.MeasureText(item, cmbEndpoints.Font).Width;

            cmbEndpoints.DropDownWidth = maxwidth;

            maxwidth = 166;

            foreach (string item in cmbAppName.Items)
                if (maxwidth < TextRenderer.MeasureText(item, cmbAppName.Font).Width)
                    maxwidth = TextRenderer.MeasureText(item, cmbAppName.Font).Width;

            cmbAppName.DropDownWidth = maxwidth;

            if (cmbEndpoints.FindStringExact(Properties.Settings.Default.LastEndpointName) != -1)
                cmbEndpoints.SelectedIndex = cmbEndpoints.FindStringExact(Properties.Settings.Default.LastEndpointName);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY && (int)m.WParam == 1)
                VolumeUp();

            if (m.Msg == WM_HOTKEY && (int)m.WParam == 2)
                VolumeDown();

            if (m.Msg == WM_HOTKEY && (int)m.WParam == 3)
            {
                ToggleMute();
            }

            base.WndProc(ref m);
        }
        private void btnAppNameRefresh_Click(object sender, EventArgs e)
        {
            cmbAppName.DataSource = volumeMixer.GetSessionNames();
        }

        private void btnEndpointsRefresh_Click(object sender, EventArgs e)
        {
            cmbEndpoints.DataSource = volumeMixer.GetEndpointNames();
        }

        private void cmbAppName_SelectedIndexChanged(object sender, EventArgs e)
        {
            WriteVolumeLabel();
            WriteMuteLabel();
        }

        private void cmbEndpoints_SelectedIndexChanged(object sender, EventArgs e)
        {
            volumeMixer.SetEndpoint(cmbEndpoints.SelectedIndex);
            cmbAppName.DataSource = volumeMixer.GetSessionNames();
        }

        public void VolumeUp()
        {
            volumeMixer.SetApplicationVolume(cmbAppName.SelectedIndex, AppVolume + VolumeSteps);
            WriteVolumeLabel();
        }

        public void VolumeDown()
        {
            volumeMixer.SetApplicationVolume(cmbAppName.SelectedIndex, AppVolume - VolumeSteps);
            WriteVolumeLabel();
        }
        public void ToggleMute()
        {
            if (AppMute == false)
                volumeMixer.SetApplicationMute(cmbAppName.SelectedIndex, true);
            else volumeMixer.SetApplicationMute(cmbAppName.SelectedIndex, false);
            WriteMuteLabel();
        }

        public void WriteVolumeLabel()
        {
            AppVolume = volumeMixer.GetApplicationVolume(cmbAppName.SelectedIndex);
            lblAppVolume.Text = AppVolume.ToString();
        }

        public void WriteMuteLabel()
        {
            AppMute = volumeMixer.GetApplicationMute(cmbAppName.SelectedIndex);
            if (AppMute)
                lblAppMute.Text = "Yes";
            else lblAppMute.Text = "No";
        }

        private void numericUpDown_VolumeSteps_ValueChanged(object sender, EventArgs e)
        {
            VolumeSteps = (int)nudVolumeSteps.Value;
        }

        private void numericUpDown_VolumeSteps_KeyDown(object sender, KeyEventArgs e)
        {
            VolumeSteps = (int)nudVolumeSteps.Value;
        }

        private void textBox_VolUpHotkey_KeyUp(object sender, KeyEventArgs e)
        {
            if (((int)(e.KeyData ^ e.Modifiers) == 16) || ((int)(e.KeyData ^ e.Modifiers) == 17) || ((int)(e.KeyData ^ e.Modifiers) == 18))
                return;

            var converter = new KeysConverter();
            tbxVolUpHotkey.Text = converter.ConvertToString(e.KeyData).ToUpper();

            VolUpModifier = 0;

            if (e.Alt)
                VolUpModifier += 1;
            if (e.Control)
                VolUpModifier += 2;
            if (e.Shift)
                VolUpModifier += 4;

            VolUpHotkey = e.KeyData ^ e.Modifiers;

            UnregisterHotKey(this.Handle, 1);
            RegisterHotKey(this.Handle, 1, (int)VolUpModifier, (int)VolUpHotkey);

            lblAppVolume.Focus(); //dirty workaround to remove focus from textbox after setting hotkey
        }

        private void textBox_VolDownHotkey_KeyUp(object sender, KeyEventArgs e)
        {
            if (((int)(e.KeyData ^ e.Modifiers) == 16) || ((int)(e.KeyData ^ e.Modifiers) == 17) || ((int)(e.KeyData ^ e.Modifiers) == 18))
                return;

            var converter = new KeysConverter();
            tbxVolDownHotkey.Text = converter.ConvertToString(e.KeyData).ToUpper();

            VolDownModifier = 0;

            if (e.Alt)
                VolDownModifier += 1;
            if (e.Control)
                VolDownModifier += 2;
            if (e.Shift)
                VolDownModifier += 4;

            VolDownHotkey = e.KeyData ^ e.Modifiers;

            UnregisterHotKey(this.Handle, 2);
            RegisterHotKey(this.Handle, 2, (int)VolDownModifier, (int)VolDownHotkey);

            lblAppVolume.Focus(); //dirty workaround to remove focus from textbox after setting hotkey
        }

        private void textBox_MuteHotkey_KeyUp(object sender, KeyEventArgs e)
        {
            if (((int)(e.KeyData ^ e.Modifiers) == 16) || ((int)(e.KeyData ^ e.Modifiers) == 17) || ((int)(e.KeyData ^ e.Modifiers) == 18))
                return;

            var converter = new KeysConverter();
            tbxMuteHotkey.Text = converter.ConvertToString(e.KeyData).ToUpper();

            MuteModifier = 0;

            if (e.Alt)
                MuteModifier += 1;
            if (e.Control)
                MuteModifier += 2;
            if (e.Shift)
                MuteModifier += 4;

            MuteHotkey = e.KeyData ^ e.Modifiers;

            UnregisterHotKey(this.Handle, 3);
            RegisterHotKey(this.Handle, 3, (int)MuteModifier, (int)MuteHotkey);

            lblAppVolume.Focus(); //dirty workaround to remove focus from textbox after setting hotkey
        }
        private void tbxPTTHotkey_KeyUp(object sender, KeyEventArgs e)
        {
            var converter = new KeysConverter();
            tbxPTTHotkey.Text = converter.ConvertToString(e.KeyData).ToUpper();

            PTTHotkey = e.KeyData;

            lblAppVolume.Focus(); //dirty workaround to remove focus from textbox after setting hotkey
        }

        private void button_SaveHotkeys_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.VolUpHotkey = VolUpHotkey;
            Properties.Settings.Default.VolUpModifier = VolUpModifier;
            Properties.Settings.Default.VolDownHotkey = VolDownHotkey;
            Properties.Settings.Default.VolDownModifier = VolDownModifier;
            Properties.Settings.Default.MuteHotkey = MuteHotkey;
            Properties.Settings.Default.MuteModifier = MuteModifier;
            Properties.Settings.Default.PTTHotkey = PTTHotkey;
            Properties.Settings.Default.Save();
        }

        private void button_ResetHotkeys_Click(object sender, EventArgs e)
        {
            VolUpHotkey = Keys.None;
            VolUpModifier = Keys.None;
            VolDownHotkey = Keys.None;
            VolDownModifier = Keys.None;
            MuteHotkey = Keys.None;
            MuteModifier = Keys.None;
            PTTHotkey = Keys.None;

            tbxVolUpHotkey.Text = "None";
            tbxVolDownHotkey.Text = "None";
            tbxMuteHotkey.Text = "None";
            tbxPTTHotkey.Text = "None";

            button_SaveHotkeys_Click(sender, e);
        }

        private void timer_Refresh_Tick(object sender, EventArgs e)
        {
            WriteVolumeLabel();
            WriteMuteLabel();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        private void notifyIcon_MouseMove(object sender, MouseEventArgs e)
        {
            if (AppMute)
                notifyIcon.Text = "AppVolumeHotkeys\nVolume: " + AppVolume.ToString() + " | Mute: Yes";
            else notifyIcon.Text = "AppVolumeHotkeys\nVolume: " + AppVolume.ToString() + " | Mute: No";
        }

        private void itemOpen_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void timer_ptt_Tick(object sender, EventArgs e)
        {
            if ((GetAsyncKeyState(PTTHotkey) & 0x8000) != 0 && !isPTTPressed)
            {
                volumeMixer.SetApplicationVolume(cmbAppName.SelectedIndex, (int)nudSoftMuteLevel.Value);
                isPTTPressed = true;
            }
            if ((GetAsyncKeyState(PTTHotkey) & 0x8000) == 0)
            {
                isPTTPressed = false;
                volumeMixer.SetApplicationVolume(cmbAppName.SelectedIndex, 100);
            }

        }
        private void nudSoftMuteLevel_ValueChanged(object sender, EventArgs e)
        {
            SoftMuteLevel = (int)nudSoftMuteLevel.Value;
        }
        private void nudSoftMuteLevel_KeyDown(object sender, KeyEventArgs e)
        {
            SoftMuteLevel = (int)nudSoftMuteLevel.Value;
        }

        private void checkBox_SoftMute_CheckedChanged(object sender, EventArgs e)
        {
            SoftMute = !SoftMute;
        }

        private void itemVolUp_Click(object sender, EventArgs e)
        {
            VolumeUp();
        }

        private void itemVolDown_Click(object sender, EventArgs e)
        {
            VolumeDown();
        }

        private void itemMute_Click(object sender, EventArgs e)
        {
            ToggleMute();
        }

        private void itemAbout_Click(object sender, EventArgs e)
        {
            new AboutForm().Show();
        }

        private void itemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.LastVolStep = decimal.ToInt32(nudVolumeSteps.Value);
            Properties.Settings.Default.SoftMuteLevel = decimal.ToInt32(nudSoftMuteLevel.Value);
            Properties.Settings.Default.LastEndpointName = cmbEndpoints.Text;
            Properties.Settings.Default.Save();

            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();

                if (Properties.Settings.Default.FirstNotification)
                {
                    notifyIcon.ShowBalloonTip(5, string.Empty, "AppVolumeHotkeys will stay open in the background when you close the window, rightclick on the tray icon and select 'Exit' to close it.", ToolTipIcon.None);
                    Properties.Settings.Default.FirstNotification = false;
                    Properties.Settings.Default.Save();
                }

                e.Cancel = true;
                return;
            }

            UnregisterHotKey(this.Handle, 1);
            UnregisterHotKey(this.Handle, 2);
            UnregisterHotKey(this.Handle, 3);
        }
    }
}