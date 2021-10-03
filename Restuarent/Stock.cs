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
            if (Position == "admin")
            {
                AddStockButton.Visible = true;
                DeleteButton.Visible = true;
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
                S.Chicken= reader["Chicken"].ToString();
                S.Beef = reader["Beef"].ToString();
                S.Cheese= reader["Cheese"].ToString();
                S.Flour = reader["Flour"].ToString();
                S.Milk = reader["Milk"].ToString();
                S.Chocolate = reader["Chocolate"].ToString();
                S.Coke = reader["Coke"].ToString();
                S.Tomato = reader["Tomato"].ToString();
                S.Salt = reader["Salt"].ToString();
                S.AddingDate= reader["AddingDate"].ToString();
                S.UpdateDate= reader["UpdateDate"].ToString();

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
            if (ChickenTextBox.Text=="")
            {
                ChickenTextBox.Text = "0";
            }
             if (BeefTextBox.Text == "")
            {
                BeefTextBox.Text = "0";
            }
            if (CheeseTextBox.Text == "")
            {
                CheeseTextBox.Text = "0";
            }
            if (FlourTextBox.Text == "")
            {
                FlourTextBox.Text = "0";
            }
            if (MilkTextBox.Text == "")
            {
                MilkTextBox.Text = "0";
            }
            if (ChocolateTextBox.Text == "")
            {
                ChocolateTextBox.Text = "0";
            }
            if (CokeTextBox.Text == "")
            {
                CokeTextBox.Text = "0";
            }
             if (TomatoTextBox.Text == "")
            {
                TomatoTextBox.Text = "0";
            }
             if (SaltTextBox.Text == "")
            {
                SaltTextBox.Text = "0";
            }
          
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Stock"].ConnectionString);
                connection.Open();
                string sq1 = "INSERT INTO Stock(Chicken,Beef,Cheese,Flour,Milk,Chocolate,Coke,Tomato,Salt,AddingDate) VALUES('" + ChickenTextBox.Text + "','" + BeefTextBox.Text + "','" + CheeseTextBox.Text + "','" + FlourTextBox.Text + "','" + MilkTextBox.Text + "','" + ChocolateTextBox.Text + "','" + CokeTextBox.Text + "','" + TomatoTextBox.Text + "','" + SaltTextBox.Text + "','" +addtime + "')";


                SqlCommand command = new SqlCommand(sq1, connection);
                int diary = command.ExecuteNonQuery();

                if (diary > 0)
                {
                    MessageBox.Show("Stock Added !");

                    ChickenTextBox.Text = BeefTextBox.Text = CheeseTextBox.Text = FlourTextBox.Text = MilkTextBox.Text = ChocolateTextBox.Text = CokeTextBox.Text = TomatoTextBox.Text = SaltTextBox.Text = string.Empty;


                    string sq2 = "SELECT * FROM Stock";
                    SqlCommand command1 = new SqlCommand(sq2, connection);
                    SqlDataReader reader2 = command1.ExecuteReader();
                    List<Stocks> list2 = new List<Stocks>();
                    while (reader2.Read())
                    {
                        Stocks S = new Stocks();

                        S.ID = (int)reader2["ID"];
                        S.Chicken = reader2["Chicken"].ToString();
                        S.Beef = reader2["Beef"].ToString();
                        S.Cheese = reader2["Cheese"].ToString();
                        S.Flour = reader2["Flour"].ToString();
                        S.Milk = reader2["Milk"].ToString();
                        S.Chocolate = reader2["Chocolate"].ToString();
                        S.Coke = reader2["Coke"].ToString();
                        S.Tomato = reader2["Tomato"].ToString();
                        S.Salt = reader2["Salt"].ToString();
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
            
        

        private void button1_Click(object sender, EventArgs e)
        {

            if (ChickenTextBox.Text == "" || BeefTextBox.Text == "" || CheeseTextBox.Text == "" || FlourTextBox.Text == "" || MilkTextBox.Text == "" || ChocolateTextBox.Text == "" || CokeTextBox.Text == "" || TomatoTextBox.Text == "" || SaltTextBox.Text == "")
            {
                MessageBox.Show("Please Fillup All the Items");
            }
            else
            { 
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Stock"].ConnectionString);
                connection.Open();

                string sq3 = "UPDATE Stock SET Chicken='" + ChickenTextBox.Text + "',Beef='" + BeefTextBox.Text + "',Cheese='" + CheeseTextBox.Text + "',Flour='" + FlourTextBox.Text + "',Milk='" + MilkTextBox.Text + "',Chocolate='" + ChocolateTextBox.Text + "',Coke='" + CokeTextBox.Text + "',Tomato='" + TomatoTextBox.Text + "', Salt='" + SaltTextBox.Text + "',UpdateDate='" + addtime + "' WHERE ID=7";


                SqlCommand command3 = new SqlCommand(sq3, connection);


                int diary3 = command3.ExecuteNonQuery();


                if (diary3 > 0)
                {
                    MessageBox.Show("Stock is Updated!!");

                    ChickenTextBox.Text = BeefTextBox.Text = CheeseTextBox.Text = FlourTextBox.Text = MilkTextBox.Text = ChocolateTextBox.Text = CokeTextBox.Text = TomatoTextBox.Text = SaltTextBox.Text = string.Empty;

                    string sq2 = "SELECT * FROM Stock";
                    SqlCommand command1 = new SqlCommand(sq2, connection);
                    SqlDataReader reader2 = command1.ExecuteReader();
                    List<Stocks> list2 = new List<Stocks>();
                    while (reader2.Read())
                    {
                        Stocks S = new Stocks();

                        S.ID = (int)reader2["ID"];
                        S.Chicken = reader2["Chicken"].ToString();
                        S.Beef = reader2["Beef"].ToString();
                        S.Cheese = reader2["Cheese"].ToString();
                        S.Flour = reader2["Flour"].ToString();
                        S.Milk = reader2["Milk"].ToString();
                        S.Chocolate = reader2["Chocolate"].ToString();
                        S.Coke = reader2["Coke"].ToString();
                        S.Tomato = reader2["Tomato"].ToString();
                        S.Salt = reader2["Salt"].ToString();
                        S.AddingDate = reader2["AddingDate"].ToString();
                        S.UpdateDate = reader2["UpdateDate"].ToString();



                        list2.Add(S);


                    }
                    dataGridView1.DataSource = list2;

                }
            }
            }
       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            ID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            ChickenTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            BeefTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            CheeseTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            FlourTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            MilkTextBox.Text= dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            ChocolateTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            CokeTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            TomatoTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            SaltTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

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
           
            
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Stock"].ConnectionString);
            connection.Open();
            string sql = "DELETE FROM Stock WHERE ID='" + ID + "' ";


            SqlCommand command = new SqlCommand(sql, connection);
            int diary = command.ExecuteNonQuery();

            if (diary > 0)
            {
                MessageBox.Show("Stock Deleted");

                ChickenTextBox.Text = BeefTextBox.Text = CheeseTextBox.Text = FlourTextBox.Text = MilkTextBox.Text = ChocolateTextBox.Text = CokeTextBox.Text = TomatoTextBox.Text = SaltTextBox.Text = string.Empty;
               
                string sq2 = "SELECT * FROM Stock";
                SqlCommand command1 = new SqlCommand(sq2, connection);
                SqlDataReader reader2 = command1.ExecuteReader();
                List<Stocks> list2 = new List<Stocks>();
                while (reader2.Read())
                {
                    Stocks S = new Stocks();

                    S.ID = (int)reader2["ID"];
                    S.Chicken = reader2["Chicken"].ToString();
                    S.Beef = reader2["Beef"].ToString();
                    S.Cheese = reader2["Cheese"].ToString();
                    S.Flour = reader2["Flour"].ToString();
                    S.Milk = reader2["Milk"].ToString();
                    S.Chocolate = reader2["Chocolate"].ToString();
                    S.Coke = reader2["Coke"].ToString();
                    S.Tomato = reader2["Tomato"].ToString();
                    S.Salt = reader2["Salt"].ToString();
                    S.AddingDate = reader2["AddingDate"].ToString();
                    S.UpdateDate = reader2["UpdateDate"].ToString();



                    list2.Add(S);


                }
                dataGridView1.DataSource = list2;

            }
        }

        private void BeefTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
