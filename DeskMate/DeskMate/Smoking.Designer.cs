namespace DeskMate
{
    partial class Smoking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Smoking));
            this.done = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer_reminder = new System.Windows.Forms.Timer(this.components);
            this.dataSet1 = new DeskMate.DataSet1();
            this.smokingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smokingTableAdapter = new DeskMate.DataSet1TableAdapters.SmokingTableAdapter();
            this.separator = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smokingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).BeginInit();
            this.SuspendLayout();
            // 
            // done
            // 
            this.done.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("done.BackgroundImage")));
            this.done.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.done.Location = new System.Drawing.Point(119, 104);
            this.done.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(73, 34);
            this.done.TabIndex = 0;
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // timer_reminder
            // 
            this.timer_reminder.Enabled = true;
            this.timer_reminder.Interval = 100000;
            this.timer_reminder.Tick += new System.EventHandler(this.timer_reminder_Tick);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // smokingBindingSource
            // 
            this.smokingBindingSource.DataMember = "Smoking";
            this.smokingBindingSource.DataSource = this.dataSet1;
            // 
            // smokingTableAdapter
            // 
            this.smokingTableAdapter.ClearBeforeFill = true;
            // 
            // separator
            // 
            this.separator.Image = ((System.Drawing.Image)(resources.GetObject("separator.Image")));
            this.separator.Location = new System.Drawing.Point(9, 80);
            this.separator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(286, 5);
            this.separator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.separator.TabIndex = 5;
            this.separator.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(9, 42);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 28);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Input avg";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 2435;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Smoking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(309, 186);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.done);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Smoking";
            this.Load += new System.EventHandler(this.Smoking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smokingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer_reminder;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource smokingBindingSource;
        private DataSet1TableAdapters.SmokingTableAdapter smokingTableAdapter;
        private System.Windows.Forms.PictureBox separator;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}