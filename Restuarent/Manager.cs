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
    public partial class Manager : Form
    {
        int Id;

        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            AddEmployee AE = new AddEmployee();
            AE.Show();
            this.Hide();
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            

        }



        private void groupBox1_Enter(object sender, EventArgs e)
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
                list.Add(CS);
            }
            dataGridView1.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accounts ac = new Accounts();
            ac.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddEmployee ae = new AddEmployee();
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

        private void button4_Click(object sender, EventArgs e)
        {
            CheckAttendance ca = new CheckAttendance();
            ca.Show();
            this.Hide();
        }
    }
}
