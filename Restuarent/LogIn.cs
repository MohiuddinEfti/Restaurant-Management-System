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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Signinbutton_Click(object sender, EventArgs e)
        {
            
            if (Namebox.Text=="Customer" && PasswordBox.Text=="Customer")
            {
                Customer cm = new Customer();
                cm.Show();
                this.Hide();
            }
            else if (Namebox.Text == "admin" && PasswordBox.Text == "admin")
            {
                Admin cm = new Admin("admin","admin");
                cm.Show();
                this.Hide();
            }
            else if (Namebox.Text == "Manager" && PasswordBox.Text == "Manager")
            {
                Manager cm = new Manager(Namebox.Text, Namebox.Text);
                cm.Show();
                this.Hide();
            }
            else if (Namebox.Text == "")
            {
                MessageBox.Show("ERROR Username Is Empty");

            }
            else if (PasswordBox.Text == "")
            {
                MessageBox.Show("ERROR Password Is Empty");

            }
            else
            {





                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Employee"].ConnectionString);


                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE Name = '" + Namebox.Text + "' AND [Password] = '" + PasswordBox.Text + "' ", connection);



                connection.Open();


                SqlDataReader sdr = cmd.ExecuteReader();
                if ((sdr.Read() == true))

                {
                    string emp;
                    string eid;
                    string po;
                    string pi;
                    string sq1 = "SELECT * FROM Employee WHERE Name = '" + Namebox.Text + "'";
                    SqlCommand commands = new SqlCommand(sq1, connection);

                    emp = sdr["Name"].ToString();
                    eid = sdr["EmpID"].ToString();
                    po = sdr["Position"].ToString();
                    pi = sdr["Picture"].ToString();

                    Attendance at = new Attendance(emp,eid,po,pi);
                    at.Show();
                    this.Hide();
                }             
                else
                {

                    MessageBox.Show("Invalid username or password!");

                }
        }  }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.BackColor==Color.White)
            {
                PasswordBox.PasswordChar = '\0';
                button1.BackColor = Color.Gray;
            }
            else
            {
                PasswordBox.PasswordChar = '*';
                button1.BackColor = Color.White;
            }

        }
    }
}
