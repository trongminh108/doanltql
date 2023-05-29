using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCaoDoanhThu_DTO
    {
        int idHoaDon;
        int idBan;
        DateTime ngayLap;
        int tongTien;
        DateTime tuNgay, denNgay;

        public BaoCaoDoanhThu_DTO()
        {
        }

        public BaoCaoDoanhThu_DTO(int idHoaDon, int idBan, DateTime ngayLap, int tongTien, DateTime tuNgay, DateTime denNgay)
        {
            this.idHoaDon = idHoaDon;
            this.idBan = idBan;
            this.ngayLap = ngayLap;
            this.tongTien = tongTien;
            this.tuNgay = tuNgay;
            this.denNgay = denNgay;
        }

        public int IdHoaDon { get => idHoaDon; set => idHoaDon = value; }
        public int IdBan { get => idBan; set => idBan = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public DateTime TuNgay { get => tuNgay; set => tuNgay = value; }
        public DateTime DenNgay { get => denNgay; set => denNgay = value; }
    }
}
