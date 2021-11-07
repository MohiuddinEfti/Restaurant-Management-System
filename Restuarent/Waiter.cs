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
                timer1.Enabled = false;
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
            string rr = "Ready";
            string Done = "Done";
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM CustomerOrders WHERE CustomerRecieved IS NULL AND ChefOrderDone='" + Done + "' OR CustomerRecieved='" + rr + "' AND ChefOrderDone='" + Done + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<WaiterChek> list = new List<WaiterChek>();
            while (reader.Read())
            {


                WaiterChek CS = new WaiterChek();

                CS.Id = (int)reader["Id"];
                CS.CustomerName = reader["CustomerName"].ToString();
                CS.TableNo = (int)reader["TableNo"];
                
                CS.Order = reader["TotalOrder"].ToString();
                CS.OrderTime = reader["OrderTime"].ToString();
                CS.CustomerRecieved = reader["CustomerRecieved"].ToString();
                CS.Price = reader["Price"].ToString();
                CS.Payment = reader["Payment"].ToString();
                CS.Reference = reader["Reference"].ToString();

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
            if (e.RowIndex == -1) return;
            rec= (string)dataGridView1.Rows[e.RowIndex].Cells[5].Value;
            Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;

            richTextBox1.Text = String.Empty;
            richTextBox1.Text = "Table No: "+ (int)dataGridView1.Rows[e.RowIndex].Cells[2].Value+"\n"+"Customer Name: "+ (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value +"\n\n" +(string)dataGridView1.Rows[e.RowIndex].Cells[3].Value;

        }
        public string rec;
        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="")
            {
                MessageBox.Show("Please Select The Payment Type");
            }
            else if(rec!="Ready")
            {
                MessageBox.Show("First make your item ready");
            }
            else
            {
                DateTime time = DateTime.Now;
                string ab = time.ToString("h:mm tt ");
                string ba = "Served by " + abd;
                string Ready = "Served";
                SqlConnection connections = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
                connections.Open();
                string sqls = "UPDATE CustomerOrders SET Payment='" + comboBox1.Text + "',CustomerRecieved='" + Ready+"', WaiterOrderDoneTime='" + ab + ba + "'WHERE Id=" + Id;


                SqlCommand commands = new SqlCommand(sqls, connections);


                int diary = commands.ExecuteNonQuery();


                if (diary > 0)
                {
                    string R = "Ready";
                    string Done = "Done";
                    comboBox1.Text = String.Empty;
                    MessageBox.Show("Order is Succefully Done");
                    richTextBox1.Text = String.Empty;
                    string sq2 = "SELECT * FROM CustomerOrders WHERE CustomerRecieved IS NULL AND ChefOrderDone='" + Done + "' OR CustomerRecieved='" + R + "' AND ChefOrderDone='" + Done + "'";
                    SqlCommand commandss = new SqlCommand(sq2, connections);
                    SqlDataReader readers = commandss.ExecuteReader();
                    List<WaiterChek> list = new List<WaiterChek>();
                    while (readers.Read())
                    {
                        

                        WaiterChek CS = new WaiterChek();

                        CS.Id = (int)readers["Id"];
                        CS.CustomerName = readers["CustomerName"].ToString();
                        CS.TableNo = (int)readers["TableNo"];
                        
                        CS.Order = readers["TotalOrder"].ToString();
                        CS.OrderTime = readers["OrderTime"].ToString();
                        CS.CustomerRecieved = readers["CustomerRecieved"].ToString();
                        CS.Price = readers["Price"].ToString();
                        CS.Payment = readers["Payment"].ToString();
                        CS.Reference = readers["Reference"].ToString();

                        list.Add(CS);

                    }
                    dataGridView1.DataSource = list;
                }
            }
            
        }
        public string checks;
        

        private void button2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(button3.Text=="Live")
            {
                MessageBox.Show("Live Order Viewer Is On");
                button3.Text = "Stop Live";
                button3.BackColor = Color.Red;
                timer1.Enabled = true;
            }
            else if(button3.Text == "Stop Live")
            {
                MessageBox.Show("Live Order Viewer Is Off");
                button3.Text = "Live";
                button3.BackColor = Color.LightGreen;
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string Ready = "Ready";
            string Done = "Done";
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM CustomerOrders WHERE CustomerRecieved IS NULL AND ChefOrderDone='" + Done + "' OR CustomerRecieved='" + Ready+ "' AND ChefOrderDone='" + Done + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<WaiterChek> list = new List<WaiterChek>();
            while (reader.Read())
            {


                WaiterChek CS = new WaiterChek();

                CS.Id = (int)reader["Id"];
                CS.CustomerName = reader["CustomerName"].ToString();
                CS.TableNo = (int)reader["TableNo"];
               
                CS.Order = reader["TotalOrder"].ToString();
                CS.OrderTime = reader["OrderTime"].ToString();
                CS.CustomerRecieved = reader["CustomerRecieved"].ToString();
                CS.Price = reader["Price"].ToString();
                CS.Payment = reader["Payment"].ToString();
                CS.Reference = reader["Reference"].ToString();

                list.Add(CS);
            }
            dataGridView1.DataSource = list;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Ready = "Ready";
            SqlConnection connections = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
            connections.Open();
            string sqls = "UPDATE CustomerOrders SET CustomerRecieved='" + Ready + "'WHERE Id=" + Id;


            SqlCommand commands = new SqlCommand(sqls, connections);


            int diary = commands.ExecuteNonQuery();


            if (diary > 0)
            {
                string rr = "Ready";
                comboBox1.Text = String.Empty;
                MessageBox.Show("Order is Succefully Done");
                richTextBox1.Text = String.Empty;
                string sq2 = "SELECT * FROM CustomerOrders WHERE CustomerRecieved='"+rr+"' AND ChefOrderDoneTime IS NOT NULL";
                SqlCommand commandss = new SqlCommand(sq2, connections);
                SqlDataReader readers = commandss.ExecuteReader();
                List<WaiterChek> list = new List<WaiterChek>();
                while (readers.Read())
                {


                    WaiterChek CS = new WaiterChek();

                    CS.Id = (int)readers["Id"];
                    CS.CustomerName = readers["CustomerName"].ToString();
                    CS.TableNo = (int)readers["TableNo"];
                   
                    CS.Order = readers["TotalOrder"].ToString();
                    CS.OrderTime = readers["OrderTime"].ToString();
                    CS.CustomerRecieved = readers["CustomerRecieved"].ToString();
                    CS.Price = readers["Price"].ToString();
                    CS.Payment = readers["Payment"].ToString();
                    CS.Reference = readers["Reference"].ToString();

                    list.Add(CS);

                }
                dataGridView1.DataSource = list;
            }
        }
    }
}
