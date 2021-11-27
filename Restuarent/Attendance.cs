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
        public string Names;
        public string Empid;
        public string Position;
        public string Present = "Yes";
        public string Date;
        public string picture;
        public Attendance(string n, string e, string p, string pi)
        {
            InitializeComponent();
            Names = n;
            Empid = e;           
            Position = p;
            picture = pi;
            Date = DateTime.Today.ToString("dddd , MMM dd yyyy");
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

                CS.ID = (int)reader["ID"];
                CS.Name = reader["Name"].ToString();
                CS.Position = reader["Position"].ToString();
                CS.Present = reader["Present"].ToString();
                CS.EmployeeID = reader["EmpID"].ToString();
                CS.Date = reader["Date"].ToString();
                CS.Time = reader["Time"].ToString();
                CS.Picture = reader["Picture"].ToString();

                list.Add(CS);
            }
            dataGridView1.DataSource = list;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Attendance"].ConnectionString);


            SqlCommand cmd = new SqlCommand("SELECT * FROM Attendance WHERE Name = '" + Names + "' AND [Date] = '" + Date + "' ", connection);



            connection.Open();


            SqlDataReader sdr = cmd.ExecuteReader();
            if ((sdr.Read() == true))
            {
                
                MessageBox.Show("You Are Already Present " + Names + " Id= " + Empid);
                if (Position == "Manager")
                {
                    Manager mg = new Manager(Names, Position);
                    mg.Show();
                    this.Hide();
                }
                else if (Position == "Chef")
                {
                    Chef cf = new Chef(Names, Position);
                    cf.Show();
                    this.Hide();
                }
                else if (Position == "Admin")
                {
                    Admin ad = new Admin(Names, Position);
                    ad.Show();
                    this.Hide();
                }
                else if (Position == "Waiter")
                {
                    Waiter wt = new Waiter(Names);
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
                string timing = DateTime.Today.ToString("h:mm tt");

                SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Attendance"].ConnectionString);
                connection1.Open();
                string sq1 = "INSERT INTO Attendance(Name,Position,Present,EmpID,Date,Picture,Time) VALUES('" + Names + "','" + Position + "','" + Present + "','" + Empid + "','" + Date + "','" + picture + "','"+timing+"')";

                SqlCommand command = new SqlCommand(sq1, connection1);
                int diary = command.ExecuteNonQuery();

                if (diary > 0)
                {
                    MessageBox.Show("Present, WELCOME " + Names + " ID= " + Empid);


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
                        CS.Time = reader["Time"].ToString();
                        CS.Picture = reader["Picture"].ToString();

                        list.Add(CS);
                    }
                    dataGridView1.DataSource = list;
                    if (Position == "Manager")
                    {
                        Manager mg = new Manager(Names,Position);
                        mg.Show();
                        this.Hide();
                    }
                    else if (Position == "Chef")
                    {
                        Chef cf = new Chef(Names, Position);
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
                        Waiter wt = new Waiter(Names);
                        wt.Show();
                        this.Hide();
                    }

                }

            }


        }

        private void Attendance_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }      

}   

