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

namespace CafeMenu.All_User_Controls
{
    public partial class UC_Bevarages : UserControl
    {
        SqlConnection con;
        public UC_Bevarages()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=False");

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
