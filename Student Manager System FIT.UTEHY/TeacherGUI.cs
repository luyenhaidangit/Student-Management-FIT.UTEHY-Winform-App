using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Student_Manager_System_FIT.UTEHY
{
    public partial class TeacherGUI : Form
    {
        public TeacherGUI()
        {
            InitializeComponent();
        }

        public TeacherBUS TeacherBUS = new TeacherBUS();

        public void LoadDataGridView()
        {
            dgvStudent.DataSource = new List<Class>();
            dgvStudent.DataSource = TeacherBUS.GetData();
            dgvStudent.Columns[0].HeaderText = "Mã giáo viên";
            dgvStudent.Columns[1].HeaderText = "Tên giáo viên";
            dgvStudent.Columns[2].HeaderText = "Ngày sinh";
            dgvStudent.Columns[3].HeaderText = "Giới tính";
            dgvStudent.Columns[4].HeaderText = "Địa chỉ";
            dgvStudent.ReadOnly = true;
            dgvStudent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvStudent.AllowUserToResizeRows = false;
        }

        public void LoadComBoBoxSex()
        {
            cbbSex.Items.Add("Nam");
            cbbSex.Items.Add("Nữ");
        }

        public void ResetInput()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtBirthday.Text = "";
            txtAndress.Text = "";
            btnSubmit.Enabled = false;
        }

        public void DefaultStatus()
        {
            submitDelete.Text = "";
            lblDelete.Text = "";
            lblErName.Text = "";
            errName.Text = "";
            errAndress.Text = "";
            errBirthday.Text = "";
            cbbSex.SelectedIndex = 0;
            lblStatus.Text = "Default";
            btnAdd.Enabled = true;
            editBtn.Enabled = true;
            deleteBtn.Enabled = true;
            numberTeacher.Text = TeacherBUS.GetData().Rows.Count.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void TeacherGUI_Load(object sender, EventArgs e)
        {
            ResetInput();
            LoadDataGridView();
            LoadComBoBoxSex();
            DefaultStatus();
            numberTeacher.Text = TeacherBUS.GetData().Rows.Count.ToString();
        }
    }
}
