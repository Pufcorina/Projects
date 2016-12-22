namespace DeskMate
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.exit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_counter = new System.Windows.Forms.Timer(this.components);
            this.nameBox = new System.Windows.Forms.TextBox();
            this.is_smoker = new System.Windows.Forms.CheckBox();
            this.is_interested = new System.Windows.Forms.CheckBox();
            this.separator = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.checkBox_brightness = new System.Windows.Forms.CheckBox();
            this.checkBox_volume = new System.Windows.Forms.CheckBox();
            this.checkBox_sugestions = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_button.BackgroundImage")));
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Location = new System.Drawing.Point(492, 342);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(78, 33);
            this.exit_button.TabIndex = 0;
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.LightGray;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Location = new System.Drawing.Point(25, 44);
            this.nameBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(286, 28);
            this.nameBox.TabIndex = 1;
            this.nameBox.Click += new System.EventHandler(this.nameBox_Click);
            // 
            // is_smoker
            // 
            this.is_smoker.BackColor = System.Drawing.Color.Transparent;
            this.is_smoker.FlatAppearance.BorderSize = 0;
            this.is_smoker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.is_smoker.Location = new System.Drawing.Point(25, 84);
            this.is_smoker.Margin = new System.Windows.Forms.Padding(2);
            this.is_smoker.Name = "is_smoker";
            this.is_smoker.Size = new System.Drawing.Size(286, 50);
            this.is_smoker.TabIndex = 4;
            this.is_smoker.Text = "Smoker";
            this.is_smoker.UseVisualStyleBackColor = false;
            // 
            // is_interested
            // 
            this.is_interested.BackColor = System.Drawing.Color.Transparent;
            this.is_interested.FlatAppearance.BorderSize = 0;
            this.is_interested.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.is_interested.Location = new System.Drawing.Point(25, 120);
            this.is_interested.Margin = new System.Windows.Forms.Padding(2);
            this.is_interested.Name = "is_interested";
            this.is_interested.Size = new System.Drawing.Size(286, 71);
            this.is_interested.TabIndex = 5;
            this.is_interested.Text = "Interested in recipes";
            this.is_interested.UseVisualStyleBackColor = false;
            // 
            // separator
            // 
            this.separator.Image = ((System.Drawing.Image)(resources.GetObject("separator.Image")));
            this.separator.Location = new System.Drawing.Point(25, 75);
            this.separator.Margin = new System.Windows.Forms.Padding(2);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(286, 5);
            this.separator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.separator.TabIndex = 3;
            this.separator.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(419, 13);
            this.Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(151, 135);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 6;
            this.Logo.TabStop = false;
            // 
            // checkBox_brightness
            // 
            this.checkBox_brightness.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_brightness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_brightness.Location = new System.Drawing.Point(25, 168);
            this.checkBox_brightness.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_brightness.Name = "checkBox_brightness";
            this.checkBox_brightness.Size = new System.Drawing.Size(211, 71);
            this.checkBox_brightness.TabIndex = 5;
            this.checkBox_brightness.Text = "Brightness control";
            this.checkBox_brightness.UseVisualStyleBackColor = false;
            // 
            // checkBox_volume
            // 
            this.checkBox_volume.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_volume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_volume.Location = new System.Drawing.Point(25, 215);
            this.checkBox_volume.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_volume.Name = "checkBox_volume";
            this.checkBox_volume.Size = new System.Drawing.Size(211, 71);
            this.checkBox_volume.TabIndex = 7;
            this.checkBox_volume.Text = "Volume control";
            this.checkBox_volume.UseVisualStyleBackColor = false;
            // 
            // checkBox_sugestions
            // 
            this.checkBox_sugestions.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_sugestions.Checked = true;
            this.checkBox_sugestions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_sugestions.Location = new System.Drawing.Point(25, 273);
            this.checkBox_sugestions.Name = "checkBox_sugestions";
            this.checkBox_sugestions.Size = new System.Drawing.Size(211, 71);
            this.checkBox_sugestions.TabIndex = 8;
            this.checkBox_sugestions.Text = "Streching Sugestions";
            this.checkBox_sugestions.UseVisualStyleBackColor = false;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(586, 387);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox_sugestions);
            this.Controls.Add(this.checkBox_volume);
            this.Controls.Add(this.checkBox_brightness);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.is_interested);
            this.Controls.Add(this.is_smoker);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            ((System.ComponentModel.ISupportInitialize)(this.separator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_counter;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.PictureBox separator;
        private System.Windows.Forms.CheckBox is_smoker;
        private System.Windows.Forms.CheckBox is_interested;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.CheckBox checkBox_brightness;
        private System.Windows.Forms.CheckBox checkBox_volume;
        private System.Windows.Forms.CheckBox checkBox_sugestions;
    }
}