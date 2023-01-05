using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class SubjectDAO:DBConnect
    {
        public DBConnect connect = new DBConnect();

        public DataTable GetData()
        {
            string sql = "select * from Subject";
            return connect.GetData(sql);
        }
    }
}
