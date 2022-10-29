
namespace Inventory
{
    partial class frmCompany
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompany));
            this.btn_delete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_updata = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_insert = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invntoryDataSetCompany = new Inventory.InvntoryDataSetCompany();
            this.companyTableAdapter = new Inventory.InvntoryDataSetCompanyTableAdapters.companyTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shwenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invntoryDataSetCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Animated = true;
            this.btn_delete.BorderRadius = 5;
            this.btn_delete.CheckedState.Parent = this.btn_delete;
            this.btn_delete.CustomImages.Parent = this.btn_delete;
            this.btn_delete.FillColor2 = System.Drawing.Color.MediumTurquoise;
            this.btn_delete.Font = new System.Drawing.Font("NRT Bold", 12F);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_delete.HoverState.Parent = this.btn_delete;
            this.btn_delete.Location = new System.Drawing.Point(12, 237);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ShadowDecoration.Parent = this.btn_delete;
            this.btn_delete.Size = new System.Drawing.Size(189, 45);
            this.btn_delete.TabIndex = 40;
            this.btn_delete.Text = "سرینه‌وه‌";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_updata
            // 
            this.btn_updata.Animated = true;
            this.btn_updata.BorderRadius = 5;
            this.btn_updata.CheckedState.Parent = this.btn_updata;
            this.btn_updata.CustomImages.Parent = this.btn_updata;
            this.btn_updata.FillColor2 = System.Drawing.Color.MediumTurquoise;
            this.btn_updata.Font = new System.Drawing.Font("NRT Bold", 12F);
            this.btn_updata.ForeColor = System.Drawing.Color.White;
            this.btn_updata.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_updata.HoverState.Parent = this.btn_updata;
            this.btn_updata.Location = new System.Drawing.Point(12, 186);
            this.btn_updata.Name = "btn_updata";
            this.btn_updata.ShadowDecoration.Parent = this.btn_updata;
            this.btn_updata.Size = new System.Drawing.Size(189, 45);
            this.btn_updata.TabIndex = 39;
            this.btn_updata.Text = "گۆرانكاری";
            this.btn_updata.Click += new System.EventHandler(this.btn_updata_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Animated = true;
            this.btn_insert.BorderRadius = 5;
            this.btn_insert.CheckedState.Parent = this.btn_insert;
            this.btn_insert.CustomImages.Parent = this.btn_insert;
            this.btn_insert.FillColor2 = System.Drawing.Color.MediumTurquoise;
            this.btn_insert.Font = new System.Drawing.Font("NRT Bold", 12F);
            this.btn_insert.ForeColor = System.Drawing.Color.White;
            this.btn_insert.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_insert.HoverState.Parent = this.btn_insert;
            this.btn_insert.Location = new System.Drawing.Point(12, 135);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.ShadowDecoration.Parent = this.btn_insert;
            this.btn_insert.Size = new System.Drawing.Size(189, 45);
            this.btn_insert.TabIndex = 38;
            this.btn_insert.Text = "تۆماركردن";
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Animated = true;
            this.TextBox1.BorderColor = System.Drawing.Color.CadetBlue;
            this.TextBox1.BorderRadius = 5;
            this.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox1.DefaultText = "";
            this.TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox1.DisabledState.Parent = this.TextBox1;
            this.TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox1.FocusedState.Parent = this.TextBox1;
            this.TextBox1.Font = new System.Drawing.Font("NRT Bold", 12F);
            this.TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox1.HoverState.Parent = this.TextBox1;
            this.TextBox1.Location = new System.Drawing.Point(525, 34);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.PasswordChar = '\0';
            this.TextBox1.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.TextBox1.PlaceholderText = "ناوی كۆمپانیا";
            this.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBox1.SelectedText = "";
            this.TextBox1.ShadowDecoration.Parent = this.TextBox1;
            this.TextBox1.Size = new System.Drawing.Size(281, 36);
            this.TextBox1.TabIndex = 35;
            this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox2
            // 
            this.TextBox2.Animated = true;
            this.TextBox2.BorderColor = System.Drawing.Color.CadetBlue;
            this.TextBox2.BorderRadius = 5;
            this.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox2.DefaultText = "";
            this.TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox2.DisabledState.Parent = this.TextBox2;
            this.TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox2.FocusedState.Parent = this.TextBox2;
            this.TextBox2.Font = new System.Drawing.Font("NRT Bold", 12F);
            this.TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox2.HoverState.Parent = this.TextBox2;
            this.TextBox2.Location = new System.Drawing.Point(525, 80);
            this.TextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.PasswordChar = '\0';
            this.TextBox2.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.TextBox2.PlaceholderText = "شوێن";
            this.TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBox2.SelectedText = "";
            this.TextBox2.ShadowDecoration.Parent = this.TextBox2;
            this.TextBox2.Size = new System.Drawing.Size(281, 36);
            this.TextBox2.TabIndex = 37;
            this.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox3
            // 
            this.TextBox3.Animated = true;
            this.TextBox3.BorderColor = System.Drawing.Color.CadetBlue;
            this.TextBox3.BorderRadius = 5;
            this.TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox3.DefaultText = "";
            this.TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox3.DisabledState.Parent = this.TextBox3;
            this.TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox3.FocusedState.Parent = this.TextBox3;
            this.TextBox3.Font = new System.Drawing.Font("NRT Bold", 12F);
            this.TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox3.HoverState.Parent = this.TextBox3;
            this.TextBox3.Location = new System.Drawing.Point(207, 34);
            this.TextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.PasswordChar = '\0';
            this.TextBox3.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.TextBox3.PlaceholderText = "ژماره‌ موبایل";
            this.TextBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBox3.SelectedText = "";
            this.TextBox3.ShadowDecoration.Parent = this.TextBox3;
            this.TextBox3.Size = new System.Drawing.Size(282, 36);
            this.TextBox3.TabIndex = 36;
            this.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeight = 31;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.shwenDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.Column1});
            this.DataGridView1.DataSource = this.companyBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView1.Location = new System.Drawing.Point(207, 135);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridView1.RowTemplate.Height = 26;
            this.DataGridView1.RowTemplate.ReadOnly = true;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(599, 297);
            this.DataGridView1.TabIndex = 34;
            this.DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView1.ThemeStyle.HeaderStyle.Height = 31;
            this.DataGridView1.ThemeStyle.ReadOnly = true;
            this.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView1.ThemeStyle.RowsStyle.Height = 26;
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "company";
            this.companyBindingSource.DataSource = this.invntoryDataSetCompany;
            // 
            // invntoryDataSetCompany
            // 
            this.invntoryDataSetCompany.DataSetName = "InvntoryDataSetCompany";
            this.invntoryDataSetCompany.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "ناو";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shwenDataGridViewTextBoxColumn
            // 
            this.shwenDataGridViewTextBoxColumn.DataPropertyName = "shwen";
            this.shwenDataGridViewTextBoxColumn.HeaderText = "شوێن";
            this.shwenDataGridViewTextBoxColumn.Name = "shwenDataGridViewTextBoxColumn";
            this.shwenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "ژمارە مووبایل";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IDcompany";
            this.Column1.FillWeight = 38.07107F;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "سرینه‌وه‌";
            this.Column1.ToolTipText = "سرینه‌وه‌";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // frmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(837, 466);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_updata);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.DataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فۆرمی کۆمپانیا";
            this.Load += new System.EventHandler(this.frmCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invntoryDataSetCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btn_delete;
        private Guna.UI2.WinForms.Guna2GradientButton btn_updata;
        private Guna.UI2.WinForms.Guna2GradientButton btn_insert;
        private Guna.UI2.WinForms.Guna2TextBox TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox TextBox3;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView1;
        private InvntoryDataSetCompany invntoryDataSetCompany;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private InvntoryDataSetCompanyTableAdapters.companyTableAdapter companyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shwenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}