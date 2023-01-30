using frmCategory;
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
using System.Xml.Linq;

namespace Guest
{
    public partial class frmGuest : Form
    {
        public string connectionString = "data source=MSI\\SQLEXPRESS; initial catalog=EventGuests;Integrated Security=SSPI;";
        public SqlConnection connection;
        
        public frmGuest()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
           
            showAllGuests("");
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if(txtGuestName.Text == "")
            {
                return;
            }
            enterGuest(txtGuestName.Text);
            createFormsByCategories(txtGuestName.Text);
        }

        private void enterGuest(string name)
        {
            if (!Connect()) return;
            string insert = "if not exists(select Name from Guests where Name = @Guest_Name)\r\n\r\nbegin\r\n\tINSERT INTO Guests (Name) VALUES (@Guest_Name)\r\nend";
            SqlCommand command = new SqlCommand(insert, connection);

            command.Parameters.AddWithValue("@Guest_Name", name);

            try
            {
                int number = command.ExecuteNonQuery();
            }
            catch (SqlException ex) {
            MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

        private void showAllGuests(string name)
        {
            //clear from previous names
            listGuests.Items.Clear();

            if (!Connect()) return;
            string select = "select Name from Guests where Name like '%" +name + "%'";
            SqlCommand command = new SqlCommand(select, connection);
            //execute the command into existing table
            SqlDataReader reader = command.ExecuteReader();
            //checks if there are rows in table
            if(reader.HasRows)
            {
                while(reader.Read())
                {
                   listGuests.Items.Add(reader[0].ToString());
                }
            }
            connection.Close();
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

        private void txtGuestName_TextChanged(object sender, EventArgs e)
        {
            showAllGuests(txtGuestName.Text);
        }

        private void txtGuestName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                enterGuest(txtGuestName.Text);
                showAllGuests(txtGuestName.Text);
                txtGuestName.Text = "";
            }
        }

        private void listGuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGuestName.Text = listGuests.Text;
        }

        private void createFormsByCategories(string guestName)
        {
            string select = "select name from Categories";

            if (!Connect()) return;
            SqlCommand command = new SqlCommand(select, connection);
            SqlDataReader reader = command.ExecuteReader();
            //from list
            List<frmCategories> categories = new List<frmCategories>();
            int index = 0;
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    categories.Add(new frmCategories(this,guestName, reader[0].ToString(), index++));
                }
                categories.First().Brothers = categories;
                categories.First().Show();
            }
            connection.Close();
        }
    }
}
