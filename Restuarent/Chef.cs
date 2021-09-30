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
        public Chef(string a,string b)
        {
            InitializeComponent();
            abc = a;
            Position = b;
        }

        private void Chef_Load(object sender, EventArgs e)
        {
            
            dataGridView1.ReadOnly = true;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM CustomerOrders WHERE ChefOrderDoneTime IS NULL";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<ChefCheck> list = new List<ChefCheck>();
            while (reader.Read())
            {
                ChefCheck CS = new ChefCheck();

                CS.Id = (int)reader["Id"];
                CS.CustomerName = reader["CustomerName"].ToString();
                CS.TableNo = (int)reader["TableNo"];
                CS.AddOn = reader["AddOn"].ToString();
                CS.Order = reader["TotalOrder"].ToString();
                CS.OrderTime = reader["OrderTime"].ToString();
                CS.ChefOrderDone = reader["ChefOrderDoneTime"].ToString();

                list.Add(CS);
            }

            dataGridView1.DataSource = list;


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            
                richTextBox1.Text = String.Empty;
                richTextBox1.Text= (string)dataGridView1.Rows[e.RowIndex].Cells[4].Value;
            
          
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
                string sq2 = "SELECT * FROM CustomerOrders WHERE ChefOrderDoneTime IS NULL";
                SqlCommand commands = new SqlCommand(sq2, connection);
                SqlDataReader reader = commands.ExecuteReader();
                List<ChefCheck> list = new List<ChefCheck>();
                while (reader.Read())
                {
                    ChefCheck CS = new ChefCheck();

                    CS.Id = (int)reader["Id"];
                    CS.CustomerName = reader["CustomerName"].ToString();
                    CS.TableNo = (int)reader["TableNo"];
                    CS.AddOn = reader["AddOn"].ToString();
                    CS.Order = reader["TotalOrder"].ToString();
                    CS.OrderTime = reader["OrderTime"].ToString();
                    CS.ChefOrderDone = reader["ChefOrderDoneTime"].ToString();
                    

                    list.Add(CS);
                }
                dataGridView1.DataSource = list;
                richTextBox1.Text = String.Empty;

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

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Live Order Viewer Is On");
            timer1.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Live Order Viewer Is Off");
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
                connection.Open();
                string sql = "SELECT * FROM CustomerOrders WHERE ChefOrderDoneTime IS NULL";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                List<ChefCheck> list = new List<ChefCheck>();
                while (reader.Read())
                {
                    ChefCheck CS = new ChefCheck();

                    CS.Id = (int)reader["Id"];
                    CS.CustomerName = reader["CustomerName"].ToString();
                    CS.TableNo = (int)reader["TableNo"];
                    CS.AddOn = reader["AddOn"].ToString();
                    CS.Order = reader["TotalOrder"].ToString();
                    CS.OrderTime = reader["OrderTime"].ToString();
                    CS.ChefOrderDone = reader["ChefOrderDoneTime"].ToString();



                    list.Add(CS);
                }
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = list;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
