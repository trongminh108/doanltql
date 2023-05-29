using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class TaiKhoan_BUS
    {
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
        public static TaiKhoan_DTO DangNhapTaiKhoan(string ten, string matkhau)
        {
            MD5 md5Hash = MD5.Create();
            string matkhau_mahoa = GetMd5Hash(md5Hash, matkhau);
            return TaiKhoan_DAO.DangNhapTaiKhoan(ten, matkhau_mahoa);
        }

        public static List<TaiKhoan_DTO> LayTaiKhoan()
        {
            return TaiKhoan_DAO.LayTaiKhoan();
        }

        public static bool ThemTaiKhoan(TaiKhoan_DTO tk)
        {
            if (tk.Username.Trim()=="" || tk.Password.Trim()=="" ||
                tk.DisplayName == "")
            {
                MessageBox.Show(
                    "Tên đăng nhập, mật khẩu và tên hiển thị không được trống!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            MD5 md5Hash = MD5.Create();
            tk.Password = Functions.GetMd5Hash(md5Hash, tk.Password);
            TaiKhoan_DTO tkCheck = TaiKhoan_DAO.LayTaiKhoan(tk.Username);
            if (tkCheck == null)
                return TaiKhoan_DAO.ThemTaiKhoan(tk);
            MessageBox.Show(
                    "Tài khoản đã tồn tại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            return false;
        }

        public static bool XoaTaiKhoan(string ten)
        {
            return TaiKhoan_DAO.XoaTaiKhoan(ten);
        }

        public static bool CapNhatTaiKhoanKoMK(string tenCu, TaiKhoan_DTO tk)
        {
            if (tk.Username.Trim() == "" ||
                tk.DisplayName == "")
            {
                MessageBox.Show(
                    "Tên đăng nhập và tên hiển thị không được trống!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return TaiKhoan_DAO.CapNhatTaiKhoanKoMK(tenCu, tk);
        }
    }
}
