using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Inventory
{
    public partial class frmRestory : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Invntory;User ID=sa;Password=kurdstan;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");

        public frmRestory()
        {
            InitializeComponent();
        }

        private void btnRsetBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog dig = new OpenFileDialog();
            dig.Filter = "SQL SERVER database backup files|*.bak";
            dig.Title = "DATABASE RESTPRE";
            if (dig.ShowDialog() == DialogResult.OK)
            {
                txt_RestoreBrowser.Text = dig.FileName;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();
            //string database = "Shoping.mdf";
            try
            {
                con.Open();
                string sqlstm2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(sqlstm2, con);
                cmd1.ExecuteNonQuery();

                string sqlstm3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + txt_RestoreBrowser.Text + "'WITH REPLACE ";
                SqlCommand cmd2 = new SqlCommand(sqlstm3, con);
                cmd2.ExecuteNonQuery();

                string sqlstm4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(sqlstm4, con);
                cmd3.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("به‌سه‌ركه‌وتووی داتاكان گه‌رێندرانه‌وه‌");
            }
            catch (Exception)
            {

            }
        }
    }
}
