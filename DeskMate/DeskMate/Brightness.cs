using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DeskMate
{
    public partial class Brightness : Form
    {

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


        public Brightness()
        {
            InitializeComponent();
            this.trackBar1.Maximum = 60;
            this.trackBar1.Minimum = 21;
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar1.RightToLeftLayout = true;
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 39;
            this.trackBar1.ValueChanged += new System.EventHandler(this.HandleValueChanged);
        }
        private void HandleValueChanged(object sender, EventArgs e)
        {
            SetGamma(trackBar1.Value / 3);
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
    }
}
