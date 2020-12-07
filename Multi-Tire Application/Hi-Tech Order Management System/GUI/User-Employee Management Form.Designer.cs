namespace Hi_Tech_Order_Management_System.GUI
{
    partial class MIS_ManagerForm
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
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonExitU = new System.Windows.Forms.Button();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxSearchU = new System.Windows.Forms.TextBox();
            this.comboBoxSearchU = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonListAllUsers = new System.Windows.Forms.Button();
            this.buttonSearchU = new System.Windows.Forms.Button();
            this.buttonDeleteU = new System.Windows.Forms.Button();
            this.buttonUpdateU = new System.Windows.Forms.Button();
            this.buttonAddU = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelUserInfo = new System.Windows.Forms.Label();
            this.comboBoxEmployeeId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonExitE = new System.Windows.Forms.Button();
            this.listViewEmployee = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxSearchE = new System.Windows.Forms.TextBox();
            this.comboBoxSearchE = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonListE = new System.Windows.Forms.Button();
            this.buttonSearchE = new System.Windows.Forms.Button();
            this.buttonDeleteE = new System.Windows.Forms.Button();
            this.buttonUpadateE = new System.Windows.Forms.Button();
            this.buttonAddE = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.comboBoxJob = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUser);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(821, 699);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageUser
            // 
            this.tabPageUser.Controls.Add(this.label10);
            this.tabPageUser.Controls.Add(this.buttonExitU);
            this.tabPageUser.Controls.Add(this.listViewUsers);
            this.tabPageUser.Controls.Add(this.textBoxSearchU);
            this.tabPageUser.Controls.Add(this.comboBoxSearchU);
            this.tabPageUser.Controls.Add(this.label7);
            this.tabPageUser.Controls.Add(this.buttonListAllUsers);
            this.tabPageUser.Controls.Add(this.buttonSearchU);
            this.tabPageUser.Controls.Add(this.buttonDeleteU);
            this.tabPageUser.Controls.Add(this.buttonUpdateU);
            this.tabPageUser.Controls.Add(this.buttonAddU);
            this.tabPageUser.Controls.Add(this.groupBox1);
            this.tabPageUser.Location = new System.Drawing.Point(4, 27);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser.Size = new System.Drawing.Size(813, 668);
            this.tabPageUser.TabIndex = 0;
            this.tabPageUser.Text = "User";
            this.tabPageUser.UseVisualStyleBackColor = true;
            this.tabPageUser.Click += new System.EventHandler(this.tabPageUser_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(377, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 18);
            this.label10.TabIndex = 43;
            this.label10.Text = "Please enter information :";
            // 
            // buttonExitU
            // 
            this.buttonExitU.Location = new System.Drawing.Point(603, 549);
            this.buttonExitU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExitU.Name = "buttonExitU";
            this.buttonExitU.Size = new System.Drawing.Size(160, 58);
            this.buttonExitU.TabIndex = 42;
            this.buttonExitU.Text = "Exit";
            this.buttonExitU.UseVisualStyleBackColor = true;
            this.buttonExitU.Click += new System.EventHandler(this.buttonExitU_Click);
            // 
            // listViewUsers
            // 
            this.listViewUsers.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader12});
            this.listViewUsers.GridLines = true;
            this.listViewUsers.HideSelection = false;
            this.listViewUsers.Location = new System.Drawing.Point(53, 372);
            this.listViewUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(487, 182);
            this.listViewUsers.TabIndex = 41;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "User ID";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Password";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Employee Id";
            this.columnHeader12.Width = 186;
            // 
            // textBoxSearchU
            // 
            this.textBoxSearchU.Location = new System.Drawing.Point(379, 321);
            this.textBoxSearchU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSearchU.Name = "textBoxSearchU";
            this.textBoxSearchU.Size = new System.Drawing.Size(221, 24);
            this.textBoxSearchU.TabIndex = 40;
            // 
            // comboBoxSearchU
            // 
            this.comboBoxSearchU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchU.ForeColor = System.Drawing.Color.Black;
            this.comboBoxSearchU.FormattingEnabled = true;
            this.comboBoxSearchU.Items.AddRange(new object[] {
            "User ID"});
            this.comboBoxSearchU.Location = new System.Drawing.Point(193, 321);
            this.comboBoxSearchU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSearchU.Name = "comboBoxSearchU";
            this.comboBoxSearchU.Size = new System.Drawing.Size(167, 26);
            this.comboBoxSearchU.TabIndex = 38;
            this.comboBoxSearchU.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchU_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "Search by :";
            // 
            // buttonListAllUsers
            // 
            this.buttonListAllUsers.Location = new System.Drawing.Point(536, 240);
            this.buttonListAllUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonListAllUsers.Name = "buttonListAllUsers";
            this.buttonListAllUsers.Size = new System.Drawing.Size(225, 41);
            this.buttonListAllUsers.TabIndex = 36;
            this.buttonListAllUsers.Text = "&List all users";
            this.buttonListAllUsers.UseVisualStyleBackColor = true;
            this.buttonListAllUsers.Click += new System.EventHandler(this.buttonListAllUsers_Click_1);
            // 
            // buttonSearchU
            // 
            this.buttonSearchU.Location = new System.Drawing.Point(625, 312);
            this.buttonSearchU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSearchU.Name = "buttonSearchU";
            this.buttonSearchU.Size = new System.Drawing.Size(88, 41);
            this.buttonSearchU.TabIndex = 39;
            this.buttonSearchU.Text = "&Search";
            this.buttonSearchU.UseVisualStyleBackColor = true;
            this.buttonSearchU.Click += new System.EventHandler(this.buttonSearchU_Click);
            // 
            // buttonDeleteU
            // 
            this.buttonDeleteU.Location = new System.Drawing.Point(380, 240);
            this.buttonDeleteU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeleteU.Name = "buttonDeleteU";
            this.buttonDeleteU.Size = new System.Drawing.Size(88, 41);
            this.buttonDeleteU.TabIndex = 35;
            this.buttonDeleteU.Text = "&Delete";
            this.buttonDeleteU.UseVisualStyleBackColor = true;
            this.buttonDeleteU.Click += new System.EventHandler(this.buttonDeleteU_Click);
            // 
            // buttonUpdateU
            // 
            this.buttonUpdateU.Location = new System.Drawing.Point(215, 240);
            this.buttonUpdateU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUpdateU.Name = "buttonUpdateU";
            this.buttonUpdateU.Size = new System.Drawing.Size(88, 41);
            this.buttonUpdateU.TabIndex = 34;
            this.buttonUpdateU.Text = "&Update";
            this.buttonUpdateU.UseVisualStyleBackColor = true;
            this.buttonUpdateU.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAddU
            // 
            this.buttonAddU.Location = new System.Drawing.Point(53, 240);
            this.buttonAddU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddU.Name = "buttonAddU";
            this.buttonAddU.Size = new System.Drawing.Size(88, 41);
            this.buttonAddU.TabIndex = 33;
            this.buttonAddU.Text = "&Add";
            this.buttonAddU.UseVisualStyleBackColor = true;
            this.buttonAddU.Click += new System.EventHandler(this.buttonAddU_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.comboBoxEmployeeId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxUserId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Location = new System.Drawing.Point(53, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(710, 209);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Crimson;
            this.label15.Location = new System.Drawing.Point(138, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 18);
            this.label15.TabIndex = 13;
            this.label15.Text = "( 3 digits )";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelUserInfo);
            this.groupBox3.Location = new System.Drawing.Point(365, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 172);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information";
            // 
            // labelUserInfo
            // 
            this.labelUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserInfo.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelUserInfo.Location = new System.Drawing.Point(22, 23);
            this.labelUserInfo.Name = "labelUserInfo";
            this.labelUserInfo.Size = new System.Drawing.Size(273, 131);
            this.labelUserInfo.TabIndex = 0;
            // 
            // comboBoxEmployeeId
            // 
            this.comboBoxEmployeeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployeeId.FormattingEnabled = true;
            this.comboBoxEmployeeId.Location = new System.Drawing.Point(140, 152);
            this.comboBoxEmployeeId.Name = "comboBoxEmployeeId";
            this.comboBoxEmployeeId.Size = new System.Drawing.Size(167, 26);
            this.comboBoxEmployeeId.TabIndex = 11;
            this.comboBoxEmployeeId.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmployeeId_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Employee ID :";
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Location = new System.Drawing.Point(141, 33);
            this.textBoxUserId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(167, 24);
            this.textBoxUserId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password :";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(141, 94);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(167, 24);
            this.textBoxPassword.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.buttonExitE);
            this.tabPage2.Controls.Add(this.listViewEmployee);
            this.tabPage2.Controls.Add(this.textBoxSearchE);
            this.tabPage2.Controls.Add(this.comboBoxSearchE);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.buttonListE);
            this.tabPage2.Controls.Add(this.buttonSearchE);
            this.tabPage2.Controls.Add(this.buttonDeleteE);
            this.tabPage2.Controls.Add(this.buttonUpadateE);
            this.tabPage2.Controls.Add(this.buttonAddE);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(813, 668);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 18);
            this.label3.TabIndex = 54;
            this.label3.Text = "Please enter information:";
            // 
            // buttonExitE
            // 
            this.buttonExitE.Location = new System.Drawing.Point(603, 565);
            this.buttonExitE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExitE.Name = "buttonExitE";
            this.buttonExitE.Size = new System.Drawing.Size(160, 58);
            this.buttonExitE.TabIndex = 53;
            this.buttonExitE.Text = "Exit";
            this.buttonExitE.UseVisualStyleBackColor = true;
            this.buttonExitE.Click += new System.EventHandler(this.buttonExitE_Click);
            // 
            // listViewEmployee
            // 
            this.listViewEmployee.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listViewEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader13,
            this.columnHeader8,
            this.columnHeader11});
            this.listViewEmployee.GridLines = true;
            this.listViewEmployee.HideSelection = false;
            this.listViewEmployee.Location = new System.Drawing.Point(52, 369);
            this.listViewEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewEmployee.Name = "listViewEmployee";
            this.listViewEmployee.Size = new System.Drawing.Size(709, 182);
            this.listViewEmployee.TabIndex = 52;
            this.listViewEmployee.UseCompatibleStateImageBehavior = false;
            this.listViewEmployee.View = System.Windows.Forms.View.Details;
            this.listViewEmployee.SelectedIndexChanged += new System.EventHandler(this.listViewEmployee_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Employee ID";
            this.columnHeader7.Width = 99;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "First Name";
            this.columnHeader9.Width = 94;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Last Name";
            this.columnHeader10.Width = 102;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Phone Number";
            this.columnHeader13.Width = 116;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Email";
            this.columnHeader8.Width = 145;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Job Title";
            this.columnHeader11.Width = 151;
            // 
            // textBoxSearchE
            // 
            this.textBoxSearchE.Location = new System.Drawing.Point(379, 314);
            this.textBoxSearchE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSearchE.Name = "textBoxSearchE";
            this.textBoxSearchE.Size = new System.Drawing.Size(221, 24);
            this.textBoxSearchE.TabIndex = 51;
            // 
            // comboBoxSearchE
            // 
            this.comboBoxSearchE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchE.ForeColor = System.Drawing.Color.Black;
            this.comboBoxSearchE.FormattingEnabled = true;
            this.comboBoxSearchE.Items.AddRange(new object[] {
            "Employee ID",
            "Last Name"});
            this.comboBoxSearchE.Location = new System.Drawing.Point(193, 314);
            this.comboBoxSearchE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSearchE.Name = "comboBoxSearchE";
            this.comboBoxSearchE.Size = new System.Drawing.Size(167, 26);
            this.comboBoxSearchE.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 18);
            this.label8.TabIndex = 48;
            this.label8.Text = "Search by :";
            // 
            // buttonListE
            // 
            this.buttonListE.Location = new System.Drawing.Point(536, 224);
            this.buttonListE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonListE.Name = "buttonListE";
            this.buttonListE.Size = new System.Drawing.Size(225, 41);
            this.buttonListE.TabIndex = 47;
            this.buttonListE.Text = "&List all employees";
            this.buttonListE.UseVisualStyleBackColor = true;
            this.buttonListE.Click += new System.EventHandler(this.buttonListE_Click);
            // 
            // buttonSearchE
            // 
            this.buttonSearchE.Location = new System.Drawing.Point(625, 305);
            this.buttonSearchE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSearchE.Name = "buttonSearchE";
            this.buttonSearchE.Size = new System.Drawing.Size(88, 41);
            this.buttonSearchE.TabIndex = 50;
            this.buttonSearchE.Text = "&Search";
            this.buttonSearchE.UseVisualStyleBackColor = true;
            this.buttonSearchE.Click += new System.EventHandler(this.buttonSearchE_Click);
            // 
            // buttonDeleteE
            // 
            this.buttonDeleteE.Location = new System.Drawing.Point(380, 224);
            this.buttonDeleteE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeleteE.Name = "buttonDeleteE";
            this.buttonDeleteE.Size = new System.Drawing.Size(88, 41);
            this.buttonDeleteE.TabIndex = 46;
            this.buttonDeleteE.Text = "&Delete";
            this.buttonDeleteE.UseVisualStyleBackColor = true;
            this.buttonDeleteE.Click += new System.EventHandler(this.buttonDeleteE_Click);
            // 
            // buttonUpadateE
            // 
            this.buttonUpadateE.Location = new System.Drawing.Point(215, 224);
            this.buttonUpadateE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUpadateE.Name = "buttonUpadateE";
            this.buttonUpadateE.Size = new System.Drawing.Size(88, 41);
            this.buttonUpadateE.TabIndex = 45;
            this.buttonUpadateE.Text = "&Update";
            this.buttonUpadateE.UseVisualStyleBackColor = true;
            this.buttonUpadateE.Click += new System.EventHandler(this.buttonUpadateE_Click);
            // 
            // buttonAddE
            // 
            this.buttonAddE.Location = new System.Drawing.Point(53, 224);
            this.buttonAddE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddE.Name = "buttonAddE";
            this.buttonAddE.Size = new System.Drawing.Size(88, 41);
            this.buttonAddE.TabIndex = 44;
            this.buttonAddE.Text = "&Add";
            this.buttonAddE.UseVisualStyleBackColor = true;
            this.buttonAddE.Click += new System.EventHandler(this.buttonAddE_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxEmail);
            this.groupBox2.Controls.Add(this.comboBoxJob);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.maskedTextBoxPhone);
            this.groupBox2.Controls.Add(this.textBoxFirstName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxEmployeeId);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBoxLastName);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(53, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(710, 193);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee Info";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(493, 88);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(167, 24);
            this.textBoxEmail.TabIndex = 51;
            // 
            // comboBoxJob
            // 
            this.comboBoxJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJob.FormattingEnabled = true;
            this.comboBoxJob.Location = new System.Drawing.Point(493, 141);
            this.comboBoxJob.Name = "comboBoxJob";
            this.comboBoxJob.Size = new System.Drawing.Size(167, 26);
            this.comboBoxJob.TabIndex = 52;
            this.comboBoxJob.SelectedIndexChanged += new System.EventHandler(this.comboBoxJob_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 50;
            this.label5.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(138, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 49;
            this.label4.Text = "( 4 digits )";
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(493, 34);
            this.maskedTextBoxPhone.Mask = "(999) 000-0000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(167, 24);
            this.maskedTextBoxPhone.TabIndex = 10;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(141, 91);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(167, 24);
            this.textBoxFirstName.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Employee ID :";
            // 
            // textBoxEmployeeId
            // 
            this.textBoxEmployeeId.Location = new System.Drawing.Point(141, 33);
            this.textBoxEmployeeId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            this.textBoxEmployeeId.Size = new System.Drawing.Size(167, 24);
            this.textBoxEmployeeId.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(369, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "Phone Number :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(369, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 18);
            this.label12.TabIndex = 8;
            this.label12.Text = "Job Title :";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(141, 147);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(167, 24);
            this.textBoxLastName.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 18);
            this.label13.TabIndex = 4;
            this.label13.Text = "First Name :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 18);
            this.label14.TabIndex = 6;
            this.label14.Text = "Last Name :";
            // 
            // MIS_ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 724);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MIS_ManagerForm";
            this.Text = "User-Employee Management Form";
            this.Load += new System.EventHandler(this.MIS_ManagerForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageUser.ResumeLayout(false);
            this.tabPageUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageUser;
        private System.Windows.Forms.Button buttonExitU;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBoxSearchU;
        private System.Windows.Forms.ComboBox comboBoxSearchU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonListAllUsers;
        private System.Windows.Forms.Button buttonSearchU;
        private System.Windows.Forms.Button buttonDeleteU;
        private System.Windows.Forms.Button buttonUpdateU;
        private System.Windows.Forms.Button buttonAddU;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonExitE;
        private System.Windows.Forms.ListView listViewEmployee;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TextBox textBoxSearchE;
        private System.Windows.Forms.ComboBox comboBoxSearchE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonListE;
        private System.Windows.Forms.Button buttonSearchE;
        private System.Windows.Forms.Button buttonDeleteE;
        private System.Windows.Forms.Button buttonUpadateE;
        private System.Windows.Forms.Button buttonAddE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxEmployeeId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxJob;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelUserInfo;
        private System.Windows.Forms.ComboBox comboBoxEmployeeId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}