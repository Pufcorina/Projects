using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace DeskMate
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("../../Champagne & Limousines.ttf");
            label1.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
            label2.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
            label3.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
            label4.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
            label5.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
            label6.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
            label4.Text = MainForm.min.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
