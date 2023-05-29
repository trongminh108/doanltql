using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form_ThietLapTaiKhoan : Form
    {
        public TaiKhoan_DTO tk;
        public Form_ThietLapTaiKhoan(TaiKhoan_DTO tk)
        {
            InitializeComponent();
            this.tk = tk;
        }

        private void Form_ThietLapTaiKhoan_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = tk.Username;
            txtTenHienThi.Text = tk.DisplayName;
            nudQuyen.Value = tk.Type;
            if (tk.Type == 2)
            {
                lblTenQuyen.Text = "Nhân viên";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            MD5 md5Hash = MD5.Create();
            string mkCu = Functions.GetMd5Hash(md5Hash, txtMatKhauCu.Text);
            if (mkCu == tk.Password)
            {
                DialogResult answer = MessageBox.Show(
                    "Bạn chắc chắn đổi chứ?",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    TaiKhoan_DTO tkMoi = new TaiKhoan_DTO();
                    tkMoi.Username = txtTenDangNhap.Text;
                    tkMoi.Password = txtMatKhauMoi.Text;
                    tkMoi.DisplayName = txtTenHienThi.Text;
                    tkMoi.Type = int.Parse(nudQuyen.Value.ToString());
                    if (TaiKhoan_BUS.CapNhatTaiKhoanCoMK(tk.Username, tkMoi))
                    {
                        MessageBox.Show(
                            "Cập nhật thành công, đăng nhập lại sẽ có hiệu lực!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(
                           "Cập nhật thất bại!",
                           "Thông báo",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(
                    "Mật khẩu sai",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
