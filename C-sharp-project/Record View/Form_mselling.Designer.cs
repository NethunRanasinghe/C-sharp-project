namespace C_sharp_project
{
    partial class Form_mselling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_mselling));
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.BTN_mbuymain = new System.Windows.Forms.Button();
            this.BTN_mbuyback = new System.Windows.Forms.Button();
            this.LBL_sellings = new System.Windows.Forms.Label();
            this.BTN_sellingclear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(273, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly selling";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.listBox1.Location = new System.Drawing.Point(96, 167);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(81, 27);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 23;
            this.listBox2.Items.AddRange(new object[] {
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
            this.listBox2.Location = new System.Drawing.Point(238, 167);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(111, 27);
            this.listBox2.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(76, 291);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // BTN_mbuymain
            // 
            this.BTN_mbuymain.BackgroundImage = global::C_sharp_project.Properties.Resources.texture_background;
            this.BTN_mbuymain.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_mbuymain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_mbuymain.Location = new System.Drawing.Point(420, 385);
            this.BTN_mbuymain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_mbuymain.Name = "BTN_mbuymain";
            this.BTN_mbuymain.Size = new System.Drawing.Size(117, 39);
            this.BTN_mbuymain.TabIndex = 14;
            this.BTN_mbuymain.Text = "MAIN MENU";
            this.BTN_mbuymain.UseVisualStyleBackColor = true;
            this.BTN_mbuymain.Click += new System.EventHandler(this.BTN_mbuymain_Click);
            // 
            // BTN_mbuyback
            // 
            this.BTN_mbuyback.BackgroundImage = global::C_sharp_project.Properties.Resources.texture_background;
            this.BTN_mbuyback.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_mbuyback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_mbuyback.Location = new System.Drawing.Point(602, 385);
            this.BTN_mbuyback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_mbuyback.Name = "BTN_mbuyback";
            this.BTN_mbuyback.Size = new System.Drawing.Size(102, 39);
            this.BTN_mbuyback.TabIndex = 13;
            this.BTN_mbuyback.Text = "BACK";
            this.BTN_mbuyback.UseVisualStyleBackColor = true;
            this.BTN_mbuyback.Click += new System.EventHandler(this.BTN_mbuyback_Click);
            // 
            // LBL_sellings
            // 
            this.LBL_sellings.AutoSize = true;
            this.LBL_sellings.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_sellings.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LBL_sellings.Location = new System.Drawing.Point(454, 167);
            this.LBL_sellings.Name = "LBL_sellings";
            this.LBL_sellings.Size = new System.Drawing.Size(101, 23);
            this.LBL_sellings.TabIndex = 16;
            this.LBL_sellings.Text = ".......";
            // 
            // BTN_sellingclear
            // 
            this.BTN_sellingclear.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_sellingclear.ForeColor = System.Drawing.Color.SaddleBrown;
            this.BTN_sellingclear.Location = new System.Drawing.Point(645, 160);
            this.BTN_sellingclear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_sellingclear.Name = "BTN_sellingclear";
            this.BTN_sellingclear.Size = new System.Drawing.Size(90, 34);
            this.BTN_sellingclear.TabIndex = 15;
            this.BTN_sellingclear.Text = "clear";
            this.BTN_sellingclear.UseVisualStyleBackColor = true;
            this.BTN_sellingclear.Click += new System.EventHandler(this.BTN_sellingclear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(399, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Rs.";
            // 
            // Form_mselling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C_sharp_project.Properties.Resources.texture_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBL_sellings);
            this.Controls.Add(this.BTN_sellingclear);
            this.Controls.Add(this.BTN_mbuymain);
            this.Controls.Add(this.BTN_mbuyback);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_mselling";
            this.Text = "Monthly_selling";
            this.Load += new System.EventHandler(this.Form_mselling_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button BTN_mbuymain;
        private System.Windows.Forms.Button BTN_mbuyback;
        private System.Windows.Forms.Label LBL_sellings;
        private System.Windows.Forms.Button BTN_sellingclear;
        private System.Windows.Forms.Label label2;
    }
}