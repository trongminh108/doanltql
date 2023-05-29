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
    public class HoaDon_DAO
    {
        public static int LayIDHoaDon(int idBan)
        {
            string sTruyVan = string.Format(@"select id from hoadon where idBan='{0}' AND tinhtrang=0", idBan);
            SqlConnection conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return -1;
            }
            return int.Parse(dt.Rows[0]["id"]+"");
        }

        public static bool ThanhToanHoaDon(int idHD, int tongtien, DateTime tg)
        {
            DateTime thoigian = tg;
            string sTruyVan = string.Format(@"update hoadon 
                set tinhtrang='1', thoigianlap='{0}', tongtien={1} 
                where id='{2}'", thoigian, tongtien, idHD);
            SqlConnection conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        public static bool ThemHoaDon(int idBan, int tinhtrang)
        {
            string sTruyVan = string.Format(@"insert into hoadon values('{0}', NULL,'{1}', 0)", idBan, tinhtrang);
            SqlConnection conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        public static bool ChuyenBan(int idHD, int idBanMoi)
        {
            string sTruyVan = string.Format(@"update hoadon 
                set idBan={0} 
                where id='{1}'", idBanMoi, idHD);
            SqlConnection conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        public static bool XoaHoaDon(int idHD)
        {
            string sTruyVan = string.Format(
                @"DELETE FROM hoadon WHERE id={0}", 
                idHD);
            SqlConnection conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        public static List<HoaDon_DTO> LayHoaDonTuNgay(DateTime fromDate, DateTime toDate)
        {
            string sTruyVan = string.Format(
                @"SELECT *
                FROM HoaDon
                WHERE thoigianlap >= N'{0}' AND thoigianlap <= N'{1}'",
                fromDate, toDate);
            SqlConnection conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> lst = new List<HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO temp = new HoaDon_DTO();
                temp.Id = int.Parse(dt.Rows[i][0].ToString());
                temp.IdTable = int.Parse(dt.Rows[i][1].ToString());
                temp.Thoigianlap = DateTime.Parse(dt.Rows[i][2].ToString());
                temp.Status = (bool) dt.Rows[i][3];
                temp.Tongtien = int.Parse(dt.Rows[i][4].ToString());
                lst.Add(temp);
            }
            DataProvider.DongKetNoi(conn);
            return lst;
        }
    }
}
