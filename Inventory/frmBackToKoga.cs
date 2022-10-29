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
    public partial class frmBackToKoga : Form
    {
        Db db = new Db();
        public frmBackToKoga()
        {
            InitializeComponent();
            txt_dana.DefaultText = "0";
            txt_karton.DefaultText = "0";
        }
        void dataToComb2()
        {

            ComboBox1.DisplayMember = "name";
            ComboBox1.ValueMember = "id";
            ComboBox1.DataSource = db.query("select id,name from kryar order by id");

        }
        private void btn_addtolist_Click(object sender, EventArgs e)
        {
            try
            {

            //dana
            int td = int.Parse(txt_dana.Text);
            int ld = int.Parse(lab_dana.Text);
            // karton
            int tk = int.Parse(txt_karton.Text);
            int lk = int.Parse(lab_karton.Text);

            int after_dana = ld - td;
            int after_karton = lk - tk;

                if (txt_dana.Text != "0")
                {
                    if (lab_dana.Text != "0" && (Convert.ToInt32(lab_dana.Text) >= Convert.ToInt32(txt_dana.Text)))
                    {
                        lab_dana.Text = after_dana.ToString();


                        //update item

                        //db.bind(new object[] { "barcode", txt_barcode.Text, "koy_dana", after_dana });
                        //int update = db.nQuery("update item set koy_dana=@koy_dana where barcode = @barcode");

                        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

                        int n = Convert.ToInt32(txt_nrx.Text);
                        int d = Convert.ToInt32(txt_dana.Text);
                        int nd = n * d;
                        //int d = Convert.ToInt32(txt_dana.Text);
                        object[] a = {kode_mada.Text,txt_barcode.Text, DateTime.Now.ToString("yyyy-MM-dd"),txt_dana.Text,txt_karton.Text,nd,ComboBox1.SelectedValue};
                        guna2DataGridView2.Rows.Add(a);


                    }
                    else
                    {

                        if (td > ld)
                        {
                            MessageBox.Show("دانه‌ی پێویست به‌رده‌ست نییه‌ ");
                        }


                    }
                }
                // karton
                if (txt_karton.Text != "0")
                {
                    if ((lab_karton.Text != "0" && lk >= tk))
                    {
                        lab_karton.Text = after_karton.ToString();


                        //update item

                        //db.bind(new object[] { "barcode", txt_barcode.Text, "karton", after_karton });
                        //int update = db.nQuery("update item set karton=@karton where barcode = @barcode");

                        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        int n = Convert.ToInt32(txt_nrx.Text);
                        int d = Convert.ToInt32(txt_karton.Text);
                        int nd = n * d;
                        //int d = Convert.ToInt32(txt_dana.Text);
                        object[] a = { kode_mada.Text, txt_barcode.Text, DateTime.Now.ToString("yyyy-MM-dd"), txt_dana.Text, txt_karton.Text, nd,ComboBox1.SelectedValue };
                        guna2DataGridView2.Rows.Add(a);



                    }
                    else
                    {
                        if (tk > lk)
                        {
                            MessageBox.Show("کارتۆنی‌ پێویست به‌رده‌ست نییه‌ ");
                        }
                    }
                }


            }
            catch (Exception)
            {

                MessageBox.Show("هیچ داتایه‌ك نییه‌ بۆ ناردن بۆ لیستی فرۆشتن");
            }

        }

        private void txt_barcode_TextChanged(object sender, EventArgs e)
        {
            //
            string[] data = db.row("select item.barcode,item.kode,sum(froshtn.dana),sum(froshtn.karton),kryar.name  from item inner join froshtn on froshtn.item_id = item.id inner join froshtn_ba_qarz on froshtn.froshtn_ba_qarz_id = froshtn_ba_qarz.id inner join kryar on froshtn_ba_qarz.kryar_id = kryar.id WHERE barcode = '"+ txt_barcode.Text + "' And kryar.name = '"+ComboBox1.Text+"' group by  item.barcode,item.kode,kryar.name  ");
            kode_mada.Text = data[1];
            lab_dana.Text = data[2];
            lab_karton.Text = data[3];
        }

        private void kode_mada_TextChanged(object sender, EventArgs e)
        {
            string[] data = db.row("select item.barcode,item.kode,sum(froshtn.dana),sum(froshtn.karton),kryar.name  from item inner join froshtn on froshtn.item_id = item.id inner join froshtn_ba_qarz on froshtn.froshtn_ba_qarz_id = froshtn_ba_qarz.id inner join kryar on froshtn_ba_qarz.kryar_id = kryar.id WHERE kode = '" + kode_mada.Text + "' And kryar.name = '" + ComboBox1.Text + "' group by  item.barcode,item.kode,kryar.name  ");
            txt_barcode.Text = data[0];
            lab_dana.Text = data[2];
            lab_karton.Text = data[3];
        }

        private void txt_karton_Enter(object sender, EventArgs e)
        {
            txt_dana.Text = "0";
            txt_karton.Text = "";
        }

        private void txt_dana_Enter(object sender, EventArgs e)
        {
            txt_dana.Text = "";
            txt_karton.Text = "0";
        }

        private void frmBackToKoga_Load(object sender, EventArgs e)
        {
            dataToComb2();
        }

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 7)
                {
                    if (guna2DataGridView2.CurrentRow.Cells[3].Value?.ToString() != "0" && guna2DataGridView2.CurrentRow.Cells[4].Value?.ToString() == "0")
                    {
                        int ko_dana = (Convert.ToInt32(lab_dana.Text) + int.Parse(guna2DataGridView2.CurrentRow.Cells[3].Value.ToString()));
                        lab_dana.Text = ko_dana.ToString();
                        guna2DataGridView2.Rows.RemoveAt(guna2DataGridView2.CurrentCell.RowIndex);
                    }


                }
                if (e.ColumnIndex == 6)
                {

                    //karton
                    if (guna2DataGridView2.CurrentRow.Cells[4].Value?.ToString() != "0" && guna2DataGridView2.CurrentRow.Cells[3].Value?.ToString() == "0")
                    {
                        int ko_dana = (Convert.ToInt32(lab_karton.Text) + int.Parse(guna2DataGridView2.CurrentRow.Cells[4].Value.ToString()));
                        lab_karton.Text = ko_dana.ToString();
                        guna2DataGridView2.Rows.RemoveAt(guna2DataGridView2.CurrentCell.RowIndex);
                    }

                }


            }
            catch (Exception)
            {


            }
        }

        private void btn_frost_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_barcode.Text != "" && ComboBox1.Text != "")
                {

                    DialogResult dr = MessageBox.Show("ئه‌ته‌وێ فرۆشتن بكه‌یت‌", "ئاگاداری", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        int countRow = guna2DataGridView2.Rows.Count;



                        for (int i = 0; i < countRow - 1; i++)
                        {
                            db.bind(new object[] {
                                    "item_name", guna2DataGridView2.Rows[i].Cells[0].Value.ToString() ,
                                    "barcode", guna2DataGridView2.Rows[i].Cells[1].Value.ToString() ,
                                    "barwar", guna2DataGridView2.Rows[i].Cells[2].Value.ToString() ,
                                    "nrxy_garanawaa", guna2DataGridView2.Rows[i].Cells[5].Value.ToString() ,
                                    "dana", guna2DataGridView2.Rows[i].Cells[3].Value.ToString() ,
                                    "karton", guna2DataGridView2.Rows[i].Cells[4].Value.ToString() ,
                                    "froshtn_id", guna2DataGridView2.Rows[i].Cells[6].Value.ToString() ,
                                });
                            int insert = db.nQuery("INSERT INTO back_to_koga ( barcode,item_name,nrxy_garanawaa,dana,karton,barwar,froshtn_id) VALUES " +
                                "( @barcode,@item_name,@nrxy_garanawaa,@dana,@karton,@barwar,@froshtn_id)");

                            string item_Dana = db.single("SELECT dana FROM item WHERE barcode = @barcode", new string[] { "barcode", txt_barcode.Text });
                            string item_koyDana = db.single("SELECT koy_dana FROM item WHERE barcode = @barcode", new string[] { "barcode", txt_barcode.Text });
                            string item_karton = db.single("SELECT karton FROM item WHERE barcode = @barcode", new string[] { "barcode", txt_barcode.Text });

                            
                            int koyKarton = Convert.ToInt32(item_karton) + int.Parse(guna2DataGridView2.Rows[i].Cells[4].Value.ToString());

                            
                            if (guna2DataGridView2.Rows[i].Cells[3].Value.ToString() != "0" && guna2DataGridView2.Rows[i].Cells[4].Value.ToString() == "0")
                            {
                                int koyDana = Convert.ToInt32(item_koyDana) + int.Parse(guna2DataGridView2.Rows[i].Cells[3].Value.ToString());
                                MessageBox.Show(koyDana.ToString());
                                db.bind(new object[] {
                                "barcode", txt_barcode.Text ,
                                "koy_dana" , koyDana,
                                });
                                int insertU = db.nQuery("update item set koy_dana = @koy_dana where barcode=@barcode");
                            }
                            //karton
                            if (guna2DataGridView2.Rows[i].Cells[4].Value.ToString() != "0" && guna2DataGridView2.Rows[i].Cells[3].Value.ToString() == "0")
                            {
                                int koyDana = Convert.ToInt32(item_koyDana) + (int.Parse(guna2DataGridView2.Rows[i].Cells[4].Value.ToString()) * int.Parse(item_Dana));
                                db.bind(new object[] {
                                "barcode", txt_barcode.Text ,
                                "karton" , koyKarton,
                                "koy_dana" , koyDana,
                                });
                                int insertU = db.nQuery("update item set karton = @karton ,koy_dana = @koy_dana where barcode=@barcode");
                            }

                        }

                        MessageBox.Show("به‌سه‌ركه‌وتووی تۆماركرا");

                        guna2DataGridView2.Rows.Clear();

                    }
                }
                else
                {
                    MessageBox.Show("تكایه‌ خانه‌كان پربكه‌وه‌");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("هه‌ڵه‌یه‌ك رووی دا‌");

            }
        }
    }
}
