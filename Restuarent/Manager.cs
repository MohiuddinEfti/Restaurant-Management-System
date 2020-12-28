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
    public partial class Manager : Form
    {
        int Id;

        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            AddEmployee AE = new AddEmployee();
            AE.Show();
            this.Hide();
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Employees"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM Employees";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Employee> list = new List<Employee>();
            while (reader.Read())
            {
                Employee EM = new Employee();
                EM.Id = (int)reader["Id"];
                EM.Name = reader["Name"].ToString();
                EM.PhoneNo = reader["PhoneNo"].ToString();
                EM.Email = reader["Email"].ToString();
                EM.DateOfBirth = reader["DateOfBirth"].ToString();
                EM.Gender = reader["Gender"].ToString();
                EM.BloodGroup = reader["BloodGroup"].ToString();


                list.Add(EM);
            }
            dataGridView1.DataSource = list;
        }
    }
}
