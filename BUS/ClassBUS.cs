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
    public class ClassBUS
    {
        public ClassDAO ClassDAO = new ClassDAO();

        public DataTable GetData()
        {
            return ClassDAO.GetData();
        }

        public DataTable GetDataDisplayName()
        {
            return ClassDAO.GetDataDisplayName();
        }

        public void Add(Class obj)
        {
            ClassDAO.Add(obj);
        }

        public void Edit(Class obj)
        {
            ClassDAO.Edit(obj);
        }

        public void Delete(string id)
        {
            ClassDAO.Delete(id);
        }

        public DataTable Search(string key)
        {
            return ClassDAO.Search(key);
        }

        public string AutoID()
        {
            return ClassDAO.AutoID();
        }

        public Class GetObj(int index)
        {
            return ClassDAO.GetObj(index);
        }
    }
}
