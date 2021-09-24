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
    public partial class FoodItem : Form
    {
        public int powerid;

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

        public string realname1;
       

        public string abc;

        public FoodItem()
        {
            InitializeComponent();
        }

        private void FoodItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FoodItem_Load(object sender, EventArgs e)
        {
            groupbox1.Visible = false;
            Namelab1.Visible = false;
            Pricelab1.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            Update1.Visible = false;
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
            pictureBox1.ImageLocation =pic1;
            
            button1.Text = "Update "+name1;
            textBox1.Text = name1+" "+ price1+" tk";

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
            pictureBox2.ImageLocation = pic2;
            button2.Text = "Update " + name2;
            textBox2.Text = name2 + " " + price2 + " tk";

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
            pictureBox3.ImageLocation = pic3;
            button3.Text = "Update " + name3;
            textBox3.Text = name3 + " " + price3 + " tk";

            SqlConnection connection4 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection4.Open();
            string sq4 = "SELECT * FROM Food Where Id=4";
            SqlCommand command4 = new SqlCommand(sq4, connection4);
            SqlDataReader reader4 = command4.ExecuteReader();

            while (reader4.Read())
            {

                price4 = (int)reader4["FoodPrice"];
                name4= reader4["FoodName"].ToString();
                pic4 = reader4["FoodPic"].ToString();



            }
            connection4.Close();
            pictureBox4.ImageLocation = pic4;
            button4.Text = "Update " + name4;
            textBox4.Text = name4 + " " + price4 + " tk";

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
            pictureBox5.ImageLocation = pic5;
            button5.Text = "Update " + name5;
            textBox5.Text = name5 + " " + price5 + " tk";

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
            pictureBox6.ImageLocation = pic6;
            button6.Text = "Update " + name6;
            textBox6.Text = name6 + " " + price6 + " tk";

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
            pictureBox7.ImageLocation = pic7;
            button7.Text = "Update " + name7;
            textBox7.Text = name7 + " " + price7 + " tk";

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
            pictureBox8.ImageLocation = pic8;
            button8.Text = "Update " + name8;
            textBox8.Text = name8 + " " + price8 + " tk";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox10.Text, "[^0-9]"))
            {
                MessageBox.Show("Price will be in numbers.");
                textBox10.Text = String.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            pictureBox9.ImageLocation = pic1;
            textBox9.Text = name1;
            realname1 = name1;
            textBox10.Text = price1.ToString();
            powerid = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Namelab1.Visible = true;
            Pricelab1.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            Update1.Visible = true;
            string img;
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    img = ofd.FileName;
                    if (img != "")
                    {
                        abc = img;
                    }
                    else
                    {
                        abc = string.Empty;
                    }

                    pictureBox9.ImageLocation = img;
                   


                }

            }
            catch (Exception)
            {
                MessageBox.Show("An ERROR Occured");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            powerid = 2;
            groupbox1.Visible = true;
            textBox9.Text = name2;
            realname1 = name2;
            textBox10.Text = price2.ToString();
            pictureBox9.ImageLocation = pic2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = name3;
            realname1 = name3;
            textBox10.Text = price3.ToString();
            pictureBox9.ImageLocation = pic3; 
            powerid = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = name4;
            realname1 = name4;
            textBox10.Text = price4.ToString();
            pictureBox9.ImageLocation = pic4; 
            powerid = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = name5;
            realname1 = name5;
            textBox10.Text = price5.ToString();
            pictureBox9.ImageLocation = pic5; 
            powerid = 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = name6;
            realname1 = name6;
            textBox10.Text = price6.ToString();
            pictureBox9.ImageLocation = pic6; 
            powerid = 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = name7;
            realname1 = name7;
            textBox10.Text = price7.ToString();
            pictureBox9.ImageLocation = pic7; 
            powerid = 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = name8;
            realname1 = name8;
            textBox10.Text = price8.ToString();
            pictureBox9.ImageLocation = pic8; 
            powerid = 8;
        }

        private void Update1_Click(object sender, EventArgs e)
        {
           
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection.Open();
                string sql = "UPDATE Food SET FoodName='" + textBox9.Text + "',FoodPic='" + pictureBox9.ImageLocation + "',FoodPrice='" + textBox10.Text + "'WHERE Id=" + powerid;
                SqlCommand command = new SqlCommand(sql, connection);
                int diary = command.ExecuteNonQuery();

                if (diary > 0)
                {
                    MessageBox.Show("Updated");
                    textBox9.Text = textBox10.Text = String.Empty;
                    groupbox1.Visible = false;
                    Namelab1.Visible = false;
                    Pricelab1.Visible = false;
                    textBox9.Visible = false;
                    textBox10.Visible = false;
                    Update1.Visible = false;

                }
                else
                {
                    MessageBox.Show("Error");
                }
            
                SqlConnection connection11 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection11.Open();
            string sql1 = "SELECT * FROM Food Where Id=1";
            SqlCommand command11 = new SqlCommand(sql1, connection11);
            SqlDataReader reader = command11.ExecuteReader();

            while (reader.Read())
            {


                price1 = (int)reader["FoodPrice"];
                name1 = reader["FoodName"].ToString();
                pic1 = reader["FoodPic"].ToString();



            }
            connection11.Close();
            pictureBox1.ImageLocation = pic1;

            button1.Text = "Update " + name1;
            textBox1.Text = name1 + " " + price1 + " tk";

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
            pictureBox2.ImageLocation = pic2;
            button2.Text = "Update " + name2;
            textBox2.Text = name2 + " " + price2 + " tk";

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
            pictureBox3.ImageLocation = pic3;
            button3.Text = "Update " + name3;
            textBox3.Text = name3 + " " + price3 + " tk";

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
            pictureBox4.ImageLocation = pic4;
            button4.Text = "Update " + name4;
            textBox4.Text = name4 + " " + price4 + " tk";

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
            pictureBox5.ImageLocation = pic5;
            button5.Text = "Update " + name5;
            textBox5.Text = name5 + " " + price5 + " tk";

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
            pictureBox6.ImageLocation = pic6;
            button6.Text = "Update " + name6;
            textBox6.Text = name6 + " " + price6 + " tk";

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
            pictureBox7.ImageLocation = pic7;
            button7.Text = "Update " + name7;
            textBox7.Text = name7 + " " + price7 + " tk";

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
            pictureBox8.ImageLocation = pic8;
            button8.Text = "Update " + name8;
            textBox8.Text = name8 + " " + price8 + " tk";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin("admin","admin");
            ad.Show();
            this.Hide();
            textBox9.Text = textBox10.Text = String.Empty;
            groupbox1.Visible = false;
            Namelab1.Visible = false;
            Pricelab1.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            Update1.Visible = false;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
