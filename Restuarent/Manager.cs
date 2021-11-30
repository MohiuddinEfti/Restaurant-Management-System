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
                CS.TotalOrder = reader["TotalOrder"].ToString();
                CS.Price = reader["Price"].ToString();
                CS.OrderTime = reader["OrderTime"].ToString();
                CS.ChefOrderDone = reader["ChefOrderDone"].ToString();
                CS.CustomerRecievedTime = reader["CustomerRecieved"].ToString();
                CS.Date = reader["Date"].ToString();
                CS.Payment = reader["Payment"].ToString();

                list.Add(CS);
            }

            dataGridView1.DataSource = list;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {

                if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "" && dataGridView1.Rows[i].Cells[7].Value.ToString() == "")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                if (dataGridView1.Rows[i].Cells[6].Value.ToString() != "" && dataGridView1.Rows[i].Cells[7].Value.ToString() == "")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                if (dataGridView1.Rows[i].Cells[6].Value.ToString() != "" && dataGridView1.Rows[i].Cells[7].Value.ToString() != "")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "Cancel")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkBlue;
                }
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
                CS.TotalOrder = reader["TotalOrder"].ToString();
                CS.Price = reader["Price"].ToString();
                CS.OrderTime = reader["OrderTime"].ToString();
                CS.ChefOrderDone = reader["ChefOrderDone"].ToString();
                CS.CustomerRecievedTime = reader["CustomerRecieved"].ToString();
                CS.Date = reader["Date"].ToString();
                CS.Payment = reader["Payment"].ToString();


                list.Add(CS);
            }
            dataGridView1.DataSource = list;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {

                if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "" && dataGridView1.Rows[i].Cells[7].Value.ToString() == "")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                if (dataGridView1.Rows[i].Cells[6].Value.ToString() != "" && dataGridView1.Rows[i].Cells[7].Value.ToString() == "")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                if (dataGridView1.Rows[i].Cells[6].Value.ToString() != "" && dataGridView1.Rows[i].Cells[7].Value.ToString() != "")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "Cancel")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkBlue;
                }
            }

            connection.Close();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal; 
            icon_restore.Visible = true;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {

                if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "" && dataGridView1.Rows[i].Cells[7].Value.ToString() == "")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                if (dataGridView1.Rows[i].Cells[6].Value.ToString() != "" && dataGridView1.Rows[i].Cells[7].Value.ToString() == "")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                if (dataGridView1.Rows[i].Cells[6].Value.ToString() != "" && dataGridView1.Rows[i].Cells[7].Value.ToString() != "")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "Cancel")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkBlue;
                }
            }
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
                    CS.TotalOrder = reader["TotalOrder"].ToString();
                    CS.Price = reader["Price"].ToString();
                    CS.OrderTime = reader["OrderTime"].ToString();
                    CS.ChefOrderDone = reader["ChefOrderDone"].ToString();
                    CS.CustomerRecievedTime = reader["CustomerRecieved"].ToString();
                    CS.Date = reader["Date"].ToString();
                    CS.Payment = reader["Payment"].ToString();

                    list.Add(CS);
                }

                dataGridView1.DataSource = list;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {

                    if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "" && dataGridView1.Rows[i].Cells[7].Value.ToString() == "")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                    if (dataGridView1.Rows[i].Cells[6].Value.ToString() != "" && dataGridView1.Rows[i].Cells[7].Value.ToString() == "")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    if (dataGridView1.Rows[i].Cells[6].Value.ToString() != "" && dataGridView1.Rows[i].Cells[7].Value.ToString() != "")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "Cancel")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkBlue;
                    }
                }
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

        private void icon_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void icon_restore_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void icon_close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
