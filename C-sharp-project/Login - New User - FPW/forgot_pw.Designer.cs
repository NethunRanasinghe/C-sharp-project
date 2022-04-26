namespace C_sharp_project
{
    partial class forgot_pw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgot_pw));
            this.label1 = new System.Windows.Forms.Label();
            this.fpw_txtemail = new System.Windows.Forms.TextBox();
            this.fpw_txtauthcode = new System.Windows.Forms.TextBox();
            this.fpw_txtnpw = new System.Windows.Forms.TextBox();
            this.fpw_txtcpw = new System.Windows.Forms.TextBox();
            this.fpw_btnrqcode = new System.Windows.Forms.Button();
            this.fpw_pnlfpw = new System.Windows.Forms.Panel();
            this.fpw_picback = new System.Windows.Forms.PictureBox();
            this.fpw_pichelp = new System.Windows.Forms.PictureBox();
            this.fpw_btncpw = new System.Windows.Forms.Button();
            this.forgot_pw_tt = new System.Windows.Forms.ToolTip(this.components);
            this.forgot_pw_errp = new System.Windows.Forms.ErrorProvider(this.components);
            this.fpw_pnlfpw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpw_picback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpw_pichelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forgot_pw_errp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forgot Password";
            // 
            // fpw_txtemail
            // 
            this.fpw_txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fpw_txtemail.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fpw_txtemail.ForeColor = System.Drawing.Color.SaddleBrown;
            this.fpw_txtemail.Location = new System.Drawing.Point(25, 26);
            this.fpw_txtemail.MaxLength = 200;
            this.fpw_txtemail.Multiline = true;
            this.fpw_txtemail.Name = "fpw_txtemail";
            this.fpw_txtemail.Size = new System.Drawing.Size(490, 50);
            this.fpw_txtemail.TabIndex = 1;
            this.fpw_txtemail.Text = "Email";
            this.fpw_txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fpw_txtemail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.fpw_txtemail.Enter += new System.EventHandler(this.fpw_txtemail_Enter);
            this.fpw_txtemail.Leave += new System.EventHandler(this.fpw_txtemail_Leave);
            this.fpw_txtemail.Validating += new System.ComponentModel.CancelEventHandler(this.fpw_txtemail_Validating);
            // 
            // fpw_txtauthcode
            // 
            this.fpw_txtauthcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fpw_txtauthcode.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fpw_txtauthcode.ForeColor = System.Drawing.Color.SaddleBrown;
            this.fpw_txtauthcode.Location = new System.Drawing.Point(25, 110);
            this.fpw_txtauthcode.MaxLength = 1000000;
            this.fpw_txtauthcode.Multiline = true;
            this.fpw_txtauthcode.Name = "fpw_txtauthcode";
            this.fpw_txtauthcode.Size = new System.Drawing.Size(241, 50);
            this.fpw_txtauthcode.TabIndex = 2;
            this.fpw_txtauthcode.Text = "Auth Code";
            this.fpw_txtauthcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fpw_txtauthcode.Enter += new System.EventHandler(this.fpw_txtauthcode_Enter);
            this.fpw_txtauthcode.Leave += new System.EventHandler(this.fpw_txtauthcode_Leave);
            this.fpw_txtauthcode.Validating += new System.ComponentModel.CancelEventHandler(this.fpw_txtauthcode_Validating);
            // 
            // fpw_txtnpw
            // 
            this.fpw_txtnpw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fpw_txtnpw.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fpw_txtnpw.ForeColor = System.Drawing.Color.SaddleBrown;
            this.fpw_txtnpw.Location = new System.Drawing.Point(25, 197);
            this.fpw_txtnpw.MaxLength = 200;
            this.fpw_txtnpw.Multiline = true;
            this.fpw_txtnpw.Name = "fpw_txtnpw";
            this.fpw_txtnpw.Size = new System.Drawing.Size(241, 50);
            this.fpw_txtnpw.TabIndex = 3;
            this.fpw_txtnpw.Text = "New Password";
            this.fpw_txtnpw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fpw_txtnpw.Enter += new System.EventHandler(this.fpw_txtnpw_Enter);
            this.fpw_txtnpw.Leave += new System.EventHandler(this.fpw_txtnpw_Leave);
            this.fpw_txtnpw.Validating += new System.ComponentModel.CancelEventHandler(this.fpw_txtnpw_Validating);
            // 
            // fpw_txtcpw
            // 
            this.fpw_txtcpw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fpw_txtcpw.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fpw_txtcpw.ForeColor = System.Drawing.Color.SaddleBrown;
            this.fpw_txtcpw.Location = new System.Drawing.Point(274, 197);
            this.fpw_txtcpw.MaxLength = 200;
            this.fpw_txtcpw.Multiline = true;
            this.fpw_txtcpw.Name = "fpw_txtcpw";
            this.fpw_txtcpw.Size = new System.Drawing.Size(241, 50);
            this.fpw_txtcpw.TabIndex = 4;
            this.fpw_txtcpw.Text = "Confirm  New Password";
            this.fpw_txtcpw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fpw_txtcpw.Enter += new System.EventHandler(this.fpw_txtcpw_Enter);
            this.fpw_txtcpw.Leave += new System.EventHandler(this.fpw_txtcpw_Leave);
            this.fpw_txtcpw.Validating += new System.ComponentModel.CancelEventHandler(this.fpw_txtcpw_Validating);
            // 
            // fpw_btnrqcode
            // 
            this.fpw_btnrqcode.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fpw_btnrqcode.ForeColor = System.Drawing.Color.SaddleBrown;
            this.fpw_btnrqcode.Location = new System.Drawing.Point(274, 110);
            this.fpw_btnrqcode.Name = "fpw_btnrqcode";
            this.fpw_btnrqcode.Size = new System.Drawing.Size(241, 50);
            this.fpw_btnrqcode.TabIndex = 5;
            this.fpw_btnrqcode.Text = "Request Code";
            this.fpw_btnrqcode.UseVisualStyleBackColor = true;
            this.fpw_btnrqcode.Click += new System.EventHandler(this.fpw_btnrqcode_Click);
            // 
            // fpw_pnlfpw
            // 
            this.fpw_pnlfpw.BackColor = System.Drawing.Color.LightGray;
            this.fpw_pnlfpw.Controls.Add(this.fpw_btnrqcode);
            this.fpw_pnlfpw.Controls.Add(this.fpw_txtcpw);
            this.fpw_pnlfpw.Controls.Add(this.fpw_txtnpw);
            this.fpw_pnlfpw.Controls.Add(this.fpw_txtauthcode);
            this.fpw_pnlfpw.Controls.Add(this.fpw_txtemail);
            this.fpw_pnlfpw.Location = new System.Drawing.Point(33, 88);
            this.fpw_pnlfpw.Name = "fpw_pnlfpw";
            this.fpw_pnlfpw.Size = new System.Drawing.Size(541, 276);
            this.fpw_pnlfpw.TabIndex = 6;
            // 
            // fpw_picback
            // 
            this.fpw_picback.BackColor = System.Drawing.Color.Transparent;
            this.fpw_picback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fpw_picback.Image = global::C_sharp_project.Properties.Resources.back;
            this.fpw_picback.Location = new System.Drawing.Point(460, 438);
            this.fpw_picback.Name = "fpw_picback";
            this.fpw_picback.Size = new System.Drawing.Size(40, 40);
            this.fpw_picback.TabIndex = 7;
            this.fpw_picback.TabStop = false;
            this.forgot_pw_tt.SetToolTip(this.fpw_picback, "Click here to go back to login page.");
            this.fpw_picback.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // fpw_pichelp
            // 
            this.fpw_pichelp.BackColor = System.Drawing.Color.Transparent;
            this.fpw_pichelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fpw_pichelp.Image = global::C_sharp_project.Properties.Resources.login_help;
            this.fpw_pichelp.Location = new System.Drawing.Point(534, 438);
            this.fpw_pichelp.Name = "fpw_pichelp";
            this.fpw_pichelp.Size = new System.Drawing.Size(40, 40);
            this.fpw_pichelp.TabIndex = 8;
            this.fpw_pichelp.TabStop = false;
            this.forgot_pw_tt.SetToolTip(this.fpw_pichelp, "Click here to see forgot password help.");
            this.fpw_pichelp.Click += new System.EventHandler(this.fpw_pichelp_Click);
            // 
            // fpw_btncpw
            // 
            this.fpw_btncpw.BackgroundImage = global::C_sharp_project.Properties.Resources.texture_background;
            this.fpw_btncpw.Font = new System.Drawing.Font("Baskerville Old Face", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fpw_btncpw.ForeColor = System.Drawing.Color.Snow;
            this.fpw_btncpw.Location = new System.Drawing.Point(58, 396);
            this.fpw_btncpw.Name = "fpw_btncpw";
            this.fpw_btncpw.Size = new System.Drawing.Size(151, 68);
            this.fpw_btncpw.TabIndex = 9;
            this.fpw_btncpw.Text = "Change Password";
            this.fpw_btncpw.UseVisualStyleBackColor = true;
            this.fpw_btncpw.Click += new System.EventHandler(this.fpw_btncpw_Click);
            // 
            // forgot_pw_errp
            // 
            this.forgot_pw_errp.ContainerControl = this;
            // 
            // forgot_pw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C_sharp_project.Properties.Resources.texture_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(606, 514);
            this.Controls.Add(this.fpw_btncpw);
            this.Controls.Add(this.fpw_pichelp);
            this.Controls.Add(this.fpw_picback);
            this.Controls.Add(this.fpw_pnlfpw);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "forgot_pw";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.forgot_pw_Load);
            this.fpw_pnlfpw.ResumeLayout(false);
            this.fpw_pnlfpw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpw_picback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpw_pichelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forgot_pw_errp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fpw_txtemail;
        private System.Windows.Forms.TextBox fpw_txtauthcode;
        private System.Windows.Forms.TextBox fpw_txtnpw;
        private System.Windows.Forms.TextBox fpw_txtcpw;
        private System.Windows.Forms.Button fpw_btnrqcode;
        private System.Windows.Forms.Panel fpw_pnlfpw;
        private System.Windows.Forms.PictureBox fpw_picback;
        private System.Windows.Forms.PictureBox fpw_pichelp;
        private System.Windows.Forms.Button fpw_btncpw;
        private System.Windows.Forms.ToolTip forgot_pw_tt;
        private System.Windows.Forms.ErrorProvider forgot_pw_errp;
    }
}