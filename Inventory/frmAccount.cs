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
    public partial class frmAccount : Form
    {
        Db db = new Db();

        public frmAccount()
        {
            InitializeComponent();
        }
        public void showData()
        {
            DataGridView1.Columns.Clear();
            DataGridView1.DataSource = db.query("select id,full_name 'ناوی سیانی',username 'ناوی بەکار‌ین',password 'وشەی تێپەر',role 'دەسەڵات' from users");
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
        private void frmAccount_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (txt_fullName.Text != "" && txt_user.Text != "" && txt_pass.Text != "" && cmb_ustyp.Text != "")
            {

                DialogResult dr = MessageBox.Show("ئه‌ته‌وێ جۆر زیاد بكه‌یت‌", "ئاگاداری", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    db.bind(new object[] {
                        "full_name", txt_fullName.Text ,
                        "username", txt_user.Text ,
                        "password", txt_pass.Text ,
                        "role", cmb_ustyp.SelectedIndex ,
                    });
                    int insert = db.nQuery("INSERT INTO users (full_name,username,password,role) VALUES (@full_name,@username,@password,@role)");
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
                if (txt_fullName.Text != "" && txt_user.Text != "" && txt_pass.Text != "" && cmb_ustyp.Text != "")
                {
                    DialogResult dr = MessageBox.Show("ئه‌ته‌وێ گۆرانكاری بكه‌یت‌", "ئاگاداری", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {

                        int id = (int)DataGridView1.CurrentRow.Cells[0].Value;
                        db.bind(new object[] {
                        "id", id ,
                        "full_name", txt_fullName.Text ,
                        "username", txt_user.Text ,
                        "password", txt_pass.Text ,
                        "role", cmb_ustyp.SelectedIndex ,
                       });
                        int update = db.nQuery("update users set full_name = @full_name , username = @username,password = @password,role = @role where id = @id");
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
                if (DataGridView1.CurrentCell != null)
                {
                    int id = (int)DataGridView1.CurrentRow.Cells[0].Value;
                    int delete = db.nQuery("delete from users where id = @id", new string[] { "id", id.ToString() });

                    if (delete > 0)
                    {
                        MessageBox.Show("به‌سه‌ركه‌وتووی سرایه‌وه‌");
                        showData();
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
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
                        int delete = db.nQuery("delete from users where id = @id", new string[] { "id", id.ToString() });

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

                    txt_fullName.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txt_user.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
                    txt_pass.Text = DataGridView1.CurrentRow.Cells[3].Value.ToString();
                    cmb_ustyp.SelectedIndex = int.Parse(DataGridView1.CurrentRow.Cells[4].Value.ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("بەتاڵە");
            }
        }
    }
}
