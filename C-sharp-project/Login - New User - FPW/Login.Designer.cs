namespace C_sharp_project
{
    partial class login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.login_bpanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.login_btnclear = new System.Windows.Forms.Button();
            this.login_btnlgin = new System.Windows.Forms.Button();
            this.login_tpanel = new System.Windows.Forms.Panel();
            this.login_txtpw = new C_sharp_project.CustomTextBox();
            this.login_txtusr = new C_sharp_project.CustomTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_lblfpw = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.login_errp = new System.Windows.Forms.ErrorProvider(this.components);
            this.login_tt = new System.Windows.Forms.ToolTip(this.components);
            this.login_bpanel.SuspendLayout();
            this.login_tpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_errp)).BeginInit();
            this.SuspendLayout();
            // 
            // login_bpanel
            // 
            this.login_bpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_bpanel.AutoSize = true;
            this.login_bpanel.BackColor = System.Drawing.Color.Bisque;
            this.login_bpanel.Controls.Add(this.label5);
            this.login_bpanel.Controls.Add(this.login_btnclear);
            this.login_bpanel.Controls.Add(this.login_btnlgin);
            this.login_bpanel.Controls.Add(this.login_tpanel);
            this.login_bpanel.Location = new System.Drawing.Point(127, 27);
            this.login_bpanel.Name = "login_bpanel";
            this.login_bpanel.Size = new System.Drawing.Size(752, 464);
            this.login_bpanel.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(53, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(649, 46);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ranasinghe Saw Mill and Timber Stores";
            // 
            // login_btnclear
            // 
            this.login_btnclear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_btnclear.AutoSize = true;
            this.login_btnclear.BackColor = System.Drawing.Color.Bisque;
            this.login_btnclear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_btnclear.Location = new System.Drawing.Point(574, 395);
            this.login_btnclear.Name = "login_btnclear";
            this.login_btnclear.Size = new System.Drawing.Size(152, 43);
            this.login_btnclear.TabIndex = 2;
            this.login_btnclear.Text = "Clear";
            this.login_btnclear.UseVisualStyleBackColor = false;
            this.login_btnclear.Click += new System.EventHandler(this.login_btnclear_Click);
            // 
            // login_btnlgin
            // 
            this.login_btnlgin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_btnlgin.AutoSize = true;
            this.login_btnlgin.BackColor = System.Drawing.Color.Bisque;
            this.login_btnlgin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_btnlgin.Location = new System.Drawing.Point(363, 395);
            this.login_btnlgin.Name = "login_btnlgin";
            this.login_btnlgin.Size = new System.Drawing.Size(152, 43);
            this.login_btnlgin.TabIndex = 1;
            this.login_btnlgin.Text = "Log In";
            this.login_btnlgin.UseVisualStyleBackColor = false;
            this.login_btnlgin.Click += new System.EventHandler(this.login_btnlgin_Click);
            // 
            // login_tpanel
            // 
            this.login_tpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_tpanel.AutoSize = true;
            this.login_tpanel.BackColor = System.Drawing.Color.PeachPuff;
            this.login_tpanel.Controls.Add(this.login_txtpw);
            this.login_tpanel.Controls.Add(this.login_txtusr);
            this.login_tpanel.Controls.Add(this.label4);
            this.login_tpanel.Controls.Add(this.label3);
            this.login_tpanel.Controls.Add(this.login_lblfpw);
            this.login_tpanel.Controls.Add(this.label2);
            this.login_tpanel.Controls.Add(this.label1);
            this.login_tpanel.Location = new System.Drawing.Point(26, 93);
            this.login_tpanel.Name = "login_tpanel";
            this.login_tpanel.Size = new System.Drawing.Size(709, 255);
            this.login_tpanel.TabIndex = 0;
            // 
            // login_txtpw
            // 
            this.login_txtpw.BackColor = System.Drawing.Color.PeachPuff;
            this.login_txtpw.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.login_txtpw.BorderFocusColor = System.Drawing.Color.HotPink;
            this.login_txtpw.BorderSize = 2;
            this.login_txtpw.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_txtpw.ForeColor = System.Drawing.Color.Black;
            this.login_txtpw.Location = new System.Drawing.Point(223, 141);
            this.login_txtpw.Multiline = false;
            this.login_txtpw.Name = "login_txtpw";
            this.login_txtpw.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.login_txtpw.PasswordChar = false;
            this.login_txtpw.Size = new System.Drawing.Size(446, 36);
            this.login_txtpw.TabIndex = 6;
            this.login_txtpw.Texts = "Password";
            this.login_txtpw.UnderlinedStyle = true;
            this.login_txtpw.Enter += new System.EventHandler(this.login_txtpw_Enter);
            this.login_txtpw.Leave += new System.EventHandler(this.login_txtpw_Leave);
            this.login_txtpw.Validating += new System.ComponentModel.CancelEventHandler(this.login_txtpw_Validating);
            // 
            // login_txtusr
            // 
            this.login_txtusr.BackColor = System.Drawing.Color.PeachPuff;
            this.login_txtusr.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.login_txtusr.BorderFocusColor = System.Drawing.Color.HotPink;
            this.login_txtusr.BorderSize = 2;
            this.login_txtusr.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_txtusr.ForeColor = System.Drawing.Color.Black;
            this.login_txtusr.Location = new System.Drawing.Point(223, 29);
            this.login_txtusr.Multiline = false;
            this.login_txtusr.Name = "login_txtusr";
            this.login_txtusr.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.login_txtusr.PasswordChar = false;
            this.login_txtusr.Size = new System.Drawing.Size(446, 36);
            this.login_txtusr.TabIndex = 5;
            this.login_txtusr.Texts = "First Name";
            this.login_txtusr.UnderlinedStyle = true;
            this.login_txtusr.Enter += new System.EventHandler(this.login_txtusr_Enter);
            this.login_txtusr.Leave += new System.EventHandler(this.login_txtusr_Leave);
            this.login_txtusr.Validating += new System.ComponentModel.CancelEventHandler(this.login_txtusr_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(176, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(176, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = ":";
            // 
            // login_lblfpw
            // 
            this.login_lblfpw.AutoSize = true;
            this.login_lblfpw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_lblfpw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_lblfpw.LinkColor = System.Drawing.Color.SaddleBrown;
            this.login_lblfpw.Location = new System.Drawing.Point(509, 217);
            this.login_lblfpw.Name = "login_lblfpw";
            this.login_lblfpw.Size = new System.Drawing.Size(172, 28);
            this.login_lblfpw.TabIndex = 2;
            this.login_lblfpw.TabStop = true;
            this.login_lblfpw.Text = "Forgot Password ?";
            this.login_tt.SetToolTip(this.login_lblfpw, "Click here to reset the password.");
            this.login_lblfpw.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.login_lblfpw_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::C_sharp_project.Properties.Resources.login_help;
            this.pictureBox1.Location = new System.Drawing.Point(954, 501);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.login_tt.SetToolTip(this.pictureBox1, "Click here to see login help.");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::C_sharp_project.Properties.Resources.login_add;
            this.pictureBox2.Location = new System.Drawing.Point(878, 501);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.login_tt.SetToolTip(this.pictureBox2, "Click here to sign up as a new user.");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // login_errp
            // 
            this.login_errp.ContainerControl = this;
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.login_bpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.login_bpanel.ResumeLayout(false);
            this.login_bpanel.PerformLayout();
            this.login_tpanel.ResumeLayout(false);
            this.login_tpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_errp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel login_bpanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button login_btnclear;
        private System.Windows.Forms.Button login_btnlgin;
        private System.Windows.Forms.Panel login_tpanel;
        private CustomTextBox login_txtpw;
        private CustomTextBox login_txtusr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel login_lblfpw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider login_errp;
        private System.Windows.Forms.ToolTip login_tt;
    }
}