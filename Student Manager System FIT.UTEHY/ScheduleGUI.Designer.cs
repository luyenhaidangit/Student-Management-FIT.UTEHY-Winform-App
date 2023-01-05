namespace Student_Manager_System_FIT.UTEHY
{
    partial class ScheduleGUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleGUI));
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvSchedule = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblErrorName = new Guna.UI2.WinForms.Guna2Panel();
            this.submitDelete = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.errSubject = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.errClass = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.errTeacher = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.errSemester = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbbTeacher = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblErName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
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
            this.numberStudent = new System.Windows.Forms.Label();
            this.cbbClass = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbSemester = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbSubject = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.lblErrorName.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dgvSchedule);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2Panel2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 67);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(773, 548);
            this.guna2Panel2.TabIndex = 18;
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToAddRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvSchedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedule.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSchedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSchedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvSchedule.ColumnHeadersHeight = 40;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSchedule.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvSchedule.EnableHeadersVisualStyles = false;
            this.dgvSchedule.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvSchedule.Location = new System.Drawing.Point(4, 0);
            this.dgvSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSchedule.Name = "dgvSchedule";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvSchedule.RowHeadersVisible = false;
            this.dgvSchedule.RowHeadersWidth = 51;
            this.dgvSchedule.RowTemplate.DividerHeight = 5;
            this.dgvSchedule.RowTemplate.Height = 40;
            this.dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedule.Size = new System.Drawing.Size(761, 544);
            this.dgvSchedule.TabIndex = 4;
            this.dgvSchedule.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSchedule.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSchedule.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSchedule.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSchedule.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSchedule.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvSchedule.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvSchedule.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvSchedule.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSchedule.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvSchedule.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvSchedule.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSchedule.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvSchedule.ThemeStyle.ReadOnly = false;
            this.dgvSchedule.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSchedule.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSchedule.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvSchedule.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSchedule.ThemeStyle.RowsStyle.Height = 40;
            this.dgvSchedule.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvSchedule.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedule_CellClick);
            // 
            // lblErrorName
            // 
            this.lblErrorName.BorderColor = System.Drawing.Color.SlateGray;
            this.lblErrorName.Controls.Add(this.cbbSubject);
            this.lblErrorName.Controls.Add(this.cbbSemester);
            this.lblErrorName.Controls.Add(this.cbbClass);
            this.lblErrorName.Controls.Add(this.submitDelete);
            this.lblErrorName.Controls.Add(this.errSubject);
            this.lblErrorName.Controls.Add(this.errClass);
            this.lblErrorName.Controls.Add(this.errTeacher);
            this.lblErrorName.Controls.Add(this.errSemester);
            this.lblErrorName.Controls.Add(this.cbbTeacher);
            this.lblErrorName.Controls.Add(this.label8);
            this.lblErrorName.Controls.Add(this.label6);
            this.lblErrorName.Controls.Add(this.label5);
            this.lblErrorName.Controls.Add(this.lblDelete);
            this.lblErrorName.Controls.Add(this.lblErName);
            this.lblErrorName.Controls.Add(this.lblStatus);
            this.lblErrorName.Controls.Add(this.label7);
            this.lblErrorName.Controls.Add(this.btnSubmit);
            this.lblErrorName.Controls.Add(this.label4);
            this.lblErrorName.CustomBorderColor = System.Drawing.Color.Silver;
            this.lblErrorName.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.lblErrorName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblErrorName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.lblErrorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorName.Location = new System.Drawing.Point(773, 67);
            this.lblErrorName.Margin = new System.Windows.Forms.Padding(4);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(418, 548);
            this.lblErrorName.TabIndex = 17;
            // 
            // submitDelete
            // 
            this.submitDelete.BackColor = System.Drawing.Color.Transparent;
            this.submitDelete.ForeColor = System.Drawing.Color.Red;
            this.submitDelete.Location = new System.Drawing.Point(73, 376);
            this.submitDelete.Name = "submitDelete";
            this.submitDelete.Size = new System.Drawing.Size(145, 18);
            this.submitDelete.TabIndex = 42;
            this.submitDelete.Text = "Bạn có chắc muốn xóa?";
            // 
            // errSubject
            // 
            this.errSubject.BackColor = System.Drawing.Color.Transparent;
            this.errSubject.ForeColor = System.Drawing.Color.Red;
            this.errSubject.Location = new System.Drawing.Point(70, 267);
            this.errSubject.Name = "errSubject";
            this.errSubject.Size = new System.Drawing.Size(70, 20);
            this.errSubject.TabIndex = 41;
            this.errSubject.Text = "errSubject";
            // 
            // errClass
            // 
            this.errClass.BackColor = System.Drawing.Color.Transparent;
            this.errClass.ForeColor = System.Drawing.Color.Red;
            this.errClass.Location = new System.Drawing.Point(60, 116);
            this.errClass.Name = "errClass";
            this.errClass.Size = new System.Drawing.Size(59, 20);
            this.errClass.TabIndex = 40;
            this.errClass.Text = "errClass";
            // 
            // errTeacher
            // 
            this.errTeacher.BackColor = System.Drawing.Color.Transparent;
            this.errTeacher.ForeColor = System.Drawing.Color.Red;
            this.errTeacher.Location = new System.Drawing.Point(73, 342);
            this.errTeacher.Name = "errTeacher";
            this.errTeacher.Size = new System.Drawing.Size(75, 20);
            this.errTeacher.TabIndex = 39;
            this.errTeacher.Text = "errTeacher";
            // 
            // errSemester
            // 
            this.errSemester.BackColor = System.Drawing.Color.Transparent;
            this.errSemester.ForeColor = System.Drawing.Color.Red;
            this.errSemester.Location = new System.Drawing.Point(73, 188);
            this.errSemester.Name = "errSemester";
            this.errSemester.Size = new System.Drawing.Size(85, 20);
            this.errSemester.TabIndex = 38;
            this.errSemester.Text = "errSemester";
            // 
            // cbbTeacher
            // 
            this.cbbTeacher.BackColor = System.Drawing.Color.Transparent;
            this.cbbTeacher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTeacher.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTeacher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTeacher.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbTeacher.ItemHeight = 30;
            this.cbbTeacher.Location = new System.Drawing.Point(137, 291);
            this.cbbTeacher.Name = "cbbTeacher";
            this.cbbTeacher.Size = new System.Drawing.Size(246, 36);
            this.cbbTeacher.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 306);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 21);
            this.label8.TabIndex = 33;
            this.label8.Text = "Giáo viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 233);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "Môn học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 31;
            this.label5.Text = "Kỳ học";
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
            this.btnSubmit.Location = new System.Drawing.Point(258, 365);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 41);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Xác nhận";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Lớp học";
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
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
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
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Controls.Add(this.guna2Button3);
            this.panelTop.Controls.Add(this.guna2Button2);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.numberStudent);
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
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lịch học";
            // 
            // numberStudent
            // 
            this.numberStudent.AutoSize = true;
            this.numberStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.numberStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.numberStudent.Location = new System.Drawing.Point(23, 9);
            this.numberStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberStudent.Name = "numberStudent";
            this.numberStudent.Size = new System.Drawing.Size(62, 42);
            this.numberStudent.TabIndex = 0;
            this.numberStudent.Text = "12";
            // 
            // cbbClass
            // 
            this.cbbClass.BackColor = System.Drawing.Color.Transparent;
            this.cbbClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbClass.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbClass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbClass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbClass.ItemHeight = 30;
            this.cbbClass.Location = new System.Drawing.Point(137, 74);
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.Size = new System.Drawing.Size(246, 36);
            this.cbbClass.TabIndex = 43;
            // 
            // cbbSemester
            // 
            this.cbbSemester.BackColor = System.Drawing.Color.Transparent;
            this.cbbSemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSemester.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSemester.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSemester.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbSemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbSemester.ItemHeight = 30;
            this.cbbSemester.Location = new System.Drawing.Point(137, 142);
            this.cbbSemester.Name = "cbbSemester";
            this.cbbSemester.Size = new System.Drawing.Size(246, 36);
            this.cbbSemester.TabIndex = 44;
            // 
            // cbbSubject
            // 
            this.cbbSubject.BackColor = System.Drawing.Color.Transparent;
            this.cbbSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSubject.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSubject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSubject.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbSubject.ItemHeight = 30;
            this.cbbSubject.Location = new System.Drawing.Point(137, 218);
            this.cbbSubject.Name = "cbbSubject";
            this.cbbSubject.Size = new System.Drawing.Size(246, 36);
            this.cbbSubject.TabIndex = 45;
            // 
            // ScheduleGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1191, 681);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "ScheduleGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lịch học";
            this.Load += new System.EventHandler(this.ScheduleGUI_Load);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView dgvSchedule;
        private Guna.UI2.WinForms.Guna2Panel lblErrorName;
        private Guna.UI2.WinForms.Guna2HtmlLabel submitDelete;
        private Guna.UI2.WinForms.Guna2HtmlLabel errSubject;
        private Guna.UI2.WinForms.Guna2HtmlLabel errClass;
        private Guna.UI2.WinForms.Guna2HtmlLabel errTeacher;
        private Guna.UI2.WinForms.Guna2HtmlLabel errSemester;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTeacher;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblErName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
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
        private System.Windows.Forms.Label numberStudent;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSubject;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSemester;
        private Guna.UI2.WinForms.Guna2ComboBox cbbClass;
    }
}