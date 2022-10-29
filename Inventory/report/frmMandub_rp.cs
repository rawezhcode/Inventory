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
    public partial class frmMandub_rp : Form
    {
        Db db = new Db();
        public frmMandub_rp()
        {
            InitializeComponent();
        }
        private void showReport()
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptMandub.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetMandub", db.query("SELECT  froshtn.id, froshtn.froshtn_ba_qarz_id, froshtn.wasl, froshtn.nrxy_froshtn, froshtn.barwary_froshtn, froshtn.dana, froshtn.karton, froshtn.mandub_id, mandub.name, item.barcode, item.name AS mada_name,  froshtn.dashkan FROM froshtn INNER JOIN mandub ON froshtn.mandub_id = mandub.id INNER JOIN item ON froshtn.item_id = item.id ")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }
        void dataToComb3()
        {

            ComboBox1.DisplayMember = "name";
            ComboBox1.ValueMember = "id";
            ComboBox1.DataSource = db.query("select id,name from mandub order by id");

        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptMandub.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetMandub", db.query("SELECT  froshtn.id, froshtn.froshtn_ba_qarz_id, froshtn.wasl, froshtn.nrxy_froshtn, froshtn.barwary_froshtn, froshtn.dana, froshtn.karton, froshtn.mandub_id, mandub.name, item.barcode, item.name AS mada_name,  froshtn.dashkan FROM froshtn INNER JOIN mandub ON froshtn.mandub_id = mandub.id INNER JOIN item ON froshtn.item_id = item.id where mandub.name = '"+ComboBox1.Text+"' ")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }

        private void frmMandub_rp_Load(object sender, EventArgs e)
        {
            showReport();
            dataToComb3();
            DateStart.Text = DateTime.Now.ToString("yyyy-MM-dd");
            DateEnd.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptMandub.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetMandub", db.query("SELECT  froshtn.id, froshtn.froshtn_ba_qarz_id, froshtn.wasl, froshtn.nrxy_froshtn, froshtn.barwary_froshtn, froshtn.dana, froshtn.karton, froshtn.mandub_id, mandub.name, item.barcode, item.name AS mada_name,  froshtn.dashkan FROM froshtn INNER JOIN mandub ON froshtn.mandub_id = mandub.id INNER JOIN item ON froshtn.item_id = item.id where mandub.name = '" + ComboBox1.Text + "' AND froshtn.barwary_froshtn between '" + DateStart.Value.ToString("yyyy-MM-dd").Trim() + "' and '" + DateEnd.Value.ToString("yyyy-MM-dd").Trim() + "' ")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptMandub.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetMandub", db.query("SELECT  froshtn.id, froshtn.froshtn_ba_qarz_id, froshtn.wasl, froshtn.nrxy_froshtn, froshtn.barwary_froshtn, froshtn.dana, froshtn.karton, froshtn.mandub_id, mandub.name, item.barcode, item.name AS mada_name,  froshtn.dashkan FROM froshtn INNER JOIN mandub ON froshtn.mandub_id = mandub.id INNER JOIN item ON froshtn.item_id = item.id where froshtn.barwary_froshtn between '" + DateStart.Value.ToString("yyyy-MM-dd").Trim() + "' and '" + DateEnd.Value.ToString("yyyy-MM-dd").Trim() + "' ")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }
    }
}
