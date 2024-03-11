namespace LibraryManager.Employee
{
    partial class eHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eHome));
            this.whatToDo = new System.Windows.Forms.ListBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // whatToDo
            // 
            this.whatToDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.whatToDo.FormattingEnabled = true;
            this.whatToDo.Items.AddRange(new object[] {
            "Check-in",
            "Check-out",
            "Incident Report",
            "Manage Inventory"});
            this.whatToDo.Location = new System.Drawing.Point(12, 12);
            this.whatToDo.Name = "whatToDo";
            this.whatToDo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.whatToDo.Size = new System.Drawing.Size(247, 67);
            this.whatToDo.TabIndex = 0;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(86, 128);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(107, 49);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // eHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 248);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.whatToDo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "eHome";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox whatToDo;
        private System.Windows.Forms.Button nextButton;
    }
}