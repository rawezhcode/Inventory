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
    public partial class frmFroshyar_rpt : Form
    {
        Db db = new Db();
        public frmFroshyar_rpt()
        {
            InitializeComponent();
        }
        void dataToComb2()
        {
            ComboBox1.DisplayMember = "name";
            ComboBox1.ValueMember = "id";
            ComboBox1.DataSource = db.query("select id,name from company order by id");
        }
        private void showReport()
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rpt_Froshyar.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetFroshyar", db.query("SELECT  company.id, company.name, company.bry_qarz, company.mobile, company.shwen, danaway_qarz_company.bry_para , danaway_qarz_company.barwar FROM  company left JOIN danaway_qarz_company ON company.id = danaway_qarz_company.company_id ")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }
        private void frmFroshyar_rpt_Load(object sender, EventArgs e)
        {
            showReport();
            dataToComb2();
            DateStart.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rpt_Froshyar.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetFroshyar", db.query("SELECT  company.id, company.name, company.bry_qarz, company.mobile, company.shwen, danaway_qarz_company.bry_para , danaway_qarz_company.barwar FROM  company left JOIN danaway_qarz_company ON company.id = danaway_qarz_company.company_id  where name = '" + ComboBox1.Text+ "' and danaway_qarz_company.barwar  = '" + DateStart.Value.ToString("yyyy-MM-dd").Trim() + "' ")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rpt_Froshyar.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetFroshyar", db.query("SELECT  company.id, company.name, company.bry_qarz, company.mobile, company.shwen, danaway_qarz_company.bry_para , danaway_qarz_company.barwar FROM  company left JOIN danaway_qarz_company ON company.id = danaway_qarz_company.company_id  where name = '" + ComboBox1.Text + "' and danaway_qarz_company.barwar  = '" + DateStart.Value.ToString("yyyy-MM-dd").Trim() + "' ")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rpt_Froshyar.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetFroshyar", db.query("SELECT  company.id, company.name, company.bry_qarz, company.mobile, company.shwen, danaway_qarz_company.bry_para , danaway_qarz_company.barwar FROM  company left JOIN danaway_qarz_company ON company.id = danaway_qarz_company.company_id  where  danaway_qarz_company.barwar  = '" + DateStart.Value.ToString("yyyy-MM-dd").Trim() + "' ")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }
    }
}
