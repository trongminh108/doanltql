namespace GUI
{
    partial class Form_ChonMon
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
            this.fpnDSMon = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fpnDSMon
            // 
            this.fpnDSMon.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.fpnDSMon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fpnDSMon.Location = new System.Drawing.Point(0, 69);
            this.fpnDSMon.Name = "fpnDSMon";
            this.fpnDSMon.Size = new System.Drawing.Size(554, 382);
            this.fpnDSMon.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(386, 12);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(156, 40);
            this.btnDong.TabIndex = 15;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // Form_ChonMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 451);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.fpnDSMon);
            this.Name = "Form_ChonMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn món";
            this.Load += new System.EventHandler(this.Form_ChonMon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnDSMon;
        private System.Windows.Forms.Button btnDong;
    }
}