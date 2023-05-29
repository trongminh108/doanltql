using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThongTinHoaDon_DAO
    {
        public static List<ChiTietHoaDon_DTO> LayChiTietHD(int idHD)
        {
            string sTruyVan = string.Format(@"
                SELECT du.ten, tthd.soLuong, du.gia
                FROM thongtinhoadon tthd
                INNER JOIN douong AS du ON du.id=tthd.idDoUong
                WHERE tthd.idHoaDon = {0}
            ", idHD);
            SqlConnection conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChiTietHoaDon_DTO> lst = new List<ChiTietHoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTietHoaDon_DTO ban = new ChiTietHoaDon_DTO();
                ban.DrinkName = dt.Rows[i]["ten"].ToString();
                ban.Quantity = int.Parse(dt.Rows[i]["soLuong"].ToString());
                ban.Price = int.Parse(dt.Rows[i]["gia"].ToString());
                lst.Add(ban);
            }
            DataProvider.DongKetNoi(conn);
            return lst;
        }

        public static bool ThemThongTinHoaDon(ThongTinHoaDon_DTO tthd)
        {
            string sTruyVan = string.Format(@"insert into thongtinhoadon values(N'{0}',N'{1}',N'{2}')", tthd.IdBill, tthd.IdDrink, tthd.Quantity);
            SqlConnection conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        public static int LayIdCTHD(int idHoaDon, int idDoUong)
        {
            string sTruyVan = string.Format(@"
                SELECT id
                FROM ThongTinHoaDon
                WHERE idDoUong = {0} AND idHoaDon = {1}
            ", idDoUong, idHoaDon);
            SqlConnection conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return -1;
            }
            return (int)dt.Rows[0][0];
        }

        public static DataTable LayCTHD(int idHoaDon, int idDoUong)
        {
            string sTruyVan = string.Format(@"
                SELECT *
                FROM ThongTinHoaDon
                WHERE idDoUong = {0} AND idHoaDon = {1}
            ", idDoUong, idHoaDon);
            SqlConnection conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            return dt;
        }

        public static bool CapNhatCTHD(int idDU, int sl, int idCTHD)
        {
            string sTruyVan = string.Format(@"
                UPDATE ThongTinHoaDon
                SET idDoUong={0}, soLuong={1}
                WHERE id={2}
            ", idDU, sl, idCTHD);
            SqlConnection conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        public static bool XoaCTHD(int idCTHD)
        {
            string sTruyVan = string.Format(@"
                DELETE FROM ThongTinHoaDon
                WHERE id = {0}
            ", idCTHD);
            SqlConnection conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider.CapNhatIndentity("thongtinhoadon", conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        public static List<ThongTinHoaDon_DTO> LayThongTinHoaDon(int idHD)
        {
            string sTruyVan = string.Format(
                @"SELECT * 
                FROM ThongTinHoaDon tthd
                WHERE tthd.idHoaDon={0}
            ", idHD);
            SqlConnection conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ThongTinHoaDon_DTO> lst = new List<ThongTinHoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThongTinHoaDon_DTO ban = new ThongTinHoaDon_DTO();
                ban.Id = int.Parse(dt.Rows[i][0].ToString());
                ban.IdBill = int.Parse(dt.Rows[i][1].ToString());
                ban.IdDrink = int.Parse(dt.Rows[i][2].ToString());
                ban.Quantity = int.Parse(dt.Rows[i][3].ToString());
                lst.Add(ban);
            }
            DataProvider.DongKetNoi(conn);
            return lst;
        }
    }
}
