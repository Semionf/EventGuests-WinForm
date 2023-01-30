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
       
        string connectionString = "data source=MSI\\SQLEXPRESS; initial catalog=EventGuest;Integrated Security=SSPI;";
        public SqlConnection connection;
        frmGuest parent;
        private int index;
        static List<frmCategories> brothers;
        public frmCategories(frmGuest parent, string guestName, string categoryName, int index)
        {
            InitializeComponent();
            this.parent = parent;
            this.index = index;
            string txt = lblGuestName.Text;
            lblGuestName.Text = guestName;
            lblCategoryName.Text = categoryName;
            connection = new SqlConnection(connectionString);
            showAllGuestsSelections();
            showCurrentGuestSelection();
        }

        
        public List<frmCategories> Brothers { set { brothers = value; } }
        
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (brothers.Count == 0) return;
            if (brothers.Count - 1 <= index)
            {
                brothers[0].Show();
                Visible = false;
                return;
            }
            Visible= false;
            brothers[index+1].Show();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (brothers.Count == 0) return;
            if (index <= 0 )
            {
                brothers[brothers.Count - 1].Show();
                Visible = false;
                return;
            }
            Visible = false;
            brothers[index - 1].Show();
        }
        private void AddFood(string food)
        {
            string insert = "\r\ndeclare @Guest_Code int, @Category_Code int\r\nif exists(select Code from Guests where name = @Guest_Name)\r\nbegin\r\n\tselect @Guest_Code = (select Code from Guests where name = @Guest_Name)\r\nend\r\nelse\r\nbegin \r\n\tinsert into Guests values (@Guest_Name)\r\n\tselect @Guest_Code = @@IDENTITY\r\nend\r\n\r\n\r\nif exists(select Code from Categories where name = @Category_Name)\r\nbegin\r\n\tselect @Category_Code = (select Code from Categories where name = @Category_Name)\r\n\tinsert into Foods values(@Guest_Code, @Category_Code,@Food_Name)\r\nend";
            if (!parent.Connect()) return;
            SqlCommand command = new SqlCommand(insert, parent.connection);
            command.Parameters.AddWithValue("@Guest_Name", lblGuestName.Text);
            command.Parameters.AddWithValue("@Category_Name", lblCategoryName.Text);
            command.Parameters.AddWithValue("@Food_Name", food);
            command.ExecuteNonQuery();
            parent.connection.Close();
            showCurrentGuestSelection();
            showAllGuestsSelections();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            txtFood.Visible = true;
            btnOk.Visible = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtFood.Text == "") return;
            AddFood(txtFood.Text);
            txtFood.Visible = false;
            btnOk.Visible = false;
            txtFood.Text = "";
        }

        //function that shows all guests selection in category
        private void showAllGuestsSelections()
        {
            string select = "\r\nselect Guests.Name as Name, Categories.Name as Category, Foods.Name as Food\r\nfrom Guests inner join Foods on Guests.Code = Foods.Guest_Code inner join\r\nCategories on Categories.Code = Foods.Category_Code\r\nwhere Categories.Name = '" + lblCategoryName.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(select, parent.connectionString);
            //Creating Data table
            DataTable data = new DataTable();
            //fill data into table
            adapter.Fill(data);
            dgvAllFoods.DataSource= data;
        }
        //function that shows the foods that the
        //current guest ordered
        private void showCurrentGuestSelection()
        {
            string select = "\r\nselect Guests.Name as Name, Categories.Name as Category, Foods.Name as Food\r\nfrom Guests inner join Foods on Guests.Code = Foods.Guest_Code inner join\r\nCategories on Categories.Code = Foods.Category_Code\r\nwhere Categories.Name = '" + lblCategoryName.Text + "' and Guests.Name = '" + lblGuestName.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(select, parent.connectionString);
            //Creating Data table
            DataTable data = new DataTable();
            //fill data into table
            adapter.Fill(data);
            dgvCurrentPerson.DataSource = data;
        }

        private void dgvAllFoods_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string selection = dgvAllFoods[2, e.RowIndex].Value.ToString();
            AddFood(selection);
        }
    }
}
