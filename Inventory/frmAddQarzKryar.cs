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
    public partial class frmAddQarzKryar : Form
    {
        Db db = new Db();
        public frmAddQarzKryar()
        {
            InitializeComponent();
        }
        void dataToComb3()
        {

            ComboBox1.DisplayMember = "name";
            ComboBox1.ValueMember = "id";
            ComboBox1.DataSource = db.query("select id,name from kryar order by id");

        }
        private void frmAddQarzKryar_Load(object sender, EventArgs e)
        {
            dataToComb3();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] data = db.row("SELECT * FROM kryar WHERE id = @id", new string[] { "id", ComboBox1.SelectedValue.ToString() });
            txt_qarz.Text = data[6];
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {

            string kryar_id = ComboBox1.SelectedValue.ToString();

            string bry_qarz_k = db.single("SELECT bry_qarz FROM kryar WHERE id = @id", new string[] { "id", kryar_id });
            db.bind(new object[] {
                                  "bry_qarz" , Math.Abs(int.Parse(bry_qarz_k) + int.Parse(txt_nrx.Text) ),
                            });
            int update_kryar = db.nQuery("update kryar set bry_qarz=@bry_qarz where id = @id", new string[] { "id", kryar_id });
            //

            MessageBox.Show("بەسەرکەوتووی تۆمارکرا");

            string[] data = db.row("SELECT * FROM kryar WHERE id = @id", new string[] { "id", ComboBox1.SelectedValue.ToString() });
            txt_qarz.Text = data[6];
        }
    }
}
