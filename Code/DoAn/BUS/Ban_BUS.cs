using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Ban_BUS
    {
        public static List<Ban_DTO> LayBan()
        {
            return Ban_DAO.LayBan();
        }

        public static Ban_DTO LayBan(int idBan)
        {
            return Ban_DAO.LayBan(idBan);
        }

        public static bool ThanhToanBan(int id, int tinhtrang)
        {
            return Ban_DAO.ThanhToanBan(id, tinhtrang);
        }

        public static List<Ban_DTO> LayBanCoNguoiKhongCoHD()
        {
            return Ban_DAO.LayBanCoNguoiKhongCoHD();
        }

        public static bool ThemBan()
        {
            return Ban_DAO.ThemBan();
        }

        public static bool LayTinhTrangBan(int idBan)
        {
            return Ban_DAO.LayTinhTrang(idBan);
        }

        public static bool XoaBan(int idBan)
        {
            return Ban_DAO.XoaBan(idBan);
        }
    }
}
