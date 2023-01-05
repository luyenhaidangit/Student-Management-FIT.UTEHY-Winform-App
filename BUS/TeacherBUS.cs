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
    public class TeacherBUS
    {
        public TeacherDAO TeacherDAO = new TeacherDAO();

        public DataTable GetData()
        {
            return TeacherDAO.GetData();
        }
    }
}
