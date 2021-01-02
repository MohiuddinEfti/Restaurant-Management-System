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
        public int Id;
        public string abc;
        public string Position;

        public Chef(string a,string b)
        {
            InitializeComponent();
            abc = a;
            Position = b;
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
                CS.CustomerName = reader["CustomerName"].ToString();
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
                CS.Payment = reader["Payment"].ToString();

                list.Add(CS);
            }
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
          
        }

        private void FoodReadyButton_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string abcd="by "+abc;
            string ab = time.ToString("h:mm tt"+" Done ");
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
            connection.Open();
            string sql = "UPDATE CustomerOrders SET ChefOrderDoneTime='" + ab+abcd + "'WHERE Id=" + Id;
           
           
            SqlCommand command = new SqlCommand(sql, connection);
            

            int diary = command.ExecuteNonQuery();
            

            if (diary > 0)
            {
                MessageBox.Show("Order is Succefully Done");
                string sq2 = "SELECT * FROM CustomerOrders";
                SqlCommand commands = new SqlCommand(sq2, connection);
                SqlDataReader reader = commands.ExecuteReader();
                List<CustomerOrders> list = new List<CustomerOrders>();
                while (reader.Read())
                {
                    CustomerOrders CS = new CustomerOrders();

                    CS.Id = (int)reader["Id"];
                    CS.CustomerName = reader["CustomerName"].ToString();
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
                    CS.Payment = reader["Payment"].ToString();

                    list.Add(CS);
                }
                dataGridView1.DataSource = list;

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Chef_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       

        private void Logoutbutton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure", "Log Out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                LogIn lg = new LogIn();
                lg.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stock S = new Stock(Position,abc);
            S.Show();
            this.Hide();
        }
    }
}
