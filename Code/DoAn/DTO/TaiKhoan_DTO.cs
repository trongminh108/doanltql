using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan_DTO
    {
        string username;
        string password;
        string displayName;
        int type;

        public TaiKhoan_DTO(string username, string password, string displayName, int type)
        {
            this.username = username;
            this.password = password;
            this.displayName = displayName;
            this.type = type;
        }

        public TaiKhoan_DTO() { }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public int Type { get => type; set => type = value; }
    }
}
