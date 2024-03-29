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
    public partial class Accounts : Form
    {
        public int id1;
        public int c;
        public int d;
        public string name;
        public string position;
        public Accounts(string a,string b)
        {
            InitializeComponent();
           
            name = a;
            position = b;
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            this.dataGridView2.DefaultCellStyle.Font = new Font("Tahoma", 20);
            this.WindowState = FormWindowState.Maximized;
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
            string Today = DateTime.Today.ToString("dddd , MMM dd yyyy");
            string cancel = "Cancel";
            string Ready = "Served";
            SqlConnection connections = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
            connections.Open();
            string sqls = "SELECT * FROM CustomerOrders Where Date LIKE '" + Today + "%' AND ChefOrderDone !='" + cancel + "' And CustomerRecieved='" + Ready + "' OR CustomerRecieved='" + Ready + "' AND Date LIKE '" + Today + "%' AND ChefOrderDone IS NULL";
            SqlCommand commands = new SqlCommand(sqls, connections);
            SqlDataReader readers = commands.ExecuteReader();
            List<AccountsCash> list = new List<AccountsCash>();
            while (readers.Read())
            {
                AccountsCash CS = new AccountsCash();


                CS.Cash = (int)readers["Price"];
                CS.Date = readers["Date"].ToString();

                list.Add(CS);
            }
            dataGridView1.DataSource = list;
            connections.Close();

            SqlConnection connection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Accounts"].ConnectionString);
            connection2.Open();
            string sq2 = "SELECT * FROM Accounts";
            SqlCommand command2 = new SqlCommand(sq2, connection2);
            SqlDataReader reader2 = command2.ExecuteReader();
            List<DailyIncome> list2 = new List<DailyIncome>();
            while (reader2.Read())
            {
                DailyIncome CS = new DailyIncome();

                CS.Id = (int)reader2["ID"];
                CS.TotalCash = (int)reader2["TotalCash"];
                CS.Date = reader2["Date"].ToString();
                CS.Time = reader2["Time"].ToString();
                CS.UpdatedTime = reader2["UpdatedTime"].ToString();

                list2.Add(CS);
            }
            dataGridView2.DataSource = list2;

        }

       
        
       

        private void Accounts_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

       

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string ab = time.ToString("h:mm tt ");
            string Today = DateTime.Today.ToString("dddd , MMM dd yyyy");
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Accounts"].ConnectionString);
            connection.Open();
            string sql = "UPDATE Accounts SET TotalCash='" + textBox3.Text+ "',UpdatedTime='" + ab + " " + Today + "' WHERE Id=" + id1;
           
            
            SqlCommand command = new SqlCommand(sql, connection);
           
            int diary = command.ExecuteNonQuery();
          
            if (diary > 0)
            {
                MessageBox.Show("Order is Succefully Done");
                string sq2 = "SELECT * FROM Accounts";
                SqlCommand command2 = new SqlCommand(sq2, connection);
                SqlDataReader reader2 = command2.ExecuteReader();
                List<DailyIncome> list2 = new List<DailyIncome>();
                while (reader2.Read())
                {
                    DailyIncome CS = new DailyIncome();

                    CS.Id = (int)reader2["ID"];
                    CS.TotalCash = (int)reader2["TotalCash"];
                    CS.Date = reader2["Date"].ToString();
                    CS.Time = reader2["Time"].ToString();
                    CS.UpdatedTime = reader2["UpdatedTime"].ToString();

                    list2.Add(CS);
                }
                dataGridView2.DataSource = list2;
                textBox3.Text = string.Empty;

            }
        }

       

        

        private void button21_Click(object sender, EventArgs e)
        {
            Manager mg = new Manager(name,position);
            mg.Show();
            this.Hide();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            id1 = (int)dataGridView2.Rows[e.RowIndex].Cells[0].Value;
            int cash = (int)dataGridView2.Rows[e.RowIndex].Cells[1].Value;
            textBox3.Text = cash.ToString();
        }
    }
}
