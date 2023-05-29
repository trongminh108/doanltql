namespace GUI
{
    partial class Form_QuanLyNhanVien
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
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.btnXoaTK = new System.Windows.Forms.Button();
            this.btnSuaTK = new System.Windows.Forms.Button();
            this.btnThemTK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenHienThi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudQuyen = new System.Windows.Forms.NumericUpDown();
            this.lblTenQuyen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(0, 223);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.Size = new System.Drawing.Size(603, 148);
            this.dgvTaiKhoan.TabIndex = 0;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên đăng nhập:";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(169, 6);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(118, 31);
            this.txtTenDangNhap.TabIndex = 15;
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.AutoSize = true;
            this.btnXoaTK.BackColor = System.Drawing.Color.White;
            this.btnXoaTK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTK.Image = global::GUI.Properties.Resources.deleteIcon;
            this.btnXoaTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaTK.Location = new System.Drawing.Point(419, 68);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(133, 56);
            this.btnXoaTK.TabIndex = 14;
            this.btnXoaTK.Text = "Xóa";
            this.btnXoaTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaTK.UseVisualStyleBackColor = false;
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // btnSuaTK
            // 
            this.btnSuaTK.AutoSize = true;
            this.btnSuaTK.BackColor = System.Drawing.Color.White;
            this.btnSuaTK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTK.Image = global::GUI.Properties.Resources.editIcon;
            this.btnSuaTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaTK.Location = new System.Drawing.Point(419, 130);
            this.btnSuaTK.Name = "btnSuaTK";
            this.btnSuaTK.Size = new System.Drawing.Size(133, 56);
            this.btnSuaTK.TabIndex = 13;
            this.btnSuaTK.Text = "Sửa";
            this.btnSuaTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaTK.UseVisualStyleBackColor = false;
            this.btnSuaTK.Click += new System.EventHandler(this.btnSuaTK_Click);
            // 
            // btnThemTK
            // 
            this.btnThemTK.AutoSize = true;
            this.btnThemTK.BackColor = System.Drawing.Color.White;
            this.btnThemTK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThemTK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnThemTK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTK.Image = global::GUI.Properties.Resources.addIcon_removebg_preview;
            this.btnThemTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemTK.Location = new System.Drawing.Point(419, 6);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(133, 56);
            this.btnThemTK.TabIndex = 12;
            this.btnThemTK.Text = "Thêm";
            this.btnThemTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemTK.UseVisualStyleBackColor = false;
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(169, 55);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(118, 31);
            this.txtMatKhau.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên hiển thị:";
            // 
            // txtTenHienThi
            // 
            this.txtTenHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHienThi.Location = new System.Drawing.Point(169, 104);
            this.txtTenHienThi.Name = "txtTenHienThi";
            this.txtTenHienThi.Size = new System.Drawing.Size(118, 31);
            this.txtTenHienThi.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Quyền";
            // 
            // nudQuyen
            // 
            this.nudQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuyen.Location = new System.Drawing.Point(169, 154);
            this.nudQuyen.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudQuyen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuyen.Name = "nudQuyen";
            this.nudQuyen.Size = new System.Drawing.Size(118, 31);
            this.nudQuyen.TabIndex = 23;
            this.nudQuyen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuyen.ValueChanged += new System.EventHandler(this.nudQuyen_ValueChanged);
            // 
            // lblTenQuyen
            // 
            this.lblTenQuyen.AutoSize = true;
            this.lblTenQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenQuyen.Location = new System.Drawing.Point(293, 156);
            this.lblTenQuyen.Name = "lblTenQuyen";
            this.lblTenQuyen.Size = new System.Drawing.Size(86, 25);
            this.lblTenQuyen.TabIndex = 24;
            this.lblTenQuyen.Text = "Quản lý";
            // 
            // Form_QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(638, 371);
            this.Controls.Add(this.lblTenQuyen);
            this.Controls.Add(this.nudQuyen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenHienThi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.btnXoaTK);
            this.Controls.Add(this.btnSuaTK);
            this.Controls.Add(this.btnThemTK);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Name = "Form_QuanLyNhanVien";
            this.Text = "Form_QuanLyNhanVien";
            this.Load += new System.EventHandler(this.Form_QuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Button btnXoaTK;
        private System.Windows.Forms.Button btnSuaTK;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenHienThi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudQuyen;
        private System.Windows.Forms.Label lblTenQuyen;
    }
}