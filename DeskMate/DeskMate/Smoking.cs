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
    public partial class Smoking : Form
    {
        public DateTime time = DateTime.Now;
        private void reminder_Function()
        {
            TimeSpan ts = DateTime.Now - time;
            ReminderForm reminder_form = new ReminderForm();
            reminder_form.StartPosition = FormStartPosition.Manual;
            reminder_form.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - reminder_form.Width,
                                   Screen.PrimaryScreen.WorkingArea.Height - reminder_form.Height);
            reminder_form.TopMost = true;
            reminder_form.Show();
        }
        public Smoking()
        {
            InitializeComponent();
            smokingTableAdapter.GetDataByDaySorted();
            int avgr = 0;
            int cnt = 0;
            for (int i = 0; i < smokingTableAdapter.GetDataByDaySorted().Count; i++)
            {
                if (smokingTableAdapter.GetDataByDaySorted()[i] != null)
                {
                    cnt++;
                    int value = Convert.ToInt32(smokingTableAdapter.GetDataByDaySorted().Rows[i][2]);
                    avgr += value;
                }
            }
            float avg_week = 0;
            if (smokingTableAdapter.GetDataByDaySorted().Count != 0 && smokingTableAdapter.GetDataByDaySorted().Count < 7)
            {
                avg_week = avgr / cnt;
            }
            else
            {
                for (int i = 0; i < 7; i++)
                {
                    if (smokingTableAdapter.GetDataByDaySorted()[i] != null)
                    {
                        int value = Convert.ToInt32(smokingTableAdapter.GetDataByDaySorted().Rows[i][2]);
                        avg_week += value;
                    }
                }
            }
            float avg = avgr / cnt;
            label1.Text = Convert.ToString(avg);
            label2.Text = Convert.ToString(avg_week);
            done.Enabled = true;
            DateTime time = DateTime.Now;
            if (smokingTableAdapter.GetDataByDay(time.ToString()).Rows.Count == 1)
            {
                done.Enabled = false;
            }
        }

        private void Smoking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Smoking' table. You can move, or remove it, as needed.
            this.smokingTableAdapter.Fill(this.dataSet1.Smoking);

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("../../Champagne & Limousines.ttf");
            textBox1.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
        }

        private void timer_reminder_Tick(object sender, EventArgs e)
        {
            reminder_Function();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            smokingTableAdapter.insert_NumberOfCigaretts(Convert.ToString(DateTime.Now), Convert.ToInt32(textBox1.Text));
            smokingTableAdapter.Update(this.dataSet1.Smoking);
            smokingTableAdapter.Fill(this.dataSet1.Smoking);
            smokingTableAdapter.GetDataByDaySorted();
            int avgr = 0;
            int cnt = 0;
            for (int i = 0; i < smokingTableAdapter.GetDataByDaySorted().Count; i++)
            {
                if (smokingTableAdapter.GetDataByDaySorted()[i] != null)
                {
                    cnt++;
                    int value = Convert.ToInt32(smokingTableAdapter.GetDataByDaySorted().Rows[i][2]);
                    avgr += value;
                }
            }
            float avg_week = 0;
            if (smokingTableAdapter.GetDataByDaySorted().Count < 7)
            {
                avg_week = avgr / cnt;
            }
            else
            {
                for (int i = 0; i < 7; i++)
                {
                    if (smokingTableAdapter.GetDataByDaySorted()[i] != null)
                    {
                        int value = Convert.ToInt32(smokingTableAdapter.GetDataByDaySorted().Rows[i][2]);
                        avg_week += value;
                    }
                }
            }
            float avg = avgr / cnt;
            label1.Text = Convert.ToString(avg);
            label2.Text = Convert.ToString(avg_week);

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("../../Champagne & Limousines Bold.ttf");
            label3.Font = new Font(pfc.Families[0], 10, FontStyle.Bold);
            label3.Visible = true;
            label3.Text = "You have smoked 3 cigarettes less than avg.";

            done.Enabled = false;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
