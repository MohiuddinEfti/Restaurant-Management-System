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


    public partial class Stock : Form
    {
        public string addtime = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
        public int ID;
        public string Position;
        public string abc;
        public Stock(string a,string b)
        {
            InitializeComponent();
            Position = a;
            abc = b;
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            icon_restore.Visible = true;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 20);
            dataGridView1.ReadOnly = true;


            if (Position == "Chef")
            {
                button1.Text = "Total Used";
                groupBox1.Text = "Stock Item Used By Chef";
                AddStockButton.Visible = false;
                DeleteButton.Visible = false;
            }
      
            if ( Position == "admin")
            {
                AddStockButton.Visible = true;
                
            }
            else
            { 
                AddStockButton.Visible = false; 
                
                DeleteButton.Visible = false;
            }
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Stock"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM Stock";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Stocks> list = new List<Stocks>();
            while (reader.Read())
            {
                Stocks S = new Stocks();

                S.ID= (int)reader["ID"];
                S.Item_Name = reader["Item_Name"].ToString();
                S.Item_Weight = reader["Item_Weight"].ToString();
                S.AddingDate = reader["AddingDate"].ToString();
                S.UpdateDate = reader["UpdateDate"].ToString();


                list.Add(S);
            }
            dataGridView1.DataSource = list;
        }

        private void Stock_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddStockButton_Click(object sender, EventArgs e)
        {
           
          
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Stock"].ConnectionString);
                connection.Open();
                string sq1 = "INSERT INTO Stock(Item_Name,Item_Weight,AddingDate) VALUES('" + textBox1.Text + "','" + ChickenTextBox.Text + "','" +addtime + "')";


                SqlCommand command = new SqlCommand(sq1, connection);
                int diary = command.ExecuteNonQuery();

                if (diary > 0)
                {
                    MessageBox.Show("Stock Added !");

                    ChickenTextBox.Text = textBox1.Text=  string.Empty;
               

                    string sq2 = "SELECT * FROM Stock";
                    SqlCommand command1 = new SqlCommand(sq2, connection);
                    SqlDataReader reader2 = command1.ExecuteReader();
                    List<Stocks> list2 = new List<Stocks>();
                    while (reader2.Read())
                    {
                        Stocks S = new Stocks();

                    S.ID = (int)reader2["ID"];
                    S.Item_Name = reader2["Item_Name"].ToString();
                    S.Item_Weight = reader2["Item_Weight"].ToString();
                    S.AddingDate = reader2["AddingDate"].ToString();
                    S.UpdateDate = reader2["UpdateDate"].ToString();



                    list2.Add(S);
                    }
                    dataGridView1.DataSource = list2;

                }
                else
                {
                    MessageBox.Show("Error Stock could not be added!!");
                }
            }

        public string chicken;
        public string beef;
        public string cheese;
        public string flour;
        public string milk;
        public string chocolate;
        public string coke;
        public string tomato;
        public string salt;

        private void button1_Click(object sender, EventArgs e)
        {
            if(Position=="Chef")
            {
                if (ID == 0)
                {
                    MessageBox.Show("Please Select a specific row from the table");
                }
                else
                {

                    //ChickenTextBox.Text = BeefTextBox.Text = CheeseTextBox.Text = FlourTextBox.Text = MilkTextBox.Text = ChocolateTextBox.Text = CokeTextBox.Text = TomatoTextBox.Text = SaltTextBox.Text = string.Empty;
                    SqlConnection connectionss = new SqlConnection(ConfigurationManager.ConnectionStrings["Stock"].ConnectionString);
                    connectionss.Open();
                    string sq2 = "SELECT * FROM Stock WHERE ID='" + ID + "'";
                    SqlCommand command1s = new SqlCommand(sq2, connectionss);
                    SqlDataReader reader2s = command1s.ExecuteReader();

                    while (reader2s.Read())
                    {


                        chicken = reader2s["Item_Weight"].ToString();
                        if(chicken=="")
                        {
                            chicken = "0";
                        }
                        

                    }
                    if (ChickenTextBox.Text == "")
                    {
                        ChickenTextBox.Text = "0";
                    }
                    
                    int ae = (Int32.Parse(chicken) - Int32.Parse(ChickenTextBox.Text));
                    string a = ae.ToString();
                    
                    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Stock"].ConnectionString);
                    connection.Open();
                   

                    string sq3 = "UPDATE Stock SET Item_Weight='" + a + "',Item_Name='" + textBox1.Text+ "',UpdateDate='" + addtime + "' WHERE ID='" + ID + "'";


                    SqlCommand command3 = new SqlCommand(sq3, connection);


                    int diary3 = command3.ExecuteNonQuery();


                    if (diary3 > 0)
                    {
                        MessageBox.Show("Stock is Updated!!");

                        ChickenTextBox.Text = textBox1.Text= string.Empty;

                        string sq4 = "SELECT * FROM Stock";
                        SqlCommand command1 = new SqlCommand(sq4, connection);
                        SqlDataReader reader2 = command1.ExecuteReader();
                        List<Stocks> list2 = new List<Stocks>();
                        while (reader2.Read())
                        {
                            Stocks S = new Stocks();

                            S.ID = (int)reader2["ID"];
                            S.Item_Name = reader2["Item_Name"].ToString();
                            S.Item_Weight = reader2["Item_Weight"].ToString();
                            S.AddingDate = reader2["AddingDate"].ToString();
                            S.UpdateDate = reader2["UpdateDate"].ToString();



                            list2.Add(S);


                        }
                        dataGridView1.DataSource = list2;

                    }
                    else
                    {
                        MessageBox.Show("Error Please Select a Row From the table");
                    }

                }
            }
            
            else
            { 
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Stock"].ConnectionString);
                connection.Open();

                string sq3 = "UPDATE Stock SET Item_Weight='" + ChickenTextBox.Text + "',Item_Name='" + textBox1.Text + "',UpdateDate='" + addtime + "' WHERE ID='" + ID + "'";


                SqlCommand command3 = new SqlCommand(sq3, connection);


                int diary3 = command3.ExecuteNonQuery();


                if (diary3 > 0)
                {
                    MessageBox.Show("Stock is Updated!!");

                    ChickenTextBox.Text = string.Empty;

                    string sq2 = "SELECT * FROM Stock";
                    SqlCommand command1 = new SqlCommand(sq2, connection);
                    SqlDataReader reader2 = command1.ExecuteReader();
                    List<Stocks> list2 = new List<Stocks>();
                    while (reader2.Read())
                    {
                        Stocks S = new Stocks();


                        S.ID = (int)reader2["ID"];
                        S.Item_Name = reader2["Item_Name"].ToString();
                        S.Item_Weight = reader2["Item_Weight"].ToString();
                        S.AddingDate = reader2["AddingDate"].ToString();
                        S.UpdateDate = reader2["UpdateDate"].ToString();



                        list2.Add(S);


                    }
                    dataGridView1.DataSource = list2;

                }
                else
                {
                    MessageBox.Show("Error Please Select a Row From the table");
                }
            }
            }
       

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            ID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            textBox1.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            if (Position == "Chef")
            {
                ChickenTextBox.Text = String.Empty;
            }
            else
            {
                ChickenTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
               
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (Position == "Chef")
            {
                Chef cf = new Chef(abc, Position);
                cf.Show();
                this.Hide();
            }
            else if(abc=="admin")
            {
                Admin ad = new Admin(Position, abc);
                ad.Show();
                this.Hide();
            }
            else if(abc=="Manager")
            {
                Manager mg = new Manager(Position, abc);
                mg.Show();
                this.Hide();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("Please Select a specific row from the table");
            }
            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Stock"].ConnectionString);
                connection.Open();
                string sql = "DELETE FROM Stock WHERE ID='" + ID + "' ";


                SqlCommand command = new SqlCommand(sql, connection);
                int diary = command.ExecuteNonQuery();

                if (diary > 0)
                {
                    MessageBox.Show("Stock Deleted");

                    ChickenTextBox.Text = textBox1.Text = string.Empty;

                    string sq2 = "SELECT * FROM Stock";
                    SqlCommand command1 = new SqlCommand(sq2, connection);
                    SqlDataReader reader2 = command1.ExecuteReader();
                    List<Stocks> list2 = new List<Stocks>();
                    while (reader2.Read())
                    {
                        Stocks S = new Stocks();


                        S.ID = (int)reader2["ID"];
                        S.Item_Name = reader2["Item_Name"].ToString();
                        S.Item_Weight = reader2["Item_Weight"].ToString();
                        S.AddingDate = reader2["AddingDate"].ToString();
                        S.UpdateDate = reader2["UpdateDate"].ToString();



                        list2.Add(S);


                    }
                    dataGridView1.DataSource = list2;

                }
            }
        }

        

        private void ChickenTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ChickenTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                ChickenTextBox.Text = String.Empty;
            }
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
                this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 20);
            }
        }

        private void icon_close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            ID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            if (Position == "Chef")
            {
                ChickenTextBox.Text = String.Empty;
            }
            else
            {
                ChickenTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            }
        }
    }
}
