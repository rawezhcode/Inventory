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
    public partial class frmLossItem : Form
    {
        Db db = new Db();
        public frmLossItem()
        {
            InitializeComponent();
        }
        public void showData()
        {
           
            guna2DataGridView1.Columns.Clear();
            guna2DataGridView1.DataSource = db.query("SELECT  item.id as item_it , barcode 'بارکۆد',item.name 'ناوی مادە',types.name 'جۆری مادە',FORMAT(nrxy_kryn,'#,###,##0') 'نرخی کرین',FORMAT(nrxy_froshtn,'#,###,##0') 'نرخی فرۆشتن',dana 'دانە',karton 'کارتۆن',koy_dana 'کۆی مادە',barwary_kryn 'بەرواری کرین',barwary_basarchwn 'بەرواری بەسەرجوون',users.full_name 'بەکارهێن' " +
                " FROM users " +
                "INNER JOIN(types INNER JOIN((company INNER JOIN kryn ON company.id = kryn.company_id)" +
                "INNER JOIN item ON(kryn.id = item.kryn_id)) ON types.id = item.type_id) ON users.ID = item.user_id  where koy_dana <= '10'");
            guna2DataGridView1.Columns[0].Visible = false;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("NRT Bold", 12F);
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("NRT Reg", 12F);
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.FillWeight = 50F;
                button.FlatStyle = FlatStyle.Popup;
                button.HeaderText = "";
                button.Name = "Column1";
                button.ReadOnly = true;
                button.Text = "زیادکردن";
                button.ToolTipText = "زیادکردن";
                button.UseColumnTextForButtonValue = true;
                this.guna2DataGridView1.Columns.Add(button);
            }
        }
        private void frmLossItem_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_serch_TextChanged(object sender, EventArgs e)
        {
            guna2DataGridView1.Columns.Clear();
            guna2DataGridView1.DataSource = db.query("SELECT  item.id as item_it , barcode 'بارکۆد',item.name 'ناوی مادە',types.name 'جۆری مادە',FORMAT(nrxy_kryn,'#,###,##0') 'نرخی کرین',FORMAT(nrxy_froshtn,'#,###,##0') 'نرخی فرۆشتن',dana 'دانە',karton 'کارتۆن',koy_dana 'کۆی مادە',barwary_kryn 'بەرواری کرین',barwary_basarchwn 'بەرواری بەسەرجوون',users.full_name 'بەکارهێن' " +
               " FROM users " +
               "INNER JOIN(types INNER JOIN((company INNER JOIN kryn ON company.id = kryn.company_id)" +
               "INNER JOIN item ON(kryn.id = item.kryn_id)) ON types.id = item.type_id) ON users.ID = item.user_id  where item.barcode like '%" + txt_serch.Text + "%' AND  koy_dana <= '10'");
            guna2DataGridView1.Columns[0].Visible = false;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("NRT Bold", 12F);
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("NRT Reg", 12F);
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.FillWeight = 50F;
                button.FlatStyle = FlatStyle.Popup;
                button.HeaderText = "";
                button.Name = "Column1";
                button.ReadOnly = true;
                button.Text = "زیادکردن";
                button.ToolTipText = "زیادکردن";
                button.UseColumnTextForButtonValue = true;
                this.guna2DataGridView1.Columns.Add(button);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            frmAddItem fk = new frmAddItem();
            fk.id_item.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            fk.ComboBox2.Text = guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            fk.barcode.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            fk.name_item.Text = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            fk.barwary_basarchwn.Value = Convert.ToDateTime(guna2DataGridView1.CurrentRow.Cells[10].Value);
            fk.barwary_zyadkrdn_item.Value = Convert.ToDateTime(guna2DataGridView1.CurrentRow.Cells[9].Value);
            fk.nrxy_kryn.Text = guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
            fk.nrxy_froshtn.Text = guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();
            //fk.karton.Text = guna2DataGridView1.CurrentRow.Cells[7].Value.ToString();
            //fk.dana.Text = guna2DataGridView1.CurrentRow.Cells[6].Value.ToString();

            fk.btn_add_item.Visible = false;
            fk.btn_updata.Visible = true;

            fk.ShowDialog();
        }
    }
}
