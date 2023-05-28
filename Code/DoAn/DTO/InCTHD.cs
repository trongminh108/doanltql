using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InCTHD
    {
        int idBill;
        DateTime billDate;
        int idTable;
        string drinkName;
        int quantity;
        int price;

        public InCTHD(int idBill, DateTime billDate, int idTable, string drinkName, int quantity, int price)
        {
            this.idBill = idBill;
            this.billDate = billDate;
            this.IdTable = idTable;
            this.drinkName = drinkName;
            this.quantity = quantity;
            this.price = price;
        }

        public InCTHD() { }

        public InCTHD(int idBill, DateTime billDate, int idTable, ChiTietHoaDon_DTO cthd)
        {
            this.idBill = idBill;
            this.billDate = billDate;
            this.IdTable = idTable;
            this.drinkName = cthd.DrinkName;
            this.quantity = cthd.Quantity;
            this.Price = cthd.Price;
        }

        public int IdBill { get => idBill; set => idBill = value; }
        public DateTime BillDate { get => billDate; set => billDate = value; }
        public string DrinkName { get => drinkName; set => drinkName = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }
        public int IdTable { get => idTable; set => idTable = value; }
    }
}
