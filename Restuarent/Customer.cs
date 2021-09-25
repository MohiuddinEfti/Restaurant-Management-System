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
    public partial class Customer : Form
    {
        public int tbno;
        public Customer(int a)
        {
            tbno = a;
            InitializeComponent();
        }
        
        public static int f = 0;
        public int price1;
        public int price2;
        public int price3;
        public int price4;
        public int price5;
        public int price6;
        public int price7;
        public int price8;

        public string name1;
        public string name2;
        public string name3;
        public string name4;
        public string name5;
        public string name6;
        public string name7;
        public string name8;

        public string pic1;
        public string pic2;
        public string pic3;
        public string pic4;
        public string pic5;
        public string pic6;
        public string pic7;
        public string pic8;


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
            if(textBox2.Text=="")
            {
                MessageBox.Show("Customer name is empty");
            }
            else if(i==0&&n==0&&a==0&&b==0&&c==0&&d==0&&ye==0&&f==0)
            {
                MessageBox.Show("You did not order anything can't take order");
            }
            else
            {
                
                int tk = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
                string Today = DateTime.Today.ToString("dddd , MMM dd yyyy");
                DateTime time = DateTime.Now;
                string ab = time.ToString("h:mm:ss tt ");
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
                connection.Open();
                string sq1 = "INSERT INTO CustomerOrders(CustomerName,TableNo,AddOn,Burger,RiceBowl,Pizza,Sawrma,Dumplings,Pastry,Coke,Water,OrderTime,Price,Date) VALUES('" + textBox2.Text + "','" + tbno + "','" + textBox3.Text + "','" + i.ToString() + "','" + n.ToString() + "','" + a.ToString() + "','" + b.ToString() + "','" + c.ToString() + "','"+d.ToString()+ "','"+ye.ToString()+ "','"+f.ToString()+ "','"+ab+ "','"+tk+"','"+Today+"')";

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
                    Payment pm = new Payment(tbno, amount,textBox2.Text.ToString());
                   
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

        

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            label8.Text = tbno.ToString();
            Burgers.Text = 0.ToString();
            RiceBowls.Text = 0.ToString();
            Pizzas.Text = 0.ToString();
            Sawrmas.Text = 0.ToString();
            Dumplings.Text = 0.ToString();
            Pastrys.Text = 0.ToString();
            Cokes.Text = 0.ToString();
            Waters.Text = 0.ToString();

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM Food Where Id=1";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {


                price1 = (int)reader["FoodPrice"];
                name1 = reader["FoodName"].ToString();
                pic1 = reader["FoodPic"].ToString();



            }
            connection.Close();
            BurgerLab.Text = name1;
            Burgerpic.ImageLocation = pic1;

            SqlConnection connection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection2.Open();
            string sq2 = "SELECT * FROM Food Where Id=2";
            SqlCommand command2 = new SqlCommand(sq2, connection2);
            SqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {

                price2 = (int)reader2["FoodPrice"];
                name2 = reader2["FoodName"].ToString();
                pic2 = reader2["FoodPic"].ToString();



            }
            connection2.Close();
            pictureBox1.ImageLocation = pic2;
            RicebowlLab.Text = name2;
            SqlConnection connection3 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection3.Open();
            string sq3 = "SELECT * FROM Food Where Id=3";
            SqlCommand command3 = new SqlCommand(sq3, connection3);
            SqlDataReader reader3 = command3.ExecuteReader();

            while (reader3.Read())
            {

                price3 = (int)reader3["FoodPrice"];
                name3 = reader3["FoodName"].ToString();
                pic3 = reader3["FoodPic"].ToString();



            }
            connection3.Close();
            pizzapic.ImageLocation = pic3;
            Pizzalab.Text = name3;
            SqlConnection connection4 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection4.Open();
            string sq4 = "SELECT * FROM Food Where Id=4";
            SqlCommand command4 = new SqlCommand(sq4, connection4);
            SqlDataReader reader4 = command4.ExecuteReader();

            while (reader4.Read())
            {

                price4 = (int)reader4["FoodPrice"];
                name4 = reader4["FoodName"].ToString();
                pic4 = reader4["FoodPic"].ToString();



            }
            connection4.Close();
            sawrmapic.ImageLocation = pic4;
            Sawrmalab.Text = name4;
            SqlConnection connection5 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection5.Open();
            string sq5 = "SELECT * FROM Food Where Id=5";
            SqlCommand command5 = new SqlCommand(sq5, connection5);
            SqlDataReader reader5 = command5.ExecuteReader();

            while (reader5.Read())
            {

                price5 = (int)reader5["FoodPrice"];
                name5 = reader5["FoodName"].ToString();
                pic5 = reader5["FoodPic"].ToString();



            }
            connection5.Close();
            Dumplingpic.ImageLocation = pic5;
            Dumplinglab.Text = name5;
            SqlConnection connection6 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection6.Open();
            string sq6 = "SELECT * FROM Food Where Id=6";
            SqlCommand command6 = new SqlCommand(sq6, connection6);
            SqlDataReader reader6 = command6.ExecuteReader();

            while (reader6.Read())
            {

                price6 = (int)reader6["FoodPrice"];
                name6 = reader6["FoodName"].ToString();
                pic6 = reader6["FoodPic"].ToString();



            }
            connection6.Close();
            Pastrypic.ImageLocation = pic6;
            Pastrylab.Text = name6;
            SqlConnection connection7 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection7.Open();
            string sq7 = "SELECT * FROM Food Where Id=7";
            SqlCommand command7 = new SqlCommand(sq7, connection7);
            SqlDataReader reader7 = command7.ExecuteReader();

            while (reader7.Read())
            {

                price7 = (int)reader7["FoodPrice"];
                name7 = reader7["FoodName"].ToString();
                pic7 = reader7["FoodPic"].ToString();



            }
            connection7.Close();
            Cokepic.ImageLocation = pic7;
            Cokelab.Text = name7;
            SqlConnection connection8 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection8.Open();
            string sq8 = "SELECT * FROM Food Where Id=8";
            SqlCommand command8 = new SqlCommand(sq8, connection8);
            SqlDataReader reader8 = command8.ExecuteReader();

            while (reader8.Read())
            {

                price8 = (int)reader8["FoodPrice"];
                name8 = reader8["FoodName"].ToString();
                pic8 = reader8["FoodPic"].ToString();



            }
            connection8.Close();
            Waterpic.ImageLocation = pic8;
            Waterlab.Text = name8;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            
        }

        private void Signinbutton_Click(object sender, EventArgs e)
        {
           
            DialogResult dialogResult = MessageBox.Show("Are You Sure", "Log Out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
               
                Burgers.Text = Pizzas.Text = RiceBowls.Text = Sawrmas.Text = Dumplings.Text = Pastrys.Text = Cokes.Text = Waters.Text = textBox2.Text = textBox3.Text = taka.Text = String.Empty;
                i = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                ye = 0;
                f = 0;
                
                LogIn lg = new LogIn();
                lg.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            i++;
            Burgers.Text = i.ToString();
            int cash =  i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
            taka.Text = cash.ToString();
            amount = cash;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Int32.Parse(Burgers.Text) > 0)
            {


                i--;
                Burgers.Text = i.ToString();
                int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
                taka.Text = cash.ToString();
                amount = cash;

            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            n++;
            RiceBowls.Text = n.ToString();
            int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
            taka.Text = cash.ToString();
            amount = cash;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (Int32.Parse(RiceBowls.Text) > 0)
            {
                n--;
                RiceBowls.Text = n.ToString();
                int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
                taka.Text = cash.ToString();
                amount = cash;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            a++;
            Pizzas.Text = a.ToString();
            int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
            taka.Text = cash.ToString();
            amount = cash;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (Int32.Parse(Pizzas.Text) > 0)
            {
                a--;
                Pizzas.Text = a.ToString();
                int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
                taka.Text = cash.ToString();
                amount = cash;
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            b++;
            Sawrmas.Text = b.ToString();
            int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
            taka.Text = cash.ToString();
            amount = cash;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(Sawrmas.Text) > 0 )
            {
                b--;
                Sawrmas.Text = b.ToString();
                int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
                taka.Text = cash.ToString();
                amount = cash;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            c++;
            Dumplings.Text = c.ToString();
            int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
            taka.Text = cash.ToString();
            amount = cash;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(Dumplings.Text) > 0 )
            {
                c--;
                Dumplings.Text = c.ToString();
                int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
                taka.Text = cash.ToString();
                amount = cash;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            d++;
            Pastrys.Text = d.ToString();
            int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
            taka.Text = cash.ToString();
            amount = cash;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(Pastrys.Text) > 0)
            {
                d--;
                Pastrys.Text = d.ToString();
                int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
                taka.Text = cash.ToString();
                amount = cash;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            f++;
            Waters.Text = f.ToString();
            int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
            taka.Text = cash.ToString();
            amount = cash;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(Waters.Text) > 0 )
            {
                f--;
                Waters.Text = f.ToString();
                int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
                taka.Text = cash.ToString();
                amount = cash;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ye++;
            Cokes.Text = ye.ToString();
            int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
            taka.Text = cash.ToString();
            amount = cash;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(Cokes.Text) > 0 )
            {
                ye--;
                Cokes.Text = ye.ToString();
                int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
                taka.Text = cash.ToString();
                amount = cash;
            }
        }

        private void Burgers_TextChanged(object sender, EventArgs e)
        {

        }

        private void Burgerpic_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void RiceBowls_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
