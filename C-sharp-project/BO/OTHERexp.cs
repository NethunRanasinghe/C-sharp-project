using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace C_sharp_project
{
    public partial class OTHERexp : Form
    {
        public OTHERexp()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void extbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fwdbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ACother2 = new ACother2();
            ACother2.Show();

        }

        private void prvbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var SCNDfrm = new SCNDfrm();
            SCNDfrm.Show();
        }
    }
}
