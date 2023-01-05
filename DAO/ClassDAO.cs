using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class ClassDAO:DBConnect
    {
        public DBConnect connect = new DBConnect();

        public DataTable GetData()
        {
            string sql = "select * from Class";
            return connect.GetData(sql);
        }

        public DataTable GetDataDisplayName()
        {
            string sql = "select c.idclass,c.nameclass,g.name from class c inner join generation g on c.IDGENERATION = g.id";
            return connect.GetData(sql);
        }

        public void Add(Class obj)
        {
            string sql = string.Format("INSERT INTO CLASS VALUES (N'{0}',N'{1}',N'{2}')", obj.Id, obj.Name, obj.IdGeneration);
            RunSQL(sql);
        }

        public void Edit(Class obj)
        {
            string sql = string.Format("update CLASS set NAMECLASS = N'{0}', IDGENERATION = N'{1}' WHERE IDCLASS=N'{2}'", obj.Name, obj.IdGeneration, obj.Id);
            RunSQL(sql);
        }

        public void Delete(string id)
        {
            string sql = "Delete from CLASS WHERE IDCLASS = '" + id.Trim() + "'";
            RunSQL(sql);
        }

        public DataTable Search(string key)
        {
            string sql = "select IDCLASS,NameClass,IDGENERATION FROM class WHERE IDCLASS like N'%+" + key + "%' OR NameClass like N'%" + key + "%' OR IDGENERATION Like N'%" + key + "%'";
            return connect.GetData(sql);
        }

        public string AutoID()
        {
            DataTable tb = GetData();
            List<int> listID = new List<int>();
            string s = "";
            foreach (DataRow dr in tb.Rows)
            {
                s = dr["IdClass"].ToString();
                listID.Add(int.Parse(s));
            }
            int max = listID.Count > 0 ? listID.Max() : 125200;
            int id = max + 1;
            string ID = id.ToString();
            return ID;
        }

        public Class GetObj(int index)
        {
            DataTable tb = GetData();
            Class cl = new Class();
            foreach (DataRow dr in tb.Rows)
            {
                if (tb.Rows.Count == index)
                {
                    cl.Id = dr["IdClass"].ToString();
                    cl.Name = dr["NameClass"].ToString();
                    cl.IdGeneration = dr["IDGENERATION"].ToString();
                }
            }
            return cl;
        }
    }
}
