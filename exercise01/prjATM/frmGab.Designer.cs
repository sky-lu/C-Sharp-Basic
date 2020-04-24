namespace prjATM
{
    partial class frmGab
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
            this.btnReadCard = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblValidationInfo = new System.Windows.Forms.Label();
            this.btnPinValidate = new System.Windows.Forms.Button();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstAccountType = new System.Windows.Forms.ComboBox();
            this.btnAccountType = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.radConsult = new System.Windows.Forms.RadioButton();
            this.radWithdraw = new System.Windows.Forms.RadioButton();
            this.radDeposit = new System.Windows.Forms.RadioButton();
            this.btnTransactionType = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblAccountInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTerminate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = " ROYALE BANK ATM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReadCard);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(75, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "READING OF CARD";
            // 
            // btnReadCard
            // 
            this.btnReadCard.Location = new System.Drawing.Point(505, 64);
            this.btnReadCard.Name = "btnReadCard";
            this.btnReadCard.Size = new System.Drawing.Size(136, 36);
            this.btnReadCard.TabIndex = 2;
            this.btnReadCard.Text = "NEXT >>";
            this.btnReadCard.UseVisualStyleBackColor = true;
            this.btnReadCard.Click += new System.EventHandler(this.btnReadCard_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(236, 30);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(304, 27);
            this.txtNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "CARD NUMBER :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblValidationInfo);
            this.groupBox2.Controls.Add(this.btnPinValidate);
            this.groupBox2.Controls.Add(this.txtPin);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(75, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(691, 145);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PIN VALIDATION";
            // 
            // lblValidationInfo
            // 
            this.lblValidationInfo.Location = new System.Drawing.Point(50, 25);
            this.lblValidationInfo.Name = "lblValidationInfo";
            this.lblValidationInfo.Size = new System.Drawing.Size(329, 28);
            this.lblValidationInfo.TabIndex = 6;
            // 
            // btnPinValidate
            // 
            this.btnPinValidate.Location = new System.Drawing.Point(505, 100);
            this.btnPinValidate.Name = "btnPinValidate";
            this.btnPinValidate.Size = new System.Drawing.Size(136, 36);
            this.btnPinValidate.TabIndex = 5;
            this.btnPinValidate.Text = "NEXT >>";
            this.btnPinValidate.UseVisualStyleBackColor = true;
            this.btnPinValidate.Click += new System.EventHandler(this.btnPinValidate_Click);
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(236, 66);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(304, 27);
            this.txtPin.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "ENTER PIN :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstAccountType);
            this.groupBox3.Controls.Add(this.btnAccountType);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(75, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(691, 121);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ACCOUNT TYPES";
            // 
            // lstAccountType
            // 
            this.lstAccountType.FormattingEnabled = true;
            this.lstAccountType.Location = new System.Drawing.Point(236, 35);
            this.lstAccountType.Name = "lstAccountType";
            this.lstAccountType.Size = new System.Drawing.Size(288, 27);
            this.lstAccountType.TabIndex = 3;
            // 
            // btnAccountType
            // 
            this.btnAccountType.Location = new System.Drawing.Point(505, 74);
            this.btnAccountType.Name = "btnAccountType";
            this.btnAccountType.Size = new System.Drawing.Size(136, 36);
            this.btnAccountType.TabIndex = 2;
            this.btnAccountType.Text = "NEXT >>";
            this.btnAccountType.UseVisualStyleBackColor = true;
            this.btnAccountType.Click += new System.EventHandler(this.btnAccountType_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "SELECT TYPE :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblWithdraw);
            this.groupBox4.Controls.Add(this.lblDeposit);
            this.groupBox4.Controls.Add(this.txtWithdraw);
            this.groupBox4.Controls.Add(this.txtDeposit);
            this.groupBox4.Controls.Add(this.radConsult);
            this.groupBox4.Controls.Add(this.radWithdraw);
            this.groupBox4.Controls.Add(this.radDeposit);
            this.groupBox4.Controls.Add(this.btnTransactionType);
            this.groupBox4.Location = new System.Drawing.Point(75, 459);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(691, 161);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TRANSACTION TYPES";
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Location = new System.Drawing.Point(428, 79);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(18, 19);
            this.lblWithdraw.TabIndex = 9;
            this.lblWithdraw.Text = "$";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(428, 39);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(18, 19);
            this.lblDeposit.TabIndex = 8;
            this.lblDeposit.Text = "$";
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(236, 73);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(186, 27);
            this.txtWithdraw.TabIndex = 7;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(236, 35);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(186, 27);
            this.txtDeposit.TabIndex = 6;
            // 
            // radConsult
            // 
            this.radConsult.AutoSize = true;
            this.radConsult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radConsult.Location = new System.Drawing.Point(20, 111);
            this.radConsult.Name = "radConsult";
            this.radConsult.Size = new System.Drawing.Size(98, 23);
            this.radConsult.TabIndex = 5;
            this.radConsult.TabStop = true;
            this.radConsult.Text = "CONSULT";
            this.radConsult.UseVisualStyleBackColor = true;
            // 
            // radWithdraw
            // 
            this.radWithdraw.AutoSize = true;
            this.radWithdraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radWithdraw.Location = new System.Drawing.Point(20, 77);
            this.radWithdraw.Name = "radWithdraw";
            this.radWithdraw.Size = new System.Drawing.Size(117, 23);
            this.radWithdraw.TabIndex = 4;
            this.radWithdraw.TabStop = true;
            this.radWithdraw.Text = "WITHDRAW";
            this.radWithdraw.UseVisualStyleBackColor = true;
            // 
            // radDeposit
            // 
            this.radDeposit.AutoSize = true;
            this.radDeposit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radDeposit.Location = new System.Drawing.Point(20, 39);
            this.radDeposit.Name = "radDeposit";
            this.radDeposit.Size = new System.Drawing.Size(91, 23);
            this.radDeposit.TabIndex = 3;
            this.radDeposit.TabStop = true;
            this.radDeposit.Text = "DEPOSIT";
            this.radDeposit.UseVisualStyleBackColor = true;
            // 
            // btnTransactionType
            // 
            this.btnTransactionType.Location = new System.Drawing.Point(475, 115);
            this.btnTransactionType.Name = "btnTransactionType";
            this.btnTransactionType.Size = new System.Drawing.Size(136, 36);
            this.btnTransactionType.TabIndex = 2;
            this.btnTransactionType.Text = "NEXT >>";
            this.btnTransactionType.UseVisualStyleBackColor = true;
            this.btnTransactionType.Click += new System.EventHandler(this.btnTransactionType_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblAccountInfo);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.btnTerminate);
            this.groupBox5.Location = new System.Drawing.Point(75, 636);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(691, 163);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ACCOUNT INFORMATIONS";
            // 
            // lblAccountInfo
            // 
            this.lblAccountInfo.Location = new System.Drawing.Point(30, 35);
            this.lblAccountInfo.Name = "lblAccountInfo";
            this.lblAccountInfo.Size = new System.Drawing.Size(271, 113);
            this.lblAccountInfo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(50, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(329, 38);
            this.label5.TabIndex = 6;
            // 
            // btnTerminate
            // 
            this.btnTerminate.Location = new System.Drawing.Point(486, 112);
            this.btnTerminate.Name = "btnTerminate";
            this.btnTerminate.Size = new System.Drawing.Size(143, 36);
            this.btnTerminate.TabIndex = 5;
            this.btnTerminate.Text = "TERMINATE";
            this.btnTerminate.UseVisualStyleBackColor = true;
            this.btnTerminate.Click += new System.EventHandler(this.btnTerminate_Click);
            // 
            // frmGab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 823);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGab";
            this.Text = "frmGab";
            this.Load += new System.EventHandler(this.frmGab_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmGab_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReadCard;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblValidationInfo;
        private System.Windows.Forms.Button btnPinValidate;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox lstAccountType;
        private System.Windows.Forms.Button btnAccountType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.RadioButton radConsult;
        private System.Windows.Forms.RadioButton radWithdraw;
        private System.Windows.Forms.RadioButton radDeposit;
        private System.Windows.Forms.Button btnTransactionType;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblAccountInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTerminate;
    }
}