
namespace Inventory
{
    partial class frmMandub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMandub));
            this.txt_naw = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_update = new Guna.UI2.WinForms.Guna2Button();
            this.btn_insert = new Guna.UI2.WinForms.Guna2Button();
            this.DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_naw
            // 
            this.txt_naw.Animated = true;
            this.txt_naw.BorderRadius = 5;
            this.txt_naw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_naw.DefaultText = "";
            this.txt_naw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_naw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_naw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_naw.DisabledState.Parent = this.txt_naw;
            this.txt_naw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_naw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_naw.FocusedState.Parent = this.txt_naw;
            this.txt_naw.Font = new System.Drawing.Font("NRT Bold", 12F);
            this.txt_naw.ForeColor = System.Drawing.Color.Black;
            this.txt_naw.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_naw.HoverState.Parent = this.txt_naw;
            this.txt_naw.Location = new System.Drawing.Point(154, 34);
            this.txt_naw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_naw.Name = "txt_naw";
            this.txt_naw.PasswordChar = '\0';
            this.txt_naw.PlaceholderText = "ناوی مەندوب";
            this.txt_naw.SelectedText = "";
            this.txt_naw.ShadowDecoration.Parent = this.txt_naw;
            this.txt_naw.Size = new System.Drawing.Size(439, 40);
            this.txt_naw.TabIndex = 15;
            this.txt_naw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_delete
            // 
            this.btn_delete.Animated = true;
            this.btn_delete.BorderRadius = 5;
            this.btn_delete.CheckedState.Parent = this.btn_delete;
            this.btn_delete.CustomImages.Parent = this.btn_delete;
            this.btn_delete.Font = new System.Drawing.Font("NRT Reg", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.HoverState.Parent = this.btn_delete;
            this.btn_delete.Location = new System.Drawing.Point(7, 185);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ShadowDecoration.Parent = this.btn_delete;
            this.btn_delete.Size = new System.Drawing.Size(132, 45);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "سرینه‌وه‌";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Animated = true;
            this.btn_update.BorderRadius = 5;
            this.btn_update.CheckedState.Parent = this.btn_update;
            this.btn_update.CustomImages.Parent = this.btn_update;
            this.btn_update.Font = new System.Drawing.Font("NRT Reg", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.HoverState.Parent = this.btn_update;
            this.btn_update.Location = new System.Drawing.Point(7, 134);
            this.btn_update.Name = "btn_update";
            this.btn_update.ShadowDecoration.Parent = this.btn_update;
            this.btn_update.Size = new System.Drawing.Size(132, 45);
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "گۆرانكاری";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Animated = true;
            this.btn_insert.BorderRadius = 5;
            this.btn_insert.CheckedState.Parent = this.btn_insert;
            this.btn_insert.CustomImages.Parent = this.btn_insert;
            this.btn_insert.Font = new System.Drawing.Font("NRT Reg", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_insert.ForeColor = System.Drawing.Color.White;
            this.btn_insert.HoverState.Parent = this.btn_insert;
            this.btn_insert.Location = new System.Drawing.Point(7, 83);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.ShadowDecoration.Parent = this.btn_insert;
            this.btn_insert.Size = new System.Drawing.Size(132, 45);
            this.btn_insert.TabIndex = 12;
            this.btn_insert.Text = "زیادكردن";
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
            this.DataGridView1.ColumnHeadersHeight = 30;
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
            this.DataGridView1.Location = new System.Drawing.Point(154, 83);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowTemplate.Height = 26;
            this.DataGridView1.RowTemplate.ReadOnly = true;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(439, 275);
            this.DataGridView1.TabIndex = 11;
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
            this.DataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            this.DataGridView1.ThemeStyle.ReadOnly = false;
            this.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView1.ThemeStyle.RowsStyle.Height = 26;
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // frmMandub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(625, 379);
            this.Controls.Add(this.txt_naw);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.DataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMandub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فۆرمی مەندوب";
            this.Load += new System.EventHandler(this.frmMandub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txt_naw;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2Button btn_update;
        private Guna.UI2.WinForms.Guna2Button btn_insert;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView1;
    }
}