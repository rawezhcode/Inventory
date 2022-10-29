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
    public partial class frmBackUpRestore : Form
    {
        public frmBackUpRestore()
        {
            InitializeComponent();
        }

        private void btn_exp_Click(object sender, EventArgs e)
        {
            frmBackUp f = new frmBackUp();
            f.ShowDialog();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            frmRestory f = new frmRestory();
            f.ShowDialog();
        }
    }
}
