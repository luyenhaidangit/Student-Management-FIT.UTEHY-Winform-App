using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class ScoresDAO:DBConnect
    {
        public DBConnect connect = new DBConnect();

        public DataTable GetData()
        {
            string sql = "select * from Scores";
            return connect.GetData(sql);
        }

        public void Add(Scores obj)
        {
            string sql = string.Format("INSERT INTO Scores VALUES (N'{0}',N'{1}',N'{2}',N'{3}')", obj.IdStudent, obj.IdSubject, obj.Mark1, obj.Mark2);
            RunSQL(sql);
        }

        public DataTable StudentWithScores(string idclass,string idsubject)
        {
            string sql = "select s.idstudent,s.Namestudent,c.mark1,c.mark2 from Student s left join Scores c ON c.IDStudent = s.IDSTUDENT left JOIN CLASS cl ON cl.IDCLASS = s.IDCLASS WHERE s.IDCLASS = '"+idclass+ "' and c.IDStudent = '" + idsubject+"'";
            return connect.GetData(sql);
        }

        public void Edit(Scores obj)
        {
            string sql = string.Format("update scores set mark1 = N'{0}', mark2 = N'{1}' WHERE IDStudent=N'{2}' AND IDsubject=N'{3}'", obj.Mark1, obj.Mark2, obj.IdStudent, obj.IdSubject);
            RunSQL(sql);
        }

        public void Delete(string id,string id1)
        {
            string sql = "Delete from scores WHERE IDStudent = '" + id.Trim() + "' AND IDSubject ='" + id1.Trim() + "'";
            RunSQL(sql);
        }

        public DataTable Search(string key)
        {
            string sql = "select IDStudent,NameStudent,Birthday,Sex,Andress,IDclass FROM student WHERE IDStudent like N'%" + key + "%' OR NameStudent like N'%" + key + "%' OR Birthday Like N'%" + key + "%' OR SEX like N'%" + key + "%' OR ANdress like N'%" + key + "%' OR IDclass like N'%" + key + "%'";
            return connect.GetData(sql);
        }
    }
}
