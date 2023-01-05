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
    public partial class LoginGUI : Form
    {
        public LoginGUI()
        {
            InitializeComponent();
        }

        public UserBUS UserBUS = new UserBUS();

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginGUI_Load(object sender, EventArgs e)
        {
            lblErr.Text = "";
        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            List<int> listID = new List<int>();
            string s = "";
            string s1 = "";
            string x = txtID.Text.ToString();
            string x1 = txtPassword.Text.ToString();
            if (x == "admin" && x1 == "admin")
            {
                LoadingGUI loadingGUI = new LoadingGUI();
                this.Hide();
                loadingGUI.Show();
            }
            bool check = false;
            foreach (DataRow dr in dt.Rows)
            {
                s = dr["Id"].ToString();
                s1 = dr["Password"].ToString();
                
                
            }
            if (check)
            {
                LoadingGUI loadingGUI = new LoadingGUI();
                this.Hide();
                loadingGUI.Show();
            }
            else
            {
                lblErr.Text = "Tên tài khoản hoặc mật khẩu không đúng, thử lại!";
            }
            
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
