using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class UserDAO:DBConnect
    {
        public DBConnect connect = new DBConnect();

        public DataTable GetData()
        {
            string sql = "select * from usersystem";
            return connect.GetData(sql);
        }

        public void Add(User obj)
        {
            string sql = string.Format("INSERT INTO Usersystem VALUES (N'{0}',N'{1}',N'{2}')", obj.Id, obj.Password, obj.Type);
            RunSQL(sql);
        }

        public void Edit(User obj)
        {
            string sql = string.Format("update usersystem set password = N'{0}', type = N'{1}' WHERE id=N'{2}'", obj.Password, obj.Type, obj.Id);
            RunSQL(sql);
        }

        public void Delete(string id)
        {
            string sql = "Delete from usersystem WHERE ID = '" + id.Trim() + "'";
            RunSQL(sql);
        }

        public string AutoID()
        {
            DataTable tb = GetData();
            List<int> listID = new List<int>();
            string s = "";
            foreach (DataRow dr in tb.Rows)
            {
                s = dr["Id"].ToString();
                listID.Add(int.Parse(s));
            }
            int max = listID.Count > 0 ? listID.Max() : 0;
            int id = max + 1;
            string ID = id.ToString();
            return ID;
        }
    }
}
