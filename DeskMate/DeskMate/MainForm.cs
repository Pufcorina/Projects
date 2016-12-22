using DeskMate.Properties;
using Recipe_form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace DeskMate
{
    public partial class MainForm : Form
    {
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;
        public static float min;
        public static int kpm;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        //Brightness

        private struct RAMP
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Red;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Green;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Blue;
        }
        [DllImport("gdi32.dll")]
        private static extern bool SetDeviceGammaRamp(IntPtr hDC, ref RAMP lpRamp);
        // private static extern bool GetDeviceGammaRamp(IntPtr hDC, ref RAMP lpRamp);

        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr hWnd);
        //[DllImport("Dxva2.dll")]
        //private static extern bool SetMonitorBrightness(int a);

        /// <summary> Required designer variable.</summary>

        private static RAMP s_ramp = new RAMP();

        //other
        public static DateTime time = DateTime.Now;
        public static TimeSpan ts = new TimeSpan();
        public static int seconds = 0;

        public static int BackSpace = 0;
        public static int KeyCounter = 0;
        public static int MinutesPassed = 0;

        private ContextMenu sysTrayMenu;

        public static class Hook
        {
            private static class API
            {

                //dll imports for hooking and unhooking and sending events trough hook hierarchy

                [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
                public static extern IntPtr SetWindowsHookEx(
                    int idHook,
                    HookDel lpfn,
                    IntPtr hMod,
                    uint dwThreadId);

                [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
                [return: MarshalAs(UnmanagedType.Bool)]
                public static extern bool UnhookWindowsHookEx(
                    IntPtr hhk);

                [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
                public static extern IntPtr CallNextHookEx(
                    IntPtr hhk,
                    int nCode,
                    IntPtr
                    wParam,
                    IntPtr lParam);

                [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
                public static extern IntPtr GetModuleHandle(
                    string lpModuleName);

            }

            public enum VK
            {
                //Keycodes may be found on many internet sites.
                //Some keys are commented feel free to uncomment them, explanations are provided for uncommon ones ;)

                VK_LBUTTON = 0X01, //Left mouse
                VK_RBUTTON = 0X02, //Right mouse
                                   //VK_CANCEL       = 0X03,
                VK_MBUTTON = 0X04,
                VK_BACK = 0X08, //Backspace
                VK_TAB = 0X09,
                //VK_CLEAR        = 0X0C,
                VK_RETURN = 0X0D, //Enter
                VK_SHIFT = 0X10,
                VK_CONTROL = 0X11, //CTRL
                                   //VK_MENU         = 0X12,
                VK_PAUSE = 0X13,
                VK_CAPITAL = 0X14, //Caps-Lock
                VK_ESCAPE = 0X1B,
                VK_SPACE = 0X20,
                VK_PRIOR = 0X21, //Page-Up
                VK_NEXT = 0X22, //Page-Down
                VK_END = 0X23,
                VK_HOME = 0X24,
                VK_LEFT = 0X25,
                VK_UP = 0X26,
                VK_RIGHT = 0X27,
                VK_DOWN = 0X28,
                //VK_SELECT       = 0X29,
                //VK_PRINT        = 0X2A,
                //VK_EXECUTE      = 0X2B,
                VK_SNAPSHOT = 0X2C, //Print Screen
                VK_INSERT = 0X2D,
                VK_DELETE = 0X2E,
                //VK_HELP         = 0X2F,

                VK_0 = 0X30,
                VK_1 = 0X31,
                VK_2 = 0X32,
                VK_3 = 0X33,
                VK_4 = 0X34,
                VK_5 = 0X35,
                VK_6 = 0X36,
                VK_7 = 0X37,
                VK_8 = 0X38,
                VK_9 = 0X39,

                VK_A = 0X41,
                VK_B = 0X42,
                VK_C = 0X43,
                VK_D = 0X44,
                VK_E = 0X45,
                VK_F = 0X46,
                VK_G = 0X47,
                VK_H = 0X48,
                VK_I = 0X49,
                VK_J = 0X4A,
                VK_K = 0X4B,
                VK_L = 0X4C,
                VK_M = 0X4D,
                VK_N = 0X4E,
                VK_O = 0X4F,
                VK_P = 0X50,
                VK_Q = 0X51,
                VK_R = 0X52,
                VK_S = 0X53,
                VK_T = 0X54,
                VK_U = 0X55,
                VK_V = 0X56,
                VK_W = 0X57,
                VK_X = 0X58,
                VK_Y = 0X59,
                VK_Z = 0X5A,

                VK_NUMPAD0 = 0X60,
                VK_NUMPAD1 = 0X61,
                VK_NUMPAD2 = 0X62,
                VK_NUMPAD3 = 0X63,
                VK_NUMPAD4 = 0X64,
                VK_NUMPAD5 = 0X65,
                VK_NUMPAD6 = 0X66,
                VK_NUMPAD7 = 0X67,
                VK_NUMPAD8 = 0X68,
                VK_NUMPAD9 = 0X69,

                VK_SEPERATOR = 0X6C, // | (shift + backslash)
                VK_SUBTRACT = 0X6D, // -
                VK_DECIMAL = 0X6E, // .
                VK_DIVIDE = 0X6F, // /

                VK_F1 = 0X70,
                VK_F2 = 0X71,
                VK_F3 = 0X72,
                VK_F4 = 0X73,
                VK_F5 = 0X74,
                VK_F6 = 0X75,
                VK_F7 = 0X76,
                VK_F8 = 0X77,
                VK_F9 = 0X78,
                VK_F10 = 0X79,
                VK_F11 = 0X7A,
                VK_F12 = 0X7B,
                //and for the 8 people in the world who do, I think they can live without using them

                VK_NUMLOCK = 0X90,
                VK_SCROLL = 0X91, //Scroll-Lock
                VK_LSHIFT = 0XA0,
                VK_RSHIFT = 0XA1,
                VK_LCONTROL = 0XA2,
                VK_RCONTROL = 0XA3,
                //VK_LMENU        = 0XA4,
                //VK_RMENU        = 0XA5,
                //VK_PLAY         = 0XFA,
                //VK_ZOOM         = 0XFB
            } //keycodes
    
            //There are detailed explanations for these functions on MSDNAA and implementations.
            public delegate IntPtr HookDel(
                int nCode,
                IntPtr wParam,
                IntPtr lParam);

            public delegate void KeyHandler(
                IntPtr wParam,
                IntPtr lParam);

            private static IntPtr hhk = IntPtr.Zero;
            private static HookDel hd;
            private static KeyHandler kh;

            //Creation of the hook
            public static void CreateHook(KeyHandler _kh)
            {
                Process _this = Process.GetCurrentProcess();
                ProcessModule mod = _this.MainModule;

                hd = HookFunc;
                kh = _kh;

                //13 is the parameter specifying that we're gonna do a low-level keyboard hook
                hhk = API.SetWindowsHookEx(13, hd, API.GetModuleHandle(mod.ModuleName), 0);

                //MessageBox.Show(Marshal.GetLastWin32Error().ToString()); //for debugging
                //Note that this could be a Console.WriteLine(), as well. I just happened
                //to be debugging this in a Windows Application
            }

            public static bool DestroyHook()
            {
                //to be called when we're done with the hook

                return API.UnhookWindowsHookEx(hhk);
            }

            //called when key is active
            private static IntPtr HookFunc(
                int nCode,
                IntPtr wParam,
                IntPtr lParam)
            {
                int iwParam = wParam.ToInt32();
                //depending on what you want to detect you can either detect keypressed or keyrealased also with  a bit tweaking keyclicked.
                if (nCode >= 0 &&
                    (iwParam == 0x100 ||
                    iwParam == 0x104)) //0x100 = WM_KEYDOWN, 0x104 = WM_SYSKEYDOWN
                    kh(wParam, lParam);

                return API.CallNextHookEx(hhk, nCode, wParam, lParam);
            }
        }

        private static void KeyReaderr(IntPtr wParam, IntPtr lParam)
        {
            int key = Marshal.ReadInt32(lParam);

            Hook.VK vk = (Hook.VK)key;
            if (vk == Hook.VK.VK_BACK)
                HandleKey("back");
            else HandleKey("key");

        }

        private static void HandleKey(string a)
        {
            if (a == "back")
            {
                BackSpace++;
                if (BackSpace == 100)
                {
                    BackSpace = 0;
                    ReminderTiredForm rtf = new ReminderTiredForm();
                    rtf.Show();
                }
            }
            else
                KeyCounter++;
        }

        public MainForm()
        {
            this.Visible = false;
            this.Hide();


            this.ShowInTaskbar = false;
            InitializeComponent();
            Hook.CreateHook(KeyReaderr);

            if (Settings.Default.brightness == true)
            {
                timer_brightness.Enabled = true;
                timer_brightness.Start();
            }
            if(Settings.Default.volume == true)
            {
                timer_volume.Enabled = true;
                timer_volume.Start();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Hide();

            /// GENERATE TRAY MENU
            sysTrayMenu = new ContextMenu();
            if (Settings.Default.is_interested == true)
                sysTrayMenu.MenuItems.Add("Recipe of the Day", GenerateRecipe);
            if (Settings.Default.is_smoker == true)
                sysTrayMenu.MenuItems.Add("Smokes Aday", GenerateSmokes);
            if (Settings.Default.brightness == true)
                sysTrayMenu.MenuItems.Add("Brightness Control", GenerateBrightness);
            
            sysTrayMenu.MenuItems.Add("Statistics", GenerateStatistics);
            sysTrayMenu.MenuItems.Add("Settings", Reset);
            sysTrayMenu.MenuItems.Add("Exit DeskMate", OnExit);

            // Adding menu and showing it
            notifyIcon1.Text = "DeskMate";
            notifyIcon1.ContextMenu = sysTrayMenu;
            notifyIcon1.Visible = true;


        }

        private void Reset(object sender, EventArgs e)
        {
            Settings.Default.is_interested = false;
            Settings.Default.is_smoker = false;
            Settings.Default.brightness = false;
            Settings.Default.volume = false;
            Settings.Default.Save();
            this.Close();
        }

        private void GenerateStatistics(object sender, EventArgs e)
        {
            Statistics s = new Statistics();
            s.Show();
        }


        private void GenerateBrightness(object sender, EventArgs e)
        {
            Brightness b = new Brightness();
            b.Show();
        }


        /// SYS TRAY BUTTONS FUNCTIONS
        private void OnExit(object sender, EventArgs e)
        {
            Properties.Settings.Default.start_loop = false;
            Properties.Settings.Default.Save();
            Application.Exit();
        }
        private void GenerateRecipe(object sender, EventArgs e)
        {
            Recipie r = new Recipie();
            r.Show();
        }
        private void GenerateSmokes(object sender, EventArgs e)
        {
            Smoking sm = new Smoking();
            sm.Show();


        }

        private void reminder_Function()
        {
            ts = DateTime.Now - time;


            ReminderForm reminder_form = new ReminderForm();
            reminder_form.StartPosition = FormStartPosition.Manual;
            //reminder_form.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - reminder_form.Width,
            //                      Screen.PrimaryScreen.WorkingArea.Height - reminder_form.Height);
            reminder_form.Location = new Point(Screen.FromPoint(reminder_form.Location).WorkingArea.Right - reminder_form.Width - 10, 10);
            // reminder_form.Location
            reminder_form.TopMost = true;
            reminder_form.Show();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds = seconds + 1;
            reminder_Function();
        }


        private static void SetGamma(int gamma)
        {
            s_ramp.Red = new ushort[256];
            s_ramp.Green = new ushort[256];
            s_ramp.Blue = new ushort[256];
            for (int i = 1; i < 256; i++)
            {
                s_ramp.Red[i] = s_ramp.Green[i] = s_ramp.Blue[i] =
                    (ushort)(Math.Min(65535, Math.Max(0, Math.Pow((i + 1) / 256.0, gamma * 0.1) * 65535 + 0.5)));
            }
            SetDeviceGammaRamp(GetDC(IntPtr.Zero), ref s_ramp);

        }

        private void timer_brightness_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            //MessageBox.Show(Convert.ToString(dt.TimeOfDay.Hours));
            if (dt.TimeOfDay.Hours >= 18)
            {
                SetGamma(20);
            }
            else
                SetGamma(7);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SetGamma(12);
        }

        private void timer_volume_Tick(object sender, EventArgs e)
        {
            for( int i = 0; i < 5; i++ )
                SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        private void kpmtimer_Tick(object sender, EventArgs e)
        {
            MinutesPassed++;
            kpmtimer.Start();
            min = (float)KeyCounter / MinutesPassed;
            if ((float)KeyCounter / MinutesPassed > 150)
                MessageBox.Show("You are stressed lol");
        }
    }
}
