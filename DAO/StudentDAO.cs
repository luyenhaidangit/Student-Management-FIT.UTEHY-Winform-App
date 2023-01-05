using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class StudentDAO:DBConnect
    {
        public DBConnect connect = new DBConnect();

        public DataTable GetData()
        {
            string sql = "select * from Student";
            return connect.GetData(sql);
        }

        public void Add(Student obj)
        {
            string sql = string.Format("INSERT INTO Student VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')", obj.IdStudent, obj.NameStudent, obj.Birthday,obj.Sex,obj.Andress,obj.IdClass);
            RunSQL(sql);
        }

        public void Edit(Student obj)
        {
            string sql = string.Format("update student set namestudent = N'{0}', birthday = N'{1}',sex = N'{2}',andress=N'{3}',idclass=N'{4}' WHERE IDStudent=N'{5}'", obj.NameStudent, obj.Birthday, obj.Sex, obj.Andress, obj.IdClass,obj.IdStudent);
            RunSQL(sql);
        }

        public void Delete(string id)
        {
            string sql = "Delete from Student WHERE IDStudent = '" + id.Trim() + "'";
            RunSQL(sql);
        }

        public DataTable Search(string key)
        {
            string sql = "select IDStudent,NameStudent,Birthday,Sex,Andress,IDclass FROM student WHERE IDStudent like N'%" + key + "%' OR NameStudent like N'%" + key + "%' OR Birthday Like N'%" + key + "%' OR SEX like N'%" + key + "%' OR ANdress like N'%"+ key+"%' OR IDclass like N'%"+ key + "%'";
            return connect.GetData(sql);
        }

        public string AutoID()
        {
            DataTable tb = GetData();
            List<int> listID = new List<int>();
            string s = "";
            foreach (DataRow dr in tb.Rows)
            {
                s = dr["IdStudent"].ToString();
                listID.Add(int.Parse(s));
            }
            int max = listID.Count > 0 ? listID.Max() : 12520062;
            int id = max + 1;
            string ID = id.ToString();
            return ID;
        }
    }
}
