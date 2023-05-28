using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class ThongTinHoaDon_BUS
    {
        public static List<ChiTietHoaDon_DTO> LayChiTietHD(int idHD)
        {
            return ThongTinHoaDon_DAO.LayChiTietHD(idHD);
        }

        public static bool ThemThongTinHoaDon(ThongTinHoaDon_DTO tthd)
        {
            int idHoaDon = tthd.IdBill;
            int idDoUong = tthd.IdDrink;
            int idCTHD = ThongTinHoaDon_DAO.LayIdCTHD(idHoaDon, idDoUong);
            if (idCTHD != -1)
            {
                DataTable dt = ThongTinHoaDon_DAO.LayCTHD(idHoaDon, idDoUong);
                int slMoi = tthd.Quantity + int.Parse(dt.Rows[0][3].ToString());
                return ThongTinHoaDon_DAO.CapNhatCTHD(idDoUong, slMoi, idCTHD);
            }
            else
            {
                return ThongTinHoaDon_DAO.ThemThongTinHoaDon(tthd);
            }
        }

        public static int LayIdCTHD(int idHoaDon, int idDoUong)
        {
            return ThongTinHoaDon_DAO.LayIdCTHD(idHoaDon, idDoUong);
        }

        public static bool CapNhatCTHD(int idDU, int sl, int idCTHD)
        {
            return ThongTinHoaDon_DAO.CapNhatCTHD(idDU, sl, idCTHD);
        }

        public static bool XoaCTHD (int idCTHD)
        {
            if (ThongTinHoaDon_DAO.XoaCTHD(idCTHD))
            {
                return true;
            }
            return false;
        }

        public static List<ThongTinHoaDon_DTO> LayThongTinHoaDon(int idHD)
        {
            return ThongTinHoaDon_DAO.LayThongTinHoaDon(idHD);
        }
    }
}
