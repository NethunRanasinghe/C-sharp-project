namespace C_sharp_project
{
    partial class sign_up
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sign_up));
            this.signup_lblsignup = new System.Windows.Forms.Label();
            this.signup_btnsignup = new System.Windows.Forms.Button();
            this.signup_btnhelp = new System.Windows.Forms.PictureBox();
            this.signup_btnback = new System.Windows.Forms.PictureBox();
            this.signup_pnlsignup = new System.Windows.Forms.Panel();
            this.signup_btnwarn = new System.Windows.Forms.PictureBox();
            this.signup_btnrequest = new System.Windows.Forms.Button();
            this.signup_txtcpw = new System.Windows.Forms.TextBox();
            this.signup_txtpw = new System.Windows.Forms.TextBox();
            this.signup_txtcode = new System.Windows.Forms.TextBox();
            this.signup_txtposition = new System.Windows.Forms.TextBox();
            this.signup_txtemail = new System.Windows.Forms.TextBox();
            this.signup_txtln = new System.Windows.Forms.TextBox();
            this.signup_txtfn = new System.Windows.Forms.TextBox();
            this.signup_tt = new System.Windows.Forms.ToolTip(this.components);
            this.signup_errp = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.signup_btnhelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signup_btnback)).BeginInit();
            this.signup_pnlsignup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signup_btnwarn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signup_errp)).BeginInit();
            this.SuspendLayout();
            // 
            // signup_lblsignup
            // 
            this.signup_lblsignup.AutoSize = true;
            this.signup_lblsignup.BackColor = System.Drawing.Color.Transparent;
            this.signup_lblsignup.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signup_lblsignup.Location = new System.Drawing.Point(200, 20);
            this.signup_lblsignup.Name = "signup_lblsignup";
            this.signup_lblsignup.Size = new System.Drawing.Size(165, 54);
            this.signup_lblsignup.TabIndex = 0;
            this.signup_lblsignup.Text = "Sign Up";
            // 
            // signup_btnsignup
            // 
            this.signup_btnsignup.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signup_btnsignup.Location = new System.Drawing.Point(45, 618);
            this.signup_btnsignup.Name = "signup_btnsignup";
            this.signup_btnsignup.Size = new System.Drawing.Size(142, 60);
            this.signup_btnsignup.TabIndex = 9;
            this.signup_btnsignup.Text = "Sign Up";
            this.signup_btnsignup.UseVisualStyleBackColor = true;
            this.signup_btnsignup.Click += new System.EventHandler(this.signup_btnsignup_Click);
            // 
            // signup_btnhelp
            // 
            this.signup_btnhelp.BackColor = System.Drawing.Color.Transparent;
            this.signup_btnhelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_btnhelp.Image = ((System.Drawing.Image)(resources.GetObject("signup_btnhelp.Image")));
            this.signup_btnhelp.Location = new System.Drawing.Point(520, 676);
            this.signup_btnhelp.Name = "signup_btnhelp";
            this.signup_btnhelp.Size = new System.Drawing.Size(40, 40);
            this.signup_btnhelp.TabIndex = 10;
            this.signup_btnhelp.TabStop = false;
            this.signup_tt.SetToolTip(this.signup_btnhelp, "Click here to see sign up help.");
            this.signup_btnhelp.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // signup_btnback
            // 
            this.signup_btnback.BackColor = System.Drawing.Color.Transparent;
            this.signup_btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_btnback.Image = ((System.Drawing.Image)(resources.GetObject("signup_btnback.Image")));
            this.signup_btnback.Location = new System.Drawing.Point(441, 676);
            this.signup_btnback.Name = "signup_btnback";
            this.signup_btnback.Size = new System.Drawing.Size(40, 40);
            this.signup_btnback.TabIndex = 11;
            this.signup_btnback.TabStop = false;
            this.signup_tt.SetToolTip(this.signup_btnback, "Click here to go back to the login page.");
            this.signup_btnback.Click += new System.EventHandler(this.signup_btnback_Click);
            // 
            // signup_pnlsignup
            // 
            this.signup_pnlsignup.BackColor = System.Drawing.Color.LightGray;
            this.signup_pnlsignup.Controls.Add(this.signup_btnwarn);
            this.signup_pnlsignup.Controls.Add(this.signup_btnrequest);
            this.signup_pnlsignup.Controls.Add(this.signup_txtcpw);
            this.signup_pnlsignup.Controls.Add(this.signup_txtpw);
            this.signup_pnlsignup.Controls.Add(this.signup_txtcode);
            this.signup_pnlsignup.Controls.Add(this.signup_txtposition);
            this.signup_pnlsignup.Controls.Add(this.signup_txtemail);
            this.signup_pnlsignup.Controls.Add(this.signup_txtln);
            this.signup_pnlsignup.Controls.Add(this.signup_txtfn);
            this.signup_pnlsignup.Location = new System.Drawing.Point(21, 101);
            this.signup_pnlsignup.Name = "signup_pnlsignup";
            this.signup_pnlsignup.Size = new System.Drawing.Size(539, 483);
            this.signup_pnlsignup.TabIndex = 12;
            this.signup_pnlsignup.Paint += new System.Windows.Forms.PaintEventHandler(this.signup_pnlsignup_Paint);
            // 
            // signup_btnwarn
            // 
            this.signup_btnwarn.BackColor = System.Drawing.Color.Transparent;
            this.signup_btnwarn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_btnwarn.Image = ((System.Drawing.Image)(resources.GetObject("signup_btnwarn.Image")));
            this.signup_btnwarn.Location = new System.Drawing.Point(364, 333);
            this.signup_btnwarn.Name = "signup_btnwarn";
            this.signup_btnwarn.Size = new System.Drawing.Size(30, 30);
            this.signup_btnwarn.TabIndex = 19;
            this.signup_btnwarn.TabStop = false;
            this.signup_tt.SetToolTip(this.signup_btnwarn, "#1. Password should be more than 8 characters.\r\n#2. Password should contain upper" +
        "case and lowercase characters.\r\n#3. Password should include numbers and symbols." +
        "\r\n");
            // 
            // signup_btnrequest
            // 
            this.signup_btnrequest.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signup_btnrequest.Location = new System.Drawing.Point(389, 262);
            this.signup_btnrequest.Name = "signup_btnrequest";
            this.signup_btnrequest.Size = new System.Drawing.Size(125, 31);
            this.signup_btnrequest.TabIndex = 16;
            this.signup_btnrequest.Text = "Request Code";
            this.signup_btnrequest.UseVisualStyleBackColor = true;
            this.signup_btnrequest.Click += new System.EventHandler(this.signup_btnrequest_Click);
            // 
            // signup_txtcpw
            // 
            this.signup_txtcpw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signup_txtcpw.ForeColor = System.Drawing.SystemColors.Desktop;
            this.signup_txtcpw.Location = new System.Drawing.Point(24, 408);
            this.signup_txtcpw.MaxLength = 200;
            this.signup_txtcpw.Multiline = true;
            this.signup_txtcpw.Name = "signup_txtcpw";
            this.signup_txtcpw.Size = new System.Drawing.Size(317, 50);
            this.signup_txtcpw.TabIndex = 15;
            this.signup_txtcpw.Text = "Confirm Password";
            this.signup_txtcpw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.signup_txtcpw.Enter += new System.EventHandler(this.signup_txtcpw_Enter);
            this.signup_txtcpw.Leave += new System.EventHandler(this.signup_txtcpw_Leave);
            this.signup_txtcpw.Validating += new System.ComponentModel.CancelEventHandler(this.signup_txtcpw_Validating);
            // 
            // signup_txtpw
            // 
            this.signup_txtpw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signup_txtpw.ForeColor = System.Drawing.SystemColors.Desktop;
            this.signup_txtpw.Location = new System.Drawing.Point(24, 322);
            this.signup_txtpw.MaxLength = 200;
            this.signup_txtpw.Multiline = true;
            this.signup_txtpw.Name = "signup_txtpw";
            this.signup_txtpw.Size = new System.Drawing.Size(317, 50);
            this.signup_txtpw.TabIndex = 14;
            this.signup_txtpw.Text = "Password";
            this.signup_txtpw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.signup_txtpw.Enter += new System.EventHandler(this.signup_txtpw_Enter);
            this.signup_txtpw.Leave += new System.EventHandler(this.signup_txtpw_Leave);
            this.signup_txtpw.Validating += new System.ComponentModel.CancelEventHandler(this.signup_txtpw_Validating);
            // 
            // signup_txtcode
            // 
            this.signup_txtcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signup_txtcode.ForeColor = System.Drawing.SystemColors.Desktop;
            this.signup_txtcode.Location = new System.Drawing.Point(298, 206);
            this.signup_txtcode.MaxLength = 200;
            this.signup_txtcode.Multiline = true;
            this.signup_txtcode.Name = "signup_txtcode";
            this.signup_txtcode.Size = new System.Drawing.Size(216, 50);
            this.signup_txtcode.TabIndex = 13;
            this.signup_txtcode.Text = "Admin Code";
            this.signup_txtcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.signup_txtcode.Enter += new System.EventHandler(this.signup_txtcode_Enter);
            this.signup_txtcode.Leave += new System.EventHandler(this.signup_txtcode_Leave);
            this.signup_txtcode.Validating += new System.ComponentModel.CancelEventHandler(this.signup_txtcode_Validating);
            // 
            // signup_txtposition
            // 
            this.signup_txtposition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signup_txtposition.ForeColor = System.Drawing.SystemColors.Desktop;
            this.signup_txtposition.Location = new System.Drawing.Point(24, 206);
            this.signup_txtposition.MaxLength = 200;
            this.signup_txtposition.Multiline = true;
            this.signup_txtposition.Name = "signup_txtposition";
            this.signup_txtposition.Size = new System.Drawing.Size(216, 50);
            this.signup_txtposition.TabIndex = 12;
            this.signup_txtposition.Text = "Position";
            this.signup_txtposition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.signup_txtposition.Enter += new System.EventHandler(this.signup_txtposition_Enter);
            this.signup_txtposition.Leave += new System.EventHandler(this.signup_txtposition_Leave);
            this.signup_txtposition.Validating += new System.ComponentModel.CancelEventHandler(this.signup_txtposition_Validating);
            // 
            // signup_txtemail
            // 
            this.signup_txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signup_txtemail.ForeColor = System.Drawing.SystemColors.Desktop;
            this.signup_txtemail.Location = new System.Drawing.Point(24, 117);
            this.signup_txtemail.MaxLength = 200;
            this.signup_txtemail.Multiline = true;
            this.signup_txtemail.Name = "signup_txtemail";
            this.signup_txtemail.Size = new System.Drawing.Size(490, 50);
            this.signup_txtemail.TabIndex = 11;
            this.signup_txtemail.Text = "Email";
            this.signup_txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.signup_txtemail.Enter += new System.EventHandler(this.signup_txtemail_Enter);
            this.signup_txtemail.Leave += new System.EventHandler(this.signup_txtemail_Leave);
            this.signup_txtemail.Validating += new System.ComponentModel.CancelEventHandler(this.signup_txtemail_Validating);
            // 
            // signup_txtln
            // 
            this.signup_txtln.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signup_txtln.ForeColor = System.Drawing.SystemColors.Desktop;
            this.signup_txtln.Location = new System.Drawing.Point(298, 26);
            this.signup_txtln.MaxLength = 200;
            this.signup_txtln.Multiline = true;
            this.signup_txtln.Name = "signup_txtln";
            this.signup_txtln.Size = new System.Drawing.Size(216, 50);
            this.signup_txtln.TabIndex = 10;
            this.signup_txtln.Text = "Last Name";
            this.signup_txtln.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.signup_txtln.Enter += new System.EventHandler(this.signup_txtln_Enter);
            this.signup_txtln.Leave += new System.EventHandler(this.signup_txtln_Leave);
            this.signup_txtln.Validating += new System.ComponentModel.CancelEventHandler(this.signup_txtln_Validating);
            // 
            // signup_txtfn
            // 
            this.signup_txtfn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signup_txtfn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.signup_txtfn.Location = new System.Drawing.Point(24, 26);
            this.signup_txtfn.MaxLength = 200;
            this.signup_txtfn.Multiline = true;
            this.signup_txtfn.Name = "signup_txtfn";
            this.signup_txtfn.Size = new System.Drawing.Size(216, 50);
            this.signup_txtfn.TabIndex = 9;
            this.signup_txtfn.Text = "First Name";
            this.signup_txtfn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.signup_txtfn.Enter += new System.EventHandler(this.signup_txtfn_Enter);
            this.signup_txtfn.Leave += new System.EventHandler(this.signup_txtfn_Leave);
            this.signup_txtfn.Validating += new System.ComponentModel.CancelEventHandler(this.signup_txtfn_Validating);
            // 
            // signup_errp
            // 
            this.signup_errp.ContainerControl = this;
            // 
            // sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 753);
            this.Controls.Add(this.signup_pnlsignup);
            this.Controls.Add(this.signup_btnback);
            this.Controls.Add(this.signup_btnhelp);
            this.Controls.Add(this.signup_btnsignup);
            this.Controls.Add(this.signup_lblsignup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "sign_up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Sign Up";
            this.Load += new System.EventHandler(this.sign_up_Load);
            ((System.ComponentModel.ISupportInitialize)(this.signup_btnhelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signup_btnback)).EndInit();
            this.signup_pnlsignup.ResumeLayout(false);
            this.signup_pnlsignup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signup_btnwarn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signup_errp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signup_lblsignup;
        private System.Windows.Forms.Button signup_btnsignup;
        private System.Windows.Forms.PictureBox signup_btnhelp;
        private System.Windows.Forms.PictureBox signup_btnback;
        private System.Windows.Forms.Panel signup_pnlsignup;
        private System.Windows.Forms.Button signup_btnrequest;
        private System.Windows.Forms.TextBox signup_txtcpw;
        private System.Windows.Forms.TextBox signup_txtpw;
        private System.Windows.Forms.TextBox signup_txtcode;
        private System.Windows.Forms.TextBox signup_txtposition;
        private System.Windows.Forms.TextBox signup_txtemail;
        private System.Windows.Forms.TextBox signup_txtln;
        private System.Windows.Forms.TextBox signup_txtfn;
        private System.Windows.Forms.PictureBox signup_btnwarn;
        private System.Windows.Forms.ToolTip signup_tt;
        private System.Windows.Forms.ErrorProvider signup_errp;
    }
}