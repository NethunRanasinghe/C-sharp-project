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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_buyingclear = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LBL_buying = new System.Windows.Forms.Label();
            this.BTN_mbuyback = new System.Windows.Forms.Button();
            this.BTN_mbuymain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 299);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 29;
            this.listBox2.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.listBox2.Location = new System.Drawing.Point(105, 106);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(94, 33);
            this.listBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(286, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Monthly Buying";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BTN_buyingclear
            // 
            this.BTN_buyingclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_buyingclear.Location = new System.Drawing.Point(669, 111);
            this.BTN_buyingclear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_buyingclear.Name = "BTN_buyingclear";
            this.BTN_buyingclear.Size = new System.Drawing.Size(90, 102);
            this.BTN_buyingclear.TabIndex = 9;
            this.BTN_buyingclear.Text = "clear";
            this.BTN_buyingclear.UseVisualStyleBackColor = true;
            this.BTN_buyingclear.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
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
            this.listBox1.Location = new System.Drawing.Point(251, 106);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(102, 33);
            this.listBox1.TabIndex = 4;
            // 
            // LBL_buying
            // 
            this.LBL_buying.AutoSize = true;
            this.LBL_buying.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_buying.Location = new System.Drawing.Point(417, 111);
            this.LBL_buying.Name = "LBL_buying";
            this.LBL_buying.Size = new System.Drawing.Size(163, 29);
            this.LBL_buying.TabIndex = 10;
            this.LBL_buying.Text = "Rs. ...............";
            this.LBL_buying.Click += new System.EventHandler(this.label2_Click);
            // 
            // BTN_mbuyback
            // 
            this.BTN_mbuyback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_mbuyback.Location = new System.Drawing.Point(379, 379);
            this.BTN_mbuyback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_mbuyback.Name = "BTN_mbuyback";
            this.BTN_mbuyback.Size = new System.Drawing.Size(102, 51);
            this.BTN_mbuyback.TabIndex = 11;
            this.BTN_mbuyback.Text = "BACK";
            this.BTN_mbuyback.UseVisualStyleBackColor = true;
            this.BTN_mbuyback.Click += new System.EventHandler(this.BTN_mbuyback_Click);
            // 
            // BTN_mbuymain
            // 
            this.BTN_mbuymain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_mbuymain.Location = new System.Drawing.Point(561, 379);
            this.BTN_mbuymain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_mbuymain.Name = "BTN_mbuymain";
            this.BTN_mbuymain.Size = new System.Drawing.Size(117, 51);
            this.BTN_mbuymain.TabIndex = 12;
            this.BTN_mbuymain.Text = "MAIN MENU";
            this.BTN_mbuymain.UseVisualStyleBackColor = true;
            this.BTN_mbuymain.Click += new System.EventHandler(this.BTN_mbuymain_Click);
            // 
            // Form_mbuying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C_sharp_project.Properties.Resources._98c8ddb18b1311c90f9e56e08ad7358d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.BTN_mbuymain);
            this.Controls.Add(this.BTN_mbuyback);
            this.Controls.Add(this.LBL_buying);
            this.Controls.Add(this.BTN_buyingclear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_mbuying";
            this.Text = "monthly_buying";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button BTN_mbuyback;
        private System.Windows.Forms.Button BTN_mbuymain;
    }
}

