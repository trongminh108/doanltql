using BUS;
using DTO;
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

        public Form_Main(TaiKhoan_DTO tk)
        {
            InitializeComponent();
            this.tk = tk;
            lblHello.Text = "Xin chào, " + tk.DisplayName;
        }        

        private void Form_Main_Load(object sender, EventArgs e)
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
                }

                fpnDanhSachBan.Controls.Add(btn);
            }
        }

        public void HienThiChiTietHoaDon(int idHD)
        {
            lstCTHD = ThongTinHoaDon_BUS.LayChiTietHD(idHD);
            dgvCTHD.DataSource = lstCTHD;
            dgvCTHD.ReadOnly = true;
            dgvCTHD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string[] names = { "Đồ uống", "Số lượng", "Đơn giá" };
            double[] widths = { 0.4, 0.3, 0.3 };
            int width = dgvCTHD.Width;
            int i = 0;
            foreach (DataGridViewColumn col in dgvCTHD.Columns)
            {
                col.HeaderText = names[i];
                col.Width = (int)(widths[i] * width);
                i += 1;
            }
            string total = Functions.TinhTongTien(lstCTHD).ToString("#,###");
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
            catch (Exception ex)
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
            
            
            DialogResult answer = MessageBox.Show("Bạn muốn in hóa đơn bàn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            DateTime billDate = DateTime.Now;
            if (answer == DialogResult.Yes)
            {
                List<InCTHD> lstInCTHD = new List<InCTHD>();
                foreach (ChiTietHoaDon_DTO cthd in lstCTHD)
                {
                    lstInCTHD.Add(new InCTHD(idHoaDon, billDate, idBan, cthd));
                }
                new Form_ChiTietHoaDon(lstInCTHD).ShowDialog();
                HoaDon_BUS.ThanhToanHoaDon(idHoaDon, billDate);
                Ban_BUS.ThanhToanBan(idBan, 0);
                HienThiBan();
                tabControl.SelectedIndex = 0;
            }            
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPageQuanLy && tk.Type == 2)
            {
                MessageBox.Show("Bạn không quyền truy cập tab này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabControl.SelectedTab = tabHome;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
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
    }
}
