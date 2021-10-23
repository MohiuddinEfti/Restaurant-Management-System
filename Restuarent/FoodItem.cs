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
    public partial class FoodItem : Form
    {
        public int powerid;


        public string realname1;
        public int realID;

        
        public string abc;

        public FoodItem()
        {
            InitializeComponent();
        }

        private void FoodItem_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
        List<int> slist = new List<int>();
        List<string> add = new List<string>();
        List<string> pics = new List<string>();
        List<int> prices = new List<int>();
        List<string> names = new List<string>();
        public void FoodItem_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            groupbox1.Visible = false;
            Namelab1.Visible = false;
            Pricelab1.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            Update1.Visible = false;
            comboBox1.Visible = false;
            label2.Visible = false;
            SqlConnection connection55 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection55.Open();
            string sql55 = "SELECT * FROM Food WHERE FoodStatus IS NOT NULL";
            SqlCommand command55 = new SqlCommand(sql55, connection55);
            SqlDataReader reader55 = command55.ExecuteReader();
            List<Foodlist> list = new List<Foodlist>();
            while (reader55.Read())
            {
                Foodlist CS = new Foodlist();

                CS.Id = (int)reader55["Id"];
                
                CS.Food_Name = reader55["FoodName"].ToString();
                CS.Food_Type = reader55["FoodType"].ToString();
                CS.Food_Status = reader55["FoodStatus"].ToString();
                slist.Add((int)reader55["Id"]);
                realID = slist[slist.Count - 1];

                list.Add(CS);
              

            }
            dataGridView1.DataSource = list;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {

                if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "not")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
            SqlConnection connection555 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection555.Open();
            string sql555 = "SELECT * FROM Food";
            SqlCommand command555 = new SqlCommand(sql555, connection555);
            SqlDataReader reader555 = command555.ExecuteReader();
           
            while (reader555.Read())
            {
                
                add.Add((string)reader555["Added"]);

                prices.Add((int)reader555["FoodPrice"]);
                pics.Add(reader555["FoodPic"].ToString());
                names.Add(reader555["FoodName"].ToString());

            }
            connection555.Close();

            if (add.ElementAt(0) == "added")
            {
                panel1.Visible = true;
                pictureBox1.ImageLocation = pics.ElementAt(0);
                button1.Text = "Update " + names.ElementAt(0);
                textBox1.Text = names.ElementAt(0) + " " + prices.ElementAt(0) + " tk";
            }
            else if(add.ElementAt(0) == "not")
            {
                panel1.Visible = false;
            }

            if (add.ElementAt(1) == "added")
            {
                panel2.Visible = true;
                pictureBox2.ImageLocation = pics.ElementAt(1);
                button2.Text = "Update " + names.ElementAt(1);
                textBox2.Text = names.ElementAt(1) + " " + prices.ElementAt(1) + " tk";
            }
            else if (add.ElementAt(1) == "not")
            {
                panel2.Visible = false;
            }

            if (add.ElementAt(2) == "added")
            {
                panel3.Visible = true;
                pictureBox3.ImageLocation = pics.ElementAt(2);
                button3.Text = "Update " + names.ElementAt(2);
                textBox3.Text = names.ElementAt(2) + " " + prices.ElementAt(2) + " tk";
            }
            else if (add.ElementAt(2) == "not")
            {
                panel3.Visible = false;
            }
            if (add.ElementAt(3) == "added")
            {
                panel4.Visible = true;
                pictureBox4.ImageLocation = pics.ElementAt(3);
                button4.Text = "Update " + names.ElementAt(3);
                textBox4.Text = names.ElementAt(3) + " " + prices.ElementAt(3) + " tk";
            }
            else if (add.ElementAt(3) == "not")
            {
                panel4.Visible = false;
            }
            if (add.ElementAt(4) == "added")
            {
                panel5.Visible = true;
                pictureBox5.ImageLocation = pics.ElementAt(4);
                button5.Text = "Update " + names.ElementAt(4);
                textBox5.Text = names.ElementAt(4) + " " + prices.ElementAt(4) + " tk";
            }
            else if (add.ElementAt(4) == "not")
            {
                panel5.Visible = false;
            }

            if (add.ElementAt(5) == "added")
            {
                panel6.Visible = true;
                pictureBox6.ImageLocation = pics.ElementAt(5);
                button6.Text = "Update " + names.ElementAt(5);
                textBox6.Text = names.ElementAt(5) + " " + prices.ElementAt(5) + " tk";
            }
            else if (add.ElementAt(5) == "not")
            {
                panel6.Visible = false;
            }

            if (add.ElementAt(6) == "added")
            {
                panel7.Visible = true;
                pictureBox7.ImageLocation = pics.ElementAt(6);
                button7.Text = "Update " + names.ElementAt(6);
                textBox7.Text = names.ElementAt(6) + " " + prices.ElementAt(6) + " tk";
            }
            else if (add.ElementAt(6) == "not")
            {
                panel7.Visible = false;
            }

            if (add.ElementAt(7) == "added")
            {
                panel8.Visible = true;
                pictureBox8.ImageLocation = pics.ElementAt(7);
                button8.Text = "Update " + names.ElementAt(7);
                textBox8.Text = names.ElementAt(7) + " " + prices.ElementAt(7) + " tk";
            }
            else if (add.ElementAt(6) == "not")
            {
                panel8.Visible = false;
            }

            if (add.ElementAt(8)=="added")
            {
                panel9.Visible = true;
                
                pictureBox10.ImageLocation = pics.ElementAt(8);
                button12.Text = "Update " + names.ElementAt(8);
                textBox11.Text = names.ElementAt(8) + " " + prices.ElementAt(8) + " tk";
            }
            else if(add.ElementAt(8) == "not")
            {
                panel9.Visible = false;
            }

           
            if (add.ElementAt(9) == "added")
            {
                panel10.Visible = true;
                
                pictureBox11.ImageLocation = pics.ElementAt(9);
                button13.Text = "Update " + names.ElementAt(9);
                textBox12.Text = names.ElementAt(9) + " " + prices.ElementAt(9) + " tk";
            }
            else if (add.ElementAt(9) == "not")
            {
                panel10.Visible = false;
            }

            panel11.Visible = false;
            if (add.ElementAt(10) == "added")
            {
                panel11.Visible = true;
                
                pictureBox12.ImageLocation = pics.ElementAt(10);
                button14.Text = "Update " + names.ElementAt(10);
                textBox13.Text = names.ElementAt(10) + " " + prices.ElementAt(10) + " tk";
            }
            else if (add.ElementAt(10) == "not")
            {
                panel11.Visible = false;
            }

            panel12.Visible = false;
            if (add.ElementAt(11) == "added")
            {
                panel12.Visible = true;

                pictureBox13.ImageLocation = pics.ElementAt(11);
                button15.Text = "Update " + names.ElementAt(11);
                textBox14.Text = names.ElementAt(11) + " " + prices.ElementAt(11) + " tk";
            }
            else if (add.ElementAt(11) == "not")
            {
                panel12.Visible = false;
            }

            panel13.Visible = false;
            if (add.ElementAt(12) == "added")
            {
                panel13.Visible = true;
                
                pictureBox14.ImageLocation = pics.ElementAt(12);
                button16.Text = "Update " + names.ElementAt(12);
                textBox15.Text = names.ElementAt(12) + " " + prices.ElementAt(12) + " tk";
            }
            else if (add.ElementAt(12) == "not")
            {
                panel13.Visible = false;
            }

            panel14.Visible = false;
            if (add.ElementAt(13) == "added" )
            {
                panel14.Visible = true;
               
                pictureBox15.ImageLocation = pics.ElementAt(13);
                button17.Text = "Update " + names.ElementAt(13);
                textBox16.Text = names.ElementAt(13) + " " + prices.ElementAt(13) + " tk";
            }
            else if (add.ElementAt(13) == "not")
            {
                panel14.Visible = false;
            }

            panel15.Visible = false;
            if (add.ElementAt(14) == "added")
            {
                panel15.Visible = true;
               
                pictureBox16.ImageLocation = pics.ElementAt(14);
                button18.Text = "Update " + names.ElementAt(14);
                textBox17.Text = names.ElementAt(14) + " " + prices.ElementAt(14) + " tk";
            }
            else if (add.ElementAt(14) == "not")
            {
                panel15.Visible = false;
            }

            panel16.Visible = false;
            if (add.ElementAt(15) == "added")
            {
                panel16.Visible = true;
                
                pictureBox17.ImageLocation = pics.ElementAt(15);
                button19.Text = "Update " + names.ElementAt(15);
                textBox18.Text = names.ElementAt(15) + " " + prices.ElementAt(15) + " tk";
            }
            else if (add.ElementAt(15) == "not")
            {
                panel16.Visible = false;
            }

            panel17.Visible = false;
            if (add.ElementAt(16) == "added")
            {
                panel17.Visible = true;
                
                pictureBox18.ImageLocation = pics.ElementAt(16);
                button20.Text = "Update " + names.ElementAt(16);
                textBox19.Text = names.ElementAt(16) + " " + prices.ElementAt(16) + " tk";
            }
            else if (add.ElementAt(16) == "not")
            {
                panel17.Visible = false;
            }


            panel21.Visible = false;
            if (add.ElementAt(17) == "added")
            {
                panel21.Visible = true;
                
                pictureBox19.ImageLocation = pics.ElementAt(17);
                button21.Text = "Update " + names.ElementAt(17);
                textBox20.Text = names.ElementAt(17) + " " + prices.ElementAt(17) + " tk";
            }
            else if (add.ElementAt(17) == "not")
            {
                panel21.Visible = false;
            }

            panel24.Visible = false;
            if (add.ElementAt(18) == "added")
            {
                panel24.Visible = true;
                
                pictureBox20.ImageLocation = pics.ElementAt(18);
                button22.Text = "Update " + names.ElementAt(18);
                textBox21.Text = names.ElementAt(18) + " " + prices.ElementAt(18) + " tk";
            }
            else if (add.ElementAt(18) == "not")
            {
                panel24.Visible = false;
            }

            panel25.Visible = false;
            if (add.ElementAt(19) == "added")
            {
                panel25.Visible = true;
                
                pictureBox21.ImageLocation = pics.ElementAt(19);
                button23.Text = "Update " + names.ElementAt(19);
                textBox22.Text = names.ElementAt(19) + " " + prices.ElementAt(19) + " tk";
            }
            else if (add.ElementAt(19) == "not")
            {
                panel25.Visible = false;
            }

            panel26.Visible = false;
            if (add.ElementAt(20) == "added")
            {
                panel26.Visible = true;
                
                pictureBox22.ImageLocation = pics.ElementAt(20);
                button24.Text = "Update " + names.ElementAt(20);
                textBox23.Text = names.ElementAt(20) + " " + prices.ElementAt(20) + " tk";
            }
            else if (add.ElementAt(20) == "not")
            {
                panel26.Visible = false;
            }

            panel27.Visible = false;
            if (add.ElementAt(21) == "added")
            {
                panel27.Visible = true;
                
                pictureBox23.ImageLocation = pics.ElementAt(21);
                button25.Text = "Update " + names.ElementAt(21);
                textBox24.Text = names.ElementAt(21) + " " + prices.ElementAt(21) + " tk";
            }
            else if (add.ElementAt(21) == "not")
            {
                panel27.Visible = false;
            }

            panel28.Visible = false;
            if (add.ElementAt(22) == "added")
            {
                panel28.Visible = true;

                pictureBox24.ImageLocation = pics.ElementAt(22);
                button26.Text = "Update " + names.ElementAt(22);
                textBox25.Text = names.ElementAt(22) + " " + prices.ElementAt(22) + " tk";
            }
            else if (add.ElementAt(22) == "not")
            {
                panel28.Visible = false;
            }

            panel32.Visible = false;
            if (add.ElementAt(23) == "added")
            {
                panel32.Visible = true;
                
                pictureBox25.ImageLocation = pics.ElementAt(23);
                button27.Text = "Update " + names.ElementAt(23);
                textBox26.Text = names.ElementAt(23) + " " + prices.ElementAt(23) + " tk";
            }
            else if (add.ElementAt(23) == "not")
            {
                panel32.Visible = false;
            }

            panel33.Visible = false;
            if (add.ElementAt(24) == "added")
            {
                panel33.Visible = true;
                
                pictureBox26.ImageLocation = pics.ElementAt(24);
                button28.Text = "Update " + names.ElementAt(24);
                textBox27.Text = names.ElementAt(24) + " " + prices.ElementAt(24) + " tk";
            }
            else if (add.ElementAt(24) == "not")
            {
                panel33.Visible = false;
            }

            panel34.Visible = false;
            if (add.ElementAt(25) == "added")
            {
                panel34.Visible = true;
                
                pictureBox27.ImageLocation = pics.ElementAt(25);
                button29.Text = "Update " + names.ElementAt(25);
                textBox28.Text = names.ElementAt(25) + " " + prices.ElementAt(25) + " tk";
            }
            else if (add.ElementAt(25) == "not")
            {
                panel34.Visible = false;
            }

            panel35.Visible = false;
            if (add.ElementAt(26) == "added")
            {
                panel35.Visible = true;
                
                pictureBox28.ImageLocation = pics.ElementAt(26);
                button30.Text = "Update " + names.ElementAt(26);
                textBox29.Text = names.ElementAt(26) + " " + prices.ElementAt(26) + " tk";
            }
            else if (add.ElementAt(26) == "not")
            {
                panel35.Visible = false;
            }

            panel36.Visible = false;
            if (add.ElementAt(27) == "added")
            {
                panel36.Visible = true;
                
                pictureBox29.ImageLocation = pics.ElementAt(27);
                button31.Text = "Update " + names.ElementAt(27);
                textBox30.Text = names.ElementAt(27) + " " + prices.ElementAt(27) + " tk";
            }
            else if (add.ElementAt(27) == "not")
            {
                panel36.Visible = false;
            }

            panel37.Visible = false;
            if (add.ElementAt(28) == "added")
            {
                panel37.Visible = true;
                
                pictureBox30.ImageLocation = pics.ElementAt(28);
                button32.Text = "Update " + names.ElementAt(28);
                textBox31.Text = names.ElementAt(28) + " " + prices.ElementAt(28) + " tk";
            }
            else if (add.ElementAt(28) == "not")
            {
                panel37.Visible = false;
            }

            if (add.ElementAt(29) == "added")
            {
                panel19.Visible = true;

                pictureBox31.ImageLocation = pics.ElementAt(29);
                button35.Text = "Update " + names.ElementAt(29);
                textBox33.Text = names.ElementAt(29) + " " + prices.ElementAt(29) + " tk";
            }
            else if (add.ElementAt(29) == "not")
            {
                panel19.Visible = false;
            }
            if (add.ElementAt(30) == "added")
            {
                panel20.Visible = true;

                pictureBox32.ImageLocation = pics.ElementAt(30);
                button36.Text = "Update " + names.ElementAt(30);
                textBox34.Text = names.ElementAt(30) + " " + prices.ElementAt(30) + " tk";
            }
            else if (add.ElementAt(30) == "not")
            {
                panel20.Visible = false;
            }
            if (add.ElementAt(31) == "added")
            {
                panel22.Visible = true;

                pictureBox33.ImageLocation = pics.ElementAt(31);
                button37.Text = "Update " + names.ElementAt(31);
                textBox35.Text = names.ElementAt(31) + " " + prices.ElementAt(31) + " tk";
            }
            else if (add.ElementAt(30) == "not")
            {
                panel22.Visible = false;
            }

            if (add.ElementAt(32) == "added")
            {
                panel23.Visible = true;

                pictureBox34.ImageLocation = pics.ElementAt(32);
                button38.Text = "Update " + names.ElementAt(32);
                textBox36.Text = names.ElementAt(32) + " " + prices.ElementAt(32) + " tk";
            }
            else if (add.ElementAt(30) == "not")
            {
                panel23.Visible = false;
            }
            if (add.ElementAt(33) == "added")
            {
                panel29.Visible = true;

                pictureBox35.ImageLocation = pics.ElementAt(33);
                button39.Text = "Update " + names.ElementAt(33);
                textBox37.Text = names.ElementAt(33) + " " + prices.ElementAt(33) + " tk";
            }
            else if (add.ElementAt(33) == "not")
            {
                panel29.Visible = false;
            }
            if (add.ElementAt(34) == "added")
            {
                panel30.Visible = true;

                pictureBox36.ImageLocation = pics.ElementAt(34);
                button40.Text = "Update " + names.ElementAt(34);
                textBox38.Text = names.ElementAt(34) + " " + prices.ElementAt(34) + " tk";
            }
            else if (add.ElementAt(34) == "not")
            {
                panel30.Visible = false;
            }
            if (add.ElementAt(35) == "added")
            {
                panel31.Visible = true;

                pictureBox37.ImageLocation = pics.ElementAt(35);
                button41.Text = "Update " + names.ElementAt(35);
                textBox39.Text = names.ElementAt(35) + " " + prices.ElementAt(35) + " tk";
            }
            else if (add.ElementAt(35) == "not")
            {
                panel31.Visible = false;
            }

            if (add.ElementAt(36) == "added")
            {
                panel38.Visible = true;

                pictureBox38.ImageLocation = pics.ElementAt(36);
                button42.Text = "Update " + names.ElementAt(36);
                textBox40.Text = names.ElementAt(36) + " " + prices.ElementAt(36) + " tk";
            }
            else if (add.ElementAt(36) == "not")
            {
                panel38.Visible = false;
            }
            if (add.ElementAt(37) == "added")
            {
                panel39.Visible = true;

                pictureBox39.ImageLocation = pics.ElementAt(37);
                button43.Text = "Update " + names.ElementAt(37);
                textBox41.Text = names.ElementAt(37) + " " + prices.ElementAt(37) + " tk";
            }
            else if (add.ElementAt(37) == "not")
            {
                panel39.Visible = false;
            }
            if (add.ElementAt(38) == "added")
            {
                panel40.Visible = true;

                pictureBox40.ImageLocation = pics.ElementAt(38);
                button44.Text = "Update " + names.ElementAt(38);
                textBox42.Text = names.ElementAt(38) + " " + prices.ElementAt(38) + " tk";
            }
            else if (add.ElementAt(38) == "not")
            {
                panel40.Visible = false;
            }
            if (add.ElementAt(39) == "added")
            {
                panel41.Visible = true;

                pictureBox41.ImageLocation = pics.ElementAt(39);
                button45.Text = "Update " + names.ElementAt(39);
                textBox43.Text = names.ElementAt(39) + " " + prices.ElementAt(39) + " tk";
            }
            else if (add.ElementAt(39) == "not")
            {
                panel41.Visible = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox10.Text, "[^0-9]"))
            {
                MessageBox.Show("Price will be in numbers.");
                textBox10.Text = String.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            pictureBox9.ImageLocation = pics.ElementAt(0);
            textBox9.Text = names.ElementAt(0);
            realname1 = names.ElementAt(0);
            textBox10.Text = prices.ElementAt(0).ToString();
            powerid = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Namelab1.Visible = true;
            Pricelab1.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            Update1.Visible = true;
            comboBox1.Visible = true;
            label2.Visible = true;
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

                    pictureBox9.ImageLocation = img;
                   


                }

            }
            catch (Exception)
            {
                MessageBox.Show("An ERROR Occured");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            powerid = 2;
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(1);
            realname1 = names.ElementAt(1);
            textBox10.Text = prices.ElementAt(1).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(2);
            realname1 = names.ElementAt(2);
            textBox10.Text = prices.ElementAt(2).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(2);
            powerid = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(3);
            realname1 = names.ElementAt(3);
            textBox10.Text = prices.ElementAt(3).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(3);
            powerid = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(4);
            realname1 = names.ElementAt(4);
            textBox10.Text = prices.ElementAt(4).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(4);
            powerid = 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(5);
            realname1 = names.ElementAt(5);
            textBox10.Text = prices.ElementAt(5).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(5);
            powerid = 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(6);
            realname1 = names.ElementAt(6);
            textBox10.Text = prices.ElementAt(6).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(6);
            powerid = 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(7);
            realname1 = names.ElementAt(7);
            textBox10.Text = prices.ElementAt(7).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(7);
            powerid = 8;
        }
        
        private void Update1_Click(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                MessageBox.Show("Please Insert Food Name");
            }
            else if (textBox10.Text == "")
            {
                MessageBox.Show("Please Insert Food Price");
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Please Insert Food Type");
            }
            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection.Open();
                string sql = "UPDATE Food SET FoodName='" + textBox9.Text + "',FoodPic='" + pictureBox9.ImageLocation + "',FoodPrice='" + textBox10.Text + "',FoodType='" + comboBox1.Text + "'WHERE Id=" + powerid;
                SqlCommand command = new SqlCommand(sql, connection);
                int diary = command.ExecuteNonQuery();

                if (diary > 0)
                {
                    MessageBox.Show("Updated");
                    label2.Visible = true;
                    textBox9.Text = textBox10.Text = String.Empty;
                    groupbox1.Visible = false;
                    Namelab1.Visible = false;
                    Pricelab1.Visible = false;
                    textBox9.Visible = false;
                    textBox10.Visible = false;
                    Update1.Visible = false;
                    comboBox1.Visible = false;

                    add.Clear();
                    pics.Clear();
                    names.Clear();
                    prices.Clear();
                    SqlConnection connection55 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection55.Open();
                    string sql55 = "SELECT * FROM Food WHERE FoodStatus IS NOT NULL";
                    SqlCommand command55 = new SqlCommand(sql55, connection55);
                    SqlDataReader reader55 = command55.ExecuteReader();
                    List<Foodlist> list = new List<Foodlist>();
                    while (reader55.Read())
                    {
                        Foodlist CS = new Foodlist();

                        CS.Id = (int)reader55["Id"];

                        CS.Food_Name = reader55["FoodName"].ToString();
                        CS.Food_Type = reader55["FoodType"].ToString();
                        CS.Food_Status = reader55["FoodStatus"].ToString();
                        slist.Add((int)reader55["Id"]);
                        realID = slist[slist.Count - 1];

                        list.Add(CS);


                    }
                    dataGridView1.DataSource = list;
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {

                        if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "not")
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        }
                        else
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                    }
                    SqlConnection connection555 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection555.Open();
                    string sql555 = "SELECT * FROM Food";
                    SqlCommand command555 = new SqlCommand(sql555, connection555);
                    SqlDataReader reader555 = command555.ExecuteReader();

                    while (reader555.Read())
                    {

                        add.Add((string)reader555["Added"]);

                        prices.Add((int)reader555["FoodPrice"]);
                        pics.Add(reader555["FoodPic"].ToString());
                        names.Add(reader555["FoodName"].ToString());

                    }
                    connection555.Close();

                    if (add.ElementAt(0) == "added")
                    {
                        panel1.Visible = true;
                        pictureBox1.ImageLocation = pics.ElementAt(0);
                        button1.Text = "Update " + names.ElementAt(0);
                        textBox1.Text = names.ElementAt(0) + " " + prices.ElementAt(0) + " tk";
                    }
                    else if (add.ElementAt(0) == "not")
                    {
                        panel1.Visible = false;
                    }

                    if (add.ElementAt(1) == "added")
                    {
                        panel2.Visible = true;
                        pictureBox2.ImageLocation = pics.ElementAt(1);
                        button2.Text = "Update " + names.ElementAt(1);
                        textBox2.Text = names.ElementAt(1) + " " + prices.ElementAt(1) + " tk";
                    }
                    else if (add.ElementAt(1) == "not")
                    {
                        panel2.Visible = false;
                    }

                    if (add.ElementAt(2) == "added")
                    {
                        panel3.Visible = true;
                        pictureBox3.ImageLocation = pics.ElementAt(2);
                        button3.Text = "Update " + names.ElementAt(2);
                        textBox3.Text = names.ElementAt(2) + " " + prices.ElementAt(2) + " tk";
                    }
                    else if (add.ElementAt(2) == "not")
                    {
                        panel3.Visible = false;
                    }
                    if (add.ElementAt(3) == "added")
                    {
                        panel4.Visible = true;
                        pictureBox4.ImageLocation = pics.ElementAt(3);
                        button4.Text = "Update " + names.ElementAt(3);
                        textBox4.Text = names.ElementAt(3) + " " + prices.ElementAt(3) + " tk";
                    }
                    else if (add.ElementAt(3) == "not")
                    {
                        panel4.Visible = false;
                    }
                    if (add.ElementAt(4) == "added")
                    {
                        panel5.Visible = true;
                        pictureBox5.ImageLocation = pics.ElementAt(4);
                        button5.Text = "Update " + names.ElementAt(4);
                        textBox5.Text = names.ElementAt(4) + " " + prices.ElementAt(4) + " tk";
                    }
                    else if (add.ElementAt(4) == "not")
                    {
                        panel5.Visible = false;
                    }

                    if (add.ElementAt(5) == "added")
                    {
                        panel6.Visible = true;
                        pictureBox6.ImageLocation = pics.ElementAt(5);
                        button6.Text = "Update " + names.ElementAt(5);
                        textBox6.Text = names.ElementAt(5) + " " + prices.ElementAt(5) + " tk";
                    }
                    else if (add.ElementAt(5) == "not")
                    {
                        panel6.Visible = false;
                    }

                    if (add.ElementAt(6) == "added")
                    {
                        panel7.Visible = true;
                        pictureBox7.ImageLocation = pics.ElementAt(6);
                        button7.Text = "Update " + names.ElementAt(6);
                        textBox7.Text = names.ElementAt(6) + " " + prices.ElementAt(6) + " tk";
                    }
                    else if (add.ElementAt(6) == "not")
                    {
                        panel7.Visible = false;
                    }

                    if (add.ElementAt(7) == "added")
                    {
                        panel8.Visible = true;
                        pictureBox8.ImageLocation = pics.ElementAt(7);
                        button8.Text = "Update " + names.ElementAt(7);
                        textBox8.Text = names.ElementAt(7) + " " + prices.ElementAt(7) + " tk";
                    }
                    else if (add.ElementAt(6) == "not")
                    {
                        panel8.Visible = false;
                    }

                    if (add.ElementAt(8) == "added")
                    {
                        panel9.Visible = true;

                        pictureBox10.ImageLocation = pics.ElementAt(8);
                        button12.Text = "Update " + names.ElementAt(8);
                        textBox11.Text = names.ElementAt(8) + " " + prices.ElementAt(8) + " tk";
                    }
                    else if (add.ElementAt(8) == "not")
                    {
                        panel9.Visible = false;
                    }


                    if (add.ElementAt(9) == "added")
                    {
                        panel10.Visible = true;

                        pictureBox11.ImageLocation = pics.ElementAt(9);
                        button13.Text = "Update " + names.ElementAt(9);
                        textBox12.Text = names.ElementAt(9) + " " + prices.ElementAt(9) + " tk";
                    }
                    else if (add.ElementAt(9) == "not")
                    {
                        panel10.Visible = false;
                    }

                    panel11.Visible = false;
                    if (add.ElementAt(10) == "added")
                    {
                        panel11.Visible = true;

                        pictureBox12.ImageLocation = pics.ElementAt(10);
                        button14.Text = "Update " + names.ElementAt(10);
                        textBox13.Text = names.ElementAt(10) + " " + prices.ElementAt(10) + " tk";
                    }
                    else if (add.ElementAt(10) == "not")
                    {
                        panel11.Visible = false;
                    }

                    panel12.Visible = false;
                    if (add.ElementAt(11) == "added")
                    {
                        panel12.Visible = true;

                        pictureBox13.ImageLocation = pics.ElementAt(11);
                        button15.Text = "Update " + names.ElementAt(11);
                        textBox14.Text = names.ElementAt(11) + " " + prices.ElementAt(11) + " tk";
                    }
                    else if (add.ElementAt(11) == "not")
                    {
                        panel12.Visible = false;
                    }

                    panel13.Visible = false;
                    if (add.ElementAt(12) == "added")
                    {
                        panel13.Visible = true;

                        pictureBox14.ImageLocation = pics.ElementAt(12);
                        button16.Text = "Update " + names.ElementAt(12);
                        textBox15.Text = names.ElementAt(12) + " " + prices.ElementAt(12) + " tk";
                    }
                    else if (add.ElementAt(12) == "not")
                    {
                        panel13.Visible = false;
                    }

                    panel14.Visible = false;
                    if (add.ElementAt(13) == "added")
                    {
                        panel14.Visible = true;

                        pictureBox15.ImageLocation = pics.ElementAt(13);
                        button17.Text = "Update " + names.ElementAt(13);
                        textBox16.Text = names.ElementAt(13) + " " + prices.ElementAt(13) + " tk";
                    }
                    else if (add.ElementAt(13) == "not")
                    {
                        panel14.Visible = false;
                    }

                    panel15.Visible = false;
                    if (add.ElementAt(14) == "added")
                    {
                        panel15.Visible = true;

                        pictureBox16.ImageLocation = pics.ElementAt(14);
                        button18.Text = "Update " + names.ElementAt(14);
                        textBox17.Text = names.ElementAt(14) + " " + prices.ElementAt(14) + " tk";
                    }
                    else if (add.ElementAt(14) == "not")
                    {
                        panel15.Visible = false;
                    }

                    panel16.Visible = false;
                    if (add.ElementAt(15) == "added")
                    {
                        panel16.Visible = true;

                        pictureBox17.ImageLocation = pics.ElementAt(15);
                        button19.Text = "Update " + names.ElementAt(15);
                        textBox18.Text = names.ElementAt(15) + " " + prices.ElementAt(15) + " tk";
                    }
                    else if (add.ElementAt(15) == "not")
                    {
                        panel16.Visible = false;
                    }

                    panel17.Visible = false;
                    if (add.ElementAt(16) == "added")
                    {
                        panel17.Visible = true;

                        pictureBox18.ImageLocation = pics.ElementAt(16);
                        button20.Text = "Update " + names.ElementAt(16);
                        textBox19.Text = names.ElementAt(16) + " " + prices.ElementAt(16) + " tk";
                    }
                    else if (add.ElementAt(16) == "not")
                    {
                        panel17.Visible = false;
                    }


                    panel21.Visible = false;
                    if (add.ElementAt(17) == "added")
                    {
                        panel21.Visible = true;

                        pictureBox19.ImageLocation = pics.ElementAt(17);
                        button21.Text = "Update " + names.ElementAt(17);
                        textBox20.Text = names.ElementAt(17) + " " + prices.ElementAt(17) + " tk";
                    }
                    else if (add.ElementAt(17) == "not")
                    {
                        panel21.Visible = false;
                    }

                    panel24.Visible = false;
                    if (add.ElementAt(18) == "added")
                    {
                        panel24.Visible = true;

                        pictureBox20.ImageLocation = pics.ElementAt(18);
                        button22.Text = "Update " + names.ElementAt(18);
                        textBox21.Text = names.ElementAt(18) + " " + prices.ElementAt(18) + " tk";
                    }
                    else if (add.ElementAt(18) == "not")
                    {
                        panel24.Visible = false;
                    }

                    panel25.Visible = false;
                    if (add.ElementAt(19) == "added")
                    {
                        panel25.Visible = true;

                        pictureBox21.ImageLocation = pics.ElementAt(19);
                        button23.Text = "Update " + names.ElementAt(19);
                        textBox22.Text = names.ElementAt(19) + " " + prices.ElementAt(19) + " tk";
                    }
                    else if (add.ElementAt(19) == "not")
                    {
                        panel25.Visible = false;
                    }

                    panel26.Visible = false;
                    if (add.ElementAt(20) == "added")
                    {
                        panel26.Visible = true;

                        pictureBox22.ImageLocation = pics.ElementAt(20);
                        button24.Text = "Update " + names.ElementAt(20);
                        textBox23.Text = names.ElementAt(20) + " " + prices.ElementAt(20) + " tk";
                    }
                    else if (add.ElementAt(20) == "not")
                    {
                        panel26.Visible = false;
                    }

                    panel27.Visible = false;
                    if (add.ElementAt(21) == "added")
                    {
                        panel27.Visible = true;

                        pictureBox23.ImageLocation = pics.ElementAt(21);
                        button25.Text = "Update " + names.ElementAt(21);
                        textBox24.Text = names.ElementAt(21) + " " + prices.ElementAt(21) + " tk";
                    }
                    else if (add.ElementAt(21) == "not")
                    {
                        panel27.Visible = false;
                    }

                    panel28.Visible = false;
                    if (add.ElementAt(22) == "added")
                    {
                        panel28.Visible = true;

                        pictureBox24.ImageLocation = pics.ElementAt(22);
                        button26.Text = "Update " + names.ElementAt(22);
                        textBox25.Text = names.ElementAt(22) + " " + prices.ElementAt(22) + " tk";
                    }
                    else if (add.ElementAt(22) == "not")
                    {
                        panel28.Visible = false;
                    }

                    panel32.Visible = false;
                    if (add.ElementAt(23) == "added")
                    {
                        panel32.Visible = true;

                        pictureBox25.ImageLocation = pics.ElementAt(23);
                        button27.Text = "Update " + names.ElementAt(23);
                        textBox26.Text = names.ElementAt(23) + " " + prices.ElementAt(23) + " tk";
                    }
                    else if (add.ElementAt(23) == "not")
                    {
                        panel32.Visible = false;
                    }

                    panel33.Visible = false;
                    if (add.ElementAt(24) == "added")
                    {
                        panel33.Visible = true;

                        pictureBox26.ImageLocation = pics.ElementAt(24);
                        button28.Text = "Update " + names.ElementAt(24);
                        textBox27.Text = names.ElementAt(24) + " " + prices.ElementAt(24) + " tk";
                    }
                    else if (add.ElementAt(24) == "not")
                    {
                        panel33.Visible = false;
                    }

                    panel34.Visible = false;
                    if (add.ElementAt(25) == "added")
                    {
                        panel34.Visible = true;

                        pictureBox27.ImageLocation = pics.ElementAt(25);
                        button29.Text = "Update " + names.ElementAt(25);
                        textBox28.Text = names.ElementAt(25) + " " + prices.ElementAt(25) + " tk";
                    }
                    else if (add.ElementAt(25) == "not")
                    {
                        panel34.Visible = false;
                    }

                    panel35.Visible = false;
                    if (add.ElementAt(26) == "added")
                    {
                        panel35.Visible = true;

                        pictureBox28.ImageLocation = pics.ElementAt(26);
                        button30.Text = "Update " + names.ElementAt(26);
                        textBox29.Text = names.ElementAt(26) + " " + prices.ElementAt(26) + " tk";
                    }
                    else if (add.ElementAt(26) == "not")
                    {
                        panel35.Visible = false;
                    }

                    panel36.Visible = false;
                    if (add.ElementAt(27) == "added")
                    {
                        panel36.Visible = true;

                        pictureBox29.ImageLocation = pics.ElementAt(27);
                        button31.Text = "Update " + names.ElementAt(27);
                        textBox30.Text = names.ElementAt(27) + " " + prices.ElementAt(27) + " tk";
                    }
                    else if (add.ElementAt(27) == "not")
                    {
                        panel36.Visible = false;
                    }

                    panel37.Visible = false;
                    if (add.ElementAt(28) == "added")
                    {
                        panel37.Visible = true;

                        pictureBox30.ImageLocation = pics.ElementAt(28);
                        button32.Text = "Update " + names.ElementAt(28);
                        textBox31.Text = names.ElementAt(28) + " " + prices.ElementAt(28) + " tk";
                    }
                    else if (add.ElementAt(28) == "not")
                    {
                        panel37.Visible = false;
                    }
                    if (add.ElementAt(29) == "added")
                    {
                        panel19.Visible = true;

                        pictureBox31.ImageLocation = pics.ElementAt(29);
                        button35.Text = "Update " + names.ElementAt(29);
                        textBox33.Text = names.ElementAt(29) + " " + prices.ElementAt(29) + " tk";
                    }
                    else if (add.ElementAt(29) == "not")
                    {
                        panel19.Visible = false;
                    }
                    if (add.ElementAt(30) == "added")
                    {
                        panel20.Visible = true;

                        pictureBox32.ImageLocation = pics.ElementAt(30);
                        button36.Text = "Update " + names.ElementAt(30);
                        textBox34.Text = names.ElementAt(30) + " " + prices.ElementAt(30) + " tk";
                    }
                    else if (add.ElementAt(30) == "not")
                    {
                        panel20.Visible = false;
                    }
                    if (add.ElementAt(31) == "added")
                    {
                        panel22.Visible = true;

                        pictureBox33.ImageLocation = pics.ElementAt(31);
                        button37.Text = "Update " + names.ElementAt(31);
                        textBox35.Text = names.ElementAt(31) + " " + prices.ElementAt(31) + " tk";
                    }
                    else if (add.ElementAt(30) == "not")
                    {
                        panel22.Visible = false;
                    }

                    if (add.ElementAt(32) == "added")
                    {
                        panel23.Visible = true;

                        pictureBox34.ImageLocation = pics.ElementAt(32);
                        button38.Text = "Update " + names.ElementAt(32);
                        textBox36.Text = names.ElementAt(32) + " " + prices.ElementAt(32) + " tk";
                    }
                    else if (add.ElementAt(30) == "not")
                    {
                        panel23.Visible = false;
                    }
                    if (add.ElementAt(33) == "added")
                    {
                        panel29.Visible = true;

                        pictureBox35.ImageLocation = pics.ElementAt(33);
                        button39.Text = "Update " + names.ElementAt(33);
                        textBox37.Text = names.ElementAt(33) + " " + prices.ElementAt(33) + " tk";
                    }
                    else if (add.ElementAt(33) == "not")
                    {
                        panel29.Visible = false;
                    }
                    if (add.ElementAt(34) == "added")
                    {
                        panel30.Visible = true;

                        pictureBox36.ImageLocation = pics.ElementAt(34);
                        button40.Text = "Update " + names.ElementAt(34);
                        textBox38.Text = names.ElementAt(34) + " " + prices.ElementAt(34) + " tk";
                    }
                    else if (add.ElementAt(34) == "not")
                    {
                        panel30.Visible = false;
                    }
                    if (add.ElementAt(35) == "added")
                    {
                        panel31.Visible = true;

                        pictureBox37.ImageLocation = pics.ElementAt(35);
                        button41.Text = "Update " + names.ElementAt(35);
                        textBox39.Text = names.ElementAt(35) + " " + prices.ElementAt(35) + " tk";
                    }
                    else if (add.ElementAt(35) == "not")
                    {
                        panel31.Visible = false;
                    }

                    if (add.ElementAt(36) == "added")
                    {
                        panel38.Visible = true;

                        pictureBox38.ImageLocation = pics.ElementAt(36);
                        button42.Text = "Update " + names.ElementAt(36);
                        textBox40.Text = names.ElementAt(36) + " " + prices.ElementAt(36) + " tk";
                    }
                    else if (add.ElementAt(36) == "not")
                    {
                        panel38.Visible = false;
                    }
                    if (add.ElementAt(37) == "added")
                    {
                        panel39.Visible = true;

                        pictureBox39.ImageLocation = pics.ElementAt(37);
                        button43.Text = "Update " + names.ElementAt(37);
                        textBox41.Text = names.ElementAt(37) + " " + prices.ElementAt(37) + " tk";
                    }
                    else if (add.ElementAt(37) == "not")
                    {
                        panel39.Visible = false;
                    }
                    if (add.ElementAt(38) == "added")
                    {
                        panel40.Visible = true;

                        pictureBox40.ImageLocation = pics.ElementAt(38);
                        button44.Text = "Update " + names.ElementAt(38);
                        textBox42.Text = names.ElementAt(38) + " " + prices.ElementAt(38) + " tk";
                    }
                    else if (add.ElementAt(38) == "not")
                    {
                        panel40.Visible = false;
                    }
                    if (add.ElementAt(39) == "added")
                    {
                        panel41.Visible = true;

                        pictureBox41.ImageLocation = pics.ElementAt(39);
                        button45.Text = "Update " + names.ElementAt(39);
                        textBox43.Text = names.ElementAt(39) + " " + prices.ElementAt(39) + " tk";
                    }
                    else if (add.ElementAt(39) == "not")
                    {
                        panel41.Visible = false;
                    }

                }
                else
                {
                    MessageBox.Show("Error");
                }



            }


        }

        private void button10_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin("admin","admin");
            ad.Show();
            this.Close();
            textBox9.Text = textBox10.Text = String.Empty;
            groupbox1.Visible = false;
            Namelab1.Visible = false;
            Pricelab1.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            Update1.Visible = false;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection.Open();
            int its = realID + 1;
            string sq1 = "UPDATE Food SET FoodStatus='active',Added='added' WHERE Id=" + its;

            SqlCommand command = new SqlCommand(sq1, connection);
            int diary = command.ExecuteNonQuery();

            if (diary > 0)
            {
                MessageBox.Show("Food Added");
                add.Clear();
                pics.Clear();
                names.Clear();
                prices.Clear();
                SqlConnection connection55 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection55.Open();
                string sql55 = "SELECT * FROM Food WHERE FoodStatus IS NOT NULL";
                SqlCommand command55 = new SqlCommand(sql55, connection55);
                SqlDataReader reader55 = command55.ExecuteReader();
                List<Foodlist> list = new List<Foodlist>();
                while (reader55.Read())
                {
                    Foodlist CS = new Foodlist();

                    CS.Id = (int)reader55["Id"];

                    CS.Food_Name = reader55["FoodName"].ToString();
                    CS.Food_Type = reader55["FoodType"].ToString();
                    CS.Food_Status = reader55["FoodStatus"].ToString();
                    slist.Add((int)reader55["Id"]);
                    realID = slist[slist.Count - 1];

                    list.Add(CS);


                }
                dataGridView1.DataSource = list;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {

                    if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "not")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
                SqlConnection connection555 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection555.Open();
                string sql555 = "SELECT * FROM Food";
                SqlCommand command555 = new SqlCommand(sql555, connection555);
                SqlDataReader reader555 = command555.ExecuteReader();

                while (reader555.Read())
                {

                    add.Add((string)reader555["Added"]);

                    prices.Add((int)reader555["FoodPrice"]);
                    pics.Add(reader555["FoodPic"].ToString());
                    names.Add(reader555["FoodName"].ToString());

                }
                connection555.Close();

                if (add.ElementAt(0) == "added")
                {
                    panel1.Visible = true;
                    pictureBox1.ImageLocation = pics.ElementAt(0);
                    button1.Text = "Update " + names.ElementAt(0);
                    textBox1.Text = names.ElementAt(0) + " " + prices.ElementAt(0) + " tk";
                }
                else if (add.ElementAt(0) == "not")
                {
                    panel1.Visible = false;
                }

                if (add.ElementAt(1) == "added")
                {
                    panel2.Visible = true;
                    pictureBox2.ImageLocation = pics.ElementAt(1);
                    button2.Text = "Update " + names.ElementAt(1);
                    textBox2.Text = names.ElementAt(1) + " " + prices.ElementAt(1) + " tk";
                }
                else if (add.ElementAt(1) == "not")
                {
                    panel2.Visible = false;
                }

                if (add.ElementAt(2) == "added")
                {
                    panel3.Visible = true;
                    pictureBox3.ImageLocation = pics.ElementAt(2);
                    button3.Text = "Update " + names.ElementAt(2);
                    textBox3.Text = names.ElementAt(2) + " " + prices.ElementAt(2) + " tk";
                }
                else if (add.ElementAt(2) == "not")
                {
                    panel3.Visible = false;
                }
                if (add.ElementAt(3) == "added")
                {
                    panel4.Visible = true;
                    pictureBox4.ImageLocation = pics.ElementAt(3);
                    button4.Text = "Update " + names.ElementAt(3);
                    textBox4.Text = names.ElementAt(3) + " " + prices.ElementAt(3) + " tk";
                }
                else if (add.ElementAt(3) == "not")
                {
                    panel4.Visible = false;
                }
                if (add.ElementAt(4) == "added")
                {
                    panel5.Visible = true;
                    pictureBox5.ImageLocation = pics.ElementAt(4);
                    button5.Text = "Update " + names.ElementAt(4);
                    textBox5.Text = names.ElementAt(4) + " " + prices.ElementAt(4) + " tk";
                }
                else if (add.ElementAt(4) == "not")
                {
                    panel5.Visible = false;
                }

                if (add.ElementAt(5) == "added")
                {
                    panel6.Visible = true;
                    pictureBox6.ImageLocation = pics.ElementAt(5);
                    button6.Text = "Update " + names.ElementAt(5);
                    textBox6.Text = names.ElementAt(5) + " " + prices.ElementAt(5) + " tk";
                }
                else if (add.ElementAt(5) == "not")
                {
                    panel6.Visible = false;
                }

                if (add.ElementAt(6) == "added")
                {
                    panel7.Visible = true;
                    pictureBox7.ImageLocation = pics.ElementAt(6);
                    button7.Text = "Update " + names.ElementAt(6);
                    textBox7.Text = names.ElementAt(6) + " " + prices.ElementAt(6) + " tk";
                }
                else if (add.ElementAt(6) == "not")
                {
                    panel7.Visible = false;
                }

                if (add.ElementAt(7) == "added")
                {
                    panel8.Visible = true;
                    pictureBox8.ImageLocation = pics.ElementAt(7);
                    button8.Text = "Update " + names.ElementAt(7);
                    textBox8.Text = names.ElementAt(7) + " " + prices.ElementAt(7) + " tk";
                }
                else if (add.ElementAt(6) == "not")
                {
                    panel8.Visible = false;
                }

                if (add.ElementAt(8) == "added")
                {
                    panel9.Visible = true;

                    pictureBox10.ImageLocation = pics.ElementAt(8);
                    button12.Text = "Update " + names.ElementAt(8);
                    textBox11.Text = names.ElementAt(8) + " " + prices.ElementAt(8) + " tk";
                }
                else if (add.ElementAt(8) == "not")
                {
                    panel9.Visible = false;
                }


                if (add.ElementAt(9) == "added")
                {
                    panel10.Visible = true;

                    pictureBox11.ImageLocation = pics.ElementAt(9);
                    button13.Text = "Update " + names.ElementAt(9);
                    textBox12.Text = names.ElementAt(9) + " " + prices.ElementAt(9) + " tk";
                }
                else if (add.ElementAt(9) == "not")
                {
                    panel10.Visible = false;
                }

                panel11.Visible = false;
                if (add.ElementAt(10) == "added")
                {
                    panel11.Visible = true;

                    pictureBox12.ImageLocation = pics.ElementAt(10);
                    button14.Text = "Update " + names.ElementAt(10);
                    textBox13.Text = names.ElementAt(10) + " " + prices.ElementAt(10) + " tk";
                }
                else if (add.ElementAt(10) == "not")
                {
                    panel11.Visible = false;
                }

                panel12.Visible = false;
                if (add.ElementAt(11) == "added")
                {
                    panel12.Visible = true;

                    pictureBox13.ImageLocation = pics.ElementAt(11);
                    button15.Text = "Update " + names.ElementAt(11);
                    textBox14.Text = names.ElementAt(11) + " " + prices.ElementAt(11) + " tk";
                }
                else if (add.ElementAt(11) == "not")
                {
                    panel12.Visible = false;
                }

                panel13.Visible = false;
                if (add.ElementAt(12) == "added")
                {
                    panel13.Visible = true;

                    pictureBox14.ImageLocation = pics.ElementAt(12);
                    button16.Text = "Update " + names.ElementAt(12);
                    textBox15.Text = names.ElementAt(12) + " " + prices.ElementAt(12) + " tk";
                }
                else if (add.ElementAt(12) == "not")
                {
                    panel13.Visible = false;
                }

                panel14.Visible = false;
                if (add.ElementAt(13) == "added")
                {
                    panel14.Visible = true;

                    pictureBox15.ImageLocation = pics.ElementAt(13);
                    button17.Text = "Update " + names.ElementAt(13);
                    textBox16.Text = names.ElementAt(13) + " " + prices.ElementAt(13) + " tk";
                }
                else if (add.ElementAt(13) == "not")
                {
                    panel14.Visible = false;
                }

                panel15.Visible = false;
                if (add.ElementAt(14) == "added")
                {
                    panel15.Visible = true;

                    pictureBox16.ImageLocation = pics.ElementAt(14);
                    button18.Text = "Update " + names.ElementAt(14);
                    textBox17.Text = names.ElementAt(14) + " " + prices.ElementAt(14) + " tk";
                }
                else if (add.ElementAt(14) == "not")
                {
                    panel15.Visible = false;
                }

                panel16.Visible = false;
                if (add.ElementAt(15) == "added")
                {
                    panel16.Visible = true;

                    pictureBox17.ImageLocation = pics.ElementAt(15);
                    button19.Text = "Update " + names.ElementAt(15);
                    textBox18.Text = names.ElementAt(15) + " " + prices.ElementAt(15) + " tk";
                }
                else if (add.ElementAt(15) == "not")
                {
                    panel16.Visible = false;
                }

                panel17.Visible = false;
                if (add.ElementAt(16) == "added")
                {
                    panel17.Visible = true;

                    pictureBox18.ImageLocation = pics.ElementAt(16);
                    button20.Text = "Update " + names.ElementAt(16);
                    textBox19.Text = names.ElementAt(16) + " " + prices.ElementAt(16) + " tk";
                }
                else if (add.ElementAt(16) == "not")
                {
                    panel17.Visible = false;
                }


                panel21.Visible = false;
                if (add.ElementAt(17) == "added")
                {
                    panel21.Visible = true;

                    pictureBox19.ImageLocation = pics.ElementAt(17);
                    button21.Text = "Update " + names.ElementAt(17);
                    textBox20.Text = names.ElementAt(17) + " " + prices.ElementAt(17) + " tk";
                }
                else if (add.ElementAt(17) == "not")
                {
                    panel21.Visible = false;
                }

                panel24.Visible = false;
                if (add.ElementAt(18) == "added")
                {
                    panel24.Visible = true;

                    pictureBox20.ImageLocation = pics.ElementAt(18);
                    button22.Text = "Update " + names.ElementAt(18);
                    textBox21.Text = names.ElementAt(18) + " " + prices.ElementAt(18) + " tk";
                }
                else if (add.ElementAt(18) == "not")
                {
                    panel24.Visible = false;
                }

                panel25.Visible = false;
                if (add.ElementAt(19) == "added")
                {
                    panel25.Visible = true;

                    pictureBox21.ImageLocation = pics.ElementAt(19);
                    button23.Text = "Update " + names.ElementAt(19);
                    textBox22.Text = names.ElementAt(19) + " " + prices.ElementAt(19) + " tk";
                }
                else if (add.ElementAt(19) == "not")
                {
                    panel25.Visible = false;
                }

                panel26.Visible = false;
                if (add.ElementAt(20) == "added")
                {
                    panel26.Visible = true;

                    pictureBox22.ImageLocation = pics.ElementAt(20);
                    button24.Text = "Update " + names.ElementAt(20);
                    textBox23.Text = names.ElementAt(20) + " " + prices.ElementAt(20) + " tk";
                }
                else if (add.ElementAt(20) == "not")
                {
                    panel26.Visible = false;
                }

                panel27.Visible = false;
                if (add.ElementAt(21) == "added")
                {
                    panel27.Visible = true;

                    pictureBox23.ImageLocation = pics.ElementAt(21);
                    button25.Text = "Update " + names.ElementAt(21);
                    textBox24.Text = names.ElementAt(21) + " " + prices.ElementAt(21) + " tk";
                }
                else if (add.ElementAt(21) == "not")
                {
                    panel27.Visible = false;
                }

                panel28.Visible = false;
                if (add.ElementAt(22) == "added")
                {
                    panel28.Visible = true;

                    pictureBox24.ImageLocation = pics.ElementAt(22);
                    button26.Text = "Update " + names.ElementAt(22);
                    textBox25.Text = names.ElementAt(22) + " " + prices.ElementAt(22) + " tk";
                }
                else if (add.ElementAt(22) == "not")
                {
                    panel28.Visible = false;
                }

                panel32.Visible = false;
                if (add.ElementAt(23) == "added")
                {
                    panel32.Visible = true;

                    pictureBox25.ImageLocation = pics.ElementAt(23);
                    button27.Text = "Update " + names.ElementAt(23);
                    textBox26.Text = names.ElementAt(23) + " " + prices.ElementAt(23) + " tk";
                }
                else if (add.ElementAt(23) == "not")
                {
                    panel32.Visible = false;
                }

                panel33.Visible = false;
                if (add.ElementAt(24) == "added")
                {
                    panel33.Visible = true;

                    pictureBox26.ImageLocation = pics.ElementAt(24);
                    button28.Text = "Update " + names.ElementAt(24);
                    textBox27.Text = names.ElementAt(24) + " " + prices.ElementAt(24) + " tk";
                }
                else if (add.ElementAt(24) == "not")
                {
                    panel33.Visible = false;
                }

                panel34.Visible = false;
                if (add.ElementAt(25) == "added")
                {
                    panel34.Visible = true;

                    pictureBox27.ImageLocation = pics.ElementAt(25);
                    button29.Text = "Update " + names.ElementAt(25);
                    textBox28.Text = names.ElementAt(25) + " " + prices.ElementAt(25) + " tk";
                }
                else if (add.ElementAt(25) == "not")
                {
                    panel34.Visible = false;
                }

                panel35.Visible = false;
                if (add.ElementAt(26) == "added")
                {
                    panel35.Visible = true;

                    pictureBox28.ImageLocation = pics.ElementAt(26);
                    button30.Text = "Update " + names.ElementAt(26);
                    textBox29.Text = names.ElementAt(26) + " " + prices.ElementAt(26) + " tk";
                }
                else if (add.ElementAt(26) == "not")
                {
                    panel35.Visible = false;
                }

                panel36.Visible = false;
                if (add.ElementAt(27) == "added")
                {
                    panel36.Visible = true;

                    pictureBox29.ImageLocation = pics.ElementAt(27);
                    button31.Text = "Update " + names.ElementAt(27);
                    textBox30.Text = names.ElementAt(27) + " " + prices.ElementAt(27) + " tk";
                }
                else if (add.ElementAt(27) == "not")
                {
                    panel36.Visible = false;
                }

                panel37.Visible = false;
                if (add.ElementAt(28) == "added")
                {
                    panel37.Visible = true;

                    pictureBox30.ImageLocation = pics.ElementAt(28);
                    button32.Text = "Update " + names.ElementAt(28);
                    textBox31.Text = names.ElementAt(28) + " " + prices.ElementAt(28) + " tk";
                }
                else if (add.ElementAt(28) == "not")
                {
                    panel37.Visible = false;
                }
                if (add.ElementAt(29) == "added")
                {
                    panel19.Visible = true;

                    pictureBox31.ImageLocation = pics.ElementAt(29);
                    button35.Text = "Update " + names.ElementAt(29);
                    textBox33.Text = names.ElementAt(29) + " " + prices.ElementAt(29) + " tk";
                }
                else if (add.ElementAt(29) == "not")
                {
                    panel19.Visible = false;
                }
                if (add.ElementAt(30) == "added")
                {
                    panel20.Visible = true;

                    pictureBox32.ImageLocation = pics.ElementAt(30);
                    button36.Text = "Update " + names.ElementAt(30);
                    textBox34.Text = names.ElementAt(30) + " " + prices.ElementAt(30) + " tk";
                }
                else if (add.ElementAt(30) == "not")
                {
                    panel20.Visible = false;
                }
                if (add.ElementAt(31) == "added")
                {
                    panel22.Visible = true;

                    pictureBox33.ImageLocation = pics.ElementAt(31);
                    button37.Text = "Update " + names.ElementAt(31);
                    textBox35.Text = names.ElementAt(31) + " " + prices.ElementAt(31) + " tk";
                }
                else if (add.ElementAt(30) == "not")
                {
                    panel22.Visible = false;
                }

                if (add.ElementAt(32) == "added")
                {
                    panel23.Visible = true;

                    pictureBox34.ImageLocation = pics.ElementAt(32);
                    button38.Text = "Update " + names.ElementAt(32);
                    textBox36.Text = names.ElementAt(32) + " " + prices.ElementAt(32) + " tk";
                }
                else if (add.ElementAt(30) == "not")
                {
                    panel23.Visible = false;
                }
                if (add.ElementAt(33) == "added")
                {
                    panel29.Visible = true;

                    pictureBox35.ImageLocation = pics.ElementAt(33);
                    button39.Text = "Update " + names.ElementAt(33);
                    textBox37.Text = names.ElementAt(33) + " " + prices.ElementAt(33) + " tk";
                }
                else if (add.ElementAt(33) == "not")
                {
                    panel29.Visible = false;
                }
                if (add.ElementAt(34) == "added")
                {
                    panel30.Visible = true;

                    pictureBox36.ImageLocation = pics.ElementAt(34);
                    button40.Text = "Update " + names.ElementAt(34);
                    textBox38.Text = names.ElementAt(34) + " " + prices.ElementAt(34) + " tk";
                }
                else if (add.ElementAt(34) == "not")
                {
                    panel30.Visible = false;
                }
                if (add.ElementAt(35) == "added")
                {
                    panel31.Visible = true;

                    pictureBox37.ImageLocation = pics.ElementAt(35);
                    button41.Text = "Update " + names.ElementAt(35);
                    textBox39.Text = names.ElementAt(35) + " " + prices.ElementAt(35) + " tk";
                }
                else if (add.ElementAt(35) == "not")
                {
                    panel31.Visible = false;
                }

                if (add.ElementAt(36) == "added")
                {
                    panel38.Visible = true;

                    pictureBox38.ImageLocation = pics.ElementAt(36);
                    button42.Text = "Update " + names.ElementAt(36);
                    textBox40.Text = names.ElementAt(36) + " " + prices.ElementAt(36) + " tk";
                }
                else if (add.ElementAt(36) == "not")
                {
                    panel38.Visible = false;
                }
                if (add.ElementAt(37) == "added")
                {
                    panel39.Visible = true;

                    pictureBox39.ImageLocation = pics.ElementAt(37);
                    button43.Text = "Update " + names.ElementAt(37);
                    textBox41.Text = names.ElementAt(37) + " " + prices.ElementAt(37) + " tk";
                }
                else if (add.ElementAt(37) == "not")
                {
                    panel39.Visible = false;
                }
                if (add.ElementAt(38) == "added")
                {
                    panel40.Visible = true;

                    pictureBox40.ImageLocation = pics.ElementAt(38);
                    button44.Text = "Update " + names.ElementAt(38);
                    textBox42.Text = names.ElementAt(38) + " " + prices.ElementAt(38) + " tk";
                }
                else if (add.ElementAt(38) == "not")
                {
                    panel40.Visible = false;
                }
                if (add.ElementAt(39) == "added")
                {
                    panel41.Visible = true;

                    pictureBox41.ImageLocation = pics.ElementAt(39);
                    button45.Text = "Update " + names.ElementAt(39);
                    textBox43.Text = names.ElementAt(39) + " " + prices.ElementAt(39) + " tk";
                }
                else if (add.ElementAt(39) == "not")
                {
                    panel41.Visible = false;
                }

            }
            else
            {
                MessageBox.Show("Error");

            }
        }
        public int Id;
        

        private void button33_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection.Open();
            string sql = "UPDATE Food SET FoodStatus='active',Added='added' WHERE Id=" + Id;
            SqlCommand command = new SqlCommand(sql, connection);
            int diary = command.ExecuteNonQuery();

            if (diary > 0)
            {
                MessageBox.Show("Activated");
               
                textBox32.Text = String.Empty;
                add.Clear();
                pics.Clear();
                names.Clear();
                prices.Clear();
                SqlConnection connection55 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection55.Open();
                string sql55 = "SELECT * FROM Food WHERE FoodStatus IS NOT NULL";
                SqlCommand command55 = new SqlCommand(sql55, connection55);
                SqlDataReader reader55 = command55.ExecuteReader();
                List<Foodlist> list = new List<Foodlist>();
                while (reader55.Read())
                {
                    Foodlist CS = new Foodlist();

                    CS.Id = (int)reader55["Id"];

                    CS.Food_Name = reader55["FoodName"].ToString();
                    CS.Food_Type = reader55["FoodType"].ToString();
                    CS.Food_Status = reader55["FoodStatus"].ToString();
                    slist.Add((int)reader55["Id"]);
                    realID = slist[slist.Count - 1];

                    list.Add(CS);


                }
                dataGridView1.DataSource = list;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {

                    if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "not")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
                SqlConnection connection555 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection555.Open();
                string sql555 = "SELECT * FROM Food";
                SqlCommand command555 = new SqlCommand(sql555, connection555);
                SqlDataReader reader555 = command555.ExecuteReader();

                while (reader555.Read())
                {

                    add.Add((string)reader555["Added"]);

                    prices.Add((int)reader555["FoodPrice"]);
                    pics.Add(reader555["FoodPic"].ToString());
                    names.Add(reader555["FoodName"].ToString());

                }
                connection555.Close();

                if (add.ElementAt(0) == "added")
                {
                    panel1.Visible = true;
                    pictureBox1.ImageLocation = pics.ElementAt(0);
                    button1.Text = "Update " + names.ElementAt(0);
                    textBox1.Text = names.ElementAt(0) + " " + prices.ElementAt(0) + " tk";
                }
                else if (add.ElementAt(0) == "not")
                {
                    panel1.Visible = false;
                }

                if (add.ElementAt(1) == "added")
                {
                    panel2.Visible = true;
                    pictureBox2.ImageLocation = pics.ElementAt(1);
                    button2.Text = "Update " + names.ElementAt(1);
                    textBox2.Text = names.ElementAt(1) + " " + prices.ElementAt(1) + " tk";
                }
                else if (add.ElementAt(1) == "not")
                {
                    panel2.Visible = false;
                }

                if (add.ElementAt(2) == "added")
                {
                    panel3.Visible = true;
                    pictureBox3.ImageLocation = pics.ElementAt(2);
                    button3.Text = "Update " + names.ElementAt(2);
                    textBox3.Text = names.ElementAt(2) + " " + prices.ElementAt(2) + " tk";
                }
                else if (add.ElementAt(2) == "not")
                {
                    panel3.Visible = false;
                }
                if (add.ElementAt(3) == "added")
                {
                    panel4.Visible = true;
                    pictureBox4.ImageLocation = pics.ElementAt(3);
                    button4.Text = "Update " + names.ElementAt(3);
                    textBox4.Text = names.ElementAt(3) + " " + prices.ElementAt(3) + " tk";
                }
                else if (add.ElementAt(3) == "not")
                {
                    panel4.Visible = false;
                }
                if (add.ElementAt(4) == "added")
                {
                    panel5.Visible = true;
                    pictureBox5.ImageLocation = pics.ElementAt(4);
                    button5.Text = "Update " + names.ElementAt(4);
                    textBox5.Text = names.ElementAt(4) + " " + prices.ElementAt(4) + " tk";
                }
                else if (add.ElementAt(4) == "not")
                {
                    panel5.Visible = false;
                }

                if (add.ElementAt(5) == "added")
                {
                    panel6.Visible = true;
                    pictureBox6.ImageLocation = pics.ElementAt(5);
                    button6.Text = "Update " + names.ElementAt(5);
                    textBox6.Text = names.ElementAt(5) + " " + prices.ElementAt(5) + " tk";
                }
                else if (add.ElementAt(5) == "not")
                {
                    panel6.Visible = false;
                }

                if (add.ElementAt(6) == "added")
                {
                    panel7.Visible = true;
                    pictureBox7.ImageLocation = pics.ElementAt(6);
                    button7.Text = "Update " + names.ElementAt(6);
                    textBox7.Text = names.ElementAt(6) + " " + prices.ElementAt(6) + " tk";
                }
                else if (add.ElementAt(6) == "not")
                {
                    panel7.Visible = false;
                }

                if (add.ElementAt(7) == "added")
                {
                    panel8.Visible = true;
                    pictureBox8.ImageLocation = pics.ElementAt(7);
                    button8.Text = "Update " + names.ElementAt(7);
                    textBox8.Text = names.ElementAt(7) + " " + prices.ElementAt(7) + " tk";
                }
                else if (add.ElementAt(6) == "not")
                {
                    panel8.Visible = false;
                }

                if (add.ElementAt(8) == "added")
                {
                    panel9.Visible = true;

                    pictureBox10.ImageLocation = pics.ElementAt(8);
                    button12.Text = "Update " + names.ElementAt(8);
                    textBox11.Text = names.ElementAt(8) + " " + prices.ElementAt(8) + " tk";
                }
                else if (add.ElementAt(8) == "not")
                {
                    panel9.Visible = false;
                }


                if (add.ElementAt(9) == "added")
                {
                    panel10.Visible = true;

                    pictureBox11.ImageLocation = pics.ElementAt(9);
                    button13.Text = "Update " + names.ElementAt(9);
                    textBox12.Text = names.ElementAt(9) + " " + prices.ElementAt(9) + " tk";
                }
                else if (add.ElementAt(9) == "not")
                {
                    panel10.Visible = false;
                }

                panel11.Visible = false;
                if (add.ElementAt(10) == "added")
                {
                    panel11.Visible = true;

                    pictureBox12.ImageLocation = pics.ElementAt(10);
                    button14.Text = "Update " + names.ElementAt(10);
                    textBox13.Text = names.ElementAt(10) + " " + prices.ElementAt(10) + " tk";
                }
                else if (add.ElementAt(10) == "not")
                {
                    panel11.Visible = false;
                }

                panel12.Visible = false;
                if (add.ElementAt(11) == "added")
                {
                    panel12.Visible = true;

                    pictureBox13.ImageLocation = pics.ElementAt(11);
                    button15.Text = "Update " + names.ElementAt(11);
                    textBox14.Text = names.ElementAt(11) + " " + prices.ElementAt(11) + " tk";
                }
                else if (add.ElementAt(11) == "not")
                {
                    panel12.Visible = false;
                }

                panel13.Visible = false;
                if (add.ElementAt(12) == "added")
                {
                    panel13.Visible = true;

                    pictureBox14.ImageLocation = pics.ElementAt(12);
                    button16.Text = "Update " + names.ElementAt(12);
                    textBox15.Text = names.ElementAt(12) + " " + prices.ElementAt(12) + " tk";
                }
                else if (add.ElementAt(12) == "not")
                {
                    panel13.Visible = false;
                }

                panel14.Visible = false;
                if (add.ElementAt(13) == "added")
                {
                    panel14.Visible = true;

                    pictureBox15.ImageLocation = pics.ElementAt(13);
                    button17.Text = "Update " + names.ElementAt(13);
                    textBox16.Text = names.ElementAt(13) + " " + prices.ElementAt(13) + " tk";
                }
                else if (add.ElementAt(13) == "not")
                {
                    panel14.Visible = false;
                }

                panel15.Visible = false;
                if (add.ElementAt(14) == "added")
                {
                    panel15.Visible = true;

                    pictureBox16.ImageLocation = pics.ElementAt(14);
                    button18.Text = "Update " + names.ElementAt(14);
                    textBox17.Text = names.ElementAt(14) + " " + prices.ElementAt(14) + " tk";
                }
                else if (add.ElementAt(14) == "not")
                {
                    panel15.Visible = false;
                }

                panel16.Visible = false;
                if (add.ElementAt(15) == "added")
                {
                    panel16.Visible = true;

                    pictureBox17.ImageLocation = pics.ElementAt(15);
                    button19.Text = "Update " + names.ElementAt(15);
                    textBox18.Text = names.ElementAt(15) + " " + prices.ElementAt(15) + " tk";
                }
                else if (add.ElementAt(15) == "not")
                {
                    panel16.Visible = false;
                }

                panel17.Visible = false;
                if (add.ElementAt(16) == "added")
                {
                    panel17.Visible = true;

                    pictureBox18.ImageLocation = pics.ElementAt(16);
                    button20.Text = "Update " + names.ElementAt(16);
                    textBox19.Text = names.ElementAt(16) + " " + prices.ElementAt(16) + " tk";
                }
                else if (add.ElementAt(16) == "not")
                {
                    panel17.Visible = false;
                }


                panel21.Visible = false;
                if (add.ElementAt(17) == "added")
                {
                    panel21.Visible = true;

                    pictureBox19.ImageLocation = pics.ElementAt(17);
                    button21.Text = "Update " + names.ElementAt(17);
                    textBox20.Text = names.ElementAt(17) + " " + prices.ElementAt(17) + " tk";
                }
                else if (add.ElementAt(17) == "not")
                {
                    panel21.Visible = false;
                }

                panel24.Visible = false;
                if (add.ElementAt(18) == "added")
                {
                    panel24.Visible = true;

                    pictureBox20.ImageLocation = pics.ElementAt(18);
                    button22.Text = "Update " + names.ElementAt(18);
                    textBox21.Text = names.ElementAt(18) + " " + prices.ElementAt(18) + " tk";
                }
                else if (add.ElementAt(18) == "not")
                {
                    panel24.Visible = false;
                }

                panel25.Visible = false;
                if (add.ElementAt(19) == "added")
                {
                    panel25.Visible = true;

                    pictureBox21.ImageLocation = pics.ElementAt(19);
                    button23.Text = "Update " + names.ElementAt(19);
                    textBox22.Text = names.ElementAt(19) + " " + prices.ElementAt(19) + " tk";
                }
                else if (add.ElementAt(19) == "not")
                {
                    panel25.Visible = false;
                }

                panel26.Visible = false;
                if (add.ElementAt(20) == "added")
                {
                    panel26.Visible = true;

                    pictureBox22.ImageLocation = pics.ElementAt(20);
                    button24.Text = "Update " + names.ElementAt(20);
                    textBox23.Text = names.ElementAt(20) + " " + prices.ElementAt(20) + " tk";
                }
                else if (add.ElementAt(20) == "not")
                {
                    panel26.Visible = false;
                }

                panel27.Visible = false;
                if (add.ElementAt(21) == "added")
                {
                    panel27.Visible = true;

                    pictureBox23.ImageLocation = pics.ElementAt(21);
                    button25.Text = "Update " + names.ElementAt(21);
                    textBox24.Text = names.ElementAt(21) + " " + prices.ElementAt(21) + " tk";
                }
                else if (add.ElementAt(21) == "not")
                {
                    panel27.Visible = false;
                }

                panel28.Visible = false;
                if (add.ElementAt(22) == "added")
                {
                    panel28.Visible = true;

                    pictureBox24.ImageLocation = pics.ElementAt(22);
                    button26.Text = "Update " + names.ElementAt(22);
                    textBox25.Text = names.ElementAt(22) + " " + prices.ElementAt(22) + " tk";
                }
                else if (add.ElementAt(22) == "not")
                {
                    panel28.Visible = false;
                }

                panel32.Visible = false;
                if (add.ElementAt(23) == "added")
                {
                    panel32.Visible = true;

                    pictureBox25.ImageLocation = pics.ElementAt(23);
                    button27.Text = "Update " + names.ElementAt(23);
                    textBox26.Text = names.ElementAt(23) + " " + prices.ElementAt(23) + " tk";
                }
                else if (add.ElementAt(23) == "not")
                {
                    panel32.Visible = false;
                }

                panel33.Visible = false;
                if (add.ElementAt(24) == "added")
                {
                    panel33.Visible = true;

                    pictureBox26.ImageLocation = pics.ElementAt(24);
                    button28.Text = "Update " + names.ElementAt(24);
                    textBox27.Text = names.ElementAt(24) + " " + prices.ElementAt(24) + " tk";
                }
                else if (add.ElementAt(24) == "not")
                {
                    panel33.Visible = false;
                }

                panel34.Visible = false;
                if (add.ElementAt(25) == "added")
                {
                    panel34.Visible = true;

                    pictureBox27.ImageLocation = pics.ElementAt(25);
                    button29.Text = "Update " + names.ElementAt(25);
                    textBox28.Text = names.ElementAt(25) + " " + prices.ElementAt(25) + " tk";
                }
                else if (add.ElementAt(25) == "not")
                {
                    panel34.Visible = false;
                }

                panel35.Visible = false;
                if (add.ElementAt(26) == "added")
                {
                    panel35.Visible = true;

                    pictureBox28.ImageLocation = pics.ElementAt(26);
                    button30.Text = "Update " + names.ElementAt(26);
                    textBox29.Text = names.ElementAt(26) + " " + prices.ElementAt(26) + " tk";
                }
                else if (add.ElementAt(26) == "not")
                {
                    panel35.Visible = false;
                }

                panel36.Visible = false;
                if (add.ElementAt(27) == "added")
                {
                    panel36.Visible = true;

                    pictureBox29.ImageLocation = pics.ElementAt(27);
                    button31.Text = "Update " + names.ElementAt(27);
                    textBox30.Text = names.ElementAt(27) + " " + prices.ElementAt(27) + " tk";
                }
                else if (add.ElementAt(27) == "not")
                {
                    panel36.Visible = false;
                }

                panel37.Visible = false;
                if (add.ElementAt(28) == "added")
                {
                    panel37.Visible = true;

                    pictureBox30.ImageLocation = pics.ElementAt(28);
                    button32.Text = "Update " + names.ElementAt(28);
                    textBox31.Text = names.ElementAt(28) + " " + prices.ElementAt(28) + " tk";
                }
                else if (add.ElementAt(28) == "not")
                {
                    panel37.Visible = false;
                }
                if (add.ElementAt(29) == "added")
                {
                    panel19.Visible = true;

                    pictureBox31.ImageLocation = pics.ElementAt(29);
                    button35.Text = "Update " + names.ElementAt(29);
                    textBox33.Text = names.ElementAt(29) + " " + prices.ElementAt(29) + " tk";
                }
                else if (add.ElementAt(29) == "not")
                {
                    panel19.Visible = false;
                }
                if (add.ElementAt(30) == "added")
                {
                    panel20.Visible = true;

                    pictureBox32.ImageLocation = pics.ElementAt(30);
                    button36.Text = "Update " + names.ElementAt(30);
                    textBox34.Text = names.ElementAt(30) + " " + prices.ElementAt(30) + " tk";
                }
                else if (add.ElementAt(30) == "not")
                {
                    panel20.Visible = false;
                }
                if (add.ElementAt(31) == "added")
                {
                    panel22.Visible = true;

                    pictureBox33.ImageLocation = pics.ElementAt(31);
                    button37.Text = "Update " + names.ElementAt(31);
                    textBox35.Text = names.ElementAt(31) + " " + prices.ElementAt(31) + " tk";
                }
                else if (add.ElementAt(30) == "not")
                {
                    panel22.Visible = false;
                }

                if (add.ElementAt(32) == "added")
                {
                    panel23.Visible = true;

                    pictureBox34.ImageLocation = pics.ElementAt(32);
                    button38.Text = "Update " + names.ElementAt(32);
                    textBox36.Text = names.ElementAt(32) + " " + prices.ElementAt(32) + " tk";
                }
                else if (add.ElementAt(30) == "not")
                {
                    panel23.Visible = false;
                }
                if (add.ElementAt(33) == "added")
                {
                    panel29.Visible = true;

                    pictureBox35.ImageLocation = pics.ElementAt(33);
                    button39.Text = "Update " + names.ElementAt(33);
                    textBox37.Text = names.ElementAt(33) + " " + prices.ElementAt(33) + " tk";
                }
                else if (add.ElementAt(33) == "not")
                {
                    panel29.Visible = false;
                }
                if (add.ElementAt(34) == "added")
                {
                    panel30.Visible = true;

                    pictureBox36.ImageLocation = pics.ElementAt(34);
                    button40.Text = "Update " + names.ElementAt(34);
                    textBox38.Text = names.ElementAt(34) + " " + prices.ElementAt(34) + " tk";
                }
                else if (add.ElementAt(34) == "not")
                {
                    panel30.Visible = false;
                }
                if (add.ElementAt(35) == "added")
                {
                    panel31.Visible = true;

                    pictureBox37.ImageLocation = pics.ElementAt(35);
                    button41.Text = "Update " + names.ElementAt(35);
                    textBox39.Text = names.ElementAt(35) + " " + prices.ElementAt(35) + " tk";
                }
                else if (add.ElementAt(35) == "not")
                {
                    panel31.Visible = false;
                }

                if (add.ElementAt(36) == "added")
                {
                    panel38.Visible = true;

                    pictureBox38.ImageLocation = pics.ElementAt(36);
                    button42.Text = "Update " + names.ElementAt(36);
                    textBox40.Text = names.ElementAt(36) + " " + prices.ElementAt(36) + " tk";
                }
                else if (add.ElementAt(36) == "not")
                {
                    panel38.Visible = false;
                }
                if (add.ElementAt(37) == "added")
                {
                    panel39.Visible = true;

                    pictureBox39.ImageLocation = pics.ElementAt(37);
                    button43.Text = "Update " + names.ElementAt(37);
                    textBox41.Text = names.ElementAt(37) + " " + prices.ElementAt(37) + " tk";
                }
                else if (add.ElementAt(37) == "not")
                {
                    panel39.Visible = false;
                }
                if (add.ElementAt(38) == "added")
                {
                    panel40.Visible = true;

                    pictureBox40.ImageLocation = pics.ElementAt(38);
                    button44.Text = "Update " + names.ElementAt(38);
                    textBox42.Text = names.ElementAt(38) + " " + prices.ElementAt(38) + " tk";
                }
                else if (add.ElementAt(38) == "not")
                {
                    panel40.Visible = false;
                }
                if (add.ElementAt(39) == "added")
                {
                    panel41.Visible = true;

                    pictureBox41.ImageLocation = pics.ElementAt(39);
                    button45.Text = "Update " + names.ElementAt(39);
                    textBox43.Text = names.ElementAt(39) + " " + prices.ElementAt(39) + " tk";
                }
                else if (add.ElementAt(39) == "not")
                {
                    panel41.Visible = false;
                }

            }
            else
            {
                MessageBox.Show("Error");
            }
            
        }

        private void button34_Click(object sender, EventArgs e)
        {
           
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection.Open();
            string sql = "UPDATE Food SET FoodStatus='not',Added='not' WHERE Id=" + Id;
            SqlCommand command = new SqlCommand(sql, connection);
            int diary = command.ExecuteNonQuery();

            if (diary > 0)
            {
                MessageBox.Show("Deactivated");
                
                textBox32.Text = String.Empty;
                add.Clear();
                pics.Clear();
                names.Clear();
                prices.Clear();
                SqlConnection connection55 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection55.Open();
                string sql55 = "SELECT * FROM Food WHERE FoodStatus IS NOT NULL";
                SqlCommand command55 = new SqlCommand(sql55, connection55);
                SqlDataReader reader55 = command55.ExecuteReader();
                List<Foodlist> list = new List<Foodlist>();
                while (reader55.Read())
                {
                    Foodlist CS = new Foodlist();

                    CS.Id = (int)reader55["Id"];

                    CS.Food_Name = reader55["FoodName"].ToString();
                    CS.Food_Type = reader55["FoodType"].ToString();
                    CS.Food_Status = reader55["FoodStatus"].ToString();
                    slist.Add((int)reader55["Id"]);
                    realID = slist[slist.Count - 1];

                    list.Add(CS);


                }
                dataGridView1.DataSource = list;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {

                    if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "not")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
                SqlConnection connection555 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection555.Open();
                string sql555 = "SELECT * FROM Food";
                SqlCommand command555 = new SqlCommand(sql555, connection555);
                SqlDataReader reader555 = command555.ExecuteReader();

                while (reader555.Read())
                {

                    add.Add((string)reader555["Added"]);

                    prices.Add((int)reader555["FoodPrice"]);
                    pics.Add(reader555["FoodPic"].ToString());
                    names.Add(reader555["FoodName"].ToString());

                }
                connection555.Close();

                if (add.ElementAt(0) == "added")
                {
                    panel1.Visible = true;
                    pictureBox1.ImageLocation = pics.ElementAt(0);
                    button1.Text = "Update " + names.ElementAt(0);
                    textBox1.Text = names.ElementAt(0) + " " + prices.ElementAt(0) + " tk";
                }
                else if (add.ElementAt(0) == "not")
                {
                    panel1.Visible = false;
                }

                if (add.ElementAt(1) == "added")
                {
                    panel2.Visible = true;
                    pictureBox2.ImageLocation = pics.ElementAt(1);
                    button2.Text = "Update " + names.ElementAt(1);
                    textBox2.Text = names.ElementAt(1) + " " + prices.ElementAt(1) + " tk";
                }
                else if (add.ElementAt(1) == "not")
                {
                    panel2.Visible = false;
                }

                if (add.ElementAt(2) == "added")
                {
                    panel3.Visible = true;
                    pictureBox3.ImageLocation = pics.ElementAt(2);
                    button3.Text = "Update " + names.ElementAt(2);
                    textBox3.Text = names.ElementAt(2) + " " + prices.ElementAt(2) + " tk";
                }
                else if (add.ElementAt(2) == "not")
                {
                    panel3.Visible = false;
                }
                if (add.ElementAt(3) == "added")
                {
                    panel4.Visible = true;
                    pictureBox4.ImageLocation = pics.ElementAt(3);
                    button4.Text = "Update " + names.ElementAt(3);
                    textBox4.Text = names.ElementAt(3) + " " + prices.ElementAt(3) + " tk";
                }
                else if (add.ElementAt(3) == "not")
                {
                    panel4.Visible = false;
                }
                if (add.ElementAt(4) == "added")
                {
                    panel5.Visible = true;
                    pictureBox5.ImageLocation = pics.ElementAt(4);
                    button5.Text = "Update " + names.ElementAt(4);
                    textBox5.Text = names.ElementAt(4) + " " + prices.ElementAt(4) + " tk";
                }
                else if (add.ElementAt(4) == "not")
                {
                    panel5.Visible = false;
                }

                if (add.ElementAt(5) == "added")
                {
                    panel6.Visible = true;
                    pictureBox6.ImageLocation = pics.ElementAt(5);
                    button6.Text = "Update " + names.ElementAt(5);
                    textBox6.Text = names.ElementAt(5) + " " + prices.ElementAt(5) + " tk";
                }
                else if (add.ElementAt(5) == "not")
                {
                    panel6.Visible = false;
                }

                if (add.ElementAt(6) == "added")
                {
                    panel7.Visible = true;
                    pictureBox7.ImageLocation = pics.ElementAt(6);
                    button7.Text = "Update " + names.ElementAt(6);
                    textBox7.Text = names.ElementAt(6) + " " + prices.ElementAt(6) + " tk";
                }
                else if (add.ElementAt(6) == "not")
                {
                    panel7.Visible = false;
                }

                if (add.ElementAt(7) == "added")
                {
                    panel8.Visible = true;
                    pictureBox8.ImageLocation = pics.ElementAt(7);
                    button8.Text = "Update " + names.ElementAt(7);
                    textBox8.Text = names.ElementAt(7) + " " + prices.ElementAt(7) + " tk";
                }
                else if (add.ElementAt(6) == "not")
                {
                    panel8.Visible = false;
                }

                if (add.ElementAt(8) == "added")
                {
                    panel9.Visible = true;

                    pictureBox10.ImageLocation = pics.ElementAt(8);
                    button12.Text = "Update " + names.ElementAt(8);
                    textBox11.Text = names.ElementAt(8) + " " + prices.ElementAt(8) + " tk";
                }
                else if (add.ElementAt(8) == "not")
                {
                    panel9.Visible = false;
                }


                if (add.ElementAt(9) == "added")
                {
                    panel10.Visible = true;

                    pictureBox11.ImageLocation = pics.ElementAt(9);
                    button13.Text = "Update " + names.ElementAt(9);
                    textBox12.Text = names.ElementAt(9) + " " + prices.ElementAt(9) + " tk";
                }
                else if (add.ElementAt(9) == "not")
                {
                    panel10.Visible = false;
                }

                panel11.Visible = false;
                if (add.ElementAt(10) == "added")
                {
                    panel11.Visible = true;

                    pictureBox12.ImageLocation = pics.ElementAt(10);
                    button14.Text = "Update " + names.ElementAt(10);
                    textBox13.Text = names.ElementAt(10) + " " + prices.ElementAt(10) + " tk";
                }
                else if (add.ElementAt(10) == "not")
                {
                    panel11.Visible = false;
                }

                panel12.Visible = false;
                if (add.ElementAt(11) == "added")
                {
                    panel12.Visible = true;

                    pictureBox13.ImageLocation = pics.ElementAt(11);
                    button15.Text = "Update " + names.ElementAt(11);
                    textBox14.Text = names.ElementAt(11) + " " + prices.ElementAt(11) + " tk";
                }
                else if (add.ElementAt(11) == "not")
                {
                    panel12.Visible = false;
                }

                panel13.Visible = false;
                if (add.ElementAt(12) == "added")
                {
                    panel13.Visible = true;

                    pictureBox14.ImageLocation = pics.ElementAt(12);
                    button16.Text = "Update " + names.ElementAt(12);
                    textBox15.Text = names.ElementAt(12) + " " + prices.ElementAt(12) + " tk";
                }
                else if (add.ElementAt(12) == "not")
                {
                    panel13.Visible = false;
                }

                panel14.Visible = false;
                if (add.ElementAt(13) == "added")
                {
                    panel14.Visible = true;

                    pictureBox15.ImageLocation = pics.ElementAt(13);
                    button17.Text = "Update " + names.ElementAt(13);
                    textBox16.Text = names.ElementAt(13) + " " + prices.ElementAt(13) + " tk";
                }
                else if (add.ElementAt(13) == "not")
                {
                    panel14.Visible = false;
                }

                panel15.Visible = false;
                if (add.ElementAt(14) == "added")
                {
                    panel15.Visible = true;

                    pictureBox16.ImageLocation = pics.ElementAt(14);
                    button18.Text = "Update " + names.ElementAt(14);
                    textBox17.Text = names.ElementAt(14) + " " + prices.ElementAt(14) + " tk";
                }
                else if (add.ElementAt(14) == "not")
                {
                    panel15.Visible = false;
                }

                panel16.Visible = false;
                if (add.ElementAt(15) == "added")
                {
                    panel16.Visible = true;

                    pictureBox17.ImageLocation = pics.ElementAt(15);
                    button19.Text = "Update " + names.ElementAt(15);
                    textBox18.Text = names.ElementAt(15) + " " + prices.ElementAt(15) + " tk";
                }
                else if (add.ElementAt(15) == "not")
                {
                    panel16.Visible = false;
                }

                panel17.Visible = false;
                if (add.ElementAt(16) == "added")
                {
                    panel17.Visible = true;

                    pictureBox18.ImageLocation = pics.ElementAt(16);
                    button20.Text = "Update " + names.ElementAt(16);
                    textBox19.Text = names.ElementAt(16) + " " + prices.ElementAt(16) + " tk";
                }
                else if (add.ElementAt(16) == "not")
                {
                    panel17.Visible = false;
                }


                panel21.Visible = false;
                if (add.ElementAt(17) == "added")
                {
                    panel21.Visible = true;

                    pictureBox19.ImageLocation = pics.ElementAt(17);
                    button21.Text = "Update " + names.ElementAt(17);
                    textBox20.Text = names.ElementAt(17) + " " + prices.ElementAt(17) + " tk";
                }
                else if (add.ElementAt(17) == "not")
                {
                    panel21.Visible = false;
                }

                panel24.Visible = false;
                if (add.ElementAt(18) == "added")
                {
                    panel24.Visible = true;

                    pictureBox20.ImageLocation = pics.ElementAt(18);
                    button22.Text = "Update " + names.ElementAt(18);
                    textBox21.Text = names.ElementAt(18) + " " + prices.ElementAt(18) + " tk";
                }
                else if (add.ElementAt(18) == "not")
                {
                    panel24.Visible = false;
                }

                panel25.Visible = false;
                if (add.ElementAt(19) == "added")
                {
                    panel25.Visible = true;

                    pictureBox21.ImageLocation = pics.ElementAt(19);
                    button23.Text = "Update " + names.ElementAt(19);
                    textBox22.Text = names.ElementAt(19) + " " + prices.ElementAt(19) + " tk";
                }
                else if (add.ElementAt(19) == "not")
                {
                    panel25.Visible = false;
                }

                panel26.Visible = false;
                if (add.ElementAt(20) == "added")
                {
                    panel26.Visible = true;

                    pictureBox22.ImageLocation = pics.ElementAt(20);
                    button24.Text = "Update " + names.ElementAt(20);
                    textBox23.Text = names.ElementAt(20) + " " + prices.ElementAt(20) + " tk";
                }
                else if (add.ElementAt(20) == "not")
                {
                    panel26.Visible = false;
                }

                panel27.Visible = false;
                if (add.ElementAt(21) == "added")
                {
                    panel27.Visible = true;

                    pictureBox23.ImageLocation = pics.ElementAt(21);
                    button25.Text = "Update " + names.ElementAt(21);
                    textBox24.Text = names.ElementAt(21) + " " + prices.ElementAt(21) + " tk";
                }
                else if (add.ElementAt(21) == "not")
                {
                    panel27.Visible = false;
                }

                panel28.Visible = false;
                if (add.ElementAt(22) == "added")
                {
                    panel28.Visible = true;

                    pictureBox24.ImageLocation = pics.ElementAt(22);
                    button26.Text = "Update " + names.ElementAt(22);
                    textBox25.Text = names.ElementAt(22) + " " + prices.ElementAt(22) + " tk";
                }
                else if (add.ElementAt(22) == "not")
                {
                    panel28.Visible = false;
                }

                panel32.Visible = false;
                if (add.ElementAt(23) == "added")
                {
                    panel32.Visible = true;

                    pictureBox25.ImageLocation = pics.ElementAt(23);
                    button27.Text = "Update " + names.ElementAt(23);
                    textBox26.Text = names.ElementAt(23) + " " + prices.ElementAt(23) + " tk";
                }
                else if (add.ElementAt(23) == "not")
                {
                    panel32.Visible = false;
                }

                panel33.Visible = false;
                if (add.ElementAt(24) == "added")
                {
                    panel33.Visible = true;

                    pictureBox26.ImageLocation = pics.ElementAt(24);
                    button28.Text = "Update " + names.ElementAt(24);
                    textBox27.Text = names.ElementAt(24) + " " + prices.ElementAt(24) + " tk";
                }
                else if (add.ElementAt(24) == "not")
                {
                    panel33.Visible = false;
                }

                panel34.Visible = false;
                if (add.ElementAt(25) == "added")
                {
                    panel34.Visible = true;

                    pictureBox27.ImageLocation = pics.ElementAt(25);
                    button29.Text = "Update " + names.ElementAt(25);
                    textBox28.Text = names.ElementAt(25) + " " + prices.ElementAt(25) + " tk";
                }
                else if (add.ElementAt(25) == "not")
                {
                    panel34.Visible = false;
                }

                panel35.Visible = false;
                if (add.ElementAt(26) == "added")
                {
                    panel35.Visible = true;

                    pictureBox28.ImageLocation = pics.ElementAt(26);
                    button30.Text = "Update " + names.ElementAt(26);
                    textBox29.Text = names.ElementAt(26) + " " + prices.ElementAt(26) + " tk";
                }
                else if (add.ElementAt(26) == "not")
                {
                    panel35.Visible = false;
                }

                panel36.Visible = false;
                if (add.ElementAt(27) == "added")
                {
                    panel36.Visible = true;

                    pictureBox29.ImageLocation = pics.ElementAt(27);
                    button31.Text = "Update " + names.ElementAt(27);
                    textBox30.Text = names.ElementAt(27) + " " + prices.ElementAt(27) + " tk";
                }
                else if (add.ElementAt(27) == "not")
                {
                    panel36.Visible = false;
                }

                panel37.Visible = false;
                if (add.ElementAt(28) == "added")
                {
                    panel37.Visible = true;

                    pictureBox30.ImageLocation = pics.ElementAt(28);
                    button32.Text = "Update " + names.ElementAt(28);
                    textBox31.Text = names.ElementAt(28) + " " + prices.ElementAt(28) + " tk";
                }
                else if (add.ElementAt(28) == "not")
                {
                    panel37.Visible = false;
                }
                if (add.ElementAt(29) == "added")
                {
                    panel19.Visible = true;

                    pictureBox31.ImageLocation = pics.ElementAt(29);
                    button35.Text = "Update " + names.ElementAt(29);
                    textBox33.Text = names.ElementAt(29) + " " + prices.ElementAt(29) + " tk";
                }
                else if (add.ElementAt(29) == "not")
                {
                    panel19.Visible = false;
                }
                if (add.ElementAt(30) == "added")
                {
                    panel20.Visible = true;

                    pictureBox32.ImageLocation = pics.ElementAt(30);
                    button36.Text = "Update " + names.ElementAt(30);
                    textBox34.Text = names.ElementAt(30) + " " + prices.ElementAt(30) + " tk";
                }
                else if (add.ElementAt(30) == "not")
                {
                    panel20.Visible = false;
                }
                if (add.ElementAt(31) == "added")
                {
                    panel22.Visible = true;

                    pictureBox33.ImageLocation = pics.ElementAt(31);
                    button37.Text = "Update " + names.ElementAt(31);
                    textBox35.Text = names.ElementAt(31) + " " + prices.ElementAt(31) + " tk";
                }
                else if (add.ElementAt(30) == "not")
                {
                    panel22.Visible = false;
                }

                if (add.ElementAt(32) == "added")
                {
                    panel23.Visible = true;

                    pictureBox34.ImageLocation = pics.ElementAt(32);
                    button38.Text = "Update " + names.ElementAt(32);
                    textBox36.Text = names.ElementAt(32) + " " + prices.ElementAt(32) + " tk";
                }
                else if (add.ElementAt(30) == "not")
                {
                    panel23.Visible = false;
                }
                if (add.ElementAt(33) == "added")
                {
                    panel29.Visible = true;

                    pictureBox35.ImageLocation = pics.ElementAt(33);
                    button39.Text = "Update " + names.ElementAt(33);
                    textBox37.Text = names.ElementAt(33) + " " + prices.ElementAt(33) + " tk";
                }
                else if (add.ElementAt(33) == "not")
                {
                    panel29.Visible = false;
                }
                if (add.ElementAt(34) == "added")
                {
                    panel30.Visible = true;

                    pictureBox36.ImageLocation = pics.ElementAt(34);
                    button40.Text = "Update " + names.ElementAt(34);
                    textBox38.Text = names.ElementAt(34) + " " + prices.ElementAt(34) + " tk";
                }
                else if (add.ElementAt(34) == "not")
                {
                    panel30.Visible = false;
                }
                if (add.ElementAt(35) == "added")
                {
                    panel31.Visible = true;

                    pictureBox37.ImageLocation = pics.ElementAt(35);
                    button41.Text = "Update " + names.ElementAt(35);
                    textBox39.Text = names.ElementAt(35) + " " + prices.ElementAt(35) + " tk";
                }
                else if (add.ElementAt(35) == "not")
                {
                    panel31.Visible = false;
                }

                if (add.ElementAt(36) == "added")
                {
                    panel38.Visible = true;

                    pictureBox38.ImageLocation = pics.ElementAt(36);
                    button42.Text = "Update " + names.ElementAt(36);
                    textBox40.Text = names.ElementAt(36) + " " + prices.ElementAt(36) + " tk";
                }
                else if (add.ElementAt(36) == "not")
                {
                    panel38.Visible = false;
                }
                if (add.ElementAt(37) == "added")
                {
                    panel39.Visible = true;

                    pictureBox39.ImageLocation = pics.ElementAt(37);
                    button43.Text = "Update " + names.ElementAt(37);
                    textBox41.Text = names.ElementAt(37) + " " + prices.ElementAt(37) + " tk";
                }
                else if (add.ElementAt(37) == "not")
                {
                    panel39.Visible = false;
                }
                if (add.ElementAt(38) == "added")
                {
                    panel40.Visible = true;

                    pictureBox40.ImageLocation = pics.ElementAt(38);
                    button44.Text = "Update " + names.ElementAt(38);
                    textBox42.Text = names.ElementAt(38) + " " + prices.ElementAt(38) + " tk";
                }
                else if (add.ElementAt(38) == "not")
                {
                    panel40.Visible = false;
                }
                if (add.ElementAt(39) == "added")
                {
                    panel41.Visible = true;

                    pictureBox41.ImageLocation = pics.ElementAt(39);
                    button45.Text = "Update " + names.ElementAt(39);
                    textBox43.Text = names.ElementAt(39) + " " + prices.ElementAt(39) + " tk";
                }
                else if (add.ElementAt(39) == "not")
                {
                    panel41.Visible = false;
                }

            }
            else
            {
                MessageBox.Show("Error");
            }
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            textBox32.Text = String.Empty;
            textBox32.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(8);
            realname1 = names.ElementAt(8);
            textBox10.Text = prices.ElementAt(8).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(8);
            powerid =9;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(9);
            realname1 = names.ElementAt(9);
            textBox10.Text = prices.ElementAt(9).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(9);
            powerid = 10;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(10);
            realname1 = names.ElementAt(10);
            textBox10.Text = prices.ElementAt(10).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(10);
            powerid = 11;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(11);
            realname1 = names.ElementAt(11);
            textBox10.Text = prices.ElementAt(11).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(11);
            powerid = 12;
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(12);
            realname1 = names.ElementAt(12);
            textBox10.Text = prices.ElementAt(12).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(12);
            powerid = 13;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(13);
            realname1 = names.ElementAt(13);
            textBox10.Text = prices.ElementAt(13).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(13);
            powerid = 14;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(14);
            realname1 = names.ElementAt(14);
            textBox10.Text = prices.ElementAt(14).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(14);
            powerid = 15;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(15);
            realname1 = names.ElementAt(15);
            textBox10.Text = prices.ElementAt(15).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(15);
            powerid = 16;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(16);
            realname1 = names.ElementAt(16);
            textBox10.Text = prices.ElementAt(16).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(16);
            powerid = 17;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(17);
            realname1 = names.ElementAt(17);
            textBox10.Text = prices.ElementAt(17).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(17);
            powerid = 18;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(18);
            realname1 = names.ElementAt(18);
            textBox10.Text = prices.ElementAt(18).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(18);
            powerid = 19;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(19);
            realname1 = names.ElementAt(19);
            textBox10.Text = prices.ElementAt(19).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(19);
            powerid = 20;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(20);
            realname1 = names.ElementAt(20);
            textBox10.Text = prices.ElementAt(20).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(20);
            powerid = 21;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(21);
            realname1 = names.ElementAt(21);
            textBox10.Text = prices.ElementAt(21).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(21);
            powerid = 22;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(22);
            realname1 = names.ElementAt(22);
            textBox10.Text = prices.ElementAt(22).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(22);
            powerid = 23;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(23);
            realname1 = names.ElementAt(23);
            textBox10.Text = prices.ElementAt(23).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(23);
            powerid = 24;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(24);
            realname1 = names.ElementAt(24);
            textBox10.Text = prices.ElementAt(24).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(24);
            powerid = 25;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(25);
            realname1 = names.ElementAt(25);
            textBox10.Text = prices.ElementAt(25).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(25);
            powerid = 26;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(26);
            realname1 = names.ElementAt(26);
            textBox10.Text = prices.ElementAt(26).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(26);
            powerid = 27;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(27);
            realname1 = names.ElementAt(27);
            textBox10.Text = prices.ElementAt(27).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(27);
            powerid = 28;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(28);
            realname1 = names.ElementAt(28);
            textBox10.Text = prices.ElementAt(28).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(28);
            powerid = 29;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(29);
            realname1 = names.ElementAt(29);
            textBox10.Text = prices.ElementAt(29).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(29);
            powerid = 30;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(30);
            realname1 = names.ElementAt(30);
            textBox10.Text = prices.ElementAt(30).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(30);
            powerid = 31;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(31);
            realname1 = names.ElementAt(31);
            textBox10.Text = prices.ElementAt(31).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(31);
            powerid = 32;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(32);
            realname1 = names.ElementAt(32);
            textBox10.Text = prices.ElementAt(32).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(32);
            powerid = 33;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(33);
            realname1 = names.ElementAt(33);
            textBox10.Text = prices.ElementAt(33).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(33);
            powerid = 34;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(34);
            realname1 = names.ElementAt(34);
            textBox10.Text = prices.ElementAt(34).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(34);
            powerid = 35;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(35);
            realname1 = names.ElementAt(35);
            textBox10.Text = prices.ElementAt(35).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(35);
            powerid = 36;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(36);
            realname1 = names.ElementAt(36);
            textBox10.Text = prices.ElementAt(36).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(36);
            powerid = 37;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(37);
            realname1 = names.ElementAt(37);
            textBox10.Text = prices.ElementAt(37).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(37);
            powerid = 38;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(38);
            realname1 = names.ElementAt(38);
            textBox10.Text = prices.ElementAt(38).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(38);
            powerid = 39;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = names.ElementAt(39);
            realname1 = names.ElementAt(39);
            textBox10.Text = prices.ElementAt(39).ToString();
            pictureBox9.ImageLocation = pics.ElementAt(39);
            powerid = 40;
        }

        private void groupbox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
