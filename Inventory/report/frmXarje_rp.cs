using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.report
{
    public partial class frmXarje_rp : Form
    {
        Db db = new Db();
        public frmXarje_rp()
        {
            InitializeComponent();
        }
        void dataToComb1()
        {
            ComboBox1.DisplayMember = "name";
            ComboBox1.ValueMember = "id";
            ComboBox1.DataSource = db.query("select id,name from type_xarje order by id");
        }

        private void frmXarje_rp_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptXarje.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetXarje", db.query("SELECT xarjeakan.id ,type_Xarje.name,bry_xarje ,barwar , users.full_name FROM type_xarje inner join xarjeakan on xarjeakan.type_Xarje_id = type_Xarje.id inner join users on xarjeakan.user_id = users.id ")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            dataToComb1();
            DateStart.Text = DateTime.Now.ToString("yyyy-MM-dd");
            DateEnd.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptXarje.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetXarje", db.query("SELECT xarjeakan.id ,type_Xarje.name,bry_xarje ,barwar , users.full_name FROM type_xarje inner join xarjeakan on xarjeakan.type_Xarje_id = type_Xarje.id inner join users on xarjeakan.user_id = users.id where barwar between '" + DateStart.Value.ToString("yyyy-MM-dd").Trim() + "' and '" + DateEnd.Value.ToString("yyyy-MM-dd").Trim() + "'")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptXarje.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetXarje", db.query("SELECT xarjeakan.id ,type_Xarje.name,bry_xarje ,barwar , users.full_name FROM type_xarje inner join xarjeakan on xarjeakan.type_Xarje_id = type_Xarje.id inner join users on xarjeakan.user_id = users.id where type_Xarje.name = '" + ComboBox1.Text + "' AND barwar between '" + DateStart.Value.ToString("yyyy-MM-dd").Trim() + "' and '" + DateEnd.Value.ToString("yyyy-MM-dd").Trim() + "'")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptXarje.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetXarje", db.query("SELECT xarjeakan.id ,type_Xarje.name,bry_xarje ,barwar , users.full_name FROM type_xarje inner join xarjeakan on xarjeakan.type_Xarje_id = type_Xarje.id inner join users on xarjeakan.user_id = users.id where type_Xarje.name = '"+ComboBox1.Text+"' ")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }
    }
}
