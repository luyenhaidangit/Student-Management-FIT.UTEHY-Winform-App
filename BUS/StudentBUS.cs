using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class StudentBUS
    {
        public StudentDAO StudentDAO = new StudentDAO();

        public DataTable GetData()
        {
            return StudentDAO.GetData();
        }

        public void Add(Student obj)
        {
            StudentDAO.Add(obj);
        }

        public void Edit(Student obj)
        {
            StudentDAO.Edit(obj);
        }

        public void Delete(string id)
        {
            StudentDAO.Delete(id);
        }

        public string AutoID()
        {
            return StudentDAO.AutoID();
        }

        public DataTable Search(string key)
        {
            return StudentDAO.Search(key);
        }
    }
}
