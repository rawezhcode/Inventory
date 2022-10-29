
namespace Inventory.report
{
    partial class frmKryarWasl_rpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKryarWasl_rpt));
            this.label13 = new System.Windows.Forms.Label();
            this.ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.DateStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("NRT Bold", 11F);
            this.label13.Location = new System.Drawing.Point(1042, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 36);
            this.label13.TabIndex = 217;
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
            this.ComboBox1.Location = new System.Drawing.Point(600, 22);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.ShadowDecoration.Parent = this.ComboBox1;
            this.ComboBox1.Size = new System.Drawing.Size(436, 36);
            this.ComboBox1.TabIndex = 216;
            this.ComboBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetFroshtn";
            reportDataSource1.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptFroshraw.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(210, 70);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(934, 619);
            this.reportViewer1.TabIndex = 215;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 3;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.MediumAquamarine;
            this.guna2GradientButton1.Font = new System.Drawing.Font("NRT Bold", 11F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(210, 22);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(196, 35);
            this.guna2GradientButton1.TabIndex = 218;
            this.guna2GradientButton1.Text = "هەمووی";
            this.guna2GradientButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
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
            this.guna2Button2.Location = new System.Drawing.Point(9, 70);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(195, 46);
            this.guna2Button2.TabIndex = 224;
            this.guna2Button2.Text = "گـه‌ران بە پێی کریار و بەروار";
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
            this.guna2Button1.Location = new System.Drawing.Point(9, 126);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(195, 38);
            this.guna2Button1.TabIndex = 221;
            this.guna2Button1.Text = "گــــــــــــه‌ران بە پێی بەروار";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.DateStart.Location = new System.Drawing.Point(9, 212);
            this.DateStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateStart.Name = "DateStart";
            this.DateStart.ShadowDecoration.Parent = this.DateStart;
            this.DateStart.Size = new System.Drawing.Size(195, 30);
            this.DateStart.TabIndex = 219;
            this.DateStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateStart.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.DateStart.Value = new System.DateTime(2020, 7, 29, 21, 3, 23, 295);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("NRT Bold", 13F);
            this.label2.Location = new System.Drawing.Point(45, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 27);
            this.label2.TabIndex = 222;
            this.label2.Text = "له‌ به‌رواری";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmKryarWasl_rpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 707);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.DateStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKryarWasl_rpt";
            this.Text = "راپۆرتی وەسڵ قبص";
            this.Load += new System.EventHandler(this.frmKryarWasl_rpt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateStart;
        private System.Windows.Forms.Label label2;
    }
}