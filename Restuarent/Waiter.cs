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
    public partial class Waiter : Form
    {
       public int Id;
        public string abd;
        public Waiter(string a)
        {
            InitializeComponent();
            abd = a;
        }

        private void button1_Click(object sender, EventArgs e)
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
        public string check;
        
        private void Waiter_Load(object sender, EventArgs e)
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

        private void Waiter_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM CustomerOrders WHERE Id=" + Id;
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                

                check = reader["ChefOrderDoneTime"].ToString();


            }
            connection.Close();
            if (check=="")
            {
                MessageBox.Show("Waiter is still making food wait...");
            }
            else
            {
                DateTime time = DateTime.Now;
                string ab = time.ToString("h:mm tt ");
                string ba = "Served by " + abd;
                SqlConnection connections = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
                connections.Open();
                string sqls = "UPDATE CustomerOrders SET CustomerRecieved='" + ab + ba + "'WHERE Id=" + Id;


                SqlCommand commands = new SqlCommand(sqls, connections);


                int diary = commands.ExecuteNonQuery();


                if (diary > 0)
                {
                    MessageBox.Show("Order is Succefully Done");
                    string sq2 = "SELECT * FROM CustomerOrders";
                    SqlCommand commandss = new SqlCommand(sq2, connections);
                    SqlDataReader readers = commandss.ExecuteReader();
                    List<CustomerOrders> list = new List<CustomerOrders>();
                    while (readers.Read())
                    {
                        CustomerOrders CS = new CustomerOrders();

                        CS.Id = (int)readers["Id"];
                        CS.CustomerName = readers["CustomerName"].ToString();
                        CS.TableNo = (int)readers["Id"];
                        CS.AddOn = readers["AddOn"].ToString();
                        CS.Burger = readers["Burger"].ToString();
                        CS.RiceBowl = readers["RiceBowl"].ToString();
                        CS.Pizza = readers["Pizza"].ToString();
                        CS.Sawrma = readers["Sawrma"].ToString();
                        CS.Dumplings = readers["Dumplings"].ToString();
                        CS.Pastry = readers["Pastry"].ToString();
                        CS.Coke = readers["Coke"].ToString();
                        CS.Water = readers["Water"].ToString();
                        CS.Price = readers["Price"].ToString();
                        CS.OrderTime = readers["OrderTime"].ToString();
                        CS.ChefOrderDone = readers["ChefOrderDoneTime"].ToString();
                        CS.CustomerRecievedTime = readers["CustomerRecieved"].ToString();
                        CS.Payment = readers["Payment"].ToString();

                        list.Add(CS);
                    }
                    dataGridView1.DataSource = list;
                }
            }
            
        }
        public string checks;
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM CustomerOrders WHERE Id=" + Id;
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {


                checks = reader["CustomerRecieved"].ToString();


            }
            connection.Close();
            if (checks == "")
            {
                MessageBox.Show("First You Need To Serve The Food...");
            }
            else
            {
                SqlConnection connections = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
                connections.Open();
                string sqls = "UPDATE CustomerOrders SET Payment='" + comboBox1.Text + "'WHERE Id=" + Id;


                SqlCommand commands = new SqlCommand(sqls, connections);


                int diary = commands.ExecuteNonQuery();


                if (diary > 0)
                {
                    MessageBox.Show("Order is Succefully Done");
                    string sq2 = "SELECT * FROM CustomerOrders";
                    SqlCommand commandss = new SqlCommand(sq2, connections);
                    SqlDataReader readers = commandss.ExecuteReader();
                    List<CustomerOrders> list = new List<CustomerOrders>();
                    while (readers.Read())
                    {
                        CustomerOrders CS = new CustomerOrders();

                        CS.Id = (int)readers["Id"];
                        CS.CustomerName = readers["CustomerName"].ToString();
                        CS.TableNo = (int)readers["Id"];
                        CS.AddOn = readers["AddOn"].ToString();
                        CS.Burger = readers["Burger"].ToString();
                        CS.RiceBowl = readers["RiceBowl"].ToString();
                        CS.Pizza = readers["Pizza"].ToString();
                        CS.Sawrma = readers["Sawrma"].ToString();
                        CS.Dumplings = readers["Dumplings"].ToString();
                        CS.Pastry = readers["Pastry"].ToString();
                        CS.Coke = readers["Coke"].ToString();
                        CS.Water = readers["Water"].ToString();
                        CS.Price = readers["Price"].ToString();
                        CS.OrderTime = readers["OrderTime"].ToString();
                        CS.ChefOrderDone = readers["ChefOrderDoneTime"].ToString();
                        CS.CustomerRecievedTime = readers["CustomerRecieved"].ToString();
                        CS.Payment = readers["Payment"].ToString();

                        list.Add(CS);
                    }
                    dataGridView1.DataSource = list;
                }
            }
        }
    }
}
