using BUS;
using DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GUI
{
    public partial class Form_Main : Form
    {
        TaiKhoan_DTO tk;
        int tableWidth = 100;
        int tableHeight = 100;
        int idBan = 1;
        int idHoaDon = -1;
        int idDoUongCu = -1;
        List<Ban_DTO> lstBan;
        List<ChiTietHoaDon_DTO> lstCTHD;
        bool isAll = true;
        List<List<int>> lstBanGop = new List<List<int>>();

        public Form_Main(TaiKhoan_DTO tk)
        {
            InitializeComponent();
            this.tk = tk;
            lblHello.Text = "Xin chào, " + tk.DisplayName;
        }        

        public void HienThiDoUong()
        {
            List<DoUong_DTO> lstDoUong = DoUong_BUS.LayDoUong();
            cbDoUong.DataSource = lstDoUong;
            cbDoUong.DisplayMember = "Name";
            cbDoUong.ValueMember = "Id";
            cbDoUong.SelectedIndex = 0;

            cbDoUong2.DataSource = lstDoUong;
            cbDoUong2.DisplayMember = "Name";
            cbDoUong2.ValueMember = "Id";
            cbDoUong2.SelectedIndex = 0;
            HienThiBan();
            HienThiGia();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            HienThiDoUong();
            this.rpBCTK.RefreshReport();
        }

        public void HienThiBan()
        {
            fpnDanhSachBan.Controls.Clear();
            lstBan = Ban_BUS.LayBan();
            foreach(Ban_DTO ban in lstBan)
            {
                string status = ban.Status ? "Có người" : "Trống";
                Button btn = new Button() { Width = tableWidth, Height = tableHeight };
                btn.Text = "Bàn " + ban.Id + Environment.NewLine + status;
                btn.Tag = ban;
                btn.Click += new System.EventHandler(this.btnBan_Click);
                if (ban.Status)
                {
                    btn.BackColor = Color.Aqua;
                    btn.TextAlign = ContentAlignment.TopCenter;
                    btn.BackgroundImage = Properties.Resources.FullTableIcon;
                    btn.Font = new Font(btn.Font, FontStyle.Bold);
                }
                fpnDanhSachBan.Controls.Add(btn);
                if (lstBanGop.Count != 0)
                {
                    for (int i = 0; i < lstBanGop.Count; i++)
                    {
                        List<int> cap = lstBanGop[i];
                        if (cap[1] == ban.Id)
                        {
                            btn.Text = "Bàn " + ban.Id
                                + Environment.NewLine + "Gộp với " + cap[0];
                            btn.BackColor = Color.LimeGreen;
                        }
                    }
                }
            }
            isAll = true;
            btnLocBanTrong.Text = "Bàn trống";
        }

        public void HienThiChiTietHoaDon(int idHD)
        {
            lstCTHD = ThongTinHoaDon_BUS.LayChiTietHD(idHD);
            string total = "0";
            if (lstCTHD != null)
            {
                dgvCTHD.DataSource = lstCTHD;
                dgvCTHD.ReadOnly = true;
                dgvCTHD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvCTHD.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCTHD.ColumnHeadersDefaultCellStyle.Font = new Font(dgvCTHD.Font, FontStyle.Bold); // Make header text bold
                string[] names = { "Đồ uống", "Số lượng", "Đơn giá" };
                double[] widths = { 0.4, 0.2, 0.3 };
                int width = dgvCTHD.Width;
                int i = 0;
                foreach (DataGridViewColumn col in dgvCTHD.Columns)
                {
                    col.HeaderText = names[i];
                    col.Width = (int)(widths[i] * width);
                    i += 1;
                }
                total = Functions.TinhTongTien(lstCTHD).ToString("#,###");
            }
            else
            {
                dgvCTHD.DataSource = null;
            }
            
            lblTongTien.Text = "Tổng tiền: " + total + "vnđ";
        }

        public void HienThiGia()
        {
            try
            {
                int id = int.Parse(cbDoUong2.SelectedValue.ToString());
                lblGia.Text = "Giá: " + DoUong_BUS.getGia(id) * nudSoLuong2.Value + "vnđ";
                id = int.Parse(cbDoUong.SelectedValue.ToString());
                lblHomeGia.Text = "Giá: " + DoUong_BUS.getGia(id) * nudSoLuong.Value + "vnđ";
            }
            catch
            {

            }
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            if (idBan != -1)
            {
                idHoaDon = HoaDon_BUS.LayIDHoaDon(idBan);
                if (idHoaDon != -1)
                {
                    tabControl.SelectedIndex = 1;
                    HienThiChiTietHoaDon(idHoaDon);
                    lblHoaDonBan.Text = "Hóa đơn bàn " + idBan;
                    HienThiGia();
                }
                else
                {
                    if (lstBan[idBan-1].Status)
                        MessageBox.Show("Bàn này đã gộp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Bàn này đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            idBan = ((sender as Button).Tag as Ban_DTO).Id;
            idHoaDon = HoaDon_BUS.LayIDHoaDon(idBan);
            lblIdBan.Text = idBan + "";
            foreach (Control control in fpnDanhSachBan.Controls)
            {
                (control as Button).BackColor = Color.White;
                if (((control as Button).Tag as Ban_DTO).Status)
                    control.BackColor = Color.Aqua;
                Button btn = (Button)control;
                Ban_DTO ban = btn.Tag as Ban_DTO;
                if (lstBanGop.Count != 0)
                {
                    for (int i = 0; i < lstBanGop.Count; i++)
                    {
                        List<int> cap = lstBanGop[i];
                        if (cap[1] == ban.Id)
                        {
                            btn.Text = "Bàn " + ban.Id
                                + Environment.NewLine + "Gộp với " + cap[0];
                            btn.BackColor = Color.LimeGreen;
                        }
                    }
                }
            }
            (sender as Button).BackColor = Color.Yellow;
            if (idHoaDon == -1 && ((sender as Button).Tag as Ban_DTO).Status)
            {
                btnThem.Enabled = false;
            }
            else
                btnThem.Enabled = true;
        }

        private void cbDoUong_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbDoUong2_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudSoLuong2.Value = 1;
            HienThiGia();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (lstBan[idBan - 1].Status)
            {
                tabControl.SelectedIndex = 1;
            }
            else
            {
                Ban_BUS.ThanhToanBan(idBan, 1);
                HoaDon_BUS.ThemHoaDon(idBan, 0);
            }
            idHoaDon = HoaDon_BUS.LayIDHoaDon(idBan);
            ThongTinHoaDon_DTO tthd = new ThongTinHoaDon_DTO();
            tthd.IdBill = idHoaDon;
            tthd.IdDrink = int.Parse(cbDoUong.SelectedValue + "");
            tthd.Quantity = int.Parse(nudSoLuong.Value + "");
            ThongTinHoaDon_BUS.ThemThongTinHoaDon(tthd);
            HienThiBan();
            HienThiChiTietHoaDon(idHoaDon);
        }

        private void btnThem2_Click(object sender, EventArgs e)
        {
            ThongTinHoaDon_DTO tthd = new ThongTinHoaDon_DTO();
            tthd.IdBill = idHoaDon;
            tthd.IdDrink = int.Parse(cbDoUong2.SelectedValue+"");
            tthd.Quantity = int.Parse(nudSoLuong2.Value+"");
            ThongTinHoaDon_BUS.ThemThongTinHoaDon(tthd);
            HienThiChiTietHoaDon(idHoaDon);
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            HienThiGia();
        }

        private void mudSoLuong2_ValueChanged(object sender, EventArgs e)
        {
            HienThiGia();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Bạn muốn thanh toán hóa đơn bàn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            DateTime billDate = DateTime.Now;
            if (answer == DialogResult.Yes)
            {
                List<InCTHD> lstInCTHD = new List<InCTHD>();
                foreach (ChiTietHoaDon_DTO cthd in lstCTHD)
                {
                    lstInCTHD.Add(new InCTHD(idHoaDon, billDate, idBan, cthd));
                }
                new Form_ChiTietHoaDon(lstInCTHD).ShowDialog();
                FormQRCode.text = 
                    "Thanh toán: " + 
                    Functions.TinhTongTien(lstCTHD).ToString("#,###") + "vnđ"
                    +  "\nChân thành cảm ơn quý khách!";
                new FormQRCode().Show();
                HoaDon_BUS.ThanhToanHoaDon(idHoaDon, Functions.TinhTongTien(lstCTHD), billDate);
                Ban_BUS.ThanhToanBan(idBan, 0);
                tabControl.SelectedIndex = 0;
                if (lstBanGop.Count != 0)
                {
                    for (int i = 0; i < lstBanGop.Count; i++)
                    {
                        List<int> cap = lstBanGop[i];
                        if (cap[0] == idBan)
                        {
                            Ban_BUS.ThanhToanBan(cap[1], 0);
                            lstBanGop.Remove(cap);
                        }
                    }
                }
                else
                {
                    List<Ban_DTO> lstBanKhongHD = Ban_BUS.LayBanCoNguoiKhongCoHD();
                    if (lstBanKhongHD != null)
                        foreach (Ban_DTO ban in lstBanKhongHD)
                        {
                            Ban_BUS.ThanhToanBan(ban.Id, 0);
                        }
                }
                HienThiBan();
            }            
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPageQuanLy && tk.Type == 2)
            {
                MessageBox.Show("Bạn không quyền truy cập tab này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabControl.SelectedTab = tabHome;
            }
            else if (tabControl.SelectedIndex == 1)
            {
                idHoaDon = HoaDon_BUS.LayIDHoaDon(idBan);
                HienThiDoUong();
                if (idHoaDon != -1)
                    HienThiChiTietHoaDon(idHoaDon);
                else
                {
                    if (lstBan[idBan - 1].Status)
                        MessageBox.Show("Bàn này đã gộp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Bàn này đang trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabControl.SelectedIndex = 0;
                }
            }
            else if (tabControl.SelectedIndex == 0)
            {
                HienThiDoUong();
            }
            else if (tabControl.SelectedTab == tabPageBaoCao)
            {
                cbBCTK.SelectedIndex = 0;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //string temp = "";
            //foreach (Control con in panelButton.Controls)
            //{
            //    temp += con.Text + "\n";
            //}
            //MessageBox.Show(temp);
            this.Close();
            Form_DangNhap.isExit = true;
        }

        private void dgvCTHD_Click(object sender, EventArgs e)
        {
            int idx = dgvCTHD.CurrentRow.Index;
            if (idx >= 0 && idx <= dgvCTHD.RowCount - 1)
            {
                string ten = dgvCTHD[0, idx].Value.ToString();
                cbDoUong2.SelectedValue = DoUong_BUS.getID(ten);
                idDoUongCu = int.Parse(cbDoUong2.SelectedValue+"");
                nudSoLuong2.Value = int.Parse(dgvCTHD[1, idx].Value.ToString());
                HienThiGia();
            }
        }

        private void btnQuanLyGoHome_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void btnChiTietGoHome_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new Form_QuanLyBan(), pnChildForm);
        }

        private void btnQuanLyDoUong_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new Form_QuanLyDoUong(), pnChildForm);
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new Form_QuanLyNhanVien(), pnChildForm);
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            bool tableStatus = lstBan[idBan - 1].Status;
            if (tableStatus)
            {
                new Form_ChuyenBan(idBan).ShowDialog();
                HienThiBan();
            }
            else
                MessageBox.Show("Bàn này đang trống, không cần chuyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDoiMon_Click(object sender, EventArgs e)
        {
            int idx = dgvCTHD.CurrentRow.Index;
            if (idx >= 0 && idx <= dgvCTHD.Rows.Count-1)
            {
                DialogResult answer = MessageBox.Show("Bạn muốn đổi món bàn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    int idDoUongMoi = int.Parse(cbDoUong2.SelectedValue.ToString());
                    int sl = int.Parse(nudSoLuong2.Value.ToString());
                    int idCTHD = ThongTinHoaDon_BUS.LayIdCTHD(idHoaDon, idDoUongCu);
                    if (ThongTinHoaDon_BUS.CapNhatCTHD(idDoUongMoi, sl, idCTHD))
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiChiTietHoaDon(idHoaDon);
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            int idx = dgvCTHD.CurrentRow.Index;
            if (idx >= 0 && idx <= dgvCTHD.Rows.Count - 1)
            {
                DialogResult answer = MessageBox.Show("Bạn muốn xóa món này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    int idCTHD = ThongTinHoaDon_BUS.LayIdCTHD(idHoaDon, idDoUongCu);
                    if (ThongTinHoaDon_BUS.XoaCTHD(idCTHD))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiChiTietHoaDon(idHoaDon);
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnGopBan_Click(object sender, EventArgs e)
        {
            bool tableStatus = lstBan[idBan - 1].Status;
            if (tableStatus)
            {
                new Form_GopBan(idBan).ShowDialog();
                HienThiBan();
                if (Form_GopBan.IDres!=-1)
                    lstBanGop.Add(new List<int> { Form_GopBan.IDres, idBan });
                Form_GopBan.IDres = -1;
                HienThiBan();
            }
            else
                MessageBox.Show("Bàn này đang trống, không cần gộp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabelDangXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                    "Bạn có muốn đăng xuất không?",
                    "Đăng xuất",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (answer==DialogResult.Yes)
                this.Close();
            Form_DangNhap.isLogout = true;
        }

        private void rbtnNow_CheckedChanged(object sender, EventArgs e)
        {
            dtpToDate.Enabled = false;
        }

        private void rbtnToDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpToDate.Enabled = true;
        }

        private void btnXemBC_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpFromDate.Value;
            DateTime toDate = dtpToDate.Value;
            if (rbtnNow.Checked)
                toDate = DateTime.Now;
            if (cbBCTK.SelectedIndex == 0)
            {
                List<HoaDon_DTO> lstHoaDonBC = HoaDon_BUS.LayHoaDonTuNgay(fromDate, toDate);
                List<BaoCaoDoanhThu_DTO> lstBCDT = new List<BaoCaoDoanhThu_DTO>();
                BaoCaoDoanhThu_DTO bcdt = null;
                if (lstHoaDonBC != null)
                    foreach (HoaDon_DTO hoaDon in lstHoaDonBC)
                    {
                        bcdt = new BaoCaoDoanhThu_DTO();
                        bcdt.IdHoaDon = hoaDon.Id;
                        bcdt.IdBan = hoaDon.IdTable;
                        bcdt.NgayLap = hoaDon.Thoigianlap;
                        bcdt.TongTien = hoaDon.Tongtien;
                        bcdt.TuNgay = fromDate;
                        bcdt.DenNgay = toDate;
                        lstBCDT.Add(bcdt);
                    }
                else
                {
                    DialogResult answer = MessageBox.Show(
                    "Không có hóa đơn nào từ ngày: " + fromDate.ToString() 
                    + " -> " + toDate.ToString(),
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                rpBCTK.LocalReport.ReportPath = "BCTK_HoaDon.rdlc";
                rpBCTK.LocalReport.DataSources.Clear();
                var source = new ReportDataSource("DataSetBCTK_HoaDon", lstBCDT);
                rpBCTK.LocalReport.DataSources.Add(source);
                this.rpBCTK.RefreshReport();
            }
            else if (cbBCTK.SelectedIndex == 1)
            {
                List<BCTK_DoUong> lstBCDU = DoUong_BUS.LaySoLuongDoUongTheoNgay(fromDate, toDate);
                if (lstBCDU != null)
                    foreach (BCTK_DoUong doUong in lstBCDU)
                    {
                        doUong.TuNgay = fromDate;
                        doUong.DenNgay = toDate;
                    }
                else
                {
                    DialogResult answer = MessageBox.Show(
                    "Không thức uống nào được bán từ ngày: " + fromDate.ToString()
                    + " -> " + toDate.ToString(),
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                rpBCTK.LocalReport.ReportPath = "BCTK_DoUong.rdlc";
                rpBCTK.LocalReport.DataSources.Clear();
                var source = new ReportDataSource("DataSetBCTK_DoUong", lstBCDU);
                rpBCTK.LocalReport.DataSources.Add(source);
                this.rpBCTK.RefreshReport();
            }
        }


        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_DangNhap.isExit = true;
        }

        private void btnLocBanTrong_Click(object sender, EventArgs e)
        {
            if (isAll)
            {
                btnLocBanTrong.Text = "Tất cả bàn";
                fpnDanhSachBan.Controls.Clear();
                lstBan = Ban_BUS.LayBan();
                foreach (Ban_DTO ban in lstBan)
                {
                    if (!ban.Status)
                    {
                        string status = ban.Status ? "Có người" : "Trống";
                        Button btn = new Button() { Width = tableWidth, Height = tableHeight };
                        btn.Text = "Bàn " + ban.Id + Environment.NewLine + status;
                        btn.Tag = ban;
                        btn.Click += new System.EventHandler(this.btnBan_Click);
                        fpnDanhSachBan.Controls.Add(btn);
                    }
                }
                isAll = false;
            }
            else 
            {
                HienThiBan();
            }
        }

        private void linkLabelDoiMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form_ThietLapTaiKhoan(tk).ShowDialog();
        }

        private void linkLabelSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            contextMenuStripSetting.Show(linkLabelSetting, new Point(0, linkLabelSetting.Height));
            //Point screenPoint = linkLabelSetting.PointToScreen(new Point(linkLabelSetting.Left, linkLabelSetting.Bottom));
            //if (screenPoint.Y + contextMenuStripSetting.Size.Height > Screen.PrimaryScreen.WorkingArea.Height)
            //{
            //    contextMenuStripSetting.Show(linkLabelSetting, new Point(0, -contextMenuStripSetting.Size.Height));
            //}
            //else
            //{
            //    contextMenuStripSetting.Show(linkLabelSetting, new Point(0, linkLabelSetting.Height));
            //}
        }

        private void thietLapTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_ThietLapTaiKhoan(tk).ShowDialog();
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                    "Bạn có muốn đăng xuất không?",
                    "Đăng xuất",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
                this.Close();
            Form_DangNhap.isLogout = true;
        }

        private void btnChonMon_Click(object sender, EventArgs e)
        {
            new Form_ChonMon().ShowDialog();
            if (Form_ChonMon.idMon != -1)
                cbDoUong.SelectedValue = Form_ChonMon.idMon;
            Form_ChonMon.idMon = -1;
        }

        private void saoLuutoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                    "Bạn có muốn sao lưu dữ liệu không?",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                FolderBrowserDialog saoluuFolder = new FolderBrowserDialog();
                saoluuFolder.Description = "Chọn thư mục lưu trữ";
                if (saoluuFolder.ShowDialog() == DialogResult.OK)
                {
                    string sDuongDan = saoluuFolder.SelectedPath;
                    if (CSDL_BUS.SaoLuu(sDuongDan) == true)
                        MessageBox.Show("Đã sao lưu dữ liệu vào " + sDuongDan);
                    else
                        MessageBox.Show("Thao tác không thành công");
                }
            }
        }

        private void khoiPhucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                    "Dữ liệu hiện tại sau khi khôi phục sẽ bị mất,\n" +
                    "Bạn có muốn không?",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                OpenFileDialog phuchoiFile = new OpenFileDialog();
                phuchoiFile.Filter = "*.bak|*.bak";
                phuchoiFile.Title = "Chọn tập tin phục hồi (.bak)";
                if (phuchoiFile.ShowDialog() == DialogResult.OK &&
               phuchoiFile.CheckFileExists == true)
                {
                    string sDuongDan = phuchoiFile.FileName;
                    if (CSDL_BUS.PhucHoi(sDuongDan) == true)
                    {
                        MessageBox.Show(
                        "Khôi phục thành công, vui lòng đăng nhập lại để sử dụng",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                        dangXuatToolStripMenuItem_Click(new Button(), new EventArgs());
                    }
                    else
                        MessageBox.Show("Khôi phục thất bại");
                }
            }
        }
    }
}
