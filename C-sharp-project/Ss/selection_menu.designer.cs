namespace C_sharp_project
{
    partial class form_selectionmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_selectionmenu));
            this.lblwelcometext = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_sales = new System.Windows.Forms.Label();
            this.lbl_buying = new System.Windows.Forms.Label();
            this.lbl_othersales = new System.Windows.Forms.Label();
            this.lbl_acccheck = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_sales = new System.Windows.Forms.Button();
            this.Btn_buying = new System.Windows.Forms.Button();
            this.Btn_othersales = new System.Windows.Forms.Button();
            this.Btn_check = new System.Windows.Forms.Button();
            this.Btn_list = new System.Windows.Forms.Button();
            this.GroupBox_menu = new System.Windows.Forms.GroupBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.Btn_prevMenu = new System.Windows.Forms.Button();
            this.GroupBox_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblwelcometext
            // 
            this.lblwelcometext.AutoSize = true;
            this.lblwelcometext.BackColor = System.Drawing.Color.Transparent;
            this.lblwelcometext.Cursor = System.Windows.Forms.Cursors.No;
            this.lblwelcometext.Font = new System.Drawing.Font("Baskerville Old Face", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcometext.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblwelcometext.Location = new System.Drawing.Point(323, 29);
            this.lblwelcometext.Name = "lblwelcometext";
            this.lblwelcometext.Size = new System.Drawing.Size(262, 44);
            this.lblwelcometext.TabIndex = 0;
            this.lblwelcometext.Text = "Selection Menu";
            this.lblwelcometext.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_user.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl_user.Font = new System.Drawing.Font("SimSun-ExtB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_user.Location = new System.Drawing.Point(124, 92);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(109, 29);
            this.lbl_user.TabIndex = 1;
            this.lbl_user.Text = "User :";
            this.lbl_user.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_sales
            // 
            this.lbl_sales.AutoSize = true;
            this.lbl_sales.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sales.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl_sales.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sales.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_sales.Location = new System.Drawing.Point(115, 11);
            this.lbl_sales.Name = "lbl_sales";
            this.lbl_sales.Size = new System.Drawing.Size(93, 29);
            this.lbl_sales.TabIndex = 2;
            this.lbl_sales.Text = "Sales";
            this.lbl_sales.Click += new System.EventHandler(this.lbl_sales_Click);
            // 
            // lbl_buying
            // 
            this.lbl_buying.AutoSize = true;
            this.lbl_buying.BackColor = System.Drawing.Color.Transparent;
            this.lbl_buying.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl_buying.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Bold);
            this.lbl_buying.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_buying.Location = new System.Drawing.Point(115, 67);
            this.lbl_buying.Name = "lbl_buying";
            this.lbl_buying.Size = new System.Drawing.Size(109, 29);
            this.lbl_buying.TabIndex = 3;
            this.lbl_buying.Text = "Buying";
            // 
            // lbl_othersales
            // 
            this.lbl_othersales.AutoSize = true;
            this.lbl_othersales.BackColor = System.Drawing.Color.Transparent;
            this.lbl_othersales.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl_othersales.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Bold);
            this.lbl_othersales.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_othersales.Location = new System.Drawing.Point(115, 122);
            this.lbl_othersales.Name = "lbl_othersales";
            this.lbl_othersales.Size = new System.Drawing.Size(189, 29);
            this.lbl_othersales.TabIndex = 4;
            this.lbl_othersales.Text = "Other Sales";
            // 
            // lbl_acccheck
            // 
            this.lbl_acccheck.AutoSize = true;
            this.lbl_acccheck.BackColor = System.Drawing.Color.Transparent;
            this.lbl_acccheck.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl_acccheck.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Bold);
            this.lbl_acccheck.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_acccheck.Location = new System.Drawing.Point(115, 170);
            this.lbl_acccheck.Name = "lbl_acccheck";
            this.lbl_acccheck.Size = new System.Drawing.Size(221, 29);
            this.lbl_acccheck.TabIndex = 5;
            this.lbl_acccheck.Text = "Account Check";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(117, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wood List";
            // 
            // Btn_sales
            // 
            this.Btn_sales.BackColor = System.Drawing.Color.White;
            this.Btn_sales.BackgroundImage = global::C_sharp_project.Properties.Resources.texture_background;
            this.Btn_sales.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_sales.ForeColor = System.Drawing.Color.Snow;
            this.Btn_sales.Location = new System.Drawing.Point(410, 11);
            this.Btn_sales.Name = "Btn_sales";
            this.Btn_sales.Size = new System.Drawing.Size(195, 34);
            this.Btn_sales.TabIndex = 7;
            this.Btn_sales.Text = "Sales";
            this.Btn_sales.UseVisualStyleBackColor = false;
            this.Btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // Btn_buying
            // 
            this.Btn_buying.BackColor = System.Drawing.Color.White;
            this.Btn_buying.BackgroundImage = global::C_sharp_project.Properties.Resources.texture_background;
            this.Btn_buying.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_buying.ForeColor = System.Drawing.Color.Snow;
            this.Btn_buying.Location = new System.Drawing.Point(410, 68);
            this.Btn_buying.Name = "Btn_buying";
            this.Btn_buying.Size = new System.Drawing.Size(195, 34);
            this.Btn_buying.TabIndex = 8;
            this.Btn_buying.Text = "Buying";
            this.Btn_buying.UseVisualStyleBackColor = false;
            this.Btn_buying.Click += new System.EventHandler(this.btn_buying_Click);
            // 
            // Btn_othersales
            // 
            this.Btn_othersales.BackColor = System.Drawing.Color.White;
            this.Btn_othersales.BackgroundImage = global::C_sharp_project.Properties.Resources.texture_background;
            this.Btn_othersales.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_othersales.ForeColor = System.Drawing.Color.Snow;
            this.Btn_othersales.Location = new System.Drawing.Point(410, 114);
            this.Btn_othersales.Name = "Btn_othersales";
            this.Btn_othersales.Size = new System.Drawing.Size(195, 34);
            this.Btn_othersales.TabIndex = 9;
            this.Btn_othersales.Text = "Other";
            this.Btn_othersales.UseVisualStyleBackColor = false;
            this.Btn_othersales.Click += new System.EventHandler(this.btn_othersales_Click);
            // 
            // Btn_check
            // 
            this.Btn_check.BackColor = System.Drawing.Color.White;
            this.Btn_check.BackgroundImage = global::C_sharp_project.Properties.Resources.texture_background;
            this.Btn_check.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_check.ForeColor = System.Drawing.Color.Snow;
            this.Btn_check.Location = new System.Drawing.Point(410, 166);
            this.Btn_check.Name = "Btn_check";
            this.Btn_check.Size = new System.Drawing.Size(195, 34);
            this.Btn_check.TabIndex = 10;
            this.Btn_check.Text = "Check";
            this.Btn_check.UseVisualStyleBackColor = false;
            this.Btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // Btn_list
            // 
            this.Btn_list.BackColor = System.Drawing.Color.White;
            this.Btn_list.BackgroundImage = global::C_sharp_project.Properties.Resources.texture_background;
            this.Btn_list.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_list.ForeColor = System.Drawing.Color.Snow;
            this.Btn_list.Location = new System.Drawing.Point(410, 219);
            this.Btn_list.Name = "Btn_list";
            this.Btn_list.Size = new System.Drawing.Size(195, 34);
            this.Btn_list.TabIndex = 11;
            this.Btn_list.Text = "List";
            this.Btn_list.UseVisualStyleBackColor = false;
            this.Btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // GroupBox_menu
            // 
            this.GroupBox_menu.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox_menu.Controls.Add(this.Btn_list);
            this.GroupBox_menu.Controls.Add(this.Btn_check);
            this.GroupBox_menu.Controls.Add(this.Btn_othersales);
            this.GroupBox_menu.Controls.Add(this.Btn_buying);
            this.GroupBox_menu.Controls.Add(this.Btn_sales);
            this.GroupBox_menu.Controls.Add(this.label1);
            this.GroupBox_menu.Controls.Add(this.lbl_acccheck);
            this.GroupBox_menu.Controls.Add(this.lbl_othersales);
            this.GroupBox_menu.Controls.Add(this.lbl_buying);
            this.GroupBox_menu.Controls.Add(this.lbl_sales);
            this.GroupBox_menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GroupBox_menu.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.GroupBox_menu.Location = new System.Drawing.Point(129, 142);
            this.GroupBox_menu.Name = "GroupBox_menu";
            this.GroupBox_menu.Size = new System.Drawing.Size(659, 284);
            this.GroupBox_menu.TabIndex = 12;
            this.GroupBox_menu.TabStop = false;
            this.GroupBox_menu.Enter += new System.EventHandler(this.groupBox_menu_Enter);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(229, 100);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(126, 20);
            this.TextBox1.TabIndex = 13;
            // 
            // Btn_exit
            // 
            this.Btn_exit.BackColor = System.Drawing.Color.White;
            this.Btn_exit.BackgroundImage = global::C_sharp_project.Properties.Resources.texture_background;
            this.Btn_exit.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_exit.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Btn_exit.Location = new System.Drawing.Point(761, 440);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(91, 34);
            this.Btn_exit.TabIndex = 12;
            this.Btn_exit.Text = "Exit";
            this.Btn_exit.UseVisualStyleBackColor = false;
            this.Btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Btn_prevMenu
            // 
            this.Btn_prevMenu.BackColor = System.Drawing.Color.White;
            this.Btn_prevMenu.BackgroundImage = global::C_sharp_project.Properties.Resources.texture_background;
            this.Btn_prevMenu.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_prevMenu.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Btn_prevMenu.Location = new System.Drawing.Point(12, 440);
            this.Btn_prevMenu.Name = "Btn_prevMenu";
            this.Btn_prevMenu.Size = new System.Drawing.Size(100, 34);
            this.Btn_prevMenu.TabIndex = 14;
            this.Btn_prevMenu.Text = "Back ";
            this.Btn_prevMenu.UseVisualStyleBackColor = false;
            this.Btn_prevMenu.Click += new System.EventHandler(this.btn_prevMenu_Click);
            // 
            // form_selectionmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::C_sharp_project.Properties.Resources.texture_background;
            this.ClientSize = new System.Drawing.Size(864, 486);
            this.Controls.Add(this.Btn_prevMenu);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.GroupBox_menu);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lblwelcometext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_selectionmenu";
            this.Text = "Ranasinghe Sawmills";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox_menu.ResumeLayout(false);
            this.GroupBox_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwelcometext;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_sales;
        private System.Windows.Forms.Label lbl_buying;
        private System.Windows.Forms.Label lbl_othersales;
        private System.Windows.Forms.Label lbl_acccheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_sales;
        private System.Windows.Forms.Button Btn_buying;
        private System.Windows.Forms.Button Btn_othersales;
        private System.Windows.Forms.Button Btn_check;
        private System.Windows.Forms.Button Btn_list;
        private System.Windows.Forms.GroupBox GroupBox_menu;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.Button Btn_prevMenu;
    }
}