using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager.Employee
{
    public partial class checkIn : Form
    {
        public checkIn()
        {
            InitializeComponent();
        }

        public void DbConnect()
        {
            String connectionString;
            SqlConnection cnn;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\FABI54148\\OneDrive - lhcgroup.com\\Documents\\Library.mdf\";Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            MessageBox.Show("Connection Open !");
            cnn.Close();
        }
        private void checkInButton_Click(object sender, EventArgs e)
        {

            string bookID = bookIDTextBox.Text;
            string dateCheckedIn = checkInDate.Text;
            string customerID = customerIDTextBox.Text;
            string dueDate = dueDateTime.Text;
            string fee = feeTextBox.Text;
            
            int.Parse(bookID);
            int.Parse(customerID);
            Convert.ToDateTime(dateCheckedIn);
            Convert.ToDateTime(dueDate);


            String connectionString;
            SqlConnection cnn;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\FABI54148\\OneDrive - lhcgroup.com\\Documents\\Library.mdf\";Integrated Security=True;Connect Timeout=30";

            string query = "INSERT INTO dbo.CheckIn(checkInDate) VALUES(@checkInDate); ";
            


            
        }
    }
}
