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

        public static bool ThanhToanHoaDon(int id, DateTime tg)
        {
            return HoaDon_DAO.ThanhToanHoaDon(id, tg);
        }

        public static bool ThemHoaDon(int idBan, int tinhtrang)
        {
            return HoaDon_DAO.ThemHoaDon(idBan, tinhtrang);
        }
    }
}
