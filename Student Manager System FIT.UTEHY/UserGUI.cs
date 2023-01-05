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
    public partial class UserGUI : Form
    {
        public UserGUI()
        {
            InitializeComponent();
        }

        public UserBUS UserBUS = new UserBUS();


        public void LoadDataGridView()
        {
            dgvClass.DataSource = new List<Class>();
            dgvClass.DataSource = UserBUS.GetData();
            //MessageBox.Show(ClassBUS.GetData().Rows[0][1].ToString());
            dgvClass.Columns[0].HeaderText = "Tên tài khoản";
            dgvClass.Columns[1].HeaderText = "Mật khẩu";
            dgvClass.Columns[2].HeaderText = "Loại người dùng";
            dgvClass.ReadOnly = true;
            dgvClass.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvClass.AllowUserToResizeRows = false;
        }

        public void LoadComboBoxGeneration()
        {
            cbbGeneration.Items.Add("Quản trị hệ thống");
            cbbGeneration.Items.Add("Giáo viên");
            cbbGeneration.Items.Add("Sinh viên");
        }

        public void ResetInput()
        {
            txtID.Text = "";
            txtName.Text = "";
            btnSubmit.Enabled = false;
        }

        public void DefaultStatus()
        {
            lblDelete.Text = "";
            lblErName.Text = "";
            cbbGeneration.SelectedIndex = 0;
            lblStatus.Text = "Default";
            btnAdd.Enabled = true;
            editBtn.Enabled = true;
            deleteBtn.Enabled = true;
            numberClass.Text = UserBUS.GetData().Rows.Count.ToString();
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

        private void UserGUI_Load(object sender, EventArgs e)
        {
            ResetInput();
            LoadDataGridView();
            LoadComboBoxGeneration();
            numberClass.Text = UserBUS.GetData().Rows.Count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStatus();
            txtID.Text = UserBUS.AutoID();
            txtName.Focus();
            btnSubmit.Enabled = true;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
            EditStatus();
            int index = int.Parse(label1.Text);
            txtID.Text = dgvClass[0, index].Value.ToString();
            txtName.Text = dgvClass[1, index].Value.ToString();
            cbbGeneration.SelectedIndex = GetSelectedIndexComboBoxType(dgvClass[2, index].Value.ToString());
        }

        public int GetSelectedIndexComboBoxType(string value)
        {
            if (value == "Quản trị hệ thống")
            {
                return 0;
            }
            else if(value == "Giáo viên")
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
            DeleteStatus();
            int index = int.Parse(label1.Text);
            txtID.Text = dgvClass[0, index].Value.ToString();
            txtName.Text = dgvClass[1, index].Value.ToString();
            cbbGeneration.SelectedIndex = GetSelectedIndexComboBoxType(dgvClass[2, index].Value.ToString());
            lblDelete.Text = "Bạn có chắc muốn xóa?";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text == "Delete")
            {
                UserBUS.Delete(txtID.Text);
                LoadDataGridView();
                DefaultStatus();
                ResetInput();
            }
            else
            {
                if (txtName.Text.Trim() == "")
                {
                    lblErName.Text = "Tên người dùng không được để trống, thử lại!";
                    txtName.Focus();
                }
                else
                {
                    if (lblStatus.Text == "Add")
                    {
                        User cl = new User();
                        cl.Id = txtID.Text;
                        cl.Password = txtName.Text.Trim();
                        cl.Type = cbbGeneration.Text.ToString();
                        UserBUS.Add(cl);
                        LoadDataGridView();
                        DefaultStatus();
                        ResetInput();
                    }
                    else if (lblStatus.Text == "Edit")
                    {
                        User cl = new User();
                        cl.Id = txtID.Text;
                        cl.Password = txtName.Text.Trim();
                        cl.Type = cbbGeneration.Text.ToString();
                        UserBUS.Edit(cl);
                        LoadDataGridView();
                        DefaultStatus();
                        ResetInput();
                    }

                }
            }
        }
    }
}
