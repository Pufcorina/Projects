using DeskMate.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeskMate
{
    public partial class Start : Form
    {
        public Start()
        {
            this.ShowInTaskbar = false;
            InitializeComponent();
            nameBox.Text = "Input name";

            exit_button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            exit_button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            exit_button.FlatAppearance.MouseDownBackColor = Color.Transparent;

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("../../Champagne & Limousines.ttf");
            nameBox.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
            is_smoker.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
            is_interested.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
            checkBox_brightness.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
            checkBox_volume.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
            checkBox_sugestions.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Settings.Default.name = nameBox.Text;
            Settings.Default.is_smoker = is_smoker.Checked;
            Settings.Default.is_interested = is_interested.Checked;
            Settings.Default.brightness = checkBox_brightness.Checked;
            Settings.Default.volume = checkBox_volume.Checked;
            Settings.Default.Save();
            this.Close();
        }


        private void nameBox_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "Input name")
                nameBox.Text = "";
        }
    }
}
