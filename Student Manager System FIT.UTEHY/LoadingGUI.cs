using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Manager_System_FIT.UTEHY
{
    public partial class LoadingGUI : Form
    {
        public LoadingGUI()
        {
            InitializeComponent();
        }

    

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            guna2CircleProgressBar1.Increment(1);
            if (guna2CircleProgressBar1.Value == 10)
            {
                timer1.Stop();
                DashboardGUI dashboardGUI = new DashboardGUI();
                dashboardGUI.Show();
                this.Hide();
            }
        }

        private void LoadingGUI_Load(object sender, EventArgs e)
        {
            guna2CircleProgressBar1.Value = 0;
            timer1.Start();
        }
    }
}
