using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDon_BUS
    {
        public static int LayIDHoaDon(int idBan)
        {
            return HoaDon_DAO.LayIDHoaDon(idBan);
        }

        public static bool ThanhToanHoaDon(int id, int tongtien, DateTime tg)
        {
            return HoaDon_DAO.ThanhToanHoaDon(id, tongtien, tg);
        }

        public static bool ThemHoaDon(int idBan, int tinhtrang)
        {
            return HoaDon_DAO.ThemHoaDon(idBan, tinhtrang);
        }

        public static bool ChuyenBan(int idHD, int idBanMoi)
        {
            return HoaDon_DAO.ChuyenBan(idHD, idBanMoi);
        }

        public static bool XoaHoaDon(int idHD)
        {
            return HoaDon_DAO.XoaHoaDon(idHD);
        }

        public static List<HoaDon_DTO> LayHoaDonTuNgay(DateTime from, DateTime to)
        {
            return HoaDon_DAO.LayHoaDonTuNgay(from, to);
        }
    }
}
