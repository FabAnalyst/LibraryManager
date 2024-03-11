using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManager
{
    public partial class Signin : Form
    {
        String admin = "admin";
        String password = "password";
        public Signin()
        {
            InitializeComponent();
            // The password character is an asterisk.
            passwordTextBox.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            passwordTextBox.MaxLength = 14;
        }

        private void employeeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (employeeCheckBox.Checked)
            {
                customerCheckBox.Checked = false;
            }
        }

        private void customerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (customerCheckBox.Checked)
            {
                employeeCheckBox.Checked = false;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (employeeCheckBox.Checked)
            {
                if (usernameTextBox.Text == admin && passwordTextBox.Text == password)
                {
                    this.Hide();
                    Employee.eHome eHome = new Employee.eHome();
                    eHome.Closed += (s, args) => this.Close();
                    eHome.Show();
                }
            }
        }
    }
}
