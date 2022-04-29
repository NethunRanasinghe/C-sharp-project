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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mbuy_back = new System.Windows.Forms.PictureBox();
            this.buy_record = new System.Windows.Forms.DataGridView();
            this.buy_btnre = new System.Windows.Forms.Button();
            this.buy_btnsub = new System.Windows.Forms.Button();
            this.buy_date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mbuy_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_record)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(313, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 56);
            this.label1.TabIndex = 7;
            this.label1.Text = "Monthly Buying";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::C_sharp_project.Properties.Resources.exit;
            this.pictureBox1.Location = new System.Drawing.Point(876, 490);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mbuy_back
            // 
            this.mbuy_back.BackColor = System.Drawing.Color.Transparent;
            this.mbuy_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mbuy_back.Image = global::C_sharp_project.Properties.Resources.back;
            this.mbuy_back.Location = new System.Drawing.Point(798, 490);
            this.mbuy_back.Name = "mbuy_back";
            this.mbuy_back.Size = new System.Drawing.Size(40, 40);
            this.mbuy_back.TabIndex = 20;
            this.mbuy_back.TabStop = false;
            this.mbuy_back.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // buy_record
            // 
            this.buy_record.AllowUserToAddRows = false;
            this.buy_record.AllowUserToDeleteRows = false;
            this.buy_record.AllowUserToResizeColumns = false;
            this.buy_record.AllowUserToResizeRows = false;
            this.buy_record.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buy_record.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.buy_record.BackgroundColor = System.Drawing.Color.Bisque;
            this.buy_record.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.buy_record.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.buy_record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buy_record.GridColor = System.Drawing.Color.Black;
            this.buy_record.Location = new System.Drawing.Point(49, 103);
            this.buy_record.Name = "buy_record";
            this.buy_record.ReadOnly = true;
            this.buy_record.RowHeadersWidth = 51;
            this.buy_record.RowTemplate.Height = 29;
            this.buy_record.Size = new System.Drawing.Size(867, 285);
            this.buy_record.TabIndex = 21;
            // 
            // buy_btnre
            // 
            this.buy_btnre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buy_btnre.AutoSize = true;
            this.buy_btnre.BackColor = System.Drawing.Color.PeachPuff;
            this.buy_btnre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buy_btnre.Location = new System.Drawing.Point(798, 427);
            this.buy_btnre.Name = "buy_btnre";
            this.buy_btnre.Size = new System.Drawing.Size(118, 41);
            this.buy_btnre.TabIndex = 22;
            this.buy_btnre.Text = "Reset";
            this.buy_btnre.UseVisualStyleBackColor = false;
            this.buy_btnre.Click += new System.EventHandler(this.buy_btnre_Click);
            // 
            // buy_btnsub
            // 
            this.buy_btnsub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buy_btnsub.AutoSize = true;
            this.buy_btnsub.BackColor = System.Drawing.Color.PeachPuff;
            this.buy_btnsub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buy_btnsub.Location = new System.Drawing.Point(49, 427);
            this.buy_btnsub.Name = "buy_btnsub";
            this.buy_btnsub.Size = new System.Drawing.Size(118, 41);
            this.buy_btnsub.TabIndex = 23;
            this.buy_btnsub.Text = "Submit";
            this.buy_btnsub.UseVisualStyleBackColor = false;
            this.buy_btnsub.Click += new System.EventHandler(this.buy_btnsub_Click);
            // 
            // buy_date
            // 
            this.buy_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buy_date.CustomFormat = "MMMM";
            this.buy_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.buy_date.Location = new System.Drawing.Point(49, 394);
            this.buy_date.Name = "buy_date";
            this.buy_date.Size = new System.Drawing.Size(118, 27);
            this.buy_date.TabIndex = 24;
            // 
            // Form_mbuying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C_sharp_project.Properties.Resources.texture_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(964, 553);
            this.Controls.Add(this.buy_date);
            this.Controls.Add(this.buy_btnsub);
            this.Controls.Add(this.buy_btnre);
            this.Controls.Add(this.buy_record);
            this.Controls.Add(this.mbuy_back);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_mbuying";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buying Records";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mbuy_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_record)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox mbuy_back;
        private System.Windows.Forms.DataGridView buy_record;
        private System.Windows.Forms.Button buy_btnre;
        private System.Windows.Forms.Button buy_btnsub;
        private System.Windows.Forms.DateTimePicker buy_date;
    }
}

