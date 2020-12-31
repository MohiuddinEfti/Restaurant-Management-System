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
    public partial class Attendance : Form
    {
        public string da;
        public string na;
        public string Name;
        public string Empid;
        public string Position;
        public string Present = "Yes";
        public string Date;
        public string picture;
        public Attendance(string n, string e, string p, string pi)
        {
            InitializeComponent();
            Empid = e;
            Name = n;
            Position = p;
            picture = pi;
            Date = DateTime.Today.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void Attendance_Load(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Attendance"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM Attendance";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<AttendanceAdd> list = new List<AttendanceAdd>();
            while (reader.Read())
            {
                AttendanceAdd CS = new AttendanceAdd();
                da = reader["Date"].ToString();
                na = reader["Name"].ToString();
                CS.ID = (int)reader["Id"];
                CS.Name = reader["Name"].ToString();
                CS.Position = reader["Position"].ToString();
                CS.Present = reader["Present"].ToString();
                CS.EmployeeID = reader["EmpID"].ToString();
                CS.Date = reader["Date"].ToString();
                CS.Picture = reader["Picture"].ToString();

                list.Add(CS);
            }
            dataGridView1.DataSource = list;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Attendance"].ConnectionString);


            SqlCommand cmd = new SqlCommand("SELECT * FROM Attendance WHERE Name = '" + Name + "' AND [Date] = '" + Date + "' ", connection);



            connection.Open();


            SqlDataReader sdr = cmd.ExecuteReader();
            if ((sdr.Read() == true))
            {
                MessageBox.Show("Already Present Welcome " + Name + " Sir Id= " + Empid);
                if (Position == "Manager")
                {
                    Manager mg = new Manager();
                    mg.Show();
                    this.Hide();
                }
                else if (Position == "Chef")
                {
                    Chef cf = new Chef();
                    cf.Show();
                    this.Hide();
                }
                else if (Position == "Waiter")
                {
                    Waiter wt = new Waiter();
                    wt.Show();
                    this.Hide();
                }
                else if(Position == "Cleaner")
                {
                    LogIn lg = new LogIn();
                    lg.Show();
                    this.Hide();
                }
                else if(Position=="Guard")
                {
                    LogIn lg = new LogIn();
                    lg.Show();
                    this.Hide();
                }
            }
            else
            {

                SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Attendance"].ConnectionString);
                connection1.Open();
                string sq1 = "INSERT INTO Attendance(Name,Position,Present,EmpID,Date,Picture) VALUES('" + Name + "','" + Position + "','" + Present + "','" + Empid + "','" + Date + "','" + picture + "')";

                SqlCommand command = new SqlCommand(sq1, connection1);
                int diary = command.ExecuteNonQuery();

                if (diary > 0)
                {
                    MessageBox.Show("Present Welcome " + Name + " Sir " + Empid);


                    string sq2 = "SELECT * FROM Attendance";
                    SqlCommand command2 = new SqlCommand(sq2, connection1);
                    SqlDataReader reader = command2.ExecuteReader();
                    List<AttendanceAdd> list = new List<AttendanceAdd>();
                    while (reader.Read())
                    {
                        AttendanceAdd CS = new AttendanceAdd();

                        CS.ID = (int)reader["ID"];
                        CS.Name = reader["Name"].ToString();
                        CS.Position = reader["Position"].ToString();
                        CS.Present = reader["Present"].ToString();
                        CS.EmployeeID = reader["EmpID"].ToString();
                        CS.Date = reader["Date"].ToString();
                        CS.Picture = reader["Picture"].ToString();

                        list.Add(CS);
                    }
                    dataGridView1.DataSource = list;
                    if (Position == "Manager")
                    {
                        Manager mg = new Manager();
                        mg.Show();
                        this.Hide();
                    }
                    else if (Position == "Chef")
                    {
                        Chef cf = new Chef();
                        cf.Show();
                        this.Hide();
                    }
                    else if (Position == "Cleaner")
                    {
                        LogIn lg = new LogIn();
                        lg.Show();
                        this.Hide();
                    }
                    else if (Position == "Guard")
                    {
                        LogIn lg = new LogIn();
                        lg.Show();
                        this.Hide();
                    }
                    else if (Position == "Waiter")
                    {
                        Waiter wt = new Waiter();
                        wt.Show();
                        this.Hide();
                    }

                }

            }


        }
    }      

}   

