using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongTinHoaDon_DTO
    {
        int id;
        int idBill;
        int idDrink;
        int quantity;

        public ThongTinHoaDon_DTO(int id, int idBill, int idDrink, int quantity)
        {
            this.id = id;
            this.idBill = idBill;
            this.idDrink = idDrink;
            this.quantity = quantity;
        }

        public ThongTinHoaDon_DTO() { }

        public int Id { get => id; set => id = value; }
        public int IdBill { get => idBill; set => idBill = value; }
        public int IdDrink { get => idDrink; set => idDrink = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
