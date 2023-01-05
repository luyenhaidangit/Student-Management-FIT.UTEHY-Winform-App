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
    public class ScoresBUS
    {
        public ScoresDAO ScoresDAO = new ScoresDAO();

        public DataTable GetData()
        {
            return ScoresDAO.GetData();
        }

        public void Add(Scores obj)
        {
            ScoresDAO.Add(obj);
        }

        public void Edit(Scores obj)
        {
            ScoresDAO.Edit(obj);
        }

        public void Delete(string id,string id1)
        {
            ScoresDAO.Delete(id,id1);
        }

        public DataTable StudentWithScores(string idClass,string idSubject)
        {
            return ScoresDAO.StudentWithScores(idClass,idSubject);
        }
    }
}
