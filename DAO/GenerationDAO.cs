using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class GenerationDAO:DBConnect
    {
        public DBConnect connect = new DBConnect();

        public DataTable GetData()
        {
            string sql = "select * from Generation";
            return connect.GetData(sql);
        }

        public void Add(Generation obj)
        {
            string sql = string.Format("INSERT INTO GENERATION VALUES ('{0}',N'{1}',N'{2}')", obj.Id,obj.Name,obj.Desc);
            RunSQL(sql);
        }

        public void Edit(Generation obj)
        {
            string sql = string.Format("update GENERATION set NAME = N'{0}', DES = N'{1}' WHERE ID=N'{2}'", obj.Name, obj.Desc,obj.Id);
            RunSQL(sql);
        }

        public void Delete(string id)
        {
            string sql = "Delete from GENERATION WHERE ID = '" + id.Trim() + "'";
            RunSQL(sql);
        }

        public DataTable Search(string key)
        {
            string sql = "select g.ID,g.Name,g.Des FROM generation g WHERE g.ID like N'%+"+key+"%' OR g.Name like N'%"+key+"%' OR g.Des Like N'%"+key+"%'";
            return connect.GetData(sql);
        }

        public string AutoID()
        {
            DataTable tb = GetData();
            List<int> listID = new List<int>();
            string s = "";
            foreach(DataRow dr in tb.Rows)
            {
                s = dr["Id"].ToString();
                listID.Add(int.Parse(s));
            }
            int max = listID.Count>0?listID.Max():1159;
            int id = max+1;
            string ID = id.ToString();
            return ID;
        } 

        public Generation GetObj(int index)
        {
            DataTable tb = GetData();
            Generation ge = new Generation();
            foreach (DataRow dr in tb.Rows)
            {
                if(tb.Rows.Count == index)
                {
                    ge.Id = dr["Id"].ToString();
                    ge.Name = dr["Name"].ToString();
                    ge.Desc = dr["Description"].ToString();
                }
            }
            return ge;
        }
    }
}
