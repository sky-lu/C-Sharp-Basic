﻿namespace prjWinCsBasicOperators
{
    partial class frmVideo
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
            this.lblBigTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.chkDelivery = new System.Windows.Forms.CheckBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdiSingle = new System.Windows.Forms.RadioButton();
            this.rdiMarried = new System.Windows.Forms.RadioButton();
            this.rdiSeparated = new System.Windows.Forms.RadioButton();
            this.rdiWidow = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBigTitle
            // 
            this.lblBigTitle.AutoSize = true;
            this.lblBigTitle.Font = new System.Drawing.Font("SimSun", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBigTitle.Location = new System.Drawing.Point(189, 8);
            this.lblBigTitle.Name = "lblBigTitle";
            this.lblBigTitle.Size = new System.Drawing.Size(0, 33);
            this.lblBigTitle.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(98, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Movies-Rental-Store";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(130, 121);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(236, 27);
            this.txtNumber.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 156);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 27);
            this.txtName.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(404, 121);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 27);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chkDelivery
            // 
            this.chkDelivery.AutoSize = true;
            this.chkDelivery.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDelivery.Location = new System.Drawing.Point(21, 190);
            this.chkDelivery.Name = "chkDelivery";
            this.chkDelivery.Size = new System.Drawing.Size(128, 24);
            this.chkDelivery.TabIndex = 7;
            this.chkDelivery.Text = "Delivery ? :";
            this.chkDelivery.UseVisualStyleBackColor = true;
            this.chkDelivery.CheckedChanged += new System.EventHandler(this.chkDelivery_CheckedChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(37, 228);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(84, 20);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(130, 228);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(236, 55);
            this.txtAddress.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdiWidow);
            this.groupBox1.Controls.Add(this.rdiSeparated);
            this.groupBox1.Controls.Add(this.rdiMarried);
            this.groupBox1.Controls.Add(this.rdiSingle);
            this.groupBox1.Location = new System.Drawing.Point(32, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 154);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marital Status";
            // 
            // rdiSingle
            // 
            this.rdiSingle.AutoSize = true;
            this.rdiSingle.Location = new System.Drawing.Point(98, 26);
            this.rdiSingle.Name = "rdiSingle";
            this.rdiSingle.Size = new System.Drawing.Size(82, 24);
            this.rdiSingle.TabIndex = 0;
            this.rdiSingle.TabStop = true;
            this.rdiSingle.Text = "Single";
            this.rdiSingle.UseVisualStyleBackColor = true;
            // 
            // rdiMarried
            // 
            this.rdiMarried.AutoSize = true;
            this.rdiMarried.Location = new System.Drawing.Point(98, 56);
            this.rdiMarried.Name = "rdiMarried";
            this.rdiMarried.Size = new System.Drawing.Size(94, 24);
            this.rdiMarried.TabIndex = 1;
            this.rdiMarried.TabStop = true;
            this.rdiMarried.Text = "Married";
            this.rdiMarried.UseVisualStyleBackColor = true;
            // 
            // rdiSeparated
            // 
            this.rdiSeparated.AutoSize = true;
            this.rdiSeparated.Location = new System.Drawing.Point(98, 86);
            this.rdiSeparated.Name = "rdiSeparated";
            this.rdiSeparated.Size = new System.Drawing.Size(115, 24);
            this.rdiSeparated.TabIndex = 2;
            this.rdiSeparated.TabStop = true;
            this.rdiSeparated.Text = "Separated";
            this.rdiSeparated.UseVisualStyleBackColor = true;
            // 
            // rdiWidow
            // 
            this.rdiWidow.AutoSize = true;
            this.rdiWidow.Location = new System.Drawing.Point(98, 116);
            this.rdiWidow.Name = "rdiWidow";
            this.rdiWidow.Size = new System.Drawing.Size(85, 24);
            this.rdiWidow.TabIndex = 3;
            this.rdiWidow.TabStop = true;
            this.rdiWidow.Text = "Widow";
            this.rdiWidow.UseVisualStyleBackColor = true;
            // 
            // frmVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.chkDelivery);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBigTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVideo";
            this.Text = "frmVideo";
            this.Load += new System.EventHandler(this.frmVideo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBigTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox chkDelivery;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdiWidow;
        private System.Windows.Forms.RadioButton rdiSeparated;
        private System.Windows.Forms.RadioButton rdiMarried;
        private System.Windows.Forms.RadioButton rdiSingle;
    }
}