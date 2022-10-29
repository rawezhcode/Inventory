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
    public partial class frmKryar_rpt : Form
    {
        Db db = new Db();
        public frmKryar_rpt()
        {
            InitializeComponent();
        }
        void dataToComb3()
        {

            ComboBox1.DisplayMember = "name";
            ComboBox1.ValueMember = "id";
            ComboBox1.DataSource = db.query("select id,name from kryar order by id");

        }
        private void showReport()
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptKryar.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetAllKryar", db.query("SELECT kryar.name ,froshtn.wasl,froshtn.barwary_froshtn,froshtn_ba_qarz.bry_para,froshtn_ba_qarz.bry_qarz FROM kryar inner join froshtn_ba_qarz on kryar.id = froshtn_ba_qarz.kryar_id  left join froshtn  on froshtn_ba_qarz.id = froshtn.froshtn_ba_qarz_id left JOIN item ON froshtn.item_id = item.id ")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }
        private void frmQarz_rpt_Load(object sender, EventArgs e)
        {
            showReport();
            dataToComb3();
            DateStart.Text = DateTime.Now.ToString("yyyy-MM-dd");
            DateEnd.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptKryar.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetAllKryar", db.query("SELECT kryar.name ,froshtn.wasl,froshtn.barwary_froshtn,froshtn_ba_qarz.bry_para,froshtn_ba_qarz.bry_qarz FROM kryar inner join froshtn_ba_qarz on kryar.id = froshtn_ba_qarz.kryar_id  left join froshtn  on froshtn_ba_qarz.id = froshtn.froshtn_ba_qarz_id left JOIN item ON froshtn.item_id = item.id  where kryar.name = '" + ComboBox1.Text + "'")));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetQarawa", db.query("select back_to_koga.barcode,back_to_koga.item_name,SUM(back_to_koga.dana)dana,SUM(back_to_koga.karton)karton , back_to_koga.nrxy_garanawaa from back_to_koga inner join kryar on back_to_koga.froshtn_id = kryar.id where kryar.name = '" + ComboBox1.Text + "' group by back_to_koga.barcode,back_to_koga.item_name, back_to_koga.nrxy_garanawaa  ")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout); 
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptKryar.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetAllKryar", db.query("SELECT kryar.name ,froshtn.wasl,froshtn.barwary_froshtn,froshtn_ba_qarz.bry_para,froshtn_ba_qarz.bry_qarz FROM kryar inner join froshtn_ba_qarz on kryar.id = froshtn_ba_qarz.kryar_id  left join froshtn  on froshtn_ba_qarz.id = froshtn.froshtn_ba_qarz_id left JOIN item ON froshtn.item_id = item.id  where froshtn.barwary_froshtn between '" + DateStart.Value.ToString("yyyy-MM-dd").Trim() + "' and '" + DateEnd.Value.ToString("yyyy-MM-dd").Trim() + "'")));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetQarawa", db.query("select back_to_koga.barcode,back_to_koga.item_name,SUM(back_to_koga.dana)dana,SUM(back_to_koga.karton)karton , back_to_koga.nrxy_garanawaa from back_to_koga inner join kryar on back_to_koga.froshtn_id = kryar.id  group by back_to_koga.barcode,back_to_koga.item_name , back_to_koga.nrxy_garanawaa ")));

            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptKryar.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetAllKryar", db.query("SELECT kryar.name ,froshtn.wasl,froshtn.barwary_froshtn,froshtn_ba_qarz.bry_para,froshtn_ba_qarz.bry_qarz FROM kryar inner join froshtn_ba_qarz on kryar.id = froshtn_ba_qarz.kryar_id  left join froshtn  on froshtn_ba_qarz.id = froshtn.froshtn_ba_qarz_id left JOIN item ON froshtn.item_id = item.id  where froshtn.barwary_froshtn between '" + DateStart.Value.ToString("yyyy-MM-dd").Trim() + "' and '" + DateEnd.Value.ToString("yyyy-MM-dd").Trim() + "' AND  kryar.name = '" + ComboBox1.Text + "'")));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetQarawa", db.query("select back_to_koga.barcode,back_to_koga.item_name,SUM(back_to_koga.dana)dana,SUM(back_to_koga.karton)karton , back_to_koga.nrxy_garanawaa from back_to_koga inner join kryar on back_to_koga.froshtn_id = kryar.id where kryar.name = '" + ComboBox1.Text + "' group by back_to_koga.barcode,back_to_koga.item_name , back_to_koga.nrxy_garanawaa ")));
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }
    }
}
