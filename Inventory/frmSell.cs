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
    public partial class frmSell : Form
    {
        Db db = new Db();
        public frmSell()
        {
            InitializeComponent();
            txt_dana.DefaultText = "0";
            txt_karton.DefaultText = "0";

            //lab_shwen.Visible = false;
            //txt_naw.Visible = false;
            //lab_mobil.Visible = false;
            //txt_mobil.Visible = false;
            //btn_addQarz.Visible = false;

            //btn_korankary.Visible = false;
            txt_barcode.Focus();
            guna2DataGridView2.ThemeStyle.HeaderStyle.Font = new Font("NRT Bold", 12F);
            guna2DataGridView2.ThemeStyle.RowsStyle.Font = new Font("NRT Reg", 12F);
            dataToComb2();
            dataToComb3();
        }
        void dataToComb2()
        {

            ComboBox1.DisplayMember = "name";
            ComboBox1.ValueMember = "id";
            ComboBox1.DataSource = db.query("select id,name from kryar order by id");

        }
        void dataToComb3()
        {

            ComboBox2.DisplayMember = "name";
            ComboBox2.ValueMember = "id";
            ComboBox2.DataSource = db.query("select id,name from mandub order by id");

        }
        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (guna2CheckBox1.Checked == true)
            {
                lab_shwen.Visible = true;
                txt_naw.Visible = true;
                lab_mobil.Visible = true;
                txt_mobil.Visible = true;
                btn_addQarz.Visible = true;
                //btn_korankary.Visible = true;
                txt_naw.Text = "";
                txt_mobil.Text = "";
            }
            else
            {
                lab_shwen.Visible = false;
                txt_naw.Visible = false;
                lab_mobil.Visible = false;
                txt_mobil.Visible = false;
                btn_addQarz.Visible = false;
                //btn_korankary.Visible = false;
            }
        }

        private void btn_addtolist_Click(object sender, EventArgs e)
        {
            //string s = Properties.Settings.Default.str;
            string s = Properties.Settings.Default.id;
            try
            {
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

                        db.bind(new object[] { "barcode", txt_barcode.Text, "koy_dana", after_dana });
                        int update = db.nQuery("update item set koy_dana=@koy_dana where barcode = @barcode");

                        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

                        string wasl = db.single("SELECT max(wasl)+1 FROM froshtn");
                        if (wasl == "")
                        {
                            wasl = "1";
                        }
                        lab_psw.Text = wasl;


                        if (txt_Dwadashkan.Text != "")
                        {

                            int n = Convert.ToInt32(txt_Dwadashkan.Text);
                            int d = Convert.ToInt32(txt_dana.Text);
                            int nd = n * d;
                            object[] a = {lab_psw.Text,txt_barcode.Text, DateTime.Now.ToString("yyyy-MM-dd"),txt_dana.Text,txt_karton.Text,
                            txt_Dwadashkan.Text,nd,s,txt_dashkan.Text,txt_more_karton.Text};
                            guna2DataGridView2.Rows.Add(a);

                        }
                        else
                        {
                            int dashkan = 0;
                            int n = Convert.ToInt32(txt_nrx.Text);
                            int d = Convert.ToInt32(txt_dana.Text);
                            int nd = n * d;
                            object[] a = {lab_psw.Text,txt_barcode.Text, DateTime.Now.ToString("yyyy-MM-dd"),txt_dana.Text,txt_karton.Text,
                            txt_nrx.Text,nd,s,dashkan,txt_more_karton.Text};
                            guna2DataGridView2.Rows.Add(a);
                        }

                    }
                    else
                    {

                        if (td > ld)
                        {
                            MessageBox.Show("دانه‌ی پێویست به‌رده‌ست نییه‌ ");
                        }


                    }
                }
                
                //karton sell
                if(txt_karton.Text != "0")
                {
                    if ((lab_karton.Text != "0" && lk >= tk))
                    {
                        lab_karton.Text = after_karton.ToString();


                        //update item

                        db.bind(new object[] { "barcode", txt_barcode.Text, "karton", after_karton });
                        int update = db.nQuery("update item set karton=@karton where barcode = @barcode");

                        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

                        string wasl = db.single("SELECT max(wasl)+1 FROM froshtn");
                        if (wasl == "")
                        {
                            wasl = "1";
                        }
                        lab_psw.Text = wasl;


                        if (txt_Dwadashkan.Text != "")
                        {

                            int n = Convert.ToInt32(txt_Dwadashkan.Text);
                            int d = Convert.ToInt32(txt_karton.Text);
                            int nd = n * d;
                            object[] a = {lab_psw.Text,txt_barcode.Text, DateTime.Now.ToString("yyyy-MM-dd"),txt_dana.Text,txt_karton.Text,
                            txt_Dwadashkan.Text,nd,s,txt_dashkan.Text,txt_more_karton.Text};
                            guna2DataGridView2.Rows.Add(a);

                        }
                        else
                        {
                            int dashkan = 0;
                            int n = Convert.ToInt32(txt_nrx.Text);
                            int d = Convert.ToInt32(txt_karton.Text);
                            int nd = n * d;
                            object[] a = {lab_psw.Text,txt_barcode.Text, DateTime.Now.ToString("yyyy-MM-dd"),txt_dana.Text,txt_karton.Text,
                            txt_nrx.Text,nd,s,dashkan,txt_more_karton.Text};
                            guna2DataGridView2.Rows.Add(a);
                        }
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
            sumrows();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            report.frmFroshtn_rp f = new report.frmFroshtn_rp();
            f.ShowDialog();

        }

        private void txt_barcode_TextChanged(object sender, EventArgs e)
        {
            string[] data = db.row("SELECT * FROM item WHERE barcode = @barcode", new string[] { "barcode", txt_barcode.Text });
            txt_nrx.Text = data[5];
            lab_dana.Text = data[8];
            lab_karton.Text = data[7];
            kode_mada.Text = data[14];

        }

        public void sumrows()
        {
            int sum = 0;
            int countRow = guna2DataGridView2.Rows.Count;
            for (int i = 0; i < countRow - 1; i++)
            {
                sum = sum + int.Parse(guna2DataGridView2.Rows[i].Cells[6].Value.ToString());
            }
            lab_koypara.Text = sum.ToString("#,###,##0");
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

                        db.bind(new object[] {
                                    "barwar" , DateTime.Now.ToString("yyyy-MM-dd") ,
                                    "bry_para" , lab_koypara.Text.Replace(",", ""),
                                    "kryar_id" , ComboBox1.SelectedValue,
                        });
                        int insert_f_b_n = db.nQuery("INSERT INTO froshtn_ba_qarz(barwar, bry_para,kryar_id) VALUES " +
                            "(@barwar, @bry_para, @kryar_id)");

                        //
                        string bry_para_k = db.single("SELECT bry_para FROM kryar WHERE name = @name", new string[] { "name", ComboBox1.Text });
                        //MessageBox.Show((int.Parse(lab_koypara.Text.Replace(",", "")) + int.Parse(bry_para_k)).ToString());
                        db.bind(new object[] {
                                        "bry_para" , int.Parse(lab_koypara.Text.Replace(",", "")) + int.Parse(bry_para_k),
                            });
                        int update_kryar = db.nQuery("update kryar set bry_para=@bry_para where name = @name", new string[] { "name", ComboBox1.Text });
                    //
                    string naqd_last_id = db.single("SELECT MAX(id) id FROM froshtn_ba_qarz ");

                        for (int i = 0; i < countRow - 1; i++)
                        {
                            string item_id = db.single("SELECT id FROM item WHERE barcode = @barcode", new string[] { "barcode", guna2DataGridView2.Rows[i].Cells[1].Value.ToString() });

                            double mawa = 0;
                            //int id = int.Parse(guna2DataGridView2.Rows[i].Cells[0].Value.ToString());
                            int dana = int.Parse(guna2DataGridView2.Rows[i].Cells[3].Value.ToString());
                            int karton = int.Parse(guna2DataGridView2.Rows[i].Cells[4].Value.ToString());

                            string[] data = db.row("SELECT count(*) FROM froshtn ");
                            string[] item = db.row("SELECT * FROM item where id=@id ",new string[] { "id", item_id });
                            if(data[0] == "0")
                            {
                                if(dana >= int.Parse(item[6]))
                                {
                                    int n_mini = dana / int.Parse(item[6]);
                                    int zhmaray_karton_U = int.Parse(item[7]) - n_mini;
                                    db.bind(new object[] { "id", int.Parse(item_id), "karton", zhmaray_karton_U });
                                    int update = db.nQuery("update item set karton=@karton where id = @id");

                                    int dana_f = dana - int.Parse(item[6]);
                                    mawa = (n_mini * int.Parse(item[6])) - dana_f;
                                    
                                }
                                if (dana < int.Parse(item[6]))
                                {
                                    mawa = int.Parse(item[6]) - dana;
                                }

                            }
                            else
                            {
                                db.bind(new object[] { "item_id", int.Parse(item_id) });
                                string[] sell = db.row("SELECT mawa FROM froshtn where (mawa != 0) AND item_id = @item_id ");
                                db.bind(new object[] { "item_id", int.Parse(item_id) });
                                string[] sell_rowCount = db.row("SELECT count(mawa) FROM froshtn where (mawa != 0) AND item_id = @item_id ");

                                if (sell_rowCount[0] != "0" && sell[0] != "0" )
                                {
                                    if (dana != 0)
                                    {
                                        if (int.Parse(sell[0]) > dana)
                                        {
                                            mawa = int.Parse(sell[0]) - dana;
                                            db.bind(new object[] { "item_id", int.Parse(item_id) , "mawa", 0 });
                                            int update = db.nQuery("update froshtn set mawa=@mawa where item_id = @item_id");
                                        }
                                        else
                                        {
                                            int dana_f = dana - int.Parse(sell[0]);
                                            int zhmaray_karton_U = int.Parse(item[7]) - 1;
                                            //
                                            db.bind(new object[] { "id", int.Parse(item_id), "karton", zhmaray_karton_U });
                                            int update_i = db.nQuery("update item set karton=@karton where id = @id");
                                            //
                                            db.bind(new object[] { "item_id", int.Parse(item_id), "mawa", 0 });
                                            int update_f = db.nQuery("update froshtn set mawa=@mawa where item_id = @item_id");

                                            if (dana_f < int.Parse(item[6]))
                                            {
                                                if (dana_f != 0)
                                                {
                                                    mawa = int.Parse(item[6]) - dana_f;
                                                }
                                            }
                                            else
                                            {
                                                int n_mini = dana_f / int.Parse(item[6]);
                                                zhmaray_karton_U = zhmaray_karton_U - n_mini;
                                                db.bind(new object[] { "id", int.Parse(item_id), "karton", zhmaray_karton_U });
                                                int update = db.nQuery("update item set karton=@karton where id = @id");
                                                 mawa = dana_f - (n_mini * int.Parse(item[6]));
                    }
                                        }
                                    }
                                }
                                if (sell_rowCount[0] == "0")
                                {
                                   
                                    if (dana >= int.Parse(item[6]))
                                    {
                                        int n_mini = dana / int.Parse(item[6]);
                                        int zhmaray_karton_U = int.Parse(item[7]) - n_mini;
                                        db.bind(new object[] { "id", int.Parse(item_id), "karton", zhmaray_karton_U });
                                        int update = db.nQuery("update item set karton=@karton where id = @id");

                                        int dana_f = dana - int.Parse(item[6]);
                                        mawa = (n_mini * int.Parse(item[6])) - dana_f;

                                    }
                                    if (dana < int.Parse(item[6]))
                                    {
                                        mawa = int.Parse(item[6]) - dana;
                                    }
                                }
                            }
                            //


                                db.bind(new object[] {
                                    "item_id", item_id ,
                                    "froshtn_ba_qarz_id", naqd_last_id ,
                                    "wasl", guna2DataGridView2.Rows[i].Cells[0].Value.ToString() ,
                                    "nrxy_froshtn", guna2DataGridView2.Rows[i].Cells[5].Value.ToString() ,
                                    "barwary_froshtn", guna2DataGridView2.Rows[i].Cells[2].Value.ToString() ,
                                    "dana", guna2DataGridView2.Rows[i].Cells[3].Value.ToString() ,
                                    "karton", guna2DataGridView2.Rows[i].Cells[4].Value.ToString() ,
                                    "dashkan", guna2DataGridView2.Rows[i].Cells[8].Value.ToString() ,
                                    "user_id", guna2DataGridView2.Rows[i].Cells[7].Value.ToString() ,
                                    "mawa", mawa ,
                                    "more_karton", txt_more_karton.Text ,
                                    "mandub_id", ComboBox2.SelectedValue ,
                                });
                                int insert = db.nQuery("INSERT INTO froshtn ( item_id,froshtn_ba_qarz_id,wasl,nrxy_froshtn,barwary_froshtn,dana,karton,dashkan,user_id,mawa,more_karton,mandub_id) VALUES " +
                                    "(@item_id, @froshtn_ba_qarz_id , @wasl, @nrxy_froshtn, @barwary_froshtn, @dana, @karton, @dashkan,@user_id, @mawa,@more_karton,@mandub_id)");



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

        private void txt_karton_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_dana_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 9)
                {

                    if (guna2DataGridView2.CurrentRow.Cells[3].Value?.ToString() != "0" && guna2DataGridView2.CurrentRow.Cells[4].Value?.ToString() == "0")
                    {
                        int barcod = int.Parse(guna2DataGridView2.CurrentRow.Cells[1].Value.ToString());

                        string item_dana = db.single("SELECT dana FROM item WHERE barcode = @barcode", new string[] { "barcode", barcod.ToString() });
                        int ko_dana = (int.Parse(item_dana) + int.Parse(guna2DataGridView2.CurrentRow.Cells[3].Value.ToString()));

                        db.bind(new object[] { "barcode", barcod.ToString(), "koy_dana", ko_dana });
                        int update = db.nQuery("update item set koy_dana=@koy_dana where barcode = @barcode");
                    }

                    //karton
                    if (guna2DataGridView2.CurrentRow.Cells[4].Value?.ToString() != "0" && guna2DataGridView2.CurrentRow.Cells[3].Value?.ToString() == "0")
                    {
                        int barcod = int.Parse(guna2DataGridView2.CurrentRow.Cells[1].Value.ToString());

                        string item_karton = db.single("SELECT karton FROM item WHERE barcode = @barcode", new string[] { "barcode", barcod.ToString() });
                        int ko_karton = (int.Parse(item_karton) + int.Parse(guna2DataGridView2.CurrentRow.Cells[4].Value.ToString()));

                        db.bind(new object[] { "barcode", barcod.ToString(), "karton", ko_karton });
                        int update = db.nQuery("update item set karton=@karton where barcode = @barcode");
                    }
                }

                if (e.ColumnIndex == 9)
                {
                    if (guna2DataGridView2.CurrentRow.Cells[3].Value?.ToString() != "0" && guna2DataGridView2.CurrentRow.Cells[4].Value?.ToString() == "0")
                    {
                        int ko_dana = (Convert.ToInt32(lab_dana.Text) + int.Parse(guna2DataGridView2.CurrentRow.Cells[3].Value.ToString()));
                        lab_dana.Text = ko_dana.ToString();
                        guna2DataGridView2.Rows.RemoveAt(guna2DataGridView2.CurrentCell.RowIndex);
                    }


                }
                if(e.ColumnIndex == 9)
                {

                    //karton
                    if (guna2DataGridView2.CurrentRow.Cells[4].Value?.ToString() != "0" && guna2DataGridView2.CurrentRow.Cells[3].Value?.ToString() == "0")
                    {
                        int ko_dana = (Convert.ToInt32(lab_karton.Text) + int.Parse(guna2DataGridView2.CurrentRow.Cells[4].Value.ToString()));
                        lab_karton.Text = ko_dana.ToString();
                        guna2DataGridView2.Rows.RemoveAt(guna2DataGridView2.CurrentCell.RowIndex);
                    }

                }
                sumrows();

            }
            catch (Exception )
            {


            }
        }

        private void guna2DataGridView2_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void txt_dashkan_TextChanged(object sender, EventArgs e)
        {

            try
            {

                if (txt_dashkan.Text != "")
                {

                    double n = Convert.ToDouble(txt_nrx.Text);
                    double dash = Convert.ToDouble(txt_dashkan.Text);
                    double lasada = dash / 100;
                    double kodashkan = lasada * n;
                    string Dwadashkan = (n - kodashkan).ToString();


                    string item_karton = db.single("SELECT nrxy_kryn FROM item WHERE barcode = @barcode", new string[] { "barcode", txt_barcode.Text });
                    

                        if (int.Parse(item_karton.ToString()) < int.Parse(Dwadashkan))
                        {
                            txt_Dwadashkan.Text = Dwadashkan;
                        }
                        else if (int.Parse(item_karton.ToString()) == int.Parse(Dwadashkan))
                        {
                            txt_Dwadashkan.Text = Dwadashkan;
                            MessageBox.Show("بەم داشکانە نە زەرەر دەکەی نە قازانج");
                        }
                        else
                        {
                            //txt_Dwadashkan.Text = "";
                            //MessageBox.Show(" ناتوانی داشكانی له‌سه‌دا " + dash + " بكه‌ی ");
                            txt_Dwadashkan.Text = Dwadashkan;
                            MessageBox.Show("بەم داشکانە دەکەویتە زەرەرەوە");
                        }

                    

                }
                else
                {
                    txt_Dwadashkan.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void txt_karton_Enter(object sender, EventArgs e)
        {
            txt_dana.Text = "0";
            txt_karton.Text = "";
            txt_more_karton.Text = "";
        }

        private void txt_dana_Enter(object sender, EventArgs e)
        {
            txt_karton.Text = "0";
            txt_dana.Text = "";
            txt_more_karton.Text = "";
        }

        private void btn_addQarz_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_barcode.Text != "" && ComboBox1.Text != "" )
                {

                    DialogResult dr = MessageBox.Show("ئه‌ته‌وێ فرۆشتن بكه‌یت‌", "ئاگاداری", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        int countRow = guna2DataGridView2.Rows.Count;


                        db.bind(new object[] {
                                                                      "barwar" , DateTime.Now.ToString("yyyy-MM-dd") ,
                                    "bry_qarz" , lab_koypara.Text.Replace(",", ""),
                                    "kryar_id" , ComboBox1.SelectedValue,
                        });
                        int insert_f_b_q = db.nQuery("INSERT INTO froshtn_ba_qarz(barwar, bry_qarz, kryar_id) VALUES " +
                            "(@barwar, @bry_qarz, @kryar_id)");
                        //
                        string bry_para_k = db.single("SELECT bry_qarz FROM kryar WHERE name = @name", new string[] { "name", ComboBox1.Text });
                        //MessageBox.Show((int.Parse(lab_koypara.Text.Replace(",", "")) + int.Parse(bry_para_k)).ToString());
                        db.bind(new object[] {
                                        "bry_qarz" , int.Parse(lab_koypara.Text.Replace(",", "")) + int.Parse(bry_para_k),
                                        "bry_qarzy_nwe" , int.Parse(lab_koypara.Text.Replace(",", "")),
                            });
                        int update_kryar = db.nQuery("update kryar set bry_qarz=@bry_qarz,bry_qarzy_nwe=@bry_qarzy_nwe where name = @name", new string[] { "name", ComboBox1.Text });
                        //


                        string qarz_last_id = db.single("SELECT MAX(id) id FROM froshtn_ba_qarz ");

                        for (int i = 0; i < countRow - 1; i++)
                        {
                            string item_id = db.single("SELECT id FROM item WHERE barcode = @barcode", new string[] { "barcode", guna2DataGridView2.Rows[i].Cells[1].Value.ToString() });

                            double mawa = 0;
                            int dana = int.Parse(guna2DataGridView2.Rows[i].Cells[3].Value.ToString());
                            int karton = int.Parse(guna2DataGridView2.Rows[i].Cells[4].Value.ToString());

                            string[] data = db.row("SELECT count(*) FROM froshtn ");
                            string[] item = db.row("SELECT * FROM item where id=@id ", new string[] { "id", item_id });
                            if (data[0] == "0")
                            {
                                if (dana >= int.Parse(item[6]))
                                {
                                    int n_mini = dana / int.Parse(item[6]);
                                    int zhmaray_karton_U = int.Parse(item[7]) - n_mini;
                                    db.bind(new object[] { "id", int.Parse(item_id), "karton", zhmaray_karton_U });
                                    int update = db.nQuery("update item set karton=@karton where id = @id");

                                    int dana_f = dana - int.Parse(item[6]);
                                    mawa = (n_mini * int.Parse(item[6])) - dana_f;

                                }
                                if (dana < int.Parse(item[6]))
                                {
                                    mawa = int.Parse(item[6]) - dana;
                                }

                            }
                            else
                            {
                                db.bind(new object[] { "item_id", int.Parse(item_id) });
                                string[] sell = db.row("SELECT mawa FROM froshtn where (mawa != 0) AND item_id = @item_id ");
                                db.bind(new object[] { "item_id", int.Parse(item_id) });
                                string[] sell_rowCount = db.row("SELECT count(mawa) FROM froshtn where (mawa != 0) AND item_id = @item_id ");

                                if (sell_rowCount[0] != "0" && sell[0] != "0")
                                {
                                    if (dana != 0)
                                    {
                                        if (int.Parse(sell[0]) > dana)
                                        {
                                            mawa = int.Parse(sell[0]) - dana;
                                            db.bind(new object[] { "item_id", int.Parse(item_id), "mawa", 0 });
                                            int update = db.nQuery("update froshtn set mawa=@mawa where item_id = @item_id");
                                        }
                                        else
                                        {
                                            int dana_f = dana - int.Parse(sell[0]);
                                            int zhmaray_karton_U = int.Parse(item[7]) - 1;
                                            //
                                            db.bind(new object[] { "id", int.Parse(item_id), "karton", zhmaray_karton_U });
                                            int update_i = db.nQuery("update item set karton=@karton where id = @id");
                                            //
                                            db.bind(new object[] { "item_id", int.Parse(item_id), "mawa", 0 });
                                            int update_f = db.nQuery("update froshtn set mawa=@mawa where item_id = @item_id");

                                            if (dana_f < int.Parse(item[6]))
                                            {
                                                if (dana_f != 0)
                                                {
                                                    mawa = int.Parse(item[6]) - dana_f;
                                                }
                                            }
                                            else
                                            {
                                                int n_mini = dana_f / int.Parse(item[6]);
                                                zhmaray_karton_U = zhmaray_karton_U - n_mini;
                                                db.bind(new object[] { "id", int.Parse(item_id), "karton", zhmaray_karton_U });
                                                int update = db.nQuery("update item set karton=@karton where id = @id");
                                                mawa = dana_f - (n_mini * int.Parse(item[6]));
                                            }
                                        }
                                    }
                                }
                                if (sell_rowCount[0] == "0")
                                {

                                    if (dana >= int.Parse(item[6]))
                                    {
                                        int n_mini = dana / int.Parse(item[6]);
                                        int zhmaray_karton_U = int.Parse(item[7]) - n_mini;
                                        db.bind(new object[] { "id", int.Parse(item_id), "karton", zhmaray_karton_U });
                                        int update = db.nQuery("update item set karton=@karton where id = @id");

                                        int dana_f = dana - int.Parse(item[6]);
                                        mawa = (n_mini * int.Parse(item[6])) - dana_f;

                                    }
                                    if (dana < int.Parse(item[6]))
                                    {
                                        mawa = int.Parse(item[6]) - dana;
                                    }
                                }
                            }


                            //Sell
                            db.bind(new object[] {
                                    "item_id", item_id ,
                                    "froshtn_ba_qarz_id", int.Parse(qarz_last_id) ,
                                    "wasl", guna2DataGridView2.Rows[i].Cells[0].Value.ToString() ,
                                    "nrxy_froshtn", guna2DataGridView2.Rows[i].Cells[5].Value.ToString() ,
                                    "barwary_froshtn", guna2DataGridView2.Rows[i].Cells[2].Value.ToString() ,
                                    "dana", guna2DataGridView2.Rows[i].Cells[3].Value.ToString() ,
                                    "karton", guna2DataGridView2.Rows[i].Cells[4].Value.ToString() ,
                                    "dashkan", guna2DataGridView2.Rows[i].Cells[8].Value.ToString() ,
                                    "user_id", guna2DataGridView2.Rows[i].Cells[7].Value.ToString() ,
                                    "mawa", mawa ,
                                    "more_karton", txt_more_karton.Text ,
                                    "mandub_id", ComboBox2.SelectedValue ,
                                });
                            int insert = db.nQuery("INSERT INTO froshtn ( item_id,froshtn_ba_qarz_id,wasl,nrxy_froshtn,barwary_froshtn,dana,karton,dashkan,user_id,mawa,more_karton,mandub_id) VALUES " +
                                "(@item_id, @froshtn_ba_qarz_id, @wasl, @nrxy_froshtn, @barwary_froshtn, @dana, @karton, @dashkan,@user_id, @mawa,@more_karton,@mandub_id)");



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

        private void frmSell_FormClosed(object sender, FormClosedEventArgs e)
        {
            int countRow = guna2DataGridView2.Rows.Count;

            for (int i = 0; i < countRow - 1; i++)
            {
                string item_id = db.single("SELECT id FROM item WHERE barcode = @barcode", new string[] { "barcode", guna2DataGridView2.Rows[i].Cells[1].Value.ToString() });
                string item_koy_dana = db.single("SELECT koy_dana FROM item WHERE barcode = @barcode", new string[] { "barcode", guna2DataGridView2.Rows[i].Cells[1].Value.ToString() });
                
                int koyDana = int.Parse(guna2DataGridView2.Rows[i].Cells[3].Value.ToString()) + int.Parse(item_koy_dana);
                db.bind(new object[] { "id", int.Parse(item_id), "koy_dana", koyDana });
                int update = db.nQuery("update item set koy_dana=@koy_dana where id = @id");
            }
        }

        private void btn_add_kryar_Click(object sender, EventArgs e)
        {
            if (txt_naw.Text != "" && txt_shwen.Text != "" && txt_mobil.Text != "" && ComboBox2.Text != "")
            {

                DialogResult dr = MessageBox.Show("ئه‌ته‌وێ جۆر زیاد بكه‌یت‌", "ئاگاداری", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    db.bind(new object[] {
                        "name", txt_naw.Text ,
                        "shwen", txt_shwen.Text ,
                        "mobile", txt_mobil.Text ,
                        "mandub_id", ComboBox2.SelectedValue ,
                    });
                    int insert = db.nQuery("INSERT INTO kryar (name,shwen,mobile,mandub_id) VALUES (@name,@shwen,@mobile,@mandub_id)");
                    dataToComb2();
                    MessageBox.Show("به‌سه‌ركه‌وتووی تۆماركرا");
                    
                }

            }
            else
            {
                MessageBox.Show("تكایه‌ خانه‌كان پربكه‌وه‌");

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void kode_mada_TextChanged(object sender, EventArgs e)
        {
            string[] data = db.row("SELECT * FROM item WHERE kode = @barcode", new string[] { "barcode", kode_mada.Text });
            txt_barcode.Text = data[1];
            txt_nrx.Text = data[5];
            lab_dana.Text = data[8];
            lab_karton.Text = data[7];
        }
    }
}
