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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        
        public static int f = 0;

        

        private void taka_Click(object sender, EventArgs e)
        {
            
        }
        int amount;
        

        public static int ye = 0;
        

        public static int d = 0;
       
        public static int c = 0;
        

        public static int b = 0;
        

        public static int a = 0;
        
        public static int i = 0;
        
        public static int n = 0;
        

        private void button9_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="") 
            {

                MessageBox.Show("Table number is empty");
            }
            else if(textBox2.Text=="")
            {
                MessageBox.Show("Customer name is empty");
            }
            else if(i==0&&n==0&&a==0&&b==0&&c==0&&d==0&&ye==0&&f==0)
            {
                MessageBox.Show("You did not order anything can't take order");
            }
            else
            {
                
                int tk = i * 150 + n * 200 + a * 500 + b * 120 + c * 100 + d * 70 + ye * 30 + f * 15;
                string Today = DateTime.Today.ToString("dddd , MMM dd yyyy");
                DateTime time = DateTime.Now;
                string ab = time.ToString("h:mm:ss tt ");
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
                connection.Open();
                string sq1 = "INSERT INTO CustomerOrders(CustomerName,TableNo,AddOn,Burger,RiceBowl,Pizza,Sawrma,Dumplings,Pastry,Coke,Water,OrderTime,Price,Date) VALUES('" + textBox2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + i.ToString() + "','" + n.ToString() + "','" + a.ToString() + "','" + b.ToString() + "','" + c.ToString() + "','"+d.ToString()+ "','"+ye.ToString()+ "','"+f.ToString()+ "','"+ab+ "','"+tk+"','"+Today+"')";

                SqlCommand command = new SqlCommand(sq1, connection);
                int diary = command.ExecuteNonQuery();
                connection.Close();
                if (diary > 0)
                {
                    /*MessageBox.Show("Order Taken");
                    i = n = a = b = c = d = ye = f = 0;
                    textBox1.Text = textBox2.Text = textBox3.Text = string.Empty;
                    taka.Text = 0.ToString();
                    Burger.Text = "Burger";
                    RiceBowl.Text = "Rice Bowl";
                    Pizza.Text = "PIZZA";
                    Sawrma.Text = "Sawrma";
                    Dumplings.Text = "Dumplings";
                    Pastry.Text = "Pastry";
                    Coke.Text = "Coke";
                    Water.Text = "Water";*/
                    Payment pm = new Payment(Int32.Parse(textBox1.Text), amount,textBox2.Text.ToString());
                   
                    pm.ShowDialog(this);
                    



                }
                else
                {
                    MessageBox.Show("Error");
                }
                
              

            }
           
        }
        public void DoEnable()
        {
            this.Enabled = true;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Burgers.Text = 0.ToString();
            RiceBowls.Text = 0.ToString();
            Pizzas.Text = 0.ToString();
            Sawrmas.Text = 0.ToString();
            Dumplings.Text = 0.ToString();
            Pastrys.Text = 0.ToString();
            Cokes.Text = 0.ToString();
            Waters.Text = 0.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            
        }

        private void Signinbutton_Click(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            lg.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            i++;
            Burgers.Text = i.ToString();
            int cash = i * 150 + n * 200 + a * 500 + b * 120 + c * 100 + d * 70 + ye * 30 + f * 15;
            taka.Text = cash.ToString();
            amount = cash;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Int32.Parse(Burgers.Text) > 0)
            {


                i--;
                Burgers.Text = i.ToString();
                int cash = i * 150 + n * 200 + a * 500 + b * 120 + c * 100 + d * 70 + ye * 30 + f * 15;
                taka.Text = cash.ToString();
                amount = cash;

            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            n++;
            RiceBowls.Text = n.ToString();
            int cash = i * 150 + n * 200 + a * 500 + b * 120 + c * 100 + d * 70 + ye * 30 + f * 15;
            taka.Text = cash.ToString();
            amount = cash;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (Int32.Parse(RiceBowls.Text) > 0)
            {
                n--;
                RiceBowls.Text = n.ToString();
                int cash = i * 150 + n * 200 + a * 500 + b * 120 + c * 100 + d * 70 + ye * 30 + f * 15;
                taka.Text = cash.ToString();
                amount = cash;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            a++;
            Pizzas.Text = a.ToString();
            int cash = i * 150 + n * 200 + a * 500 + b * 120 + c * 100 + d * 70 + ye * 30 + f * 15;
            taka.Text = cash.ToString();
            amount = cash;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (Int32.Parse(Pizzas.Text) > 0)
            {
                a--;
                Pizzas.Text = a.ToString();
                int cash = i * 150 + n * 200 + a * 500 + b * 120 + c * 100 + d * 70 + ye * 30 + f * 15;
                taka.Text = cash.ToString();
                amount = cash;
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            b++;
            Sawrmas.Text = b.ToString();
            int cash = i * 150 + n * 200 + a * 500 + b * 120 + c * 100 + d * 70 + ye * 30 + f * 15;
            taka.Text = cash.ToString();
            amount = cash;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(Sawrmas.Text) > 0 )
            {
                b--;
                Sawrmas.Text = b.ToString();
                int cash = i * 150 + n * 200 + a * 500 + b * 120 + c * 100 + d * 70 + ye * 30 + f * 15;
                taka.Text = cash.ToString();
                amount = cash;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            c++;
            Dumplings.Text = c.ToString();
            int cash = i * 150 + n * 200 + a * 500 + b * 120 + c * 100 + d * 70 + ye * 30 + f * 15;
            taka.Text = cash.ToString();
            amount = cash;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(Dumplings.Text) > 0 )
            {
                c--;
                Dumplings.Text = c.ToString();
                int cash = i * 150 + n * 200 + a * 500 + b * 120 + c * 100 + d * 70 + ye * 30 + f * 15;
                taka.Text = cash.ToString();
                amount = cash;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            d++;
            Pastrys.Text = d.ToString();
            int cash = i * 150 + n * 200 + a * 500 + b * 120 + c * 100 + d * 70 + ye * 30 + f * 15;
            taka.Text = cash.ToString();
            amount = cash;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(Pastrys.Text) > 0)
            {
                d--;
                Pastrys.Text = d.ToString();
                int cash = i * 150 + n * 200 + a * 500 + b * 120 + c * 100 + d * 70 + ye * 30 + f * 15;
                taka.Text = cash.ToString();
                amount = cash;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            f++;
            Waters.Text = f.ToString();
            int cash = i * 150 + n * 200 + a * 500 + b * 120 + c * 100 + d * 70 + ye * 30 + f * 15;
            taka.Text = cash.ToString();
            amount = cash;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(Waters.Text) > 0 )
            {
                f--;
                Waters.Text = f.ToString();
                int cash = i * 150 + n * 200 + a * 500 + b * 120 + c * 100 + d * 70 + ye * 30 + f * 15;
                taka.Text = cash.ToString();
                amount = cash;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ye++;
            Cokes.Text = ye.ToString();
            int cash = i * 150 + n * 200 + a * 500 + b * 120 + c * 100 + d * 70 + ye * 30 + f * 15;
            taka.Text = cash.ToString();
            amount = cash;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(Cokes.Text) > 0 )
            {
                ye--;
                Cokes.Text = ye.ToString();
                int cash = i * 150 + n * 200 + a * 500 + b * 120 + c * 100 + d * 70 + ye * 30 + f * 15;
                taka.Text = cash.ToString();
                amount = cash;
            }
        }

        private void Burgers_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
