
namespace Inventory.report
{
    partial class frmFroshtn_rp
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFroshtn_rp));
            this.invntoryDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invntoryDataSet1 = new Inventory.InvntoryDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DateEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_serch = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.invntoryDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invntoryDataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // invntoryDataSet1BindingSource
            // 
            this.invntoryDataSet1BindingSource.DataSource = this.invntoryDataSet1;
            this.invntoryDataSet1BindingSource.Position = 0;
            // 
            // invntoryDataSet1
            // 
            this.invntoryDataSet1.DataSetName = "InvntoryDataSet1";
            this.invntoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetFroshtn";
            reportDataSource1.Value = this.invntoryDataSet1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.rptFroshtn.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(219, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1106, 646);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DateEnd);
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.DateStart);
            this.panel2.Location = new System.Drawing.Point(10, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 198);
            this.panel2.TabIndex = 85;
            // 
            // DateEnd
            // 
            this.DateEnd.Animated = true;
            this.DateEnd.BorderThickness = 1;
            this.DateEnd.CheckedState.Parent = this.DateEnd;
            this.DateEnd.FillColor = System.Drawing.Color.Transparent;
            this.DateEnd.Font = new System.Drawing.Font("NRT Bold", 12F);
            this.DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateEnd.HoverState.Parent = this.DateEnd;
            this.DateEnd.Location = new System.Drawing.Point(3, 153);
            this.DateEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.ShadowDecoration.Parent = this.DateEnd;
            this.DateEnd.Size = new System.Drawing.Size(195, 33);
            this.DateEnd.TabIndex = 80;
            this.DateEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateEnd.Value = new System.DateTime(2020, 7, 29, 19, 8, 21, 38);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("NRT Bold", 12F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(3, 4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(195, 38);
            this.guna2Button1.TabIndex = 81;
            this.guna2Button1.Text = "گــــــــــــه‌ران";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("NRT Bold", 12F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(62, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 33);
            this.label3.TabIndex = 83;
            this.label3.Text = "بۆ به‌رواری";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("NRT Bold", 12F);
            this.label2.Location = new System.Drawing.Point(62, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 27);
            this.label2.TabIndex = 82;
            this.label2.Text = "له‌ به‌رواری";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DateStart
            // 
            this.DateStart.Animated = true;
            this.DateStart.BorderThickness = 1;
            this.DateStart.CheckedState.Parent = this.DateStart;
            this.DateStart.FillColor = System.Drawing.Color.Transparent;
            this.DateStart.Font = new System.Drawing.Font("NRT Bold", 12F);
            this.DateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateStart.HoverState.Parent = this.DateStart;
            this.DateStart.Location = new System.Drawing.Point(3, 82);
            this.DateStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateStart.Name = "DateStart";
            this.DateStart.ShadowDecoration.Parent = this.DateStart;
            this.DateStart.Size = new System.Drawing.Size(195, 33);
            this.DateStart.TabIndex = 79;
            this.DateStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateStart.Value = new System.DateTime(2020, 7, 29, 21, 3, 23, 295);
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
            this.txt_serch.Location = new System.Drawing.Point(813, 17);
            this.txt_serch.Margin = new System.Windows.Forms.Padding(4);
            this.txt_serch.Name = "txt_serch";
            this.txt_serch.PasswordChar = '\0';
            this.txt_serch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txt_serch.PlaceholderText = "وەسڵ";
            this.txt_serch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_serch.SelectedText = "";
            this.txt_serch.ShadowDecoration.Parent = this.txt_serch;
            this.txt_serch.Size = new System.Drawing.Size(512, 36);
            this.txt_serch.TabIndex = 134;
            this.txt_serch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_serch.TextChanged += new System.EventHandler(this.txt_serch_TextChanged);
            // 
            // frmFroshtn_rp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.txt_serch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFroshtn_rp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فۆرمی راپۆرتی فرۆشتنەکان";
            this.Load += new System.EventHandler(this.frmFroshtn_rp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invntoryDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invntoryDataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateEnd;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateStart;
        private System.Windows.Forms.BindingSource invntoryDataSet1BindingSource;
        private InvntoryDataSet1 invntoryDataSet1;
        public Guna.UI2.WinForms.Guna2TextBox txt_serch;
    }
}