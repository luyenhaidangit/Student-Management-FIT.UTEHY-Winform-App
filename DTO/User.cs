using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User
    {
        private string id;
        private string password;
        private string type;

        public User()
        {

        }
        public User(string id, string password, string type)
        {
            this.Id = id;
            this.Password = password;
            this.Type = type;
        }

        public string Id { get => id; set => id = value; }
        public string Password { get => password; set => password = value; }
        public string Type { get => type; set => type = value; }
    }
}
