using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon_DTO
    {
        string drinkName;
        int quantity;
        int price;

        public ChiTietHoaDon_DTO() { }


        public ChiTietHoaDon_DTO(string drinkName, int quantity, int price)
        {
            this.drinkName = drinkName;
            this.quantity = quantity;
            this.price = price;
        }

        public string DrinkName { get => drinkName; set => drinkName = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }
    }
}
