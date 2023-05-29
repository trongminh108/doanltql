using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DAO
{
    public class TaiKhoan_DAO
    {
        public static TaiKhoan_DTO DangNhapTaiKhoan(string ten, string matkhau)
        {
            string sTruyVan = string.Format(@"select * from taikhoan where tendangnhap=N'{0}' and matkhau='{1}'", ten, matkhau);
            SqlConnection con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.Username = dt.Rows[0]["tendangnhap"].ToString();
            tk.Password = dt.Rows[0]["matkhau"].ToString();
            tk.DisplayName = dt.Rows[0]["tenhienthi"].ToString();
            tk.Type = int.Parse(dt.Rows[0]["loai"].ToString());

            DataProvider.DongKetNoi(con);
            return tk;
        }

        public static List<TaiKhoan_DTO> LayTaiKhoan()
        {
            string sTruyVan = string.Format(
                @"select * from taikhoan");
            SqlConnection conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TaiKhoan_DTO> lst = new List<TaiKhoan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TaiKhoan_DTO temp = new TaiKhoan_DTO();
                temp.Username = dt.Rows[i][0].ToString();
                temp.Password = dt.Rows[i][1].ToString();
                temp.DisplayName = dt.Rows[i][2].ToString();
                temp.Type = int.Parse(dt.Rows[i][3].ToString());
                lst.Add(temp);
            }
            DataProvider.DongKetNoi(conn);
            return lst;
        }

        public static TaiKhoan_DTO LayTaiKhoan(string tenTK)
        {
            string sTruyVan = string.Format(
                @"select * from taikhoan where tendangnhap=N'{0}'",
                tenTK);
            SqlConnection conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TaiKhoan_DTO> lst = new List<TaiKhoan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TaiKhoan_DTO temp = new TaiKhoan_DTO();
                temp.Username = dt.Rows[i][0].ToString();
                temp.Password = dt.Rows[i][1].ToString();
                temp.DisplayName = dt.Rows[i][2].ToString();
                temp.Type = int.Parse(dt.Rows[i][3].ToString());
                lst.Add(temp);
            }
            DataProvider.DongKetNoi(conn);
            return lst[0];
        }

        public static bool ThemTaiKhoan(TaiKhoan_DTO tk)
        {
            string sTruyVan = string.Format(
                @"insert into taikhoan 
                values(N'{0}', '{1}', N'{2}', '{3}')", 
                tk.Username, tk.Password, tk.DisplayName, tk.Type);
            SqlConnection conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        public static bool XoaTaiKhoan(string tenTK)
        {
            string sTruyVan = string.Format(
                @"DELETE FROM TaiKhoan WHERE tendangnhap=N'{0}'",
                tenTK);
            SqlConnection conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        public static bool CapNhatTaiKhoanKoMK(string tenCu, TaiKhoan_DTO tkMoi)
        {
            string sTruyVan = string.Format(
                @"UPDATE TaiKhoan 
                SET tendangnhap=N'{0}', tenhienthi=N'{1}', loai={2}
                WHERE tendangnhap=N'{3}'",
                tkMoi.Username, tkMoi.DisplayName, tkMoi.Type, tenCu);
            SqlConnection conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
    }
}
