using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BCTK_DoUong
    {
        int idDoUong;
        string tenDoUong;
        int soLuong;
        int donGia;
        DateTime tuNgay, denNgay;

        public BCTK_DoUong()
        {
        }

        public BCTK_DoUong(int idDoUong, string tenDoUong, int soLuong, int donGia, DateTime tuNgay, DateTime denNgay)
        {
            this.idDoUong = idDoUong;
            this.tenDoUong = tenDoUong;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.tuNgay = tuNgay;
            this.denNgay = denNgay;
        }

        public int IdDoUong { get => idDoUong; set => idDoUong = value; }
        public string TenDoUong { get => tenDoUong; set => tenDoUong = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public DateTime TuNgay { get => tuNgay; set => tuNgay = value; }
        public DateTime DenNgay { get => denNgay; set => denNgay = value; }
    }
}
