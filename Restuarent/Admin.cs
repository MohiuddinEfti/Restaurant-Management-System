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
    public partial class Admin : Form
    {
        public int Id;
        public string Positions = "admin";
        public string names="admin";

        public string real1;
        public string real2;
        public string real3;
        public string real4;
        public string real5;
        public string real6;
        public string real7;
        public string real8;

        public string name1;
        public string name2;
        public string name3;
        public string name4;
        public string name5;
        public string name6;
        public string name7;
        public string name8;
        public Admin(string a , string b)
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stock S = new Stock(names, Positions);
            S.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckAttendance ca = new CheckAttendance(names, Positions);
            ca.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            AddEmployee ae = new AddEmployee(names, Positions);
            ae.Show();
            this.Hide();
        }

        private void Logoutbutton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure", "Log Out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                LogIn lg = new LogIn();
                lg.Show();
                timer1.Enabled = false;
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account ac = new Account();
            ac.ShowDialog(this);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 15);
            icon_restore.Visible = true;
            
            button7.Visible = false;
            label8.Visible = true;
            label3.Visible = false;
            panel1.Visible = false;
            Kidmovies.Visible = false;
            button12.Visible = false;
            Movies.Visible = false;
            button11.Visible = false;
            button14.Visible = false;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
                connection.Open();
                string sql = "SELECT * FROM CustomerOrders";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                List<CustomerOrders> list = new List<CustomerOrders>();
                while (reader.Read())
                {
                    CustomerOrders CS = new CustomerOrders();

                    CS.Id = (int)reader["Id"];
                    CS.CustomerName = reader["CustomerName"].ToString();
                    CS.TableNo = (int)reader["TableNo"];
                    CS.TotalOrder = reader["TotalOrder"].ToString();
                    CS.Price = reader["Price"].ToString();
                    CS.OrderTime = reader["OrderTime"].ToString();
                    CS.ChefOrderDone = reader["ChefOrderDone"].ToString();
                    CS.CustomerRecievedTime = reader["CustomerRecieved"].ToString();
                    CS.Date = reader["Date"].ToString();
                    CS.Payment = reader["Payment"].ToString();

                    list.Add(CS);
                }

                dataGridView1.DataSource = list;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {

                if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "" && dataGridView1.Rows[i].Cells[7].Value.ToString() == "")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                if (dataGridView1.Rows[i].Cells[6].Value.ToString() != "" && dataGridView1.Rows[i].Cells[7].Value.ToString() == "")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                if (dataGridView1.Rows[i].Cells[6].Value.ToString() != "" && dataGridView1.Rows[i].Cells[7].Value.ToString() != "")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "Cancel")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkBlue;
                }
            }



        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Food_Click(object sender, EventArgs e)
        {
            FoodItem fi = new FoodItem();
            fi.Show();
            this.Hide();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Live Order Viewer Is On");
            timer1.Enabled = true;

            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timer1.Enabled==true)
            {
                label2.ForeColor = Color.Green;
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
                connection.Open();
                string sql = "SELECT * FROM CustomerOrders";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                List<CustomerOrders> list = new List<CustomerOrders>();
                while (reader.Read())
                {
                    CustomerOrders CS = new CustomerOrders();

                    CS.Id = (int)reader["Id"];
                    CS.CustomerName = reader["CustomerName"].ToString();
                    CS.TableNo = (int)reader["TableNo"];
                    CS.TotalOrder = reader["TotalOrder"].ToString();
                    CS.Price = reader["Price"].ToString();
                    CS.OrderTime = reader["OrderTime"].ToString();
                    CS.ChefOrderDone = reader["ChefOrderDone"].ToString();
                    CS.CustomerRecievedTime = reader["CustomerRecieved"].ToString();
                    CS.Date = reader["Date"].ToString();
                    CS.Payment = reader["Payment"].ToString();

                    list.Add(CS);
                }

                dataGridView1.DataSource = list;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {

                    if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "" && dataGridView1.Rows[i].Cells[7].Value.ToString() == "")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                    if (dataGridView1.Rows[i].Cells[6].Value.ToString() != "" && dataGridView1.Rows[i].Cells[7].Value.ToString() == "")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    if (dataGridView1.Rows[i].Cells[6].Value.ToString() != "" && dataGridView1.Rows[i].Cells[7].Value.ToString() != "")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "Cancel")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkBlue;
                    }
                }
            }
            
            
               
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Live Order Viewer Is Off");
            label2.ForeColor = Color.Red;
            timer1.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
            connection.Open();
            string sql = "DELETE FROM CustomerOrders";


            SqlCommand command = new SqlCommand(sql, connection);
            int diary = command.ExecuteNonQuery();
            if(diary>0)
            {
                MessageBox.Show("All Order Has Been Deleted");
                SqlConnection connectionss = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
                connectionss.Open();
                string sqlss = "SELECT * FROM CustomerOrders";
                SqlCommand commandss = new SqlCommand(sqlss, connectionss);
                SqlDataReader reader = commandss.ExecuteReader();
                List<CustomerOrders> list = new List<CustomerOrders>();
                while (reader.Read())
                {
                    CustomerOrders CS = new CustomerOrders();

                    CS.Id = (int)reader["Id"];
                    CS.CustomerName = reader["CustomerName"].ToString();
                    CS.TableNo = (int)reader["TableNo"];
                 
                    CS.Price = reader["Price"].ToString();
                    CS.OrderTime = reader["OrderTime"].ToString();
                    CS.ChefOrderDone = reader["ChefOrderDone"].ToString();
                    CS.CustomerRecievedTime = reader["CustomerRecieved"].ToString();
                    CS.Date = reader["Date"].ToString();
                    CS.Payment = reader["Payment"].ToString();

                    list.Add(CS);
                }

                dataGridView1.DataSource = list;
            }
            else
            {
                MessageBox.Show("There is No Data");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Clear All Order" || textBox1.Text == "clear all order") 
            {
                button7.Visible = true;
            }
            else
            {

                button7.Visible = false;
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
                connection.Open();
                string sq1 = "SELECT * FROM CustomerOrders WHERE TableNo LIKE '" + textBox1.Text + "%'  ";

                SqlCommand command = new SqlCommand(sq1, connection);
                SqlDataReader reader = command.ExecuteReader();
                List<CustomerOrders> list = new List<CustomerOrders>();
                while (reader.Read())
                {
                    CustomerOrders CS = new CustomerOrders();

                    CS.Id = (int)reader["Id"];
                    CS.CustomerName = reader["CustomerName"].ToString();
                    CS.TableNo = (int)reader["TableNo"];

                    CS.Price = reader["Price"].ToString();
                    CS.OrderTime = reader["OrderTime"].ToString();
                    CS.ChefOrderDone = reader["ChefOrderDone"].ToString();
                    CS.CustomerRecievedTime = reader["CustomerRecieved"].ToString();
                    CS.Date = reader["Date"].ToString();
                    CS.Payment = reader["Payment"].ToString();


                    list.Add(CS);
                }
                dataGridView1.DataSource = list;

                connection.Close();
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {

                    if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "" && dataGridView1.Rows[i].Cells[7].Value.ToString() == "")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                    if (dataGridView1.Rows[i].Cells[6].Value.ToString() != "" && dataGridView1.Rows[i].Cells[7].Value.ToString() == "")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    if (dataGridView1.Rows[i].Cells[6].Value.ToString() != "" && dataGridView1.Rows[i].Cells[7].Value.ToString() != "")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "Cancel")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkBlue;
                    }
                }
            }
        }
        public string movie;
        public string kidmovie;
        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = movie;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = kidmovie;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            Movies.Visible = true;
            button11.Visible = true;
            Kidmovies.Visible = false;
            button12.Visible = false;
            button14.Visible = false;
        }
        public string abc;
        public string abc2;
        private void button11_Click(object sender, EventArgs e)
        {
           
            string img;
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "mkv files(*.mkv)|*.mkv| mp4 files(*.mp4)|*.mp4| All files(*.*)|*.*";
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
                    Movies.Text = img;
                    axWindowsMediaPlayer1.URL = img;
                    Kidmovies.Visible = true;
                    button12.Visible = true;


                }

            }
            catch (Exception)
            {
                MessageBox.Show("An ERROR Occured");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
           
            string img;
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "mkv files(*.mkv)|*.mkv| mp4 files(*.mp4)|*.mp4| All files(*.*)|*.*";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    img = ofd.FileName;
                    if (img != "")
                    {
                        abc2 = img;
                    }
                    else
                    {
                        abc2 = string.Empty;
                    }
                    Movies.Text = img;
                    axWindowsMediaPlayer1.URL = img;
                    button14.Visible = true;


                }

            }
            catch (Exception)
            {
                MessageBox.Show("An ERROR Occured");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Movie"].ConnectionString);
            connection.Open();
            string sql = "UPDATE Movie SET Movie='" + abc + "',KidsMovie='" + abc2+ "'WHERE Id=1";
            SqlCommand command = new SqlCommand(sql, connection);
            int diary = command.ExecuteNonQuery();

            if (diary > 0)
            {
                MessageBox.Show("Movie Updated");
                Movies.Visible = false;
                button11.Visible = false;
                Kidmovies.Visible = false;
                button12.Visible = false;
                button14.Visible = false;
                label3.Visible = false;
                Movies.Text = "Movie";
                Kidmovies.Text = "Kids Movie";

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            timer1.Enabled = false;
            label4.Visible = label5.Visible = label7.Visible =label8.Visible= false;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Movies.Visible = false;
            button11.Visible = false;
            Kidmovies.Visible = false;
            button12.Visible = false;
            button14.Visible = false;
            panel1.Visible = false;
            label4.Visible = label5.Visible = label7.Visible= label8.Visible = true ;
            axWindowsMediaPlayer1.URL = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void icon_menu_Click(object sender, EventArgs e)
        {

        }

        private void icon_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void icon_restore_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void icon_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void icon_restore_Click_1(object sender, EventArgs e)
        {
            
            if (Size == new Size(1920, 1080))
            {
                Size = new Size(1280, 720);
                this.StartPosition = FormStartPosition.CenterScreen;
                this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            }
            else
            {
                Size = new Size(1920, 1080);
               
                this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 20);
            }
        }
    }
}
