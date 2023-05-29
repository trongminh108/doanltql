namespace GUI
{
    partial class Form_QuanLyBan
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
            this.fpnDanhSachBan = new System.Windows.Forms.FlowLayoutPanel();
            this.btnXoaBan = new System.Windows.Forms.Button();
            this.btnSuaBan = new System.Windows.Forms.Button();
            this.btnThemBan = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // fpnDanhSachBan
            // 
            this.fpnDanhSachBan.AutoScroll = true;
            this.fpnDanhSachBan.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.fpnDanhSachBan.Location = new System.Drawing.Point(12, 12);
            this.fpnDanhSachBan.Name = "fpnDanhSachBan";
            this.fpnDanhSachBan.Size = new System.Drawing.Size(287, 347);
            this.fpnDanhSachBan.TabIndex = 0;
            // 
            // btnXoaBan
            // 
            this.btnXoaBan.AutoSize = true;
            this.btnXoaBan.BackColor = System.Drawing.Color.White;
            this.btnXoaBan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaBan.Image = global::GUI.Properties.Resources.deleteIcon;
            this.btnXoaBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaBan.Location = new System.Drawing.Point(320, 75);
            this.btnXoaBan.Name = "btnXoaBan";
            this.btnXoaBan.Size = new System.Drawing.Size(133, 56);
            this.btnXoaBan.TabIndex = 17;
            this.btnXoaBan.Text = "Xóa";
            this.btnXoaBan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaBan.UseVisualStyleBackColor = false;
            this.btnXoaBan.Click += new System.EventHandler(this.btnXoaBan_Click);
            // 
            // btnSuaBan
            // 
            this.btnSuaBan.AutoSize = true;
            this.btnSuaBan.BackColor = System.Drawing.Color.White;
            this.btnSuaBan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaBan.Image = global::GUI.Properties.Resources.editIcon;
            this.btnSuaBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaBan.Location = new System.Drawing.Point(320, 137);
            this.btnSuaBan.Name = "btnSuaBan";
            this.btnSuaBan.Size = new System.Drawing.Size(133, 56);
            this.btnSuaBan.TabIndex = 16;
            this.btnSuaBan.Text = "Sửa";
            this.btnSuaBan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaBan.UseVisualStyleBackColor = false;
            this.btnSuaBan.Visible = false;
            // 
            // btnThemBan
            // 
            this.btnThemBan.AutoSize = true;
            this.btnThemBan.BackColor = System.Drawing.Color.White;
            this.btnThemBan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThemBan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnThemBan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemBan.Image = global::GUI.Properties.Resources.addIcon_removebg_preview;
            this.btnThemBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemBan.Location = new System.Drawing.Point(320, 13);
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.Size = new System.Drawing.Size(133, 56);
            this.btnThemBan.TabIndex = 15;
            this.btnThemBan.Text = "Thêm";
            this.btnThemBan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemBan.UseVisualStyleBackColor = false;
            this.btnThemBan.Click += new System.EventHandler(this.btnThemBan_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(320, 137);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(243, 194);
            this.dgvHoaDon.TabIndex = 18;
            // 
            // Form_QuanLyBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 371);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.btnXoaBan);
            this.Controls.Add(this.btnSuaBan);
            this.Controls.Add(this.btnThemBan);
            this.Controls.Add(this.fpnDanhSachBan);
            this.Name = "Form_QuanLyBan";
            this.Text = "Form_QuanLyBan";
            this.Load += new System.EventHandler(this.Form_QuanLyBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnDanhSachBan;
        private System.Windows.Forms.Button btnXoaBan;
        private System.Windows.Forms.Button btnSuaBan;
        private System.Windows.Forms.Button btnThemBan;
        private System.Windows.Forms.DataGridView dgvHoaDon;
    }
}