namespace GUI
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.fpnDanhSachBan = new System.Windows.Forms.FlowLayoutPanel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnLocBanTrong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnGopBan = new System.Windows.Forms.Button();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.lblHomeGia = new System.Windows.Forms.Label();
            this.lblIdBan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDoUong = new System.Windows.Forms.ComboBox();
            this.tabCTHD = new System.Windows.Forms.TabPage();
            this.btnChiTietGoHome = new System.Windows.Forms.Button();
            this.btnDoiMon = new System.Windows.Forms.Button();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.nudSoLuong2 = new System.Windows.Forms.NumericUpDown();
            this.btnThem2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.cbDoUong2 = new System.Windows.Forms.ComboBox();
            this.lblHoaDonBan = new System.Windows.Forms.Label();
            this.tabPageBaoCao = new System.Windows.Forms.TabPage();
            this.rpBCTK = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbBCTK = new System.Windows.Forms.ComboBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.rbtnToDate = new System.Windows.Forms.RadioButton();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.rbtnNow = new System.Windows.Forms.RadioButton();
            this.btnXemBC = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageQuanLy = new System.Windows.Forms.TabPage();
            this.pnChildForm = new System.Windows.Forms.Panel();
            this.btnQuanLyGoHome = new System.Windows.Forms.Button();
            this.btnQuanLyTaiKhoan = new System.Windows.Forms.Button();
            this.btnQuanLyDoUong = new System.Windows.Forms.Button();
            this.btnThemBan = new System.Windows.Forms.Button();
            this.lblHello = new System.Windows.Forms.Label();
            this.linkLabelDangXuat = new System.Windows.Forms.LinkLabel();
            this.linkLabelDoiMatKhau = new System.Windows.Forms.LinkLabel();
            this.tabControl.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.tabCTHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.tabPageBaoCao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageQuanLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHome);
            this.tabControl.Controls.Add(this.tabCTHD);
            this.tabControl.Controls.Add(this.tabPageBaoCao);
            this.tabControl.Controls.Add(this.tabPageQuanLy);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(13, 37);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(786, 512);
            this.tabControl.TabIndex = 8;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.fpnDanhSachBan);
            this.tabHome.Controls.Add(this.panelButton);
            this.tabHome.Location = new System.Drawing.Point(4, 25);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(778, 483);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Trang chủ";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // fpnDanhSachBan
            // 
            this.fpnDanhSachBan.AutoScroll = true;
            this.fpnDanhSachBan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fpnDanhSachBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fpnDanhSachBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpnDanhSachBan.Location = new System.Drawing.Point(0, 3);
            this.fpnDanhSachBan.Name = "fpnDanhSachBan";
            this.fpnDanhSachBan.Size = new System.Drawing.Size(387, 466);
            this.fpnDanhSachBan.TabIndex = 2;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnLocBanTrong);
            this.panelButton.Controls.Add(this.btnThoat);
            this.panelButton.Controls.Add(this.btnGopBan);
            this.panelButton.Controls.Add(this.btnChuyenBan);
            this.panelButton.Controls.Add(this.lblHomeGia);
            this.panelButton.Controls.Add(this.lblIdBan);
            this.panelButton.Controls.Add(this.label5);
            this.panelButton.Controls.Add(this.btnThem);
            this.panelButton.Controls.Add(this.btnHoaDon);
            this.panelButton.Controls.Add(this.nudSoLuong);
            this.panelButton.Controls.Add(this.label2);
            this.panelButton.Controls.Add(this.label1);
            this.panelButton.Controls.Add(this.cbDoUong);
            this.panelButton.Location = new System.Drawing.Point(393, 6);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(368, 460);
            this.panelButton.TabIndex = 1;
            // 
            // btnLocBanTrong
            // 
            this.btnLocBanTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocBanTrong.Location = new System.Drawing.Point(21, 381);
            this.btnLocBanTrong.Name = "btnLocBanTrong";
            this.btnLocBanTrong.Size = new System.Drawing.Size(156, 40);
            this.btnLocBanTrong.TabIndex = 23;
            this.btnLocBanTrong.Text = "Bàn trống";
            this.btnLocBanTrong.UseVisualStyleBackColor = true;
            this.btnLocBanTrong.Click += new System.EventHandler(this.btnLocBanTrong_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(198, 381);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(156, 40);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnGopBan
            // 
            this.btnGopBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGopBan.Location = new System.Drawing.Point(198, 315);
            this.btnGopBan.Name = "btnGopBan";
            this.btnGopBan.Size = new System.Drawing.Size(156, 40);
            this.btnGopBan.TabIndex = 21;
            this.btnGopBan.Text = "Gộp bàn";
            this.btnGopBan.UseVisualStyleBackColor = true;
            this.btnGopBan.Click += new System.EventHandler(this.btnGopBan_Click);
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenBan.Location = new System.Drawing.Point(21, 315);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(156, 40);
            this.btnChuyenBan.TabIndex = 20;
            this.btnChuyenBan.Text = "Chuyển bàn";
            this.btnChuyenBan.UseVisualStyleBackColor = true;
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // lblHomeGia
            // 
            this.lblHomeGia.AutoSize = true;
            this.lblHomeGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeGia.Location = new System.Drawing.Point(16, 189);
            this.lblHomeGia.Name = "lblHomeGia";
            this.lblHomeGia.Size = new System.Drawing.Size(81, 25);
            this.lblHomeGia.TabIndex = 19;
            this.lblHomeGia.Text = "Giá: 0đ";
            // 
            // lblIdBan
            // 
            this.lblIdBan.AutoSize = true;
            this.lblIdBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdBan.ForeColor = System.Drawing.Color.Red;
            this.lblIdBan.Location = new System.Drawing.Point(221, 22);
            this.lblIdBan.Name = "lblIdBan";
            this.lblIdBan.Size = new System.Drawing.Size(24, 25);
            this.lblIdBan.TabIndex = 16;
            this.lblIdBan.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Đang chọn bàn số: ";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(21, 245);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(156, 40);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.Location = new System.Drawing.Point(198, 245);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(156, 40);
            this.btnHoaDon.TabIndex = 13;
            this.btnHoaDon.Text = "Hóa đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuong.Location = new System.Drawing.Point(134, 129);
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(220, 31);
            this.nudSoLuong.TabIndex = 12;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.ValueChanged += new System.EventHandler(this.nudSoLuong_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Số lượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Đồ uống:";
            // 
            // cbDoUong
            // 
            this.cbDoUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDoUong.FormattingEnabled = true;
            this.cbDoUong.Location = new System.Drawing.Point(134, 73);
            this.cbDoUong.Name = "cbDoUong";
            this.cbDoUong.Size = new System.Drawing.Size(220, 33);
            this.cbDoUong.TabIndex = 0;
            this.cbDoUong.SelectedIndexChanged += new System.EventHandler(this.cbDoUong_SelectedIndexChanged);
            // 
            // tabCTHD
            // 
            this.tabCTHD.Controls.Add(this.btnChiTietGoHome);
            this.tabCTHD.Controls.Add(this.btnDoiMon);
            this.tabCTHD.Controls.Add(this.btnXoaMon);
            this.tabCTHD.Controls.Add(this.lblGia);
            this.tabCTHD.Controls.Add(this.lblTongTien);
            this.tabCTHD.Controls.Add(this.nudSoLuong2);
            this.tabCTHD.Controls.Add(this.btnThem2);
            this.tabCTHD.Controls.Add(this.label3);
            this.tabCTHD.Controls.Add(this.dgvCTHD);
            this.tabCTHD.Controls.Add(this.label4);
            this.tabCTHD.Controls.Add(this.btnThanhToan);
            this.tabCTHD.Controls.Add(this.cbDoUong2);
            this.tabCTHD.Controls.Add(this.lblHoaDonBan);
            this.tabCTHD.Location = new System.Drawing.Point(4, 25);
            this.tabCTHD.Name = "tabCTHD";
            this.tabCTHD.Padding = new System.Windows.Forms.Padding(3);
            this.tabCTHD.Size = new System.Drawing.Size(778, 483);
            this.tabCTHD.TabIndex = 1;
            this.tabCTHD.Text = "Chi tiết hóa đơn";
            this.tabCTHD.UseVisualStyleBackColor = true;
            // 
            // btnChiTietGoHome
            // 
            this.btnChiTietGoHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietGoHome.Location = new System.Drawing.Point(588, 338);
            this.btnChiTietGoHome.Name = "btnChiTietGoHome";
            this.btnChiTietGoHome.Size = new System.Drawing.Size(156, 40);
            this.btnChiTietGoHome.TabIndex = 21;
            this.btnChiTietGoHome.Text = "Trang chủ";
            this.btnChiTietGoHome.UseVisualStyleBackColor = true;
            this.btnChiTietGoHome.Click += new System.EventHandler(this.btnChiTietGoHome_Click);
            // 
            // btnDoiMon
            // 
            this.btnDoiMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMon.Location = new System.Drawing.Point(588, 272);
            this.btnDoiMon.Name = "btnDoiMon";
            this.btnDoiMon.Size = new System.Drawing.Size(156, 40);
            this.btnDoiMon.TabIndex = 20;
            this.btnDoiMon.Text = "Đổi món";
            this.btnDoiMon.UseVisualStyleBackColor = true;
            this.btnDoiMon.Click += new System.EventHandler(this.btnDoiMon_Click);
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMon.Location = new System.Drawing.Point(411, 272);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(156, 40);
            this.btnXoaMon.TabIndex = 19;
            this.btnXoaMon.Text = "Xóa món";
            this.btnXoaMon.UseVisualStyleBackColor = true;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(406, 148);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(81, 25);
            this.lblGia.TabIndex = 18;
            this.lblGia.Text = "Giá: 0đ";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(173, 446);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(205, 20);
            this.lblTongTien.TabIndex = 17;
            this.lblTongTien.Text = "Tổng tiền";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudSoLuong2
            // 
            this.nudSoLuong2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuong2.Location = new System.Drawing.Point(524, 98);
            this.nudSoLuong2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong2.Name = "nudSoLuong2";
            this.nudSoLuong2.Size = new System.Drawing.Size(220, 31);
            this.nudSoLuong2.TabIndex = 16;
            this.nudSoLuong2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong2.ValueChanged += new System.EventHandler(this.mudSoLuong2_ValueChanged);
            // 
            // btnThem2
            // 
            this.btnThem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem2.Location = new System.Drawing.Point(411, 208);
            this.btnThem2.Name = "btnThem2";
            this.btnThem2.Size = new System.Drawing.Size(156, 40);
            this.btnThem2.TabIndex = 16;
            this.btnThem2.Text = "Thêm";
            this.btnThem2.UseVisualStyleBackColor = true;
            this.btnThem2.Click += new System.EventHandler(this.btnThem2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Số lượng:";
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Location = new System.Drawing.Point(6, 45);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.Size = new System.Drawing.Size(372, 389);
            this.dgvCTHD.TabIndex = 11;
            this.dgvCTHD.Click += new System.EventHandler(this.dgvCTHD_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(406, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Đồ uống:";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(588, 208);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(156, 40);
            this.btnThanhToan.TabIndex = 15;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // cbDoUong2
            // 
            this.cbDoUong2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDoUong2.FormattingEnabled = true;
            this.cbDoUong2.Location = new System.Drawing.Point(524, 45);
            this.cbDoUong2.Name = "cbDoUong2";
            this.cbDoUong2.Size = new System.Drawing.Size(220, 33);
            this.cbDoUong2.TabIndex = 13;
            this.cbDoUong2.SelectedIndexChanged += new System.EventHandler(this.cbDoUong2_SelectedIndexChanged);
            // 
            // lblHoaDonBan
            // 
            this.lblHoaDonBan.AutoSize = true;
            this.lblHoaDonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDonBan.Location = new System.Drawing.Point(6, 22);
            this.lblHoaDonBan.Name = "lblHoaDonBan";
            this.lblHoaDonBan.Size = new System.Drawing.Size(70, 20);
            this.lblHoaDonBan.TabIndex = 10;
            this.lblHoaDonBan.Text = "Hóa đơn";
            // 
            // tabPageBaoCao
            // 
            this.tabPageBaoCao.Controls.Add(this.rpBCTK);
            this.tabPageBaoCao.Controls.Add(this.groupBox1);
            this.tabPageBaoCao.Location = new System.Drawing.Point(4, 25);
            this.tabPageBaoCao.Name = "tabPageBaoCao";
            this.tabPageBaoCao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBaoCao.Size = new System.Drawing.Size(778, 483);
            this.tabPageBaoCao.TabIndex = 2;
            this.tabPageBaoCao.Text = "Báo cáo thống kê";
            this.tabPageBaoCao.UseVisualStyleBackColor = true;
            // 
            // rpBCTK
            // 
            this.rpBCTK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rpBCTK.Location = new System.Drawing.Point(3, 103);
            this.rpBCTK.Name = "rpBCTK";
            this.rpBCTK.ServerReport.BearerToken = null;
            this.rpBCTK.Size = new System.Drawing.Size(772, 377);
            this.rpBCTK.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBCTK);
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.Controls.Add(this.rbtnToDate);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Controls.Add(this.rbtnNow);
            this.groupBox1.Controls.Add(this.btnXemBC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo cáo";
            // 
            // cbBCTK
            // 
            this.cbBCTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBCTK.FormattingEnabled = true;
            this.cbBCTK.Items.AddRange(new object[] {
            "Hóa đơn",
            "Đồ uống"});
            this.cbBCTK.Location = new System.Drawing.Point(76, 0);
            this.cbBCTK.Name = "cbBCTK";
            this.cbBCTK.Size = new System.Drawing.Size(160, 33);
            this.cbBCTK.TabIndex = 6;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpToDate.Enabled = false;
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(531, 46);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(110, 26);
            this.dtpToDate.TabIndex = 5;
            this.dtpToDate.Value = new System.DateTime(2023, 5, 29, 0, 0, 0, 0);
            // 
            // rbtnToDate
            // 
            this.rbtnToDate.AutoSize = true;
            this.rbtnToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnToDate.Location = new System.Drawing.Point(371, 47);
            this.rbtnToDate.Name = "rbtnToDate";
            this.rbtnToDate.Size = new System.Drawing.Size(144, 24);
            this.rbtnToDate.TabIndex = 4;
            this.rbtnToDate.Text = "hoặc đến ngày";
            this.rbtnToDate.UseVisualStyleBackColor = true;
            this.rbtnToDate.CheckedChanged += new System.EventHandler(this.rbtnToDate_CheckedChanged);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(108, 46);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(110, 26);
            this.dtpFromDate.TabIndex = 3;
            this.dtpFromDate.Value = new System.DateTime(2002, 1, 8, 0, 0, 0, 0);
            // 
            // rbtnNow
            // 
            this.rbtnNow.AutoSize = true;
            this.rbtnNow.Checked = true;
            this.rbtnNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNow.Location = new System.Drawing.Point(234, 47);
            this.rbtnNow.Name = "rbtnNow";
            this.rbtnNow.Size = new System.Drawing.Size(121, 24);
            this.rbtnNow.TabIndex = 2;
            this.rbtnNow.TabStop = true;
            this.rbtnNow.Text = "đến hiện tại";
            this.rbtnNow.UseVisualStyleBackColor = true;
            this.rbtnNow.CheckedChanged += new System.EventHandler(this.rbtnNow_CheckedChanged);
            // 
            // btnXemBC
            // 
            this.btnXemBC.Location = new System.Drawing.Point(657, 42);
            this.btnXemBC.Name = "btnXemBC";
            this.btnXemBC.Size = new System.Drawing.Size(75, 34);
            this.btnXemBC.TabIndex = 1;
            this.btnXemBC.Text = "Xem";
            this.btnXemBC.UseVisualStyleBackColor = true;
            this.btnXemBC.Click += new System.EventHandler(this.btnXemBC_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Từ ngày:";
            // 
            // tabPageQuanLy
            // 
            this.tabPageQuanLy.Controls.Add(this.pnChildForm);
            this.tabPageQuanLy.Controls.Add(this.btnQuanLyGoHome);
            this.tabPageQuanLy.Controls.Add(this.btnQuanLyTaiKhoan);
            this.tabPageQuanLy.Controls.Add(this.btnQuanLyDoUong);
            this.tabPageQuanLy.Controls.Add(this.btnThemBan);
            this.tabPageQuanLy.Location = new System.Drawing.Point(4, 25);
            this.tabPageQuanLy.Name = "tabPageQuanLy";
            this.tabPageQuanLy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuanLy.Size = new System.Drawing.Size(778, 483);
            this.tabPageQuanLy.TabIndex = 3;
            this.tabPageQuanLy.Text = "Quản lý";
            this.tabPageQuanLy.UseVisualStyleBackColor = true;
            // 
            // pnChildForm
            // 
            this.pnChildForm.Location = new System.Drawing.Point(4, 53);
            this.pnChildForm.Name = "pnChildForm";
            this.pnChildForm.Size = new System.Drawing.Size(758, 424);
            this.pnChildForm.TabIndex = 21;
            // 
            // btnQuanLyGoHome
            // 
            this.btnQuanLyGoHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyGoHome.Location = new System.Drawing.Point(606, 6);
            this.btnQuanLyGoHome.Name = "btnQuanLyGoHome";
            this.btnQuanLyGoHome.Size = new System.Drawing.Size(156, 40);
            this.btnQuanLyGoHome.TabIndex = 20;
            this.btnQuanLyGoHome.Text = "Trang chủ";
            this.btnQuanLyGoHome.UseVisualStyleBackColor = true;
            this.btnQuanLyGoHome.Click += new System.EventHandler(this.btnQuanLyGoHome_Click);
            // 
            // btnQuanLyTaiKhoan
            // 
            this.btnQuanLyTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyTaiKhoan.Location = new System.Drawing.Point(406, 6);
            this.btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            this.btnQuanLyTaiKhoan.Size = new System.Drawing.Size(156, 40);
            this.btnQuanLyTaiKhoan.TabIndex = 19;
            this.btnQuanLyTaiKhoan.Text = "Tài Khoản";
            this.btnQuanLyTaiKhoan.UseVisualStyleBackColor = true;
            this.btnQuanLyTaiKhoan.Click += new System.EventHandler(this.btnQuanLyTaiKhoan_Click);
            // 
            // btnQuanLyDoUong
            // 
            this.btnQuanLyDoUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyDoUong.Location = new System.Drawing.Point(206, 6);
            this.btnQuanLyDoUong.Name = "btnQuanLyDoUong";
            this.btnQuanLyDoUong.Size = new System.Drawing.Size(156, 40);
            this.btnQuanLyDoUong.TabIndex = 18;
            this.btnQuanLyDoUong.Text = "Đồ uống";
            this.btnQuanLyDoUong.UseVisualStyleBackColor = true;
            this.btnQuanLyDoUong.Click += new System.EventHandler(this.btnQuanLyDoUong_Click);
            // 
            // btnThemBan
            // 
            this.btnThemBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemBan.Location = new System.Drawing.Point(6, 6);
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.Size = new System.Drawing.Size(156, 40);
            this.btnThemBan.TabIndex = 17;
            this.btnThemBan.Text = "Thêm Bàn";
            this.btnThemBan.UseVisualStyleBackColor = true;
            this.btnThemBan.Click += new System.EventHandler(this.btnThemBan_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(12, 9);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(163, 25);
            this.lblHello.TabIndex = 9;
            this.lblHello.Text = "Tên đăng nhập:";
            // 
            // linkLabelDangXuat
            // 
            this.linkLabelDangXuat.AutoSize = true;
            this.linkLabelDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelDangXuat.Location = new System.Drawing.Point(685, 9);
            this.linkLabelDangXuat.Name = "linkLabelDangXuat";
            this.linkLabelDangXuat.Size = new System.Drawing.Size(110, 25);
            this.linkLabelDangXuat.TabIndex = 10;
            this.linkLabelDangXuat.TabStop = true;
            this.linkLabelDangXuat.Text = "Đăng xuất";
            this.linkLabelDangXuat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDangXuat_LinkClicked);
            // 
            // linkLabelDoiMatKhau
            // 
            this.linkLabelDoiMatKhau.AutoSize = true;
            this.linkLabelDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelDoiMatKhau.Location = new System.Drawing.Point(541, 9);
            this.linkLabelDoiMatKhau.Name = "linkLabelDoiMatKhau";
            this.linkLabelDoiMatKhau.Size = new System.Drawing.Size(138, 25);
            this.linkLabelDoiMatKhau.TabIndex = 11;
            this.linkLabelDoiMatKhau.TabStop = true;
            this.linkLabelDoiMatKhau.Text = "Đổi mật khẩu";
            this.linkLabelDoiMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDoiMatKhau_LinkClicked);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.logqlcafe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.linkLabelDoiMatKhau);
            this.Controls.Add(this.linkLabelDangXuat);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.tabControl.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.panelButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.tabCTHD.ResumeLayout(false);
            this.tabCTHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.tabPageBaoCao.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageQuanLy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabCTHD;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDoUong;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.FlowLayoutPanel fpnDanhSachBan;
        private System.Windows.Forms.Label lblHoaDonBan;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.NumericUpDown nudSoLuong2;
        private System.Windows.Forms.Button btnThem2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.ComboBox cbDoUong2;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblIdBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHomeGia;
        private System.Windows.Forms.Button btnDoiMon;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.Button btnGopBan;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.TabPage tabPageBaoCao;
        private System.Windows.Forms.TabPage tabPageQuanLy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnChiTietGoHome;
        private System.Windows.Forms.Panel pnChildForm;
        private System.Windows.Forms.Button btnQuanLyGoHome;
        private System.Windows.Forms.Button btnQuanLyTaiKhoan;
        private System.Windows.Forms.Button btnQuanLyDoUong;
        private System.Windows.Forms.Button btnThemBan;
        private System.Windows.Forms.LinkLabel linkLabelDangXuat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.RadioButton rbtnToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.RadioButton rbtnNow;
        private System.Windows.Forms.Button btnXemBC;
        private System.Windows.Forms.Label label6;
        private Microsoft.Reporting.WinForms.ReportViewer rpBCTK;
        private System.Windows.Forms.ComboBox cbBCTK;
        private System.Windows.Forms.Button btnLocBanTrong;
        private System.Windows.Forms.LinkLabel linkLabelDoiMatKhau;
    }
}