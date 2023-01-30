using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventGuests
{
    public partial class frmHost : Form
    {
        public frmHost()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if(txtCategory.Text != "")
            CategoryList.Items.Add(txtCategory.Text);
        }
    }
}
