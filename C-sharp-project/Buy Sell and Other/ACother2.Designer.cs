namespace C_sharp_project
{
    partial class ACother2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACother2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PRCD = new System.Windows.Forms.Button();
            this.CLEAR = new System.Windows.Forms.Button();
            this.OTHERdt = new System.Windows.Forms.DateTimePicker();
            this.ESTOTHERcst = new System.Windows.Forms.TextBox();
            this.CSTother = new System.Windows.Forms.TextBox();
            this.INFO = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SRVCE = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(325, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.label1.Size = new System.Drawing.Size(329, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Other Transactions";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SimSun", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(34, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("SimSun", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(34, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Service";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("SimSun", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(34, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(387, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Details regarding the service";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("SimSun", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(34, 358);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Estimated amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("SimSun", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(34, 415);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(387, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Total amount spent / obtained";
            // 
            // PRCD
            // 
            this.PRCD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PRCD.BackgroundImage = global::C_sharp_project.Properties.Resources.texture_background;
            this.PRCD.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PRCD.Location = new System.Drawing.Point(426, 461);
            this.PRCD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PRCD.Name = "PRCD";
            this.PRCD.Size = new System.Drawing.Size(85, 37);
            this.PRCD.TabIndex = 19;
            this.PRCD.Text = "Verify";
            this.PRCD.UseVisualStyleBackColor = false;
            this.PRCD.Click += new System.EventHandler(this.PRCD_Click);
            // 
            // CLEAR
            // 
            this.CLEAR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CLEAR.BackgroundImage = global::C_sharp_project.Properties.Resources.texture_background;
            this.CLEAR.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CLEAR.Location = new System.Drawing.Point(569, 461);
            this.CLEAR.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(85, 37);
            this.CLEAR.TabIndex = 21;
            this.CLEAR.Text = "Clear";
            this.CLEAR.UseVisualStyleBackColor = false;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // OTHERdt
            // 
            this.OTHERdt.CustomFormat = "yyyy-mm-dd";
            this.OTHERdt.Location = new System.Drawing.Point(426, 123);
            this.OTHERdt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.OTHERdt.Name = "OTHERdt";
            this.OTHERdt.Size = new System.Drawing.Size(302, 27);
            this.OTHERdt.TabIndex = 23;
            this.OTHERdt.Value = new System.DateTime(2022, 4, 19, 22, 37, 6, 0);
            // 
            // ESTOTHERcst
            // 
            this.ESTOTHERcst.Location = new System.Drawing.Point(426, 358);
            this.ESTOTHERcst.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ESTOTHERcst.Name = "ESTOTHERcst";
            this.ESTOTHERcst.Size = new System.Drawing.Size(546, 27);
            this.ESTOTHERcst.TabIndex = 26;
            // 
            // CSTother
            // 
            this.CSTother.Location = new System.Drawing.Point(426, 415);
            this.CSTother.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CSTother.Name = "CSTother";
            this.CSTother.Size = new System.Drawing.Size(546, 27);
            this.CSTother.TabIndex = 27;
            // 
            // INFO
            // 
            this.INFO.Location = new System.Drawing.Point(426, 231);
            this.INFO.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.INFO.Name = "INFO";
            this.INFO.Size = new System.Drawing.Size(546, 96);
            this.INFO.TabIndex = 29;
            this.INFO.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::C_sharp_project.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(840, 506);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::C_sharp_project.Properties.Resources.exit;
            this.pictureBox2.Location = new System.Drawing.Point(922, 506);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // SRVCE
            // 
            this.SRVCE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SRVCE.FormattingEnabled = true;
            this.SRVCE.Items.AddRange(new object[] {
            "(1) Purchase of new machinery.",
            "(2) Sale of old machinery.",
            "(3) Repair of machinery."});
            this.SRVCE.Location = new System.Drawing.Point(426, 176);
            this.SRVCE.Name = "SRVCE";
            this.SRVCE.Size = new System.Drawing.Size(546, 28);
            this.SRVCE.TabIndex = 32;
            // 
            // ACother2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C_sharp_project.Properties.Resources.texture_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 572);
            this.Controls.Add(this.SRVCE);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.INFO);
            this.Controls.Add(this.CSTother);
            this.Controls.Add(this.ESTOTHERcst);
            this.Controls.Add(this.OTHERdt);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.PRCD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ACother2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranasingha Saw Mills";
            this.Load += new System.EventHandler(this.ACother2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button PRCD;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.DateTimePicker OTHERdt;
        private System.Windows.Forms.TextBox ESTOTHERcst;
        private System.Windows.Forms.TextBox CSTother;
        private System.Windows.Forms.RichTextBox INFO;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox SRVCE;
    }
}