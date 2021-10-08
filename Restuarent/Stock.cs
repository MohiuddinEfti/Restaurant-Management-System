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
                button1.Location = new System.Drawing.Point(570, 516);
                DeleteButton.Location = new System.Drawing.Point(738, 516);
            }
            else
            { 
                AddStockButton.Visible = false; 
                button1.Location = new System.Drawing.Point(506, 516);
                DeleteButton.Location = new System.Drawing.Point(674, 516);
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


                        chicken = reader2s["Chicken"].ToString();
                        if(chicken=="")
                        {
                            chicken = "0";
                        }
                        beef = reader2s["Beef"].ToString();
                        if (beef == "")
                        {
                            beef = "0";
                        }
                        cheese = reader2s["Cheese"].ToString();
                        if (cheese == "")
                        {
                            cheese = "0";
                        }
                        flour = reader2s["Flour"].ToString();
                        if (flour == "")
                        {
                            flour = "0";
                        }
                        milk = reader2s["Milk"].ToString();
                        if (milk == "")
                        {
                            milk = "0";
                        }
                        chocolate = reader2s["Chocolate"].ToString();
                        if (chocolate == "")
                        {
                            chocolate = "0";
                        }
                        coke = reader2s["Coke"].ToString();
                        if (coke == "")
                        {
                            coke = "0";
                        }
                        tomato = reader2s["Tomato"].ToString();
                        if (tomato == "")
                        {
                            tomato = "0";
                        }
                        salt = reader2s["Salt"].ToString();
                        if (salt == "")
                        {
                            salt = "0";
                        }




                    }
                    if (ChickenTextBox.Text == "")
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
                    int ae = (Int32.Parse(chicken) - Int32.Parse(ChickenTextBox.Text));
                    string a = ae.ToString();
                    int be = Int32.Parse(beef) - Int32.Parse(BeefTextBox.Text);
                    string b = be.ToString();
                    int ce = Int32.Parse(cheese) - Int32.Parse(CheeseTextBox.Text);
                    string c = ce.ToString();
                    int de = Int32.Parse(flour) - Int32.Parse(FlourTextBox.Text);
                    string d = de.ToString();
                    int efe = Int32.Parse(milk) - Int32.Parse(MilkTextBox.Text);
                    string ef = efe.ToString();
                    int fe = Int32.Parse(chocolate) - Int32.Parse(ChocolateTextBox.Text);
                    string f = fe.ToString();
                    int ge = Int32.Parse(coke) - Int32.Parse(CokeTextBox.Text);
                    string g = ge.ToString();
                    int he = Int32.Parse(tomato) - Int32.Parse(TomatoTextBox.Text);
                    string h = he.ToString();
                    int ie = Int32.Parse(salt) - Int32.Parse(SaltTextBox.Text);
                    string i = ie.ToString();
                    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Stock"].ConnectionString);
                    connection.Open();
                   

                    string sq3 = "UPDATE Stock SET Chicken='" + a + "',Beef='" + b + "',Cheese='" + c + "',Flour='" + d + "',Milk='" + ef + "',Chocolate='" + f + "',Coke='" + g + "',Tomato='" + h + "', Salt='" + i + "',UpdateDate='" + addtime + "' WHERE ID='" + ID + "'";


                    SqlCommand command3 = new SqlCommand(sq3, connection);


                    int diary3 = command3.ExecuteNonQuery();


                    if (diary3 > 0)
                    {
                        MessageBox.Show("Stock is Updated!!");

                        ChickenTextBox.Text = BeefTextBox.Text = CheeseTextBox.Text = FlourTextBox.Text = MilkTextBox.Text = ChocolateTextBox.Text = CokeTextBox.Text = TomatoTextBox.Text = SaltTextBox.Text = string.Empty;

                        string sq4 = "SELECT * FROM Stock";
                        SqlCommand command1 = new SqlCommand(sq4, connection);
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
                        MessageBox.Show("Error Please Select a Row From the table");
                    }

                }
            }
            
            else
            { 
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Stock"].ConnectionString);
                connection.Open();

                string sq3 = "UPDATE Stock SET Chicken='" + ChickenTextBox.Text + "',Beef='" + BeefTextBox.Text + "',Cheese='" + CheeseTextBox.Text + "',Flour='" + FlourTextBox.Text + "',Milk='" + MilkTextBox.Text + "',Chocolate='" + ChocolateTextBox.Text + "',Coke='" + CokeTextBox.Text + "',Tomato='" + TomatoTextBox.Text + "', Salt='" + SaltTextBox.Text + "',UpdateDate='" + addtime + "' WHERE ID='" + ID + "'";


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
            if (Position == "Chef")
            {
                ChickenTextBox.Text =
                     BeefTextBox.Text =
                     CheeseTextBox.Text =
                     FlourTextBox.Text =
                     MilkTextBox.Text =
                      ChocolateTextBox.Text =
                       CokeTextBox.Text =
                       TomatoTextBox.Text =
                        SaltTextBox.Text = String.Empty;
            }
            else
            {
                ChickenTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                BeefTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                CheeseTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                FlourTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                MilkTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                ChocolateTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                CokeTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                TomatoTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                SaltTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
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
            if (System.Text.RegularExpressions.Regex.IsMatch(BeefTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                BeefTextBox.Text = String.Empty;
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

        private void CheeseTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(CheeseTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                CheeseTextBox.Text = String.Empty;
            }
        }

        private void FlourTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(FlourTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                FlourTextBox.Text = String.Empty;
            }
        }

        private void MilkTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(MilkTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                MilkTextBox.Text = String.Empty;
            }
        }

        private void ChocolateTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ChocolateTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                ChocolateTextBox.Text = String.Empty;
            }
        }

        private void CokeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(CokeTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                CokeTextBox.Text = String.Empty;
            }
        }

        private void TomatoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TomatoTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                TomatoTextBox.Text = String.Empty;
            }
        }

        private void SaltTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(SaltTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                SaltTextBox.Text = String.Empty;
            }
        }
    }
}
