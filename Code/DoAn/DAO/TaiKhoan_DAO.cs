using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
