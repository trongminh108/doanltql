using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DoUong_BUS
    {
        public static List<DoUong_DTO> LayDoUong()
        {
            return DoUong_DAO.LayDoUong();
        }

        public static int getGia(int id)
        {
            return DoUong_DAO.getGia(id);
        }

        public static int getID(string ten)
        {
            return DoUong_DAO.getID(ten);
        }
    }
}
