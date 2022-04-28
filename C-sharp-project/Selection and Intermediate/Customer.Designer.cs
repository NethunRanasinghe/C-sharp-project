namespace C_sharp_project
{
    partial class cus_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cus_form));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cus_btncd = new System.Windows.Forms.Button();
            this.cus_btncr = new System.Windows.Forms.Button();
            this.cus_panel = new System.Windows.Forms.Panel();
            this.cus_exit = new System.Windows.Forms.PictureBox();
            this.cus_back = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cus_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cus_back)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cus_btncd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cus_btncr, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(72, 118);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(657, 214);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cus_btncd
            // 
            this.cus_btncd.AutoSize = true;
            this.cus_btncd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cus_btncd.BackColor = System.Drawing.Color.PeachPuff;
            this.cus_btncd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cus_btncd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cus_btncd.Location = new System.Drawing.Point(3, 3);
            this.cus_btncd.Name = "cus_btncd";
            this.cus_btncd.Size = new System.Drawing.Size(322, 208);
            this.cus_btncd.TabIndex = 0;
            this.cus_btncd.Text = "Customer Data";
            this.cus_btncd.UseVisualStyleBackColor = false;
            this.cus_btncd.Click += new System.EventHandler(this.cus_btncd_Click);
            // 
            // cus_btncr
            // 
            this.cus_btncr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cus_btncr.BackColor = System.Drawing.Color.PeachPuff;
            this.cus_btncr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cus_btncr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cus_btncr.Location = new System.Drawing.Point(331, 3);
            this.cus_btncr.Name = "cus_btncr";
            this.cus_btncr.Size = new System.Drawing.Size(323, 208);
            this.cus_btncr.TabIndex = 1;
            this.cus_btncr.Text = "Customer Registration";
            this.cus_btncr.UseVisualStyleBackColor = false;
            this.cus_btncr.Click += new System.EventHandler(this.cus_btncr_Click);
            // 
            // cus_panel
            // 
            this.cus_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cus_panel.AutoSize = true;
            this.cus_panel.BackColor = System.Drawing.Color.Bisque;
            this.cus_panel.Location = new System.Drawing.Point(60, 105);
            this.cus_panel.Name = "cus_panel";
            this.cus_panel.Size = new System.Drawing.Size(680, 240);
            this.cus_panel.TabIndex = 1;
            // 
            // cus_exit
            // 
            this.cus_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cus_exit.BackColor = System.Drawing.Color.Transparent;
            this.cus_exit.Image = global::C_sharp_project.Properties.Resources.exit;
            this.cus_exit.Location = new System.Drawing.Point(737, 390);
            this.cus_exit.Name = "cus_exit";
            this.cus_exit.Size = new System.Drawing.Size(40, 40);
            this.cus_exit.TabIndex = 2;
            this.cus_exit.TabStop = false;
            this.cus_exit.Click += new System.EventHandler(this.cus_exit_Click);
            // 
            // cus_back
            // 
            this.cus_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cus_back.BackColor = System.Drawing.Color.Transparent;
            this.cus_back.Image = global::C_sharp_project.Properties.Resources.back;
            this.cus_back.Location = new System.Drawing.Point(657, 390);
            this.cus_back.Name = "cus_back";
            this.cus_back.Size = new System.Drawing.Size(40, 40);
            this.cus_back.TabIndex = 3;
            this.cus_back.TabStop = false;
            this.cus_back.Click += new System.EventHandler(this.cus_back_Click);
            // 
            // cus_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::C_sharp_project.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cus_back);
            this.Controls.Add(this.cus_exit);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cus_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cus_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cus_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cus_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cus_btncd;
        private System.Windows.Forms.Button cus_btncr;
        private System.Windows.Forms.Panel cus_panel;
        private System.Windows.Forms.PictureBox cus_exit;
        private System.Windows.Forms.PictureBox cus_back;
    }
}