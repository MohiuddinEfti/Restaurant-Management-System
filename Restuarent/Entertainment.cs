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
    public partial class Entertainment : Form
    {
        public string movie;
        public string kidmovie;
        public Entertainment()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = movie; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Entertainment_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Movie"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM Movie WHERE Id=1";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                CustomerOrders CS = new CustomerOrders();

                CS.Id = (int)reader["Id"];
                movie = reader["Movie"].ToString();
                
                kidmovie = reader["KidsMovie"].ToString();
                
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = kidmovie; 
        }
    }
}
