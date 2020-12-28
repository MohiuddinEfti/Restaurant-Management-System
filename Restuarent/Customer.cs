﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        
        private static int f = 0;

        private void button7_Click(object sender, EventArgs e)
        {
            if (button11.Text == "Add")
            {
                f++;
                Water.Text = f.ToString();
            }
            else if (Water.Text == "Water" && button11.Text == "Deduct")
            {
                MessageBox.Show("ERROR you did not select anything from this section");
            }
            else if (Int32.Parse(Water.Text) > 0 && button11.Text == "Deduct")
            {
                f--;
                Water.Text = f.ToString();
            }
         
        }

        private void taka_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(i+n+a+b+c+d+ye+f==0)
            {
                MessageBox.Show("You Did Not Order Anything");
            }
            else
            {
                int cash = i * 150 + n * 200 + a * 500 + b * 120 + c * 100 + d * 70 + ye * 30 + f * 15;
                taka.Text = cash.ToString();
            }
            
        }
        
        private static int ye = 0;
        private void button8_Click(object sender, EventArgs e)
        {
            if (button11.Text == "Add")
            {
                ye++;
                Coke.Text = ye.ToString();
            }
            else if (Coke.Text == "Coke" && button11.Text == "Deduct")
            {
                MessageBox.Show("ERROR you did not select anything from this section");
            }
            else if (Int32.Parse(Coke.Text) > 0 && button11.Text == "Deduct")
            {
                ye--;
                Coke.Text = ye.ToString();
            }
            
        }
        
        private static int d = 0;
       
        private void button5_Click(object sender, EventArgs e)
        {
            if (button11.Text == "Add")
            {
                d++;
                Pastry.Text = d.ToString();
            }
            else if (Pastry.Text == "Pastry" && button11.Text == "Deduct")
            {
                MessageBox.Show("ERROR you did not select anything from this section");
            }
            else if (Int32.Parse(Pastry.Text) > 0 && button11.Text == "Deduct")
            {
                d--;
                Pastry.Text = d.ToString();
            }

           
        }
        
        private static int c = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            if (button11.Text == "Add")
            {
                c++;
                Dumplings.Text = c.ToString();
            }
            else if (Dumplings.Text == "Dumplings" && button11.Text == "Deduct")
            {
                MessageBox.Show("ERROR you did not select anything from this section");
            }
            else if (Int32.Parse(Dumplings.Text) > 0 && button11.Text == "Deduct")
            {
                c--;
                Dumplings.Text = c.ToString();
            }
            
        }
        
        private static int b = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (button11.Text == "Add")
            {
                b++;
                Sawrma.Text = b.ToString();
            }
            else if (Sawrma.Text == "Sawrma" && button11.Text == "Deduct")
            {
                MessageBox.Show("ERROR you did not select anything from this section");
            }
            else if (Int32.Parse(Sawrma.Text) > 0 && button11.Text == "Deduct")
            {
                b--;
                Sawrma.Text = b.ToString();
            }
            
            
        }
        
        private static int a = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            if (button11.Text == "Add")
            {
                a++;
                Pizza.Text = a.ToString();
            }
            else if (Pizza.Text == "PIZZA" && button11.Text == "Deduct")
            {
                MessageBox.Show("ERROR you did not select anything from this section");
            }
            else if (Int32.Parse(Pizza.Text) > 0 && button11.Text == "Deduct")
            {
                a--;
                Pizza.Text = a.ToString();
            }
            
        }
        private static int i = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(button11.Text=="Add")
            {
                i++;
                Burger.Text = i.ToString();
            }
            else if (Burger.Text == "Burger" && button11.Text == "Deduct")
            {
                MessageBox.Show("ERROR you did not select anything from this section");
            }
            else if(Int32.Parse(Burger.Text) > 0 && button11.Text == "Deduct")
            {
                
              
                    i--;
                    Burger.Text = i.ToString();
                
                
            }
            
        }
        private static int n = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (button11.Text == "Add")
            {
                n++;
                RiceBowl.Text = n.ToString();
            }
            else if (RiceBowl.Text == "Rice Bowl" && button11.Text == "Deduct")
            {
                MessageBox.Show("ERROR you did not select anything from this section");
            }
            else if (Int32.Parse(RiceBowl.Text) > 0 && button11.Text == "Deduct")
            {
                n--;
                RiceBowl.Text = n.ToString();
            }
            
        }

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
                MessageBox.Show("Order Taken");
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
                Water.Text = "Water";
              

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            if(button11.Text== "Add")
            {
                button11.Text = "Deduct";
                button11.BackColor = Color.Red;
                
            }
            else
            {
                button11.Text = "Add";
                button11.BackColor = Color.Lime;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
