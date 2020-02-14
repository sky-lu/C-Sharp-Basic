namespace prjWinCsStringDateTime
{
    partial class frmCalculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radAddition = new System.Windows.Forms.RadioButton();
            this.radDivision = new System.Windows.Forms.RadioButton();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(268, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULATOR FUNCTIONS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "value 1 :";
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(215, 103);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(100, 25);
            this.txtValue1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Value 2 :";
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(547, 103);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtValue2.Size = new System.Drawing.Size(100, 25);
            this.txtValue2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDivision);
            this.groupBox1.Controls.Add(this.radAddition);
            this.groupBox1.Location = new System.Drawing.Point(133, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operators";
            // 
            // radAddition
            // 
            this.radAddition.AutoSize = true;
            this.radAddition.Location = new System.Drawing.Point(38, 49);
            this.radAddition.Name = "radAddition";
            this.radAddition.Size = new System.Drawing.Size(92, 19);
            this.radAddition.TabIndex = 0;
            this.radAddition.TabStop = true;
            this.radAddition.Text = "Addition";
            this.radAddition.UseVisualStyleBackColor = true;
            // 
            // radDivision
            // 
            this.radDivision.AutoSize = true;
            this.radDivision.Location = new System.Drawing.Point(284, 49);
            this.radDivision.Name = "radDivision";
            this.radDivision.Size = new System.Drawing.Size(92, 19);
            this.radDivision.TabIndex = 1;
            this.radDivision.TabStop = true;
            this.radDivision.Text = "Division";
            this.radDivision.UseVisualStyleBackColor = true;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(188, 303);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 6;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(417, 303);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 7;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(154, 393);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(426, 40);
            this.lblResult.TabIndex = 8;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 547);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCalculator";
            this.Text = "frmCalculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDivision;
        private System.Windows.Forms.RadioButton radAddition;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblResult;
    }
}