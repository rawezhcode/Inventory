
namespace Inventory
{
    partial class frmBackUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackUp));
            this.btnBackUp = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_BackBrowser = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_BackupBrowser = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // btnBackUp
            // 
            this.btnBackUp.Animated = true;
            this.btnBackUp.BorderRadius = 5;
            this.btnBackUp.CheckedState.Parent = this.btnBackUp;
            this.btnBackUp.CustomImages.Parent = this.btnBackUp;
            this.btnBackUp.FillColor2 = System.Drawing.Color.LightSeaGreen;
            this.btnBackUp.Font = new System.Drawing.Font("NRT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackUp.ForeColor = System.Drawing.Color.White;
            this.btnBackUp.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnBackUp.HoverState.Parent = this.btnBackUp;
            this.btnBackUp.Location = new System.Drawing.Point(82, 146);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.ShadowDecoration.Parent = this.btnBackUp;
            this.btnBackUp.Size = new System.Drawing.Size(262, 43);
            this.btnBackUp.TabIndex = 70;
            this.btnBackUp.Text = "خه‌زنكردن";
            this.btnBackUp.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // btn_BackBrowser
            // 
            this.btn_BackBrowser.Animated = true;
            this.btn_BackBrowser.BorderRadius = 5;
            this.btn_BackBrowser.CheckedState.Parent = this.btn_BackBrowser;
            this.btn_BackBrowser.CustomImages.Parent = this.btn_BackBrowser;
            this.btn_BackBrowser.FillColor2 = System.Drawing.Color.LightSeaGreen;
            this.btn_BackBrowser.Font = new System.Drawing.Font("NRT Bold", 12.75F);
            this.btn_BackBrowser.ForeColor = System.Drawing.Color.White;
            this.btn_BackBrowser.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_BackBrowser.HoverState.Parent = this.btn_BackBrowser;
            this.btn_BackBrowser.Location = new System.Drawing.Point(387, 146);
            this.btn_BackBrowser.Name = "btn_BackBrowser";
            this.btn_BackBrowser.ShadowDecoration.Parent = this.btn_BackBrowser;
            this.btn_BackBrowser.Size = new System.Drawing.Size(251, 43);
            this.btn_BackBrowser.TabIndex = 69;
            this.btn_BackBrowser.Text = "شوێنی خه‌زنكردن";
            this.btn_BackBrowser.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.btn_BackBrowser.Click += new System.EventHandler(this.btn_BackBrowser_Click);
            // 
            // txt_BackupBrowser
            // 
            this.txt_BackupBrowser.Animated = true;
            this.txt_BackupBrowser.BorderRadius = 5;
            this.txt_BackupBrowser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_BackupBrowser.DefaultText = "";
            this.txt_BackupBrowser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_BackupBrowser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_BackupBrowser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_BackupBrowser.DisabledState.Parent = this.txt_BackupBrowser;
            this.txt_BackupBrowser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_BackupBrowser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_BackupBrowser.FocusedState.Parent = this.txt_BackupBrowser;
            this.txt_BackupBrowser.Font = new System.Drawing.Font("NRT Bold", 12.75F);
            this.txt_BackupBrowser.ForeColor = System.Drawing.Color.Black;
            this.txt_BackupBrowser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_BackupBrowser.HoverState.Parent = this.txt_BackupBrowser;
            this.txt_BackupBrowser.Location = new System.Drawing.Point(82, 65);
            this.txt_BackupBrowser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_BackupBrowser.Name = "txt_BackupBrowser";
            this.txt_BackupBrowser.PasswordChar = '\0';
            this.txt_BackupBrowser.PlaceholderText = "شوێنی خه‌زنكردن";
            this.txt_BackupBrowser.SelectedText = "";
            this.txt_BackupBrowser.ShadowDecoration.Parent = this.txt_BackupBrowser;
            this.txt_BackupBrowser.Size = new System.Drawing.Size(556, 37);
            this.txt_BackupBrowser.TabIndex = 68;
            this.txt_BackupBrowser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmBackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(726, 240);
            this.Controls.Add(this.btnBackUp);
            this.Controls.Add(this.btn_BackBrowser);
            this.Controls.Add(this.txt_BackupBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBackUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBackUp";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnBackUp;
        private Guna.UI2.WinForms.Guna2GradientButton btn_BackBrowser;
        private Guna.UI2.WinForms.Guna2TextBox txt_BackupBrowser;
    }
}