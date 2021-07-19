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
    public partial class Place_Order : Form
    {
        SqlConnection con;
        public Place_Order()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=False");
        }

        private void Place_Order_Load(object sender, EventArgs e)
        {
            {
                string query = "SELECT * FROM menudata";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmd;
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        Order_Order.DataSource = dt;
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                string Query = "select sum(total) as labe1 from menudata;";
                SqlCommand Cmd = new SqlCommand(Query, con);
                try
                {

                    con.Open();
                    Cmd.ExecuteNonQuery();
                    DataTable td = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = Cmd;
                    sda.Fill(td);
                    if (td.Rows.Count > 0)
                    {
                        string result = Cmd.ExecuteScalar().ToString();
                        label1.Text = result;
                    }
                    else if (td.Rows.Count == 0)
                    {
                        MessageBox.Show("No data found", "No Data");
                    }
                    con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Error");
                }
            }
            //try
            //{
            //    Int32 total = 0, Tot = 0, To=0;
            //    {
            //        string query = "SELECT Price FROM menudata";
            //        SqlCommand cmd = new SqlCommand(query, con);
            //        con.Open();
            //        cmd.ExecuteNonQuery();
            //        DataTable dt = new DataTable();
            //        SqlDataAdapter sda = new SqlDataAdapter();
            //        sda.SelectCommand = cmd;
            //        sda.Fill(dt);
            //        if (dt.Rows.Count > 0)
            //        {
            //            total = (Int32)cmd.ExecuteScalar();
            //        }
            //        con.Close();


            //        string quer = "SELECT Qty FROM menudata";
            //        SqlCommand cm = new SqlCommand(quer, con);
            //        con.Open();
            //        cm.ExecuteNonQuery();
            //        DataTable t = new DataTable();
            //        SqlDataAdapter sd = new SqlDataAdapter();
            //        sd.SelectCommand = cm;
            //        sd.Fill(t);
            //        if (t.Rows.Count > 0)
            //        {
            //            Tot = (Int32)cm.ExecuteScalar();
            //        }
            //        con.Close();
            //        To = Tot * total;
            //        string que = "INSERT into menudata (Total) values '" + To + "'";
            //        SqlCommand cmm = new SqlCommand(que, con);
            //        con.Open();
            //        cmm.ExecuteNonQuery();
            //        DataTable mt = new DataTable();
            //        SqlDataAdapter smd = new SqlDataAdapter();
            //        smd.SelectCommand = cmm;
            //        smd.Fill(mt);
            //        if (mt.Rows.Count > 0)
            //        {

            //        }
            //        con.Close();
            //    }
            //}
            //catch (Exception Ex)
            //{
            //    MessageBox.Show(Ex.Message, "Error");
            //}


        }
            private void Place_Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try {
                string query = "insert into customer_data (TotalAmount) select Total from menudata";
                SqlCommand cmd = new SqlCommand(query, con);
       
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                MessageBox.Show("Your order has been placed successfully", "Success");
                Application.Exit();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
