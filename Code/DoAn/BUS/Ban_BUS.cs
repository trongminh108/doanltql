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

        public static bool ThanhToanBan(int id, int tinhtrang)
        {
            return Ban_DAO.ThanhToanBan(id, tinhtrang);
        }
    }
}
