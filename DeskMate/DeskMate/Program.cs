using DeskMate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeskMate
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Properties.Settings.Default.start_loop = true;
            Properties.Settings.Default.Save();
            while (Properties.Settings.Default.start_loop == true)
            {
                if (Properties.Settings.Default.FirstRun == true)
                            {
                                Start start_form = new Start();
                                start_form.ShowDialog();
                                Properties.Settings.Default["FirstRun"] = true;
                                Properties.Settings.Default.Save();
                            }
            
                            Application.Run(new MainForm());
            }

        }
    }
}
