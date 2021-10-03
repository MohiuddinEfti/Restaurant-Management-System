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
        public string names;
        public string positions;
        public string ManagerPos;
        
        
        public AddEmployee(string a ,string b)
        {
            InitializeComponent();
            names = a;
            positions = b;

            if(positions=="Manager")
            {
                AddEmployeeButton.Visible = false;
                button2.Visible = false;
            }
            else if(positions=="admin")
            {
                AddEmployeeButton.Visible = true;
                button2.Visible = true;
            }
            
        }
        
        private void AddEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            string mycombo = comboBox2.Text;
            SqlConnection connections = new SqlConnection(ConfigurationManager.ConnectionStrings["Employee"].ConnectionString);


            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE EmpID = '" + textBox2.Text + "'", connections);



            connections.Open();


            SqlDataReader sdr = cmd.ExecuteReader();
            if ((sdr.Read() == false))
            { 
                SqlConnection connections1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Employee"].ConnectionString);
            connections1.Open();
            string sq2s1 = "SELECT * FROM Employee WHERE Position LIKE '" + "Manager" + "%'  ";

            SqlCommand command12 = new SqlCommand(sq2s1, connections1);
            SqlDataReader reader2s = command12.ExecuteReader();

            while (reader2s.Read())
            {


                ManagerPos = reader2s["Position"].ToString();


            }


            connections1.Close();


            if (comboBox2.Text=="")
            {
                MessageBox.Show("ERROR Position is Blank");
            }
            else if (NameTextBox.Text=="")
            {
                MessageBox.Show("ERROR Name is Blank");

            }
            else if(textBox2.Text=="")
            {
                MessageBox.Show("ERROR Employee Id is Blank");

            }
            else if(EmailTextBox.Text=="")
            {
                MessageBox.Show("ERROR Email is Blank");

            }
            else if(Phonetextbox.Text=="")
            {
                MessageBox.Show("ERROR Phone Number is Blank");

            }
            else if(comboBox1.Text=="")
            {
                MessageBox.Show("ERROR Blood Group is Blank");

            }
            else if(Salarytextbox.Text=="")
            {
                MessageBox.Show("ERROR Salary is Blank");

            }
            else if (PasswordtextBox2.Text=="")
            {
                MessageBox.Show("ERROR Password is Blank");

            } 
            else if (ManagerPos == "Manager" && comboBox2.Text=="Manager"&&positions=="Manager")
            {
                MessageBox.Show("Unauthorised\nThere Is Already A Manager\nNew Manager Only Can Be Added By ADMIN");
                textBox2.Text = comboBox2.Text = dateTimePicker1.Text = NameTextBox.Text = EmailTextBox.Text = Phonetextbox.Text = comboBox1.Text = Salarytextbox.Text = PasswordtextBox2.Text = string.Empty;
                pictureBox1.ImageLocation = null;
                
                abc = string.Empty;
            }
            else
            {
               
                    string gen;
                    if (radioButton1.Checked)
                    {
                        gen = "Female";
                    }
                    else
                    {
                        gen = "Male";
                    }

                    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Employee"].ConnectionString);
                    connection.Open();
                    string sq1 = "INSERT INTO Employee(Position,Name,Email,Phone,DateOfBirth,Gender,BloodGroup,Salary,Picture,Password,EmpID) VALUES('" + comboBox2.Text + "','" + NameTextBox.Text + "','" + EmailTextBox.Text + "','" + Phonetextbox.Text + "','" + dateTimePicker1.Text + "','" + gen + "','" + comboBox1.Text + "','" + Int32.Parse(Salarytextbox.Text) + "','" + abc + "','" + PasswordtextBox2.Text + "','" + textBox2.Text + "')";

                    SqlCommand command = new SqlCommand(sq1, connection);
                    int diary = command.ExecuteNonQuery();

                    if (diary > 0)
                    {
                        MessageBox.Show("Employee Added");

                        textBox2.Text = comboBox2.Text = dateTimePicker1.Text = NameTextBox.Text = EmailTextBox.Text = Phonetextbox.Text = comboBox1.Text = Salarytextbox.Text = PasswordtextBox2.Text = string.Empty;
                        pictureBox1.ImageLocation = null;

                        abc = string.Empty;
                        string sq2 = "SELECT * FROM Employee";
                        SqlCommand command1 = new SqlCommand(sq2, connection);
                        SqlDataReader reader2 = command1.ExecuteReader();
                        List<EmployeeAdding> list2 = new List<EmployeeAdding>();
                        while (reader2.Read())
                        {
                            EmployeeAdding CS = new EmployeeAdding();

                            CS.ID = (int)reader2["Id"];
                            CS.Position = reader2["Position"].ToString();
                            CS.Name = reader2["Name"].ToString();
                            CS.EmployeeID = reader2["EmpID"].ToString();
                            CS.Email = reader2["Email"].ToString();
                            CS.Phone = reader2["Phone"].ToString();
                            CS.DateOfBirth = reader2["DateOfBirth"].ToString();
                            CS.Gender = reader2["Gender"].ToString();
                            CS.BloodGroup = reader2["BloodGroup"].ToString();
                            CS.Salary = (int)reader2["Salary"];
                            CS.Picture = reader2["Picture"].ToString();
                            CS.Password = reader2["Password"].ToString();
                            list2.Add(CS);
                        }
                        dataGridView1.DataSource = list2;

                    }
                    else
                    {
                        MessageBox.Show("Error");
                        
                    }
                

               
                
               
            }
            }
            else
            {
                MessageBox.Show("Employee ID Already Taken\nPlease Choose Another ID");
                textBox2.Text = String.Empty;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if(positions=="admin")
            {
                Admin ad = new Admin("admin", "admin");
                    ad.Show();
                this.Hide();
            }
            else if(positions=="Manager")
            {
                Manager mg = new Manager(names, positions);
                mg.Show();
                this.Hide();
            }
            
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Employee"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM Employee";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader2 = command.ExecuteReader();
            List<EmployeeAdding> list2 = new List<EmployeeAdding>();
            while (reader2.Read())
            {
                EmployeeAdding CS = new EmployeeAdding();

                CS.ID = (int)reader2["Id"];
                CS.Position = reader2["Position"].ToString();
                CS.Name = reader2["Name"].ToString();
                CS.EmployeeID = reader2["EmpID"].ToString();
                CS.Email = reader2["Email"].ToString();
                CS.Phone = reader2["Phone"].ToString();
                CS.DateOfBirth = reader2["DateOfBirth"].ToString();
                CS.Gender = reader2["Gender"].ToString();
                CS.BloodGroup = reader2["BloodGroup"].ToString();
                CS.Salary = (int)reader2["Salary"];
                CS.Picture = reader2["Picture"].ToString();
                CS.Password = reader2["Password"].ToString();
                list2.Add(CS);
            }
            dataGridView1.DataSource = list2;
        }
        public string abc;
        private void button3_Click(object sender, EventArgs e)
        {
            string img;
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
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

                    pictureBox1.ImageLocation = img;



                }

            }
            catch (Exception)
            {
                MessageBox.Show("An ERROR Occured");
            }
        }
        public int id1;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            id1 = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            NameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            EmailTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Phonetextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            comboBox2.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Salarytextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            textBox2.Text= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ManagerPos == "Manager" && comboBox2.Text == "Manager")
            {
                ManagerPos = string.Empty;
            }
            else if (comboBox2.Text == "Manager" && positions == "Manager")
            {
                MessageBox.Show("Unauthorized\nManager Only can be removed by Admin");
            }
            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Employee"].ConnectionString);
                connection.Open();
                string sql = "DELETE FROM Employee WHERE Id='" + id1 + "' ";


                SqlCommand command = new SqlCommand(sql, connection);
                int diary = command.ExecuteNonQuery();

                if (diary > 0)
                {
                    MessageBox.Show("Employee Deleted");

                    textBox2.Text = comboBox2.Text = dateTimePicker1.Text = NameTextBox.Text = EmailTextBox.Text = Phonetextbox.Text = comboBox1.Text = Salarytextbox.Text = PasswordtextBox2.Text = string.Empty;
                    pictureBox1.ImageLocation = null;

                    abc = string.Empty;
                    string sq2 = "SELECT * FROM Employee";
                    SqlCommand command1 = new SqlCommand(sq2, connection);
                    SqlDataReader reader2 = command1.ExecuteReader();
                    List<EmployeeAdding> list2 = new List<EmployeeAdding>();
                    while (reader2.Read())
                    {
                        EmployeeAdding CS = new EmployeeAdding();

                        CS.ID = (int)reader2["Id"];
                        CS.Position = reader2["Position"].ToString();
                        CS.Name = reader2["Name"].ToString();
                        CS.EmployeeID = reader2["EmpID"].ToString();
                        CS.Email = reader2["Email"].ToString();
                        CS.Phone = reader2["Phone"].ToString();
                        CS.DateOfBirth = reader2["DateOfBirth"].ToString();
                        CS.Gender = reader2["Gender"].ToString();
                        CS.BloodGroup = reader2["BloodGroup"].ToString();
                        CS.Salary = (int)reader2["Salary"];
                        CS.Picture = reader2["Picture"].ToString();
                        CS.Password = reader2["Password"].ToString();
                        list2.Add(CS);
                    }
                    dataGridView1.DataSource = list2;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connections = new SqlConnection(ConfigurationManager.ConnectionStrings["Employee"].ConnectionString);


            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE EmpID = '" + textBox2.Text + "'", connections);



            connections.Open();


            SqlDataReader sdr = cmd.ExecuteReader();
            if ((sdr.Read() == false))
            {
                if (abc == "")
                {
                    pictureBox1.ImageLocation = null;
                    abc = string.Empty;

                }
                else
                {

                    string pic = abc;

                    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Employee"].ConnectionString);

                    connection.Open();

                    string sq3 = "UPDATE Employee SET Name='" + NameTextBox.Text + "',Email='" + EmailTextBox.Text + "',Phone='" + Phonetextbox.Text + "',DateOfBirth='" + dateTimePicker1.Text + "',Picture='" + pic + "',Position='" + comboBox2.Text + "',Salary='" + Salarytextbox.Text + "',EmpID='" + textBox2.Text + "'WHERE Id=" + id1;




                    SqlCommand command3 = new SqlCommand(sq3, connection);



                    int diary3 = command3.ExecuteNonQuery();




                    if (diary3 > 0)
                    {

                        MessageBox.Show("Updated");


                        textBox2.Text = comboBox2.Text = dateTimePicker1.Text = NameTextBox.Text = EmailTextBox.Text = Phonetextbox.Text = comboBox1.Text = Salarytextbox.Text = PasswordtextBox2.Text = string.Empty;

                        pictureBox1.ImageLocation = null;




                        string sq2 = "SELECT * FROM Employee";

                        SqlCommand command1 = new SqlCommand(sq2, connection);

                        SqlDataReader reader2 = command1.ExecuteReader();

                        List<EmployeeAdding> list2 = new List<EmployeeAdding>();

                        while (reader2.Read())

                        {

                            EmployeeAdding CS = new EmployeeAdding();


                            CS.ID = (int)reader2["Id"];

                            CS.Position = reader2["Position"].ToString();

                            CS.Name = reader2["Name"].ToString();

                            CS.EmployeeID = reader2["EmpID"].ToString();

                            CS.Email = reader2["Email"].ToString();

                            CS.Phone = reader2["Phone"].ToString();

                            CS.DateOfBirth = reader2["DateOfBirth"].ToString();

                            CS.Gender = reader2["Gender"].ToString();

                            CS.BloodGroup = reader2["BloodGroup"].ToString();

                            CS.Salary = (int)reader2["Salary"];

                            CS.Picture = reader2["Picture"].ToString();

                            CS.Password = reader2["Password"].ToString();

                            list2.Add(CS);

                        }

                        dataGridView1.DataSource = list2;





                    }

                    connection.Close();
                }

            }
            else
            {
                MessageBox.Show("Employee ID Already Taken\nPlease Choose Another ID");
                textBox2.Text = String.Empty;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Employee"].ConnectionString);
            connection.Open();
            string sq1 = "SELECT * FROM Employee WHERE EmpID LIKE '" + textBox1.Text + "%'  ";

            SqlCommand command1 = new SqlCommand(sq1, connection);
            SqlDataReader reader2 = command1.ExecuteReader();
            List<EmployeeAdding> list2 = new List<EmployeeAdding>();
            while (reader2.Read())
            {
                EmployeeAdding CS = new EmployeeAdding();

                CS.ID = (int)reader2["Id"];
                CS.Position = reader2["Position"].ToString();
                CS.Name = reader2["Name"].ToString();
                CS.EmployeeID = reader2["EmpID"].ToString();
                CS.Email = reader2["Email"].ToString();
                CS.Phone = reader2["Phone"].ToString();
                CS.DateOfBirth = reader2["DateOfBirth"].ToString();
                CS.Gender = reader2["Gender"].ToString();
                CS.BloodGroup = reader2["BloodGroup"].ToString();
                CS.Salary = (int)reader2["Salary"];
                CS.Picture = reader2["Picture"].ToString();
                CS.Password = reader2["Password"].ToString();
                list2.Add(CS);
            }
            dataGridView1.DataSource = list2;

            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.White)
            {
                PasswordtextBox2.PasswordChar = '\0';
                button4.BackColor = Color.Gray;
            }
            else
            {
                PasswordtextBox2.PasswordChar = '*';
                button4.BackColor = Color.White;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
               
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

