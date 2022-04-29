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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sell_record = new System.Windows.Forms.DataGridView();
            this.sell_btnreset = new System.Windows.Forms.Button();
            this.sell_btnsub = new System.Windows.Forms.Button();
            this.sell_date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sell_record)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(321, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly selling";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::C_sharp_project.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(798, 490);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::C_sharp_project.Properties.Resources.exit;
            this.pictureBox2.Location = new System.Drawing.Point(876, 490);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // sell_record
            // 
            this.sell_record.AllowUserToAddRows = false;
            this.sell_record.AllowUserToDeleteRows = false;
            this.sell_record.AllowUserToResizeColumns = false;
            this.sell_record.AllowUserToResizeRows = false;
            this.sell_record.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sell_record.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.sell_record.BackgroundColor = System.Drawing.Color.Bisque;
            this.sell_record.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sell_record.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.sell_record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sell_record.GridColor = System.Drawing.Color.Black;
            this.sell_record.Location = new System.Drawing.Point(49, 103);
            this.sell_record.Name = "sell_record";
            this.sell_record.ReadOnly = true;
            this.sell_record.RowHeadersWidth = 51;
            this.sell_record.RowTemplate.Height = 29;
            this.sell_record.Size = new System.Drawing.Size(867, 285);
            this.sell_record.TabIndex = 20;
            // 
            // sell_btnreset
            // 
            this.sell_btnreset.BackColor = System.Drawing.Color.PeachPuff;
            this.sell_btnreset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sell_btnreset.Location = new System.Drawing.Point(798, 427);
            this.sell_btnreset.Name = "sell_btnreset";
            this.sell_btnreset.Size = new System.Drawing.Size(118, 41);
            this.sell_btnreset.TabIndex = 21;
            this.sell_btnreset.Text = "Reset";
            this.sell_btnreset.UseVisualStyleBackColor = false;
            this.sell_btnreset.Click += new System.EventHandler(this.sell_btnreset_Click);
            // 
            // sell_btnsub
            // 
            this.sell_btnsub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sell_btnsub.AutoSize = true;
            this.sell_btnsub.BackColor = System.Drawing.Color.PeachPuff;
            this.sell_btnsub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sell_btnsub.Location = new System.Drawing.Point(49, 427);
            this.sell_btnsub.Name = "sell_btnsub";
            this.sell_btnsub.Size = new System.Drawing.Size(118, 41);
            this.sell_btnsub.TabIndex = 22;
            this.sell_btnsub.Text = "Submit";
            this.sell_btnsub.UseVisualStyleBackColor = false;
            this.sell_btnsub.Click += new System.EventHandler(this.sell_btnsub_Click);
            // 
            // sell_date
            // 
            this.sell_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sell_date.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sell_date.CustomFormat = "MMMM";
            this.sell_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sell_date.Location = new System.Drawing.Point(49, 394);
            this.sell_date.Name = "sell_date";
            this.sell_date.Size = new System.Drawing.Size(118, 27);
            this.sell_date.TabIndex = 23;
            // 
            // Form_mselling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C_sharp_project.Properties.Resources.texture_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(964, 553);
            this.Controls.Add(this.sell_date);
            this.Controls.Add(this.sell_btnsub);
            this.Controls.Add(this.sell_btnreset);
            this.Controls.Add(this.sell_record);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_mselling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selling Records";
            this.Load += new System.EventHandler(this.Form_mselling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sell_record)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView sell_record;
        private System.Windows.Forms.Button sell_btnreset;
        private System.Windows.Forms.Button sell_btnsub;
        private System.Windows.Forms.DateTimePicker sell_date;
    }
}