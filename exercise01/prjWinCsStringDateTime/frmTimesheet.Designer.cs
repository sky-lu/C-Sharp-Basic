namespace prjWinCsStringDateTime
{
    partial class frmTimesheet
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
            this.lblToday = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimeIn = new System.Windows.Forms.TextBox();
            this.btnTimeIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.btnTimeOut = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(307, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "MC-DONALDS-TIMESHEET";
            // 
            // lblToday
            // 
            this.lblToday.Location = new System.Drawing.Point(106, 83);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(347, 31);
            this.lblToday.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time In :";
            // 
            // txtTimeIn
            // 
            this.txtTimeIn.Location = new System.Drawing.Point(191, 136);
            this.txtTimeIn.Name = "txtTimeIn";
            this.txtTimeIn.Size = new System.Drawing.Size(115, 25);
            this.txtTimeIn.TabIndex = 3;
            // 
            // btnTimeIn
            // 
            this.btnTimeIn.Location = new System.Drawing.Point(312, 137);
            this.btnTimeIn.Name = "btnTimeIn";
            this.btnTimeIn.Size = new System.Drawing.Size(55, 23);
            this.btnTimeIn.TabIndex = 4;
            this.btnTimeIn.Text = "Now";
            this.btnTimeIn.UseVisualStyleBackColor = true;
            this.btnTimeIn.Click += new System.EventHandler(this.btnTimeIn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time Out :";
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.Location = new System.Drawing.Point(540, 137);
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(121, 25);
            this.txtTimeOut.TabIndex = 6;
            this.txtTimeOut.TextChanged += new System.EventHandler(this.txtTimeOut_TextChanged);
            // 
            // btnTimeOut
            // 
            this.btnTimeOut.Location = new System.Drawing.Point(667, 136);
            this.btnTimeOut.Name = "btnTimeOut";
            this.btnTimeOut.Size = new System.Drawing.Size(50, 23);
            this.btnTimeOut.TabIndex = 7;
            this.btnTimeOut.Text = "Now";
            this.btnTimeOut.UseVisualStyleBackColor = true;
            this.btnTimeOut.Click += new System.EventHandler(this.btnTimeOut_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(380, 234);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(99, 35);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(154, 346);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(507, 46);
            this.lblResult.TabIndex = 9;
            // 
            // frmTimesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 626);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnTimeOut);
            this.Controls.Add(this.txtTimeOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTimeIn);
            this.Controls.Add(this.txtTimeIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.label1);
            this.Name = "frmTimesheet";
            this.Text = "DateTime Methods and Properties";
            this.Load += new System.EventHandler(this.frmTimesheet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimeIn;
        private System.Windows.Forms.Button btnTimeIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimeOut;
        private System.Windows.Forms.Button btnTimeOut;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
    }
}