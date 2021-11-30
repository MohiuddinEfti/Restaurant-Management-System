using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restuarent
{
    public partial class TableNo : Form
    {
        public TableNo()
        {
            InitializeComponent();
        }

        private void TableNo_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            label2.Visible = false;
            loading.Enabled = false;
            panel1.Visible = panel2.Visible = false;
            for (int i = 1; i <= 30; i += 1)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="")
            {
                MessageBox.Show("Please Select A table number");

            }
            else
            {
                label2.Visible = true;
                panel1.Visible = panel2.Visible = true;
                loading.Enabled = true;

            }
            
        }

        private void TableNo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 5;
            if(panel2.Width>=1166)
            {
                loading.Enabled=false;
                Customer cm = new Customer(Int32.Parse(comboBox1.Text));
                cm.Show();
                this.Hide();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text!="")
            {
                label2.Visible = true;
            }
        }
    }
}
