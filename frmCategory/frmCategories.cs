using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guest;
namespace frmCategory
{
    public partial class frmCategories : Form
    {
        Guest.frmGuest 
        string connectionString = "data source=MSI\\SQLEXPRESS; initial catalog=EventGuests;Integrated Security=SSPI;";
        public SqlConnection connection;
        public frmCategories()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        public bool Connect()
        {
            bool successfullyConnected = false;
            try
            {
                connection.Open();
                successfullyConnected = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                successfullyConnected = false;

            }

            return successfullyConnected;
        }
    }
}
