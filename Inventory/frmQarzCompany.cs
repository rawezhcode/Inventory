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
    public partial class frmQarzCompany : Form
    {
        Db db = new Db();
        public frmQarzCompany()
        {
            InitializeComponent();
        }
        void dataToComb1()
        {
            ComboBox1.DisplayMember = "name";
            ComboBox1.ValueMember = "id";
            ComboBox1.DataSource = db.query("select id,name from company order by id");
        }
        public void showData()
        {
            guna2DataGridView1.Columns.Clear();
            guna2DataGridView1.DataSource = db.query("select kryn.id,kryn.zhmaray_wasl 'ژمارەی وەسڵ',kryn.bry_para 'بری پارە',kryn.bry_qarz 'بری قەرز',company.name 'ناوی کۆمپانیا',company.shwen 'شوێن',company.mobile 'ژمارە مووبایل' from  kryn inner join company on kryn.company_id = company.id where kryn.bry_qarz > 0");
            guna2DataGridView1.Columns[0].Visible = false;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("NRT Bold", 12F);
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("NRT Reg", 12F);
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.FillWeight = 38.07107F;
                button.Width = 200;
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
        private void frmQarzCompany_Load(object sender, EventArgs e)
        {
            dataToComb1();
            showData();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox1.Text == ComboBox1.Text)
            {

                guna2DataGridView1.Columns.Clear();
                guna2DataGridView1.DataSource = db.query("select kryn.id,kryn.zhmaray_wasl 'ژمارەی وەسڵ',kryn.bry_para 'بری پارە',kryn.bry_qarz 'بری قەرز',company.name 'ناوی کۆمپانیا',company.shwen 'شوێن',company.mobile 'ژمارە مووبایل' " +
                    "from  kryn inner join company on kryn.company_id = company.id where kryn.bry_qarz > 0  And company.name = '" + ComboBox1.Text + "' ");
                guna2DataGridView1.Columns[0].Visible = false;
                guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("NRT Bold", 12F);
                guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("NRT Reg", 12F);
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                {
                    button.FillWeight = 38.07107F;
                    button.Width = 200;
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
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void zhmaray_wasl_TextChanged(object sender, EventArgs e)
        {
            guna2DataGridView1.Columns.Clear();
            guna2DataGridView1.DataSource = db.query("select kryn.id,kryn.zhmaray_wasl 'ژمارەی وەسڵ',kryn.bry_para 'بری پارە',kryn.bry_qarz 'بری قەرز',company.name 'ناوی کۆمپانیا',company.shwen 'شوێن',company.mobile 'ژمارە مووبایل' " +
                "from  kryn inner join company on kryn.company_id = company.id where kryn.bry_qarz > 0  And kryn.zhmaray_wasl Like '%" + zhmaray_wasl.Text + "%' ");
            guna2DataGridView1.Columns[0].Visible = false;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("NRT Bold", 12F);
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("NRT Reg", 12F);
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.FillWeight = 38.07107F;
                button.Width = 200;
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
                if (e.ColumnIndex == 7)
                {
                    try
                    {
                        int id = (int)guna2DataGridView1.CurrentRow.Cells[0].Value;
                        int bry_qarz = (int)guna2DataGridView1.CurrentRow.Cells[3].Value;

                        string company_id = db.single("SELECT company_id FROM kryn WHERE id = @id", new string[] { "id", id.ToString() });


                        string bry_para_k = db.single("SELECT bry_para FROM company WHERE id = @id", new string[] { "id", company_id });
                        string bry_qarz_k = db.single("SELECT bry_qarz FROM company WHERE id = @id", new string[] { "id", company_id });
                        
                             db.bind(new object[] {
                                        "bry_para" , (bry_qarz) + int.Parse(bry_para_k),
                                        "bry_qarz" ,  Math.Abs(int.Parse(bry_qarz_k) - bry_qarz),
                            });
                            int update_kryar = db.nQuery("update company set bry_para=@bry_para,bry_qarz=@bry_qarz where name = @name", new string[] { "name", ComboBox1.Text });
                        //
                        db.bind(new object[] {
                            "bry_para" , bry_qarz ,
                            "barwar" ,  DateTime.Now.ToString("yyyy-MM-dd") ,
                            "company_id" , company_id,
                        });
                        int insert_f_b_n = db.nQuery("INSERT INTO danaway_qarz_company(bry_para, barwar,company_id) VALUES " +
                        "(@bry_para, @barwar, @company_id)");
                        //


                        db.bind(new object[] { "id", id.ToString(), "bry_qarz", 0 });
                        int update = db.nQuery("update kryn set bry_qarz = @bry_qarz where id = @id");

                        if (update > 0)
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
