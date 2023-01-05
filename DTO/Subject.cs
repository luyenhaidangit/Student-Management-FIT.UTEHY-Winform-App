using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Subject
    {
        private string idSubject;
        private string nameSubject;
        private int numberCredits;

        public Subject()
        {

        }

        public Subject(string idSubject, string nameSubject, int numberCredits)
        {
            this.IdSubject = idSubject;
            this.NameSubject = nameSubject;
            this.NumberCredits = numberCredits;
        }

        public string IdSubject { get => idSubject; set => idSubject = value; }
        public string NameSubject { get => nameSubject; set => nameSubject = value; }
        public int NumberCredits { get => numberCredits; set => numberCredits = value; }
    }
}
