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
    public partial class SubjectGUI : Form
    {
        public SubjectGUI()
        {
            InitializeComponent();
        }

        public SubjectBUS SubjectBUS = new SubjectBUS();

        public void LoadDataGridView()
        {
            dgvStudent.DataSource = new List<Class>();
            dgvStudent.DataSource = SubjectBUS.GetData();
            dgvStudent.Columns[0].HeaderText = "Mã môn học";
            dgvStudent.Columns[1].HeaderText = "Tên môn học";
            dgvStudent.Columns[2].HeaderText = "Số tín chỉ";
            dgvStudent.ReadOnly = true;
            dgvStudent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvStudent.AllowUserToResizeRows = false;
        }

        public void ResetInput()
        {
            txtID.Text = "";
            txtName.Text = "";
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
            lblStatus.Text = "Default";
            btnAdd.Enabled = true;
            editBtn.Enabled = true;
            deleteBtn.Enabled = true;
            numberStudent.Text = SubjectBUS.GetData().Rows.Count.ToString();
        }

        private void SubjectGUI_Load(object sender, EventArgs e)
        {
            ResetInput();
            DefaultStatus();
            LoadDataGridView();
            numberStudent.Text = SubjectBUS.GetData().Rows.Count.ToString();
        }
    }
}
