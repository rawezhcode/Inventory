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
    public partial class frmType : Form
    {
        Db db = new Db();
        public frmType()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (txt_naw.Text != "")
            {

                DialogResult dr = MessageBox.Show("ئه‌ته‌وێ جۆر زیاد بكه‌یت‌", "ئاگاداری", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                 
                    db.bind(new string[] { "name" , txt_naw.Text });
                    int insert = db.nQuery("INSERT INTO types (name) VALUES (@name)");
                    MessageBox.Show("به‌سه‌ركه‌وتووی تۆماركرا");
                    showData();
                }

            }
            else
            {
                MessageBox.Show("تكایه‌ خانه‌كان پربكه‌وه‌");

            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_naw.Text != "")
                {
                    DialogResult dr = MessageBox.Show("ئه‌ته‌وێ گۆرانكاری بكه‌یت‌", "ئاگاداری", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        
                        int id = (int)DataGridView1.CurrentRow.Cells[0].Value;
                        db.bind(new string[] { "id", id.ToString(), "name", txt_naw.Text });
                        int update = db.nQuery("update types set name = @name where id = @id");
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

                    int id = (int)DataGridView1.CurrentRow.Cells[0].Value;
                    int delete = db.nQuery("delete from types where id = @id",new string[] { "id",id.ToString() });

                    if( delete > 0)
                    {
                    MessageBox.Show("به‌سه‌ركه‌وتووی سرایه‌وه‌");
                    showData();
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

        private void frmType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invntoryDataSet.types' table. You can move, or remove it, as needed.
            this.typesTableAdapter.Fill(this.invntoryDataSet.types);
            showData();
        }

        public void showData()
        {
            DataGridView1.DataSource = db.query("SELECT * FROM types");
            DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("NRT Bold", 12F);
            DataGridView1.ThemeStyle.RowsStyle.Font = new Font("NRT Reg", 12F);
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             txt_naw.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
