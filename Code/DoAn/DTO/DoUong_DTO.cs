using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DoUong_DTO
    {
        int id;
        string name;
        int price;

        public DoUong_DTO(int id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public DoUong_DTO() { }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
    }
}
