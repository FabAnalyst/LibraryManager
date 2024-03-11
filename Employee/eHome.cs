using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager.Employee
{
    public partial class eHome : Form
    {
        public eHome()
        {
            InitializeComponent();
        }


        private void nextButton_Click(object sender, EventArgs e)
        {
            switch (whatToDo.SelectedItem.ToString())
            {
                case "Check-in":
                    checkIn checkIn = new checkIn();
                    checkIn.Show();
                    break;
                case "Check-out":
                    checkOut checkOut = new checkOut();
                    checkOut.Show(); break;
                case "Incident Report":
                    incidentReport incidentReport = new incidentReport();
                    incidentReport.Show(); break;
                case "Manage Inventory":
                    manageInventory manageInventory = new manageInventory();    
                    manageInventory.Show(); break;  
            }
        }
    }
}
