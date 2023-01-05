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
    public partial class StudentGUI : Form
    {
        public StudentGUI()
        {
            InitializeComponent();
        }

        public StudentBUS StudentBUS = new StudentBUS();

        public ClassBUS ClassBUS = new ClassBUS();

        public void LoadDataGridView()
        {
            dgvStudent.DataSource = new List<Class>();
            dgvStudent.DataSource = StudentBUS.GetData();
            dgvStudent.Columns[0].HeaderText = "Mã sinh viên";
            dgvStudent.Columns[1].HeaderText = "Tên sinh viên";
            dgvStudent.Columns[2].HeaderText = "Ngày sinh";
            dgvStudent.Columns[3].HeaderText = "Giới tính";
            dgvStudent.Columns[4].HeaderText = "Địa chỉ";
            dgvStudent.Columns[5].HeaderText = "Lớp học";
            dgvStudent.ReadOnly = true;
            dgvStudent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvStudent.AllowUserToResizeRows = false;
        }

        public void LoadComBoBoxSex()
        {
            cbbSex.Items.Add("Nam");
            cbbSex.Items.Add("Nữ");
        }

        public void LoadComboBoxClass()
        {
            cbbClass.DataSource = ClassBUS.GetData();
            cbbClass.DisplayMember = "NameClass";
            cbbClass.ValueMember = "IDClass";
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
            errIDClass.Text = "";
            errAndress.Text = "";
            errBirthday.Text = "";
            cbbSex.SelectedIndex = 0;
            cbbClass.SelectedIndex = 0;
            lblStatus.Text = "Default";
            btnAdd.Enabled = true;
            editBtn.Enabled = true;
            deleteBtn.Enabled = true;
            numberStudent.Text = StudentBUS.GetData().Rows.Count.ToString();
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

        private void StudentGUI_Load(object sender, EventArgs e)
        {
            ResetInput();
            LoadDataGridView();
            LoadComBoBoxSex();
            LoadComboBoxClass();
            DefaultStatus();
            numberStudent.Text = StudentBUS.GetData().Rows.Count.ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DefaultStatus();
            ResetInput();
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.RowIndex;
            label1.Text = y.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStatus();
            txtID.Text = StudentBUS.AutoID();
            txtName.Focus();
            btnSubmit.Enabled = true;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
            EditStatus();
            int index = int.Parse(label1.Text);
            txtID.Text = dgvStudent[0, index].Value.ToString();
            txtName.Text = dgvStudent[1, index].Value.ToString();
            txtBirthday.Text = dgvStudent[2, index].Value.ToString();
            cbbSex.SelectedIndex = GetSelectedIndexComboBoxSex(dgvStudent[3, index].Value.ToString());
            txtAndress.Text = dgvStudent[4, index].Value.ToString();
            cbbClass.SelectedIndex = GetSelectedIndexComboBoxClass(dgvStudent[5, index].Value.ToString());
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
            DeleteStatus();
            int index = int.Parse(label1.Text);
            txtID.Text = dgvStudent[0, index].Value.ToString();
            txtName.Text = dgvStudent[1, index].Value.ToString();
            txtBirthday.Text = dgvStudent[2, index].Value.ToString();
            cbbSex.SelectedIndex = GetSelectedIndexComboBoxSex(dgvStudent[3, index].Value.ToString());
            txtAndress.Text = dgvStudent[4, index].Value.ToString();
            cbbClass.SelectedIndex = GetSelectedIndexComboBoxClass(dgvStudent[5, index].Value.ToString());
            submitDelete.Text = "Bạn có chắc muốn xóa?";
        }

        public int GetSelectedIndexComboBoxSex(string value)
        {
            if (value == "Nam")
            {
                return 0;
            }
            else return 1;
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

        public string FormatDate(string date)
        {
            string[] arr = date.Split('/');
            string dateString = arr[2] + "-" + arr[1] + "-" + arr[0];
            return dateString;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text == "Delete")
            {
                StudentBUS.Delete(txtID.Text);
                LoadDataGridView();
                DefaultStatus();
                ResetInput();
            }
            else
            {
                bool check = true;
                if (cbbClass.SelectedValue.ToString() == null)
                {
                    errIDClass.Text = "Mã lớp không để trống, thử lại";
                    check = false;
                }
                else
                {
                    errIDClass.Text = "";
                }
                if (txtAndress.Text.Trim() == "")
                {
                    errAndress.Text = "Địa chỉ không để trống, thử lại";
                    txtAndress.Focus();
                    check = false;
                }
                else
                {
                    errAndress.Text = "";
                }
                if(txtBirthday.MaskCompleted==false)
                {
                    errBirthday.Text = "Ngày sinh không để trống, thử lại";
                    txtBirthday.Focus();
                    check = false;
                }
                else
                {
                    errBirthday.Text = "";
                }
                if (txtName.Text.Trim() == "")
                {
                    errName.Text = "Tên không được để trống, thử lại";
                    txtName.Focus();
                    check = false;
                }
                else
                {
                    errName.Text = "";
                }
                if(check == true)
                {
                    if (lblStatus.Text == "Add")
                    {
                        Student st = new Student();
                        st.IdStudent = txtID.Text;
                        st.NameStudent = txtName.Text.Trim();
                        st.Birthday = FormatDate(txtBirthday.Text.Trim());
                        st.Sex = cbbSex.Text.Trim();
                        st.Andress = txtAndress.Text.ToString();
                        st.IdClass = cbbClass.SelectedValue.ToString();
                        StudentBUS.Add(st);
                        LoadDataGridView();
                        DefaultStatus();
                        ResetInput();
                    }
                    else if (lblStatus.Text == "Edit")
                    {
                        Student st = new Student();
                        st.IdStudent = txtID.Text;
                        st.NameStudent = txtName.Text.Trim();
                        st.Birthday = FormatDate(txtBirthday.Text.Trim());
                        st.Sex = cbbSex.Text.Trim();
                        st.Andress = txtAndress.Text.ToString();
                        st.IdClass = cbbClass.SelectedValue.ToString();
                        StudentBUS.Edit(st);
                        LoadDataGridView();
                        DefaultStatus();
                        ResetInput();
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string key = txtSearch.Text;
            dgvStudent.DataSource = new List<Generation>();
            dgvStudent.DataSource = StudentBUS.Search(key);
            dgvStudent.Columns[0].HeaderText = "Mã sinh viên";
            dgvStudent.Columns[1].HeaderText = "Tên sinh viên";
            dgvStudent.Columns[2].HeaderText = "Ngày sinh";
            dgvStudent.Columns[3].HeaderText = "Giới tính";
            dgvStudent.Columns[4].HeaderText = "Địa chỉ";
            dgvStudent.Columns[5].HeaderText = "Lớp học";
            dgvStudent.ReadOnly = true;
            dgvStudent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvStudent.AllowUserToResizeRows = false;
        }
    }
}
