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
    public partial class frmFroshraw_rp : Form
    {
        Db db = new Db();
        public frmFroshraw_rp()
        {
            InitializeComponent();
        }
        private void showReport()
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptFroshraw.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", db.query("SELECT froshtn.id, froshtn.wasl, item.barcode, item.name, froshtn.nrxy_froshtn, froshtn.barwary_froshtn, froshtn.dana, froshtn.karton, froshtn.dashkan, kryar.name AS nameK, froshtn_ba_qarz.bry_qarz, froshtn_ba_qarz.bry_para,  (froshtn.nrxy_froshtn - item.nrxy_kryn) * froshtn.dana AS qazangDana, (froshtn.nrxy_froshtn - item.nrxy_kryn) * froshtn.karton AS qazangKelo, (froshtn.nrxy_froshtn - item.nrxy_kryn)  * froshtn.dana + (froshtn.nrxy_froshtn - item.nrxy_kryn) * froshtn.karton AS qazang, kryar.shwen, kryar.mobile " +
                "FROM item INNER JOIN froshtn ON item.id = froshtn.item_id INNER JOIN froshtn_ba_qarz ON froshtn.froshtn_ba_qarz_id = froshtn_ba_qarz.id INNER JOIN   kryar ON froshtn_ba_qarz.kryar_id = kryar.id ")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }
        void dataToComb2()
        {

            ComboBox1.DisplayMember = "name";
            ComboBox1.ValueMember = "id";
            ComboBox1.DataSource = db.query("select id,name from kryar order by id");

        }
        private void frmFroshraw_rp_Load(object sender, EventArgs e)
        {
            showReport();
            dataToComb2();
            DateStart.Text = DateTime.Now.ToString("yyyy-MM-dd");
            DateEnd.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox2.SelectedItem == "قه‌رز")
            {
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptFroshraw.rdlc";
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", db.query("SELECT froshtn.id, froshtn.wasl, item.barcode, item.name, froshtn.nrxy_froshtn, froshtn.barwary_froshtn, froshtn.dana, froshtn.karton, froshtn.dashkan, kryar.name AS nameK, froshtn_ba_qarz.bry_qarz, froshtn_ba_qarz.bry_para,  (froshtn.nrxy_froshtn - item.nrxy_kryn) * froshtn.dana AS qazangDana, (froshtn.nrxy_froshtn - item.nrxy_kryn) * froshtn.karton AS qazangKelo, (froshtn.nrxy_froshtn - item.nrxy_kryn)  * froshtn.dana + (froshtn.nrxy_froshtn - item.nrxy_kryn) * froshtn.karton AS qazang, kryar.shwen, kryar.mobile " +
                "FROM item INNER JOIN froshtn ON item.id = froshtn.item_id INNER JOIN froshtn_ba_qarz ON froshtn.froshtn_ba_qarz_id = froshtn_ba_qarz.id INNER JOIN   kryar ON froshtn_ba_qarz.kryar_id = kryar.id where froshtn_ba_qarz.bry_qarz > 0")));
                reportViewer1.RefreshReport();
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            }
            else if (guna2ComboBox2.SelectedItem == "نه‌قد")
            {
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptFroshraw.rdlc";
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", db.query("SELECT froshtn.id, froshtn.wasl, item.barcode, item.name, froshtn.nrxy_froshtn, froshtn.barwary_froshtn, froshtn.dana, froshtn.karton, froshtn.dashkan, kryar.name AS nameK, froshtn_ba_qarz.bry_qarz, froshtn_ba_qarz.bry_para,  (froshtn.nrxy_froshtn - item.nrxy_kryn) * froshtn.dana AS qazangDana, (froshtn.nrxy_froshtn - item.nrxy_kryn) * froshtn.karton AS qazangKelo, (froshtn.nrxy_froshtn - item.nrxy_kryn)  * froshtn.dana + (froshtn.nrxy_froshtn - item.nrxy_kryn) * froshtn.karton AS qazang, kryar.shwen, kryar.mobile " +
                "FROM item INNER JOIN froshtn ON item.id = froshtn.item_id INNER JOIN froshtn_ba_qarz ON froshtn.froshtn_ba_qarz_id = froshtn_ba_qarz.id INNER JOIN   kryar ON froshtn_ba_qarz.kryar_id = kryar.id where froshtn_ba_qarz.bry_para > 0")));
                reportViewer1.RefreshReport();
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            }
            else
            {
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptFroshraw.rdlc";
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", db.query("SELECT froshtn.id, froshtn.wasl, item.barcode, item.name, froshtn.nrxy_froshtn, froshtn.barwary_froshtn, froshtn.dana, froshtn.karton, froshtn.dashkan, kryar.name AS nameK, froshtn_ba_qarz.bry_qarz, froshtn_ba_qarz.bry_para,  (froshtn.nrxy_froshtn - item.nrxy_kryn) * froshtn.dana AS qazangDana, (froshtn.nrxy_froshtn - item.nrxy_kryn) * froshtn.karton AS qazangKelo, (froshtn.nrxy_froshtn - item.nrxy_kryn)  * froshtn.dana + (froshtn.nrxy_froshtn - item.nrxy_kryn) * froshtn.karton AS qazang, kryar.shwen, kryar.mobile " +
                "FROM item INNER JOIN froshtn ON item.id = froshtn.item_id INNER JOIN froshtn_ba_qarz ON froshtn.froshtn_ba_qarz_id = froshtn_ba_qarz.id INNER JOIN   kryar ON froshtn_ba_qarz.kryar_id = kryar.id where froshtn.dashkan > 0")));
                reportViewer1.RefreshReport();
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptFroshraw.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", db.query("SELECT froshtn.id, froshtn.wasl, item.barcode, item.name, froshtn.nrxy_froshtn, froshtn.barwary_froshtn, froshtn.dana, froshtn.karton, froshtn.dashkan, kryar.name AS nameK, froshtn_ba_qarz.bry_qarz, froshtn_ba_qarz.bry_para,  (froshtn.nrxy_froshtn - item.nrxy_kryn) * froshtn.dana AS qazangDana, (froshtn.nrxy_froshtn - item.nrxy_kryn) * froshtn.karton AS qazangKelo, (froshtn.nrxy_froshtn - item.nrxy_kryn)  * froshtn.dana + (froshtn.nrxy_froshtn - item.nrxy_kryn) * froshtn.karton AS qazang, kryar.shwen, kryar.mobile " +
                "FROM item INNER JOIN froshtn ON item.id = froshtn.item_id INNER JOIN froshtn_ba_qarz ON froshtn.froshtn_ba_qarz_id = froshtn_ba_qarz.id INNER JOIN   kryar ON froshtn_ba_qarz.kryar_id = kryar.id where froshtn.barwary_froshtn between '" + DateStart.Value.ToString("yyyy-MM-dd").Trim() + "' and '" + DateEnd.Value.ToString("yyyy-MM-dd").Trim() + "'")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }

        private void txt_serch_TextChanged(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptFroshraw.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", db.query("SELECT froshtn.id, froshtn.wasl, item.barcode, item.name, froshtn.nrxy_froshtn, froshtn.barwary_froshtn, froshtn.dana, froshtn.karton, froshtn.dashkan, kryar.name AS nameK, froshtn_ba_qarz.bry_qarz, froshtn_ba_qarz.bry_para,  (froshtn.nrxy_froshtn - item.nrxy_kryn) * froshtn.dana AS qazangDana, (froshtn.nrxy_froshtn - item.nrxy_kryn) * froshtn.karton AS qazangKelo, (froshtn.nrxy_froshtn - item.nrxy_kryn)  * froshtn.dana + (froshtn.nrxy_froshtn - item.nrxy_kryn) * froshtn.karton AS qazang, kryar.shwen, kryar.mobile " +
                "FROM item INNER JOIN froshtn ON item.id = froshtn.item_id INNER JOIN froshtn_ba_qarz ON froshtn.froshtn_ba_qarz_id = froshtn_ba_qarz.id INNER JOIN   kryar ON froshtn_ba_qarz.kryar_id = kryar.id where froshtn.wasl = '" + txt_serch.Text + "'")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptFroshraw.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", db.query("SELECT froshtn.id, froshtn.wasl, item.barcode, item.name, froshtn.nrxy_froshtn, froshtn.barwary_froshtn, froshtn.dana, froshtn.karton, froshtn.dashkan, kryar.name AS nameK, froshtn_ba_qarz.bry_qarz,  froshtn_ba_qarz.bry_para, (froshtn.nrxy_froshtn - item.nrxy_kryn) * froshtn.dana AS qazangDana, (froshtn.nrxy_froshtn - item.nrxy_kryn) * froshtn.karton AS qazangKelo,(((froshtn.nrxy_froshtn - item.nrxy_kryn) * froshtn.dana) + ((froshtn.nrxy_froshtn - item.nrxy_kryn) * froshtn.karton)) as qazang, kryar.shwen, kryar.mobile " +
                "FROM  users INNER JOIN (item INNER JOIN ((kryar INNER JOIN froshtn_ba_qarz ON kryar.id = froshtn_ba_qarz.kryar_id) INNER JOIN froshtn ON froshtn_ba_qarz.id = froshtn.froshtn_ba_qarz_id) ON item.id = froshtn.item_id) ON users.id = froshtn.user_id  where kryar.name = '" + ComboBox1.Text + "'")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptFroshraw.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", db.query("SELECT froshtn.id, froshtn.wasl, item.barcode, item.name, froshtn.nrxy_froshtn, froshtn.barwary_froshtn, froshtn.dana, froshtn.karton, froshtn.dashkan, kryar.name AS nameK, froshtn_ba_qarz.bry_qarz,  froshtn_ba_qarz.bry_para, (froshtn.nrxy_froshtn - item.nrxy_kryn) * froshtn.dana AS qazangDana, (froshtn.nrxy_froshtn - item.nrxy_kryn) * froshtn.karton AS qazangKelo,(((froshtn.nrxy_froshtn - item.nrxy_kryn) * froshtn.dana) + ((froshtn.nrxy_froshtn - item.nrxy_kryn) * froshtn.karton)) as qazang, kryar.shwen, kryar.mobile " +
                "FROM  users INNER JOIN (item INNER JOIN ((kryar INNER JOIN froshtn_ba_qarz ON kryar.id = froshtn_ba_qarz.kryar_id) INNER JOIN froshtn ON froshtn_ba_qarz.id = froshtn.froshtn_ba_qarz_id) ON item.id = froshtn.item_id) ON users.id = froshtn.user_id  where kryar.name = '" + ComboBox1.Text + "' AND froshtn.barwary_froshtn between '" + DateStart.Value.ToString("yyyy-MM-dd").Trim() + "' and '" + DateEnd.Value.ToString("yyyy-MM-dd").Trim() + "'")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }
    }
}
