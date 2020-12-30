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
        public int c;
        public int d;
        public Accounts()
        {
            InitializeComponent();
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

                
                CS.taka = (int)reader["Price"];
                
                list.Add(CS);
            }
            dataGridView1.DataSource = list;
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
    }
}
