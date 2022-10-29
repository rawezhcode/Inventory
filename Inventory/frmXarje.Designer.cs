
namespace Inventory
{
    partial class frmXarje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXarje));
            this.barwary_xarje = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.bry_para = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_delete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_updata = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_insert = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.name_xarje = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barwary_xarje
            // 
            this.barwary_xarje.Animated = true;
            this.barwary_xarje.BorderColor = System.Drawing.Color.CadetBlue;
            this.barwary_xarje.BorderRadius = 5;
            this.barwary_xarje.CheckedState.Parent = this.barwary_xarje;
            this.barwary_xarje.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.barwary_xarje.Font = new System.Drawing.Font("NRT Bold", 12F);
            this.barwary_xarje.ForeColor = System.Drawing.Color.White;
            this.barwary_xarje.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.barwary_xarje.HoverState.Parent = this.barwary_xarje;
            this.barwary_xarje.IndicateFocus = true;
            this.barwary_xarje.Location = new System.Drawing.Point(207, 41);
            this.barwary_xarje.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.barwary_xarje.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.barwary_xarje.Name = "barwary_xarje";
            this.barwary_xarje.ShadowDecoration.Parent = this.barwary_xarje;
            this.barwary_xarje.Size = new System.Drawing.Size(308, 36);
            this.barwary_xarje.TabIndex = 113;
            this.barwary_xarje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.barwary_xarje.Value = new System.DateTime(2020, 7, 4, 11, 48, 38, 228);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("NRT Bold", 12F);
            this.label11.Location = new System.Drawing.Point(1053, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 36);
            this.label11.TabIndex = 117;
            this.label11.Text = "بری پارەی ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bry_para
            // 
            this.bry_para.Animated = true;
            this.bry_para.BorderColor = System.Drawing.Color.CadetBlue;
            this.bry_para.BorderRadius = 5;
            this.bry_para.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bry_para.DefaultText = "";
            this.bry_para.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bry_para.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bry_para.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bry_para.DisabledState.Parent = this.bry_para;
            this.bry_para.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bry_para.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bry_para.FocusedState.Parent = this.bry_para;
            this.bry_para.Font = new System.Drawing.Font("NRT Bold", 12F);
            this.bry_para.ForeColor = System.Drawing.Color.Black;
            this.bry_para.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bry_para.HoverState.Parent = this.bry_para;
            this.bry_para.Location = new System.Drawing.Point(674, 97);
            this.bry_para.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.bry_para.Name = "bry_para";
            this.bry_para.PasswordChar = '\0';
            this.bry_para.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.bry_para.PlaceholderText = "بری پارەی";
            this.bry_para.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bry_para.SelectedText = "";
            this.bry_para.ShadowDecoration.Parent = this.bry_para;
            this.bry_para.Size = new System.Drawing.Size(371, 36);
            this.bry_para.TabIndex = 116;
            this.bry_para.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("NRT Bold", 12F);
            this.label8.Location = new System.Drawing.Point(1048, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 36);
            this.label8.TabIndex = 115;
            this.label8.Text = "نـــاوی خەرجی";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("NRT Bold", 12F);
            this.label3.Location = new System.Drawing.Point(521, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 36);
            this.label3.TabIndex = 114;
            this.label3.Text = "بـه‌رواری خەرخی";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btn_delete.Location = new System.Drawing.Point(12, 245);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ShadowDecoration.Parent = this.btn_delete;
            this.btn_delete.Size = new System.Drawing.Size(189, 45);
            this.btn_delete.TabIndex = 121;
            this.btn_delete.Text = "سرینه‌وه‌";
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
            this.btn_updata.Location = new System.Drawing.Point(12, 194);
            this.btn_updata.Name = "btn_updata";
            this.btn_updata.ShadowDecoration.Parent = this.btn_updata;
            this.btn_updata.Size = new System.Drawing.Size(189, 45);
            this.btn_updata.TabIndex = 120;
            this.btn_updata.Text = "گۆرانكاری";
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
            this.btn_insert.Location = new System.Drawing.Point(12, 143);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.ShadowDecoration.Parent = this.btn_insert;
            this.btn_insert.Size = new System.Drawing.Size(189, 45);
            this.btn_insert.TabIndex = 119;
            this.btn_insert.Text = "تۆماركردن";
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
            this.DataGridView1.ContextMenuStrip = this.contextMenuStrip1;
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
            this.DataGridView1.Location = new System.Drawing.Point(207, 143);
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
            this.DataGridView1.Size = new System.Drawing.Size(938, 427);
            this.DataGridView1.TabIndex = 118;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refresh});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 26);
            // 
            // refresh
            // 
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(126, 22);
            this.refresh.Text = "نوێبوونەوە";
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // name_xarje
            // 
            this.name_xarje.Animated = true;
            this.name_xarje.BackColor = System.Drawing.Color.Transparent;
            this.name_xarje.BorderColor = System.Drawing.Color.CadetBlue;
            this.name_xarje.BorderRadius = 5;
            this.name_xarje.DisplayMember = "xaXAx";
            this.name_xarje.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.name_xarje.DropDownHeight = 125;
            this.name_xarje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.name_xarje.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_xarje.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_xarje.FocusedState.Parent = this.name_xarje;
            this.name_xarje.Font = new System.Drawing.Font("NRT Bold", 12F);
            this.name_xarje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.name_xarje.HoverState.Parent = this.name_xarje;
            this.name_xarje.IntegralHeight = false;
            this.name_xarje.ItemHeight = 30;
            this.name_xarje.ItemsAppearance.Parent = this.name_xarje;
            this.name_xarje.Location = new System.Drawing.Point(720, 41);
            this.name_xarje.Name = "name_xarje";
            this.name_xarje.ShadowDecoration.Parent = this.name_xarje;
            this.name_xarje.Size = new System.Drawing.Size(325, 36);
            this.name_xarje.TabIndex = 151;
            this.name_xarje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.AutoRoundedCorners = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 19;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.LightSeaGreen;
            this.guna2GradientButton1.Font = new System.Drawing.Font("NRT Bold", 12F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Image = global::Inventory.Properties.Resources.button;
            this.guna2GradientButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2GradientButton1.Location = new System.Drawing.Point(674, 37);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(40, 40);
            this.guna2GradientButton1.TabIndex = 150;
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.Animated = true;
            this.guna2GradientButton2.BorderRadius = 5;
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.LightSeaGreen;
            this.guna2GradientButton2.Font = new System.Drawing.Font("NRT Bold", 12F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Location = new System.Drawing.Point(12, 515);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(189, 45);
            this.guna2GradientButton2.TabIndex = 152;
            this.guna2GradientButton2.Text = "راپۆرت";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // frmXarje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 582);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.name_xarje);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_updata);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.barwary_xarje);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bry_para);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmXarje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فۆرمی خەرجیەکان";
            this.Load += new System.EventHandler(this.frmXarje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label11;
        public Guna.UI2.WinForms.Guna2TextBox bry_para;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton btn_delete;
        private Guna.UI2.WinForms.Guna2GradientButton btn_updata;
        private Guna.UI2.WinForms.Guna2GradientButton btn_insert;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView1;
        public Guna.UI2.WinForms.Guna2DateTimePicker barwary_xarje;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refresh;
        public Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        public Guna.UI2.WinForms.Guna2ComboBox name_xarje;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
    }
}