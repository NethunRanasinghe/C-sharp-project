namespace C_sharp_project
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.login_split = new System.Windows.Forms.SplitContainer();
            this.login_title = new System.Windows.Forms.Label();
            this.login_paddusr = new System.Windows.Forms.PictureBox();
            this.login_phelp = new System.Windows.Forms.PictureBox();
            this.login_lbllogin = new System.Windows.Forms.Label();
            this.login_lblfpw = new System.Windows.Forms.Label();
            this.login_btnclear = new System.Windows.Forms.Button();
            this.login_btnlogin = new System.Windows.Forms.Button();
            this.login_txtpw = new System.Windows.Forms.TextBox();
            this.login_txtusr = new System.Windows.Forms.TextBox();
            this.login_pw = new System.Windows.Forms.Label();
            this.login_usr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.login_split)).BeginInit();
            this.login_split.Panel1.SuspendLayout();
            this.login_split.Panel2.SuspendLayout();
            this.login_split.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_paddusr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_phelp)).BeginInit();
            this.SuspendLayout();
            // 
            // login_split
            // 
            this.login_split.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_split.IsSplitterFixed = true;
            this.login_split.Location = new System.Drawing.Point(0, 0);
            this.login_split.Name = "login_split";
            // 
            // login_split.Panel1
            // 
            this.login_split.Panel1.Controls.Add(this.login_title);
            // 
            // login_split.Panel2
            // 
            this.login_split.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_split.Panel2.BackgroundImage")));
            this.login_split.Panel2.Controls.Add(this.login_paddusr);
            this.login_split.Panel2.Controls.Add(this.login_phelp);
            this.login_split.Panel2.Controls.Add(this.login_lbllogin);
            this.login_split.Panel2.Controls.Add(this.login_lblfpw);
            this.login_split.Panel2.Controls.Add(this.login_btnclear);
            this.login_split.Panel2.Controls.Add(this.login_btnlogin);
            this.login_split.Panel2.Controls.Add(this.login_txtpw);
            this.login_split.Panel2.Controls.Add(this.login_txtusr);
            this.login_split.Panel2.Controls.Add(this.login_pw);
            this.login_split.Panel2.Controls.Add(this.login_usr);
            this.login_split.Size = new System.Drawing.Size(1006, 553);
            this.login_split.SplitterDistance = 503;
            this.login_split.TabIndex = 0;
            // 
            // login_title
            // 
            this.login_title.AutoSize = true;
            this.login_title.BackColor = System.Drawing.Color.White;
            this.login_title.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_title.Location = new System.Drawing.Point(42, 9);
            this.login_title.Name = "login_title";
            this.login_title.Size = new System.Drawing.Size(429, 92);
            this.login_title.TabIndex = 15;
            this.login_title.Text = "Ranasinghe Saw Mills and \r\n          Timber Stores";
            // 
            // login_paddusr
            // 
            this.login_paddusr.BackColor = System.Drawing.Color.Transparent;
            this.login_paddusr.Image = ((System.Drawing.Image)(resources.GetObject("login_paddusr.Image")));
            this.login_paddusr.Location = new System.Drawing.Point(371, 501);
            this.login_paddusr.Name = "login_paddusr";
            this.login_paddusr.Size = new System.Drawing.Size(40, 40);
            this.login_paddusr.TabIndex = 25;
            this.login_paddusr.TabStop = false;
            this.login_paddusr.Click += new System.EventHandler(this.login_paddusr_Click);
            // 
            // login_phelp
            // 
            this.login_phelp.BackColor = System.Drawing.Color.Transparent;
            this.login_phelp.Image = ((System.Drawing.Image)(resources.GetObject("login_phelp.Image")));
            this.login_phelp.Location = new System.Drawing.Point(447, 501);
            this.login_phelp.Name = "login_phelp";
            this.login_phelp.Size = new System.Drawing.Size(40, 40);
            this.login_phelp.TabIndex = 24;
            this.login_phelp.TabStop = false;
            // 
            // login_lbllogin
            // 
            this.login_lbllogin.AutoSize = true;
            this.login_lbllogin.BackColor = System.Drawing.Color.Transparent;
            this.login_lbllogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_lbllogin.Location = new System.Drawing.Point(24, 70);
            this.login_lbllogin.Name = "login_lbllogin";
            this.login_lbllogin.Size = new System.Drawing.Size(75, 31);
            this.login_lbllogin.TabIndex = 23;
            this.login_lbllogin.Text = "Login";
            // 
            // login_lblfpw
            // 
            this.login_lblfpw.AutoSize = true;
            this.login_lblfpw.BackColor = System.Drawing.Color.Transparent;
            this.login_lblfpw.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_lblfpw.Location = new System.Drawing.Point(331, 298);
            this.login_lblfpw.Name = "login_lblfpw";
            this.login_lblfpw.Size = new System.Drawing.Size(134, 20);
            this.login_lblfpw.TabIndex = 22;
            this.login_lblfpw.Text = "Forgot Password ?";
            // 
            // login_btnclear
            // 
            this.login_btnclear.Location = new System.Drawing.Point(371, 348);
            this.login_btnclear.Name = "login_btnclear";
            this.login_btnclear.Size = new System.Drawing.Size(94, 29);
            this.login_btnclear.TabIndex = 21;
            this.login_btnclear.Text = "Clear";
            this.login_btnclear.UseVisualStyleBackColor = true;
            // 
            // login_btnlogin
            // 
            this.login_btnlogin.Location = new System.Drawing.Point(199, 348);
            this.login_btnlogin.Name = "login_btnlogin";
            this.login_btnlogin.Size = new System.Drawing.Size(94, 29);
            this.login_btnlogin.TabIndex = 20;
            this.login_btnlogin.Text = "Login";
            this.login_btnlogin.UseVisualStyleBackColor = true;
            // 
            // login_txtpw
            // 
            this.login_txtpw.Location = new System.Drawing.Point(199, 243);
            this.login_txtpw.Name = "login_txtpw";
            this.login_txtpw.Size = new System.Drawing.Size(266, 27);
            this.login_txtpw.TabIndex = 19;
            // 
            // login_txtusr
            // 
            this.login_txtusr.Location = new System.Drawing.Point(199, 177);
            this.login_txtusr.Name = "login_txtusr";
            this.login_txtusr.Size = new System.Drawing.Size(266, 27);
            this.login_txtusr.TabIndex = 18;
            // 
            // login_pw
            // 
            this.login_pw.AutoSize = true;
            this.login_pw.BackColor = System.Drawing.Color.Transparent;
            this.login_pw.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_pw.Location = new System.Drawing.Point(33, 235);
            this.login_pw.Name = "login_pw";
            this.login_pw.Size = new System.Drawing.Size(122, 35);
            this.login_pw.TabIndex = 17;
            this.login_pw.Text = "Password";
            // 
            // login_usr
            // 
            this.login_usr.AutoSize = true;
            this.login_usr.BackColor = System.Drawing.Color.Transparent;
            this.login_usr.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_usr.Location = new System.Drawing.Point(33, 169);
            this.login_usr.Name = "login_usr";
            this.login_usr.Size = new System.Drawing.Size(66, 35);
            this.login_usr.TabIndex = 16;
            this.login_usr.Text = "User";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.login_split);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            this.login_split.Panel1.ResumeLayout(false);
            this.login_split.Panel1.PerformLayout();
            this.login_split.Panel2.ResumeLayout(false);
            this.login_split.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_split)).EndInit();
            this.login_split.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.login_paddusr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_phelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer login_split;
        private System.Windows.Forms.Label login_title;
        private System.Windows.Forms.PictureBox login_paddusr;
        private System.Windows.Forms.PictureBox login_phelp;
        private System.Windows.Forms.Label login_lbllogin;
        private System.Windows.Forms.Label login_lblfpw;
        private System.Windows.Forms.Button login_btnclear;
        private System.Windows.Forms.Button login_btnlogin;
        private System.Windows.Forms.TextBox login_txtpw;
        private System.Windows.Forms.TextBox login_txtusr;
        private System.Windows.Forms.Label login_pw;
        private System.Windows.Forms.Label login_usr;
    }
}
