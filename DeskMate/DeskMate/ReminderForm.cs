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
using Plasmoid.Extensions;
using System.Drawing.Text;
using DeskMate.Properties;

namespace DeskMate
{

    public partial class ReminderForm : Form
    {
        public int x = 3;
        public string[] stretch = new string[5];
        

        //IMport for rounded corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public ReminderForm()
        {
            this.ShowInTaskbar = false;
            InitializeComponent();
            // show seconds 

            label2.Text = "You have been sitting down for " + Convert.ToString(MainForm.seconds) + " minutes.";            /*
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(brush);
            System.Drawing.Graphics g = this.CreateGraphics();
            g.DrawRoundedRectangle(pen, 85, 20, 400, 150, 35);
            */

            //rounded edges


            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("../../Champagne & Limousines Bold.ttf");
            label1.Font = new Font(pfc.Families[0], 12, FontStyle.Bold);
            label2.Font = new Font(pfc.Families[0], 12, FontStyle.Bold);

            button1.Font = new Font(pfc.Families[0], 12, FontStyle.Bold);
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;

            button2.Font = new Font(pfc.Families[0], 12, FontStyle.Bold);
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;


            stretch[0] = ", do 20 crunches!";
            stretch[1] = ", do 20 stand up and sit downs!";
            stretch[2] = ", shrug your shoulders!";
            stretch[3] = ", go up and down the stairs!";
            stretch[4] = ", do 20 squats!";
            Random r = new Random();
            int rInt = r.Next(0, 4);
            label1.Text = Settings.Default.name + stretch[rInt];
            label1.Visible = true;

        }

        private void timer_counter_Tick(object sender, EventArgs e)
        {
            x = Convert.ToInt32(Convert.ToString(Convert.ToInt32(Convert.ToString(x))));
            if (x - 1 == 0)
                this.Close();
            else
                x--;
        }

        private void ReminderForm_MouseHover(object sender, EventArgs e)
        {
            this.Opacity = 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.seconds = 0;
            this.Close();

        }

    }
}

