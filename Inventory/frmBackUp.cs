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
    public partial class frmBackUp : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Invntory;User ID=sa;Password=kurdstan;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");

        public frmBackUp()
        {
            InitializeComponent();
        }

        private void btn_BackBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dig = new FolderBrowserDialog();
            if (dig.ShowDialog() == DialogResult.OK)
            {
                txt_BackupBrowser.Text = dig.SelectedPath;
            }
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            //string database = "Shoping.mdf";
            string database = con.Database.ToString();
            try
            {
                if (File.Exists(txt_BackupBrowser.Text + "\\" + "BackUp_Inventory_Database.bak"))
                {
                    File.Delete(txt_BackupBrowser.Text + "\\" + "BackUp_Inventory_Database.bak");
                }
                if (txt_BackupBrowser.Text == string.Empty)
                {
                    MessageBox.Show("");
                }
                else
                {
                    string cmd = @"BACKUP DATABASE [" + database + "] TO DISK='" + txt_BackupBrowser.Text + "\\" + "BackUp_Inventory_Database" + ".bak'";
                    con.Open();
                    SqlCommand comand = new SqlCommand(cmd, con);
                    comand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("به‌سه‌ركه‌وتووی داتاكان خه‌زنكرا");

                }
            }
            catch (Exception)
            {


            }
        }
    }
}
