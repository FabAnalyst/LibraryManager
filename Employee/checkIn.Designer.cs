namespace LibraryManager.Employee
{
    partial class checkIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkIn));
            this.label1 = new System.Windows.Forms.Label();
            this.bookIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkInButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.checkInDate = new System.Windows.Forms.DateTimePicker();
            this.feeTextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.dueDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ID:";
            // 
            // bookIDTextBox
            // 
            this.bookIDTextBox.Location = new System.Drawing.Point(112, 30);
            this.bookIDTextBox.Name = "bookIDTextBox";
            this.bookIDTextBox.Size = new System.Drawing.Size(126, 20);
            this.bookIDTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date checked in";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Due Date";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Location = new System.Drawing.Point(112, 82);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(126, 20);
            this.customerIDTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Customer ID";
            // 
            // checkInButton
            // 
            this.checkInButton.Location = new System.Drawing.Point(52, 179);
            this.checkInButton.Name = "checkInButton";
            this.checkInButton.Size = new System.Drawing.Size(54, 45);
            this.checkInButton.TabIndex = 8;
            this.checkInButton.Text = "Check In";
            this.checkInButton.UseVisualStyleBackColor = true;
            this.checkInButton.Click += new System.EventHandler(this.checkInButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(175, 179);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(54, 45);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // checkInDate
            // 
            this.checkInDate.Location = new System.Drawing.Point(112, 56);
            this.checkInDate.Name = "checkInDate";
            this.checkInDate.Size = new System.Drawing.Size(126, 20);
            this.checkInDate.TabIndex = 10;
            // 
            // feeTextBox
            // 
            this.feeTextBox.Location = new System.Drawing.Point(112, 134);
            this.feeTextBox.Name = "feeTextBox";
            this.feeTextBox.Size = new System.Drawing.Size(126, 20);
            this.feeTextBox.TabIndex = 12;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(20, 137);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(25, 13);
            this.label.TabIndex = 11;
            this.label.Text = "Fee";
            // 
            // dueDateTime
            // 
            this.dueDateTime.Location = new System.Drawing.Point(112, 108);
            this.dueDateTime.Name = "dueDateTime";
            this.dueDateTime.Size = new System.Drawing.Size(126, 20);
            this.dueDateTime.TabIndex = 13;
            // 
            // checkIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 265);
            this.Controls.Add(this.dueDateTime);
            this.Controls.Add(this.feeTextBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.checkInDate);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.checkInButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bookIDTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "checkIn";
            this.Text = "Check in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button checkInButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DateTimePicker checkInDate;
        private System.Windows.Forms.TextBox feeTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DateTimePicker dueDateTime;
    }
}