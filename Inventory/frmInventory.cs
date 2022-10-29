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
    public partial class frmInventory : Form
    {
        Db db = new Db();
        public frmInventory()
        {
            InitializeComponent();
            guna2ComboBox1.SelectedItem = "باركۆد";
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            frmType f = new frmType();
            f.ShowDialog();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            frmCompany f = new frmCompany();
            f.ShowDialog();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            frmAddItem f = new frmAddItem();
            f.ShowDialog();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            showData();
        }
        public void showData()
        {
            DataGridView1.Columns.Clear();
            DataGridView1.DataSource = db.query("SELECT  item.id as item_it , barcode 'بارکۆد',item.name 'ناوی مادە',types.name 'جۆری مادە',FORMAT(nrxy_kryn,'#,###,##0') 'نرخی کرین',FORMAT(nrxy_froshtn,'#,###,##0') 'نرخی فرۆشتن',dana 'دانە',karton 'کارتۆن',koy_dana 'کۆی مادە',barwary_kryn 'بەرواری کرین',barwary_basarchwn 'بەرواری بەسەرجوون',FORMAT(nrxy_kryn_j,'#,###,##0') 'نرخی کرین-جوملە',kode 'کۆدی مادە',users.full_name 'بەکارهێن' " +
                " FROM users " +
                "INNER JOIN(types INNER JOIN((company INNER JOIN kryn ON company.id = kryn.company_id)" +
                "INNER JOIN item ON(kryn.id = item.kryn_id)) ON types.id = item.type_id) ON users.ID = item.user_id");
            DataGridView1.Columns[0].Visible = false;
            DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("NRT Bold", 12F);
            DataGridView1.ThemeStyle.RowsStyle.Font = new Font("NRT Reg", 12F);
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.FillWeight = 39.07107F;
                button.FlatStyle = FlatStyle.Popup;
                button.HeaderText = "";
                button.Name = "Column1";
                button.ReadOnly = true;
                button.Text = "سرینه‌وه‌";
                button.ToolTipText = "سرینه‌وه‌";
                button.UseColumnTextForButtonValue = true;
                this.DataGridView1.Columns.Add(button);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void txt_serch_TextChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedItem == "باركۆد")
            {

                DataGridView1.Columns.Clear();
                DataGridView1.DataSource = db.query("SELECT  item.id as item_it , barcode 'بارکۆد',item.name 'ناوی مادە',types.name 'جۆری مادە',FORMAT(nrxy_kryn,'#,###,##0') 'نرخی کرین',FORMAT(nrxy_froshtn,'#,###,##0') 'نرخی فرۆشتن',dana 'دانە',karton 'کارتۆن',koy_dana 'کۆی مادە',barwary_kryn 'بەرواری کرین',barwary_basarchwn 'بەرواری بەسەرجوون',FORMAT(nrxy_kryn_j,'#,###,##0') 'نرخی کرین-جوملە',kode 'کۆدی مادە',users.full_name 'بەکارهێن' " +
                    " FROM users " +
                    "INNER JOIN(types INNER JOIN((company INNER JOIN kryn ON company.id = kryn.company_id)" +
                    "INNER JOIN item ON(kryn.id = item.kryn_id)) ON types.id = item.type_id) ON users.ID = item.user_id where barcode like '%"+txt_serch.Text+"%' ");
                DataGridView1.Columns[0].Visible = false;
                DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("NRT Bold", 12F);
                DataGridView1.ThemeStyle.RowsStyle.Font = new Font("NRT Reg", 12F);
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                {
                    button.FillWeight = 39.07107F;
                    button.FlatStyle = FlatStyle.Popup;
                    button.HeaderText = "";
                    button.Name = "Column1";
                    button.ReadOnly = true;
                    button.Text = "سرینه‌وه‌";
                    button.ToolTipText = "سرینه‌وه‌";
                    button.UseColumnTextForButtonValue = true;
                    this.DataGridView1.Columns.Add(button);
                }

            }
            
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            frmAddItem fk = new frmAddItem();
            fk.id_item.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            fk.ComboBox2.Text = DataGridView1.CurrentRow.Cells[3].Value.ToString();
            fk.barcode.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            fk.name_item.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            fk.barwary_basarchwn.Value = Convert.ToDateTime(DataGridView1.CurrentRow.Cells[10].Value);
            fk.barwary_zyadkrdn_item.Value = Convert.ToDateTime(DataGridView1.CurrentRow.Cells[9].Value);
            fk.nrxy_kryn.Text = DataGridView1.CurrentRow.Cells[4].Value.ToString();
            fk.nrxy_kryn_j.Text = DataGridView1.CurrentRow.Cells[11].Value.ToString();
            fk.nrxy_froshtn.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            fk.karton.Text = DataGridView1.CurrentRow.Cells[7].Value.ToString();
            fk.dana.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();

            fk.btn_add_item.Visible = false;
            fk.btn_updata.Visible = true;

            fk.ShowDialog();


        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 14)
            {
                try
                {

                    int id = (int)DataGridView1.CurrentRow.Cells[0].Value;
                    int delete = db.nQuery("delete from item where id = @id", new string[] { "id", id.ToString() });

                    if (delete > 0)
                    {
                        MessageBox.Show("به‌سه‌ركه‌وتووی سرایه‌وه‌");
                        showData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            frmQarz f = new frmQarz();
            f.ShowDialog();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            frmQarzCompany f = new frmQarzCompany();
            f.ShowDialog();
        }
    }
}
