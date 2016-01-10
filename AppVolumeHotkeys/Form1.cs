using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVolumeHotkeys
{
    public partial class MainWindow : Form
    {
        Keys VolUpHotkey, VolDownHotkey, VolUpModifier, VolDownModifier, MuteHotkey, MuteModifier;
        string AppName, LastName;
        int PID, VolumeSteps;
        int AppVolume;
        bool AppMute;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        const int WM_HOTKEY = 0x0312;

        public MainWindow()
        {
            InitializeComponent();

            VolUpHotkey = Properties.Settings.Default.VolUpHotkey;
            VolUpModifier = Properties.Settings.Default.VolUpModifier;
            VolDownHotkey = Properties.Settings.Default.VolDownHotkey;
            VolDownModifier = Properties.Settings.Default.VolDownModifier;
            MuteHotkey = Properties.Settings.Default.MuteHotkey;
            MuteModifier = Properties.Settings.Default.MuteModifier;
            LastName = Properties.Settings.Default.LastName;
            VolumeSteps = Properties.Settings.Default.LastVolStep;

            if (LastName != String.Empty)
                CueTextBox_AppName.Text = LastName;

            if (VolumeSteps != 0)
                numericUpDown_VolumeSteps.Value = VolumeSteps;

            RegisterHotKey(this.Handle, 1, (int)VolUpModifier, (int)VolUpHotkey);
            RegisterHotKey(this.Handle, 2, (int)VolDownModifier, (int)VolDownHotkey);
            RegisterHotKey(this.Handle, 3, (int)MuteModifier, (int)MuteHotkey);

            var converter = new KeysConverter();

            if (VolUpModifier != Keys.None)
                textBox_VolUpHotkey.Text = converter.ConvertToString(VolUpModifier + "+" + VolUpHotkey);

            else if (VolUpModifier == Keys.None)
                textBox_VolUpHotkey.Text = converter.ConvertToString(VolUpHotkey);
                
            if (VolDownModifier != Keys.None)
                textBox_VolDownHotkey.Text = converter.ConvertToString(VolDownModifier + "+" + VolDownHotkey);
                
            else if (VolDownModifier == Keys.None)
                textBox_VolDownHotkey.Text = converter.ConvertToString(VolDownHotkey);

            if (MuteModifier != Keys.None)
                textBox_MuteHotkey.Text = converter.ConvertToString(MuteModifier + "+" + MuteHotkey);

            else if (MuteModifier == Keys.None)
                textBox_MuteHotkey.Text = converter.ConvertToString(MuteHotkey);

            VolumeSteps = decimal.ToInt32(numericUpDown_VolumeSteps.Value);
        }


        private void button_SetName_Click(object sender, EventArgs e)
        {
            AppName = CueTextBox_AppName.Text;
            foreach (var p in Process.GetProcesses())
                if (p.MainWindowTitle.ToLower() == AppName.ToLower() | p.MainWindowTitle.ToLower().Contains(AppName.ToLower()))
                {
                    textBox1.Text = textBox1.Text + Environment.NewLine + p.MainWindowTitle + " PID = " + p.Id;
                    if (p.MainWindowTitle.Length > 56)
                        label_ProgramStatus.Text = "Application '" + p.MainWindowTitle.Substring(0, 55) + "' found and set.";
                    else label_ProgramStatus.Text = "Application '" + p.MainWindowTitle + "' found and set.";
                    PID = p.Id;
                    WriteVolumeLabel();
                    WriteMuteLabel();
                    return;
                }
                else label_ProgramStatus.Text = "Can't find application '" + CueTextBox_AppName.Text + "'.";
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

        public void VolumeUp()
        {
            VolumeMixer.SetApplicationVolume(PID, AppVolume + VolumeSteps);
            WriteVolumeLabel();
        }

        public void VolumeDown()
        {
            VolumeMixer.SetApplicationVolume(PID, AppVolume - VolumeSteps);
            WriteVolumeLabel();
        }

        public void ToggleMute()
        {

            if (AppMute == false)
                VolumeMixer.SetApplicationMute(PID, true);
            else VolumeMixer.SetApplicationMute(PID, false);
            WriteMuteLabel();
        }

        public void WriteVolumeLabel()
        {
            AppVolume = VolumeMixer.GetApplicationVolume(PID);
            if (AppVolume == 999)
                MessageBox.Show("This Application has no controllable volume." + Environment.NewLine + 
                                "Please select another application or start an audio stream on your selected one.",
                                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else label_AppVolume.Text = AppVolume.ToString();
        }

        public void WriteMuteLabel()
        {
            AppMute = VolumeMixer.GetApplicationMute(PID);
            if (AppMute == true)
                label_AppMute.Text = "Yes";
            else label_AppMute.Text = "No";
        }

        private void numericUpDown_VolumeSteps_ValueChanged(object sender, EventArgs e)
        {
            VolumeSteps = decimal.ToInt32(numericUpDown_VolumeSteps.Value);
            textBox1.Text = textBox1.Text + Environment.NewLine + VolumeSteps.ToString();
        }

        private void numericUpDown_VolumeSteps_KeyPress(object sender, KeyPressEventArgs e)
        {
            VolumeSteps = decimal.ToInt32(numericUpDown_VolumeSteps.Value);
        }

        private void textBox_VolUpHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            Keys modifierKey = e.Modifiers;
            Keys pressedKey = e.KeyData ^ modifierKey;

            var converter = new KeysConverter();
            textBox_VolUpHotkey.Text = converter.ConvertToString(e.KeyData);

            VolUpModifier = modifierKey;
            VolUpHotkey = pressedKey;

            UnregisterHotKey(this.Handle, 1);
            RegisterHotKey(this.Handle, 1, (int)VolUpModifier, (int)VolUpHotkey);
        }

        private void textBox_VolDownHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            Keys modifierKey = e.Modifiers;
            Keys pressedKey = e.KeyData ^ modifierKey;

            var converter = new KeysConverter();
            textBox_VolDownHotkey.Text = converter.ConvertToString(e.KeyData);

            VolDownModifier = modifierKey;
            VolDownHotkey = pressedKey;

            UnregisterHotKey(this.Handle, 2);
            RegisterHotKey(this.Handle, 2, (int)VolDownModifier, (int)VolDownHotkey);
        }

        private void textBox_MuteHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            Keys modifierKey = e.Modifiers;
            Keys pressedKey = e.KeyData ^ modifierKey;

            var converter = new KeysConverter();
            textBox_MuteHotkey.Text = converter.ConvertToString(e.KeyData);

            MuteModifier = modifierKey;
            MuteHotkey = pressedKey;

            UnregisterHotKey(this.Handle, 3);
            RegisterHotKey(this.Handle, 3, (int)MuteModifier, (int)MuteHotkey);
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
            textBox_VolUpHotkey.Text = converter.ConvertToString(Properties.Settings.Default.VolUpHotkey);
            textBox_VolDownHotkey.Text = converter.ConvertToString(Properties.Settings.Default.VolDownHotkey);
            textBox_MuteHotkey.Text = converter.ConvertToString(Properties.Settings.Default.MuteHotkey);
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
            textBox_VolUpHotkey.Text = converter.ConvertToString(Properties.Settings.Default.VolUpHotkey);
            textBox_VolDownHotkey.Text = converter.ConvertToString(Properties.Settings.Default.VolDownHotkey);
            textBox_MuteHotkey.Text = converter.ConvertToString(Properties.Settings.Default.MuteHotkey);

            VolUpHotkey = Properties.Settings.Default.VolUpHotkey;
            VolUpModifier = Properties.Settings.Default.VolUpModifier;
            VolDownHotkey = Properties.Settings.Default.VolDownHotkey;
            VolDownModifier = Properties.Settings.Default.VolDownModifier;
            MuteHotkey = Properties.Settings.Default.MuteHotkey;
            MuteModifier = Properties.Settings.Default.MuteModifier;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.LastName = CueTextBox_AppName.Text;
            Properties.Settings.Default.LastVolStep = decimal.ToInt32(numericUpDown_VolumeSteps.Value);
            Properties.Settings.Default.Save();

            UnregisterHotKey(this.Handle, 1);
            UnregisterHotKey(this.Handle, 2);
        }

        #region c/p
        public class VolumeMixer
        {
            public static int GetApplicationVolume(int pid)
            {
                ISimpleAudioVolume volume = GetVolumeObject(pid);
                if (volume == null)
                    return 999;

                float level;
                volume.GetMasterVolume(out level);
                Marshal.ReleaseComObject(volume);
                level = level * 100;
                return Convert.ToInt32(level);
            }

            public static bool GetApplicationMute(int pid)
            {
                ISimpleAudioVolume volume = GetVolumeObject(pid);
                if (volume == null)
                    return false;

                bool mute;
                volume.GetMute(out mute);
                Marshal.ReleaseComObject(volume);
                return mute;
            }

            public static void SetApplicationVolume(int pid, float level)
            {
                ISimpleAudioVolume volume = GetVolumeObject(pid);
                if (volume == null)
                    return;

                Guid guid = Guid.Empty;
                volume.SetMasterVolume(level / 100, ref guid);
                Marshal.ReleaseComObject(volume);
            }

            public static void SetApplicationMute(int pid, bool mute)
            {
                ISimpleAudioVolume volume = GetVolumeObject(pid);
                if (volume == null)
                    return;

                Guid guid = Guid.Empty;
                volume.SetMute(mute, ref guid);
                Marshal.ReleaseComObject(volume);
            }

            private static ISimpleAudioVolume GetVolumeObject(int pid)
            {
                // get the speakers (1st render + multimedia) device
                IMMDeviceEnumerator deviceEnumerator = (IMMDeviceEnumerator)(new MMDeviceEnumerator());
                IMMDevice speakers;
                deviceEnumerator.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia, out speakers);

                // activate the session manager. we need the enumerator
                Guid IID_IAudioSessionManager2 = typeof(IAudioSessionManager2).GUID;
                object o;
                speakers.Activate(ref IID_IAudioSessionManager2, 0, IntPtr.Zero, out o);
                IAudioSessionManager2 mgr = (IAudioSessionManager2)o;

                // enumerate sessions for on this device
                IAudioSessionEnumerator sessionEnumerator;
                mgr.GetSessionEnumerator(out sessionEnumerator);
                int count;
                sessionEnumerator.GetCount(out count);

                // search for an audio session with the required id
                ISimpleAudioVolume volumeControl = null;
                for (int i = 0; i < count; i++)
                {
                    IAudioSessionControl2 ctl;
                    sessionEnumerator.GetSession(i, out ctl);
                    int cpid;
                    ctl.GetProcessId(out cpid);

                    if (cpid == pid)
                    {
                        volumeControl = ctl as ISimpleAudioVolume;
                        break;
                    }
                    Marshal.ReleaseComObject(ctl);
                }
                Marshal.ReleaseComObject(sessionEnumerator);
                Marshal.ReleaseComObject(mgr);
                Marshal.ReleaseComObject(speakers);
                Marshal.ReleaseComObject(deviceEnumerator);
                return volumeControl;
            }

        }

        [ComImport]
        [Guid("BCDE0395-E52F-467C-8E3D-C4579291692E")]
        internal class MMDeviceEnumerator
        {
        }

        internal enum EDataFlow
        {
            eRender,
            eCapture,
            eAll,
            EDataFlow_enum_count
        }


        internal enum ERole
        {
            eConsole,
            eMultimedia,
            eCommunications,
            ERole_enum_count
        }

        [Guid("A95664D2-9614-4F35-A746-DE8DB63617E6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        internal interface IMMDeviceEnumerator
        {
            int NotImpl1();

            [PreserveSig]
            int GetDefaultAudioEndpoint(EDataFlow dataFlow, ERole role, out IMMDevice ppDevice);

            // the rest is not implemented
        }

        [Guid("D666063F-1587-4E43-81F1-B948E807363F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        internal interface IMMDevice
        {
            [PreserveSig]
            int Activate(ref Guid iid, int dwClsCtx, IntPtr pActivationParams, [MarshalAs(UnmanagedType.IUnknown)] out object ppInterface);

            // the rest is not implemented
        }

        [Guid("77AA99A0-1BD6-484F-8BC7-2C654C9A9B6F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        internal interface IAudioSessionManager2
        {
            int NotImpl1();
            int NotImpl2();

            [PreserveSig]
            int GetSessionEnumerator(out IAudioSessionEnumerator SessionEnum);

            // the rest is not implemented
        }

        [Guid("E2F5BB11-0570-40CA-ACDD-3AA01277DEE8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        internal interface IAudioSessionEnumerator
        {
            [PreserveSig]
            int GetCount(out int SessionCount);

            [PreserveSig]
            int GetSession(int SessionCount, out IAudioSessionControl2 Session);
        }

        [Guid("87CE5498-68D6-44E5-9215-6DA47EF883D8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        internal interface ISimpleAudioVolume
        {
            [PreserveSig]
            int SetMasterVolume(float fLevel, ref Guid EventContext);

            [PreserveSig]
            int GetMasterVolume(out float pfLevel);

            [PreserveSig]
            int SetMute(bool bMute, ref Guid EventContext);

            [PreserveSig]
            int GetMute(out bool pbMute);
        }


        [Guid("bfb7ff88-7239-4fc9-8fa2-07c950be9c6d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        internal interface IAudioSessionControl2
        {
            // IAudioSessionControl
            [PreserveSig]
            int NotImpl0();

            [PreserveSig]
            int GetDisplayName([MarshalAs(UnmanagedType.LPWStr)] out string pRetVal);

            [PreserveSig]
            int SetDisplayName([MarshalAs(UnmanagedType.LPWStr)]string Value, [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext);

            [PreserveSig]
            int GetIconPath([MarshalAs(UnmanagedType.LPWStr)] out string pRetVal);

            [PreserveSig]
            int SetIconPath([MarshalAs(UnmanagedType.LPWStr)] string Value, [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext);

            [PreserveSig]
            int GetGroupingParam(out Guid pRetVal);

            [PreserveSig]
            int SetGroupingParam([MarshalAs(UnmanagedType.LPStruct)] Guid Override, [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext);

            [PreserveSig]
            int NotImpl1();

            [PreserveSig]
            int NotImpl2();

            // IAudioSessionControl2
            [PreserveSig]
            int GetSessionIdentifier([MarshalAs(UnmanagedType.LPWStr)] out string pRetVal);

            [PreserveSig]
            int GetSessionInstanceIdentifier([MarshalAs(UnmanagedType.LPWStr)] out string pRetVal);

            [PreserveSig]
            int GetProcessId(out int pRetVal);

            [PreserveSig]
            int IsSystemSoundsSession();

            [PreserveSig]
            int SetDuckingPreference(bool optOut);
        }
        #endregion

    }
}
