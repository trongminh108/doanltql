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

namespace GUI
{
    public partial class Form_QuanLyNhanVien : Form
    {
        List<TaiKhoan_DTO> lstTaiKhoan;
        string[] names = { "Tên đăng nhập", "Mật khẩu (đã mã hóa)", "Tên hiển thị", "Quyền" };
        double[] widths = { 0.2, 0.35, 0.2, 0.15 };
        int idx = -1;
        public Form_QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void Form_QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            HienThiTaiKHoan();
        }

        public void DoiQuyen()
        {
            if (nudQuyen.Value == 1)
                lblTenQuyen.Text = "Quản lý";
            else
                lblTenQuyen.Text = "Nhân viên";
        }

        public void HienThiTaiKHoan()
        {
            lstTaiKhoan = TaiKhoan_BUS.LayTaiKhoan();
            dgvTaiKhoan.DataSource = lstTaiKhoan;
            Functions.FormatDGV(dgvTaiKhoan, names, widths);
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
            if (idx >= 0)
            {
                txtTenDangNhap.Text = dgvTaiKhoan[0, idx].Value.ToString();
                txtTenHienThi.Text = dgvTaiKhoan[2, idx].Value.ToString();
                nudQuyen.Value = int.Parse(dgvTaiKhoan[3, idx].Value.ToString());
                DoiQuyen();
            }
        }

        private void nudQuyen_ValueChanged(object sender, EventArgs e)
        {
            DoiQuyen();
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                    "Bạn có muốn thêm NV " + txtTenHienThi.Text + " không?",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                string username = txtTenDangNhap.Text;
                string pass = txtMatKhau.Text;
                string display = txtTenHienThi.Text;
                int role = int.Parse(nudQuyen.Value.ToString());
                TaiKhoan_DTO tk = new TaiKhoan_DTO(username, pass, display, role);
                TaiKhoan_BUS.ThemTaiKhoan(tk);
                HienThiTaiKHoan();
            }
            

        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            if (idx >= 0)
            {
                DialogResult answer = MessageBox.Show(
                    "Bạn chắc chắn xóa tài khoản này?",
                    "Xóa tài khoản",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (answer == DialogResult.Yes) 
                {
                    string tenTK = dgvTaiKhoan[0, idx].Value.ToString();
                    TaiKhoan_BUS.XoaTaiKhoan(tenTK);
                    HienThiTaiKHoan();
                }
            }
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            if (idx >= 0)
            {
                DialogResult answer = MessageBox.Show(
                    "Bạn chắc chắn cập nhật tài khoản này?",
                    "Cập nhật tài khoản",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    string tenTKCu = dgvTaiKhoan[0, idx].Value.ToString();
                    string tenTKMoi = txtTenDangNhap.Text;
                    string tenHTMoi = txtTenHienThi.Text;
                    int quyenMoi = int.Parse(nudQuyen.Value.ToString());
                    TaiKhoan_DTO tkMoi = new TaiKhoan_DTO(tenTKMoi, "", tenHTMoi, quyenMoi);
                    TaiKhoan_BUS.CapNhatTaiKhoanKoMK(tenTKCu, tkMoi);
                    HienThiTaiKHoan();
                }
            }
        }
    }
}
