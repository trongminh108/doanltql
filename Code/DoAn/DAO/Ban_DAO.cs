using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class Ban_DAO
    {
        public static List<Ban_DTO> LayBan()
        {
            string sTruyVan = string.Format(@"select * from ban");
            SqlConnection conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            DataProvider.DongKetNoi(conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Ban_DTO> lst = new List<Ban_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Ban_DTO ban = new Ban_DTO();
                ban.Id = int.Parse(dt.Rows[i]["id"].ToString());
                ban.Status = bool.Parse(dt.Rows[i]["tinhtrang"]+"");
                lst.Add(ban);
            }
            return lst;
        }

        public static Ban_DTO LayBan(int id)
        {
            string sTruyVan = string.Format(@"select * from ban where id={0}", id);
            SqlConnection conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            DataProvider.DongKetNoi(conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            
            Ban_DTO ban = new Ban_DTO();
            ban.Id = int.Parse(dt.Rows[0]["id"].ToString());
            ban.Status = bool.Parse(dt.Rows[0]["tinhtrang"] + "");
            return ban;
        }

        public static bool ThanhToanBan(int id, int tinhtrang)
        {
            string sTruyVan = string.Format(@"update ban set tinhtrang='{0}' where id='{1}'", tinhtrang, id);
            SqlConnection conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        public static List<Ban_DTO> LayBanCoNguoiKhongCoHD()
        {
            string sTruyVan = string.Format(
                @"SELECT *
                FROM Ban b
                WHERE b.tinhtrang=1 AND b.id NOT IN (
	                SELECT hd.idBan
	                FROM HoaDon hd	
                    WHERE tinhtrang=0
                )"
            );
            SqlConnection conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            DataProvider.DongKetNoi(conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Ban_DTO> lst = new List<Ban_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Ban_DTO ban = new Ban_DTO();
                ban.Id = int.Parse(dt.Rows[i]["id"].ToString());
                ban.Status = bool.Parse(dt.Rows[i]["tinhtrang"] + "");
                lst.Add(ban);
            }
            return lst;
        }

        public static bool ThemBan()
        {
            string sTruyVan = string.Format(
                @"INSERT INTO ban VALUES (0)"
            );
            SqlConnection conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        public static bool LayTinhTrang(int idBan)
        {
            string sTruyVan = string.Format(
                @"
                    SELECT tinhtrang
                    FROM ban
                    WHERE id={0}
                "
                , idBan);
            SqlConnection conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            DataProvider.DongKetNoi(conn);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            return (bool) dt.Rows[0][0];
        }

        public static bool XoaBan(int idBan)
        {
            string sTruyVan = string.Format(
                @"DELETE FROM ban WHERE id={0}"
                , idBan);
            SqlConnection conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider.CapNhatIndentity("ban", conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
    }
}
