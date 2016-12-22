using DeskMate.Properties;
//using Recipe_form.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipe_form
{
    public partial class Recipie : Form
    {
        public int generated_meal = -1;
        public int generated_desert = -1;
        public int food_type = 1; //1 = meal, 2 = desert
        public struct meal
        {
            public string name, link, img_name;
            public Image img;
        }
        meal[] meals = new meal[9];
        public int meals_len = 0;

        public struct desert
        {
            public string name, link, img_name;
            public Image img;
        }
        desert[] deserts = new desert[9];
        public int deserts_len = 0;

        void init()
        {
            get_desert.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            view_past_recipes.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            view_past_recipes.FlatAppearance.MouseOverBackColor = Color.Transparent;
            view_past_recipes.FlatAppearance.MouseDownBackColor = Color.Transparent;

            GraphicsPath gp = new GraphicsPath();
            //gp.AddEllipse(new Rectangle(0, 0, 160, 160));
            gp.AddEllipse(food_picture.DisplayRectangle);
            food_picture.Region = new Region(gp);

            ///MEALS
            try
            {
                StreamReader sr = new StreamReader("meals.txt");
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] the_line;
                    the_line = line.Split(',');
                    meals[meals_len].name = the_line[0];
                    meals[meals_len].img = (Image)Resources.ResourceManager.GetObject(the_line[1]);
                    meals[meals_len].img_name = the_line[1];
                    meals[meals_len++].link = the_line[2];
                }
                sr.Close();
            }

            catch (FileNotFoundException)
            {
                StreamWriter sw = new StreamWriter("meals.txt");
                sw.Close();
            }

            ///deserts
            try
            {
                StreamReader sr = new StreamReader("deserts.txt");
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] the_line;
                    the_line = line.Split(',');
                    deserts[deserts_len].name = the_line[0];
                    deserts[deserts_len].img = (Image)Resources.ResourceManager.GetObject(the_line[1]);
                    deserts[deserts_len].img_name = the_line[1];
                    deserts[deserts_len++].link = the_line[2];
                }
                sr.Close();
            }

            catch (FileNotFoundException)
            {
                StreamWriter sw = new StreamWriter("meals.txt");
                sw.Close();
            }

        }
        public Recipie()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init();
            if (Settings.Default.first_run == true)
            {
                food_type = 1;
                Random r = new Random();
                int rInt = r.Next(0, meals_len);
                generated_meal = rInt;
                food_picture.Image = meals[rInt].img;
                food_text.Text = meals[rInt].name;
                Settings.Default.first_run = false;
                Settings.Default.rInt = rInt;
                Settings.Default.Save();
            }
            else
            {
                food_type = 1;
                generated_meal = Settings.Default.rInt;
                food_picture.Image = meals[Settings.Default.rInt].img;
                food_text.Text = meals[Settings.Default.rInt].name;
            }

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("../../Champagne & Limousines.ttf");
            food_text.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);

            if (meals_len > 1)
            {
                unlike.Enabled = true;
                unlike.Visible = true;
            }
            else
            {
                unlike.Enabled = false;
                unlike.Visible = false;
            }
        }

        private void get_desert_Click(object sender, EventArgs e)
        {
            food_type = 2;
            Random r = new Random();
            int rInt = r.Next(0, deserts_len);
            generated_desert = rInt;
            food_picture.Image = deserts[rInt].img;
            food_text.Text = deserts[rInt].name;

            if (deserts_len == 1)
            {
                unlike.Enabled = false;
                unlike.Visible = false;
            }
            else
            {
                unlike.Enabled = true;
                unlike.Visible = true;
            }
        }

        private void unlike_Click(object sender, EventArgs e)
        {
            if (food_type == 1 && meals_len > 1)
            {
                for (int i = generated_meal; i < meals_len; i++)
                    meals[i] = meals[i + 1];
                meals_len--;

                //try except
                Random r = new Random();
                int rInt = r.Next(0, meals_len);
                Settings.Default.rInt = rInt;
                generated_meal = Settings.Default.rInt;
                food_picture.Image = meals[Settings.Default.rInt].img;
                food_text.Text = meals[Settings.Default.rInt].name;
                food_picture.Image = meals[Settings.Default.rInt].img;
                food_text.Text = meals[Settings.Default.rInt].name;
                Settings.Default.Save();
            }
            if (food_type == 1 && meals_len == 1)
            {
                unlike.Visible = false;
                unlike.Enabled = false;
            }

            else if (food_type == 2 && deserts_len > 1)
            {
                for (int i = generated_desert; i < deserts_len; i++)
                    deserts[i] = deserts[i + 1];
                deserts_len--;

                //try except
                Random r = new Random();
                int rInt = r.Next(0, deserts_len);
                generated_desert = rInt;
                food_picture.Image = deserts[rInt].img;
                food_text.Text = deserts[rInt].name;

            }
            if (food_type == 2 && deserts_len == 1)
            {
                unlike.Visible = false;
                unlike.Enabled = false;
            }
        }

        private void like_Click(object sender, EventArgs e)
        {
            if (food_type == 1)
            {
                bool OK = true;
                try
                {
                    StreamReader sr = new StreamReader("liked_meals.txt");
                    string line = null;
                    while ((line = sr.ReadLine()) != null)
                        if (line == meals[generated_meal].name)
                        {
                            OK = false;
                            break;
                        }
                    sr.Close();
                }

                catch (FileNotFoundException)
                {
                    StreamWriter sw = new StreamWriter("liked_meals.txt");
                    sw.Close();
                }


                if (OK == true)
                {
                    StreamWriter sw = new StreamWriter("liked_meals.txt", true);
                    sw.WriteLine(String.Format("{0}\n", meals[generated_meal].name));
                    sw.Close();
                }
                PopulateList("liked_meals.txt");
                }

            else
            {
                bool OK = true;
                try
                {
                    StreamReader sr = new StreamReader("liked_meals.txt");
                    string line = null;
                    while ((line = sr.ReadLine()) != null)
                        if (line == deserts[generated_desert].name)
                        {
                            OK = false;
                            break;
                        }
                    sr.Close();
                }

                catch (FileNotFoundException)
                {
                    StreamWriter sw = new StreamWriter("liked_meals.txt");
                    sw.Close();
                }


                if (OK == true)
                {
                    StreamWriter sw = new StreamWriter("liked_meals.txt", true);
                    sw.WriteLine(String.Format("{0}\n", deserts[generated_desert].name));
                    sw.Close();
                }
                
            }
            
            
        }

        private void PopulateList(string filePath)
        {
            listBox1.Items.Clear();
            var items = new List<string>();
            using (var stream = File.OpenRead(filePath))  // open file
            using (var reader = new StreamReader(stream))   // read the stream with TextReader
            {
                string line;

                // read until no more lines are present
                while ((line = reader.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }
            }

            // add the ListBox items in a bulk update instead of one at a time.
            
        }
        private void view_past_recipes_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(898, 487);
            PopulateList("liked_meals.txt");
        }

        private void Recipie_Leave(object sender, EventArgs e)
        {
            
        }

        private void Recipie_FormClosed(object sender, FormClosedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("meals.txt");
            for (int i = 0; i < meals_len; i++)
            {
                sw.WriteLine(meals[i].name + "," + meals[i].img_name + "," + meals[i].link + ",");
            }
            sw.Close();

            StreamWriter dw = new StreamWriter("deserts.txt");
            for (int i = 0; i < deserts_len; i++)
            {
                dw.WriteLine(deserts[i].name + "," + deserts[i].img_name + "," + deserts[i].link + ",");
            }
            dw.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();


            for (int i = 0; i < meals_len; i++)
                if (curItem == meals[i].name)
                    System.Diagnostics.Process.Start(meals[i].link);


            for (int i = 0; i < deserts_len; i++)
                if (curItem == deserts[i].name)
                    System.Diagnostics.Process.Start(deserts[i].link);
        }
    }
}
