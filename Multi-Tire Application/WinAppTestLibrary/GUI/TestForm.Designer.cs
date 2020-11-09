namespace WinAppTestLibrary.GUI
{
    partial class TestForm
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
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(552, 132);
            this.buttonShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(136, 47);
            this.buttonShow.TabIndex = 0;
            this.buttonShow.Text = "Show FullName";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(552, 305);
            this.buttonValidate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(127, 50);
            this.buttonValidate.TabIndex = 1;
            this.buttonValidate.Text = "Validate";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee ID";
            // 
            // textBoxEmployeeId
            // 
            this.textBoxEmployeeId.Location = new System.Drawing.Point(143, 132);
            this.textBoxEmployeeId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            this.textBoxEmployeeId.Size = new System.Drawing.Size(148, 24);
            this.textBoxEmployeeId.TabIndex = 3;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(143, 215);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(148, 24);
            this.textBoxFirstName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(143, 299);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(148, 24);
            this.textBoxLastName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "( 4 digits )";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEmployeeId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.buttonShow);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmployeeId;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}