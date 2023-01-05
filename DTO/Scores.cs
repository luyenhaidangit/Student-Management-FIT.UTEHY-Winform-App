using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Scores
    {
        private string idStudent;
        private string idSubject;
        private int mark1;
        private int mark2;

        public Scores()
        {

        }

        public Scores(string idStudent, string idSubject, int mark1, int mark2)
        {
            this.IdStudent = idStudent;
            this.IdSubject = idSubject;
            this.Mark1 = mark1;
            this.Mark2 = mark2;
        }

        public string IdStudent { get => idStudent; set => idStudent = value; }
        public string IdSubject { get => idSubject; set => idSubject = value; }
        public int Mark1 { get => mark1; set => mark1 = value; }
        public int Mark2 { get => mark2; set => mark2 = value; }
    }
}
