namespace C_sharp_project
{
    partial class Form_mbuying
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_mbuying));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_buyingclear = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LBL_buying = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mbuy_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mbuy_back)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(110, 319);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(11, 14, 11, 14);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 28;
            this.listBox2.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.listBox2.Location = new System.Drawing.Point(110, 198);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(116, 32);
            this.listBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(260, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 67);
            this.label1.TabIndex = 7;
            this.label1.Text = "Monthly Buying";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BTN_buyingclear
            // 
            this.BTN_buyingclear.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_buyingclear.ForeColor = System.Drawing.Color.SaddleBrown;
            this.BTN_buyingclear.Location = new System.Drawing.Point(734, 189);
            this.BTN_buyingclear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_buyingclear.Name = "BTN_buyingclear";
            this.BTN_buyingclear.Size = new System.Drawing.Size(112, 42);
            this.BTN_buyingclear.TabIndex = 9;
            this.BTN_buyingclear.Text = "clear";
            this.BTN_buyingclear.UseVisualStyleBackColor = true;
            this.BTN_buyingclear.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "June",
            "July",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.listBox1.Location = new System.Drawing.Point(310, 196);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(126, 32);
            this.listBox1.TabIndex = 4;
            // 
            // LBL_buying
            // 
            this.LBL_buying.AutoSize = true;
            this.LBL_buying.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_buying.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LBL_buying.Location = new System.Drawing.Point(535, 196);
            this.LBL_buying.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_buying.Name = "LBL_buying";
            this.LBL_buying.Size = new System.Drawing.Size(132, 28);
            this.LBL_buying.TabIndex = 10;
            this.LBL_buying.Text = "........";
            this.LBL_buying.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(466, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Rs.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::C_sharp_project.Properties.Resources.exit;
            this.pictureBox1.Location = new System.Drawing.Point(796, 528);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mbuy_back
            // 
            this.mbuy_back.BackColor = System.Drawing.Color.Transparent;
            this.mbuy_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mbuy_back.Image = global::C_sharp_project.Properties.Resources.back;
            this.mbuy_back.Location = new System.Drawing.Point(699, 528);
            this.mbuy_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mbuy_back.Name = "mbuy_back";
            this.mbuy_back.Size = new System.Drawing.Size(50, 50);
            this.mbuy_back.TabIndex = 20;
            this.mbuy_back.TabStop = false;
            this.mbuy_back.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form_mbuying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C_sharp_project.Properties.Resources.texture_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 616);
            this.Controls.Add(this.mbuy_back);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBL_buying);
            this.Controls.Add(this.BTN_buyingclear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_mbuying";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "monthly_buying";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mbuy_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_buyingclear;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label LBL_buying;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox mbuy_back;
    }
}

