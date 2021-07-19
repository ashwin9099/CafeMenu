using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeMenu
{
    public partial class Menu : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=False");
        public Menu()
        {
            InitializeComponent();
        }
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChinese_Click(object sender, EventArgs e)
        {
            uC_Chinese1.Visible = true;
            uC_Chinese1.BringToFront();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            uC_welcome1.Visible = true;
            uC_Chinese1.Visible = false;
            uC_Italian1.Visible = false;
            uC_Southindian1.Visible = false;
            uC_Bevarages1.Visible = false;
           

        }

        private void btnItalian_Click(object sender, EventArgs e)
        {
            uC_Italian1.Visible = true;
            uC_Italian1.BringToFront();

        }

        private void btnSouthindian_Click(object sender, EventArgs e)
        {
            uC_Southindian1.Visible = true;
            uC_Southindian1.BringToFront();
        }

        private void btnBevarages_Click(object sender, EventArgs e)
        {
            uC_Bevarages1.Visible = true;
            uC_Bevarages1.BringToFront();
        }

        public void btnAddtocart_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Place_Order frm = new Place_Order();
            frm.Show();

        }
    }
}
