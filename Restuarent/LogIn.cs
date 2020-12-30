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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Signinbutton_Click(object sender, EventArgs e)
        {
            if(Namebox.Text=="Customer" && PasswordBox.Text=="Customer")
            {
                Customer cm = new Customer();
                cm.Show();
                this.Hide();
            }
            else if(Namebox.Text=="Manager" && PasswordBox.Text=="Manager")
            {
                Manager mg = new Manager();
                mg.Show();
                this.Hide();
            }
            else if(Namebox.Text=="Chef"&& PasswordBox.Text=="Chef")
            {
                Chef cf = new Chef();
                cf.Show();
                this.Hide();
            }
        }
    }
}
