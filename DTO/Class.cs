using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Class
    {
        private string id;
        private string name;
        private string idGeneration;

        public Class()
        {

        }

        public Class(string id, string name, string idGeneration)
        {
            this.id = id;
            this.name = name;
            this.idGeneration = idGeneration;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string IdGeneration { get => idGeneration; set => idGeneration = value; }
    }
}
