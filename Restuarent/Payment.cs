﻿using System;
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
    public partial class Payment: Form
    {
        public Payment(int tbName,int amount)
        {
            
            InitializeComponent();
        }
        
        
        private void Payment_FormClosing(object sender, FormClosingEventArgs e)
        {
            
           
           
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
        
        private void Bkash_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            if(textBox1.Text.Length!=11)
            {

                MessageBox.Show("Phone number must be 11 digits");
            }
        }
    }
}
