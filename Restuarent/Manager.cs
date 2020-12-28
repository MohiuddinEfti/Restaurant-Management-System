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
    public partial class Manager : Form
    {
        int Id;

        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            AddEmployee AE = new AddEmployee();
            AE.Show();
            this.Hide();
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}
