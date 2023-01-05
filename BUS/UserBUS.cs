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
    public class UserBUS
    {
        public UserDAO UserDAO = new UserDAO();

        public DataTable GetData()
        {
            return UserDAO.GetData();
        }

        public void Add(User obj)
        {
            UserDAO.Add(obj);
        }

        public void Edit(User obj)
        {
            UserDAO.Edit(obj);
        }

        public void Delete(string id)
        {
            UserDAO.Delete(id);
        }

        public string AutoID()
        {
            return UserDAO.AutoID();
        }
    }
}
