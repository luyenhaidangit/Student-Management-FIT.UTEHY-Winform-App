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
    public partial class ScheduleGUI : Form
    {
        public ScheduleGUI()
        {
            InitializeComponent();
        }

        public ScheduleBUS ScheduleBUS = new ScheduleBUS();

        public ClassBUS ClassBUS = new ClassBUS();

        public SubjectBUS SubjectBUS = new SubjectBUS();

        public TeacherBUS TeacherBUS = new TeacherBUS();

        public void LoadDataGridView()
        {
            dgvSchedule.DataSource = new List<Class>();
            dgvSchedule.DataSource = ScheduleBUS.GetData();
            dgvSchedule.Columns[0].HeaderText = "Lớp học";
            dgvSchedule.Columns[1].HeaderText = "Kỳ học";
            dgvSchedule.Columns[2].HeaderText = "Môn học";
            dgvSchedule.Columns[3].HeaderText = "Giáo viên";
            dgvSchedule.ReadOnly = true;
            dgvSchedule.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvSchedule.AllowUserToResizeRows = false;
        }

        public void LoadComboBoxClass()
        {
            cbbClass.DataSource = ClassBUS.GetData();
            cbbClass.DisplayMember = "NameClass";
            cbbClass.ValueMember = "IDClass";
        }

        public void LoadComBoBoxSemester()
        {
            cbbSemester.Items.Add(1);
            cbbSemester.Items.Add(2);
            cbbSemester.Items.Add(3);
            cbbSemester.Items.Add(4);
            cbbSemester.Items.Add(5);
            cbbSemester.Items.Add(6);
            cbbSemester.Items.Add(7);
            cbbSemester.Items.Add(8);
        }

        public void LoadComboBoxSubject()
        {
            cbbSubject.DataSource = SubjectBUS.GetData();
            cbbSubject.DisplayMember = "NameSubject";
            cbbSubject.ValueMember = "IDSubject";
        }

        public void LoadComboBoxTeacher()
        {
            cbbTeacher.DataSource = TeacherBUS.GetData();
            cbbTeacher.DisplayMember = "NameTeacher";
            cbbTeacher.ValueMember = "IDTeacher";
        }

        public void DefaultStatus()
        {
            submitDelete.Text = "";
            lblDelete.Text = "";
            lblErName.Text = "";
            errSemester.Text = "";
            errTeacher.Text = "";
            errClass.Text = "";
            errSubject.Text = "";
            cbbSemester.SelectedIndex = 0;
            cbbClass.SelectedIndex = 0;
            lblStatus.Text = "Default";
            btnAdd.Enabled = true;
            editBtn.Enabled = true;
            deleteBtn.Enabled = true;
            numberStudent.Text = ScheduleBUS.GetData().Rows.Count.ToString();
            btnSubmit.Enabled = false;
        }

        private void ScheduleGUI_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadComboBoxClass();
            LoadComBoBoxSemester();
            LoadComboBoxSubject();
            LoadComboBoxTeacher();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStatus();
            btnSubmit.Enabled = true;
        }

        private void dgvSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.RowIndex;
            label1.Text = y.ToString();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
            EditStatus();
            int index = int.Parse(label1.Text);
            cbbClass.SelectedIndex = GetSelectedIndexComboBoxClass(dgvSchedule[0, index].Value.ToString());
            cbbSemester.SelectedIndex = GetSelectedIndexComboBoxSemester(dgvSchedule[1, index].Value.ToString());
            cbbSubject.SelectedIndex = GetSelectedIndexComboBoxSubject(dgvSchedule[2, index].Value.ToString());
            cbbTeacher.SelectedIndex = GetSelectedIndexComboBoxTeacher(dgvSchedule[3, index].Value.ToString());
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
            DeleteStatus();
            int index = int.Parse(label1.Text);
            cbbClass.SelectedIndex = GetSelectedIndexComboBoxClass(dgvSchedule[0, index].Value.ToString());
            cbbSemester.SelectedIndex = GetSelectedIndexComboBoxSemester(dgvSchedule[1, index].Value.ToString());
            cbbSubject.SelectedIndex = GetSelectedIndexComboBoxSubject(dgvSchedule[2, index].Value.ToString());
            cbbTeacher.SelectedIndex = GetSelectedIndexComboBoxTeacher(dgvSchedule[3, index].Value.ToString());
            submitDelete.Text = "Bạn có chắc muốn xóa?";
        }

        public int GetSelectedIndexComboBoxClass(string id)
        {
            DataTable tb = ClassBUS.GetData();
            int i = 0;
            foreach (DataRow dr in tb.Rows)
            {
                if (dr["IDClass"].ToString() == id)
                {
                    return i;
                }
                i++;
            }
            return i;
        }

        public int GetSelectedIndexComboBoxSemester(string value)
        {
            int i = int.Parse(value);
            return i-1;
        }

        public int GetSelectedIndexComboBoxSubject(string id)
        {
            DataTable tb = SubjectBUS.GetData();
            int i = 0;
            foreach (DataRow dr in tb.Rows)
            {
                if (dr["IDSubject"].ToString() == id)
                {
                    return i;
                }
                i++;
            }
            return i;
        }

        public int GetSelectedIndexComboBoxTeacher(string id)
        {
            DataTable tb = TeacherBUS.GetData();
            int i = 0;
            foreach (DataRow dr in tb.Rows)
            {
                if (dr["IDTeacher"].ToString() == id)
                {
                    return i;
                }
                i++;
            }
            return i;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text == "Delete")
            {
                ScheduleBUS.Delete(cbbClass.SelectedValue.ToString(), cbbSubject.SelectedValue.ToString());
                LoadDataGridView();
                DefaultStatus();
            }
            else
            {
                bool check = true;
                if (cbbClass.SelectedValue.ToString() == null)
                {
                    errClass.Text = "Mã lớp không để trống, thử lại";
                    check = false;
                }
                else
                {
                    errClass.Text = "";
                }
                if (cbbSubject.SelectedValue.ToString() == null)
                {
                    errSubject.Text = "Môn học không để trống, thử lại";
                    check = false;
                }
                else
                {
                    errSubject.Text = "";
                }
                if (cbbTeacher.SelectedValue.ToString() == null)
                {
                    errTeacher.Text = "Môn học không để trống, thử lại";
                    check = false;
                }
                else
                {
                    errTeacher.Text = "";
                }
                if (check == true)
                {
                    if (lblStatus.Text == "Add")
                    {
                        Schedule sc = new Schedule();
                        sc.IdClass = cbbClass.SelectedValue.ToString();
                        sc.Semester = int.Parse(cbbSemester.Text.ToString());
                        sc.IdSubject = cbbSubject.SelectedValue.ToString();
                        sc.IdTeacher = cbbTeacher.SelectedValue.ToString();
                        ScheduleBUS.Add(sc);
                        LoadDataGridView();
                        DefaultStatus();
                    }
                    else if (lblStatus.Text == "Edit")
                    {
                        Schedule sc = new Schedule();
                        sc.IdClass = cbbClass.SelectedValue.ToString();
                        sc.Semester = int.Parse(cbbSemester.Text.Trim());
                        sc.IdSubject = cbbSubject.SelectedValue.ToString();
                        sc.IdTeacher = cbbTeacher.SelectedValue.ToString();
                        ScheduleBUS.Edit(sc);
                        LoadDataGridView();
                        DefaultStatus();
                    }
                }
            }
        }
    }
}
