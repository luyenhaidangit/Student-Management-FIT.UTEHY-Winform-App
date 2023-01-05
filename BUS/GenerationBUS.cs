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
    public class GenerationBUS
    {
        public GenerationDAO GenerationDAO = new GenerationDAO();

        public DataTable GetData()
        {
            return GenerationDAO.GetData();
        }

        public void Add(Generation obj)
        {
            GenerationDAO.Add(obj);
        }

        public void Edit(Generation obj)
        {
            GenerationDAO.Edit(obj);
        }

        public void Delete(string id)
        {
            GenerationDAO.Delete(id);
        }

        public DataTable Search(string key)
        {
            return GenerationDAO.Search(key);
        }

        public string AutoID()
        {
            return GenerationDAO.AutoID();
        }

        public Generation GetObj(int index)
        {
            return GenerationDAO.GetObj(index);
        }
    }
}
