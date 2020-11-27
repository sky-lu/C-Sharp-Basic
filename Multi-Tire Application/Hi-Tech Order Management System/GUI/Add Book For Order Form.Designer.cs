namespace Hi_Tech_Order_Management_System.GUI
{
    partial class Add_Book_For_Order_Form
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
            this.textBoxOrderId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBookId = new System.Windows.Forms.ComboBox();
            this.labelBookInfo = new System.Windows.Forms.Label();
            this.buttonAddTOOrder = new System.Windows.Forms.Button();
            this.buttonAddNewBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Id :";
            // 
            // textBoxOrderId
            // 
            this.textBoxOrderId.Location = new System.Drawing.Point(118, 65);
            this.textBoxOrderId.Name = "textBoxOrderId";
            this.textBoxOrderId.Size = new System.Drawing.Size(211, 24);
            this.textBoxOrderId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Id :";
            // 
            // comboBoxBookId
            // 
            this.comboBoxBookId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBookId.FormattingEnabled = true;
            this.comboBoxBookId.Location = new System.Drawing.Point(118, 124);
            this.comboBoxBookId.Name = "comboBoxBookId";
            this.comboBoxBookId.Size = new System.Drawing.Size(211, 26);
            this.comboBoxBookId.TabIndex = 3;
            this.comboBoxBookId.SelectedIndexChanged += new System.EventHandler(this.comboBoxBookId_SelectedIndexChanged);
            // 
            // labelBookInfo
            // 
            this.labelBookInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBookInfo.Location = new System.Drawing.Point(115, 173);
            this.labelBookInfo.Name = "labelBookInfo";
            this.labelBookInfo.Size = new System.Drawing.Size(214, 111);
            this.labelBookInfo.TabIndex = 4;
            // 
            // buttonAddTOOrder
            // 
            this.buttonAddTOOrder.Location = new System.Drawing.Point(37, 323);
            this.buttonAddTOOrder.Name = "buttonAddTOOrder";
            this.buttonAddTOOrder.Size = new System.Drawing.Size(116, 41);
            this.buttonAddTOOrder.TabIndex = 5;
            this.buttonAddTOOrder.Text = "Add to Order";
            this.buttonAddTOOrder.UseVisualStyleBackColor = true;
            this.buttonAddTOOrder.Click += new System.EventHandler(this.buttonAddTOOrder_Click);
            // 
            // buttonAddNewBook
            // 
            this.buttonAddNewBook.Location = new System.Drawing.Point(213, 323);
            this.buttonAddNewBook.Name = "buttonAddNewBook";
            this.buttonAddNewBook.Size = new System.Drawing.Size(116, 41);
            this.buttonAddNewBook.TabIndex = 6;
            this.buttonAddNewBook.Text = "Add New Book";
            this.buttonAddNewBook.UseVisualStyleBackColor = true;
            this.buttonAddNewBook.Click += new System.EventHandler(this.buttonAddNewBook_Click);
            // 
            // Add_Book_For_Order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 399);
            this.Controls.Add(this.buttonAddNewBook);
            this.Controls.Add(this.buttonAddTOOrder);
            this.Controls.Add(this.labelBookInfo);
            this.Controls.Add(this.comboBoxBookId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOrderId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Add_Book_For_Order_Form";
            this.Text = "Add_Book_For_Order_Form";
            this.Load += new System.EventHandler(this.Add_Book_For_Order_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOrderId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBookId;
        private System.Windows.Forms.Label labelBookInfo;
        private System.Windows.Forms.Button buttonAddTOOrder;
        private System.Windows.Forms.Button buttonAddNewBook;
    }
}