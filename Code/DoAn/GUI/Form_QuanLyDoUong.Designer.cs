namespace GUI
{
    partial class Form_QuanLyDoUong
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
            this.dgvTU = new System.Windows.Forms.DataGridView();
            this.txtTenTU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDonGiaTU = new System.Windows.Forms.TextBox();
            this.btnXoaTU = new System.Windows.Forms.Button();
            this.btnSuaTU = new System.Windows.Forms.Button();
            this.btnThemTU = new System.Windows.Forms.Button();
            this.lblTongDoUong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimTU = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTU)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTU
            // 
            this.dgvTU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTU.Location = new System.Drawing.Point(12, 12);
            this.dgvTU.Name = "dgvTU";
            this.dgvTU.Size = new System.Drawing.Size(219, 283);
            this.dgvTU.TabIndex = 0;
            this.dgvTU.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTU_CellClick);
            // 
            // txtTenTU
            // 
            this.txtTenTU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTU.Location = new System.Drawing.Point(388, 12);
            this.txtTenTU.Name = "txtTenTU";
            this.txtTenTU.Size = new System.Drawing.Size(146, 31);
            this.txtTenTU.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên đồ uống:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Đơn giá:";
            // 
            // txtDonGiaTU
            // 
            this.txtDonGiaTU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGiaTU.Location = new System.Drawing.Point(388, 52);
            this.txtDonGiaTU.Name = "txtDonGiaTU";
            this.txtDonGiaTU.Size = new System.Drawing.Size(146, 31);
            this.txtDonGiaTU.TabIndex = 4;
            // 
            // btnXoaTU
            // 
            this.btnXoaTU.AutoSize = true;
            this.btnXoaTU.BackColor = System.Drawing.Color.White;
            this.btnXoaTU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaTU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTU.Image = global::GUI.Properties.Resources.deleteIcon;
            this.btnXoaTU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaTU.Location = new System.Drawing.Point(350, 253);
            this.btnXoaTU.Name = "btnXoaTU";
            this.btnXoaTU.Size = new System.Drawing.Size(184, 56);
            this.btnXoaTU.TabIndex = 8;
            this.btnXoaTU.Text = "Xóa đồ uống";
            this.btnXoaTU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaTU.UseVisualStyleBackColor = false;
            this.btnXoaTU.Click += new System.EventHandler(this.btnXoaTU_Click);
            // 
            // btnSuaTU
            // 
            this.btnSuaTU.AutoSize = true;
            this.btnSuaTU.BackColor = System.Drawing.Color.White;
            this.btnSuaTU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuaTU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTU.Image = global::GUI.Properties.Resources.editIcon;
            this.btnSuaTU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaTU.Location = new System.Drawing.Point(350, 191);
            this.btnSuaTU.Name = "btnSuaTU";
            this.btnSuaTU.Size = new System.Drawing.Size(184, 56);
            this.btnSuaTU.TabIndex = 7;
            this.btnSuaTU.Text = "Sửa đồ uống";
            this.btnSuaTU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaTU.UseVisualStyleBackColor = false;
            this.btnSuaTU.Click += new System.EventHandler(this.btnSuaTU_Click);
            // 
            // btnThemTU
            // 
            this.btnThemTU.AutoSize = true;
            this.btnThemTU.BackColor = System.Drawing.Color.White;
            this.btnThemTU.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThemTU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnThemTU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemTU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTU.Image = global::GUI.Properties.Resources.addIcon_removebg_preview;
            this.btnThemTU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemTU.Location = new System.Drawing.Point(350, 129);
            this.btnThemTU.Name = "btnThemTU";
            this.btnThemTU.Size = new System.Drawing.Size(184, 56);
            this.btnThemTU.TabIndex = 6;
            this.btnThemTU.Text = "Thêm đồ uống";
            this.btnThemTU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemTU.UseVisualStyleBackColor = false;
            this.btnThemTU.Click += new System.EventHandler(this.btnThemTU_Click);
            // 
            // lblTongDoUong
            // 
            this.lblTongDoUong.AutoSize = true;
            this.lblTongDoUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoUong.Location = new System.Drawing.Point(12, 311);
            this.lblTongDoUong.Name = "lblTongDoUong";
            this.lblTongDoUong.Size = new System.Drawing.Size(139, 25);
            this.lblTongDoUong.TabIndex = 9;
            this.lblTongDoUong.Text = "Tên đồ uống:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tìm đồ uống:";
            // 
            // txtTimTU
            // 
            this.txtTimTU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTU.Location = new System.Drawing.Point(388, 92);
            this.txtTimTU.Name = "txtTimTU";
            this.txtTimTU.Size = new System.Drawing.Size(146, 31);
            this.txtTimTU.TabIndex = 10;
            this.txtTimTU.TextChanged += new System.EventHandler(this.txtTimTU_TextChanged);
            this.txtTimTU.Enter += new System.EventHandler(this.txtTimTU_Enter);
            this.txtTimTU.Leave += new System.EventHandler(this.txtTimTU_Leave);
            // 
            // Form_QuanLyDoUong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 385);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTimTU);
            this.Controls.Add(this.lblTongDoUong);
            this.Controls.Add(this.btnXoaTU);
            this.Controls.Add(this.btnSuaTU);
            this.Controls.Add(this.btnThemTU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDonGiaTU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenTU);
            this.Controls.Add(this.dgvTU);
            this.Name = "Form_QuanLyDoUong";
            this.Text = "Form_QuanLyDoUong";
            this.Load += new System.EventHandler(this.Form_QuanLyDoUong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTU;
        private System.Windows.Forms.TextBox txtTenTU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDonGiaTU;
        private System.Windows.Forms.Button btnThemTU;
        private System.Windows.Forms.Button btnSuaTU;
        private System.Windows.Forms.Button btnXoaTU;
        private System.Windows.Forms.Label lblTongDoUong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimTU;
    }
}