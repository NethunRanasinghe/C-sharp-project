namespace C_sharp_project
{
    partial class login_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.login_lpanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login_picnewusr = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login_btnclear = new System.Windows.Forms.Button();
            this.login_btnlogin = new System.Windows.Forms.Button();
            this.login_lbllogin = new System.Windows.Forms.Label();
            this.login_panelr = new System.Windows.Forms.Panel();
            this.login_txtforgotpw = new System.Windows.Forms.LinkLabel();
            this.login_txtpw = new System.Windows.Forms.TextBox();
            this.login_txtusr = new System.Windows.Forms.TextBox();
            this.login_tt = new System.Windows.Forms.ToolTip(this.components);
            this.login_errp = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.login_lpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_picnewusr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.login_panelr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_errp)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::C_sharp_project.Properties.Resources.login_bgl_6_;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.login_lpanel);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.login_picnewusr);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.login_btnclear);
            this.splitContainer1.Panel2.Controls.Add(this.login_btnlogin);
            this.splitContainer1.Panel2.Controls.Add(this.login_lbllogin);
            this.splitContainer1.Panel2.Controls.Add(this.login_panelr);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.splitContainer1.Size = new System.Drawing.Size(881, 415);
            this.splitContainer1.SplitterDistance = 507;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // login_lpanel
            // 
            this.login_lpanel.BackColor = System.Drawing.Color.Transparent;
            this.login_lpanel.Controls.Add(this.label3);
            this.login_lpanel.Controls.Add(this.label2);
            this.login_lpanel.Controls.Add(this.label1);
            this.login_lpanel.Location = new System.Drawing.Point(18, 65);
            this.login_lpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_lpanel.Name = "login_lpanel";
            this.login_lpanel.Size = new System.Drawing.Size(470, 285);
            this.login_lpanel.TabIndex = 4;
            this.login_lpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.login_lpanel_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(71, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "Timber Stores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(186, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "and";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ranasinghe Saw Mill";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // login_picnewusr
            // 
            this.login_picnewusr.BackColor = System.Drawing.Color.Transparent;
            this.login_picnewusr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_picnewusr.Image = ((System.Drawing.Image)(resources.GetObject("login_picnewusr.Image")));
            this.login_picnewusr.Location = new System.Drawing.Point(253, 368);
            this.login_picnewusr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_picnewusr.Name = "login_picnewusr";
            this.login_picnewusr.Size = new System.Drawing.Size(35, 30);
            this.login_picnewusr.TabIndex = 10;
            this.login_picnewusr.TabStop = false;
            this.login_tt.SetToolTip(this.login_picnewusr, "Click here to sign up as a new user.");
            this.login_picnewusr.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(316, 368);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 30);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.login_tt.SetToolTip(this.pictureBox1, "Click here to see login help.");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // login_btnclear
            // 
            this.login_btnclear.BackgroundImage = global::C_sharp_project.Properties.Resources.texture_background;
            this.login_btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_btnclear.ForeColor = System.Drawing.Color.White;
            this.login_btnclear.Location = new System.Drawing.Point(253, 316);
            this.login_btnclear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_btnclear.Name = "login_btnclear";
            this.login_btnclear.Size = new System.Drawing.Size(105, 34);
            this.login_btnclear.TabIndex = 8;
            this.login_btnclear.Text = "Clear";
            this.login_btnclear.UseVisualStyleBackColor = true;
            this.login_btnclear.Click += new System.EventHandler(this.login_btnclear_Click);
            // 
            // login_btnlogin
            // 
            this.login_btnlogin.BackgroundImage = global::C_sharp_project.Properties.Resources.texture_background;
            this.login_btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_btnlogin.ForeColor = System.Drawing.Color.White;
            this.login_btnlogin.Location = new System.Drawing.Point(126, 316);
            this.login_btnlogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_btnlogin.Name = "login_btnlogin";
            this.login_btnlogin.Size = new System.Drawing.Size(105, 34);
            this.login_btnlogin.TabIndex = 7;
            this.login_btnlogin.Text = "Login";
            this.login_btnlogin.UseVisualStyleBackColor = true;
            this.login_btnlogin.Click += new System.EventHandler(this.login_btnlogin_Click);
            // 
            // login_lbllogin
            // 
            this.login_lbllogin.AutoSize = true;
            this.login_lbllogin.BackColor = System.Drawing.Color.Transparent;
            this.login_lbllogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.login_lbllogin.ForeColor = System.Drawing.Color.DarkRed;
            this.login_lbllogin.Location = new System.Drawing.Point(18, 57);
            this.login_lbllogin.Name = "login_lbllogin";
            this.login_lbllogin.Size = new System.Drawing.Size(80, 31);
            this.login_lbllogin.TabIndex = 0;
            this.login_lbllogin.Text = "Login";
            // 
            // login_panelr
            // 
            this.login_panelr.BackColor = System.Drawing.Color.Transparent;
            this.login_panelr.Controls.Add(this.login_txtforgotpw);
            this.login_panelr.Controls.Add(this.login_txtpw);
            this.login_panelr.Controls.Add(this.login_txtusr);
            this.login_panelr.Location = new System.Drawing.Point(18, 110);
            this.login_panelr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_panelr.Name = "login_panelr";
            this.login_panelr.Size = new System.Drawing.Size(342, 179);
            this.login_panelr.TabIndex = 6;
            // 
            // login_txtforgotpw
            // 
            this.login_txtforgotpw.ActiveLinkColor = System.Drawing.Color.White;
            this.login_txtforgotpw.AutoSize = true;
            this.login_txtforgotpw.BackColor = System.Drawing.Color.Transparent;
            this.login_txtforgotpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_txtforgotpw.LinkColor = System.Drawing.Color.DarkRed;
            this.login_txtforgotpw.Location = new System.Drawing.Point(186, 156);
            this.login_txtforgotpw.Name = "login_txtforgotpw";
            this.login_txtforgotpw.Size = new System.Drawing.Size(152, 18);
            this.login_txtforgotpw.TabIndex = 4;
            this.login_txtforgotpw.TabStop = true;
            this.login_txtforgotpw.Text = "Forgot Password ?";
            this.login_tt.SetToolTip(this.login_txtforgotpw, "Click here to reset the password.");
            this.login_txtforgotpw.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.login_txtforgotpw_LinkClicked);
            // 
            // login_txtpw
            // 
            this.login_txtpw.BackColor = System.Drawing.Color.White;
            this.login_txtpw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_txtpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_txtpw.ForeColor = System.Drawing.Color.DarkRed;
            this.login_txtpw.Location = new System.Drawing.Point(29, 97);
            this.login_txtpw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_txtpw.Multiline = true;
            this.login_txtpw.Name = "login_txtpw";
            this.login_txtpw.Size = new System.Drawing.Size(286, 48);
            this.login_txtpw.TabIndex = 3;
            this.login_txtpw.Text = "Password";
            this.login_txtpw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login_txtpw.Enter += new System.EventHandler(this.login_txtpw_Enter);
            this.login_txtpw.Leave += new System.EventHandler(this.login_txtpw_Leave);
            this.login_txtpw.Validating += new System.ComponentModel.CancelEventHandler(this.login_txtpw_Validating);
            // 
            // login_txtusr
            // 
            this.login_txtusr.BackColor = System.Drawing.Color.White;
            this.login_txtusr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_txtusr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_txtusr.ForeColor = System.Drawing.Color.DarkRed;
            this.login_txtusr.Location = new System.Drawing.Point(29, 32);
            this.login_txtusr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_txtusr.MaxLength = 200;
            this.login_txtusr.Multiline = true;
            this.login_txtusr.Name = "login_txtusr";
            this.login_txtusr.Size = new System.Drawing.Size(286, 48);
            this.login_txtusr.TabIndex = 2;
            this.login_txtusr.Text = "First Name";
            this.login_txtusr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login_txtusr.TextChanged += new System.EventHandler(this.login_txtusr_TextChanged_1);
            this.login_txtusr.Enter += new System.EventHandler(this.login_txtusr_Enter);
            this.login_txtusr.Leave += new System.EventHandler(this.login_txtusr_Leave);
            this.login_txtusr.Validating += new System.ComponentModel.CancelEventHandler(this.login_txtusr_Validating);
            // 
            // login_errp
            // 
            this.login_errp.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(81, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "jmp_usereg";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 415);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_form_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.login_lpanel.ResumeLayout(false);
            this.login_lpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_picnewusr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.login_panelr.ResumeLayout(false);
            this.login_panelr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_errp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label login_lbllogin;
        private System.Windows.Forms.Panel login_panelr;
        private System.Windows.Forms.TextBox login_txtpw;
        private System.Windows.Forms.TextBox login_txtusr;
        private System.Windows.Forms.LinkLabel login_txtforgotpw;
        private System.Windows.Forms.Button login_btnclear;
        private System.Windows.Forms.Button login_btnlogin;
        private System.Windows.Forms.PictureBox login_picnewusr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip login_tt;
        private System.Windows.Forms.ErrorProvider login_errp;
        private System.Windows.Forms.Panel login_lpanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
