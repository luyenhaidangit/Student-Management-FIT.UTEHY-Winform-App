namespace Student_Manager_System_FIT.UTEHY
{
    partial class TeacherGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherGUI));
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvStudent = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblErrorName = new Guna.UI2.WinForms.Guna2Panel();
            this.submitDelete = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.errBirthday = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.errAndress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.errName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbbSex = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAndress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBirthday = new System.Windows.Forms.MaskedTextBox();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblErName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.btnNew = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.editBtn = new Guna.UI2.WinForms.Guna2Button();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numberTeacher = new System.Windows.Forms.Label();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.lblErrorName.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dgvStudent);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2Panel2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 67);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(847, 548);
            this.guna2Panel2.TabIndex = 18;
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStudent.ColumnHeadersHeight = 40;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStudent.EnableHeadersVisualStyles = false;
            this.dgvStudent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvStudent.Location = new System.Drawing.Point(4, 0);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStudent.Name = "dgvStudent";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.DividerHeight = 5;
            this.dgvStudent.RowTemplate.Height = 40;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(820, 544);
            this.dgvStudent.TabIndex = 4;
            this.dgvStudent.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStudent.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStudent.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStudent.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStudent.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStudent.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvStudent.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvStudent.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvStudent.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStudent.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvStudent.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvStudent.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvStudent.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvStudent.ThemeStyle.ReadOnly = false;
            this.dgvStudent.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStudent.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStudent.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvStudent.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvStudent.ThemeStyle.RowsStyle.Height = 40;
            this.dgvStudent.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvStudent.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // lblErrorName
            // 
            this.lblErrorName.BorderColor = System.Drawing.Color.SlateGray;
            this.lblErrorName.Controls.Add(this.submitDelete);
            this.lblErrorName.Controls.Add(this.errBirthday);
            this.lblErrorName.Controls.Add(this.errAndress);
            this.lblErrorName.Controls.Add(this.errName);
            this.lblErrorName.Controls.Add(this.cbbSex);
            this.lblErrorName.Controls.Add(this.txtID);
            this.lblErrorName.Controls.Add(this.label11);
            this.lblErrorName.Controls.Add(this.label8);
            this.lblErrorName.Controls.Add(this.label6);
            this.lblErrorName.Controls.Add(this.label5);
            this.lblErrorName.Controls.Add(this.txtAndress);
            this.lblErrorName.Controls.Add(this.txtBirthday);
            this.lblErrorName.Controls.Add(this.lblDelete);
            this.lblErrorName.Controls.Add(this.lblErName);
            this.lblErrorName.Controls.Add(this.lblStatus);
            this.lblErrorName.Controls.Add(this.label7);
            this.lblErrorName.Controls.Add(this.btnSubmit);
            this.lblErrorName.Controls.Add(this.txtName);
            this.lblErrorName.Controls.Add(this.label4);
            this.lblErrorName.CustomBorderColor = System.Drawing.Color.Silver;
            this.lblErrorName.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.lblErrorName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblErrorName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.lblErrorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorName.Location = new System.Drawing.Point(847, 67);
            this.lblErrorName.Margin = new System.Windows.Forms.Padding(4);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(344, 548);
            this.lblErrorName.TabIndex = 17;
            // 
            // submitDelete
            // 
            this.submitDelete.BackColor = System.Drawing.Color.Transparent;
            this.submitDelete.ForeColor = System.Drawing.Color.Red;
            this.submitDelete.Location = new System.Drawing.Point(44, 409);
            this.submitDelete.Name = "submitDelete";
            this.submitDelete.Size = new System.Drawing.Size(145, 18);
            this.submitDelete.TabIndex = 42;
            this.submitDelete.Text = "Bạn có chắc muốn xóa?";
            // 
            // errBirthday
            // 
            this.errBirthday.BackColor = System.Drawing.Color.Transparent;
            this.errBirthday.ForeColor = System.Drawing.Color.Red;
            this.errBirthday.Location = new System.Drawing.Point(82, 215);
            this.errBirthday.Name = "errBirthday";
            this.errBirthday.Size = new System.Drawing.Size(68, 18);
            this.errBirthday.TabIndex = 41;
            this.errBirthday.Text = "errBirthday";
            // 
            // errAndress
            // 
            this.errAndress.BackColor = System.Drawing.Color.Transparent;
            this.errAndress.ForeColor = System.Drawing.Color.Red;
            this.errAndress.Location = new System.Drawing.Point(82, 365);
            this.errAndress.Name = "errAndress";
            this.errAndress.Size = new System.Drawing.Size(69, 18);
            this.errAndress.TabIndex = 40;
            this.errAndress.Text = "errAndress";
            // 
            // errName
            // 
            this.errName.BackColor = System.Drawing.Color.Transparent;
            this.errName.ForeColor = System.Drawing.Color.Red;
            this.errName.Location = new System.Drawing.Point(82, 150);
            this.errName.Name = "errName";
            this.errName.Size = new System.Drawing.Size(56, 18);
            this.errName.TabIndex = 38;
            this.errName.Text = "errName";
            // 
            // cbbSex
            // 
            this.cbbSex.BackColor = System.Drawing.Color.Transparent;
            this.cbbSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSex.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSex.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbSex.ItemHeight = 30;
            this.cbbSex.Location = new System.Drawing.Point(133, 241);
            this.cbbSex.Name = "cbbSex";
            this.cbbSex.Size = new System.Drawing.Size(197, 36);
            this.cbbSex.TabIndex = 37;
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.Enabled = false;
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.FocusedState.FillColor = System.Drawing.Color.Transparent;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Location = new System.Drawing.Point(135, 33);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderText = "";
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(195, 36);
            this.txtID.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 335);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 21);
            this.label11.TabIndex = 34;
            this.label11.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 256);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 21);
            this.label8.TabIndex = 33;
            this.label8.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 185);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 31;
            this.label5.Text = "Tên sinh viên";
            // 
            // txtAndress
            // 
            this.txtAndress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAndress.DefaultText = "";
            this.txtAndress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAndress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAndress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAndress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAndress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAndress.FocusedState.FillColor = System.Drawing.Color.Transparent;
            this.txtAndress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAndress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAndress.Location = new System.Drawing.Point(137, 320);
            this.txtAndress.Name = "txtAndress";
            this.txtAndress.PasswordChar = '\0';
            this.txtAndress.PlaceholderText = "";
            this.txtAndress.SelectedText = "";
            this.txtAndress.Size = new System.Drawing.Size(195, 36);
            this.txtAndress.TabIndex = 29;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthday.Location = new System.Drawing.Point(135, 176);
            this.txtBirthday.Mask = "00/00/0000";
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(192, 30);
            this.txtBirthday.TabIndex = 25;
            this.txtBirthday.ValidatingType = typeof(System.DateTime);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.lblDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.ForeColor = System.Drawing.Color.Red;
            this.lblDelete.Location = new System.Drawing.Point(9, 291);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(0, 23);
            this.lblDelete.TabIndex = 23;
            // 
            // lblErName
            // 
            this.lblErName.AutoSize = true;
            this.lblErName.ForeColor = System.Drawing.Color.Red;
            this.lblErName.Location = new System.Drawing.Point(23, 166);
            this.lblErName.Name = "lblErName";
            this.lblErName.Size = new System.Drawing.Size(0, 18);
            this.lblErName.TabIndex = 22;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.lblStatus.Location = new System.Drawing.Point(152, 388);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 18);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(200, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 18);
            this.label7.TabIndex = 20;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoRoundedCorners = true;
            this.btnSubmit.BorderColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BorderRadius = 19;
            this.btnSubmit.BorderThickness = 1;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
            this.btnSubmit.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnSubmit.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
            this.btnSubmit.Location = new System.Drawing.Point(226, 403);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 41);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Xác nhận";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.FocusedState.FillColor = System.Drawing.Color.Transparent;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(133, 103);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(192, 36);
            this.txtName.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã giáo viên";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnNew);
            this.panelBottom.Controls.Add(this.label3);
            this.panelBottom.Controls.Add(this.label1);
            this.panelBottom.Controls.Add(this.btnAdd);
            this.panelBottom.Controls.Add(this.editBtn);
            this.panelBottom.Controls.Add(this.deleteBtn);
            this.panelBottom.CustomBorderColor = System.Drawing.Color.Silver;
            this.panelBottom.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.panelBottom.Location = new System.Drawing.Point(0, 615);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1191, 66);
            this.panelBottom.TabIndex = 16;
            // 
            // btnNew
            // 
            this.btnNew.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNew.BorderRadius = 5;
            this.btnNew.BorderThickness = 1;
            this.btnNew.FillColor = System.Drawing.Color.Transparent;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNew.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNew.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(277, 16);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 37);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "Mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(977, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(990, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "0";
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(397, 16);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 37);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            // 
            // editBtn
            // 
            this.editBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.editBtn.BorderRadius = 5;
            this.editBtn.BorderThickness = 1;
            this.editBtn.FillColor = System.Drawing.Color.Transparent;
            this.editBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.editBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.editBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(517, 16);
            this.editBtn.Margin = new System.Windows.Forms.Padding(4);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(112, 37);
            this.editBtn.TabIndex = 4;
            this.editBtn.Text = "Sửa";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.deleteBtn.BorderRadius = 5;
            this.deleteBtn.BorderThickness = 1;
            this.deleteBtn.FillColor = System.Drawing.Color.Transparent;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.deleteBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.deleteBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(637, 16);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(112, 37);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Xóa";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Controls.Add(this.guna2Button3);
            this.panelTop.Controls.Add(this.guna2Button2);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.numberTeacher);
            this.panelTop.CustomBorderColor = System.Drawing.Color.Silver;
            this.panelTop.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1191, 67);
            this.panelTop.TabIndex = 15;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.BorderRadius = 16;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconLeft")));
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtSearch.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtSearch.Location = new System.Drawing.Point(910, 13);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Tìm kiếm";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(267, 34);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.ImageSize = new System.Drawing.Size(14, 14);
            this.guna2Button3.Location = new System.Drawing.Point(482, 17);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(48, 34);
            this.guna2Button3.TabIndex = 6;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageOffset = new System.Drawing.Point(3, 0);
            this.guna2Button2.ImageSize = new System.Drawing.Size(12, 12);
            this.guna2Button2.Location = new System.Drawing.Point(559, 17);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(132, 34);
            this.guna2Button2.TabIndex = 5;
            this.guna2Button2.Text = "Lọc kết quả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label2.Location = new System.Drawing.Point(93, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giáo viên";
            // 
            // numberTeacher
            // 
            this.numberTeacher.AutoSize = true;
            this.numberTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.numberTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.numberTeacher.Location = new System.Drawing.Point(23, 9);
            this.numberTeacher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberTeacher.Name = "numberTeacher";
            this.numberTeacher.Size = new System.Drawing.Size(62, 42);
            this.numberTeacher.TabIndex = 0;
            this.numberTeacher.Text = "12";
            // 
            // TeacherGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1191, 681);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "TeacherGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý giáo viên";
            this.Load += new System.EventHandler(this.TeacherGUI_Load);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.lblErrorName.ResumeLayout(false);
            this.lblErrorName.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStudent;
        private Guna.UI2.WinForms.Guna2Panel lblErrorName;
        private Guna.UI2.WinForms.Guna2HtmlLabel submitDelete;
        private Guna.UI2.WinForms.Guna2HtmlLabel errBirthday;
        private Guna.UI2.WinForms.Guna2HtmlLabel errAndress;
        private Guna.UI2.WinForms.Guna2HtmlLabel errName;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSex;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtAndress;
        private System.Windows.Forms.MaskedTextBox txtBirthday;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblErName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel panelBottom;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button editBtn;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numberTeacher;
    }
}