using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Schedule
    {
        private string idClass;
        private int semester;
        private string idSubject;
        private string idTeacher;

        public string IdClass { get => idClass; set => idClass = value; }
        public int Semester { get => semester; set => semester = value; }
        public string IdSubject { get => idSubject; set => idSubject = value; }
        public string IdTeacher { get => idTeacher; set => idTeacher = value; }

        public Schedule()
        {

        }

        public Schedule(string idClass, int semester, string idSubject, string idTeacher)
        {
            this.IdClass = idClass;
            this.Semester = semester;
            this.IdSubject = idSubject;
            this.IdTeacher = idTeacher;
        }
    }
}
