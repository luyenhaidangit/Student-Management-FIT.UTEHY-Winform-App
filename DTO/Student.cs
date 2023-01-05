using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Student
    {
        private string idStudent;
        private string nameStudent;
        private string birthday;
        private string sex;
        private string andress;
        private string idClass;

        public string IdStudent { get => idStudent; set => idStudent = value; }
        public string NameStudent { get => nameStudent; set => nameStudent = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Andress { get => andress; set => andress = value; }
        public string IdClass { get => idClass; set => idClass = value; }

        public Student()
        {

        }
        public Student(string idStudent, string nameStudent, string birthday, string sex, string andress, string idClass)
        {
            this.IdStudent = idStudent;
            this.NameStudent = nameStudent;
            this.Birthday = birthday;
            this.Sex = sex;
            this.Andress = andress;
            this.IdClass = idClass;
        }
    }
}
