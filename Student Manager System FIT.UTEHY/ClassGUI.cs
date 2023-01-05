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
    public partial class ClassGUI : Form
    {
        public ClassGUI()
        {
            InitializeComponent();
        }

        public ClassBUS ClassBUS = new ClassBUS();

        public GenerationBUS GenerationBUS = new GenerationBUS();

        public void LoadDataGridView()
        {
            dgvClass.DataSource = new List<Class>();
            dgvClass.DataSource = ClassBUS.GetData();
            //MessageBox.Show(ClassBUS.GetData().Rows[0][1].ToString());
            dgvClass.Columns[0].HeaderText = "Mã lớp học";
            dgvClass.Columns[1].HeaderText = "Tên lớp học";
            dgvClass.Columns[2].HeaderText = "Chuyên ngành";
            dgvClass.ReadOnly = true;
            dgvClass.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvClass.AllowUserToResizeRows = false;
        }

        public void LoadComboBoxGeneration()
        {
            cbbGeneration.DataSource = GenerationBUS.GetData();
            cbbGeneration.DisplayMember = "Name";
            cbbGeneration.ValueMember = "ID";
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
            numberClass.Text = ClassBUS.GetData().Rows.Count.ToString();
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

        private void ClassGUI_Load(object sender, EventArgs e)
        {
            ResetInput();
            LoadDataGridView();
            LoadComboBoxGeneration();
            numberClass.Text = ClassBUS.GetData().Rows.Count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStatus();
            txtID.Text = ClassBUS.AutoID();
            txtName.Focus();
            btnSubmit.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = "";
            DefaultStatus();
            ResetInput();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
            DeleteStatus();
            int index = int.Parse(label1.Text);
            txtID.Text = dgvClass[0, index].Value.ToString();
            txtName.Text = dgvClass[1, index].Value.ToString();
            cbbGeneration.SelectedIndex = GetSelectedIndexComboBoxGeneration(dgvClass[2, index].Value.ToString());
            lblDelete.Text = "Bạn có chắc muốn xóa?";
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
            EditStatus();
            int index = int.Parse(label1.Text);
            txtID.Text = dgvClass[0, index].Value.ToString();
            txtName.Text = dgvClass[1, index].Value.ToString();
            cbbGeneration.SelectedIndex = GetSelectedIndexComboBoxGeneration(dgvClass[2, index].Value.ToString());
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text == "Delete")
            {
                ClassBUS.Delete(txtID.Text);
                LoadDataGridView();
                DefaultStatus();
                ResetInput();
            }
            else
            {
                if (txtName.Text.Trim() == "")
                {
                    lblErName.Text = "Tên lớp học không được để trống, thử lại!";
                    txtName.Focus();
                }
                else
                {
                    if (lblStatus.Text == "Add")
                    {
                        Class cl = new Class();
                        cl.Id = txtID.Text;
                        cl.Name = txtName.Text.Trim();
                        cl.IdGeneration = cbbGeneration.SelectedValue.ToString();
                        ClassBUS.Add(cl);
                        LoadDataGridView();
                        DefaultStatus();
                        ResetInput();
                    }
                    else if (lblStatus.Text == "Edit")
                    {
                        Class cl = new Class();
                        cl.Id = txtID.Text;
                        cl.Name = txtName.Text.Trim();
                        cl.IdGeneration = cbbGeneration.SelectedValue.ToString();
                        ClassBUS.Edit(cl);
                        LoadDataGridView();
                        DefaultStatus();
                        ResetInput();
                    }

                }
            }
        }

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.RowIndex;
            label1.Text = y.ToString();
        }

        public int GetSelectedIndexComboBoxGeneration(string id)
        {
            DataTable tb = GenerationBUS.GetData();
            int i = 0;
            foreach (DataRow dr in tb.Rows)
            {
                if (dr["ID"].ToString() == id)
                {
                    return i;
                }
                i++;
            }
            return i;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string key = guna2TextBox1.Text;
            dgvClass.DataSource = new List<Generation>();
            dgvClass.DataSource = ClassBUS.Search(key);
            dgvClass.Columns[0].HeaderText = "Mã lớp học";
            dgvClass.Columns[1].HeaderText = "Tên lớp học";
            dgvClass.Columns[2].HeaderText = "Chuyên ngành";
            dgvClass.ReadOnly = true;
            dgvClass.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvClass.AllowUserToResizeRows = false;
        }
    }
}
