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
    public partial class Payment: Form
    {
        public int formtname;
        public int formamount;
        public string formcname;
        public string formorder;
        public Payment(int tbName,int amount,string cname,string order)
        {
            
            InitializeComponent();
            formtname = tbName;
            formamount = amount;
            formcname = cname;
            formorder = order;
        }
        
        
        private void Payment_FormClosing(object sender, FormClosingEventArgs e)
        {
            
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
            connection.Open();
            string sql = "DELETE FROM CustomerOrders WHERE TableNo='" + formtname + "'AND CustomerName='" + formcname + "'AND Price='" + formamount + "'";


            SqlCommand command = new SqlCommand(sql, connection);
            int diary = command.ExecuteNonQuery();

            
            connection.Close();
            this.Hide();
        }
        public string picture;
        public int number;
        public int id=1;
        private void Payment_Load(object sender, EventArgs e)
        {
            
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Bkash"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM Bkash WHERE Id=" + id;
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                number = (int)reader["Phone"];
                picture = reader["QR"].ToString();


            }
            connection.Close();
            label7.Text = number.ToString();
            pictureBox1.ImageLocation = picture;
            groupBox1.Visible = false;
            pictureBox1.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            button4.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
        
        private void Bkash_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            groupBox1.Visible = false;
            pictureBox1.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            button4.Visible = false;
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 11)
            {

                MessageBox.Show("Phone number must be 11 digits");
            }
            else
            {
                pictureBox1.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label7.Visible = true;
                button4.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            groupBox1.Visible = false;
            pictureBox1.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            button4.Visible = false;
            
            string to = textBox1.Text;
            
            //string api = "https://api.whatsapp.com/send?phones="+to+"&text="+ formorder.ToString();
            try
            {
                System.Diagnostics.Process.Start("https://api.whatsapp.com/send?phones=" + to + "&text=" + formorder);
            }
            catch
            {

            }
            //this.Hide();
        }
    }
}
