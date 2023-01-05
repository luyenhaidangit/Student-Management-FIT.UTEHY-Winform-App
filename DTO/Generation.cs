using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Generation
    {
        private string id;
        private string name;
        private string desc;

        public Generation(string id, string name, string desc)
        {
            this.Id = id;
            this.Name = name;
            this.Desc = desc;
        }

        public Generation()
        {

        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Desc { get => desc; set => desc = value; }
    }
}
