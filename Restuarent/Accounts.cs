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
    public partial class Accounts : Form
    {
        public int id1;
        public int c;
        public int d;
        public Accounts()
        {
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Today;
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM CustomerOrders";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<AccountsCash> list = new List<AccountsCash>();
            while (reader.Read())
            {
                AccountsCash CS = new AccountsCash();

                
                CS.Cash = (int)reader["Price"];
                CS.Date = reader["Date"].ToString();

                list.Add(CS);
            }
            dataGridView1.DataSource = list;
            connection.Close();

            SqlConnection connection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Accounts"].ConnectionString);
            connection2.Open();
            string sq2 = "SELECT * FROM Accounts";
            SqlCommand command2 = new SqlCommand(sq2, connection2);
            SqlDataReader reader2 = command2.ExecuteReader();
            List<DailyIncome> list2 = new List<DailyIncome>();
            while (reader2.Read())
            {
                DailyIncome CS = new DailyIncome();

                CS.Id = (int)reader2["ID"];
                CS.TotalCash = (int)reader2["TotalCash"];
                CS.Date = reader2["Date"].ToString();
                CS.Time = reader2["Time"].ToString();
                CS.UpdatedTime = reader2["UpdatedTime"].ToString();

                list2.Add(CS);
            }
            dataGridView2.DataSource = list2;

        }

       
        
       

        private void Accounts_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int a = 1;


            string b = textBox1.Text;
            textBox1.Text = b + a;

            if (textBox2.Text == "+")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "-")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "*")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "/")
            {
                d = Int32.Parse(textBox1.Text);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a = 2;
            string b = textBox1.Text;
            textBox1.Text = b + a;

            if (textBox2.Text == "+")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "-")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "*")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "/")
            {
                d = Int32.Parse(textBox1.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int a = 3;
            string b = textBox1.Text;
            textBox1.Text = b + a;

            if (textBox2.Text == "+")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "-")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "*")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "/")
            {
                d = Int32.Parse(textBox1.Text);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int a = 4;
            string b = textBox1.Text;
            textBox1.Text = b + a;

            if (textBox2.Text == "+")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "-")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "*")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "/")
            {
                d = Int32.Parse(textBox1.Text);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int a = 5;
            string b = textBox1.Text;
            textBox1.Text = b + a;

            if (textBox2.Text == "+")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "-")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "*")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "/")
            {
                d = Int32.Parse(textBox1.Text);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int a = 6;
            string b = textBox1.Text;
            textBox1.Text = b + a;

            if (textBox2.Text == "+")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "-")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "*")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "/")
            {
                d = Int32.Parse(textBox1.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int d;
            int a = 7;
            string b = textBox1.Text;
            textBox1.Text = b + a;

            if (textBox2.Text == "+")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "-")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "*")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "/")
            {
                d = Int32.Parse(textBox1.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = 8;
            string b = textBox1.Text;
            textBox1.Text = b + a;

            if (textBox2.Text == "+")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "-")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "*")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "/")
            {
                d = Int32.Parse(textBox1.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = 9;
            string b = textBox1.Text;
            textBox1.Text = b + a;

            if (textBox2.Text == "+")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "-")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "*")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "/")
            {
                d = Int32.Parse(textBox1.Text);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = string.Empty;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("ERROR no value was inserted");
            }
            else
            {
                c = Int32.Parse(textBox1.Text);
                textBox2.Text = "/";
                textBox1.Text = string.Empty;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("ERROR no value was inserted");
            }
            else
            {
                c = Int32.Parse(textBox1.Text);
                textBox2.Text = "*";
                textBox1.Text = string.Empty;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("ERROR no value was inserted");
            }
            else
            {
                c = Int32.Parse(textBox1.Text);
                textBox2.Text = "-";
                textBox1.Text = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("ERROR no value was inserted");
            }
            else
            {
                c = Int32.Parse(textBox1.Text);
                textBox2.Text = "+";
                textBox1.Text = string.Empty;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "+")
            {
                int p = c + d;
                textBox1.Text = p.ToString();
            }
            else if (textBox2.Text == "-")
            {
                int p = c - d;
                textBox1.Text = p.ToString();
            }
            else if (textBox2.Text == "*")
            {
                int p = c * d;
                textBox1.Text = p.ToString();
            }
            else if (textBox2.Text == "/")
            {
                int p = c / d;
                textBox1.Text = p.ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {

            int a = 0;
            string b = textBox1.Text;
            textBox1.Text = b + a;

            if (textBox2.Text == "+")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "-")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "*")
            {
                d = Int32.Parse(textBox1.Text);
            }
            else if (textBox2.Text == "/")
            {
                d = Int32.Parse(textBox1.Text);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                textBox3.Text = textBox1.Text;
            }
            else
            {
                MessageBox.Show("There is no ammount to add");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if(textBox3.Text=="")
            {
                MessageBox.Show("Nothing To Insert");
            }
            else
            {
                string Today = dateTimePicker1.Text;
                DateTime time = DateTime.Now;
                string ab = time.ToString("h:mm:ss tt");
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Accounts"].ConnectionString);
                connection.Open();
                string sq1 = "INSERT INTO Accounts(TotalCash,Date,Time) VALUES('" + Int32.Parse(textBox3.Text) + "','" + Today + "','" + ab + "')";

                SqlCommand command = new SqlCommand(sq1, connection);
                int diary = command.ExecuteNonQuery();

                if (diary > 0)
                {
                    MessageBox.Show("Inserted");

                    dateTimePicker1.Text = textBox3.Text = string.Empty;
                    string sq2 = "SELECT * FROM Accounts";
                    SqlCommand command2 = new SqlCommand(sq2, connection);
                    SqlDataReader reader2 = command2.ExecuteReader();
                    List<DailyIncome> list2 = new List<DailyIncome>();
                    while (reader2.Read())
                    {
                        DailyIncome CS = new DailyIncome();

                        CS.Id = (int)reader2["ID"];
                        CS.TotalCash = (int)reader2["TotalCash"];
                        CS.Date = reader2["Date"].ToString();
                        CS.Time = reader2["Time"].ToString();
                        CS.UpdatedTime = reader2["UpdatedTime"].ToString();

                        list2.Add(CS);
                    }
                    dataGridView2.DataSource = list2;
                    textBox3.Text = dateTimePicker1.Text = string.Empty;


                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string ab = time.ToString("h:mm tt ");
            
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Accounts"].ConnectionString);
            connection.Open();
            string sql = "UPDATE Accounts SET TotalCash='" + textBox3.Text+ "'WHERE Id=" + id1;
            string sq4 = "UPDATE Accounts SET Date='" + dateTimePicker1.Text + "'WHERE Id=" + id1;
            string sql3 = "UPDATE Accounts SET UpdatedTime='" + ab + "'WHERE Id=" + id1;
            SqlCommand command = new SqlCommand(sql, connection);
            SqlCommand command1 = new SqlCommand(sq4, connection);
            SqlCommand command4 = new SqlCommand(sql3, connection);
            int diary = command.ExecuteNonQuery();
            int diary1 = command1.ExecuteNonQuery();
            int diary4 = command4.ExecuteNonQuery();
            if (diary > 0)
            {
                MessageBox.Show("Order is Succefully Done");
                string sq2 = "SELECT * FROM Accounts";
                SqlCommand command2 = new SqlCommand(sq2, connection);
                SqlDataReader reader2 = command2.ExecuteReader();
                List<DailyIncome> list2 = new List<DailyIncome>();
                while (reader2.Read())
                {
                    DailyIncome CS = new DailyIncome();

                    CS.Id = (int)reader2["ID"];
                    CS.TotalCash = (int)reader2["TotalCash"];
                    CS.Date = reader2["Date"].ToString();
                    CS.Time = reader2["Time"].ToString();
                    CS.UpdatedTime = reader2["UpdatedTime"].ToString();

                    list2.Add(CS);
                }
                dataGridView2.DataSource = list2;
                textBox3.Text = dateTimePicker1.Text = string.Empty;

            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id1 = (int)dataGridView2.Rows[e.RowIndex].Cells[0].Value;
            int cash = (int)dataGridView2.Rows[e.RowIndex].Cells[1].Value;
            textBox3.Text = cash.ToString();
            dateTimePicker1.Text= (string)dataGridView2.Rows[e.RowIndex].Cells[2].Value;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Accounts"].ConnectionString);
            connection.Open();
            string sql = "DELETE FROM Accounts WHERE Id='" + id1 + "' ";


            SqlCommand command = new SqlCommand(sql, connection);
            int diary = command.ExecuteNonQuery();

            if (diary > 0)
            {
                MessageBox.Show("Deleted");
                string sq2 = "SELECT * FROM Accounts";
                SqlCommand command2 = new SqlCommand(sq2, connection);
                SqlDataReader reader2 = command2.ExecuteReader();
                List<DailyIncome> list2 = new List<DailyIncome>();
                while (reader2.Read())
                {
                    DailyIncome CS = new DailyIncome();

                    CS.Id = (int)reader2["ID"];
                    CS.TotalCash = (int)reader2["TotalCash"];
                    CS.Date = reader2["Date"].ToString();
                    CS.Time = reader2["Time"].ToString();
                    CS.UpdatedTime = reader2["UpdatedTime"].ToString();

                    list2.Add(CS);
                }
                dataGridView2.DataSource = list2;
                textBox3.Text = dateTimePicker1.Text = string.Empty;
        }   }

        private void button21_Click(object sender, EventArgs e)
        {
            Manager mg = new Manager();
            mg.Show();
            this.Hide();
        }
    }
}
