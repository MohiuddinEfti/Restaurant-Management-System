using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restuarent
{
    public partial class Chef : Form
    {
        public Chef()
        {
            InitializeComponent();
        }

        private void Chef_Load(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM CustomerOrders";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<CustomerOrders> list = new List<CustomerOrders>();
            while (reader.Read())
            {
                CustomerOrders CS = new CustomerOrders();

                CS.Id = (int)reader["Id"];
                CS.CustomerName= reader["CustomerName"].ToString();
                CS.TableNo = (int)reader["Id"];               
                CS.AddOn = reader["AddOn"].ToString();
                CS.Burger = reader["Burger"].ToString();
                CS.RiceBowl = reader["RiceBowl"].ToString();
                CS.Pizza = reader["Pizza"].ToString();
                CS.Sawrma = reader["Sawrma"].ToString();
                CS.Dumplings = reader["Dumplings"].ToString();
                CS.Pastry = reader["Pastry"].ToString();
                CS.Coke = reader["Coke"].ToString();
                CS.Water = reader["Water"].ToString();
                CS.Price = reader["Price"].ToString();
                CS.OrderTime = reader["OrderTime"].ToString();
                CS.ChefOrderDone = reader["ChefOrderDoneTime"].ToString();
                CS.CustomerRecievedTime = reader["CustomerRecieved"].ToString();
                 

              


                list.Add(CS);
            }
            dataGridView1.DataSource = list;
        }

        private void Chef_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
