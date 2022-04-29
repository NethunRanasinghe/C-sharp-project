namespace C_sharp_project
{
    partial class form_sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_sales));
            this.Lbl_user = new System.Windows.Forms.Label();
            this.LBL_salesrecords = new System.Windows.Forms.Label();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.BTN_sumbit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sales_usrn = new System.Windows.Forms.Label();
            this.TXTBX_otherservices = new System.Windows.Forms.TextBox();
            this.TXTBX_extra = new System.Windows.Forms.TextBox();
            this.TXTBX_other = new System.Windows.Forms.TextBox();
            this.TXTBX_estimation = new System.Windows.Forms.TextBox();
            this.TXTBX_woodtype = new System.Windows.Forms.TextBox();
            this.TXTBX_Producttype = new System.Windows.Forms.TextBox();
            this.TXTBX_Cname = new System.Windows.Forms.TextBox();
            this.LBL_extracharges = new System.Windows.Forms.Label();
            this.LBL_additionalcharges = new System.Windows.Forms.Label();
            this.LBL_other = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LBL_estimation = new System.Windows.Forms.Label();
            this.LBL_woodtype = new System.Windows.Forms.Label();
            this.LBL_Producttype = new System.Windows.Forms.Label();
            this.LBL_cname = new System.Windows.Forms.Label();
            this.LBL_sales = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_user
            // 
            this.Lbl_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_user.AutoSize = true;
            this.Lbl_user.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_user.Cursor = System.Windows.Forms.Cursors.No;
            this.Lbl_user.Font = new System.Drawing.Font("SimSun-ExtB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_user.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Lbl_user.Location = new System.Drawing.Point(123, 101);
            this.Lbl_user.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_user.Name = "Lbl_user";
            this.Lbl_user.Size = new System.Drawing.Size(137, 37);
            this.Lbl_user.TabIndex = 16;
            this.Lbl_user.Text = "User :";
            // 
            // LBL_salesrecords
            // 
            this.LBL_salesrecords.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBL_salesrecords.AutoSize = true;
            this.LBL_salesrecords.BackColor = System.Drawing.Color.Transparent;
            this.LBL_salesrecords.Cursor = System.Windows.Forms.Cursors.No;
            this.LBL_salesrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_salesrecords.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LBL_salesrecords.Location = new System.Drawing.Point(377, 19);
            this.LBL_salesrecords.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_salesrecords.Name = "LBL_salesrecords";
            this.LBL_salesrecords.Size = new System.Drawing.Size(344, 57);
            this.LBL_salesrecords.TabIndex = 15;
            this.LBL_salesrecords.Text = "Sales Records";
            this.LBL_salesrecords.Click += new System.EventHandler(this.LBL_salesrecords_Click);
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Clear.AutoSize = true;
            this.BTN_Clear.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Clear.BackgroundImage = global::C_sharp_project.Properties.Resources.texture_background;
            this.BTN_Clear.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Clear.ForeColor = System.Drawing.Color.Snow;
            this.BTN_Clear.Location = new System.Drawing.Point(475, 791);
            this.BTN_Clear.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(133, 52);
            this.BTN_Clear.TabIndex = 21;
            this.BTN_Clear.Text = "Clear";
            this.BTN_Clear.UseVisualStyleBackColor = false;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // BTN_sumbit
            // 
            this.BTN_sumbit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_sumbit.AutoSize = true;
            this.BTN_sumbit.BackColor = System.Drawing.Color.White;
            this.BTN_sumbit.BackgroundImage = global::C_sharp_project.Properties.Resources.texture_background;
            this.BTN_sumbit.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_sumbit.ForeColor = System.Drawing.Color.Snow;
            this.BTN_sumbit.Location = new System.Drawing.Point(741, 791);
            this.BTN_sumbit.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_sumbit.Name = "BTN_sumbit";
            this.BTN_sumbit.Size = new System.Drawing.Size(133, 52);
            this.BTN_sumbit.TabIndex = 22;
            this.BTN_sumbit.Text = "Sumbit";
            this.BTN_sumbit.UseVisualStyleBackColor = false;
            this.BTN_sumbit.Click += new System.EventHandler(this.BTN_sumbit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::C_sharp_project.Properties.Resources.exit;
            this.pictureBox1.Location = new System.Drawing.Point(968, 893);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::C_sharp_project.Properties.Resources.back;
            this.pictureBox2.Location = new System.Drawing.Point(875, 893);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // sales_usrn
            // 
            this.sales_usrn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sales_usrn.AutoSize = true;
            this.sales_usrn.BackColor = System.Drawing.Color.Transparent;
            this.sales_usrn.Font = new System.Drawing.Font("Arial Narrow", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sales_usrn.Location = new System.Drawing.Point(268, 111);
            this.sales_usrn.Name = "sales_usrn";
            this.sales_usrn.Size = new System.Drawing.Size(46, 26);
            this.sales_usrn.TabIndex = 26;
            this.sales_usrn.Text = "Null";
            this.sales_usrn.Click += new System.EventHandler(this.sales_usrn_Click);
            // 
            // TXTBX_otherservices
            // 
            this.TXTBX_otherservices.Location = new System.Drawing.Point(606, 532);
            this.TXTBX_otherservices.Margin = new System.Windows.Forms.Padding(5);
            this.TXTBX_otherservices.Multiline = true;
            this.TXTBX_otherservices.Name = "TXTBX_otherservices";
            this.TXTBX_otherservices.Size = new System.Drawing.Size(268, 89);
            this.TXTBX_otherservices.TabIndex = 45;
            // 
            // TXTBX_extra
            // 
            this.TXTBX_extra.Location = new System.Drawing.Point(606, 730);
            this.TXTBX_extra.Margin = new System.Windows.Forms.Padding(5);
            this.TXTBX_extra.Name = "TXTBX_extra";
            this.TXTBX_extra.Size = new System.Drawing.Size(268, 27);
            this.TXTBX_extra.TabIndex = 44;
            // 
            // TXTBX_other
            // 
            this.TXTBX_other.Location = new System.Drawing.Point(606, 663);
            this.TXTBX_other.Margin = new System.Windows.Forms.Padding(5);
            this.TXTBX_other.Name = "TXTBX_other";
            this.TXTBX_other.Size = new System.Drawing.Size(268, 27);
            this.TXTBX_other.TabIndex = 43;
            // 
            // TXTBX_estimation
            // 
            this.TXTBX_estimation.Location = new System.Drawing.Point(606, 466);
            this.TXTBX_estimation.Margin = new System.Windows.Forms.Padding(5);
            this.TXTBX_estimation.Name = "TXTBX_estimation";
            this.TXTBX_estimation.Size = new System.Drawing.Size(268, 27);
            this.TXTBX_estimation.TabIndex = 42;
            // 
            // TXTBX_woodtype
            // 
            this.TXTBX_woodtype.Location = new System.Drawing.Point(606, 399);
            this.TXTBX_woodtype.Margin = new System.Windows.Forms.Padding(5);
            this.TXTBX_woodtype.Name = "TXTBX_woodtype";
            this.TXTBX_woodtype.Size = new System.Drawing.Size(268, 27);
            this.TXTBX_woodtype.TabIndex = 41;
            // 
            // TXTBX_Producttype
            // 
            this.TXTBX_Producttype.Location = new System.Drawing.Point(606, 332);
            this.TXTBX_Producttype.Margin = new System.Windows.Forms.Padding(5);
            this.TXTBX_Producttype.Name = "TXTBX_Producttype";
            this.TXTBX_Producttype.Size = new System.Drawing.Size(268, 27);
            this.TXTBX_Producttype.TabIndex = 40;
            // 
            // TXTBX_Cname
            // 
            this.TXTBX_Cname.Location = new System.Drawing.Point(606, 266);
            this.TXTBX_Cname.Margin = new System.Windows.Forms.Padding(5);
            this.TXTBX_Cname.Name = "TXTBX_Cname";
            this.TXTBX_Cname.Size = new System.Drawing.Size(268, 27);
            this.TXTBX_Cname.TabIndex = 39;
            // 
            // LBL_extracharges
            // 
            this.LBL_extracharges.AutoSize = true;
            this.LBL_extracharges.BackColor = System.Drawing.Color.Transparent;
            this.LBL_extracharges.Cursor = System.Windows.Forms.Cursors.No;
            this.LBL_extracharges.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_extracharges.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LBL_extracharges.Location = new System.Drawing.Point(224, 730);
            this.LBL_extracharges.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_extracharges.Name = "LBL_extracharges";
            this.LBL_extracharges.Size = new System.Drawing.Size(207, 27);
            this.LBL_extracharges.TabIndex = 38;
            this.LBL_extracharges.Text = "Selling Price";
            // 
            // LBL_additionalcharges
            // 
            this.LBL_additionalcharges.AutoSize = true;
            this.LBL_additionalcharges.BackColor = System.Drawing.Color.Transparent;
            this.LBL_additionalcharges.Cursor = System.Windows.Forms.Cursors.No;
            this.LBL_additionalcharges.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_additionalcharges.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LBL_additionalcharges.Location = new System.Drawing.Point(224, 659);
            this.LBL_additionalcharges.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_additionalcharges.Name = "LBL_additionalcharges";
            this.LBL_additionalcharges.Size = new System.Drawing.Size(282, 27);
            this.LBL_additionalcharges.TabIndex = 37;
            this.LBL_additionalcharges.Text = "Additional Charges";
            // 
            // LBL_other
            // 
            this.LBL_other.AutoSize = true;
            this.LBL_other.BackColor = System.Drawing.Color.Transparent;
            this.LBL_other.Cursor = System.Windows.Forms.Cursors.No;
            this.LBL_other.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_other.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LBL_other.Location = new System.Drawing.Point(224, 532);
            this.LBL_other.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_other.Name = "LBL_other";
            this.LBL_other.Size = new System.Drawing.Size(222, 27);
            this.LBL_other.TabIndex = 36;
            this.LBL_other.Text = "Other Services";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(606, 196);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(268, 27);
            this.dateTimePicker.TabIndex = 35;
            // 
            // LBL_estimation
            // 
            this.LBL_estimation.AutoSize = true;
            this.LBL_estimation.BackColor = System.Drawing.Color.Transparent;
            this.LBL_estimation.Cursor = System.Windows.Forms.Cursors.No;
            this.LBL_estimation.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_estimation.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LBL_estimation.Location = new System.Drawing.Point(224, 466);
            this.LBL_estimation.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_estimation.Name = "LBL_estimation";
            this.LBL_estimation.Size = new System.Drawing.Size(87, 27);
            this.LBL_estimation.TabIndex = 34;
            this.LBL_estimation.Text = "Value";
            // 
            // LBL_woodtype
            // 
            this.LBL_woodtype.AutoSize = true;
            this.LBL_woodtype.BackColor = System.Drawing.Color.Transparent;
            this.LBL_woodtype.Cursor = System.Windows.Forms.Cursors.No;
            this.LBL_woodtype.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_woodtype.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LBL_woodtype.Location = new System.Drawing.Point(224, 398);
            this.LBL_woodtype.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_woodtype.Name = "LBL_woodtype";
            this.LBL_woodtype.Size = new System.Drawing.Size(192, 27);
            this.LBL_woodtype.TabIndex = 33;
            this.LBL_woodtype.Text = "Product Name";
            // 
            // LBL_Producttype
            // 
            this.LBL_Producttype.AutoSize = true;
            this.LBL_Producttype.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Producttype.Cursor = System.Windows.Forms.Cursors.No;
            this.LBL_Producttype.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Producttype.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LBL_Producttype.Location = new System.Drawing.Point(224, 330);
            this.LBL_Producttype.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_Producttype.Name = "LBL_Producttype";
            this.LBL_Producttype.Size = new System.Drawing.Size(192, 27);
            this.LBL_Producttype.TabIndex = 32;
            this.LBL_Producttype.Text = "Product Type";
            // 
            // LBL_cname
            // 
            this.LBL_cname.AutoSize = true;
            this.LBL_cname.BackColor = System.Drawing.Color.Transparent;
            this.LBL_cname.Cursor = System.Windows.Forms.Cursors.No;
            this.LBL_cname.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_cname.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LBL_cname.Location = new System.Drawing.Point(224, 262);
            this.LBL_cname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_cname.Name = "LBL_cname";
            this.LBL_cname.Size = new System.Drawing.Size(237, 27);
            this.LBL_cname.TabIndex = 31;
            this.LBL_cname.Text = "Customer\'s Name";
            // 
            // LBL_sales
            // 
            this.LBL_sales.AutoSize = true;
            this.LBL_sales.BackColor = System.Drawing.Color.Transparent;
            this.LBL_sales.Cursor = System.Windows.Forms.Cursors.No;
            this.LBL_sales.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_sales.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LBL_sales.Location = new System.Drawing.Point(224, 194);
            this.LBL_sales.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_sales.Name = "LBL_sales";
            this.LBL_sales.Size = new System.Drawing.Size(162, 27);
            this.LBL_sales.TabIndex = 30;
            this.LBL_sales.Text = "Sales Date";
            // 
            // form_sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::C_sharp_project.Properties.Resources.texture_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1099, 951);
            this.Controls.Add(this.TXTBX_otherservices);
            this.Controls.Add(this.TXTBX_extra);
            this.Controls.Add(this.TXTBX_other);
            this.Controls.Add(this.TXTBX_estimation);
            this.Controls.Add(this.TXTBX_woodtype);
            this.Controls.Add(this.TXTBX_Producttype);
            this.Controls.Add(this.TXTBX_Cname);
            this.Controls.Add(this.LBL_extracharges);
            this.Controls.Add(this.LBL_additionalcharges);
            this.Controls.Add(this.LBL_other);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.LBL_estimation);
            this.Controls.Add(this.LBL_woodtype);
            this.Controls.Add(this.LBL_Producttype);
            this.Controls.Add(this.LBL_cname);
            this.Controls.Add(this.LBL_sales);
            this.Controls.Add(this.sales_usrn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_sumbit);
            this.Controls.Add(this.BTN_Clear);
            this.Controls.Add(this.Lbl_user);
            this.Controls.Add(this.LBL_salesrecords);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "form_sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranasinghe Sawmills";
            this.Load += new System.EventHandler(this.form_sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_user;
        private System.Windows.Forms.Label LBL_salesrecords;
        private System.Windows.Forms.Button BTN_Clear;
        private System.Windows.Forms.Button BTN_sumbit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label sales_usrn;
        private System.Windows.Forms.TextBox TXTBX_otherservices;
        private System.Windows.Forms.TextBox TXTBX_extra;
        private System.Windows.Forms.TextBox TXTBX_other;
        private System.Windows.Forms.TextBox TXTBX_estimation;
        private System.Windows.Forms.TextBox TXTBX_woodtype;
        private System.Windows.Forms.TextBox TXTBX_Producttype;
        private System.Windows.Forms.TextBox TXTBX_Cname;
        private System.Windows.Forms.Label LBL_extracharges;
        private System.Windows.Forms.Label LBL_additionalcharges;
        private System.Windows.Forms.Label LBL_other;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label LBL_estimation;
        private System.Windows.Forms.Label LBL_woodtype;
        private System.Windows.Forms.Label LBL_Producttype;
        private System.Windows.Forms.Label LBL_cname;
        private System.Windows.Forms.Label LBL_sales;
    }
}