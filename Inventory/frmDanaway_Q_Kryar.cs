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
    public partial class frmDanaway_Q_Kryar : Form
    {
        Db db = new Db();
        public frmDanaway_Q_Kryar()
        {
            InitializeComponent();
        }
        void dataToComb3()
        {

            ComboBox1.DisplayMember = "name";
            ComboBox1.ValueMember = "id";
            ComboBox1.DataSource = db.query("select id,name from kryar order by id");

        }
        private void frmDanaway_Q_Kryar_Load(object sender, EventArgs e)
        {
            dataToComb3();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] data = db.row("SELECT * FROM kryar WHERE id = @id", new string[] { "id", ComboBox1.SelectedValue.ToString() });
            txt_qarz.Text = data[6];
            
        }

        private void txt_nrx_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(txt_nrx.Text) > int.Parse(txt_qarz.Text))
            {
                MessageBox.Show("بری پارە زیاترە لە قەرزی کۆن");
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (int.Parse(txt_nrx.Text) > int.Parse(txt_qarz.Text))
            {
                MessageBox.Show("بری پارە زیاترە لە قەرزی کۆن");
            }
            else
            {
                string kryar_id = ComboBox1.SelectedValue.ToString();

                string bry_para_k = db.single("SELECT bry_para FROM kryar WHERE id = @id", new string[] { "id", kryar_id });
                string bry_qarz_k = db.single("SELECT bry_qarz FROM kryar WHERE id = @id", new string[] { "id", kryar_id });
                db.bind(new object[] {
                                        "bry_para" , int.Parse(txt_nrx.Text) + int.Parse(bry_para_k),
                                        "bry_qarz" , Math.Abs(int.Parse(bry_qarz_k) - int.Parse(txt_nrx.Text) ),
                            });
                int update_kryar = db.nQuery("update kryar set bry_qarz=@bry_qarz where id = @id", new string[] { "id", kryar_id });
                //

                db.bind(new object[] {
                            "bry_para" , int.Parse(txt_nrx.Text) ,
                            "barwar" ,  DateTime.Now.ToString("yyyy-MM-dd") ,
                            "kryar_id" , kryar_id,
                        });
                int insert_f_b_n = db.nQuery("INSERT INTO danaway_qarz_kryar(bry_para, barwar,kryar_id) VALUES " +
                "(@bry_para, @barwar, @kryar_id)");

                MessageBox.Show("بەسەرکەوتووی تۆمارکرا");

                string[] data = db.row("SELECT * FROM kryar WHERE id = @id", new string[] { "id", ComboBox1.SelectedValue.ToString() });
                txt_qarz.Text = data[6];
            }
               
        }
    }
}
