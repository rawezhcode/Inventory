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
    public partial class frmCompany : Form
    {
        Db db = new Db();
        public frmCompany()
        {
            InitializeComponent();
        }

        private void frmCompany_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invntoryDataSetCompany.company' table. You can move, or remove it, as needed.
          
            showData();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox3.MaxLength = 11;
            if (e.ColumnIndex == 4)
            {
                try
                {

                    int id = (int)DataGridView1.CurrentRow.Cells[0].Value;
                    int delete = db.nQuery("delete from company where id = @id", new string[] { "id", id.ToString() });

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

            TextBox1.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            TextBox2.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            TextBox3.Text = DataGridView1.CurrentRow.Cells[3].Value.ToString();
            //TextBox4.Text = DataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        public void showData()
        {
            DataGridView1.DataSource = db.query("SELECT * FROM company");
            DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("NRT Bold", 12F);
            DataGridView1.ThemeStyle.RowsStyle.Font = new Font("NRT Reg", 12F);
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "")
            {

                DialogResult dr = MessageBox.Show("ئه‌ته‌وێ کۆمپانیا زیاد بكه‌یت‌", "ئاگاداری", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    if (TextBox3.TextLength != 11)
                    {
                        MessageBox.Show("ژماره‌ مۆبایله‌له‌ 11 ژماره‌ زیاتره‌");
                    }
                    else
                    {
                        //object[] s = { "aa",34 };

                        db.bind(new object[] { "name", TextBox1.Text, "shwen", TextBox2.Text, "mobile", TextBox3.Text });
                        int insert = db.nQuery("INSERT INTO company (name,shwen,mobile) VALUES (@name,@shwen,@mobile)");
                        MessageBox.Show("به‌سه‌ركه‌وتووی تۆماركرا");
                        showData();
                    }

                   
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
                if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "")
                {
                    DialogResult dr = MessageBox.Show("ئه‌ته‌وێ گۆرانكاری بكه‌یت‌", "ئاگاداری", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {

                        if (TextBox3.TextLength != 11)
                        {
                            MessageBox.Show("ژماره‌ مۆبایله‌له‌ 11 ژماره‌ زیاتره‌");
                        }
                        else
                        {
                          
                            int id = (int)DataGridView1.CurrentRow.Cells[0].Value;

                            db.bind(new object[] { "id",id.ToString(), "name", TextBox1.Text, "shwen", TextBox2.Text, "mobile", TextBox3.Text });
                            int insert = db.nQuery("UPDATE company SET name = @name , shwen =@shwen , mobile =@mobile WHERE id =@id");
                            MessageBox.Show("به‌سه‌ركه‌وتووی تۆماركرا");
                            showData();
                        }
                    }
                    else
                    {

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
                DialogResult dr = MessageBox.Show("ئه‌ته‌وێ سرینه‌وه‌ بكه‌یت‌", "ئاگاداری", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    int id = (int)DataGridView1.CurrentRow.Cells[0].Value;
                    int delete = db.nQuery("delete from company where id = @id", new string[] { "id", id.ToString() });

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
    }
}
