
namespace Inventory
{
    partial class frmQarz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQarz));
            this.btn_delete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_updata = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_insert = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_bry_para = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_delete.Location = new System.Drawing.Point(208, 566);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ShadowDecoration.Parent = this.btn_delete;
            this.btn_delete.Size = new System.Drawing.Size(198, 36);
            this.btn_delete.TabIndex = 95;
            this.btn_delete.Text = "سرینه‌وه‌";
            this.btn_delete.Visible = false;
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
            this.btn_updata.Location = new System.Drawing.Point(432, 566);
            this.btn_updata.Name = "btn_updata";
            this.btn_updata.ShadowDecoration.Parent = this.btn_updata;
            this.btn_updata.Size = new System.Drawing.Size(198, 36);
            this.btn_updata.TabIndex = 94;
            this.btn_updata.Text = "گۆرانكاری";
            this.btn_updata.Visible = false;
            this.btn_updata.Click += new System.EventHandler(this.btn_updata_Click);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 31;
            this.guna2DataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(12, 81);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.guna2DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.guna2DataGridView1.RowTemplate.Height = 26;
            this.guna2DataGridView1.RowTemplate.ReadOnly = true;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1055, 479);
            this.guna2DataGridView1.TabIndex = 89;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 31;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 26;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
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
            this.btn_insert.Location = new System.Drawing.Point(652, 566);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.ShadowDecoration.Parent = this.btn_insert;
            this.btn_insert.Size = new System.Drawing.Size(198, 36);
            this.btn_insert.TabIndex = 84;
            this.btn_insert.Text = "تۆماركردن";
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
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
            this.ComboBox1.Font = new System.Drawing.Font("NRT Bold", 15F);
            this.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox1.HoverState.Parent = this.ComboBox1;
            this.ComboBox1.ItemHeight = 30;
            this.ComboBox1.Items.AddRange(new object[] {
            "دانە",
            "کارتۆن",
            "داشکان"});
            this.ComboBox1.ItemsAppearance.Parent = this.ComboBox1;
            this.ComboBox1.Location = new System.Drawing.Point(12, 12);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.ShadowDecoration.Parent = this.ComboBox1;
            this.ComboBox1.Size = new System.Drawing.Size(128, 36);
            this.ComboBox1.TabIndex = 97;
            this.ComboBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ComboBox1.Visible = false;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // txt_bry_para
            // 
            this.txt_bry_para.Animated = true;
            this.txt_bry_para.BorderColor = System.Drawing.Color.CadetBlue;
            this.txt_bry_para.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_bry_para.DefaultText = "";
            this.txt_bry_para.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_bry_para.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_bry_para.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bry_para.DisabledState.Parent = this.txt_bry_para;
            this.txt_bry_para.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bry_para.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bry_para.FocusedState.Parent = this.txt_bry_para;
            this.txt_bry_para.Font = new System.Drawing.Font("NRT Bold", 11F);
            this.txt_bry_para.ForeColor = System.Drawing.Color.Black;
            this.txt_bry_para.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bry_para.HoverState.Parent = this.txt_bry_para;
            this.txt_bry_para.Location = new System.Drawing.Point(173, 21);
            this.txt_bry_para.Margin = new System.Windows.Forms.Padding(7);
            this.txt_bry_para.Name = "txt_bry_para";
            this.txt_bry_para.PasswordChar = '\0';
            this.txt_bry_para.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txt_bry_para.PlaceholderText = "بری قەرز";
            this.txt_bry_para.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_bry_para.SelectedText = "";
            this.txt_bry_para.ShadowDecoration.Parent = this.txt_bry_para;
            this.txt_bry_para.Size = new System.Drawing.Size(327, 36);
            this.txt_bry_para.TabIndex = 114;
            this.txt_bry_para.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("NRT Bold", 11F);
            this.label13.Location = new System.Drawing.Point(965, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 36);
            this.label13.TabIndex = 214;
            this.label13.Text = "کریار";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.Animated = true;
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("NRT Bold", 12F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(632, 21);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(327, 36);
            this.guna2ComboBox1.TabIndex = 213;
            this.guna2ComboBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("NRT Bold", 11F);
            this.label1.Location = new System.Drawing.Point(500, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 36);
            this.label1.TabIndex = 215;
            this.label1.Text = "بری قەرز";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmQarz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 607);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.txt_bry_para);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_updata);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.guna2DataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQarz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فۆرمی قەرزی کریار";
            this.Load += new System.EventHandler(this.frmQarz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btn_delete;
        private Guna.UI2.WinForms.Guna2GradientButton btn_updata;
        private Guna.UI2.WinForms.Guna2GradientButton btn_insert;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refresh;
        private Guna.UI2.WinForms.Guna2TextBox txt_bry_para;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label label1;
    }
}