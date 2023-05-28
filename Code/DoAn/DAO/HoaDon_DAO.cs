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

        public static bool ThanhToanHoaDon(int idHD, DateTime tg)
        {
            DateTime thoigian = tg;
            string sTruyVan = string.Format(@"update hoadon set tinhtrang='1', thoigianlap='{0}' where id='{1}'", thoigian, idHD);
            SqlConnection conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        public static bool ThemHoaDon(int idBan, int tinhtrang)
        {
            string sTruyVan = string.Format(@"insert into hoadon values('{0}', NULL,'{1}')", idBan, tinhtrang);
            SqlConnection conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
    }
}
