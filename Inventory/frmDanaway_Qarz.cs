using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class frmDanaway_Qarz : Form
    {
        public frmDanaway_Qarz()
        {
            InitializeComponent();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            frmDanaway_Q_Company f = new frmDanaway_Q_Company();
            f.ShowDialog();
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            frmDanaway_Q_Kryar f = new frmDanaway_Q_Kryar();
            f.ShowDialog();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            frmAddQarzCompany f = new frmAddQarzCompany();
            f.ShowDialog();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            frmAddQarzKryar f = new frmAddQarzKryar();
            f.ShowDialog();
        }
    }
}
