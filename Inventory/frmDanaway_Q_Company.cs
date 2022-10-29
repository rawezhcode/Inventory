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
    public partial class frmDanaway_Q_Company : Form
    {
        Db db = new Db();
        public frmDanaway_Q_Company()
        {
            InitializeComponent();
        }
        void dataToComb2()
        {
            ComboBox1.DisplayMember = "name";
            ComboBox1.ValueMember = "id";
            ComboBox1.DataSource = db.query("select id,name from company order by id");
        }

        private void frmDanaway_Q_Company_Load(object sender, EventArgs e)
        {
            dataToComb2();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] data = db.row("SELECT * FROM company WHERE id = @id", new string[] { "id", ComboBox1.SelectedValue.ToString() });
            txt_qarz.Text = data[5];
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
                string company_id = ComboBox1.SelectedValue.ToString();

                string bry_para_k = db.single("SELECT bry_para FROM company WHERE id = @id", new string[] { "id", company_id });
                string bry_qarz_k = db.single("SELECT bry_qarz FROM company WHERE id = @id", new string[] { "id", company_id });
                db.bind(new object[] {
                                        "bry_para" , int.Parse(txt_nrx.Text) + int.Parse(bry_para_k),
                                        "bry_qarz" , Math.Abs(int.Parse(bry_qarz_k) - int.Parse(txt_nrx.Text) ),
                            });
                int update_kryar = db.nQuery("update company set bry_qarz=@bry_qarz where id = @id", new string[] { "id", company_id });
                //

                db.bind(new object[] {
                            "bry_para" , int.Parse(txt_nrx.Text) ,
                            "barwar" ,  DateTime.Now.ToString("yyyy-MM-dd") ,
                            "company_id" , company_id,
                        });
                int insert_f_b_n = db.nQuery("INSERT INTO danaway_qarz_company(bry_para, barwar,company_id) VALUES " +
                "(@bry_para, @barwar, @company_id)");

                MessageBox.Show("بەسەرکەوتووی تۆمارکرا");

                string[] data = db.row("SELECT * FROM company WHERE id = @id", new string[] { "id", ComboBox1.SelectedValue.ToString() });
                txt_qarz.Text = data[5];
            }
        }
    }
}
