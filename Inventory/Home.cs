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
    public partial class Home : Form
    {
        Db db = new Db();
        public Home()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2AnimateWindow1.SetAnimateWindow(this);
            WindowState = FormWindowState.Maximized;
            lb_time.Text = DateTime.Now.ToLongTimeString();
            lb_date.Text = DateTime.Now.ToShortDateString();
            lab_username.Text = Properties.Settings.Default.username;

            btn_exp.Text += "  :  "+ db.single("select COUNT(*) from item where barwary_basarchwn <= '" + DateTime.Now.ToString("yyyy-MM-dd") + "' ");
            btn_los.Text += "  :  " + db.single("select COUNT(*) from item where koy_dana <= '10' ");
            btn_NA.Text += "  :  " + db.single("select COUNT(*) from item where koy_dana = '0' ");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            frmInventory f = new frmInventory();
            f.ShowDialog();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            frmSell f = new frmSell();
            f.ShowDialog();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            frmFroshraw f = new frmFroshraw();
            f.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmXarje f = new frmXarje();
            f.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frmMandub f = new frmMandub();
            f.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmBackToKoga f = new frmBackToKoga();
            f.ShowDialog();
        }

        private void btn_raport_Click(object sender, EventArgs e)
        {
            frmDanaway_Qarz f = new frmDanaway_Qarz();
            f.ShowDialog();
        }

        private void btn_saveData_Click(object sender, EventArgs e)
        {
            frmBackUpRestore f = new frmBackUpRestore();
            f.ShowDialog();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            frmAccount f = new frmAccount();
            f.ShowDialog();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void btn_exp_Click(object sender, EventArgs e)
        {
            frmExpire f = new frmExpire();
            f.ShowDialog();
        }

        private void btn_los_Click(object sender, EventArgs e)
        {
            frmLossItem f = new frmLossItem();
            f.ShowDialog();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            frmReport f = new frmReport();
            f.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToLongTimeString();
            lb_date.Text = DateTime.Now.ToShortDateString();
            timer1.Start();
        }

        private void btn_NA_Click(object sender, EventArgs e)
        {
            frmNonAvalibleItem f = new frmNonAvalibleItem();
            f.ShowDialog();
        }
    }
}
