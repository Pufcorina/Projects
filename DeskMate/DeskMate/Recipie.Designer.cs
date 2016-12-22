namespace Recipe_form
{
    partial class Recipie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recipie));
            this.food_text = new System.Windows.Forms.Label();
            this.unlike = new System.Windows.Forms.PictureBox();
            this.like = new System.Windows.Forms.PictureBox();
            this.food_picture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.separator = new System.Windows.Forms.PictureBox();
            this.view_past_recipes = new System.Windows.Forms.Button();
            this.get_desert = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.unlike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.like)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).BeginInit();
            this.SuspendLayout();
            // 
            // food_text
            // 
            this.food_text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.food_text.Location = new System.Drawing.Point(190, 241);
            this.food_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.food_text.Name = "food_text";
            this.food_text.Size = new System.Drawing.Size(218, 36);
            this.food_text.TabIndex = 5;
            this.food_text.Text = "text";
            this.food_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unlike
            // 
            this.unlike.Image = ((System.Drawing.Image)(resources.GetObject("unlike.Image")));
            this.unlike.InitialImage = null;
            this.unlike.Location = new System.Drawing.Point(381, 296);
            this.unlike.Margin = new System.Windows.Forms.Padding(2);
            this.unlike.Name = "unlike";
            this.unlike.Size = new System.Drawing.Size(51, 47);
            this.unlike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unlike.TabIndex = 7;
            this.unlike.TabStop = false;
            this.unlike.Click += new System.EventHandler(this.unlike_Click);
            // 
            // like
            // 
            this.like.Image = ((System.Drawing.Image)(resources.GetObject("like.Image")));
            this.like.InitialImage = null;
            this.like.Location = new System.Drawing.Point(183, 296);
            this.like.Margin = new System.Windows.Forms.Padding(2);
            this.like.Name = "like";
            this.like.Size = new System.Drawing.Size(51, 47);
            this.like.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.like.TabIndex = 6;
            this.like.TabStop = false;
            this.like.Click += new System.EventHandler(this.like_Click);
            // 
            // food_picture
            // 
            this.food_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.food_picture.InitialImage = null;
            this.food_picture.Location = new System.Drawing.Point(218, 43);
            this.food_picture.Margin = new System.Windows.Forms.Padding(2);
            this.food_picture.Name = "food_picture";
            this.food_picture.Size = new System.Drawing.Size(164, 163);
            this.food_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.food_picture.TabIndex = 3;
            this.food_picture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(204, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // separator
            // 
            this.separator.Image = ((System.Drawing.Image)(resources.GetObject("separator.Image")));
            this.separator.Location = new System.Drawing.Point(64, 365);
            this.separator.Margin = new System.Windows.Forms.Padding(2);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(479, 3);
            this.separator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.separator.TabIndex = 2;
            this.separator.TabStop = false;
            // 
            // view_past_recipes
            // 
            this.view_past_recipes.BackColor = System.Drawing.Color.Transparent;
            this.view_past_recipes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("view_past_recipes.BackgroundImage")));
            this.view_past_recipes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.view_past_recipes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_past_recipes.Location = new System.Drawing.Point(432, 387);
            this.view_past_recipes.Margin = new System.Windows.Forms.Padding(2);
            this.view_past_recipes.Name = "view_past_recipes";
            this.view_past_recipes.Size = new System.Drawing.Size(135, 47);
            this.view_past_recipes.TabIndex = 1;
            this.view_past_recipes.UseVisualStyleBackColor = false;
            this.view_past_recipes.Click += new System.EventHandler(this.view_past_recipes_Click);
            // 
            // get_desert
            // 
            this.get_desert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("get_desert.BackgroundImage")));
            this.get_desert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.get_desert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.get_desert.Location = new System.Drawing.Point(41, 387);
            this.get_desert.Margin = new System.Windows.Forms.Padding(2);
            this.get_desert.Name = "get_desert";
            this.get_desert.Size = new System.Drawing.Size(135, 47);
            this.get_desert.TabIndex = 0;
            this.get_desert.UseVisualStyleBackColor = true;
            this.get_desert.Click += new System.EventHandler(this.get_desert_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(603, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(262, 329);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Recipie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 448);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.unlike);
            this.Controls.Add(this.like);
            this.Controls.Add(this.food_text);
            this.Controls.Add(this.food_picture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.view_past_recipes);
            this.Controls.Add(this.get_desert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Recipie";
            this.Text = "Recipes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Recipie_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Recipie_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.unlike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.like)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button get_desert;
        private System.Windows.Forms.Button view_past_recipes;
        private System.Windows.Forms.PictureBox separator;
        private System.Windows.Forms.PictureBox food_picture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label food_text;
        private System.Windows.Forms.PictureBox like;
        private System.Windows.Forms.PictureBox unlike;
        private System.Windows.Forms.ListBox listBox1;
    }
}

