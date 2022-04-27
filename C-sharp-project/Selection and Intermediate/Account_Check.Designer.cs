namespace C_sharp_project
{
    partial class Acc_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acc_form));
            this.Acc_exit = new System.Windows.Forms.PictureBox();
            this.Acc_back = new System.Windows.Forms.PictureBox();
            this.acc_tb = new System.Windows.Forms.TableLayoutPanel();
            this.Acc_btnBuyR = new System.Windows.Forms.Button();
            this.Acc_btnSellR = new System.Windows.Forms.Button();
            this.Acc_btnPL = new System.Windows.Forms.Button();
            this.Acc_panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Acc_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Acc_back)).BeginInit();
            this.acc_tb.SuspendLayout();
            this.Acc_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Acc_exit
            // 
            this.Acc_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Acc_exit.BackColor = System.Drawing.Color.Transparent;
            this.Acc_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Acc_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Acc_exit.Image = global::C_sharp_project.Properties.Resources.exit;
            this.Acc_exit.Location = new System.Drawing.Point(780, 431);
            this.Acc_exit.Name = "Acc_exit";
            this.Acc_exit.Size = new System.Drawing.Size(40, 40);
            this.Acc_exit.TabIndex = 0;
            this.Acc_exit.TabStop = false;
            this.Acc_exit.Click += new System.EventHandler(this.Acc_exit_Click);
            // 
            // Acc_back
            // 
            this.Acc_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Acc_back.BackColor = System.Drawing.Color.Transparent;
            this.Acc_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Acc_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Acc_back.Image = global::C_sharp_project.Properties.Resources.back;
            this.Acc_back.Location = new System.Drawing.Point(705, 431);
            this.Acc_back.Name = "Acc_back";
            this.Acc_back.Size = new System.Drawing.Size(40, 40);
            this.Acc_back.TabIndex = 1;
            this.Acc_back.TabStop = false;
            this.Acc_back.Click += new System.EventHandler(this.Acc_back_Click);
            // 
            // acc_tb
            // 
            this.acc_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acc_tb.BackColor = System.Drawing.Color.Transparent;
            this.acc_tb.ColumnCount = 2;
            this.acc_tb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.acc_tb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.acc_tb.Controls.Add(this.Acc_btnBuyR, 0, 0);
            this.acc_tb.Controls.Add(this.Acc_btnSellR, 1, 0);
            this.acc_tb.Controls.Add(this.Acc_btnPL, 0, 1);
            this.acc_tb.Location = new System.Drawing.Point(11, 15);
            this.acc_tb.Name = "acc_tb";
            this.acc_tb.RowCount = 2;
            this.acc_tb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.acc_tb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.acc_tb.Size = new System.Drawing.Size(736, 304);
            this.acc_tb.TabIndex = 2;
            // 
            // Acc_btnBuyR
            // 
            this.Acc_btnBuyR.BackColor = System.Drawing.Color.PeachPuff;
            this.Acc_btnBuyR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Acc_btnBuyR.Location = new System.Drawing.Point(3, 3);
            this.Acc_btnBuyR.Name = "Acc_btnBuyR";
            this.Acc_btnBuyR.Size = new System.Drawing.Size(362, 146);
            this.Acc_btnBuyR.TabIndex = 0;
            this.Acc_btnBuyR.Text = "Buying Records";
            this.Acc_btnBuyR.UseVisualStyleBackColor = false;
            this.Acc_btnBuyR.Click += new System.EventHandler(this.Acc_btnBuyR_Click);
            // 
            // Acc_btnSellR
            // 
            this.Acc_btnSellR.BackColor = System.Drawing.Color.PeachPuff;
            this.Acc_btnSellR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Acc_btnSellR.Location = new System.Drawing.Point(371, 3);
            this.Acc_btnSellR.Name = "Acc_btnSellR";
            this.Acc_btnSellR.Size = new System.Drawing.Size(362, 146);
            this.Acc_btnSellR.TabIndex = 1;
            this.Acc_btnSellR.Text = "Selling Records";
            this.Acc_btnSellR.UseVisualStyleBackColor = false;
            this.Acc_btnSellR.Click += new System.EventHandler(this.Acc_btnSellR_Click);
            // 
            // Acc_btnPL
            // 
            this.Acc_btnPL.BackColor = System.Drawing.Color.PeachPuff;
            this.acc_tb.SetColumnSpan(this.Acc_btnPL, 2);
            this.Acc_btnPL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Acc_btnPL.Location = new System.Drawing.Point(3, 155);
            this.Acc_btnPL.Name = "Acc_btnPL";
            this.Acc_btnPL.Size = new System.Drawing.Size(730, 146);
            this.Acc_btnPL.TabIndex = 2;
            this.Acc_btnPL.Text = "Profit / Loss";
            this.Acc_btnPL.UseVisualStyleBackColor = false;
            this.Acc_btnPL.Click += new System.EventHandler(this.Acc_btnPL_Click);
            // 
            // Acc_panel
            // 
            this.Acc_panel.BackColor = System.Drawing.Color.Bisque;
            this.Acc_panel.Controls.Add(this.acc_tb);
            this.Acc_panel.Location = new System.Drawing.Point(36, 76);
            this.Acc_panel.Name = "Acc_panel";
            this.Acc_panel.Size = new System.Drawing.Size(760, 330);
            this.Acc_panel.TabIndex = 3;
            // 
            // Acc_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::C_sharp_project.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 483);
            this.Controls.Add(this.Acc_panel);
            this.Controls.Add(this.Acc_back);
            this.Controls.Add(this.Acc_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Acc_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Check";
            ((System.ComponentModel.ISupportInitialize)(this.Acc_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Acc_back)).EndInit();
            this.acc_tb.ResumeLayout(false);
            this.Acc_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Acc_exit;
        private System.Windows.Forms.PictureBox Acc_back;
        private System.Windows.Forms.TableLayoutPanel acc_tb;
        private System.Windows.Forms.Button Acc_btnBuyR;
        private System.Windows.Forms.Button Acc_btnSellR;
        private System.Windows.Forms.Button Acc_btnPL;
        private System.Windows.Forms.Panel Acc_panel;
    }
}