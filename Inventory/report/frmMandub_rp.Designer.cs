
namespace Inventory.report
{
    partial class frmMandub_rp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.DateEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DateStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("NRT Bold", 13F);
            this.label4.Location = new System.Drawing.Point(1075, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 36);
            this.label4.TabIndex = 138;
            this.label4.Text = "مەندوبەکان";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBox1
            // 
            this.ComboBox1.Animated = true;
            this.ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox1.BorderColor = System.Drawing.Color.CadetBlue;
            this.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox1.FocusedState.Parent = this.ComboBox1;
            this.ComboBox1.Font = new System.Drawing.Font("Rabar_022", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox1.HoverState.Parent = this.ComboBox1;
            this.ComboBox1.ItemHeight = 30;
            this.ComboBox1.ItemsAppearance.Parent = this.ComboBox1;
            this.ComboBox1.Location = new System.Drawing.Point(652, 33);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.ShadowDecoration.Parent = this.ComboBox1;
            this.ComboBox1.Size = new System.Drawing.Size(417, 36);
            this.ComboBox1.TabIndex = 137;
            this.ComboBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetFroshtn";
            reportDataSource1.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptFroshraw.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(204, 86);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(973, 597);
            this.reportViewer1.TabIndex = 136;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("NRT Bold", 11F);
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(3, 86);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(195, 46);
            this.guna2Button2.TabIndex = 222;
            this.guna2Button2.Text = "گـه‌ران بە پێی مەندووب و بەروار";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("NRT Bold", 13F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(3, 142);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(195, 38);
            this.guna2Button1.TabIndex = 219;
            this.guna2Button1.Text = "گــــــــــــه‌ران بە پێی بەروار";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // DateEnd
            // 
            this.DateEnd.Animated = true;
            this.DateEnd.BorderThickness = 1;
            this.DateEnd.CheckedState.Parent = this.DateEnd;
            this.DateEnd.FillColor = System.Drawing.Color.Transparent;
            this.DateEnd.Font = new System.Drawing.Font("NRT Bold", 13F);
            this.DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateEnd.HoverState.Parent = this.DateEnd;
            this.DateEnd.Location = new System.Drawing.Point(3, 297);
            this.DateEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.ShadowDecoration.Parent = this.DateEnd;
            this.DateEnd.Size = new System.Drawing.Size(195, 30);
            this.DateEnd.TabIndex = 218;
            this.DateEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateEnd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.DateEnd.Value = new System.DateTime(2020, 7, 29, 19, 8, 21, 38);
            // 
            // DateStart
            // 
            this.DateStart.Animated = true;
            this.DateStart.BorderThickness = 1;
            this.DateStart.CheckedState.Parent = this.DateStart;
            this.DateStart.FillColor = System.Drawing.Color.Transparent;
            this.DateStart.Font = new System.Drawing.Font("NRT Bold", 13F);
            this.DateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateStart.HoverState.Parent = this.DateStart;
            this.DateStart.Location = new System.Drawing.Point(3, 228);
            this.DateStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateStart.Name = "DateStart";
            this.DateStart.ShadowDecoration.Parent = this.DateStart;
            this.DateStart.Size = new System.Drawing.Size(195, 30);
            this.DateStart.TabIndex = 217;
            this.DateStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateStart.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.DateStart.Value = new System.DateTime(2020, 7, 29, 21, 3, 23, 295);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("NRT Bold", 13F);
            this.label2.Location = new System.Drawing.Point(39, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 27);
            this.label2.TabIndex = 220;
            this.label2.Text = "له‌ به‌رواری";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("NRT Bold", 13F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(42, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 33);
            this.label3.TabIndex = 221;
            this.label3.Text = "بۆ به‌رواری";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMandub_rp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1189, 695);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.DateEnd);
            this.Controls.Add(this.DateStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmMandub_rp";
            this.Text = "frmMandub_rp";
            this.Load += new System.EventHandler(this.frmMandub_rp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}