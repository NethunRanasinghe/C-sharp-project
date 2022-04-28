namespace C_sharp_project
{
    partial class Choose_Database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choose_Database));
            this.label1 = new System.Windows.Forms.Label();
            this.choose_btnCont = new System.Windows.Forms.Button();
            this.cdb_combo = new System.Windows.Forms.ComboBox();
            this.cdb_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cdb_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a Database";
            // 
            // choose_btnCont
            // 
            this.choose_btnCont.BackColor = System.Drawing.Color.PeachPuff;
            this.choose_btnCont.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.choose_btnCont.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.choose_btnCont.Location = new System.Drawing.Point(0, 168);
            this.choose_btnCont.Name = "choose_btnCont";
            this.choose_btnCont.Size = new System.Drawing.Size(577, 75);
            this.choose_btnCont.TabIndex = 2;
            this.choose_btnCont.Text = "Continue";
            this.choose_btnCont.UseVisualStyleBackColor = false;
            this.choose_btnCont.Click += new System.EventHandler(this.choose_btnCont_Click);
            // 
            // cdb_combo
            // 
            this.cdb_combo.BackColor = System.Drawing.Color.White;
            this.cdb_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdb_combo.FormattingEnabled = true;
            this.cdb_combo.Items.AddRange(new object[] {
            "1. Local Database (XAMPP)",
            "2. Remote Database (DigitalOcean) - Recommended"});
            this.cdb_combo.Location = new System.Drawing.Point(38, 120);
            this.cdb_combo.Name = "cdb_combo";
            this.cdb_combo.Size = new System.Drawing.Size(500, 28);
            this.cdb_combo.TabIndex = 3;
            this.cdb_combo.Text = "Hint :- Select a Database from the drop down menu      -->";
            this.cdb_combo.SelectedIndexChanged += new System.EventHandler(this.cdb_combo_SelectedIndexChanged);
            this.cdb_combo.Click += new System.EventHandler(this.cdb_combo_Click);
            // 
            // cdb_pic
            // 
            this.cdb_pic.BackColor = System.Drawing.Color.Transparent;
            this.cdb_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cdb_pic.Location = new System.Drawing.Point(253, 56);
            this.cdb_pic.Name = "cdb_pic";
            this.cdb_pic.Size = new System.Drawing.Size(55, 55);
            this.cdb_pic.TabIndex = 4;
            this.cdb_pic.TabStop = false;
            // 
            // Choose_Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C_sharp_project.Properties.Resources.texture_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(577, 243);
            this.Controls.Add(this.cdb_pic);
            this.Controls.Add(this.cdb_combo);
            this.Controls.Add(this.choose_btnCont);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Choose_Database";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose a Database";
            ((System.ComponentModel.ISupportInitialize)(this.cdb_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button choose_btnCont;
        private System.Windows.Forms.ComboBox cdb_combo;
        private System.Windows.Forms.PictureBox cdb_pic;
    }
}