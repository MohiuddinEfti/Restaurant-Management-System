﻿using System;
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
        public int Id;
        public string Positions;
        public string names;

        public string real1;
        public string real2;
        public string real3;
        public string real4;
        public string real5;
        public string real6;
        public string real7;
        public string real8;

        public string name1;
        public string name2;
        public string name3;
        public string name4;
        public string name5;
        public string name6;
        public string name7;
        public string name8;
        public Manager(string a,string b)
        {
            InitializeComponent();
            Positions = b;
            names = a;
        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
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
                CS.TableNo = (int)reader["TableNo"];
                
                CS.Price = reader["Price"].ToString();
                CS.OrderTime = reader["OrderTime"].ToString();
                CS.ChefOrderDone = reader["ChefOrderDoneTime"].ToString();
                CS.CustomerRecievedTime = reader["CustomerRecieved"].ToString();
                CS.Date = reader["Date"].ToString();
                CS.Payment = reader["Payment"].ToString();

                list.Add(CS);
            }

            dataGridView1.DataSource = list;


            SqlConnection connections = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connections.Open();
            string sqls = "SELECT * FROM Food Where Id=1";
            SqlCommand commands = new SqlCommand(sqls, connections);
            SqlDataReader readers = commands.ExecuteReader();

            while (readers.Read())
            {



                name1 = readers["FoodName"].ToString();




            }
            connections.Close();
            if (real1 != name1)
            {
                this.dataGridView1.Columns[4].HeaderText = name1;


            }

            SqlConnection connection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection2.Open();
            string sq2 = "SELECT * FROM Food Where Id=2";
            SqlCommand command2 = new SqlCommand(sq2, connection2);
            SqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {


                name2 = reader2["FoodName"].ToString();




            }
            connection2.Close();
            if (real2 != name2)
            {
                this.dataGridView1.Columns[5].HeaderText = name2;


            }

            SqlConnection connection3 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection3.Open();
            string sq3 = "SELECT * FROM Food Where Id=3";
            SqlCommand command3 = new SqlCommand(sq3, connection3);
            SqlDataReader reader3 = command3.ExecuteReader();

            while (reader3.Read())
            {


                name3 = reader3["FoodName"].ToString();




            }
            connection3.Close();
            if (real3 != name3)
            {
                this.dataGridView1.Columns[6].HeaderText = name3;

            }



            SqlConnection connection4 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection4.Open();
            string sq4 = "SELECT * FROM Food Where Id=4";
            SqlCommand command4 = new SqlCommand(sq4, connection4);
            SqlDataReader reader4 = command4.ExecuteReader();

            while (reader4.Read())
            {


                name4 = reader4["FoodName"].ToString();



            }
            connection4.Close();

            if (real4 != name4)
            {
                this.dataGridView1.Columns[7].HeaderText = name4;

            }


            SqlConnection connection5 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection5.Open();
            string sq5 = "SELECT * FROM Food Where Id=5";
            SqlCommand command5 = new SqlCommand(sq5, connection5);
            SqlDataReader reader5 = command5.ExecuteReader();

            while (reader5.Read())
            {


                name5 = reader5["FoodName"].ToString();




            }
            connection5.Close();

            if (real5 != name5)
            {
                this.dataGridView1.Columns[8].HeaderText = name5;


            }



            SqlConnection connection6 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection6.Open();
            string sq6 = "SELECT * FROM Food Where Id=6";
            SqlCommand command6 = new SqlCommand(sq6, connection6);
            SqlDataReader reader6 = command6.ExecuteReader();

            while (reader6.Read())
            {


                name6 = reader6["FoodName"].ToString();




            }
            connection6.Close();
            if (real6 != name6)
            {
                this.dataGridView1.Columns[9].HeaderText = name6;

            }

            SqlConnection connection7 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection7.Open();
            string sq7 = "SELECT * FROM Food Where Id=7";
            SqlCommand command7 = new SqlCommand(sq7, connection7);
            SqlDataReader reader7 = command7.ExecuteReader();

            while (reader7.Read())
            {


                name7 = reader7["FoodName"].ToString();




            }
            connection7.Close();
            if (real7 != name7)
            {
                this.dataGridView1.Columns[10].HeaderText = name7;

            }

            SqlConnection connection8 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection8.Open();
            string sq8 = "SELECT * FROM Food Where Id=8";
            SqlCommand command8 = new SqlCommand(sq8, connection8);
            SqlDataReader reader8 = command8.ExecuteReader();

            while (reader8.Read())
            {


                name8 = reader8["FoodName"].ToString();




            }
            connection8.Close();
            if (real8 != name8)
            {
                this.dataGridView1.Columns[11].HeaderText = name8;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                Accounts ac = new Accounts(names, Positions);
                ac.Show();
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
                timer1.Enabled = false;
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
                CheckAttendance ca = new CheckAttendance(names, Positions);
                ca.Show();
                this.Hide();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                Stock S = new Stock(names, Positions);
                S.Show();
                this.Hide();
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
            connection.Open();
            string sq1 = "SELECT * FROM CustomerOrders WHERE CustomerName LIKE '" + textBox1.Text + "%'  ";

            SqlCommand command = new SqlCommand(sq1, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<CustomerOrders> list = new List<CustomerOrders>();
            while (reader.Read())
            {
                CustomerOrders CS = new CustomerOrders();

                CS.Id = (int)reader["Id"];
                CS.CustomerName = reader["CustomerName"].ToString();
                CS.TableNo = (int)reader["TableNo"];
                
                CS.Price = reader["Price"].ToString();
                CS.OrderTime = reader["OrderTime"].ToString();
                CS.ChefOrderDone = reader["ChefOrderDoneTime"].ToString();
                CS.CustomerRecievedTime = reader["CustomerRecieved"].ToString();
                CS.Date = reader["Date"].ToString();
                CS.Payment = reader["Payment"].ToString();


                list.Add(CS);
            }
            dataGridView1.DataSource = list;

            connection.Close();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
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
                    CS.TableNo = (int)reader["TableNo"];
                    
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
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Live Order Viewer Is Off");
            timer1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Live Order Viewer Is On");
            timer1.Enabled = true;

        }
    }
}
