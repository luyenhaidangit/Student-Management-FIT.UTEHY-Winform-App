using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace Student_Manager_System_FIT.UTEHY
{
    public partial class OverviewGUI : Form
    {
        public OverviewGUI()
        {
            InitializeComponent();
        }

        public GenerationBUS GenerationBUS = new GenerationBUS();

        public StudentBUS StudentBUS = new StudentBUS();

        public ClassBUS ClassBUS = new ClassBUS();

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {

        }

        private void OverviewGUI_Load(object sender, EventArgs e)
        {
            numberGe.Text = GenerationBUS.GetData().Rows.Count.ToString();
            numberClass.Text = ClassBUS.GetData().Rows.Count.ToString();
            numberStudent.Text = StudentBUS.GetData().Rows.ToString();
        }
    }
}
