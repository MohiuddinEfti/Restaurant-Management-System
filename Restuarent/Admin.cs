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
    public partial class Admin : Form
    {
        public int Id;
        public string Positions = "admin";
        public string names="admin";
        public Admin(string a , string b)
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stock S = new Stock(names, Positions);
            S.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckAttendance ca = new CheckAttendance(names, Positions);
            ca.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            AddEmployee ae = new AddEmployee(names, Positions);
            ae.Show();
            this.Hide();
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
            Account ac = new Account();
            ac.Show();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
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
                CS.Date = reader["Date"].ToString();
                CS.Payment = reader["Payment"].ToString();

                list.Add(CS);
            }
            dataGridView1.DataSource = list;
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
