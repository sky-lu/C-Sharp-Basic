namespace WinFormAppEntityFramework.GUI
{
    partial class EmployeeProjectForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEmployee = new System.Windows.Forms.TabPage();
            this.buttonExit = new System.Windows.Forms.Button();
            this.listViewEmployee = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageProject = new System.Windows.Forms.TabPage();
            this.tabPageProjectAssignment = new System.Windows.Forms.TabPage();
            this.buttonExitP = new System.Windows.Forms.Button();
            this.listViewProject = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxSearchP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSearchP = new System.Windows.Forms.Button();
            this.comboBoxSearchP = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxProjectTitle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonListP = new System.Windows.Forms.Button();
            this.buttonUpdateP = new System.Windows.Forms.Button();
            this.buttonDeleteP = new System.Windows.Forms.Button();
            this.buttonSaveP = new System.Windows.Forms.Button();
            this.textBoxProjectCode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelProjInfo = new System.Windows.Forms.Label();
            this.labelEmpInfo = new System.Windows.Forms.Label();
            this.buttonAssign = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.maskedTextBoxEndDate = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxStartDate = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.listViewAssignProject = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonExitAssignProject = new System.Windows.Forms.Button();
            this.buttonListAssignedProject = new System.Windows.Forms.Button();
            this.buttonUpdateAssignment = new System.Windows.Forms.Button();
            this.buttonDeleteAssignmment = new System.Windows.Forms.Button();
            this.buttonSearchAssginment = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageEmployee.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageProject.SuspendLayout();
            this.tabPageProjectAssignment.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEmployee);
            this.tabControl1.Controls.Add(this.tabPageProject);
            this.tabControl1.Controls.Add(this.tabPageProjectAssignment);
            this.tabControl1.Location = new System.Drawing.Point(14, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(920, 560);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageEmployee
            // 
            this.tabPageEmployee.Controls.Add(this.buttonExit);
            this.tabPageEmployee.Controls.Add(this.listViewEmployee);
            this.tabPageEmployee.Controls.Add(this.groupBox2);
            this.tabPageEmployee.Controls.Add(this.groupBox1);
            this.tabPageEmployee.Location = new System.Drawing.Point(4, 27);
            this.tabPageEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageEmployee.Name = "tabPageEmployee";
            this.tabPageEmployee.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageEmployee.Size = new System.Drawing.Size(912, 529);
            this.tabPageEmployee.TabIndex = 0;
            this.tabPageEmployee.Text = "Employee";
            this.tabPageEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(780, 478);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(98, 31);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // listViewEmployee
            // 
            this.listViewEmployee.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listViewEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewEmployee.GridLines = true;
            this.listViewEmployee.HideSelection = false;
            this.listViewEmployee.Location = new System.Drawing.Point(31, 284);
            this.listViewEmployee.Name = "listViewEmployee";
            this.listViewEmployee.Size = new System.Drawing.Size(824, 170);
            this.listViewEmployee.TabIndex = 2;
            this.listViewEmployee.UseCompatibleStateImageBehavior = false;
            this.listViewEmployee.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Employee ID";
            this.columnHeader1.Width = 101;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 164;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 127;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Phone Number";
            this.columnHeader4.Width = 215;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Email";
            this.columnHeader5.Width = 210;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSearch);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.comboBoxSearch);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(582, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 201);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Employee";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(18, 135);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(193, 24);
            this.textBoxSearch.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Please enter information :";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(198, 54);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(98, 31);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "Employee Id",
            "Last Name"});
            this.comboBoxSearch.Location = new System.Drawing.Point(18, 57);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(167, 26);
            this.comboBoxSearch.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Search By";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.maskedTextBoxPhone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonList);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.textBoxLastName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxEmployeeId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Information";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(150, 127);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(193, 24);
            this.textBoxEmail.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email";
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(11, 127);
            this.maskedTextBoxPhone.Mask = "(999) 000-0000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(118, 24);
            this.maskedTextBoxPhone.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "( 4 digits )";
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(429, 163);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(98, 31);
            this.buttonList.TabIndex = 9;
            this.buttonList.Text = "List";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(429, 71);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(98, 31);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(429, 117);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(98, 31);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(429, 26);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(98, 31);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(287, 54);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(118, 24);
            this.textBoxLastName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(150, 54);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(118, 24);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // textBoxEmployeeId
            // 
            this.textBoxEmployeeId.Location = new System.Drawing.Point(11, 54);
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            this.textBoxEmployeeId.Size = new System.Drawing.Size(118, 24);
            this.textBoxEmployeeId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // tabPageProject
            // 
            this.tabPageProject.Controls.Add(this.buttonExitP);
            this.tabPageProject.Controls.Add(this.listViewProject);
            this.tabPageProject.Controls.Add(this.groupBox3);
            this.tabPageProject.Controls.Add(this.groupBox4);
            this.tabPageProject.Location = new System.Drawing.Point(4, 27);
            this.tabPageProject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageProject.Name = "tabPageProject";
            this.tabPageProject.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageProject.Size = new System.Drawing.Size(912, 529);
            this.tabPageProject.TabIndex = 1;
            this.tabPageProject.Text = "Project";
            this.tabPageProject.UseVisualStyleBackColor = true;
            // 
            // tabPageProjectAssignment
            // 
            this.tabPageProjectAssignment.Controls.Add(this.buttonSearchAssginment);
            this.tabPageProjectAssignment.Controls.Add(this.buttonDeleteAssignmment);
            this.tabPageProjectAssignment.Controls.Add(this.buttonUpdateAssignment);
            this.tabPageProjectAssignment.Controls.Add(this.buttonListAssignedProject);
            this.tabPageProjectAssignment.Controls.Add(this.buttonExitAssignProject);
            this.tabPageProjectAssignment.Controls.Add(this.listViewAssignProject);
            this.tabPageProjectAssignment.Controls.Add(this.groupBox7);
            this.tabPageProjectAssignment.Controls.Add(this.groupBox6);
            this.tabPageProjectAssignment.Controls.Add(this.groupBox5);
            this.tabPageProjectAssignment.Controls.Add(this.buttonAssign);
            this.tabPageProjectAssignment.Location = new System.Drawing.Point(4, 27);
            this.tabPageProjectAssignment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageProjectAssignment.Name = "tabPageProjectAssignment";
            this.tabPageProjectAssignment.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageProjectAssignment.Size = new System.Drawing.Size(912, 529);
            this.tabPageProjectAssignment.TabIndex = 2;
            this.tabPageProjectAssignment.Text = "Project Assignment";
            this.tabPageProjectAssignment.UseVisualStyleBackColor = true;
            // 
            // buttonExitP
            // 
            this.buttonExitP.Location = new System.Drawing.Point(776, 473);
            this.buttonExitP.Name = "buttonExitP";
            this.buttonExitP.Size = new System.Drawing.Size(98, 31);
            this.buttonExitP.TabIndex = 12;
            this.buttonExitP.Text = "Exit";
            this.buttonExitP.UseVisualStyleBackColor = true;
            this.buttonExitP.Click += new System.EventHandler(this.buttonExitP_Click);
            // 
            // listViewProject
            // 
            this.listViewProject.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listViewProject.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12});
            this.listViewProject.GridLines = true;
            this.listViewProject.HideSelection = false;
            this.listViewProject.Location = new System.Drawing.Point(122, 279);
            this.listViewProject.Name = "listViewProject";
            this.listViewProject.Size = new System.Drawing.Size(668, 170);
            this.listViewProject.TabIndex = 11;
            this.listViewProject.UseCompatibleStateImageBehavior = false;
            this.listViewProject.View = System.Windows.Forms.View.Details;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxSearchP);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.buttonSearchP);
            this.groupBox3.Controls.Add(this.comboBoxSearchP);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(578, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 201);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Project";
            // 
            // textBoxSearchP
            // 
            this.textBoxSearchP.Location = new System.Drawing.Point(18, 135);
            this.textBoxSearchP.Name = "textBoxSearchP";
            this.textBoxSearchP.Size = new System.Drawing.Size(193, 24);
            this.textBoxSearchP.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Please enter information :";
            // 
            // buttonSearchP
            // 
            this.buttonSearchP.Location = new System.Drawing.Point(198, 54);
            this.buttonSearchP.Name = "buttonSearchP";
            this.buttonSearchP.Size = new System.Drawing.Size(98, 29);
            this.buttonSearchP.TabIndex = 7;
            this.buttonSearchP.Text = "Search";
            this.buttonSearchP.UseVisualStyleBackColor = true;
            this.buttonSearchP.Click += new System.EventHandler(this.buttonSearchP_Click);
            // 
            // comboBoxSearchP
            // 
            this.comboBoxSearchP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchP.FormattingEnabled = true;
            this.comboBoxSearchP.Items.AddRange(new object[] {
            "Project Code"});
            this.comboBoxSearchP.Location = new System.Drawing.Point(18, 57);
            this.comboBoxSearchP.Name = "comboBoxSearchP";
            this.comboBoxSearchP.Size = new System.Drawing.Size(167, 26);
            this.comboBoxSearchP.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Search By";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxProjectTitle);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.buttonListP);
            this.groupBox4.Controls.Add(this.buttonUpdateP);
            this.groupBox4.Controls.Add(this.buttonDeleteP);
            this.groupBox4.Controls.Add(this.buttonSaveP);
            this.groupBox4.Controls.Add(this.textBoxProjectCode);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(27, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(537, 226);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Project Information";
            // 
            // textBoxProjectTitle
            // 
            this.textBoxProjectTitle.Location = new System.Drawing.Point(23, 137);
            this.textBoxProjectTitle.Name = "textBoxProjectTitle";
            this.textBoxProjectTitle.Size = new System.Drawing.Size(215, 24);
            this.textBoxProjectTitle.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 18);
            this.label11.TabIndex = 13;
            this.label11.Text = "Project Title";
            // 
            // buttonListP
            // 
            this.buttonListP.Location = new System.Drawing.Point(405, 163);
            this.buttonListP.Name = "buttonListP";
            this.buttonListP.Size = new System.Drawing.Size(98, 31);
            this.buttonListP.TabIndex = 9;
            this.buttonListP.Text = "List";
            this.buttonListP.UseVisualStyleBackColor = true;
            this.buttonListP.Click += new System.EventHandler(this.buttonListP_Click);
            // 
            // buttonUpdateP
            // 
            this.buttonUpdateP.Location = new System.Drawing.Point(405, 71);
            this.buttonUpdateP.Name = "buttonUpdateP";
            this.buttonUpdateP.Size = new System.Drawing.Size(98, 31);
            this.buttonUpdateP.TabIndex = 8;
            this.buttonUpdateP.Text = "Update";
            this.buttonUpdateP.UseVisualStyleBackColor = true;
            this.buttonUpdateP.Click += new System.EventHandler(this.buttonUpdateP_Click);
            // 
            // buttonDeleteP
            // 
            this.buttonDeleteP.Location = new System.Drawing.Point(405, 117);
            this.buttonDeleteP.Name = "buttonDeleteP";
            this.buttonDeleteP.Size = new System.Drawing.Size(98, 31);
            this.buttonDeleteP.TabIndex = 7;
            this.buttonDeleteP.Text = "Delete";
            this.buttonDeleteP.UseVisualStyleBackColor = true;
            this.buttonDeleteP.Click += new System.EventHandler(this.buttonDeleteP_Click);
            // 
            // buttonSaveP
            // 
            this.buttonSaveP.Location = new System.Drawing.Point(405, 26);
            this.buttonSaveP.Name = "buttonSaveP";
            this.buttonSaveP.Size = new System.Drawing.Size(98, 31);
            this.buttonSaveP.TabIndex = 6;
            this.buttonSaveP.Text = "Save";
            this.buttonSaveP.UseVisualStyleBackColor = true;
            this.buttonSaveP.Click += new System.EventHandler(this.buttonSaveP_Click);
            // 
            // textBoxProjectCode
            // 
            this.textBoxProjectCode.Location = new System.Drawing.Point(23, 66);
            this.textBoxProjectCode.Name = "textBoxProjectCode";
            this.textBoxProjectCode.Size = new System.Drawing.Size(215, 24);
            this.textBoxProjectCode.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 18);
            this.label16.TabIndex = 0;
            this.label16.Text = "Project Code";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Project Code";
            this.columnHeader11.Width = 192;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Project Title";
            this.columnHeader12.Width = 466;
            // 
            // labelProjInfo
            // 
            this.labelProjInfo.AutoSize = true;
            this.labelProjInfo.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelProjInfo.Location = new System.Drawing.Point(15, 88);
            this.labelProjInfo.Name = "labelProjInfo";
            this.labelProjInfo.Size = new System.Drawing.Size(55, 18);
            this.labelProjInfo.TabIndex = 22;
            this.labelProjInfo.Text = "Project";
            // 
            // labelEmpInfo
            // 
            this.labelEmpInfo.AutoSize = true;
            this.labelEmpInfo.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelEmpInfo.Location = new System.Drawing.Point(12, 88);
            this.labelEmpInfo.Name = "labelEmpInfo";
            this.labelEmpInfo.Size = new System.Drawing.Size(74, 18);
            this.labelEmpInfo.TabIndex = 21;
            this.labelEmpInfo.Text = "Employee";
            // 
            // buttonAssign
            // 
            this.buttonAssign.Location = new System.Drawing.Point(48, 238);
            this.buttonAssign.Name = "buttonAssign";
            this.buttonAssign.Size = new System.Drawing.Size(115, 48);
            this.buttonAssign.TabIndex = 20;
            this.buttonAssign.Text = "Assign Project";
            this.buttonAssign.UseVisualStyleBackColor = true;
            this.buttonAssign.Click += new System.EventHandler(this.buttonAssign_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 18);
            this.label12.TabIndex = 19;
            this.label12.Text = "Ending Date :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 18);
            this.label13.TabIndex = 18;
            this.label13.Text = "Starting Date :";
            // 
            // maskedTextBoxEndDate
            // 
            this.maskedTextBoxEndDate.Location = new System.Drawing.Point(18, 124);
            this.maskedTextBoxEndDate.Mask = "00/00/0000";
            this.maskedTextBoxEndDate.Name = "maskedTextBoxEndDate";
            this.maskedTextBoxEndDate.Size = new System.Drawing.Size(156, 24);
            this.maskedTextBoxEndDate.TabIndex = 17;
            this.maskedTextBoxEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxStartDate
            // 
            this.maskedTextBoxStartDate.Location = new System.Drawing.Point(18, 52);
            this.maskedTextBoxStartDate.Mask = "00/00/0000";
            this.maskedTextBoxStartDate.Name = "maskedTextBoxStartDate";
            this.maskedTextBoxStartDate.Size = new System.Drawing.Size(156, 24);
            this.maskedTextBoxStartDate.TabIndex = 16;
            this.maskedTextBoxStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 18);
            this.label14.TabIndex = 15;
            this.label14.Text = "Selected Project";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 18);
            this.label15.TabIndex = 14;
            this.label15.Text = "Selected Employee";
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Location = new System.Drawing.Point(18, 50);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(148, 26);
            this.comboBoxProject.TabIndex = 13;
            this.comboBoxProject.SelectedIndexChanged += new System.EventHandler(this.comboBoxProject_SelectedIndexChanged);
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(15, 50);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(162, 26);
            this.comboBoxEmployee.TabIndex = 12;
            this.comboBoxEmployee.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmployee_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.comboBoxEmployee);
            this.groupBox5.Controls.Add(this.labelEmpInfo);
            this.groupBox5.Location = new System.Drawing.Point(33, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(243, 194);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Employee Info";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.comboBoxProject);
            this.groupBox6.Controls.Add(this.labelProjInfo);
            this.groupBox6.Location = new System.Drawing.Point(334, 23);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(243, 194);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Project Info";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.maskedTextBoxStartDate);
            this.groupBox7.Controls.Add(this.maskedTextBoxEndDate);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Location = new System.Drawing.Point(628, 23);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(243, 194);
            this.groupBox7.TabIndex = 24;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Date Info";
            // 
            // listViewAssignProject
            // 
            this.listViewAssignProject.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listViewAssignProject.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewAssignProject.GridLines = true;
            this.listViewAssignProject.HideSelection = false;
            this.listViewAssignProject.Location = new System.Drawing.Point(33, 304);
            this.listViewAssignProject.Name = "listViewAssignProject";
            this.listViewAssignProject.Size = new System.Drawing.Size(614, 170);
            this.listViewAssignProject.TabIndex = 25;
            this.listViewAssignProject.UseCompatibleStateImageBehavior = false;
            this.listViewAssignProject.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Employee ID";
            this.columnHeader6.Width = 101;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Project Code";
            this.columnHeader7.Width = 165;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Starting Date";
            this.columnHeader8.Width = 171;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ending Date";
            this.columnHeader9.Width = 215;
            // 
            // buttonExitAssignProject
            // 
            this.buttonExitAssignProject.Location = new System.Drawing.Point(716, 452);
            this.buttonExitAssignProject.Name = "buttonExitAssignProject";
            this.buttonExitAssignProject.Size = new System.Drawing.Size(115, 48);
            this.buttonExitAssignProject.TabIndex = 26;
            this.buttonExitAssignProject.Text = "Exit";
            this.buttonExitAssignProject.UseVisualStyleBackColor = true;
            this.buttonExitAssignProject.Click += new System.EventHandler(this.buttonExitAssignProject_Click);
            // 
            // buttonListAssignedProject
            // 
            this.buttonListAssignedProject.Location = new System.Drawing.Point(671, 238);
            this.buttonListAssignedProject.Name = "buttonListAssignedProject";
            this.buttonListAssignedProject.Size = new System.Drawing.Size(160, 48);
            this.buttonListAssignedProject.TabIndex = 27;
            this.buttonListAssignedProject.Text = "List Assigned Project";
            this.buttonListAssignedProject.UseVisualStyleBackColor = true;
            this.buttonListAssignedProject.Click += new System.EventHandler(this.buttonListAssignedProject_Click);
            // 
            // buttonUpdateAssignment
            // 
            this.buttonUpdateAssignment.Location = new System.Drawing.Point(189, 238);
            this.buttonUpdateAssignment.Name = "buttonUpdateAssignment";
            this.buttonUpdateAssignment.Size = new System.Drawing.Size(115, 48);
            this.buttonUpdateAssignment.TabIndex = 28;
            this.buttonUpdateAssignment.Text = "Update";
            this.buttonUpdateAssignment.UseVisualStyleBackColor = true;
            this.buttonUpdateAssignment.Click += new System.EventHandler(this.buttonUpdateAssignment_Click);
            // 
            // buttonDeleteAssignmment
            // 
            this.buttonDeleteAssignmment.Location = new System.Drawing.Point(334, 238);
            this.buttonDeleteAssignmment.Name = "buttonDeleteAssignmment";
            this.buttonDeleteAssignmment.Size = new System.Drawing.Size(115, 48);
            this.buttonDeleteAssignmment.TabIndex = 29;
            this.buttonDeleteAssignmment.Text = "Delete";
            this.buttonDeleteAssignmment.UseVisualStyleBackColor = true;
            this.buttonDeleteAssignmment.Click += new System.EventHandler(this.buttonDeleteAssignmment_Click);
            // 
            // buttonSearchAssginment
            // 
            this.buttonSearchAssginment.Location = new System.Drawing.Point(477, 238);
            this.buttonSearchAssginment.Name = "buttonSearchAssginment";
            this.buttonSearchAssginment.Size = new System.Drawing.Size(115, 48);
            this.buttonSearchAssginment.TabIndex = 30;
            this.buttonSearchAssginment.Text = "Search";
            this.buttonSearchAssginment.UseVisualStyleBackColor = true;
            this.buttonSearchAssginment.Click += new System.EventHandler(this.buttonSearchAssginment_Click);
            // 
            // EmployeeProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 592);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmployeeProjectForm";
            this.Text = "Employee - Project Maintenance";
            this.Load += new System.EventHandler(this.EmployeeProjectForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageEmployee.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageProject.ResumeLayout(false);
            this.tabPageProjectAssignment.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEmployee;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmployeeId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageProject;
        private System.Windows.Forms.TabPage tabPageProjectAssignment;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListView listViewEmployee;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button buttonExitP;
        private System.Windows.Forms.ListView listViewProject;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxSearchP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSearchP;
        private System.Windows.Forms.ComboBox comboBoxSearchP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxProjectTitle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonListP;
        private System.Windows.Forms.Button buttonUpdateP;
        private System.Windows.Forms.Button buttonDeleteP;
        private System.Windows.Forms.Button buttonSaveP;
        private System.Windows.Forms.TextBox textBoxProjectCode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelProjInfo;
        private System.Windows.Forms.Label labelEmpInfo;
        private System.Windows.Forms.Button buttonAssign;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEndDate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStartDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxProject;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView listViewAssignProject;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button buttonExitAssignProject;
        private System.Windows.Forms.Button buttonListAssignedProject;
        private System.Windows.Forms.Button buttonSearchAssginment;
        private System.Windows.Forms.Button buttonDeleteAssignmment;
        private System.Windows.Forms.Button buttonUpdateAssignment;
    }
}