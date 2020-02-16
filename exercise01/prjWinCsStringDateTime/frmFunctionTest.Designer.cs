namespace prjWinCsStringDateTime
{
    partial class frmFunctionTest
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemal = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.combFunction = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "FUNCTIONS - TESTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname.Firstname@Company.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(123, 84);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(358, 27);
            this.txtEmail.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "BirthDate :";
            // 
            // dtpBirth
            // 
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirth.Location = new System.Drawing.Point(123, 132);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(358, 27);
            this.dtpBirth.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gender :";
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(123, 181);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(66, 24);
            this.radMale.TabIndex = 7;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemal
            // 
            this.radFemal.AutoSize = true;
            this.radFemal.Location = new System.Drawing.Point(123, 211);
            this.radFemal.Name = "radFemal";
            this.radFemal.Size = new System.Drawing.Size(76, 24);
            this.radFemal.TabIndex = 8;
            this.radFemal.TabStop = true;
            this.radFemal.Text = "Femal";
            this.radFemal.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Function :";
            // 
            // combFunction
            // 
            this.combFunction.FormattingEnabled = true;
            this.combFunction.Items.AddRange(new object[] {
            "Programmer",
            "Analyst",
            "Secretary"});
            this.combFunction.Location = new System.Drawing.Point(123, 255);
            this.combFunction.Name = "combFunction";
            this.combFunction.Size = new System.Drawing.Size(201, 28);
            this.combFunction.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(234, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 40);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(49, 400);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(432, 129);
            this.lblResult.TabIndex = 12;
            // 
            // frmFunctionTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 752);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.combFunction);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radFemal);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFunctionTest";
            this.Text = "frmFunctionTest";
            this.Load += new System.EventHandler(this.frmFunctionTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combFunction;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.DateTimePicker dtpBirth;
    }
}