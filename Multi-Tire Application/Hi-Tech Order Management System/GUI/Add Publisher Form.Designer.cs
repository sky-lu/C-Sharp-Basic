namespace Hi_Tech_Order_Management_System.GUI
{
    partial class Add_Publisher_Form
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
            this.textBoxPublisherId = new System.Windows.Forms.TextBox();
            this.textBoxWebAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPublisherName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Publisher Id :";
            // 
            // textBoxPublisherId
            // 
            this.textBoxPublisherId.Location = new System.Drawing.Point(180, 39);
            this.textBoxPublisherId.Name = "textBoxPublisherId";
            this.textBoxPublisherId.Size = new System.Drawing.Size(175, 24);
            this.textBoxPublisherId.TabIndex = 1;
            // 
            // textBoxWebAddress
            // 
            this.textBoxWebAddress.Location = new System.Drawing.Point(180, 150);
            this.textBoxWebAddress.Name = "textBoxWebAddress";
            this.textBoxWebAddress.Size = new System.Drawing.Size(175, 24);
            this.textBoxWebAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Web Address :";
            // 
            // textBoxPublisherName
            // 
            this.textBoxPublisherName.Location = new System.Drawing.Point(180, 94);
            this.textBoxPublisherName.Name = "textBoxPublisherName";
            this.textBoxPublisherName.Size = new System.Drawing.Size(175, 24);
            this.textBoxPublisherName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Publisher Name :";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(133, 236);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(131, 43);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Add_Publisher_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 334);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPublisherName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxWebAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPublisherId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Add_Publisher_Form";
            this.Text = "Add_Publisher_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPublisherId;
        private System.Windows.Forms.TextBox textBoxWebAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPublisherName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdd;
    }
}