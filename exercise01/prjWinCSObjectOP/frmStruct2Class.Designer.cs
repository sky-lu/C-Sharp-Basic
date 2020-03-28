namespace prjWinCSObjectOP
{
    partial class frmStruct2Class
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDUniversal = new System.Windows.Forms.Button();
            this.btnDStandard = new System.Windows.Forms.Button();
            this.lblUniversal = new System.Windows.Forms.Label();
            this.lblStandard = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(241, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "APPOINTMENTS-MANAGEMENT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.txtSecond);
            this.groupBox1.Controls.Add(this.txtMinute);
            this.groupBox1.Controls.Add(this.txtHour);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(50, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 248);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Appointment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Hour :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Minute :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter Second :";
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(170, 55);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(100, 30);
            this.txtHour.TabIndex = 2;
            // 
            // txtMinute
            // 
            this.txtMinute.Location = new System.Drawing.Point(170, 97);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(100, 30);
            this.txtMinute.TabIndex = 5;
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(170, 142);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(100, 30);
            this.txtSecond.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(20, 195);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 34);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(115, 195);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(167, 34);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create or Adjust";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDUniversal
            // 
            this.btnDUniversal.Location = new System.Drawing.Point(409, 308);
            this.btnDUniversal.Name = "btnDUniversal";
            this.btnDUniversal.Size = new System.Drawing.Size(214, 34);
            this.btnDUniversal.TabIndex = 8;
            this.btnDUniversal.Text = "Display in Universal >>";
            this.btnDUniversal.UseVisualStyleBackColor = true;
            this.btnDUniversal.Click += new System.EventHandler(this.btnDUniversal_Click);
            // 
            // btnDStandard
            // 
            this.btnDStandard.Location = new System.Drawing.Point(409, 372);
            this.btnDStandard.Name = "btnDStandard";
            this.btnDStandard.Size = new System.Drawing.Size(214, 34);
            this.btnDStandard.TabIndex = 9;
            this.btnDStandard.Text = "Display in Standard >>";
            this.btnDStandard.UseVisualStyleBackColor = true;
            // 
            // lblUniversal
            // 
            this.lblUniversal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblUniversal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUniversal.Location = new System.Drawing.Point(677, 308);
            this.lblUniversal.Name = "lblUniversal";
            this.lblUniversal.Size = new System.Drawing.Size(154, 34);
            this.lblUniversal.TabIndex = 10;
            // 
            // lblStandard
            // 
            this.lblStandard.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblStandard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStandard.Location = new System.Drawing.Point(677, 372);
            this.lblStandard.Name = "lblStandard";
            this.lblStandard.Size = new System.Drawing.Size(154, 34);
            this.lblStandard.TabIndex = 11;
            // 
            // frmStruct2Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 598);
            this.Controls.Add(this.lblStandard);
            this.Controls.Add(this.lblUniversal);
            this.Controls.Add(this.btnDStandard);
            this.Controls.Add(this.btnDUniversal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmStruct2Class";
            this.Text = "frmStruct2Class";
            this.Load += new System.EventHandler(this.frmStruct2Class_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDUniversal;
        private System.Windows.Forms.Button btnDStandard;
        private System.Windows.Forms.Label lblUniversal;
        private System.Windows.Forms.Label lblStandard;
    }
}