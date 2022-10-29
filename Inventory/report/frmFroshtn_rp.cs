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
    public partial class frmFroshtn_rp : Form
    {
        Db db = new Db();
        public frmFroshtn_rp()
        {
            InitializeComponent();
        }
       

        private void showReport()
        {

            string name_kryar = db.single("SELECT kryar.name AS nameK FROM kryar inner join froshtn_ba_qarz on kryar.id = froshtn_ba_qarz.kryar_id  inner join froshtn  on froshtn_ba_qarz.id = froshtn.froshtn_ba_qarz_id INNER JOIN item ON froshtn.item_id = item.id where wasl =  (select MAX(wasl)from froshtn ) ");

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptFroshtn.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetFroshtn", db.query("SELECT froshtn.id, froshtn.item_id, froshtn.froshtn_ba_qarz_id, froshtn.wasl, froshtn.nrxy_froshtn, froshtn.barwary_froshtn, froshtn.dana, froshtn.karton, froshtn.dashkan, froshtn.mawa, item.name, item.barcode, froshtn_ba_qarz.bry_para, froshtn_ba_qarz.bry_qarz, kryar.name AS nameK , kryar.mobile, kryar.shwen  " +
                "FROM kryar inner join froshtn_ba_qarz on kryar.id = froshtn_ba_qarz.kryar_id  inner join froshtn  on froshtn_ba_qarz.id = froshtn.froshtn_ba_qarz_id INNER JOIN item ON froshtn.item_id = item.id where wasl =  (select MAX(wasl)from froshtn ) ")));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetKryar", db.query("SELECT  kryar.id, kryar.name, kryar.shwen, kryar.mobile, kryar.mandub_id, froshtn_ba_qarz.bry_qarz, froshtn_ba_qarz.bry_para FROM kryar INNER JOIN froshtn_ba_qarz ON kryar.id = froshtn_ba_qarz.kryar_id where kryar.name = '"+ name_kryar + "'")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }
        private void frmFroshtn_rp_Load(object sender, EventArgs e)
        {
            showReport();
            //this.reportViewer1.RefreshReport();
            DateStart.Text = DateTime.Now.ToString("yyyy-MM-dd");
            DateEnd.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptFroshtn.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetFroshtn", db.query("SELECT froshtn.id, froshtn.item_id, froshtn.froshtn_ba_qarz_id, froshtn.wasl, froshtn.nrxy_froshtn, froshtn.barwary_froshtn, froshtn.dana, froshtn.karton, froshtn.dashkan, froshtn.mawa, item.name, item.barcode, froshtn_ba_qarz.bry_para, froshtn_ba_qarz.bry_qarz, kryar.name AS nameK , kryar.mobile, kryar.shwen  " +
                "FROM kryar inner join froshtn_ba_qarz on kryar.id = froshtn_ba_qarz.kryar_id  inner join froshtn  on froshtn_ba_qarz.id = froshtn.froshtn_ba_qarz_id INNER JOIN item ON froshtn.item_id = item.id where froshtn.barwary_froshtn between '" + DateStart.Value.ToString("yyyy-MM-dd").Trim() + "' and '" + DateEnd.Value.ToString("yyyy-MM-dd").Trim() + "'")));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetKryar", db.query("SELECT  kryar.id, kryar.name, kryar.shwen, kryar.mobile, kryar.mandub_id, froshtn_ba_qarz.bry_qarz, froshtn_ba_qarz.bry_para FROM kryar INNER JOIN froshtn_ba_qarz ON kryar.id = froshtn_ba_qarz.kryar_id")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }

        private void txt_serch_TextChanged(object sender, EventArgs e)
        {
            string name_kryar = db.single("SELECT kryar.name AS nameK FROM kryar inner join froshtn_ba_qarz on kryar.id = froshtn_ba_qarz.kryar_id  inner join froshtn  on froshtn_ba_qarz.id = froshtn.froshtn_ba_qarz_id INNER JOIN item ON froshtn.item_id = item.id where wasl = '" + txt_serch.Text + "' ");

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptFroshtn.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetFroshtn", db.query("SELECT froshtn.id, froshtn.item_id, froshtn.froshtn_ba_qarz_id, froshtn.wasl, froshtn.nrxy_froshtn, froshtn.barwary_froshtn, froshtn.dana, froshtn.karton, froshtn.dashkan, froshtn.mawa, item.name, item.barcode, froshtn_ba_qarz.bry_para, froshtn_ba_qarz.bry_qarz, kryar.name AS nameK , kryar.mobile, kryar.shwen  " +
                "FROM kryar inner join froshtn_ba_qarz on kryar.id = froshtn_ba_qarz.kryar_id  inner join froshtn  on froshtn_ba_qarz.id = froshtn.froshtn_ba_qarz_id INNER JOIN item ON froshtn.item_id = item.id where wasl = '" + txt_serch.Text+"' ")));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetKryar", db.query("SELECT  kryar.id, kryar.name, kryar.shwen, kryar.mobile, kryar.mandub_id, froshtn_ba_qarz.bry_qarz, froshtn_ba_qarz.bry_para FROM kryar INNER JOIN froshtn_ba_qarz ON kryar.id = froshtn_ba_qarz.kryar_id where kryar.name = '" + name_kryar + "'")));

            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }
    }
}

