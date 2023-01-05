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
    public class ScheduleBUS
    {
        public ScheduleDAO ScheduleDAO = new ScheduleDAO();

        public DataTable GetData()
        {
            return ScheduleDAO.GetData();
        }

        public void Add(Schedule obj)
        {
            ScheduleDAO.Add(obj);
        }

        public void Edit(Schedule obj)
        {
            ScheduleDAO.Edit(obj);
        }

        public void Delete(string id,string id1)
        {
            ScheduleDAO.Delete(id,id1);
        }
    }
}
