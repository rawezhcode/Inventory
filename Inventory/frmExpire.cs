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
    public partial class frmExpire : Form
    {
        Db db = new Db();
        public frmExpire()
        {
            InitializeComponent();
        }
        public void showData()
        {
            guna2DataGridView1.DataSource = db.query("select item.id,types.name 'ناوی جۆر',item.barcode 'بارکۆد',item.name 'ناوی مادە',item.nrxy_kryn 'نرخی کرین',item.nrxy_froshtn 'نرخی فرۆشتن',item.koy_dana 'کۆی مادە',item.barwary_basarchwn 'بەرواری بەسەرچوون',kryn.zhmaray_wasl 'ژمارەی وەسڵ',kryn.barwary_wasl 'بەرواری وەسڵ' " +
               "from types inner join item on item.type_id = types.id inner join kryn on item.kryn_id = kryn.id where barwary_basarchwn <= '" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
            guna2DataGridView1.Columns[0].Visible = false;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("NRT Bold", 12F);
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("NRT Reg", 12F);
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.FillWeight = 48.07107F;
                button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                button.HeaderText = "";
                button.Name = "Column1";
                button.ReadOnly = true;
                button.Text = "سرینه‌وه‌";
                button.ToolTipText = "سرینه‌وه‌";
                button.UseColumnTextForButtonValue = true;
                this.guna2DataGridView1.Columns.Add(button);
            }
        }
        private void frmExpire_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void txt_serch_TextChanged(object sender, EventArgs e)
        {
            guna2DataGridView1.Columns.Clear();
            guna2DataGridView1.DataSource = db.query("select item.id,types.name 'ناوی جۆر',item.barcode 'بارکۆد',item.name 'ناوی مادە',item.nrxy_kryn 'نرخی کرین',item.nrxy_froshtn 'نرخی فرۆشتن',item.koy_dana 'کۆی مادە',item.barwary_basarchwn 'بەرواری بەسەرچوون',kryn.zhmaray_wasl 'ژمارەی وەسڵ',kryn.barwary_wasl 'بەرواری وەسڵ' " +
               "from types inner join item on item.type_id = types.id inner join kryn on item.kryn_id = kryn.id where item.barcode like '%"+txt_serch.Text+"%' AND  barwary_basarchwn <= '" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
            guna2DataGridView1.Columns[0].Visible = false;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("NRT Bold", 12F);
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("NRT Reg", 12F);
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.FillWeight = 38.07107F;
                button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                button.HeaderText = "";
                button.Name = "Column1";
                button.ReadOnly = true;
                button.Text = "سرینه‌وه‌";
                button.ToolTipText = "سرینه‌وه‌";
                button.UseColumnTextForButtonValue = true;
                this.guna2DataGridView1.Columns.Add(button);
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.ColumnIndex == 10)
                {
                    try
                    {

                        int id = (int)guna2DataGridView1.CurrentRow.Cells[0].Value;
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
            catch (Exception ex)
            {
                MessageBox.Show("بەتاڵە");
            }
        }
    }
}
