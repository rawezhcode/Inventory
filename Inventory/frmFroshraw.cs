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
    public partial class frmFroshraw : Form
    {
        Db db = new Db();
        public frmFroshraw()
        {
            InitializeComponent();
        }
        public void showData()
        {
            guna2DataGridView1.Columns.Clear();
            guna2DataGridView1.DataSource = db.query("select froshtn.id, froshtn.wasl 'وەسڵ',item.barcode 'بارکۆد',item.name 'ناوی مادە',froshtn.nrxy_froshtn 'نرخی فرۆشتن',froshtn.barwary_froshtn 'بەرواری فرۆشتن',froshtn.dana 'دانە',froshtn.karton 'کارتۆن',froshtn.dashkan 'داشکان',kryar.name 'کریار',froshtn_ba_qarz.bry_qarz 'نرخ-قەرز',froshtn_ba_qarz.bry_para 'نرخ-نەقد' " +
                "from item inner join froshtn on item.id = froshtn.item_id inner join froshtn_ba_qarz on froshtn.froshtn_ba_qarz_id = froshtn_ba_qarz.id inner join kryar on froshtn_ba_qarz.kryar_id = kryar.id");
            guna2DataGridView1.Columns[0].Visible = false;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("NRT Bold", 12F);
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("NRT Reg", 12F);

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.FillWeight = 38.07107F;
                button.Width = 200;
                button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button.HeaderText = "";
                button.Name = "Column1";
                button.ReadOnly = true;
                button.Text = "‌سرینه‌وه‌‌";
                button.ToolTipText = "‌سرینه‌وه‌‌";
                button.UseColumnTextForButtonValue = true;
                this.guna2DataGridView1.Columns.Add(button);
            }
        }

        public void sumrows()
        {
            try
            {
                double sumk = 0;
            double qazang = 0;
            double AllPrice = 0;
            double NrxyKryn = 0;
            double NrxyFroshtn = 0;

            string sumDana = db.single("select COUNT(*) from froshtn");

                int sum = 0;
                int countRow = guna2DataGridView1.Rows.Count;
                for (int i = 0; i < countRow - 1; i++)
                {
                    int id = int.Parse(guna2DataGridView1.Rows[i].Cells[0].Value.ToString());
                    string barcode = guna2DataGridView1.Rows[i].Cells[2].Value.ToString();
                    string nrxy_kryn = db.single("select nrxy_kryn from item where barcode=@barcode", new string[] { "barcode", barcode });
                    string nrxy_froshtn = db.single("select nrxy_froshtn from froshtn where id=@id", new string[] { "id", id.ToString() });
                    string dashkan = db.single("select dashkan from froshtn where id=@id", new string[] { "id", id.ToString() });
                    string dana = db.single("select dana from froshtn where id=@id", new string[] { "id", id.ToString() });
                //MessageBox.Show(nrxy_froshtn);


                if (dana != "" && int.Parse(dana) > 0)
                {
                    NrxyKryn = int.Parse(nrxy_kryn) * int.Parse(dana);
                    NrxyFroshtn = int.Parse(nrxy_froshtn) * int.Parse(dana);
                }

                double dwadashkan = NrxyFroshtn;
                if (int.Parse(dashkan) > 0)
                {
                    double n = NrxyFroshtn;
                    double rezhay_sady = double.Parse(dashkan);
                    double lasada = rezhay_sady / 100;
                    double kodashkan = lasada * n;
                    dwadashkan = n - kodashkan;
                }
                AllPrice = AllPrice + dwadashkan;
                qazang = qazang + (dwadashkan - NrxyKryn);
            }

                lab_danyfroshraw.Text = (countRow - 1).ToString();
                lab_koypara.Text = AllPrice.ToString("#,###,##0") + " دینار  ";
                lab_qazang.Text = qazang.ToString("#,###,##0") + " دینار  ";
            }
            catch (Exception)
            {


            }

        }
        private void frmFroshraw_Load(object sender, EventArgs e)
        {
            showData();
            sumrows();
            DateStart.Text = DateTime.Now.ToString("yyyy-MM-dd");
            DateEnd.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }


        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox2.SelectedItem == "قه‌رز")
            {
                guna2DataGridView1.Columns.Clear();
                guna2DataGridView1.DataSource = db.query("select froshtn.id, froshtn.wasl 'وەسڵ',item.barcode 'بارکۆد',item.name 'ناوی مادە',froshtn.nrxy_froshtn 'نرخی فرۆشتن',froshtn.barwary_froshtn 'بەرواری فرۆشتن',froshtn.dana 'دانە',froshtn.karton 'کارتۆن',froshtn.dashkan 'داشکان',kryar.name 'کریار',froshtn_ba_qarz.bry_qarz 'نرخ-قەرز',froshtn_ba_qarz.bry_para 'نرخ-نەقد' " +
                "from item inner join froshtn on item.id = froshtn.item_id inner join froshtn_ba_qarz on froshtn.froshtn_ba_qarz_id = froshtn_ba_qarz.id inner join kryar on froshtn_ba_qarz.kryar_id = kryar.id where froshtn_ba_qarz.bry_qarz > 0");
                guna2DataGridView1.Columns[0].Visible = false;
                 guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("NRT Bold", 12F);
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("NRT Reg", 12F);

                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                {
                    button.FillWeight = 38.07107F;
                    button.Width = 200;
                    button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    button.HeaderText = "";
                    button.Name = "Column1";
                    button.ReadOnly = true;
                    button.Text = "‌سرینه‌وه‌‌";
                    button.ToolTipText = "‌سرینه‌وه‌‌";
                    button.UseColumnTextForButtonValue = true;
                    this.guna2DataGridView1.Columns.Add(button);
                }
            }
            else if (guna2ComboBox2.SelectedItem == "نه‌قد")
            {
                guna2DataGridView1.Columns.Clear();
                guna2DataGridView1.DataSource = db.query("select froshtn.id, froshtn.wasl 'وەسڵ',item.barcode 'بارکۆد',item.name 'ناوی مادە',froshtn.nrxy_froshtn 'نرخی فرۆشتن',froshtn.barwary_froshtn 'بەرواری فرۆشتن',froshtn.dana 'دانە',froshtn.karton 'کارتۆن',froshtn.dashkan 'داشکان',kryar.name 'کریار',froshtn_ba_qarz.bry_qarz 'نرخ-قەرز',froshtn_ba_qarz.bry_para 'نرخ-نەقد' " +
                 "from item inner join froshtn on item.id = froshtn.item_id inner join froshtn_ba_qarz on froshtn.froshtn_ba_qarz_id = froshtn_ba_qarz.id inner join kryar on froshtn_ba_qarz.kryar_id = kryar.id where froshtn_ba_qarz.bry_para > 0");
                guna2DataGridView1.Columns[0].Visible = false;
                guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("NRT Bold", 12F);
                guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("NRT Reg", 12F);

                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                {
                    button.FillWeight = 38.07107F;
                    button.Width = 200;
                    button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    button.HeaderText = "";
                    button.Name = "Column1";
                    button.ReadOnly = true;
                    button.Text = "‌سرینه‌وه‌‌";
                    button.ToolTipText = "‌سرینه‌وه‌‌";
                    button.UseColumnTextForButtonValue = true;
                    this.guna2DataGridView1.Columns.Add(button);
                }
            }
            else
            {
                guna2DataGridView1.Columns.Clear();
                guna2DataGridView1.DataSource = db.query("select froshtn.id, froshtn.wasl 'وەسڵ',item.barcode 'بارکۆد',item.name 'ناوی مادە',froshtn.nrxy_froshtn 'نرخی فرۆشتن',froshtn.barwary_froshtn 'بەرواری فرۆشتن',froshtn.dana 'دانە',froshtn.karton 'کارتۆن',froshtn.dashkan 'داشکان',kryar.name 'کریار',froshtn_ba_qarz.bry_qarz 'نرخ-قەرز',froshtn_ba_qarz.bry_para 'نرخ-نەقد' " +
                "from item inner join froshtn on item.id = froshtn.item_id inner join froshtn_ba_qarz on froshtn.froshtn_ba_qarz_id = froshtn_ba_qarz.id inner join kryar on froshtn_ba_qarz.kryar_id = kryar.id where froshtn.dashkan > 0");
                guna2DataGridView1.Columns[0].Visible = false;
                 guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("NRT Bold", 12F);
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("NRT Reg", 12F);

                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                {
                    button.FillWeight = 38.07107F;
                    button.Width = 200;
                    button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    button.HeaderText = "";
                    button.Name = "Column1";
                    button.ReadOnly = true;
                    button.Text = "‌سرینه‌وه‌‌";
                    button.ToolTipText = "‌سرینه‌وه‌‌";
                    button.UseColumnTextForButtonValue = true;
                    this.guna2DataGridView1.Columns.Add(button);
                }
            }
            sumrows();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.Columns.Clear();
            guna2DataGridView1.DataSource = db.query("select froshtn.id, froshtn.wasl 'وەسڵ',item.barcode 'بارکۆد',item.name 'ناوی مادە',froshtn.nrxy_froshtn 'نرخی فرۆشتن',froshtn.barwary_froshtn 'بەرواری فرۆشتن',froshtn.dana 'دانە',froshtn.karton 'کارتۆن',froshtn.dashkan 'داشکان',kryar.name 'کریار',froshtn_ba_qarz.bry_qarz 'نرخ-قەرز',froshtn_ba_qarz.bry_para 'نرخ-نەقد' " +
               "from item inner join froshtn on item.id = froshtn.item_id inner join froshtn_ba_qarz on froshtn.froshtn_ba_qarz_id = froshtn_ba_qarz.id inner join kryar on froshtn_ba_qarz.kryar_id = kryar.id where froshtn.barwary_froshtn between '" + DateStart.Value.ToString("yyyy-MM-dd").Trim() + "' and '" + DateEnd.Value.ToString("yyyy-MM-dd").Trim() + "' ");
            guna2DataGridView1.Columns[0].Visible = false;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("NRT Bold", 12F);
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("NRT Reg", 12F);
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.FillWeight = 38.07107F;
                button.Width = 200;
                button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button.HeaderText = "";
                button.Name = "Column1";
                button.ReadOnly = true;
                button.Text = "‌سرینه‌وه‌‌";
                button.ToolTipText = "‌سرینه‌وه‌‌";
                button.UseColumnTextForButtonValue = true;
                this.guna2DataGridView1.Columns.Add(button);
            }
            sumrows();
        }

        private void txt_serch_TextChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedItem == "باركۆد")
            {
                guna2DataGridView1.Columns.Clear();
                guna2DataGridView1.DataSource = db.query("select froshtn.id, froshtn.wasl 'وەسڵ',item.barcode 'بارکۆد',item.name 'ناوی مادە',froshtn.nrxy_froshtn 'نرخی فرۆشتن',froshtn.barwary_froshtn 'بەرواری فرۆشتن',froshtn.dana 'دانە',froshtn.karton 'کارتۆن',froshtn.dashkan 'داشکان',kryar.name 'کریار',froshtn_ba_qarz.bry_qarz 'نرخ-قەرز',froshtn_ba_qarz.bry_para 'نرخ-نەقد' " +
                "from item inner join froshtn on item.id = froshtn.item_id inner join froshtn_ba_qarz on froshtn.froshtn_ba_qarz_id = froshtn_ba_qarz.id inner join kryar on froshtn_ba_qarz.kryar_id = kryar.id where item.barcode like '%" + txt_serch.Text + "%' ");
                guna2DataGridView1.Columns[0].Visible = false;
                 guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("NRT Bold", 12F);
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("NRT Reg", 12F);
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                {
                    button.FillWeight = 38.07107F;
                    button.Width = 200;
                    button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    button.HeaderText = "";
                    button.Name = "Column1";
                    button.ReadOnly = true;
                    button.Text = "‌سرینه‌وه‌‌";
                    button.ToolTipText = "‌سرینه‌وه‌‌";
                    button.UseColumnTextForButtonValue = true;
                    this.guna2DataGridView1.Columns.Add(button);
                }
                sumrows();

            }
            else
            {
                guna2DataGridView1.Columns.Clear();
                guna2DataGridView1.DataSource = db.query("select froshtn.id, froshtn.wasl 'وەسڵ',item.barcode 'بارکۆد',item.name 'ناوی مادە',froshtn.nrxy_froshtn 'نرخی فرۆشتن',froshtn.barwary_froshtn 'بەرواری فرۆشتن',froshtn.dana 'دانە',froshtn.karton 'کارتۆن',froshtn.dashkan 'داشکان',kryar.name 'کریار',froshtn_ba_qarz.bry_qarz 'نرخ-قەرز',froshtn_ba_qarz.bry_para 'نرخ-نەقد' " +
                "from item inner join froshtn on item.id = froshtn.item_id inner join froshtn_ba_qarz on froshtn.froshtn_ba_qarz_id = froshtn_ba_qarz.id inner join kryar on froshtn_ba_qarz.kryar_id = kryar.id where froshtn.wasl like '%" + txt_serch.Text + "%' ");
                guna2DataGridView1.Columns[0].Visible = false;
                 guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("NRT Bold", 12F);
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("NRT Reg", 12F);

                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                {
                    button.FillWeight = 38.07107F;
                    button.Width = 200;
                    button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    button.HeaderText = "";
                    button.Name = "Column1";
                    button.ReadOnly = true;
                    button.Text = "‌سرینه‌وه‌‌";
                    button.ToolTipText = "‌سرینه‌وه‌‌";
                    button.UseColumnTextForButtonValue = true;
                    this.guna2DataGridView1.Columns.Add(button);
                }
                sumrows();
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            report.frmFroshraw_rp f = new report.frmFroshraw_rp();
            f.ShowDialog();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 12)
            {
                try
                {

                    int id = (int)guna2DataGridView1.CurrentRow.Cells[0].Value;
                    string barcode = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();



                    string item_Dana = db.single("SELECT dana FROM item WHERE barcode = @barcode", new string[] { "barcode", barcode.ToString() });
                    string item_koyDana = db.single("SELECT koy_dana FROM item WHERE barcode = @barcode", new string[] { "barcode", barcode.ToString() });
                    string item_karton = db.single("SELECT karton FROM item WHERE barcode = @barcode", new string[] { "barcode", barcode.ToString() });


                    int koyKarton = Convert.ToInt32(item_karton) + int.Parse(guna2DataGridView1.CurrentRow.Cells[7].Value.ToString());


                    if (guna2DataGridView1.CurrentRow.Cells[6].Value.ToString() != "0" && guna2DataGridView1.CurrentRow.Cells[7].Value.ToString() == "0")
                    {
                        int koyDana = Convert.ToInt32(item_koyDana) + int.Parse(guna2DataGridView1.CurrentRow.Cells[6].Value.ToString());
                        db.bind(new object[] {
                                "barcode", barcode ,
                                "koy_dana" , koyDana,
                                });
                        int insertU = db.nQuery("update item set koy_dana = @koy_dana where barcode=@barcode");
                    }
                    //karton
                    if (guna2DataGridView1.CurrentRow.Cells[7].Value.ToString() != "0" && guna2DataGridView1.CurrentRow.Cells[6].Value.ToString() == "0")
                    {
                        int koyDana = Convert.ToInt32(item_koyDana) + (int.Parse(guna2DataGridView1.CurrentRow.Cells[7].Value.ToString()) * int.Parse(item_Dana));
                        db.bind(new object[] {
                                "barcode", barcode ,
                                "karton" , koyKarton,
                                "koy_dana" , koyDana,
                                });
                        int insertU = db.nQuery("update item set karton = @karton ,koy_dana = @koy_dana where barcode=@barcode");
                    }





                    int delete = db.nQuery("delete from froshtn where id = @id", new string[] { "id", id.ToString() });

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
    }
}
