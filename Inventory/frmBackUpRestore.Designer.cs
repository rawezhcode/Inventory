
namespace Inventory
{
    partial class frmBackUpRestore
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
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_exp = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 10;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.LightSeaGreen;
            this.guna2GradientButton1.Font = new System.Drawing.Font("NRT Bold", 18F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Image = global::Inventory.Properties.Resources.backup_copy;
            this.guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2GradientButton1.Location = new System.Drawing.Point(128, 226);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(558, 77);
            this.guna2GradientButton1.TabIndex = 2;
            this.guna2GradientButton1.Text = "گـــــــــــێرانەوەی داتاکـــــــــــــــــــــــان";
            this.guna2GradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2GradientButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // btn_exp
            // 
            this.btn_exp.BorderRadius = 10;
            this.btn_exp.CheckedState.Parent = this.btn_exp;
            this.btn_exp.CustomImages.Parent = this.btn_exp;
            this.btn_exp.FillColor2 = System.Drawing.Color.LightSeaGreen;
            this.btn_exp.Font = new System.Drawing.Font("NRT Bold", 18F);
            this.btn_exp.ForeColor = System.Drawing.Color.White;
            this.btn_exp.HoverState.Parent = this.btn_exp;
            this.btn_exp.Image = global::Inventory.Properties.Resources.backup;
            this.btn_exp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_exp.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_exp.Location = new System.Drawing.Point(128, 99);
            this.btn_exp.Name = "btn_exp";
            this.btn_exp.ShadowDecoration.Parent = this.btn_exp;
            this.btn_exp.Size = new System.Drawing.Size(558, 77);
            this.btn_exp.TabIndex = 1;
            this.btn_exp.Text = "هــــــــــــــــــەڵگرتنی داتاکــــــــــــــــــــــــان";
            this.btn_exp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_exp.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.btn_exp.Click += new System.EventHandler(this.btn_exp_Click);
            // 
            // frmBackUpRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(839, 417);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.btn_exp);
            this.Name = "frmBackUpRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBackUpRestore";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btn_exp;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
    }
}