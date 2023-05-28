using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ban_DTO
    {
        int id;
        bool status;

        public Ban_DTO(int id, bool status)
        {
            this.id = id;
            this.status = status;
        }

        public Ban_DTO()
        {
        }

        public int Id { get => id; set => id = value; }
        public bool Status { get => status; set => status = value; }
    }
}
