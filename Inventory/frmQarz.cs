using Guna.UI2.WinForms;
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
    public partial class frmQarz : Form
    {
        Db db = new Db();
        public frmQarz()
        {
            InitializeComponent();
        }
        void dataToComb2()
        {

            guna2ComboBox1.DisplayMember = "name";
            guna2ComboBox1.ValueMember = "id";
            guna2ComboBox1.DataSource = db.query("select id,name from kryar order by id");

        }
        public void showData()
        {
            guna2DataGridView1.Columns.Clear();
            guna2DataGridView1.DataSource = db.query("select froshtn_ba_qarz.id, kryar.name 'ناوی کریار',kryar.mobile 'ژمارە مووبایل',froshtn_ba_qarz.barwar 'بەروار',froshtn_ba_qarz.bry_qarz 'بری قەرز', froshtn.wasl 'ژمارەی وەسڵ' from  kryar inner join froshtn_ba_qarz on kryar.id = froshtn_ba_qarz.kryar_id left join froshtn on froshtn_ba_qarz.id = froshtn.froshtn_ba_qarz_id left join item on froshtn.item_id = item.id where froshtn_ba_qarz.bry_qarz > 0 group by froshtn.wasl,froshtn_ba_qarz.id,kryar.name,kryar.mobile,froshtn_ba_qarz.barwar,froshtn_ba_qarz.bry_qarz");
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

        private void frmQarz_Load(object sender, EventArgs e)
        {
            showData();
            dataToComb2();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (txt_bry_para.Text != "" && guna2ComboBox1.Text != "" )
            {

                DialogResult dr = MessageBox.Show("ئه‌ته‌وێ جۆر زیاد بكه‌یت‌", "ئاگاداری", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    db.bind(new object[] {
                            "barwar" , DateTime.Now.ToString("yyyy-MM-dd") ,
                            "bry_qarz" , txt_bry_para.Text.Replace(",", ""),
                            "kryar_id" , guna2ComboBox1.SelectedValue,
                        });
                    int insert_f_b_n = db.nQuery("INSERT INTO froshtn_ba_qarz(barwar, bry_qarz,kryar_id) VALUES " +
                        "(@barwar, @bry_qarz, @kryar_id)");
                    MessageBox.Show("به‌سه‌ركه‌وتووی تۆماركرا");

                }

            }
            else
            {
                MessageBox.Show("تكایه‌ خانه‌كان پربكه‌وه‌");

            }
        }

        private void btn_updata_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 6)
                {
                    try
                    {


                        int id = (int)guna2DataGridView1.CurrentRow.Cells[0].Value;
                        int bryPara = (int)guna2DataGridView1.CurrentRow.Cells[4].Value;

                        string kryar_id = db.single("SELECT kryar_id FROM froshtn_ba_qarz WHERE id = @id", new string[] { "id", id.ToString() });

                        string bry_para_k = db.single("SELECT bry_para FROM kryar WHERE id = @id", new string[] { "id", kryar_id });
                        string bry_qarz_k = db.single("SELECT bry_qarz FROM kryar WHERE id = @id", new string[] { "id", kryar_id });
                        //MessageBox.Show((int.Parse(lab_koypara.Text.Replace(",", "")) + int.Parse(bry_para_k)).ToString());
                        db.bind(new object[] {
                                        "bry_para" , (bryPara) + int.Parse(bry_qarz_k),
                                        "bry_qarz" , Math.Abs(int.Parse(bry_qarz_k) - bryPara ),
                            });
                        int update_kryar = db.nQuery("update kryar set bry_qarz=@bry_qarz where id = @id", new string[] { "id", kryar_id });
                        //

                        db.bind(new object[] {
                            "bry_para" , bryPara ,
                            "barwar" ,  DateTime.Now.ToString("yyyy-MM-dd") ,
                            "kryar_id" , kryar_id,
                        });
                        int insert_f_b_n = db.nQuery("INSERT INTO danaway_qarz_kryar(bry_para, barwar,kryar_id) VALUES " +
                        "(@bry_para, @barwar, @kryar_id)");


                        db.bind(new object[] { "id", id.ToString(), "bry_qarz", 0 , "bry_para", bryPara });
                        int update = db.nQuery("update froshtn_ba_qarz set bry_qarz = @bry_qarz, bry_para = @bry_para where id = @id");

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
        


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (ComboBox1.SelectedItem == "دانە")
            //{
            //    guna2DataGridView1.Columns.Clear();
            //    guna2DataGridView1.DataSource = db.query("select froshtn_ba_qarz.id, froshtn_ba_qarz.name 'ناوی کریار',froshtn_ba_qarz.mobile 'ژمارە مووبایل',froshtn_ba_qarz.barwar 'بەروار',froshtn_ba_qarz.bry_qarz 'بری قەرز', froshtn.wasl 'ژمارەی وەسڵ'  " +
            //        "from froshtn_ba_qarz inner join froshtn on froshtn_ba_qarz.id = froshtn.froshtn_ba_qarz_id inner join item on froshtn.item_id = item.id  where froshtn.dana > 0 AND froshtn_ba_qarz.bry_qarz > 0 group by froshtn.wasl,froshtn_ba_qarz.id,froshtn_ba_qarz.name,froshtn_ba_qarz.mobile,froshtn_ba_qarz.barwar,froshtn_ba_qarz.bry_qarz");
            //    guna2DataGridView1.Columns[0].Visible = false;
            //    guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("NRT Bold", 12F);
            //    guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("NRT Reg", 12F);
            //    DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            //    {
            //        button.FillWeight = 38.07107F;
            //        button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            //        button.HeaderText = "";
            //        button.Name = "Column1";
            //        button.ReadOnly = true;
            //        button.Text = "سرینه‌وه‌";
            //        button.ToolTipText = "سرینه‌وه‌";
            //        button.UseColumnTextForButtonValue = true;
            //        this.guna2DataGridView1.Columns.Add(button);
            //    }
            //}

            //else if (ComboBox1.SelectedItem == "داشکان")
            //{
            //    guna2DataGridView1.Columns.Clear();
            //    guna2DataGridView1.DataSource = db.query("select froshtn_ba_qarz.id, froshtn_ba_qarz.name 'ناوی کریار',froshtn_ba_qarz.mobile 'ژمارە مووبایل',froshtn_ba_qarz.barwar 'بەروار',froshtn_ba_qarz.bry_qarz 'بری قەرز', froshtn.wasl 'ژمارەی وەسڵ'  " +
            //        "from froshtn_ba_qarz inner join froshtn on froshtn_ba_qarz.id = froshtn.froshtn_ba_qarz_id inner join item on froshtn.item_id = item.id  where froshtn.dashkan > 0 AND froshtn_ba_qarz.bry_qarz > 0 group by froshtn.wasl,froshtn_ba_qarz.id,froshtn_ba_qarz.name,froshtn_ba_qarz.mobile,froshtn_ba_qarz.barwar,froshtn_ba_qarz.bry_qarz");
            //    guna2DataGridView1.Columns[0].Visible = false;
            //    guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("NRT Bold", 12F);
            //    guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("NRT Reg", 12F);
            //    DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            //    {
            //        button.FillWeight = 38.07107F;
            //        button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            //        button.HeaderText = "";
            //        button.Name = "Column1";
            //        button.ReadOnly = true;
            //        button.Text = "سرینه‌وه‌";
            //        button.ToolTipText = "سرینه‌وه‌";
            //        button.UseColumnTextForButtonValue = true;
            //        this.guna2DataGridView1.Columns.Add(button);
            //    }
            //}
            //else
            //{

            //    guna2DataGridView1.Columns.Clear();
            //    guna2DataGridView1.DataSource = db.query("select froshtn_ba_qarz.id, froshtn_ba_qarz.name 'ناوی کریار',froshtn_ba_qarz.mobile 'ژمارە مووبایل',froshtn_ba_qarz.barwar 'بەروار',froshtn_ba_qarz.bry_qarz 'بری قەرز', froshtn.wasl 'ژمارەی وەسڵ'  " +
            //        "from froshtn_ba_qarz inner join froshtn on froshtn_ba_qarz.id = froshtn.froshtn_ba_qarz_id inner join item on froshtn.item_id = item.id  where froshtn.karton > 0 AND froshtn_ba_qarz.bry_qarz > 0 group by froshtn.wasl,froshtn_ba_qarz.id,froshtn_ba_qarz.name,froshtn_ba_qarz.mobile,froshtn_ba_qarz.barwar,froshtn_ba_qarz.bry_qarz");
            //    guna2DataGridView1.Columns[0].Visible = false;
            //    guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("NRT Bold", 12F);
            //    guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("NRT Reg", 12F);
            //    DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            //    {
            //        button.FillWeight = 38.07107F;
            //        button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            //        button.HeaderText = "";
            //        button.Name = "Column1";
            //        button.ReadOnly = true;
            //        button.Text = "سرینه‌وه‌";
            //        button.ToolTipText = "سرینه‌وه‌";
            //        button.UseColumnTextForButtonValue = true;
            //        this.guna2DataGridView1.Columns.Add(button);
            //    }
                
            //}
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            showData();
            
        }

    }
}
