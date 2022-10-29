
namespace Inventory
{
    partial class frmAccount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccount));
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab_qarz = new System.Windows.Forms.Label();
            this.cmb_ustyp = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_user = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_delete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_updata = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_insert = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txt_fullName = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "ناوی به‌كارهێنه‌ر";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "وشه‌ی تێپه‌ر";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "userType";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "جۆری به‌كارهێن";
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            // 
            // lab_qarz
            // 
            this.lab_qarz.Font = new System.Drawing.Font("Rabar_022", 13F);
            this.lab_qarz.Location = new System.Drawing.Point(404, 95);
            this.lab_qarz.Name = "lab_qarz";
            this.lab_qarz.Size = new System.Drawing.Size(116, 36);
            this.lab_qarz.TabIndex = 98;
            this.lab_qarz.Text = "جۆری به‌كارهێن";
            this.lab_qarz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_ustyp
            // 
            this.cmb_ustyp.Animated = true;
            this.cmb_ustyp.BackColor = System.Drawing.Color.Transparent;
            this.cmb_ustyp.BorderColor = System.Drawing.Color.CadetBlue;
            this.cmb_ustyp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_ustyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ustyp.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_ustyp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_ustyp.FocusedState.Parent = this.cmb_ustyp;
            this.cmb_ustyp.Font = new System.Drawing.Font("NRT Bold", 12F);
            this.cmb_ustyp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_ustyp.HoverState.Parent = this.cmb_ustyp;
            this.cmb_ustyp.ItemHeight = 30;
            this.cmb_ustyp.Items.AddRange(new object[] {
            "بەرێوبەر"});
            this.cmb_ustyp.ItemsAppearance.Parent = this.cmb_ustyp;
            this.cmb_ustyp.Location = new System.Drawing.Point(207, 95);
            this.cmb_ustyp.Name = "cmb_ustyp";
            this.cmb_ustyp.ShadowDecoration.Parent = this.cmb_ustyp;
            this.cmb_ustyp.Size = new System.Drawing.Size(168, 36);
            this.cmb_ustyp.TabIndex = 97;
            this.cmb_ustyp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_pass
            // 
            this.txt_pass.Animated = true;
            this.txt_pass.BorderColor = System.Drawing.Color.CadetBlue;
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.DefaultText = "";
            this.txt_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pass.DisabledState.Parent = this.txt_pass;
            this.txt_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pass.FocusedState.Parent = this.txt_pass;
            this.txt_pass.Font = new System.Drawing.Font("NRT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.Black;
            this.txt_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pass.HoverState.Parent = this.txt_pass;
            this.txt_pass.Location = new System.Drawing.Point(530, 84);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '\0';
            this.txt_pass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txt_pass.PlaceholderText = "وشه‌ی تێپه‌ر";
            this.txt_pass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_pass.SelectedText = "";
            this.txt_pass.ShadowDecoration.Parent = this.txt_pass;
            this.txt_pass.Size = new System.Drawing.Size(322, 38);
            this.txt_pass.TabIndex = 96;
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_user
            // 
            this.txt_user.Animated = true;
            this.txt_user.BorderColor = System.Drawing.Color.CadetBlue;
            this.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user.DefaultText = "";
            this.txt_user.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_user.DisabledState.Parent = this.txt_user;
            this.txt_user.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_user.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_user.FocusedState.Parent = this.txt_user;
            this.txt_user.Font = new System.Drawing.Font("NRT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.Black;
            this.txt_user.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_user.HoverState.Parent = this.txt_user;
            this.txt_user.Location = new System.Drawing.Point(207, 38);
            this.txt_user.Margin = new System.Windows.Forms.Padding(4);
            this.txt_user.Name = "txt_user";
            this.txt_user.PasswordChar = '\0';
            this.txt_user.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txt_user.PlaceholderText = "ناوی به‌كارهێنه‌ر";
            this.txt_user.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_user.SelectedText = "";
            this.txt_user.ShadowDecoration.Parent = this.txt_user;
            this.txt_user.Size = new System.Drawing.Size(313, 38);
            this.txt_user.TabIndex = 95;
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_delete
            // 
            this.btn_delete.Animated = true;
            this.btn_delete.BorderRadius = 5;
            this.btn_delete.CheckedState.Parent = this.btn_delete;
            this.btn_delete.CustomImages.Parent = this.btn_delete;
            this.btn_delete.FillColor2 = System.Drawing.Color.LightSeaGreen;
            this.btn_delete.Font = new System.Drawing.Font("NRT Bold", 12F);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_delete.HoverState.Parent = this.btn_delete;
            this.btn_delete.Location = new System.Drawing.Point(12, 244);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ShadowDecoration.Parent = this.btn_delete;
            this.btn_delete.Size = new System.Drawing.Size(189, 45);
            this.btn_delete.TabIndex = 125;
            this.btn_delete.Text = "سرینه‌وه‌";
            this.btn_delete.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_updata
            // 
            this.btn_updata.Animated = true;
            this.btn_updata.BorderRadius = 5;
            this.btn_updata.CheckedState.Parent = this.btn_updata;
            this.btn_updata.CustomImages.Parent = this.btn_updata;
            this.btn_updata.FillColor2 = System.Drawing.Color.LightSeaGreen;
            this.btn_updata.Font = new System.Drawing.Font("NRT Bold", 12F);
            this.btn_updata.ForeColor = System.Drawing.Color.White;
            this.btn_updata.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_updata.HoverState.Parent = this.btn_updata;
            this.btn_updata.Location = new System.Drawing.Point(12, 193);
            this.btn_updata.Name = "btn_updata";
            this.btn_updata.ShadowDecoration.Parent = this.btn_updata;
            this.btn_updata.Size = new System.Drawing.Size(189, 45);
            this.btn_updata.TabIndex = 124;
            this.btn_updata.Text = "گۆرانكاری";
            this.btn_updata.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.btn_updata.Click += new System.EventHandler(this.btn_updata_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Animated = true;
            this.btn_insert.BorderRadius = 5;
            this.btn_insert.CheckedState.Parent = this.btn_insert;
            this.btn_insert.CustomImages.Parent = this.btn_insert;
            this.btn_insert.FillColor2 = System.Drawing.Color.LightSeaGreen;
            this.btn_insert.Font = new System.Drawing.Font("NRT Bold", 12F);
            this.btn_insert.ForeColor = System.Drawing.Color.White;
            this.btn_insert.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_insert.HoverState.Parent = this.btn_insert;
            this.btn_insert.Location = new System.Drawing.Point(12, 142);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.ShadowDecoration.Parent = this.btn_insert;
            this.btn_insert.Size = new System.Drawing.Size(189, 45);
            this.btn_insert.TabIndex = 123;
            this.btn_insert.Text = "تۆماركردن";
            this.btn_insert.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.DataGridView1.Location = new System.Drawing.Point(207, 142);
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
            this.DataGridView1.Size = new System.Drawing.Size(645, 352);
            this.DataGridView1.TabIndex = 122;
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
            // txt_fullName
            // 
            this.txt_fullName.Animated = true;
            this.txt_fullName.BorderColor = System.Drawing.Color.CadetBlue;
            this.txt_fullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_fullName.DefaultText = "";
            this.txt_fullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_fullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_fullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_fullName.DisabledState.Parent = this.txt_fullName;
            this.txt_fullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_fullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_fullName.FocusedState.Parent = this.txt_fullName;
            this.txt_fullName.Font = new System.Drawing.Font("NRT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fullName.ForeColor = System.Drawing.Color.Black;
            this.txt_fullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_fullName.HoverState.Parent = this.txt_fullName;
            this.txt_fullName.Location = new System.Drawing.Point(530, 38);
            this.txt_fullName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fullName.Name = "txt_fullName";
            this.txt_fullName.PasswordChar = '\0';
            this.txt_fullName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txt_fullName.PlaceholderText = "ناوی سیانی";
            this.txt_fullName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_fullName.SelectedText = "";
            this.txt_fullName.ShadowDecoration.Parent = this.txt_fullName;
            this.txt_fullName.Size = new System.Drawing.Size(322, 38);
            this.txt_fullName.TabIndex = 126;
            this.txt_fullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 506);
            this.Controls.Add(this.txt_fullName);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_updata);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.lab_qarz);
            this.Controls.Add(this.cmb_ustyp);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAccount";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lab_qarz;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_ustyp;
        private Guna.UI2.WinForms.Guna2TextBox txt_pass;
        private Guna.UI2.WinForms.Guna2TextBox txt_user;
        private Guna.UI2.WinForms.Guna2GradientButton btn_delete;
        private Guna.UI2.WinForms.Guna2GradientButton btn_updata;
        private Guna.UI2.WinForms.Guna2GradientButton btn_insert;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox txt_fullName;
    }
}