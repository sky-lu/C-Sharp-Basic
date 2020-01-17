namespace prjWinCsBasicOperators
{
    partial class frmOperators
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
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsubtraction = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMode = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnEqualSmaller = new System.Windows.Forms.Button();
            this.btnEqualGreater = new System.Windows.Forms.Button();
            this.btnSmaller = new System.Windows.Forms.Button();
            this.btngreater = new System.Windows.Forms.Button();
            this.btnNotEqual = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "BASIC OPERATORS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value 1 :";
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(144, 77);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(100, 27);
            this.txtValue1.TabIndex = 2;
            this.txtValue1.TextChanged += new System.EventHandler(this.txtValue1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Value 2 :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(471, 77);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(100, 27);
            this.txtValue2.TabIndex = 4;
            this.txtValue2.TextChanged += new System.EventHandler(this.txtValue2_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(43, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(68, 476);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(503, 32);
            this.lblResult.TabIndex = 6;
            this.lblResult.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(289, 437);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 36);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMode);
            this.groupBox1.Controls.Add(this.btnDivision);
            this.groupBox1.Controls.Add(this.btnMultiplication);
            this.groupBox1.Controls.Add(this.btnsubtraction);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(53, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arithmetic Operators";
            // 
            // btnsubtraction
            // 
            this.btnsubtraction.Location = new System.Drawing.Point(119, 38);
            this.btnsubtraction.Name = "btnsubtraction";
            this.btnsubtraction.Size = new System.Drawing.Size(43, 36);
            this.btnsubtraction.TabIndex = 6;
            this.btnsubtraction.Text = "-";
            this.btnsubtraction.UseVisualStyleBackColor = true;
            this.btnsubtraction.Click += new System.EventHandler(this.btnsubtraction_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(212, 38);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(43, 36);
            this.btnMultiplication.TabIndex = 7;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(317, 38);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(43, 36);
            this.btnDivision.TabIndex = 8;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnMode
            // 
            this.btnMode.Location = new System.Drawing.Point(418, 38);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(43, 36);
            this.btnMode.TabIndex = 9;
            this.btnMode.Text = "%";
            this.btnMode.UseVisualStyleBackColor = true;
            this.btnMode.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNotEqual);
            this.groupBox2.Controls.Add(this.btnEqual);
            this.groupBox2.Controls.Add(this.btnEqualSmaller);
            this.groupBox2.Controls.Add(this.btnEqualGreater);
            this.groupBox2.Controls.Add(this.btnSmaller);
            this.groupBox2.Controls.Add(this.btngreater);
            this.groupBox2.Location = new System.Drawing.Point(53, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comparison Operators";
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(352, 38);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(43, 36);
            this.btnEqual.TabIndex = 9;
            this.btnEqual.Text = "==";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnEqualSmaller
            // 
            this.btnEqualSmaller.Location = new System.Drawing.Point(263, 38);
            this.btnEqualSmaller.Name = "btnEqualSmaller";
            this.btnEqualSmaller.Size = new System.Drawing.Size(43, 36);
            this.btnEqualSmaller.TabIndex = 8;
            this.btnEqualSmaller.Text = "<=";
            this.btnEqualSmaller.UseVisualStyleBackColor = true;
            this.btnEqualSmaller.Click += new System.EventHandler(this.btnEqualSmaller_Click);
            // 
            // btnEqualGreater
            // 
            this.btnEqualGreater.Location = new System.Drawing.Point(174, 38);
            this.btnEqualGreater.Name = "btnEqualGreater";
            this.btnEqualGreater.Size = new System.Drawing.Size(43, 36);
            this.btnEqualGreater.TabIndex = 7;
            this.btnEqualGreater.Text = ">=";
            this.btnEqualGreater.UseVisualStyleBackColor = true;
            this.btnEqualGreater.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnSmaller
            // 
            this.btnSmaller.Location = new System.Drawing.Point(91, 38);
            this.btnSmaller.Name = "btnSmaller";
            this.btnSmaller.Size = new System.Drawing.Size(43, 36);
            this.btnSmaller.TabIndex = 6;
            this.btnSmaller.Text = "<";
            this.btnSmaller.UseVisualStyleBackColor = true;
            this.btnSmaller.Click += new System.EventHandler(this.btnSmaller_Click);
            // 
            // btngreater
            // 
            this.btngreater.Location = new System.Drawing.Point(15, 38);
            this.btngreater.Name = "btngreater";
            this.btngreater.Size = new System.Drawing.Size(43, 36);
            this.btngreater.TabIndex = 5;
            this.btngreater.Text = ">";
            this.btngreater.UseVisualStyleBackColor = true;
            this.btngreater.Click += new System.EventHandler(this.btngreater_Click);
            // 
            // btnNotEqual
            // 
            this.btnNotEqual.Location = new System.Drawing.Point(429, 38);
            this.btnNotEqual.Name = "btnNotEqual";
            this.btnNotEqual.Size = new System.Drawing.Size(43, 36);
            this.btnNotEqual.TabIndex = 10;
            this.btnNotEqual.Text = "!=";
            this.btnNotEqual.UseVisualStyleBackColor = true;
            this.btnNotEqual.Click += new System.EventHandler(this.btnNotEqual_Click);
            // 
            // frmOperators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 584);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmOperators";
            this.Text = "frmOperators";
            this.Load += new System.EventHandler(this.frmOperators_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsubtraction;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnEqualSmaller;
        private System.Windows.Forms.Button btnEqualGreater;
        private System.Windows.Forms.Button btnSmaller;
        private System.Windows.Forms.Button btngreater;
        private System.Windows.Forms.Button btnNotEqual;
    }
}