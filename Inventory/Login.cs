using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Inventory
{
    public partial class Login : Form
    {
        Db db = new Db();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            guna2AnimateWindow1.SetAnimateWindow(this);
            txt_naw.Text = "admin";
            txt_pass.Text = "12345";
            txt_naw.Focus();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.str = txt_naw.Text;
            db.bind(new string[] { "username", txt_naw.Text, "password", txt_pass.Text });
            string[] users = db.row("select * from users where username =@username and  password =@password ");
            if (users[0] != null)
            {
                Properties.Settings.Default.id = users[0];
                Properties.Settings.Default.username = users[1];
                if (users[4] == "0")
                {
                    backUp();
                    Home f = new Home();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    backUp();
                    Home f = new Home();
                    f.btn4.Enabled = false;
                    f.btn3.Enabled = false;
                    f.btn1.Enabled = false;
                    f.btn_ex.Enabled = false;
                    f.btn_loss.Enabled = false;
                    f.btn_raport.Enabled = false;
                    f.btn_xarje.Enabled = false;
                    f.Show();
                    this.Hide();
                }
            }
            if (users[0] == null)
            {
                MessageBox.Show("ناوی بەکارهێن هەڵەیە یان وشەی تێبەر هەڵەیە");
            }


        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Invntory;User ID=sa;Password=kurdstan;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            backUp();
        }
        public void backUp()
        {
            string database = con.Database.ToString();
            try
            {
                if (File.Exists(@"D:\backUpDataInventory\BackUp_Inventory_Database.bak"))
                {
                    File.Delete(@"D:\backUpDataInventory\BackUp_Inventory_Database.bak");
                }

                string cmd = @"BACKUP DATABASE [" + database + "] TO DISK='D:\\backUpDataInventory\\" + "BackUp_Inventory_Database" + ".bak'";
                con.Open();
                SqlCommand comand = new SqlCommand(cmd, con);
                comand.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception) { }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
