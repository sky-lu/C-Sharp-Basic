namespace WinFormAppEntityFramework.GUI
{
    partial class TestForm2
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxStartDate = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxEndDate = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAssign = new System.Windows.Forms.Button();
            this.labelEmpInfo = new System.Windows.Forms.Label();
            this.labelProjInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee - Project Assignment";
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(54, 85);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(162, 26);
            this.comboBoxEmployee.TabIndex = 1;
            this.comboBoxEmployee.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmployee_SelectedIndexChanged);
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Location = new System.Drawing.Point(317, 85);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(148, 26);
            this.comboBoxProject.TabIndex = 2;
            this.comboBoxProject.SelectedIndexChanged += new System.EventHandler(this.comboBoxProject_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selected Employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selected Project";
            // 
            // maskedTextBoxStartDate
            // 
            this.maskedTextBoxStartDate.Location = new System.Drawing.Point(657, 61);
            this.maskedTextBoxStartDate.Mask = "00/00/0000";
            this.maskedTextBoxStartDate.Name = "maskedTextBoxStartDate";
            this.maskedTextBoxStartDate.Size = new System.Drawing.Size(123, 24);
            this.maskedTextBoxStartDate.TabIndex = 5;
            this.maskedTextBoxStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxEndDate
            // 
            this.maskedTextBoxEndDate.Location = new System.Drawing.Point(657, 116);
            this.maskedTextBoxEndDate.Mask = "00/00/0000";
            this.maskedTextBoxEndDate.Name = "maskedTextBoxEndDate";
            this.maskedTextBoxEndDate.Size = new System.Drawing.Size(123, 24);
            this.maskedTextBoxEndDate.TabIndex = 6;
            this.maskedTextBoxEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Starting Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(534, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ending Date :";
            // 
            // buttonAssign
            // 
            this.buttonAssign.Location = new System.Drawing.Point(111, 279);
            this.buttonAssign.Name = "buttonAssign";
            this.buttonAssign.Size = new System.Drawing.Size(115, 48);
            this.buttonAssign.TabIndex = 9;
            this.buttonAssign.Text = "Assign Project";
            this.buttonAssign.UseVisualStyleBackColor = true;
            this.buttonAssign.Click += new System.EventHandler(this.buttonAssign_Click);
            // 
            // labelEmpInfo
            // 
            this.labelEmpInfo.AutoSize = true;
            this.labelEmpInfo.Location = new System.Drawing.Point(51, 142);
            this.labelEmpInfo.Name = "labelEmpInfo";
            this.labelEmpInfo.Size = new System.Drawing.Size(74, 18);
            this.labelEmpInfo.TabIndex = 10;
            this.labelEmpInfo.Text = "Employee";
            // 
            // labelProjInfo
            // 
            this.labelProjInfo.AutoSize = true;
            this.labelProjInfo.Location = new System.Drawing.Point(314, 142);
            this.labelProjInfo.Name = "labelProjInfo";
            this.labelProjInfo.Size = new System.Drawing.Size(55, 18);
            this.labelProjInfo.TabIndex = 11;
            this.labelProjInfo.Text = "Project";
            // 
            // TestForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 540);
            this.Controls.Add(this.labelProjInfo);
            this.Controls.Add(this.labelEmpInfo);
            this.Controls.Add(this.buttonAssign);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTextBoxEndDate);
            this.Controls.Add(this.maskedTextBoxStartDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxProject);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TestForm2";
            this.Text = "TestForm2";
            this.Load += new System.EventHandler(this.TestForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.ComboBox comboBoxProject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStartDate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAssign;
        private System.Windows.Forms.Label labelEmpInfo;
        private System.Windows.Forms.Label labelProjInfo;
    }
}