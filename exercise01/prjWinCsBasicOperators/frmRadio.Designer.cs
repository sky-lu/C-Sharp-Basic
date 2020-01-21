namespace prjWinCsBasicOperators
{
    partial class frmRadio
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
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMultiplication = new System.Windows.Forms.RadioButton();
            this.btnDivision = new System.Windows.Forms.RadioButton();
            this.btnSubstraction = new System.Windows.Forms.RadioButton();
            this.btnAddition = new System.Windows.Forms.RadioButton();
            this.Result = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULATOR 2.0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(31, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(247, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Value2:";
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(109, 92);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(100, 30);
            this.txtValue1.TabIndex = 3;
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(325, 92);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(100, 30);
            this.txtValue2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMultiplication);
            this.groupBox1.Controls.Add(this.btnDivision);
            this.groupBox1.Controls.Add(this.btnSubstraction);
            this.groupBox1.Controls.Add(this.btnAddition);
            this.groupBox1.Location = new System.Drawing.Point(35, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 159);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operators";
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.AutoSize = true;
            this.btnMultiplication.Location = new System.Drawing.Point(246, 103);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(150, 28);
            this.btnMultiplication.TabIndex = 3;
            this.btnMultiplication.TabStop = true;
            this.btnMultiplication.Text = "Multiplication";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.CheckedChanged += new System.EventHandler(this.btnMultiplication_CheckedChanged);
            // 
            // btnDivision
            // 
            this.btnDivision.AutoSize = true;
            this.btnDivision.Location = new System.Drawing.Point(41, 103);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(99, 28);
            this.btnDivision.TabIndex = 2;
            this.btnDivision.TabStop = true;
            this.btnDivision.Text = "Division";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.CheckedChanged += new System.EventHandler(this.btnDivision_CheckedChanged);
            // 
            // btnSubstraction
            // 
            this.btnSubstraction.AutoSize = true;
            this.btnSubstraction.Location = new System.Drawing.Point(246, 48);
            this.btnSubstraction.Name = "btnSubstraction";
            this.btnSubstraction.Size = new System.Drawing.Size(138, 28);
            this.btnSubstraction.TabIndex = 1;
            this.btnSubstraction.TabStop = true;
            this.btnSubstraction.Text = "Substraction";
            this.btnSubstraction.UseVisualStyleBackColor = true;
            this.btnSubstraction.CheckedChanged += new System.EventHandler(this.btnSubstraction_CheckedChanged);
            // 
            // btnAddition
            // 
            this.btnAddition.AutoSize = true;
            this.btnAddition.Location = new System.Drawing.Point(41, 48);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(105, 28);
            this.btnAddition.TabIndex = 0;
            this.btnAddition.TabStop = true;
            this.btnAddition.Text = "Addition";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.CheckedChanged += new System.EventHandler(this.btnAddition_CheckedChanged);
            // 
            // Result
            // 
            this.Result.Enabled = false;
            this.Result.Location = new System.Drawing.Point(56, 391);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(400, 30);
            this.Result.TabIndex = 6;
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(56, 450);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(400, 34);
            this.lblResult.TabIndex = 7;
            // 
            // frmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 575);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRadio";
            this.Text = "frmRadio";
            this.Load += new System.EventHandler(this.frmRadio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnMultiplication;
        private System.Windows.Forms.RadioButton btnDivision;
        private System.Windows.Forms.RadioButton btnSubstraction;
        private System.Windows.Forms.RadioButton btnAddition;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label lblResult;
    }
}