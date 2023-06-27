
namespace BanGiay
{
    partial class FrmTimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimKiem));
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTimKiem = new System.Windows.Forms.DataGridView();
            this.btnTimCTHD = new System.Windows.Forms.Button();
            this.btnTimSP = new System.Windows.Forms.Button();
            this.btnTimKH = new System.Windows.Forms.Button();
            this.btnTimHD = new System.Windows.Forms.Button();
            this.btnTimNV = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Blue;
            this.txtTimKiem.Location = new System.Drawing.Point(42, 69);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(225, 42);
            this.txtTimKiem.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvTimKiem);
            this.panel1.Controls.Add(this.btnTimCTHD);
            this.panel1.Controls.Add(this.btnTimSP);
            this.panel1.Controls.Add(this.btnTimKH);
            this.panel1.Controls.Add(this.btnTimHD);
            this.panel1.Controls.Add(this.btnTimNV);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Location = new System.Drawing.Point(12, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 511);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(53, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 29);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tìm kiếm theo mã";
            // 
            // dgvTimKiem
            // 
            this.dgvTimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimKiem.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiem.Location = new System.Drawing.Point(305, 69);
            this.dgvTimKiem.Name = "dgvTimKiem";
            this.dgvTimKiem.Size = new System.Drawing.Size(634, 421);
            this.dgvTimKiem.TabIndex = 2;
            // 
            // btnTimCTHD
            // 
            this.btnTimCTHD.BackColor = System.Drawing.Color.Transparent;
            this.btnTimCTHD.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.btnTimCTHD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTimCTHD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTimCTHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimCTHD.ForeColor = System.Drawing.Color.Lime;
            this.btnTimCTHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimCTHD.Location = new System.Drawing.Point(42, 444);
            this.btnTimCTHD.Name = "btnTimCTHD";
            this.btnTimCTHD.Size = new System.Drawing.Size(225, 46);
            this.btnTimCTHD.TabIndex = 34;
            this.btnTimCTHD.Text = "Tìm kiếm chi tiết HD";
            this.btnTimCTHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimCTHD.UseVisualStyleBackColor = false;
            this.btnTimCTHD.Click += new System.EventHandler(this.btnTimCTHD_Click);
            // 
            // btnTimSP
            // 
            this.btnTimSP.BackColor = System.Drawing.Color.Transparent;
            this.btnTimSP.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.btnTimSP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTimSP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTimSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimSP.ForeColor = System.Drawing.Color.Lime;
            this.btnTimSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimSP.Location = new System.Drawing.Point(42, 366);
            this.btnTimSP.Name = "btnTimSP";
            this.btnTimSP.Size = new System.Drawing.Size(225, 46);
            this.btnTimSP.TabIndex = 33;
            this.btnTimSP.Text = "Tìm kiếm Sản phẩm";
            this.btnTimSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimSP.UseVisualStyleBackColor = false;
            this.btnTimSP.Click += new System.EventHandler(this.btnTimSP_Click);
            // 
            // btnTimKH
            // 
            this.btnTimKH.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKH.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.btnTimKH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTimKH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTimKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKH.ForeColor = System.Drawing.Color.Lime;
            this.btnTimKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKH.Location = new System.Drawing.Point(42, 218);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(225, 46);
            this.btnTimKH.TabIndex = 32;
            this.btnTimKH.Text = "Tìm kiếm Khách hàng";
            this.btnTimKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKH.UseVisualStyleBackColor = false;
            this.btnTimKH.Click += new System.EventHandler(this.btnTimKH_Click);
            // 
            // btnTimHD
            // 
            this.btnTimHD.BackColor = System.Drawing.Color.Transparent;
            this.btnTimHD.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.btnTimHD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTimHD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTimHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimHD.ForeColor = System.Drawing.Color.Lime;
            this.btnTimHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimHD.Location = new System.Drawing.Point(42, 145);
            this.btnTimHD.Name = "btnTimHD";
            this.btnTimHD.Size = new System.Drawing.Size(225, 46);
            this.btnTimHD.TabIndex = 31;
            this.btnTimHD.Text = "Tìm kiếm Hóa đơn";
            this.btnTimHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimHD.UseVisualStyleBackColor = false;
            this.btnTimHD.Click += new System.EventHandler(this.btnTimHD_Click);
            // 
            // btnTimNV
            // 
            this.btnTimNV.BackColor = System.Drawing.Color.Transparent;
            this.btnTimNV.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.btnTimNV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTimNV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTimNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimNV.ForeColor = System.Drawing.Color.Lime;
            this.btnTimNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimNV.Location = new System.Drawing.Point(42, 291);
            this.btnTimNV.Name = "btnTimNV";
            this.btnTimNV.Size = new System.Drawing.Size(225, 46);
            this.btnTimNV.TabIndex = 30;
            this.btnTimNV.Text = "Tìm kiếm Nhân viên";
            this.btnTimNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimNV.UseVisualStyleBackColor = false;
            this.btnTimNV.Click += new System.EventHandler(this.btnTimNV_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(984, 67);
            this.button2.TabIndex = 38;
            this.button2.Text = "GIAO DIỆN THƯƠNG HIỆU";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(40, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 46);
            this.button1.TabIndex = 36;
            this.button1.Text = "Thoát";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(411, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "VD: HD01 => danh sách hóa đơn";
            // 
            // FrmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1004, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTimKiem;
        private System.Windows.Forms.Button btnTimCTHD;
        private System.Windows.Forms.Button btnTimSP;
        private System.Windows.Forms.Button btnTimKH;
        private System.Windows.Forms.Button btnTimHD;
        private System.Windows.Forms.Button btnTimNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}