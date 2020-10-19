namespace WinFormAppDisconnectedMode.GUI
{
    partial class CourseForm
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
            this.buttonListCoursesFromDS = new System.Windows.Forms.Button();
            this.dataGridViewCoursesFromDB = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxTotalHour = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonListCourses = new System.Windows.Forms.Button();
            this.textBoxCourseTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCourseCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewFromDS = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoursesFromDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFromDS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonListCoursesFromDS
            // 
            this.buttonListCoursesFromDS.Location = new System.Drawing.Point(55, 448);
            this.buttonListCoursesFromDS.Name = "buttonListCoursesFromDS";
            this.buttonListCoursesFromDS.Size = new System.Drawing.Size(188, 38);
            this.buttonListCoursesFromDS.TabIndex = 17;
            this.buttonListCoursesFromDS.Text = "List courses from DS";
            this.buttonListCoursesFromDS.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCoursesFromDB
            // 
            this.dataGridViewCoursesFromDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoursesFromDB.Location = new System.Drawing.Point(55, 288);
            this.dataGridViewCoursesFromDB.Name = "dataGridViewCoursesFromDB";
            this.dataGridViewCoursesFromDB.RowHeadersWidth = 51;
            this.dataGridViewCoursesFromDB.RowTemplate.Height = 27;
            this.dataGridViewCoursesFromDB.Size = new System.Drawing.Size(553, 150);
            this.dataGridViewCoursesFromDB.TabIndex = 16;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(529, 99);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(136, 29);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Update Database";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(410, 99);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 29);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(296, 99);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(100, 29);
            this.buttonModify.TabIndex = 10;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(178, 99);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 29);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(59, 99);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 29);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxTotalHour
            // 
            this.textBoxTotalHour.Location = new System.Drawing.Point(460, 49);
            this.textBoxTotalHour.Name = "textBoxTotalHour";
            this.textBoxTotalHour.Size = new System.Drawing.Size(93, 25);
            this.textBoxTotalHour.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Hour";
            // 
            // buttonListCourses
            // 
            this.buttonListCourses.Location = new System.Drawing.Point(55, 235);
            this.buttonListCourses.Name = "buttonListCourses";
            this.buttonListCourses.Size = new System.Drawing.Size(188, 38);
            this.buttonListCourses.TabIndex = 15;
            this.buttonListCourses.Text = "List courses from DB";
            this.buttonListCourses.UseVisualStyleBackColor = true;
            this.buttonListCourses.Click += new System.EventHandler(this.buttonListCourses_Click);
            // 
            // textBoxCourseTitle
            // 
            this.textBoxCourseTitle.Location = new System.Drawing.Point(187, 49);
            this.textBoxCourseTitle.Name = "textBoxCourseTitle";
            this.textBoxCourseTitle.Size = new System.Drawing.Size(246, 25);
            this.textBoxCourseTitle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course Title";
            // 
            // textBoxCourseCode
            // 
            this.textBoxCourseCode.Location = new System.Drawing.Point(59, 49);
            this.textBoxCourseCode.Name = "textBoxCourseCode";
            this.textBoxCourseCode.Size = new System.Drawing.Size(100, 25);
            this.textBoxCourseCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Code";
            // 
            // dataGridViewFromDS
            // 
            this.dataGridViewFromDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFromDS.Location = new System.Drawing.Point(55, 501);
            this.dataGridViewFromDS.Name = "dataGridViewFromDS";
            this.dataGridViewFromDS.RowHeadersWidth = 51;
            this.dataGridViewFromDS.RowTemplate.Height = 27;
            this.dataGridViewFromDS.Size = new System.Drawing.Size(553, 150);
            this.dataGridViewFromDS.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonModify);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.textBoxTotalHour);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxCourseTitle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxCourseCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(55, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 167);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Information";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(657, 614);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 37);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 695);
            this.ControlBox = false;
            this.Controls.Add(this.buttonListCoursesFromDS);
            this.Controls.Add(this.dataGridViewCoursesFromDB);
            this.Controls.Add(this.buttonListCourses);
            this.Controls.Add(this.dataGridViewFromDS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CourseForm";
            this.Text = "Course Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoursesFromDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFromDS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonListCoursesFromDS;
        private System.Windows.Forms.DataGridView dataGridViewCoursesFromDB;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxTotalHour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonListCourses;
        private System.Windows.Forms.TextBox textBoxCourseTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCourseCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewFromDS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
    }
}