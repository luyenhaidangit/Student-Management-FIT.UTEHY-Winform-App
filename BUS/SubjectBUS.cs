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
    public class SubjectBUS
    {
        public SubjectDAO SubjectDAO = new SubjectDAO();

        public DataTable GetData()
        {
            return SubjectDAO.GetData();
        }
    }
}
