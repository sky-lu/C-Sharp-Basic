namespace WinFormAppDisconnectedMode.GUI
{
    partial class CourseRegistrationForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelStuInfo = new System.Windows.Forms.Label();
            this.buttonStuInfo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelCourseInfo = new System.Windows.Forms.Label();
            this.buttonCourseInfo = new System.Windows.Forms.Button();
            this.textBoxCourseCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonUpdateDB = new System.Windows.Forms.Button();
            this.buttonListCourseByStud = new System.Windows.Forms.Button();
            this.buttonListStudByCourse = new System.Windows.Forms.Button();
            this.dataGridViewListCourseByStud = new System.Windows.Forms.DataGridView();
            this.dataGridViewListStudByCourse = new System.Windows.Forms.DataGridView();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.maskedTextBoxRegisDate = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxStartDate = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxEndDate = new System.Windows.Forms.MaskedTextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCourseByStud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListStudByCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelStuInfo);
            this.groupBox1.Controls.Add(this.buttonStuInfo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxStudentID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(308, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // labelStuInfo
            // 
            this.labelStuInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelStuInfo.Location = new System.Drawing.Point(17, 120);
            this.labelStuInfo.Name = "labelStuInfo";
            this.labelStuInfo.Size = new System.Drawing.Size(255, 88);
            this.labelStuInfo.TabIndex = 1;
            // 
            // buttonStuInfo
            // 
            this.buttonStuInfo.Location = new System.Drawing.Point(182, 54);
            this.buttonStuInfo.Name = "buttonStuInfo";
            this.buttonStuInfo.Size = new System.Drawing.Size(90, 29);
            this.buttonStuInfo.TabIndex = 1;
            this.buttonStuInfo.Text = "Get";
            this.buttonStuInfo.UseVisualStyleBackColor = true;
            this.buttonStuInfo.Click += new System.EventHandler(this.buttonStuInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "( 7 digits )";
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(20, 54);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(128, 24);
            this.textBoxStudentID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelCourseInfo);
            this.groupBox2.Controls.Add(this.buttonCourseInfo);
            this.groupBox2.Controls.Add(this.textBoxCourseCode);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(368, 32);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(308, 225);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Course Information";
            // 
            // labelCourseInfo
            // 
            this.labelCourseInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelCourseInfo.Location = new System.Drawing.Point(17, 120);
            this.labelCourseInfo.Name = "labelCourseInfo";
            this.labelCourseInfo.Size = new System.Drawing.Size(255, 88);
            this.labelCourseInfo.TabIndex = 1;
            // 
            // buttonCourseInfo
            // 
            this.buttonCourseInfo.Location = new System.Drawing.Point(182, 54);
            this.buttonCourseInfo.Name = "buttonCourseInfo";
            this.buttonCourseInfo.Size = new System.Drawing.Size(90, 29);
            this.buttonCourseInfo.TabIndex = 1;
            this.buttonCourseInfo.Text = "Get";
            this.buttonCourseInfo.UseVisualStyleBackColor = true;
            this.buttonCourseInfo.Click += new System.EventHandler(this.buttonCourseInfo_Click);
            // 
            // textBoxCourseCode
            // 
            this.textBoxCourseCode.Location = new System.Drawing.Point(20, 54);
            this.textBoxCourseCode.Name = "textBoxCourseCode";
            this.textBoxCourseCode.Size = new System.Drawing.Size(128, 24);
            this.textBoxCourseCode.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Course Code";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.maskedTextBoxEndDate);
            this.groupBox3.Controls.Add(this.maskedTextBoxStartDate);
            this.groupBox3.Controls.Add(this.maskedTextBoxRegisDate);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(712, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 214);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Course Registration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ending Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Starting Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Registration Date";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(73, 284);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(107, 41);
            this.buttonRegister.TabIndex = 3;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click_1);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(214, 284);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(107, 41);
            this.buttonModify.TabIndex = 4;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(354, 284);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(107, 41);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateDB
            // 
            this.buttonUpdateDB.Location = new System.Drawing.Point(728, 284);
            this.buttonUpdateDB.Name = "buttonUpdateDB";
            this.buttonUpdateDB.Size = new System.Drawing.Size(173, 41);
            this.buttonUpdateDB.TabIndex = 6;
            this.buttonUpdateDB.Text = "Update Datebase";
            this.buttonUpdateDB.UseVisualStyleBackColor = true;
            // 
            // buttonListCourseByStud
            // 
            this.buttonListCourseByStud.Location = new System.Drawing.Point(76, 346);
            this.buttonListCourseByStud.Name = "buttonListCourseByStud";
            this.buttonListCourseByStud.Size = new System.Drawing.Size(323, 33);
            this.buttonListCourseByStud.TabIndex = 7;
            this.buttonListCourseByStud.Text = "List Courses By Student From DB";
            this.buttonListCourseByStud.UseVisualStyleBackColor = true;
            // 
            // buttonListStudByCourse
            // 
            this.buttonListStudByCourse.Location = new System.Drawing.Point(531, 346);
            this.buttonListStudByCourse.Name = "buttonListStudByCourse";
            this.buttonListStudByCourse.Size = new System.Drawing.Size(323, 33);
            this.buttonListStudByCourse.TabIndex = 8;
            this.buttonListStudByCourse.Text = "List Students By Course From DB";
            this.buttonListStudByCourse.UseVisualStyleBackColor = true;
            this.buttonListStudByCourse.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewListCourseByStud
            // 
            this.dataGridViewListCourseByStud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListCourseByStud.Location = new System.Drawing.Point(32, 400);
            this.dataGridViewListCourseByStud.Name = "dataGridViewListCourseByStud";
            this.dataGridViewListCourseByStud.RowHeadersWidth = 51;
            this.dataGridViewListCourseByStud.RowTemplate.Height = 27;
            this.dataGridViewListCourseByStud.Size = new System.Drawing.Size(413, 190);
            this.dataGridViewListCourseByStud.TabIndex = 9;
            // 
            // dataGridViewListStudByCourse
            // 
            this.dataGridViewListStudByCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListStudByCourse.Location = new System.Drawing.Point(491, 400);
            this.dataGridViewListStudByCourse.Name = "dataGridViewListStudByCourse";
            this.dataGridViewListStudByCourse.RowHeadersWidth = 51;
            this.dataGridViewListStudByCourse.RowTemplate.Height = 27;
            this.dataGridViewListStudByCourse.Size = new System.Drawing.Size(413, 190);
            this.dataGridViewListStudByCourse.TabIndex = 10;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(768, 609);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(133, 49);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(496, 284);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(107, 41);
            this.buttonSearch.TabIndex = 12;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // maskedTextBoxRegisDate
            // 
            this.maskedTextBoxRegisDate.Location = new System.Drawing.Point(24, 55);
            this.maskedTextBoxRegisDate.Mask = "00/00/0000";
            this.maskedTextBoxRegisDate.Name = "maskedTextBoxRegisDate";
            this.maskedTextBoxRegisDate.Size = new System.Drawing.Size(156, 24);
            this.maskedTextBoxRegisDate.TabIndex = 13;
            this.maskedTextBoxRegisDate.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxStartDate
            // 
            this.maskedTextBoxStartDate.Location = new System.Drawing.Point(24, 113);
            this.maskedTextBoxStartDate.Mask = "00/00/0000";
            this.maskedTextBoxStartDate.Name = "maskedTextBoxStartDate";
            this.maskedTextBoxStartDate.Size = new System.Drawing.Size(156, 24);
            this.maskedTextBoxStartDate.TabIndex = 14;
            this.maskedTextBoxStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxEndDate
            // 
            this.maskedTextBoxEndDate.Location = new System.Drawing.Point(24, 171);
            this.maskedTextBoxEndDate.Mask = "00/00/0000";
            this.maskedTextBoxEndDate.Name = "maskedTextBoxEndDate";
            this.maskedTextBoxEndDate.Size = new System.Drawing.Size(156, 24);
            this.maskedTextBoxEndDate.TabIndex = 15;
            this.maskedTextBoxEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(280, 617);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(153, 41);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear All";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // CourseRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 688);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dataGridViewListStudByCourse);
            this.Controls.Add(this.dataGridViewListCourseByStud);
            this.Controls.Add(this.buttonListStudByCourse);
            this.Controls.Add(this.buttonListCourseByStud);
            this.Controls.Add(this.buttonUpdateDB);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CourseRegistrationForm";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.CourseRegistrationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCourseByStud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListStudByCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelStuInfo;
        private System.Windows.Forms.Button buttonStuInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelCourseInfo;
        private System.Windows.Forms.Button buttonCourseInfo;
        private System.Windows.Forms.TextBox textBoxCourseCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonUpdateDB;
        private System.Windows.Forms.Button buttonListCourseByStud;
        private System.Windows.Forms.Button buttonListStudByCourse;
        private System.Windows.Forms.DataGridView dataGridViewListCourseByStud;
        private System.Windows.Forms.DataGridView dataGridViewListStudByCourse;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEndDate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStartDate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRegisDate;
        private System.Windows.Forms.Button buttonClear;
    }
}