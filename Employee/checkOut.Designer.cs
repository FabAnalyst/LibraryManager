namespace LibraryManager.Employee
{
    partial class checkOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkOut));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bookIDTextBox = new System.Windows.Forms.TextBox();
            this.checkOutDatePicker = new System.Windows.Forms.DateTimePicker();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.dueDateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Check Out Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Due Date:";
            // 
            // bookIDTextBox
            // 
            this.bookIDTextBox.Location = new System.Drawing.Point(130, 37);
            this.bookIDTextBox.Name = "bookIDTextBox";
            this.bookIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.bookIDTextBox.TabIndex = 4;
            // 
            // checkOutDatePicker
            // 
            this.checkOutDatePicker.Location = new System.Drawing.Point(130, 90);
            this.checkOutDatePicker.Name = "checkOutDatePicker";
            this.checkOutDatePicker.Size = new System.Drawing.Size(200, 20);
            this.checkOutDatePicker.TabIndex = 5;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Location = new System.Drawing.Point(130, 63);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.customerIDTextBox.TabIndex = 6;
            // 
            // dueDateDatePicker
            // 
            this.dueDateDatePicker.Location = new System.Drawing.Point(130, 118);
            this.dueDateDatePicker.Name = "dueDateDatePicker";
            this.dueDateDatePicker.Size = new System.Drawing.Size(200, 20);
            this.dueDateDatePicker.TabIndex = 7;
            // 
            // checkOutButton
            // 
            this.checkOutButton.Location = new System.Drawing.Point(100, 172);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(52, 48);
            this.checkOutButton.TabIndex = 8;
            this.checkOutButton.Text = "CheckOut";
            this.checkOutButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(234, 172);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(52, 48);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // checkOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 272);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.checkOutButton);
            this.Controls.Add(this.dueDateDatePicker);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(this.checkOutDatePicker);
            this.Controls.Add(this.bookIDTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "checkOut";
            this.Text = "Check Out";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bookIDTextBox;
        private System.Windows.Forms.DateTimePicker checkOutDatePicker;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.DateTimePicker dueDateDatePicker;
        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.Button cancelButton;
    }
}