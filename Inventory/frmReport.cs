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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            report.frmFroshtn_rp f = new report.frmFroshtn_rp();
            f.ShowDialog();
        }

        private void btn_exp_Click(object sender, EventArgs e)
        {
            report.frmFroshraw_rp f = new report.frmFroshraw_rp();
            f.ShowDialog();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            report.frmKryar_rpt f = new report.frmKryar_rpt();
            f.ShowDialog();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            report.frmMandub_rp f = new report.frmMandub_rp();
            f.ShowDialog();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            report.frmXarje_rp f = new report.frmXarje_rp();
            f.ShowDialog();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            report.frmFroshyar_rpt f = new report.frmFroshyar_rpt();
            f.ShowDialog();
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            report.frmKryarWasl_rpt f = new report.frmKryarWasl_rpt();
            f.ShowDialog();
        }
    }
}
