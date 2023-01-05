using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Teacher
    {
        private string idTeacher;
        private string nameTeacher;
        private string birthday;
        private string sex;
        private string andress;

        public Teacher()
        {

        }

        public Teacher(string idTeacher, string nameTeacher, string birthday, string sex, string andress)
        {
            this.IdTeacher = idTeacher;
            this.NameTeacher = nameTeacher;
            this.Birthday = birthday;
            this.Sex = sex;
            this.Andress = andress;
        }

        public string IdTeacher { get => idTeacher; set => idTeacher = value; }
        public string NameTeacher { get => nameTeacher; set => nameTeacher = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Andress { get => andress; set => andress = value; }
    }
}
