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
    public partial class CheckAttendance : Form
    {
        public string names;
        public string positions;
        public CheckAttendance(string a,string b)
        {
            InitializeComponent();
            names = a;
            positions = b;
        }

        private void CheckAttendance_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            icon_restore.Visible = true; 
            dataGridView1.ReadOnly = true;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Attendance"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM Attendance";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<AttendanceAdd> list = new List<AttendanceAdd>();
            while (reader.Read())
            {
                AttendanceAdd CS = new AttendanceAdd();

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (positions == "admin")
            {
                Admin ad = new Admin("admin", "admin");
                ad.Show();
                this.Hide();
            }
            else if (positions == "Manager")
            {
                Manager mg = new Manager(names, positions);
                mg.Show();
                this.Hide();
            }
        }

        private void CheckAttendance_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
    }
}
