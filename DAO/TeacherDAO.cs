using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class TeacherDAO:DBConnect
    {
        public DBConnect connect = new DBConnect();

        public DataTable GetData()
        {
            string sql = "select * from Teacher";
            return connect.GetData(sql);
        }

        public void Add(Teacher obj)
        {
            string sql = string.Format("INSERT INTO Teacher VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')", obj.IdTeacher, obj.NameTeacher, obj.Birthday, obj.Sex, obj.Andress);
            RunSQL(sql);
        }

        public void Edit(Teacher obj)
        {
            string sql = string.Format("update student set nameteacher = N'{0}', birthday = N'{1}',sex = N'{2}',andress=N'{3}' WHERE IDTeacher=N'{4}'", obj.NameTeacher, obj.Birthday, obj.Sex, obj.Andress,  obj.IdTeacher);
            RunSQL(sql);
        }

        public void Delete(string id)
        {
            string sql = "Delete from Teacher WHERE IDteacher = '" + id.Trim() + "'";
            RunSQL(sql);
        }

        public DataTable Search(string key)
        {
            string sql = "select IDTeacher,NameTeacher,Birthday,Sex,Andress FROM student WHERE IDTeacher like N'%" + key + "%' OR NameTeacher like N'%" + key + "%' OR Birthday Like N'%" + key + "%' OR SEX like N'%" + key + "%' OR ANdress like N'%" + key + "%'";
            return connect.GetData(sql);
        }

        public string AutoID()
        {
            DataTable tb = GetData();
            List<int> listID = new List<int>();
            string s = "";
            foreach (DataRow dr in tb.Rows)
            {
                s = dr["IdTeacher"].ToString();
                listID.Add(int.Parse(s));
            }
            int max = listID.Count > 0 ? listID.Max() : 1159;
            int id = max + 1;
            string ID = id.ToString();
            return ID;
        }
    }
}
