using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon_DTO
    {
        int id;
        int idTable;
        DateTime thoigianlap;
        bool status;
        int tongtien;

        public HoaDon_DTO(int id, int idTable, DateTime thoigianlap, bool status)
        {
            this.id = id;
            this.idTable = idTable;
            this.thoigianlap = thoigianlap;
            this.status = status;
        }

        public HoaDon_DTO() { }

        public int Id { get => id; set => id = value; }
        public int IdTable { get => idTable; set => idTable = value; }
        public bool Status { get => status; set => status = value; }
        public DateTime Thoigianlap { get => thoigianlap; set => thoigianlap = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
    }
}
