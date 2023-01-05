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
    public partial class GenerationGUI : Form
    {
        public GenerationGUI()
        {
            InitializeComponent();
        }

        public GenerationBUS generationBUS = new GenerationBUS();

        public void LoadDataGridView()
        {
            dgvGeneration.DataSource = new List<Generation>();
            dgvGeneration.DataSource = generationBUS.GetData();
            dgvGeneration.Columns[0].HeaderText = "Mã chuyên ngành";
            dgvGeneration.Columns[1].HeaderText = "Tên chuyên ngành";
            dgvGeneration.Columns[2].HeaderText = "Mô tả";
            dgvGeneration.ReadOnly = true;
            dgvGeneration.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvGeneration.AllowUserToResizeRows = false;
        }

        public void ResetInput()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtDesc.Text = "";
            btnSubmit.Enabled = false;
        }

        public void DefaultStatus()
        {
            lblDelete.Text = "";
            lblErName.Text = "";
            lblStatus.Text = "Default";
            btnAdd.Enabled = true;
            editBtn.Enabled = true;
            deleteBtn.Enabled = true;
            numberGeneration.Text = generationBUS.GetData().Rows.Count.ToString();
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
            deleteBtn.Enabled= false;
        }

        public void DeleteStatus()
        {
            lblStatus.Text = "Delete";
            btnAdd.Enabled = false;
            editBtn.Enabled = false;
        }

        private void GenerationGUI_Load(object sender, EventArgs e)
        {
            ResetInput();
            LoadDataGridView();
            numberGeneration.Text = generationBUS.GetData().Rows.Count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStatus();
            txtID.Text = generationBUS.AutoID();
            txtName.Focus();
            btnSubmit.Enabled = true;
        }

        private void dgvGeneration_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.RowIndex;
            label1.Text = y.ToString();
        }

        private void editBtn_Click_1(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
            EditStatus();
            int index = int.Parse(label1.Text);
            txtID.Text = dgvGeneration[0, index].Value.ToString();
            txtName.Text = dgvGeneration[1, index].Value.ToString();
            txtDesc.Text = dgvGeneration[2, index].Value.ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
            DeleteStatus();
            int index = int.Parse(label1.Text);
            txtID.Text = dgvGeneration[0, index].Value.ToString();
            txtName.Text = dgvGeneration[1, index].Value.ToString();
            txtDesc.Text = dgvGeneration[2, index].Value.ToString();
            lblDelete.Text = "Bạn có chắc muốn xóa?";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = "";
            DefaultStatus();
            ResetInput();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(lblStatus.Text == "Delete")
            {
                generationBUS.Delete(txtID.Text);
                LoadDataGridView();
                DefaultStatus();
                ResetInput();
            }
            else
            {
                if (txtName.Text.Trim() == "")
                {
                    lblErName.Text = "Tên chuyên ngành không được để trống, thử lại!";
                    txtName.Focus();
                }
                else
                {
                    if (lblStatus.Text == "Add")
                    {
                        Generation ge = new Generation();
                        ge.Id = txtID.Text;
                        ge.Name = txtName.Text.Trim();
                        ge.Desc = txtDesc.Text.Trim();
                        generationBUS.Add(ge);
                        LoadDataGridView();
                        DefaultStatus();
                        ResetInput();
                    }
                    else if (lblStatus.Text == "Edit")
                    {
                        Generation ge = new Generation();
                        ge.Id = txtID.Text;
                        ge.Name = txtName.Text.Trim();
                        ge.Desc = txtDesc.Text.Trim();
                        generationBUS.Edit(ge);
                        LoadDataGridView();
                        DefaultStatus();
                        ResetInput();
                    }

                }
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string key = guna2TextBox1.Text;
            dgvGeneration.DataSource = new List<Generation>();
            dgvGeneration.DataSource = generationBUS.Search(key);
            dgvGeneration.Columns[0].HeaderText = "Mã chuyên ngành";
            dgvGeneration.Columns[1].HeaderText = "Tên chuyên ngành";
            dgvGeneration.Columns[2].HeaderText = "Mô tả";
            dgvGeneration.ReadOnly = true;
            dgvGeneration.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvGeneration.AllowUserToResizeRows = false;
        }
    }
}
