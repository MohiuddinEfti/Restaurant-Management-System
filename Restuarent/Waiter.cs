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
        public int value;
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
            string Today = DateTime.Today.ToString("dddd , MMM dd yyyy");
            string cancel = "Cancel";
            dataGridView3.Visible = false;
            SqlConnection connections = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
            connections.Open();
            string sqls = "SELECT * FROM CustomerOrders Where Date LIKE '" + Today + "%' AND ChefOrderDone !='" + cancel + "' OR Date LIKE '" + Today + "%' AND ChefOrderDone IS NULL";
            SqlCommand commands = new SqlCommand(sqls, connections);
            SqlDataReader readers = commands.ExecuteReader();
            List<AccountsCash> lists = new List<AccountsCash>();
            while (readers.Read())
            {
                AccountsCash CS = new AccountsCash();


                CS.Cash = (int)readers["Price"];
                CS.Date = readers["Date"].ToString();

                lists.Add(CS);
            }
            dataGridView3.DataSource = lists;
            connections.Close();
            





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
            SqlConnection connection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Accounts"].ConnectionString);
            connection2.Open();
            string sq2s = "SELECT * FROM Accounts";
            SqlCommand command2 = new SqlCommand(sq2s, connection2);
            SqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {

                DATA.Add(reader2["Date"].ToString());

            }

            connection2.Close();

        }

        private void Waiter_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public string pp;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            pp= (string)dataGridView1.Rows[e.RowIndex].Cells[6].Value;
            rec = (string)dataGridView1.Rows[e.RowIndex].Cells[5].Value;
            Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;

            richTextBox1.Text = String.Empty;
            richTextBox1.Text = "Table No: "+ (int)dataGridView1.Rows[e.RowIndex].Cells[2].Value+"\n"+"Customer Name: "+ (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value +"\n\n" +(string)dataGridView1.Rows[e.RowIndex].Cells[3].Value;

        }
        public string rec;
        List<string> DATA = new List<string>();
        public bool activ;
        //public string Today = DateTime.Today.ToString("dddd , MMM dd yyyy");
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

                    int a = 0;
                    for (int i = 0; i < dataGridView3.RowCount; i++)
                    {

                        string b = dataGridView3.Rows[i].Cells[0].Value.ToString();


                        value = a = a + Int32.Parse(b);


                    }
                    string Today = DateTime.Today.ToString("dddd , MMM dd yyyy");

                    bool con = DATA.Contains(Today);

                    if (con == true)
                    {

                      
                        DateTime times = DateTime.Now;
                        string abc = times.ToString("h:mm:ss tt");

                        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Accounts"].ConnectionString);
                        connection.Open();
                        string sql = "UPDATE Accounts SET TotalCash='" + value + "',UpdatedTime='" + abc + "' WHERE Date='" + Today + "'";
                        SqlCommand command = new SqlCommand(sql, connection);
                        int diary1 = command.ExecuteNonQuery();
                        if (diary1 > 0)
                        {

                            MessageBox.Show("Order is Succefully false");
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }
                    }
                    else
                    {

                       
                        DateTime times = DateTime.Now;
                        string abc = times.ToString("h:mm:ss tt");
                        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Accounts"].ConnectionString);
                        connection.Open();
                        string sq1 = "INSERT INTO Accounts(TotalCash,Date,Time) VALUES('" + Int32.Parse(pp) + "','" + Today + "','" + abc + "')";

                        SqlCommand command = new SqlCommand(sq1, connection);
                        int diary1 = command.ExecuteNonQuery();
                        if (diary1 > 0)
                        {
                            DATA.Clear();
                            MessageBox.Show("Order is Succefully true");
                            SqlConnection connection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Accounts"].ConnectionString);
                            connection2.Open();
                            string sq2s = "SELECT * FROM Accounts";
                            SqlCommand command2 = new SqlCommand(sq2s, connection2);
                            SqlDataReader reader2 = command2.ExecuteReader();

                            while (reader2.Read())
                            {

                                DATA.Add(reader2["Date"].ToString());

                            }

                            connection2.Close();
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }
                    }


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
