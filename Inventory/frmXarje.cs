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
    public partial class frmXarje : Form
    {
        Db db = new Db();
        public frmXarje()
        {
            InitializeComponent();
        }
        void dataToComb1()
        {
            name_xarje.DisplayMember = "name";
            name_xarje.ValueMember = "id";
            name_xarje.DataSource = db.query("select id,name from type_xarje order by id");
        }
        private void frmXarje_Load(object sender, EventArgs e)
        {
            showData();
            dataToComb1();
            barwary_xarje.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            int user_id = int.Parse(Properties.Settings.Default.id);
            if (name_xarje.Text != ""  && barwary_xarje.Text != "" && bry_para.Text != "")
            {

                DialogResult dr = MessageBox.Show("ئه‌ته‌وێ جۆر زیاد بكه‌یت‌", "ئاگاداری", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    db.bind(new object[] { 
                        "bry_xarje", bry_para.Text ,
                        "barwar", barwary_xarje.Text ,
                        "user_id", user_id,
                        "type_Xarje_id", name_xarje.SelectedValue ,
                    });
                    int insert = db.nQuery("INSERT INTO xarjeakan (bry_xarje,barwar,user_id,type_Xarje_id) VALUES (@bry_xarje,@barwar,@user_id,@type_Xarje_id)");
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
            int user_id = int.Parse(Properties.Settings.Default.id);
            try
            {
                if (name_xarje.Text != "" && barwary_xarje.Text != "" && bry_para.Text != "")
                {
                    DialogResult dr = MessageBox.Show("ئه‌ته‌وێ گۆرانكاری بكه‌یت‌", "ئاگاداری", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {

                        int id = (int)DataGridView1.CurrentRow.Cells[0].Value;
                        db.bind(new object[] { 
                            "id", id.ToString(), 
                            "bry_xarje", bry_para.Text ,
                            "barwar", barwary_xarje.Text ,
                            "user_id", user_id,
                            "type_Xarje_id", name_xarje.SelectedValue ,
                        });
                        int update = db.nQuery("update xarjeakan set  bry_xarje = @bry_xarje,barwar = @barwar,type_Xarje_id = @type_Xarje_id where id = @id");
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
                        int delete = db.nQuery("delete from xarjeakan where id = @id", new string[] { "id", id.ToString() });

                        if (delete > 0)
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

        public void showData()
        {
            DataGridView1.Columns.Clear();
            DataGridView1.DataSource = db.query("SELECT xarjeakan.id ,type_Xarje.name as 'ناوی خەرجی',bry_xarje as 'بری خەرجی',barwar as 'بەرواری خەرجی', users.full_name as 'بەکارهێن' FROM type_xarje inner join xarjeakan on xarjeakan.type_Xarje_id = type_Xarje.id inner join users on xarjeakan.user_id = users.id");
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

        private void refresh_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 5)
                {
                    try
                    {

                        int id = (int)DataGridView1.CurrentRow.Cells[0].Value;
                        int delete = db.nQuery("delete from xarjeakan where id = @id", new string[] { "id", id.ToString() });

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

                    name_xarje.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
                    bry_para.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
                    barwary_xarje.Value = Convert.ToDateTime(DataGridView1.CurrentRow.Cells[3].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("بەتاڵە");
            }
            
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            frmTypeXarje f = new frmTypeXarje();
            f.ShowDialog();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            report.frmXarje_rp f = new report.frmXarje_rp();
            f.ShowDialog();
        }
    }
}
