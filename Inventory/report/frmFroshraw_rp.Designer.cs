
namespace Inventory.report
{
    partial class frmFroshraw_rp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFroshraw_rp));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.DateEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DateStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_serch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetFroshtn";
            reportDataSource1.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptFroshraw.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(231, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1107, 648);
            this.reportViewer1.TabIndex = 1;
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
            this.guna2Button1.Location = new System.Drawing.Point(12, 125);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(195, 38);
            this.guna2Button1.TabIndex = 128;
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
            this.DateEnd.Location = new System.Drawing.Point(12, 280);
            this.DateEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.ShadowDecoration.Parent = this.DateEnd;
            this.DateEnd.Size = new System.Drawing.Size(195, 30);
            this.DateEnd.TabIndex = 127;
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
            this.DateStart.Location = new System.Drawing.Point(12, 211);
            this.DateStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateStart.Name = "DateStart";
            this.DateStart.ShadowDecoration.Parent = this.DateStart;
            this.DateStart.Size = new System.Drawing.Size(195, 30);
            this.DateStart.TabIndex = 126;
            this.DateStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateStart.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.DateStart.Value = new System.DateTime(2020, 7, 29, 21, 3, 23, 295);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("NRT Bold", 13F);
            this.label2.Location = new System.Drawing.Point(48, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 27);
            this.label2.TabIndex = 129;
            this.label2.Text = "له‌ به‌رواری";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("NRT Bold", 13F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(51, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 33);
            this.label3.TabIndex = 130;
            this.label3.Text = "بۆ به‌رواری";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("NRT Bold", 13F);
            this.label1.Location = new System.Drawing.Point(360, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 36);
            this.label1.TabIndex = 132;
            this.label1.Text = " فرۆشراوه‌ به‌";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.Animated = true;
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.BorderColor = System.Drawing.Color.CadetBlue;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Font = new System.Drawing.Font("Rabar_022", 12F, System.Drawing.FontStyle.Bold);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox2.HoverState.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.ItemHeight = 30;
            this.guna2ComboBox2.Items.AddRange(new object[] {
            "قه‌رز",
            "نه‌قد",
            "داشکان"});
            this.guna2ComboBox2.ItemsAppearance.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Location = new System.Drawing.Point(234, 18);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.ShadowDecoration.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Size = new System.Drawing.Size(120, 36);
            this.guna2ComboBox2.TabIndex = 131;
            this.guna2ComboBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2ComboBox2.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox2_SelectedIndexChanged);
            // 
            // txt_serch
            // 
            this.txt_serch.Animated = true;
            this.txt_serch.BorderColor = System.Drawing.Color.CadetBlue;
            this.txt_serch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_serch.DefaultText = "";
            this.txt_serch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_serch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_serch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_serch.DisabledState.Parent = this.txt_serch;
            this.txt_serch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_serch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_serch.FocusedState.Parent = this.txt_serch;
            this.txt_serch.Font = new System.Drawing.Font("NRT Bold", 15F);
            this.txt_serch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_serch.HoverState.Parent = this.txt_serch;
            this.txt_serch.Location = new System.Drawing.Point(1084, 18);
            this.txt_serch.Margin = new System.Windows.Forms.Padding(4);
            this.txt_serch.Name = "txt_serch";
            this.txt_serch.PasswordChar = '\0';
            this.txt_serch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txt_serch.PlaceholderText = "وەسڵ";
            this.txt_serch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_serch.SelectedText = "";
            this.txt_serch.ShadowDecoration.Parent = this.txt_serch;
            this.txt_serch.Size = new System.Drawing.Size(253, 36);
            this.txt_serch.TabIndex = 133;
            this.txt_serch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_serch.TextChanged += new System.EventHandler(this.txt_serch_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("NRT Bold", 13F);
            this.label4.Location = new System.Drawing.Point(923, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 36);
            this.label4.TabIndex = 135;
            this.label4.Text = "کریار";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.guna2Button2.Location = new System.Drawing.Point(12, 69);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(195, 46);
            this.guna2Button2.TabIndex = 216;
            this.guna2Button2.Text = "گـه‌ران بە پێی کریار و بەروار";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // ComboBox1
            // 
            this.ComboBox1.Font = new System.Drawing.Font("Rabar_022", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(523, 19);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(368, 34);
            this.ComboBox1.TabIndex = 217;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // frmFroshraw_rp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_serch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ComboBox2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.DateEnd);
            this.Controls.Add(this.DateStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFroshraw_rp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فۆرمی فرۆشراوەکان";
            this.Load += new System.EventHandler(this.frmFroshraw_rp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        public Guna.UI2.WinForms.Guna2TextBox txt_serch;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.ComboBox ComboBox1;
    }
}