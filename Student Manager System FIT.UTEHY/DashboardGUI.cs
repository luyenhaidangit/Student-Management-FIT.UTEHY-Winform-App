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
    public partial class DashboardGUI : Form
    {
        public DashboardGUI()
        {
            InitializeComponent();
        }

        private void ContainerForm(object form)
        {
            if (panelContainer.Controls.Count > 0)
            {
                panelContainer.Controls.Clear();
            }
            Form fm = form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(fm);
            panelContainer.Tag = fm;
            fm.Show();
        }

        private void DashboardGUI_Load(object sender, EventArgs e)
        {
            this.Text = "Tổng quan";
            nameFormActiveLbl.Text = "Tổng quan";
            ContainerForm(new OverviewGUI());
        }

        private void overviewLinkBtn_Click(object sender, EventArgs e)
        {
            this.Text = "Tổng quan";
            nameFormActiveLbl.Text = "Tổng quan";
            ContainerForm(new OverviewGUI());
        }

        private void generationLinkBtn_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý chuyên ngành đào tạo";
            nameFormActiveLbl.Text = "Quản lý chuyên ngành đào tạo";
            var form = new GenerationGUI();
            if (!FormService.Instance.CreatedForms.ContainsKey(typeof(GenerationGUI)))
            {
                FormService.Instance.CreatedForms.Add(form.GetType(), form);
            }
            else
            {
                FormService.Instance.CreatedForms[typeof(GenerationGUI)] = form;
            }
            ContainerForm(form);
        }

        private void classLinkBtn_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý lớp học";
            nameFormActiveLbl.Text = "Quản lý lớp học";
            var form = new ClassGUI();
            ContainerForm(form);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý sinh viên";
            nameFormActiveLbl.Text = "Quản lý sinh viên";
            var form = new StudentGUI();
            ContainerForm(form);
        }

        private void teacherLinkBtn_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý giáo viên";
            nameFormActiveLbl.Text = "Quản lý giáo viên";
            var form = new TeacherGUI();
            ContainerForm(form);
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý môn học";
            nameFormActiveLbl.Text = "Quản lý môn học";
            var form = new SubjectGUI();
            ContainerForm(form);
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý người dùng";
            nameFormActiveLbl.Text = "Quản lý người dùng";
            var form = new UserGUI();
            ContainerForm(form);
        }

        private void scheduleLinkBtn_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý lịch học";
            nameFormActiveLbl.Text = "Quản lý lịch học";
            var form = new ScheduleGUI();
            ContainerForm(form);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý điểm số";
            nameFormActiveLbl.Text = "Quản lý điểm số";
            var form = new ScoresGUI();
            ContainerForm(form);
        }
    }
}
