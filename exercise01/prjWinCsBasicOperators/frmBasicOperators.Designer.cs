namespace prjWinCsBasicOperators
{
    partial class frmBasicOperators
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
            this.label4 = new System.Windows.Forms.Label();
            this.chkArithemetics = new System.Windows.Forms.CheckBox();
            this.chkComparison = new System.Windows.Forms.CheckBox();
            this.groupArithmetic = new System.Windows.Forms.GroupBox();
            this.rdiAdd = new System.Windows.Forms.RadioButton();
            this.rdiSub = new System.Windows.Forms.RadioButton();
            this.rdiMult = new System.Windows.Forms.RadioButton();
            this.rdiDiv = new System.Windows.Forms.RadioButton();
            this.btnCompute = new System.Windows.Forms.Button();
            this.groupComparison = new System.Windows.Forms.GroupBox();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.rdiDiff = new System.Windows.Forms.RadioButton();
            this.rdiEqual = new System.Windows.Forms.RadioButton();
            this.rdiSmall = new System.Windows.Forms.RadioButton();
            this.rdiGreat = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupArithmetic.SuspendLayout();
            this.groupComparison.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(150, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "BASIC-OPERATORS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value1 :";
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(134, 73);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(100, 30);
            this.txtValue1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Value2 :";
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(393, 73);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(100, 30);
            this.txtValue2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select type of operators";
            // 
            // chkArithemetics
            // 
            this.chkArithemetics.AutoSize = true;
            this.chkArithemetics.Location = new System.Drawing.Point(95, 165);
            this.chkArithemetics.Name = "chkArithemetics";
            this.chkArithemetics.Size = new System.Drawing.Size(131, 28);
            this.chkArithemetics.TabIndex = 6;
            this.chkArithemetics.Text = "Arithmetics";
            this.chkArithemetics.UseVisualStyleBackColor = true;
            this.chkArithemetics.CheckedChanged += new System.EventHandler(this.chkArithemetics_CheckedChanged);
            // 
            // chkComparison
            // 
            this.chkComparison.AutoSize = true;
            this.chkComparison.Location = new System.Drawing.Point(313, 165);
            this.chkComparison.Name = "chkComparison";
            this.chkComparison.Size = new System.Drawing.Size(134, 28);
            this.chkComparison.TabIndex = 7;
            this.chkComparison.Text = "Comparison";
            this.chkComparison.UseVisualStyleBackColor = true;
            this.chkComparison.CheckedChanged += new System.EventHandler(this.chkComparison_CheckedChanged);
            // 
            // groupArithmetic
            // 
            this.groupArithmetic.Controls.Add(this.btnCompute);
            this.groupArithmetic.Controls.Add(this.rdiDiv);
            this.groupArithmetic.Controls.Add(this.rdiMult);
            this.groupArithmetic.Controls.Add(this.rdiSub);
            this.groupArithmetic.Controls.Add(this.rdiAdd);
            this.groupArithmetic.Location = new System.Drawing.Point(54, 199);
            this.groupArithmetic.Name = "groupArithmetic";
            this.groupArithmetic.Size = new System.Drawing.Size(458, 100);
            this.groupArithmetic.TabIndex = 8;
            this.groupArithmetic.TabStop = false;
            this.groupArithmetic.Text = "Arithmetic Operators";
            // 
            // rdiAdd
            // 
            this.rdiAdd.AutoSize = true;
            this.rdiAdd.Location = new System.Drawing.Point(51, 29);
            this.rdiAdd.Name = "rdiAdd";
            this.rdiAdd.Size = new System.Drawing.Size(66, 28);
            this.rdiAdd.TabIndex = 0;
            this.rdiAdd.Text = "Add";
            this.rdiAdd.UseVisualStyleBackColor = true;
            this.rdiAdd.CheckedChanged += new System.EventHandler(this.rdiAdd_CheckedChanged);
            // 
            // rdiSub
            // 
            this.rdiSub.AutoSize = true;
            this.rdiSub.Location = new System.Drawing.Point(151, 29);
            this.rdiSub.Name = "rdiSub";
            this.rdiSub.Size = new System.Drawing.Size(63, 28);
            this.rdiSub.TabIndex = 1;
            this.rdiSub.TabStop = true;
            this.rdiSub.Text = "Sub";
            this.rdiSub.UseVisualStyleBackColor = true;
            this.rdiSub.CheckedChanged += new System.EventHandler(this.rdiSub_CheckedChanged);
            // 
            // rdiMult
            // 
            this.rdiMult.AutoSize = true;
            this.rdiMult.Location = new System.Drawing.Point(246, 29);
            this.rdiMult.Name = "rdiMult";
            this.rdiMult.Size = new System.Drawing.Size(71, 28);
            this.rdiMult.TabIndex = 2;
            this.rdiMult.TabStop = true;
            this.rdiMult.Text = "Mult";
            this.rdiMult.UseVisualStyleBackColor = true;
            this.rdiMult.CheckedChanged += new System.EventHandler(this.rdiMult_CheckedChanged);
            // 
            // rdiDiv
            // 
            this.rdiDiv.AutoSize = true;
            this.rdiDiv.Location = new System.Drawing.Point(360, 29);
            this.rdiDiv.Name = "rdiDiv";
            this.rdiDiv.Size = new System.Drawing.Size(59, 28);
            this.rdiDiv.TabIndex = 3;
            this.rdiDiv.TabStop = true;
            this.rdiDiv.Text = "Div";
            this.rdiDiv.UseVisualStyleBackColor = true;
            this.rdiDiv.CheckedChanged += new System.EventHandler(this.rdiDiv_CheckedChanged);
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(175, 63);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(104, 31);
            this.btnCompute.TabIndex = 4;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // groupComparison
            // 
            this.groupComparison.Controls.Add(this.btnEvaluate);
            this.groupComparison.Controls.Add(this.rdiDiff);
            this.groupComparison.Controls.Add(this.rdiEqual);
            this.groupComparison.Controls.Add(this.rdiSmall);
            this.groupComparison.Controls.Add(this.rdiGreat);
            this.groupComparison.Location = new System.Drawing.Point(54, 330);
            this.groupComparison.Name = "groupComparison";
            this.groupComparison.Size = new System.Drawing.Size(458, 100);
            this.groupComparison.TabIndex = 9;
            this.groupComparison.TabStop = false;
            this.groupComparison.Text = "Comparison Operators";
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Location = new System.Drawing.Point(171, 63);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(104, 31);
            this.btnEvaluate.TabIndex = 9;
            this.btnEvaluate.Text = "Evaluate";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // rdiDiff
            // 
            this.rdiDiff.AutoSize = true;
            this.rdiDiff.Location = new System.Drawing.Point(356, 29);
            this.rdiDiff.Name = "rdiDiff";
            this.rdiDiff.Size = new System.Drawing.Size(63, 28);
            this.rdiDiff.TabIndex = 8;
            this.rdiDiff.TabStop = true;
            this.rdiDiff.Text = "Diff";
            this.rdiDiff.UseVisualStyleBackColor = true;
            this.rdiDiff.CheckedChanged += new System.EventHandler(this.rdiDiff_CheckedChanged);
            // 
            // rdiEqual
            // 
            this.rdiEqual.AutoSize = true;
            this.rdiEqual.Location = new System.Drawing.Point(242, 29);
            this.rdiEqual.Name = "rdiEqual";
            this.rdiEqual.Size = new System.Drawing.Size(78, 28);
            this.rdiEqual.TabIndex = 7;
            this.rdiEqual.TabStop = true;
            this.rdiEqual.Text = "Equal";
            this.rdiEqual.UseVisualStyleBackColor = true;
            this.rdiEqual.CheckedChanged += new System.EventHandler(this.rdiEqual_CheckedChanged);
            // 
            // rdiSmall
            // 
            this.rdiSmall.AutoSize = true;
            this.rdiSmall.Location = new System.Drawing.Point(147, 29);
            this.rdiSmall.Name = "rdiSmall";
            this.rdiSmall.Size = new System.Drawing.Size(78, 28);
            this.rdiSmall.TabIndex = 6;
            this.rdiSmall.TabStop = true;
            this.rdiSmall.Text = "Small";
            this.rdiSmall.UseVisualStyleBackColor = true;
            this.rdiSmall.CheckedChanged += new System.EventHandler(this.rdiSmall_CheckedChanged);
            // 
            // rdiGreat
            // 
            this.rdiGreat.AutoSize = true;
            this.rdiGreat.Location = new System.Drawing.Point(47, 29);
            this.rdiGreat.Name = "rdiGreat";
            this.rdiGreat.Size = new System.Drawing.Size(78, 28);
            this.rdiGreat.TabIndex = 5;
            this.rdiGreat.TabStop = true;
            this.rdiGreat.Text = "Great";
            this.rdiGreat.UseVisualStyleBackColor = true;
            this.rdiGreat.CheckedChanged += new System.EventHandler(this.rdiGreat_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(67, 463);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(426, 38);
            this.lblResult.TabIndex = 10;
            // 
            // frmBasicOperators
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(649, 548);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.groupComparison);
            this.Controls.Add(this.groupArithmetic);
            this.Controls.Add(this.chkComparison);
            this.Controls.Add(this.chkArithemetics);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frmBasicOperators";
            this.Text = "frmBasicOperators";
            this.Load += new System.EventHandler(this.frmBasicOperators_Load);
            this.groupArithmetic.ResumeLayout(false);
            this.groupArithmetic.PerformLayout();
            this.groupComparison.ResumeLayout(false);
            this.groupComparison.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkArithemetics;
        private System.Windows.Forms.CheckBox chkComparison;
        private System.Windows.Forms.GroupBox groupArithmetic;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.RadioButton rdiDiv;
        private System.Windows.Forms.RadioButton rdiMult;
        private System.Windows.Forms.RadioButton rdiSub;
        private System.Windows.Forms.RadioButton rdiAdd;
        private System.Windows.Forms.GroupBox groupComparison;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.RadioButton rdiDiff;
        private System.Windows.Forms.RadioButton rdiEqual;
        private System.Windows.Forms.RadioButton rdiSmall;
        private System.Windows.Forms.RadioButton rdiGreat;
        private System.Windows.Forms.Label lblResult;
    }
}