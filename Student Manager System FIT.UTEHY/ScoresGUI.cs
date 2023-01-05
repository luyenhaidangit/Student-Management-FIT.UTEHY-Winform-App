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
    public partial class ScoresGUI : Form
    {
        public ScoresGUI()
        {
            InitializeComponent();
        }

        public ScoresBUS ScoresBUS = new ScoresBUS();

        public StudentBUS StudentBUS = new StudentBUS();

        public SubjectBUS SubjectBUS = new SubjectBUS();

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        public void LoadDataGridView()
        {
            dgvScores.DataSource = new List<Class>();
            dgvScores.DataSource = ScoresBUS.GetData();
            dgvScores.Columns[0].HeaderText = "Mã sinh viên";
            dgvScores.Columns[1].HeaderText = "Mã môn học";
            dgvScores.Columns[2].HeaderText = "Điểm QT";
            dgvScores.Columns[3].HeaderText = "Điểm KTHP";
            dgvScores.ReadOnly = true;
            dgvScores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvScores.AllowUserToResizeRows = false;
        }

        public void LoadComboBoxStudent()
        {
            cbbStudent.DataSource = StudentBUS.GetData();
            cbbStudent.DisplayMember = "NameStudent";
            cbbStudent.ValueMember = "IDStudent";
        }

        public void LoadComboBoxSubject()
        {
            cbbSubject.DataSource = SubjectBUS.GetData();
            cbbSubject.DisplayMember = "NameSubject";
            cbbSubject.ValueMember = "IDSubject";
        }

        public void DefaultStatus()
        {
            txtMark1 = null;
            txtMark2 = null;
            submitDelete.Text = "";
            lblDelete.Text = "";
            lblErName.Text = "";
            errSemester.Text = "";
            errTeacher.Text = "";
            errClass.Text = "";
            errSubject.Text = "";
            lblStatus.Text = "Default";
            btnAdd.Enabled = true;
            editBtn.Enabled = true;
            deleteBtn.Enabled = true;
            numberStudent.Text = ScoresBUS.GetData().Rows.Count.ToString();
            btnSubmit.Enabled = false;
        }

        private void ScoresGUI_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadComboBoxStudent();
            LoadComboBoxSubject();
            DefaultStatus();
        }

        public void AddStatus()
        {
            lblStatus.Text = "Add";
            editBtn.Enabled = false;
            deleteBtn.Enabled = false;
        }

        public void EditStatus()
        {
            lblStatus.Text = "Edit";
            btnAdd.Enabled = false;
            deleteBtn.Enabled = false;
        }

        public void DeleteStatus()
        {
            lblStatus.Text = "Delete";
            btnAdd.Enabled = false;
            editBtn.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DefaultStatus();
        }

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    AddStatus();
        //    btnSubmit.Enabled = true;
        //}

        //private void editBtn_Click(object sender, EventArgs e)
        //{
        //    btnSubmit.Enabled = true;
        //    EditStatus();
        //    int index = int.Parse(label1.Text);
        //    cbbStudent.SelectedIndex = GetSelectedIndexComboBoxStudent(dgvScores[0, index].Value.ToString());
        //    cbbSubject.SelectedIndex = GetSelectedIndexComboBoxSubject(dgvScores[1, index].Value.ToString());
        //    txtMark1.Text = dgvScores[2, index].Value.ToString();
        //    txtMark2.Text = dgvScores[3, index].Value.ToString();
        //}

        //private void deleteBtn_Click(object sender, EventArgs e)
        //{
        //    btnSubmit.Enabled = true;
        //    DeleteStatus();
        //    int index = int.Parse(label1.Text);
        //    cbbStudent.SelectedIndex = GetSelectedIndexComboBoxStudent(dgvScores[0, index].Value.ToString());
        //    cbbSubject.SelectedIndex = GetSelectedIndexComboBoxSubject(dgvScores[1, index].Value.ToString());
        //    txtMark1.Text = dgvScores[2, index].Value.ToString();
        //    txtMark2.Text = dgvScores[3, index].Value.ToString();
        //    submitDelete.Text = "Bạn có chắc muốn xóa?";
        //}

        //public int GetSelectedIndexComboBoxStudent(string id)
        //{
        //    DataTable tb = StudentBUS.GetData();
        //    int i = 0;
        //    foreach (DataRow dr in tb.Rows)
        //    {
        //        if (dr["IDStudent"].ToString() == id)
        //        {
        //            return i;
        //        }
        //        i++;
        //    }
        //    return i;
        //}

        //public int GetSelectedIndexComboBoxSubject(string id)
        //{
        //    DataTable tb = SubjectBUS.GetData();
        //    int i = 0;
        //    foreach (DataRow dr in tb.Rows)
        //    {
        //        if (dr["IDSubject"].ToString() == id)
        //        {
        //            return i;
        //        }
        //        i++;
        //    }
        //    return i;
        //}

        //private void dgvScores_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int y = e.RowIndex;
        //    label1.Text = y.ToString();
        //}

        //private void btnSubmit_Click(object sender, EventArgs e)
        //{
        //    if (lblStatus.Text == "Delete")
        //    {
        //        ScoresBUS.Delete(cbbStudent.SelectedValue.ToString(), cbbSubject.SelectedValue.ToString());
        //        LoadDataGridView();
        //        DefaultStatus();
        //    }
        //    else
        //    {
        //        bool check = true;
        //        if (cbbStudent.SelectedValue.ToString() == null)
        //        {
        //            errClass.Text = "Mã sinh viên không để trống, thử lại";
        //            check = false;
        //        }
        //        else
        //        {
        //            errClass.Text = "";
        //        }
        //        if (cbbSubject.SelectedValue.ToString() == null)
        //        {
        //            errSubject.Text = "Môn học không để trống, thử lại";
        //            check = false;
        //        }
        //        else
        //        {
        //            errSubject.Text = "";
        //        }
        //        if (check == true)
        //        {
        //            if (lblStatus.Text == "Add")
        //            {
        //                Scores sc = new Scores();
        //                sc.IdStudent = cbbStudent.SelectedValue.ToString();
        //                sc.IdSubject = cbbSubject.SelectedValue.ToString();
        //                sc.Mark1 = int.Parse(txtMark1.Text.ToString());
        //                sc.Mark2 = int.Parse(txtMark2.Text.ToString());
        //                ScoresBUS.Add(sc);
        //                LoadDataGridView();
        //                DefaultStatus();
        //            }
        //            else if (lblStatus.Text == "Edit")
        //            {
        //                Scores sc = new Scores();
        //                sc.IdStudent = cbbStudent.SelectedValue.ToString();
        //                sc.IdSubject = cbbSubject.SelectedValue.ToString();
        //                sc.Mark1 = int.Parse(txtMark1.Text.ToString());
        //                sc.Mark2 = int.Parse(txtMark2.Text.ToString());
        //                ScoresBUS.Edit(sc);
        //                LoadDataGridView();
        //                DefaultStatus();
        //            }
        //        }
        //    }
        //}
    }
}
