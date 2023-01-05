using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class ScheduleDAO:DBConnect
    {
        public DBConnect connect = new DBConnect();

        public DataTable GetData()
        {
            string sql = "select * from Schedule";
            return connect.GetData(sql);
        }

        public void Add(Schedule obj)
        {
            string sql = string.Format("INSERT INTO Schedule VALUES (N'{0}',{1},N'{2}',N'{3}')", obj.IdClass, obj.Semester, obj.IdSubject, obj.IdTeacher);
            RunSQL(sql);
        }

        public void Edit(Schedule obj)
        {
            string sql = string.Format("update schedule set semester = {0}, idteacher = '{1}' WHERE IDClass=N'{2}' AND IDSUBJECT = N'{3}'", obj.Semester, obj.IdTeacher, obj.IdClass, obj.IdSubject);
            RunSQL(sql);
        }

        public void Delete(string id,string id1)
        {
            string sql = "Delete from schedule WHERE IDClass = '" + id.Trim() + "' AND IDSubject ='"+id1.Trim()+"'";
            RunSQL(sql);
        }

        public DataTable Search(string key)
        {
            string sql = "select IDStudent,NameStudent,Birthday,Sex,Andress,IDclass FROM student WHERE IDStudent like N'%" + key + "%' OR NameStudent like N'%" + key + "%' OR Birthday Like N'%" + key + "%' OR SEX like N'%" + key + "%' OR ANdress like N'%" + key + "%' OR IDclass like N'%" + key + "%'";
            return connect.GetData(sql);
        }
    }
}
