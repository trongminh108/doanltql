using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CSDL_BUS
    {
        public static bool SaoLuu(string sDuongDan)
        {
            return DataProvider.SaoLuuDuLieu(sDuongDan);
        }

        public static bool PhucHoi(string sDuongDan)
        {
            return DataProvider.PhucHoiDuLieu(sDuongDan);
        }
    }
}
