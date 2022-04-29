namespace C_sharp_project
{
    partial class Admin_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Control));
            this.admin_back = new System.Windows.Forms.PictureBox();
            this.admin_exit = new System.Windows.Forms.PictureBox();
            this.admin_cmbusr = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.admin_datalog = new System.Windows.Forms.DataGridView();
            this.admin_txtemailc = new System.Windows.Forms.TextBox();
            this.admin_lblpanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.admin_enb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.admin_btnr = new System.Windows.Forms.Button();
            this.admin_btnsende = new System.Windows.Forms.Button();
            this.admin_btndlt = new System.Windows.Forms.Button();
            this.admin_btndis = new System.Windows.Forms.Button();
            this.admin_btnen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.admin_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_datalog)).BeginInit();
            this.admin_lblpanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // admin_back
            // 
            this.admin_back.BackColor = System.Drawing.Color.Transparent;
            this.admin_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin_back.Image = global::C_sharp_project.Properties.Resources.back;
            this.admin_back.Location = new System.Drawing.Point(666, 448);
            this.admin_back.Name = "admin_back";
            this.admin_back.Size = new System.Drawing.Size(40, 40);
            this.admin_back.TabIndex = 0;
            this.admin_back.TabStop = false;
            this.admin_back.Click += new System.EventHandler(this.admin_back_Click);
            // 
            // admin_exit
            // 
            this.admin_exit.BackColor = System.Drawing.Color.Transparent;
            this.admin_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin_exit.Image = global::C_sharp_project.Properties.Resources.exit;
            this.admin_exit.Location = new System.Drawing.Point(746, 448);
            this.admin_exit.Name = "admin_exit";
            this.admin_exit.Size = new System.Drawing.Size(40, 40);
            this.admin_exit.TabIndex = 1;
            this.admin_exit.TabStop = false;
            this.admin_exit.Click += new System.EventHandler(this.admin_exit_Click);
            // 
            // admin_cmbusr
            // 
            this.admin_cmbusr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.admin_cmbusr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.admin_cmbusr.FormattingEnabled = true;
            this.admin_cmbusr.Location = new System.Drawing.Point(298, 34);
            this.admin_cmbusr.Name = "admin_cmbusr";
            this.admin_cmbusr.Size = new System.Drawing.Size(151, 28);
            this.admin_cmbusr.TabIndex = 3;
            this.admin_cmbusr.SelectedIndexChanged += new System.EventHandler(this.admin_cmbusr_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(54, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Login Log\r\n";
            // 
            // admin_datalog
            // 
            this.admin_datalog.AllowUserToAddRows = false;
            this.admin_datalog.AllowUserToDeleteRows = false;
            this.admin_datalog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.admin_datalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admin_datalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admin_datalog.Location = new System.Drawing.Point(254, 194);
            this.admin_datalog.Name = "admin_datalog";
            this.admin_datalog.ReadOnly = true;
            this.admin_datalog.RowHeadersWidth = 51;
            this.admin_datalog.RowTemplate.Height = 29;
            this.admin_datalog.Size = new System.Drawing.Size(240, 85);
            this.admin_datalog.TabIndex = 5;
            // 
            // admin_txtemailc
            // 
            this.admin_txtemailc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.admin_txtemailc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admin_txtemailc.Location = new System.Drawing.Point(254, 288);
            this.admin_txtemailc.Multiline = true;
            this.admin_txtemailc.Name = "admin_txtemailc";
            this.admin_txtemailc.Size = new System.Drawing.Size(240, 88);
            this.admin_txtemailc.TabIndex = 7;
            // 
            // admin_lblpanel
            // 
            this.admin_lblpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.admin_lblpanel.AutoSize = true;
            this.admin_lblpanel.BackColor = System.Drawing.Color.Bisque;
            this.admin_lblpanel.Controls.Add(this.tableLayoutPanel1);
            this.admin_lblpanel.Location = new System.Drawing.Point(25, 61);
            this.admin_lblpanel.Name = "admin_lblpanel";
            this.admin_lblpanel.Size = new System.Drawing.Size(506, 388);
            this.admin_lblpanel.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.admin_txtemailc, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.admin_enb, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.admin_cmbusr, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.admin_datalog, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 382);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(58, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Send an Email";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(71, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select User";
            // 
            // admin_enb
            // 
            this.admin_enb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.admin_enb.AutoSize = true;
            this.admin_enb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.admin_enb.Location = new System.Drawing.Point(350, 128);
            this.admin_enb.Name = "admin_enb";
            this.admin_enb.Size = new System.Drawing.Size(48, 28);
            this.admin_enb.TabIndex = 9;
            this.admin_enb.Text = "null";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(55, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enabled Status";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(605, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 287);
            this.panel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.admin_btnr, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.admin_btnsende, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.admin_btndlt, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.admin_btndis, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.admin_btnen, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(151, 281);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // admin_btnr
            // 
            this.admin_btnr.AutoSize = true;
            this.admin_btnr.BackColor = System.Drawing.Color.PeachPuff;
            this.admin_btnr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admin_btnr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.admin_btnr.Location = new System.Drawing.Point(3, 3);
            this.admin_btnr.Name = "admin_btnr";
            this.admin_btnr.Size = new System.Drawing.Size(145, 50);
            this.admin_btnr.TabIndex = 0;
            this.admin_btnr.Text = "Refresh";
            this.admin_btnr.UseVisualStyleBackColor = false;
            this.admin_btnr.Click += new System.EventHandler(this.admin_btnr_Click);
            // 
            // admin_btnsende
            // 
            this.admin_btnsende.AutoSize = true;
            this.admin_btnsende.BackColor = System.Drawing.Color.PeachPuff;
            this.admin_btnsende.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admin_btnsende.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.admin_btnsende.Location = new System.Drawing.Point(3, 227);
            this.admin_btnsende.Name = "admin_btnsende";
            this.admin_btnsende.Size = new System.Drawing.Size(145, 51);
            this.admin_btnsende.TabIndex = 3;
            this.admin_btnsende.Text = "Send Email";
            this.admin_btnsende.UseVisualStyleBackColor = false;
            this.admin_btnsende.Click += new System.EventHandler(this.admin_btnsende_Click);
            // 
            // admin_btndlt
            // 
            this.admin_btndlt.AutoSize = true;
            this.admin_btndlt.BackColor = System.Drawing.Color.PeachPuff;
            this.admin_btndlt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admin_btndlt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.admin_btndlt.Location = new System.Drawing.Point(3, 171);
            this.admin_btndlt.Name = "admin_btndlt";
            this.admin_btndlt.Size = new System.Drawing.Size(145, 50);
            this.admin_btndlt.TabIndex = 2;
            this.admin_btndlt.Text = "Delete User";
            this.admin_btndlt.UseVisualStyleBackColor = false;
            this.admin_btndlt.Click += new System.EventHandler(this.admin_btndlt_Click);
            // 
            // admin_btndis
            // 
            this.admin_btndis.AutoSize = true;
            this.admin_btndis.BackColor = System.Drawing.Color.PeachPuff;
            this.admin_btndis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admin_btndis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.admin_btndis.Location = new System.Drawing.Point(3, 115);
            this.admin_btndis.Name = "admin_btndis";
            this.admin_btndis.Size = new System.Drawing.Size(145, 50);
            this.admin_btndis.TabIndex = 1;
            this.admin_btndis.Text = "Disable User";
            this.admin_btndis.UseVisualStyleBackColor = false;
            this.admin_btndis.Click += new System.EventHandler(this.admin_btndis_Click);
            // 
            // admin_btnen
            // 
            this.admin_btnen.AutoSize = true;
            this.admin_btnen.BackColor = System.Drawing.Color.PeachPuff;
            this.admin_btnen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admin_btnen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.admin_btnen.Location = new System.Drawing.Point(3, 59);
            this.admin_btnen.Name = "admin_btnen";
            this.admin_btnen.Size = new System.Drawing.Size(145, 50);
            this.admin_btnen.TabIndex = 4;
            this.admin_btnen.Text = "Enable User";
            this.admin_btnen.UseVisualStyleBackColor = false;
            this.admin_btnen.Click += new System.EventHandler(this.admin_btnen_Click);
            // 
            // Admin_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::C_sharp_project.Properties.Resources.texture_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.admin_exit);
            this.Controls.Add(this.admin_back);
            this.Controls.Add(this.admin_lblpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Control Panel";
            ((System.ComponentModel.ISupportInitialize)(this.admin_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_datalog)).EndInit();
            this.admin_lblpanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox admin_back;
        private System.Windows.Forms.PictureBox admin_exit;
        private System.Windows.Forms.ComboBox admin_cmbusr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView admin_datalog;
        private System.Windows.Forms.TextBox admin_txtemailc;
        private System.Windows.Forms.Panel admin_lblpanel;
        private System.Windows.Forms.Label admin_enb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button admin_btnr;
        private System.Windows.Forms.Button admin_btndis;
        private System.Windows.Forms.Button admin_btndlt;
        private System.Windows.Forms.Button admin_btnsende;
        private System.Windows.Forms.Button admin_btnen;
    }
}