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
    public partial class BkashScan : Form
    {
        public string Cname, Torder, Ortime, Ref;
        public int Tbno, Price;
        public BkashScan(string cname,int tbno,string torder,string ortime,int price,string refa)
        {
            InitializeComponent();
            Cname = cname;
            Tbno = tbno;
            Torder = torder;
            Ortime = ortime;
            Price = price;
            Ref = refa;
        }
        public int number;
        public int id=1;
        public string picture;
        private void BkashScan_Load(object sender, EventArgs e)
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
            label13.Text = number.ToString();
            pictureBox2.ImageLocation = picture;
        }

        private void Paid_Click(object sender, EventArgs e)
        {
            string bkash = "Bkash Not Paid";
            string Today = DateTime.Today.ToString("dddd , MMM dd yyyy");
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
            connection.Open();
            string sq1 = "INSERT INTO CustomerOrders(CustomerName,TableNo,TotalOrder,OrderTime,Price,Date,Payment) VALUES('" + Cname + "','" + Tbno + "','" + Torder + "','" + Ortime + "','" + Price + "','" + Today + "','" + bkash + "')";
            SqlCommand command = new SqlCommand(sq1, connection);
            int diary = command.ExecuteNonQuery();
            connection.Close();
            if (diary > 0)
            {
                MessageBox.Show("Order Taken");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
