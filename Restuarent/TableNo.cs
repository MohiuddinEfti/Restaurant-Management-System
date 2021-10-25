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
           
            

            for (int i = 1; i <= 10; i += 1)
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
                Customer cm = new Customer(Int32.Parse(comboBox1.Text));
                cm.Show();
                this.Hide();
            }
            
        }
    }
}
