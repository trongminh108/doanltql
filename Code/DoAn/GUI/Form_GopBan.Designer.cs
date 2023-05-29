namespace GUI
{
    partial class Form_GopBan
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGop = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblGopBan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fpnDanhSachBan
            // 
            this.fpnDanhSachBan.AutoScroll = true;
            this.fpnDanhSachBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpnDanhSachBan.Location = new System.Drawing.Point(12, 49);
            this.fpnDanhSachBan.Name = "fpnDanhSachBan";
            this.fpnDanhSachBan.Size = new System.Drawing.Size(347, 366);
            this.fpnDanhSachBan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách bàn";
            // 
            // btnGop
            // 
            this.btnGop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGop.Location = new System.Drawing.Point(384, 96);
            this.btnGop.Name = "btnGop";
            this.btnGop.Size = new System.Drawing.Size(156, 40);
            this.btnGop.TabIndex = 15;
            this.btnGop.Text = "Gộp";
            this.btnGop.UseVisualStyleBackColor = true;
            this.btnGop.Click += new System.EventHandler(this.btnGop_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(384, 160);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(156, 40);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblGopBan
            // 
            this.lblGopBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGopBan.Location = new System.Drawing.Point(12, 381);
            this.lblGopBan.Name = "lblGopBan";
            this.lblGopBan.Size = new System.Drawing.Size(560, 25);
            this.lblGopBan.TabIndex = 17;
            this.lblGopBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_GopBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 427);
            this.Controls.Add(this.lblGopBan);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnGop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fpnDanhSachBan);
            this.Name = "Form_GopBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gộp bàn";
            this.Load += new System.EventHandler(this.Form_GopBan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnDanhSachBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGop;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblGopBan;
    }
}