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
    public partial class frmKryar : Form
    {
        Db db = new Db();
        public frmKryar()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    try
                    {

                        int id = (int)DataGridView1.CurrentRow.Cells[0].Value;
                        int delete = db.nQuery("delete from kryar where id = @id", new string[] { "id", id.ToString() });

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

                if (DataGridView1.CurrentCell != null)
                {

                    txt_naw.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txt_shwen.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
                    txt_mobil.Text = DataGridView1.CurrentRow.Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("بەتاڵە");
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (txt_naw.Text != "" && txt_shwen.Text != "" && txt_mobil.Text != "")
            {

                DialogResult dr = MessageBox.Show("ئه‌ته‌وێ جۆر زیاد بكه‌یت‌", "ئاگاداری", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    db.bind(new object[] {
                        "name", txt_naw.Text ,
                        "shwen", txt_shwen.Text ,
                        "mobile", txt_mobil.Text ,
                    });
                    int insert = db.nQuery("INSERT INTO kryar (name,shwen,mobile) VALUES (@name,@shwen,@mobile)");
                    MessageBox.Show("به‌سه‌ركه‌وتووی تۆماركرا");
                    showData();
                }

            }
            else
            {
                MessageBox.Show("تكایه‌ خانه‌كان پربكه‌وه‌");

            }
        }

        private void btn_updata_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_naw.Text != "" && txt_shwen.Text != "" && txt_mobil.Text != "")
                {
                    DialogResult dr = MessageBox.Show("ئه‌ته‌وێ گۆرانكاری بكه‌یت‌", "ئاگاداری", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {

                        int id = (int)DataGridView1.CurrentRow.Cells[0].Value;
                        db.bind(new object[] {
                            "id", id ,
                            "name", txt_naw.Text ,
                            "shwen", txt_shwen.Text ,
                            "mobile", txt_mobil.Text ,
                         });
                        int update = db.nQuery("update kryar set name = @name , shwen = @shwen,mobile = @mobile where id = @id");
                        MessageBox.Show("به‌سه‌ركه‌وتووی نوێكرایه‌وه‌");
                        showData();
                    }
                }
                else
                {
                    MessageBox.Show("تكایه‌ خانه‌كان پربكه‌وه‌");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dr = MessageBox.Show("ئه‌ته‌وێ سرایه‌وه بكه‌یت‌", "ئاگاداری", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    if (DataGridView1.CurrentCell != null)
                    {

                        int id = (int)DataGridView1.CurrentRow.Cells[0].Value;
                        int delete = db.nQuery("delete from kryar where id = @id", new string[] { "id", id.ToString() });

                        if (delete > 0)
                        {
                            MessageBox.Show("به‌سه‌ركه‌وتووی سرایه‌وه‌");
                            showData();
                        }
                    }
                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmKryar_Load(object sender, EventArgs e)
        {
            showData();
        }
        public void showData()
        {
            DataGridView1.Columns.Clear();
            DataGridView1.DataSource = db.query("SELECT id ,name as 'ناوی کریار',shwen as 'شوێن',mobile as 'ژمارە مۆبایل' FROM kryar ");
            DataGridView1.Columns[0].Visible = false;
            DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("NRT Bold", 12F);
            DataGridView1.ThemeStyle.RowsStyle.Font = new Font("NRT Reg", 12F);
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
                this.DataGridView1.Columns.Add(button);
            }
        }
    }
}
