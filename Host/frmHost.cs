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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace EventGuests
{
    public partial class frmHost : Form
    {
        string connectionString = "data source=MSI\\SQLEXPRESS; initial catalog=EventGuest;Integrated Security=SSPI;";
        public SqlConnection connection;
        public frmHost()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            InitList();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if(txtCategory.Text != "")
            CategoryList.Items.Add(txtCategory.Text);
            addCategory(txtCategory.Text);
        }

        private void addCategory(string category)
        {
            if (!Connect()) return;
            string insert = "if not exists(select Name from Categories where Name = @Name)\r\n\r\nbegin\r\n\tINSERT INTO Categories  VALUES (@Name)\r\nend";
            SqlCommand command = new SqlCommand(insert, connection);

            command.Parameters.AddWithValue("@Name", category);

            try
            {
                int number = command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
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
        private void InitList()
        {
            

            if (!Connect()) return;
            string select = "select Name from Categories";
            SqlCommand command = new SqlCommand(select, connection);
            //execute the command into existing table
            SqlDataReader reader = command.ExecuteReader();
            //checks if there are rows in table
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CategoryList.Items.Add(reader[0]);
                }
            }
            connection.Close();
        }
    }
}
