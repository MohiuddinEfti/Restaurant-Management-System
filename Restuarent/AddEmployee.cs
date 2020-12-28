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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            string gen = null;
            if (radioButton1.Checked)
            {
                gen = "Female";
            }
            else
            {
                gen = "Male";
            }

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Employees"].ConnectionString);
            connection.Open();
            string sql = "INSERT INTO Employees(Name,Email,PhoneNo,DateOfBirth,Gender,BloodGroup) VALUES('" + NameTextBox.Text + "','" + EmailTextBox.Text + "','" + Phonetextbox.Text + "','" + dateTimePicker1.Text + "','" + gen + "','" + comboBox1.Text + "')";
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            connection.Close();
            if (result > 0)
            {

                {
                    if (NameTextBox.Text == "")
                    {

                        MessageBox.Show("You have not given any name in the provided space");
                    }

                    else if (Phonetextbox.Text == "")
                    {

                        MessageBox.Show("You have not given the employees phone number in the provided space");
                    }
                    else if (EmailTextBox.Text == "")
                    {
                        MessageBox.Show("You have not given employees email in the provided space");
                    }
                    else if (radioButton1.Checked == false && radioButton2.Checked == false)
                    {
                        MessageBox.Show("Error!!\nThe password you have typed does not match with the password you have confirmed.\nPlease type again.");
                    }

                    else
                    {
                        MessageBox.Show("All employee details have been successfully added.");
                        Manager M = new Manager();
                        M.Show();
                        this.Hide();


                    }
                }

            }

            else
            {
                MessageBox.Show("Error!!!\nYAdding of employee details was unsuccessful.\nPlease try again.");
                Manager M = new Manager();
                M.Show();
                this.Hide();
            }

        }
    }
    }

