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
    public partial class frmKryarWasl_rpt : Form
    {
        Db db = new Db();
        public frmKryarWasl_rpt()
        {
            InitializeComponent();
        }
        void dataToComb3()
        {

            ComboBox1.DisplayMember = "name";
            ComboBox1.ValueMember = "id";
            ComboBox1.DataSource = db.query("select id,name from kryar order by id");

        }
        private void frmKryarWasl_rpt_Load(object sender, EventArgs e)
        {
            showReport();
            dataToComb3();
            DateStart.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void showReport()
        {


            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptKryarWasl.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetKryarWasl", db.query("SELECT name, shwen, mobile, mandub_id, danaway_qarz_kryar.bry_para, bry_qarz, bry_qarzy_nwe ,danaway_qarz_kryar.barwar FROM kryar left join danaway_qarz_kryar on kryar.id = danaway_qarz_kryar.kryar_id  where kryar.name = '" + ComboBox1.Text+ "'  ")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptKryarWasl.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetKryarWasl", db.query("SELECT name, shwen, mobile, mandub_id, danaway_qarz_kryar.bry_para, bry_qarz, bry_qarzy_nwe ,danaway_qarz_kryar.barwar FROM kryar left join danaway_qarz_kryar on kryar.id = danaway_qarz_kryar.kryar_id  where kryar.name = '" + ComboBox1.Text + "'  ")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptKryarWasl.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetKryarWasl", db.query("SELECT name, shwen, mobile, mandub_id, danaway_qarz_kryar.bry_para, bry_qarz, bry_qarzy_nwe ,danaway_qarz_kryar.barwar FROM kryar left join danaway_qarz_kryar on kryar.id = danaway_qarz_kryar.kryar_id ")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptKryarWasl.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetKryarWasl", db.query("SELECT name, shwen, mobile, mandub_id, danaway_qarz_kryar.bry_para, bry_qarz, bry_qarzy_nwe ,danaway_qarz_kryar.barwar FROM kryar left join danaway_qarz_kryar on kryar.id = danaway_qarz_kryar.kryar_id  where danaway_qarz_kryar.barwar  = '" + DateStart.Value.ToString("yyyy-MM-dd").Trim() + "'")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptKryarWasl.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetKryarWasl", db.query("SELECT name, shwen, mobile, mandub_id, danaway_qarz_kryar.bry_para, bry_qarz, bry_qarzy_nwe ,danaway_qarz_kryar.barwar FROM kryar left join danaway_qarz_kryar on kryar.id = danaway_qarz_kryar.kryar_id where kryar.name = '" + ComboBox1.Text + "' and danaway_qarz_kryar.barwar  = '" + DateStart.Value.ToString("yyyy-MM-dd").Trim() + "'")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }
    }
}
