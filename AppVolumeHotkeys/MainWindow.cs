using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AppVolumeHotkeys
{
    public partial class MainWindow : Form
    {
        Keys VolUpHotkey, VolDownHotkey, VolUpModifier, VolDownModifier, MuteHotkey, MuteModifier;
        int VolumeSteps, AppVolume;
        bool AppMute;

        VolumeMixer volumeMixer;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

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

            if (VolumeSteps != 0)
                nudVolumeSteps.Value = VolumeSteps;

            RegisterHotKey(this.Handle, 1, (int)VolUpModifier, (int)VolUpHotkey);
            RegisterHotKey(this.Handle, 2, (int)VolDownModifier, (int)VolDownHotkey);
            RegisterHotKey(this.Handle, 3, (int)MuteModifier, (int)MuteHotkey);

            var converter = new KeysConverter();

            if (VolUpModifier != Keys.None)
                tbxVolUpHotkey.Text = converter.ConvertToString(VolUpModifier + " + " + VolUpHotkey);
            else if (VolUpModifier == Keys.None)
                tbxVolUpHotkey.Text = converter.ConvertToString(VolUpHotkey);

            if (VolDownModifier != Keys.None)
                tbxVolDownHotkey.Text = converter.ConvertToString(VolDownModifier + " + " + VolDownHotkey);
            else if (VolDownModifier == Keys.None)
                tbxVolDownHotkey.Text = converter.ConvertToString(VolDownHotkey);

            if (MuteModifier != Keys.None)
                tbxMuteHotkey.Text = converter.ConvertToString(MuteModifier + " + " + MuteHotkey);
            else if (MuteModifier == Keys.None)
                tbxMuteHotkey.Text = converter.ConvertToString(MuteHotkey);

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
                ToggleMute();

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

        private void textBox_VolUpHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            Keys modifierKey = e.Modifiers;
            Keys pressedKey = e.KeyData ^ modifierKey;

            var converter = new KeysConverter();
            tbxVolUpHotkey.Text = converter.ConvertToString(e.KeyData);

            VolUpModifier = modifierKey;
            VolUpHotkey = pressedKey;

            UnregisterHotKey(this.Handle, 1);
            RegisterHotKey(this.Handle, 1, (int)VolUpModifier, (int)VolUpHotkey);

            lblAppVolume.Focus(); //dirty workaround to remove focus from textbox after setting hotkey
        }

        private void textBox_VolDownHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            Keys modifierKey = e.Modifiers;
            Keys pressedKey = e.KeyData ^ modifierKey;

            var converter = new KeysConverter();
            tbxVolDownHotkey.Text = converter.ConvertToString(e.KeyData);

            VolDownModifier = modifierKey;
            VolDownHotkey = pressedKey;

            UnregisterHotKey(this.Handle, 2);
            RegisterHotKey(this.Handle, 2, (int)VolDownModifier, (int)VolDownHotkey);

            lblAppVolume.Focus(); //dirty workaround to remove focus from textbox after setting hotkey
        }

        private void textBox_MuteHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            Keys modifierKey = e.Modifiers;
            Keys pressedKey = e.KeyData ^ modifierKey;

            var converter = new KeysConverter();
            tbxMuteHotkey.Text = converter.ConvertToString(e.KeyData);

            MuteModifier = modifierKey;
            MuteHotkey = pressedKey;

            UnregisterHotKey(this.Handle, 3);
            RegisterHotKey(this.Handle, 3, (int)MuteModifier, (int)MuteHotkey);

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
            Properties.Settings.Default.Save();

            var converter = new KeysConverter();
            tbxVolUpHotkey.Text = converter.ConvertToString(Properties.Settings.Default.VolUpHotkey);
            tbxVolDownHotkey.Text = converter.ConvertToString(Properties.Settings.Default.VolDownHotkey);
            tbxMuteHotkey.Text = converter.ConvertToString(Properties.Settings.Default.MuteHotkey);
        }

        private void button_ResetHotkeys_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.VolUpHotkey = Keys.None;
            Properties.Settings.Default.VolUpModifier = Keys.None;
            Properties.Settings.Default.VolDownHotkey = Keys.None;
            Properties.Settings.Default.VolDownModifier = Keys.None;
            Properties.Settings.Default.MuteHotkey = Keys.None;
            Properties.Settings.Default.MuteModifier = Keys.None;
            Properties.Settings.Default.Save();

            var converter = new KeysConverter();
            tbxVolUpHotkey.Text = converter.ConvertToString(Properties.Settings.Default.VolUpHotkey);
            tbxVolDownHotkey.Text = converter.ConvertToString(Properties.Settings.Default.VolDownHotkey);
            tbxMuteHotkey.Text = converter.ConvertToString(Properties.Settings.Default.MuteHotkey);

            VolUpHotkey = Properties.Settings.Default.VolUpHotkey;
            VolUpModifier = Properties.Settings.Default.VolUpModifier;
            VolDownHotkey = Properties.Settings.Default.VolDownHotkey;
            VolDownModifier = Properties.Settings.Default.VolDownModifier;
            MuteHotkey = Properties.Settings.Default.MuteHotkey;
            MuteModifier = Properties.Settings.Default.MuteModifier;
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