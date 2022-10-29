
namespace Inventory.report
{
    partial class frmKryar_rpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKryar_rpt));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.DateEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DateStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetFroshtn";
            reportDataSource1.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptFroshraw.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(213, 67);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(934, 619);
            this.reportViewer1.TabIndex = 2;
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
            this.guna2Button1.Location = new System.Drawing.Point(12, 67);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(195, 38);
            this.guna2Button1.TabIndex = 140;
            this.guna2Button1.Text = "گــــــــــــه‌ران";
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
            this.DateEnd.Location = new System.Drawing.Point(12, 222);
            this.DateEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.ShadowDecoration.Parent = this.DateEnd;
            this.DateEnd.Size = new System.Drawing.Size(195, 30);
            this.DateEnd.TabIndex = 139;
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
            this.DateStart.Location = new System.Drawing.Point(12, 153);
            this.DateStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateStart.Name = "DateStart";
            this.DateStart.ShadowDecoration.Parent = this.DateStart;
            this.DateStart.Size = new System.Drawing.Size(195, 30);
            this.DateStart.TabIndex = 138;
            this.DateStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateStart.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.DateStart.Value = new System.DateTime(2020, 7, 29, 21, 3, 23, 295);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("NRT Bold", 13F);
            this.label2.Location = new System.Drawing.Point(48, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 27);
            this.label2.TabIndex = 141;
            this.label2.Text = "له‌ به‌رواری";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("NRT Bold", 13F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(51, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 33);
            this.label3.TabIndex = 142;
            this.label3.Text = "بۆ به‌رواری";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("NRT Bold", 11F);
            this.label13.Location = new System.Drawing.Point(1045, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 36);
            this.label13.TabIndex = 214;
            this.label13.Text = "کریار";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBox1
            // 
            this.ComboBox1.Animated = true;
            this.ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox1.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox1.FocusedState.Parent = this.ComboBox1;
            this.ComboBox1.Font = new System.Drawing.Font("NRT Bold", 12F);
            this.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox1.HoverState.Parent = this.ComboBox1;
            this.ComboBox1.ItemHeight = 30;
            this.ComboBox1.ItemsAppearance.Parent = this.ComboBox1;
            this.ComboBox1.Location = new System.Drawing.Point(603, 19);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.ShadowDecoration.Parent = this.ComboBox1;
            this.ComboBox1.Size = new System.Drawing.Size(436, 36);
            this.ComboBox1.TabIndex = 213;
            this.ComboBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("NRT Bold", 13F);
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(12, 12);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(255, 36);
            this.guna2Button2.TabIndex = 215;
            this.guna2Button2.Text = "گــــــــــــه‌ران بە پێی کریار و بەروار";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // frmKryar_rpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 706);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.DateEnd);
            this.Controls.Add(this.DateStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKryar_rpt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فۆرمی راپۆرتی قەرز";
            this.Load += new System.EventHandler(this.frmQarz_rpt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}