
namespace BanGiay
{
    partial class FrmGiaoDien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiaoDien));
            this.NhanVien = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.QuanLy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NhanVien
            // 
            this.NhanVien.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhanVien.ForeColor = System.Drawing.Color.Blue;
            this.NhanVien.Image = global::BanGiay.Properties.Resources._49793183;
            this.NhanVien.Location = new System.Drawing.Point(36, 86);
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.Size = new System.Drawing.Size(220, 125);
            this.NhanVien.TabIndex = 0;
            this.NhanVien.Text = "Nhân viên";
            this.NhanVien.UseVisualStyleBackColor = true;
            this.NhanVien.Click += new System.EventHandler(this.NhanVien_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // QuanLy
            // 
            this.QuanLy.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLy.ForeColor = System.Drawing.Color.Blue;
            this.QuanLy.Image = global::BanGiay.Properties.Resources._49793183;
            this.QuanLy.Location = new System.Drawing.Point(309, 86);
            this.QuanLy.Name = "QuanLy";
            this.QuanLy.Size = new System.Drawing.Size(229, 125);
            this.QuanLy.TabIndex = 0;
            this.QuanLy.Text = "Quản lý";
            this.QuanLy.UseVisualStyleBackColor = true;
            this.QuanLy.Click += new System.EventHandler(this.QuanLy_Click);
            // 
            // FrmGiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(579, 315);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.QuanLy);
            this.Controls.Add(this.NhanVien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmGiaoDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao diện";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NhanVien;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button QuanLy;
    }
}