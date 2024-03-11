using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager.Classes
{
    internal class ClassTemplate
    {
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
    }
}
