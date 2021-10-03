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
    public partial class Bkash : Form
    {
        public Bkash()
        {
            InitializeComponent();
        }
        public string abc;
        public Int32 num;
        private void button1_Click(object sender, EventArgs e)
        {
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

                    pictureBox1.ImageLocation = img;
                    button4.Visible = true;


                }

            }
            catch (Exception)
            {
                MessageBox.Show("An ERROR Occured");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = String.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 11)
            {

                MessageBox.Show("Phone number must be 11 digits");
                textBox1.Text = String.Empty;
            }
            else
            {
                
                num = Convert.ToInt32(textBox1.Text);
                label7.Text = textBox1.Text;
                pictureBox1.Visible = true;
                button1.Visible = true;
            }
        }
        public int id = 1;
        public string picture;
        public int number;
        private void Bkash_Load(object sender, EventArgs e)
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
            pictureBox1.Visible = false;
            button1.Visible = false;
            button4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Bkash"].ConnectionString);
            connection.Open();
            string sql = "UPDATE Bkash SET Phone='" + textBox1.Text + "',QR='" + pictureBox1.ImageLocation + "'WHERE Id=" + id;
           // string sq2 = "UPDATE Bkash SET QR='" + pictureBox1.ImageLocation + "'WHERE Id=" + id;
            SqlCommand command = new SqlCommand(sql, connection);
            //SqlCommand command1 = new SqlCommand(sq2, connection);
            
            int diary = command.ExecuteNonQuery();
            //int diary1 = command1.ExecuteNonQuery();
            if (diary > 0)
            {
                MessageBox.Show("Updated");
                Account ac = new Account();
                ac.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Bkash_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
