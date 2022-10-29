using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class frmAddItem : Form
    {
        Db db = new Db();
        public frmAddItem()
        {
            InitializeComponent();
            
        }
        void dataToComb1()
        {
            ComboBox1.DisplayMember = "name";
            ComboBox1.ValueMember = "id";
            ComboBox1.DataSource = db.query("select id,name from company order by id");
        }

        void dataToComb2()
        {
            
            ComboBox2.DisplayMember = "name";
            ComboBox2.ValueMember = "id";
            ComboBox2.DataSource = db.query("select id,name from types order by id");

        }
        private void btn_add_kryn_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (ComboBox1.SelectedItem != null && barwary_wasl.Text != "" && barwary_zyadkrdn.Text != "" && zhmaray_wasl.Text != "" && bry_para.Text != "" )
                {
                    DialogResult dr = MessageBox.Show("ئه‌ته‌وێ وەسڵ  زیاد بکەی‌", "ئاگاداری", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                    db.bind(new object[] {
                            "company_id", ComboBox1.SelectedValue ,
                            "zhmaray_wasl", zhmaray_wasl.Text ,
                            "barwary_wasl", barwary_wasl.Text ,
                            "barway_zyadkrdn", barwary_zyadkrdn.Text ,
                            "bry_para", bry_para.Text ,
                            "bry_qarz", bry_qarz.Text ,
                        });
                    int insert = db.nQuery("INSERT INTO kryn (company_id,zhmaray_wasl,barwary_wasl,barway_zyadkrdn,bry_para,bry_qarz) VALUES (@company_id,@zhmaray_wasl,@barwary_wasl,@barway_zyadkrdn,@bry_para,@bry_qarz)");


                    string bry_para_k = db.single("SELECT bry_para FROM company WHERE name = @name", new string[] { "name", ComboBox1.Text });
                        string bry_qarz_k = db.single("SELECT bry_qarz FROM company WHERE name = @name", new string[] { "name", ComboBox1.Text });
                    if (bry_qarz.Text != "")
                    {
                        db.bind(new object[] {
                                    "bry_para" , (int.Parse(bry_para.Text) - int.Parse(bry_qarz.Text)) + int.Parse(bry_para_k),
                                    "bry_qarz" , int.Parse(bry_qarz.Text) + int.Parse(bry_qarz_k),
                                    "bry_qarzy_nwe" , bry_qarz.Text,
                        });
                        int update_kryar = db.nQuery("update company set bry_para=@bry_para,bry_qarz=@bry_qarz,bry_qarzy_nwe=@bry_qarzy_nwe where name = @name", new string[] { "name", ComboBox1.Text });

                    }
                    else
                    {
                        int qarz = 0;
                        db.bind(new object[] {
                                    "bry_para" , int.Parse(bry_para.Text) + int.Parse(bry_para_k),
                                    "bry_qarz" , qarz + int.Parse(bry_qarz_k),
                        });
                        int update_kryar = db.nQuery("update company set bry_para=@bry_para,bry_qarz=@bry_qarz where name = @name", new string[] { "name", ComboBox1.Text });

                    }



                    MessageBox.Show("به‌سه‌ركه‌وتووی تۆماركرا");
                    }
                }
                else
                {
                    MessageBox.Show("تكایه‌ خانه‌كان پربكه‌وه‌");
                }


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);

            //}
        }

        private void btn_add_item_Click(object sender, EventArgs e)
        {

            int user_id = int.Parse(Properties.Settings.Default.id);
            try
            {
                if (ComboBox2.SelectedItem != null && barcode.Text != "" && name_item.Text != "" 
                    && barwary_basarchwn.Text != "" && barwary_zyadkrdn_item.Text != "" && nrxy_kryn.Text != "" && nrxy_kryn_j.Text != "" && nrxy_froshtn.Text != ""
                    && karton.Text != "" && dana.Text != ""){
                    DialogResult dr = MessageBox.Show("ئه‌ته‌وێ وەسڵ  زیاد بکەی‌", "ئاگاداری", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {

                        // Fetch one single value
                        string age = db.single("SELECT barcode FROM item WHERE barcode = @barcode", new string[] { "barcode", barcode.Text });
                        if(age != "")
                        {
                            
                            string item_karton = db.single("SELECT karton FROM item WHERE barcode = @barcode", new string[] { "barcode", barcode.Text });
                            string item_koyDana = db.single("SELECT koy_dana FROM item WHERE barcode = @barcode", new string[] { "barcode", barcode.Text });
                            string item_Dana = db.single("SELECT dana FROM item WHERE barcode = @barcode", new string[] { "barcode", barcode.Text });
                           
                                int danaU = Convert.ToInt32(dana.Text) * Convert.ToInt32(karton.Text);
                                int kartonU = Convert.ToInt32(karton.Text) + Convert.ToInt32(item_karton);
                                int koyDana = Convert.ToInt32(item_koyDana) + danaU;

                                string id_kryn = db.single("select max(id) as id from kryn");

                                db.bind(new object[] {
                                    "id", id_item.Text ,
                                    "name", name_item.Text ,
                                    "nrxy_kryn", nrxy_kryn.Text.Replace(",", ""),
                                    "nrxy_froshtn", nrxy_froshtn.Text.Replace(",", "") ,
                                    "karton", kartonU ,
                                    "koy_dana" , koyDana ,
                                    "barwary_kryn", barwary_zyadkrdn_item.Text ,
                                    "barwary_basarchwn", barwary_basarchwn.Text ,
                                    "user_id", user_id,
                                    "kryn_id", id_kryn ,
                                    "nrxy_kryn_j", nrxy_kryn_j.Text.Replace(",", "") ,
                                });
                                int insert = db.nQuery("update item set name = @name ,nrxy_kryn = @nrxy_kryn ,nrxy_froshtn = @nrxy_froshtn ,karton = @karton ,koy_dana = @koy_dana,barwary_kryn = @barwary_kryn ,barwary_basarchwn = @barwary_basarchwn ,user_id = @user_id ,kryn_id = @kryn_id,nrxy_kryn_j = @nrxy_kryn_j  where id=@id");

                            db.bind(new object[] {
                                    "name", name_item.Text ,
                                    "nrxy_kryn", nrxy_kryn.Text.Replace(",", "") ,
                                    "nrxy_kryn_j", nrxy_kryn_j.Text.Replace(",", "") ,
                                    "nrxy_froshtn", nrxy_froshtn.Text.Replace(",", "") ,
                                    "dana", dana.Text ,
                                    "karton", karton.Text ,
                                    "koy_dana" , danaU ,
                                    "barwary_kryn", barwary_zyadkrdn_item.Text ,
                                    "barwary_basarchwn", barwary_basarchwn.Text ,
                                    "user_id", user_id,
                                    "kryn_id", id_kryn ,
                                    "item_id", id_item.Text
                                });
                            int insertA = db.nQuery("INSERT INTO itemAdd (name,nrxy_kryn,nrxy_kryn_j,nrxy_froshtn,dana,karton,koy_dana,barwary_kryn,barwary_basarchwn,user_id,kryn_id,item_id) VALUES (@name,@nrxy_kryn,@nrxy_kryn_j,@nrxy_froshtn,@dana,@karton,@koy_dana,@barwary_kryn,@barwary_basarchwn,@user_id,@kryn_id,@item_id)");


                            MessageBox.Show("به‌سه‌ركه‌وتووی تۆماركرا1");
                            
                        }
                        else
                        {
                            int koyDana = Convert.ToInt32(dana.Text) * Convert.ToInt32(karton.Text);
                            string id_kryn = db.single("select max(id) as id from kryn");
                            db.bind(new object[] {
                            "barcode", barcode.Text,
                            "name", name_item.Text ,
                            "type_id", ComboBox2.SelectedValue ,
                            "nrxy_kryn", nrxy_kryn.Text ,
                            "nrxy_froshtn", nrxy_froshtn.Text ,
                            "dana", dana.Text ,
                            "karton", karton.Text ,
                            "koy_dana" , koyDana ,
                            "barwary_kryn", Convert.ToDateTime(barwary_zyadkrdn_item.Text).ToString("yyyy-MM-dd") ,
                            "barwary_basarchwn", Convert.ToDateTime(barwary_basarchwn.Text).ToString("yyyy-MM-dd") ,
                            "user_id", user_id,
                            "kryn_id", id_kryn ,
                            "nrxy_kryn_j", nrxy_kryn_j.Text ,
                            "kode", kode_mada.Text ,
                            }); ;
                            int insert = db.nQuery("INSERT INTO item (barcode,name,type_id,nrxy_kryn,nrxy_froshtn,dana,karton,koy_dana,barwary_kryn,barwary_basarchwn,user_id,kryn_id,nrxy_kryn_j,kode) VALUES (@barcode,@name,@type_id,@nrxy_kryn,@nrxy_froshtn,@dana,@karton,@koy_dana,@barwary_kryn,@barwary_basarchwn,@user_id,@kryn_id,@nrxy_kryn_j,@kode)");

                            string id_item = db.single("select max(id) as id from item");
                            db.bind(new object[] {
                            "name", name_item.Text ,
                            "nrxy_kryn", nrxy_kryn.Text ,
                            "nrxy_kryn_j", nrxy_kryn_j.Text ,
                            "nrxy_froshtn", nrxy_froshtn.Text ,
                            "dana", dana.Text ,
                            "karton", karton.Text ,
                            "koy_dana" , koyDana ,
                            "barwary_kryn", Convert.ToDateTime(barwary_zyadkrdn_item.Text).ToString("yyyy-MM-dd") ,
                            "barwary_basarchwn", Convert.ToDateTime(barwary_basarchwn.Text).ToString("yyyy-MM-dd") ,
                            "user_id", user_id,
                            "kryn_id", id_kryn ,
                            "item_id", id_item
                            });
                            int insertA = db.nQuery("INSERT INTO itemAdd (name,nrxy_kryn,nrxy_kryn_j,nrxy_froshtn,dana,karton,koy_dana,barwary_kryn,barwary_basarchwn,user_id,kryn_id,item_id) VALUES (@name,@nrxy_kryn,@nrxy_kryn_j,@nrxy_froshtn,@dana,@karton,@koy_dana,@barwary_kryn,@barwary_basarchwn,@user_id,@kryn_id,@item_id)");
                            
                            MessageBox.Show("به‌سه‌ركه‌وتووی تۆماركرا");
                        }
                        barcode.Text = null;
                        kode_mada.Text = null;
                        name_item.Text = null;
                        nrxy_kryn.Text = null;
                        nrxy_kryn_j.Text = null;
                        nrxy_froshtn.Text = null;
                        dana.Text = null;
                        karton.Text = null;
                        koy_mada.Text = null;

                      
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

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            dataToComb1();
            dataToComb2();
            barwary_basarchwn.Text = DateTime.Now.ToString("yyyy-MM-dd");
            barwary_zyadkrdn_item.Text = DateTime.Now.ToString("yyyy-MM-dd");
            barwary_wasl.Text = DateTime.Now.ToString("yyyy-MM-dd");
            barwary_zyadkrdn.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void dana_TextChanged(object sender, EventArgs e)
        {
            int kartonM;
            int danaM;
            if (dana.Text == "")
            {
                danaM = 1;
            }
            else
            {
                danaM = Convert.ToInt32(dana.Text);
            }

            if (karton.Text == "")
            {
                kartonM = 1;
            }
            else
            {
                kartonM = Convert.ToInt32(karton.Text);
            }

            koy_mada.Text = (kartonM * danaM).ToString();
        }

        private void karton_TextChanged(object sender, EventArgs e)
        {
            int kartonM;
            int danaM;
            if (dana.Text == "")
            {
                danaM = 1;
            }
            else
            {
                danaM = Convert.ToInt32(dana.Text);
            }

            if (karton.Text == "")
            {
                kartonM = 1;
            }
            else
            {
                kartonM = Convert.ToInt32(karton.Text);
            }

            koy_mada.Text = (kartonM * danaM).ToString();
        }

        private void nrxy_froshtn_Enter(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo TypeOfLanguage = new System.Globalization.CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(TypeOfLanguage);
        }

        private void btn_updata_Click(object sender, EventArgs e)
        {

            int user_id = int.Parse(Properties.Settings.Default.id);
            try
            {
                if ( barcode.Text != "" && name_item.Text != ""
                    && barwary_basarchwn.Text != "" && barwary_zyadkrdn_item.Text != "" && nrxy_kryn.Text != "" && nrxy_froshtn.Text != ""
                    && karton.Text != "" && dana.Text != "")
                {
                    DialogResult dr = MessageBox.Show("ئه‌ته‌وێ وەسڵ  زیاد بکەی‌", "ئاگاداری", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        //a = a.Replace(",", "");
                        string item_karton = db.single("SELECT karton FROM item WHERE barcode = @barcode", new string[] { "barcode", barcode.Text });
                        string item_koyDana = db.single("SELECT koy_dana FROM item WHERE barcode = @barcode", new string[] { "barcode", barcode.Text });
                        string item_Dana = db.single("SELECT dana FROM item WHERE barcode = @barcode", new string[] { "barcode", barcode.Text });

                        if (item_karton == karton.Text)
                        {
                            int danaU = Convert.ToInt32(dana.Text) - Convert.ToInt32(item_Dana);
                            int koyDana = Convert.ToInt32(item_koyDana) + danaU;
                            string id_kryn = db.single("select max(id) as id from kryn");
                            db.bind(new object[] {
                                "id", id_item.Text ,
                                "name", name_item.Text ,
                                "nrxy_kryn", nrxy_kryn.Text.Replace(",", ""),
                                "nrxy_froshtn", nrxy_froshtn.Text.Replace(",", "") ,
                                "dana", dana.Text ,
                                "karton", karton.Text ,
                                "koy_dana" , koyDana ,
                                "barwary_kryn", barwary_zyadkrdn_item.Text ,
                                "barwary_basarchwn", barwary_basarchwn.Text ,
                                "user_id", user_id,
                                "kryn_id", id_kryn ,
                                "nrxy_kryn_j", nrxy_kryn_j.Text.Replace(",", "") ,
                                "kode", kode_mada.Text ,
                                });
                            int insert = db.nQuery("update item set name = @name ,nrxy_kryn = @nrxy_kryn ,nrxy_froshtn = @nrxy_froshtn ,dana = @dana ,karton = @karton ,koy_dana = @koy_dana,barwary_kryn = @barwary_kryn ,barwary_basarchwn = @barwary_basarchwn ,user_id = @user_id ,kryn_id = @kryn_id,nrxy_kryn_j = @nrxy_kryn_j, kode=@kode  where id=@id");

                            db.bind(new object[] {
                            "name", name_item.Text ,
                            "nrxy_kryn", nrxy_kryn.Text.Replace(",", "") ,
                            "nrxy_kryn_j", nrxy_kryn_j.Text.Replace(",", "") ,
                            "nrxy_froshtn", nrxy_froshtn.Text.Replace(",", "") ,
                            "dana", danaU ,
                            "karton", 1 ,
                            "koy_dana" , danaU ,
                            "barwary_kryn", barwary_zyadkrdn_item.Text ,
                            "barwary_basarchwn", barwary_basarchwn.Text ,
                            "user_id", user_id,
                            "kryn_id", id_kryn ,
                            "item_id", id_item.Text
                            });
                            int insertA = db.nQuery("INSERT INTO itemAdd (name,nrxy_kryn,nrxy_kryn_j,nrxy_froshtn,dana,karton,koy_dana,barwary_kryn,barwary_basarchwn,user_id,kryn_id,item_id) VALUES (@name,@nrxy_kryn,@nrxy_kryn_j,@nrxy_froshtn,@dana,@karton,@koy_dana,@barwary_kryn,@barwary_basarchwn,@user_id,@kryn_id,@item_id)");


                            MessageBox.Show("به‌سه‌ركه‌وتووی تۆماركرا");
                        }
                        else
                        {
                            if (Convert.ToInt32(item_karton) < Convert.ToInt32(karton.Text)) 
                            {
                                int kartonU = Convert.ToInt32(karton.Text) - Convert.ToInt32(item_karton);
                                int koyDana = Convert.ToInt32(item_koyDana) + (Convert.ToInt32(dana.Text) * kartonU);
                                string id_kryn = db.single("select max(id) as id from kryn");
                                db.bind(new object[] {
                                "id", id_item.Text ,
                                "name", name_item.Text ,
                                "nrxy_kryn", nrxy_kryn.Text.Replace(",", ""),
                                "nrxy_froshtn", nrxy_froshtn.Text.Replace(",", "") ,
                                "dana", dana.Text ,
                                "karton", karton.Text ,
                                "koy_dana" , koyDana ,
                                "barwary_kryn", barwary_zyadkrdn_item.Text ,
                                "barwary_basarchwn", barwary_basarchwn.Text ,
                                "user_id", user_id,
                                "kryn_id", id_kryn ,
                                "nrxy_kryn_j", nrxy_kryn_j.Text.Replace(",", "") ,
                                "kode", kode_mada.Text ,
                                });
                                int insert = db.nQuery("update item set name = @name ,nrxy_kryn = @nrxy_kryn ,nrxy_froshtn = @nrxy_froshtn ,dana = @dana ,karton = @karton ,koy_dana = @koy_dana,barwary_kryn = @barwary_kryn ,barwary_basarchwn = @barwary_basarchwn ,user_id = @user_id ,kryn_id = @kryn_id,nrxy_kryn_j = @nrxy_kryn_j, kode=@kode  where id=@id");

                                db.bind(new object[] {
                                "name", name_item.Text ,
                                "nrxy_kryn", nrxy_kryn.Text.Replace(",", "") ,
                                "nrxy_froshtn", nrxy_froshtn.Text.Replace(",", "") ,
                                "dana", dana.Text ,
                                "karton", kartonU ,
                                "koy_dana" , (Convert.ToInt32(dana.Text) * kartonU) ,
                                "barwary_kryn", barwary_zyadkrdn_item.Text ,
                                "barwary_basarchwn", barwary_basarchwn.Text ,
                                "user_id", user_id,
                                "kryn_id", id_kryn ,
                                "item_id", id_item.Text
                                });
                                int insertA = db.nQuery("INSERT INTO itemAdd (name,nrxy_kryn,nrxy_froshtn,dana,karton,koy_dana,barwary_kryn,barwary_basarchwn,user_id,kryn_id,item_id) VALUES (@name,@nrxy_kryn,@nrxy_froshtn,@dana,@karton,@koy_dana,@barwary_kryn,@barwary_basarchwn,@user_id,@kryn_id,@item_id)");



                                MessageBox.Show("به‌سه‌ركه‌وتووی تۆماركرا");
                            }
 
                        }
                        
                        

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

        private void barcode_TextChanged(object sender, EventArgs e)
        {
            string[] data = db.row("SELECT * FROM item WHERE barcode = @barcode", new string[] { "barcode", barcode.Text });
            if (data[0] != "")
            {
                string d1 = Convert.ToDateTime(data[10]).ToString();
                string d2 = Convert.ToDateTime(data[9]).ToString();

                id_item.Text = data[0];
                name_item.Text = data[2];
                if (data[14] != null)
                {
                    kode_mada.Text = data[14];
                }
                else
                {
                    kode_mada.Text = kode_mada.Text;
                }
                ComboBox2.SelectedValue = data[3]?? "0";
                if (d1 != "1/1/0001 12:00:00 AM" || d2 != "1/1/0001 12:00:00 AM")
                {
                    barwary_basarchwn.Value = Convert.ToDateTime(data[10]);
                    barwary_zyadkrdn_item.Value = Convert.ToDateTime(data[9]);
                }
               
                nrxy_kryn.Text = data[4];
                nrxy_kryn_j.Text = data[13];
                nrxy_froshtn.Text = data[5];
                dana.Text = data[6];
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            frmCompany f = new frmCompany();
            f.ShowDialog();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            frmType f = new frmType();
            f.ShowDialog();
        }

        private void kode_mada_TextChanged(object sender, EventArgs e)
        {
            string[] data = db.row("SELECT * FROM item WHERE kode = @barcode", new string[] { "barcode", kode_mada.Text });
            if (data[0] != "")
            {
                string d1 = Convert.ToDateTime(data[10]).ToString();
                string d2 = Convert.ToDateTime(data[9]).ToString();

                id_item.Text = data[0];
                name_item.Text = data[2];
                if (data[1] != null)
                {
                    barcode.Text = data[1];
                }
                else
                {
                    barcode.Text = barcode.Text;
                }
                
                ComboBox2.SelectedValue = data[3] ?? "0";
                if (d1 != "1/1/0001 12:00:00 AM" || d2 != "1/1/0001 12:00:00 AM")
                {
                    barwary_basarchwn.Value = Convert.ToDateTime(data[10]);
                    barwary_zyadkrdn_item.Value = Convert.ToDateTime(data[9]);
                }

                nrxy_kryn.Text = data[4];
                nrxy_kryn_j.Text = data[13];
                nrxy_froshtn.Text = data[5];
                dana.Text = data[6];
            }
        }

        private void ComboBox2_Click(object sender, EventArgs e)
        {
            dataToComb2();
        }

        private void ComboBox1_Click(object sender, EventArgs e)
        {
            dataToComb1();
        }
    }
}
