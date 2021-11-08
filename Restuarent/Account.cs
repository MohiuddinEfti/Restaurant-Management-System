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
    public partial class Account : Form
    {
        string a;
        string b;
        public Account()
        {
            InitializeComponent();
        }
        public string picture;
        public int number;
        public int id = 1;
        private void Account_Load(object sender, EventArgs e)
        {
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
            dataGridView1.DataSource = list2;
            connection2.Close();
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
            string Today = DateTime.Today.ToString("dddd , MMM dd yyyy");
            string cancel = "Cancel";
            SqlConnection connections = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
            connections.Open();
            string sqls = "SELECT * FROM CustomerOrders Where Date LIKE '" + Today + "%' AND ChefOrderDone !='" + cancel+ "' OR Date LIKE '" + Today + "%' AND ChefOrderDone IS NULL";
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
            dataGridView3.DataSource = list;
            connections.Close();
            int a = 0;
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {

                string b = dataGridView3.Rows[i].Cells[0].Value.ToString(); 
                

                a = a + Int32.Parse(b);
                label1.Text = "Total Cash = "+a.ToString()+" Tk";

            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void Account_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bkash bk = new Bkash();
            bk.ShowDialog();
            
        }
    }
}
