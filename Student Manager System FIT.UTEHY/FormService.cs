using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Manager_System_FIT.UTEHY
{
    public class FormService
    {
        private static FormService instance;
        public static FormService Instance
        {
            get { if (instance == null) instance = new FormService(); return instance; }
            private set => instance = value;
        }
        public Dictionary<Type, Form> CreatedForms;
        private FormService()
        {
            CreatedForms = new Dictionary<Type, Form>();
        }
    }
}
