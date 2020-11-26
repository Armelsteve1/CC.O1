using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formEtablisement
{
    public partial class connecte : Form
    {
        public connecte()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnconecole_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.Show();
        }

        private void btnconetudiant_Click(object sender, EventArgs e)
        {
            Form f = new frmcarte();
            f.Show();
        }
    }
}
