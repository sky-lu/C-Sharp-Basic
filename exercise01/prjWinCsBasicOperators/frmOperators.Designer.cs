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
            this.label4 = new System.Windows.Forms.Label();
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
            this.txtValue1.Text = "25";
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
            this.txtValue2.Text = "5";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(105, 172);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(43, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(80, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(503, 32);
            this.label4.TabIndex = 6;
            // 
            // frmOperators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 584);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmOperators";
            this.Text = "frmOperators";
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
        private System.Windows.Forms.Label label4;
    }
}