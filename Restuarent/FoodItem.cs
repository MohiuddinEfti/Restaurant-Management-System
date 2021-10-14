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

        public int price1;
        public int price2;
        public int price3;
        public int price4;
        public int price5;
        public int price6;
        public int price7;
        public int price8;
        public int price9;
        public int price10;
        public int price11;
        public int price12;
        public int price13;
        public int price14;
        public int price15;
        public int price16;
        public int price17;
        public int price18;
        public int price19;
        public int price20;
        public int price21;
        public int price22;
        public int price23;
        public int price24;
        public int price25;
        public int price26;
        public int price27;
        public int price28;
        public int price29;
        public int price30;
        public int price31;
        public int price32;
        public int price33;
        public int price34;
        public int price35;
        public int price36;
        public int price37;
        public int price38;
        public int price39;
        public int price40;
        public int price41;
        public int price42;
        public int price43;
        public int price44;
        public int price45;
        public int price46;
        public int price47;
        public int price48;
        public int price49;
        public int price50;
        public int price51;
        public int price52;
        public int price53;
        public int price54;
        public int price55;
        public int price56;
        public int price57;
        public int price58;
        public int price59;
        public int price60;
       

        public string name1;
        public string name2;
        public string name3;
        public string name4;
        public string name5;
        public string name6;
        public string name7;
        public string name8;
        public string name9;
        public string name10;
        public string name11;
        public string name12;
        public string name13;
        public string name14;
        public string name15;
        public string name16;
        public string name17;
        public string name18;
        public string name19;
        public string name20;
        public string name21;
        public string name22;
        public string name23;
        public string name24;
        public string name25;
        public string name26;
        public string name27;
        public string name28;
        public string name29;
        public string name30;
        public string name31;
        public string name32;
        public string name33;
        public string name34;
        public string name35;
        public string name36;
        public string name37;
        public string name38;
        public string name39;
        public string name40;
        public string name41;
        public string name42;
        public string name43;
        public string name44;
        public string name45;
        public string name46;
        public string name47;
        public string name48;
        public string name49;
        public string name50;
        public string name51;
        public string name52;
        public string name53;
        public string name54;
        public string name55;
        public string name56;
        public string name57;
        public string name58;
        public string name59;
        public string name60;
        

        public string pic1;
        public string pic2;
        public string pic3;
        public string pic4;
        public string pic5;
        public string pic6;
        public string pic7;
        public string pic8;
        public string pic9;
        public string pic10;
        public string pic11;
        public string pic12;
        public string pic13;
        public string pic14;
        public string pic15;
        public string pic16;
        public string pic17;
        public string pic18;
        public string pic19;
        public string pic20;
        public string pic21;
        public string pic22;
        public string pic23;
        public string pic24;
        public string pic25;
        public string pic26;
        public string pic27;
        public string pic28;
        public string pic29;
        public string pic30;
        public string pic31;
        public string pic32;
        public string pic33;
        public string pic34;
        public string pic35;
        public string pic36;
        public string pic37;
        public string pic38;
        public string pic39;
        public string pic40;
        public string pic41;
        public string pic42;
        public string pic43;
        public string pic44;
        public string pic45;
        public string pic46;
        public string pic47;
        public string pic48;
        public string pic49;
        public string pic50;
        public string pic51;
        public string pic52;
        public string pic53;
        public string pic54;
        public string pic55;
        public string pic56;
        public string pic57;
        public string pic58;
        public string pic59;
        public string pic60;

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

        public void FoodItem_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            groupbox1.Visible = false;
            Namelab1.Visible = false;
            Pricelab1.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            Update1.Visible = false;

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

            SqlConnection connection555 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection555.Open();
            string sql555 = "SELECT * FROM Food";
            SqlCommand command555 = new SqlCommand(sql555, connection555);
            SqlDataReader reader555 = command555.ExecuteReader();
           
            while (reader555.Read())
            {
                
                add.Add((string)reader555["Added"]);

            }
            connection555.Close();

            SqlConnection connection29 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection29.Open();
            string sql29 = "SELECT * FROM Food Where Id=1";
            SqlCommand command29 = new SqlCommand(sql29, connection29);
            SqlDataReader reader = command29.ExecuteReader();

            while (reader.Read())
            {


                price1 = (int)reader["FoodPrice"];
                name1 = reader["FoodName"].ToString();
                pic1 = reader["FoodPic"].ToString();



            }
            connection29.Close();
            pictureBox1.ImageLocation = pic1;

            button1.Text = "Update " + name1;
            textBox1.Text = name1 + " " + price1 + " tk";

            SqlConnection connection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection2.Open();
            string sq2 = "SELECT * FROM Food Where Id=2";
            SqlCommand command2 = new SqlCommand(sq2, connection2);
            SqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {

                price2 = (int)reader2["FoodPrice"];
                name2 = reader2["FoodName"].ToString();
                pic2 = reader2["FoodPic"].ToString();



            }
            connection2.Close();
            pictureBox2.ImageLocation = pic2;
            button2.Text = "Update " + name2;
            textBox2.Text = name2 + " " + price2 + " tk";

            SqlConnection connection3 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection3.Open();
            string sq3 = "SELECT * FROM Food Where Id=3";
            SqlCommand command3 = new SqlCommand(sq3, connection3);
            SqlDataReader reader3 = command3.ExecuteReader();

            while (reader3.Read())
            {

                price3 = (int)reader3["FoodPrice"];
                name3 = reader3["FoodName"].ToString();
                pic3 = reader3["FoodPic"].ToString();



            }
            connection3.Close();
            pictureBox3.ImageLocation = pic3;
            button3.Text = "Update " + name3;
            textBox3.Text = name3 + " " + price3 + " tk";

            SqlConnection connection4 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection4.Open();
            string sq4 = "SELECT * FROM Food Where Id=4";
            SqlCommand command4 = new SqlCommand(sq4, connection4);
            SqlDataReader reader4 = command4.ExecuteReader();

            while (reader4.Read())
            {

                price4 = (int)reader4["FoodPrice"];
                name4 = reader4["FoodName"].ToString();
                pic4 = reader4["FoodPic"].ToString();



            }
            connection4.Close();
            pictureBox4.ImageLocation = pic4;
            button4.Text = "Update " + name4;
            textBox4.Text = name4 + " " + price4 + " tk";

            SqlConnection connection5 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection5.Open();
            string sq5 = "SELECT * FROM Food Where Id=5";
            SqlCommand command5 = new SqlCommand(sq5, connection5);
            SqlDataReader reader5 = command5.ExecuteReader();

            while (reader5.Read())
            {

                price5 = (int)reader5["FoodPrice"];
                name5 = reader5["FoodName"].ToString();
                pic5 = reader5["FoodPic"].ToString();



            }
            connection5.Close();
            pictureBox5.ImageLocation = pic5;
            button5.Text = "Update " + name5;
            textBox5.Text = name5 + " " + price5 + " tk";

            SqlConnection connection6 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection6.Open();
            string sq6 = "SELECT * FROM Food Where Id=6";
            SqlCommand command6 = new SqlCommand(sq6, connection6);
            SqlDataReader reader6 = command6.ExecuteReader();

            while (reader6.Read())
            {

                price6 = (int)reader6["FoodPrice"];
                name6 = reader6["FoodName"].ToString();
                pic6 = reader6["FoodPic"].ToString();



            }
            connection6.Close();
            pictureBox6.ImageLocation = pic6;
            button6.Text = "Update " + name6;
            textBox6.Text = name6 + " " + price6 + " tk";

            SqlConnection connection7 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection7.Open();
            string sq7 = "SELECT * FROM Food Where Id=7";
            SqlCommand command7 = new SqlCommand(sq7, connection7);
            SqlDataReader reader7 = command7.ExecuteReader();

            while (reader7.Read())
            {

                price7 = (int)reader7["FoodPrice"];
                name7 = reader7["FoodName"].ToString();
                pic7 = reader7["FoodPic"].ToString();



            }
            connection7.Close();
            pictureBox7.ImageLocation = pic7;
            button7.Text = "Update " + name7;
            textBox7.Text = name7 + " " + price7 + " tk";

            SqlConnection connection8 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection8.Open();
            string sq8 = "SELECT * FROM Food Where Id=8";
            SqlCommand command8 = new SqlCommand(sq8, connection8);
            SqlDataReader reader8 = command8.ExecuteReader();

            while (reader8.Read())
            {

                price8 = (int)reader8["FoodPrice"];
                name8 = reader8["FoodName"].ToString();
                pic8 = reader8["FoodPic"].ToString();



            }
            connection8.Close();
            pictureBox8.ImageLocation = pic8;
            button8.Text = "Update " + name8;
            textBox8.Text = name8 + " " + price8 + " tk";

          
            if (add.ElementAt(9)=="added")
            {
                panel9.Visible = true;
                SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection9.Open();
                string sq9 = "SELECT * FROM Food Where Id=9";
                SqlCommand command9 = new SqlCommand(sq9, connection9);
                SqlDataReader reader9 = command9.ExecuteReader();

                while (reader9.Read())
                {

                    price9 = (int)reader9["FoodPrice"];
                    name9 = reader9["FoodName"].ToString();
                    pic9 = reader9["FoodPic"].ToString();



                }
                connection9.Close();
                pictureBox10.ImageLocation = pic9;
                button12.Text = "Update " + name9;
                textBox11.Text = name9 + " " + price9 + " tk";
            }
            else if(add.ElementAt(9) == "not")
            {
                panel9.Visible = false;
            }

           
            if (add.ElementAt(10) == "added")
            {
                panel10.Visible = true;
                SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection9.Open();
                string sq9 = "SELECT * FROM Food Where Id=10";
                SqlCommand command9 = new SqlCommand(sq9, connection9);
                SqlDataReader reader9 = command9.ExecuteReader();

                while (reader9.Read())
                {

                    price10 = (int)reader9["FoodPrice"];
                    name10 = reader9["FoodName"].ToString();
                    pic10 = reader9["FoodPic"].ToString();



                }
                connection9.Close();
                pictureBox11.ImageLocation = pic10;
                button13.Text = "Update " + name10;
                textBox12.Text = name10 + " " + price10 + " tk";
            }
            else if (add.ElementAt(10) == "not")
            {
                panel10.Visible = false;
            }

            panel11.Visible = false;
            if (add.ElementAt(11) == "added")
            {
                panel11.Visible = true;
                SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection9.Open();
                string sq9 = "SELECT * FROM Food Where Id=11";
                SqlCommand command9 = new SqlCommand(sq9, connection9);
                SqlDataReader reader9 = command9.ExecuteReader();

                while (reader9.Read())
                {

                    price11 = (int)reader9["FoodPrice"];
                    name11 = reader9["FoodName"].ToString();
                    pic11 = reader9["FoodPic"].ToString();



                }
                connection9.Close();
                pictureBox12.ImageLocation = pic11;
                button14.Text = "Update " + name11;
                textBox13.Text = name11 + " " + price11 + " tk";
            }
            else if (add.ElementAt(11) == "not")
            {
                panel11.Visible = false;
            }

            panel12.Visible = false;
            if (add.ElementAt(12) == "added")
            {
                panel12.Visible = true;
                SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection9.Open();
                string sq9 = "SELECT * FROM Food Where Id=12";
                SqlCommand command9 = new SqlCommand(sq9, connection9);
                SqlDataReader reader9 = command9.ExecuteReader();

                while (reader9.Read())
                {

                    price12 = (int)reader9["FoodPrice"];
                    name12 = reader9["FoodName"].ToString();
                    pic12 = reader9["FoodPic"].ToString();



                }
                connection9.Close();
                pictureBox13.ImageLocation = pic12;
                button15.Text = "Update " + name12;
                textBox14.Text = name12 + " " + price12 + " tk";
            }
            else if (add.ElementAt(12) == "not")
            {
                panel12.Visible = false;
            }

            panel13.Visible = false;
            if (add.ElementAt(13) == "added")
            {
                panel13.Visible = true;
                SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection9.Open();
                string sq9 = "SELECT * FROM Food Where Id=13";
                SqlCommand command9 = new SqlCommand(sq9, connection9);
                SqlDataReader reader9 = command9.ExecuteReader();

                while (reader9.Read())
                {

                    price13 = (int)reader9["FoodPrice"];
                    name13 = reader9["FoodName"].ToString();
                    pic13 = reader9["FoodPic"].ToString();



                }
                connection9.Close();
                pictureBox14.ImageLocation = pic13;
                button16.Text = "Update " + name13;
                textBox15.Text = name13 + " " + price13 + " tk";
            }
            else if (add.ElementAt(13) == "not")
            {
                panel13.Visible = false;
            }

            panel14.Visible = false;
            if (add.ElementAt(14) == "added" )
            {
                panel14.Visible = true;
                SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection9.Open();
                string sq9 = "SELECT * FROM Food Where Id=14";
                SqlCommand command9 = new SqlCommand(sq9, connection9);
                SqlDataReader reader9 = command9.ExecuteReader();

                while (reader9.Read())
                {

                    price14 = (int)reader9["FoodPrice"];
                    name14 = reader9["FoodName"].ToString();
                    pic14 = reader9["FoodPic"].ToString();



                }
                connection9.Close();
                pictureBox15.ImageLocation = pic14;
                button17.Text = "Update " + name14;
                textBox16.Text = name14 + " " + price14 + " tk";
            }
            else if (add.ElementAt(14) == "not")
            {
                panel14.Visible = false;
            }

            panel15.Visible = false;
            if (add.ElementAt(15) == "added")
            {
                panel15.Visible = true;
                SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection9.Open();
                string sq9 = "SELECT * FROM Food Where Id=15";
                SqlCommand command9 = new SqlCommand(sq9, connection9);
                SqlDataReader reader9 = command9.ExecuteReader();

                while (reader9.Read())
                {

                    price15 = (int)reader9["FoodPrice"];
                    name15 = reader9["FoodName"].ToString();
                    pic15 = reader9["FoodPic"].ToString();



                }
                connection9.Close();
                pictureBox16.ImageLocation = pic15;
                button18.Text = "Update " + name15;
                textBox17.Text = name15 + " " + price15 + " tk";
            }
            else if (add.ElementAt(15) == "not")
            {
                panel15.Visible = false;
            }

            panel16.Visible = false;
            if (add.ElementAt(16) == "added")
            {
                panel16.Visible = true;
                SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection9.Open();
                string sq9 = "SELECT * FROM Food Where Id=16";
                SqlCommand command9 = new SqlCommand(sq9, connection9);
                SqlDataReader reader9 = command9.ExecuteReader();

                while (reader9.Read())
                {

                    price16 = (int)reader9["FoodPrice"];
                    name16 = reader9["FoodName"].ToString();
                    pic16 = reader9["FoodPic"].ToString();



                }
                connection9.Close();
                pictureBox17.ImageLocation = pic16;
                button19.Text = "Update " + name16;
                textBox18.Text = name16 + " " + price16 + " tk";
            }
            else if (add.ElementAt(16) == "not")
            {
                panel16.Visible = false;
            }

            panel17.Visible = false;
            if (add.ElementAt(17) == "added")
            {
                panel17.Visible = true;
                SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection9.Open();
                string sq9 = "SELECT * FROM Food Where Id=17";
                SqlCommand command9 = new SqlCommand(sq9, connection9);
                SqlDataReader reader9 = command9.ExecuteReader();

                while (reader9.Read())
                {

                    price17 = (int)reader9["FoodPrice"];
                    name17 = reader9["FoodName"].ToString();
                    pic17 = reader9["FoodPic"].ToString();



                }
                connection9.Close();
                pictureBox18.ImageLocation = pic17;
                button20.Text = "Update " + name17;
                textBox19.Text = name17 + " " + price17 + " tk";
            }
            else if (add.ElementAt(17) == "not")
            {
                panel17.Visible = false;
            }


            panel21.Visible = false;
            if (add.ElementAt(18) == "added")
            {
                panel21.Visible = true;
                SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection9.Open();
                string sq9 = "SELECT * FROM Food Where Id=18";
                SqlCommand command9 = new SqlCommand(sq9, connection9);
                SqlDataReader reader9 = command9.ExecuteReader();

                while (reader9.Read())
                {

                    price18 = (int)reader9["FoodPrice"];
                    name18 = reader9["FoodName"].ToString();
                    pic18 = reader9["FoodPic"].ToString();



                }
                connection9.Close();
                pictureBox19.ImageLocation = pic18;
                button21.Text = "Update " + name18;
                textBox20.Text = name18 + " " + price18 + " tk";
            }
            else if (add.ElementAt(18) == "not")
            {
                panel21.Visible = false;
            }

            panel24.Visible = false;
            if (add.ElementAt(19) == "added")
            {
                panel24.Visible = true;
                SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection9.Open();
                string sq9 = "SELECT * FROM Food Where Id=19";
                SqlCommand command9 = new SqlCommand(sq9, connection9);
                SqlDataReader reader9 = command9.ExecuteReader();

                while (reader9.Read())
                {

                    price19 = (int)reader9["FoodPrice"];
                    name19 = reader9["FoodName"].ToString();
                    pic19 = reader9["FoodPic"].ToString();



                }
                connection9.Close();
                pictureBox20.ImageLocation = pic19;
                button22.Text = "Update " + name19;
                textBox21.Text = name19 + " " + price19 + " tk";
            }
            else if (add.ElementAt(19) == "not")
            {
                panel24.Visible = false;
            }

            panel25.Visible = false;
            if (add.ElementAt(20) == "added")
            {
                panel25.Visible = true;
                SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection9.Open();
                string sq9 = "SELECT * FROM Food Where Id=20";
                SqlCommand command9 = new SqlCommand(sq9, connection9);
                SqlDataReader reader9 = command9.ExecuteReader();

                while (reader9.Read())
                {

                    price20 = (int)reader9["FoodPrice"];
                    name20 = reader9["FoodName"].ToString();
                    pic20 = reader9["FoodPic"].ToString();



                }
                connection9.Close();
                pictureBox21.ImageLocation = pic20;
                button23.Text = "Update " + name20;
                textBox22.Text = name20 + " " + price20 + " tk";
            }
            else if (add.ElementAt(20) == "not")
            {
                panel25.Visible = false;
            }

            panel26.Visible = false;
            if (add.ElementAt(21) == "added")
            {
                panel26.Visible = true;
                SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection9.Open();
                string sq9 = "SELECT * FROM Food Where Id=21";
                SqlCommand command9 = new SqlCommand(sq9, connection9);
                SqlDataReader reader9 = command9.ExecuteReader();

                while (reader9.Read())
                {

                    price21 = (int)reader9["FoodPrice"];
                    name21 = reader9["FoodName"].ToString();
                    pic21 = reader9["FoodPic"].ToString();



                }
                connection9.Close();
                pictureBox22.ImageLocation = pic21;
                button24.Text = "Update " + name21;
                textBox23.Text = name21 + " " + price21 + " tk";
            }
            else if (add.ElementAt(21) == "not")
            {
                panel26.Visible = false;
            }

            panel27.Visible = false;
            if (add.ElementAt(22) == "added")
            {
                panel27.Visible = true;
                SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection9.Open();
                string sq9 = "SELECT * FROM Food Where Id=22";
                SqlCommand command9 = new SqlCommand(sq9, connection9);
                SqlDataReader reader9 = command9.ExecuteReader();

                while (reader9.Read())
                {

                    price22 = (int)reader9["FoodPrice"];
                    name22 = reader9["FoodName"].ToString();
                    pic22 = reader9["FoodPic"].ToString();



                }
                connection9.Close();
                pictureBox23.ImageLocation = pic22;
                button25.Text = "Update " + name22;
                textBox24.Text = name22 + " " + price22 + " tk";
            }
            else if (add.ElementAt(22) == "not")
            {
                panel27.Visible = false;
            }

            panel28.Visible = false;
            if (add.ElementAt(23) == "added")
            {
                panel28.Visible = true;

                SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection9.Open();
                string sq9 = "SELECT * FROM Food Where Id=23";
                SqlCommand command9 = new SqlCommand(sq9, connection9);
                SqlDataReader reader9 = command9.ExecuteReader();

                while (reader9.Read())
                {

                    price23 = (int)reader9["FoodPrice"];
                    name23 = reader9["FoodName"].ToString();
                    pic23 = reader9["FoodPic"].ToString();



                }
                connection9.Close();
                pictureBox24.ImageLocation = pic23;
                button26.Text = "Update " + name23;
                textBox25.Text = name23 + " " + price23 + " tk";
            }
            else if (add.ElementAt(23) == "not")
            {
                panel28.Visible = false;
            }

            panel32.Visible = false;
            if (add.ElementAt(24) == "added")
            {
                panel32.Visible = true;
                SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection9.Open();
                string sq9 = "SELECT * FROM Food Where Id=24";
                SqlCommand command9 = new SqlCommand(sq9, connection9);
                SqlDataReader reader9 = command9.ExecuteReader();

                while (reader9.Read())
                {

                    price24 = (int)reader9["FoodPrice"];
                    name24 = reader9["FoodName"].ToString();
                    pic24 = reader9["FoodPic"].ToString();



                }
                connection9.Close();
                pictureBox25.ImageLocation = pic24;
                button27.Text = "Update " + name24;
                textBox26.Text = name24 + " " + price24 + " tk";
            }
            else if (add.ElementAt(24) == "not")
            {
                panel32.Visible = false;
            }

            panel33.Visible = false;
            if (add.ElementAt(25) == "added")
            {
                panel33.Visible = true;
                SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection9.Open();
                string sq9 = "SELECT * FROM Food Where Id=25";
                SqlCommand command9 = new SqlCommand(sq9, connection9);
                SqlDataReader reader9 = command9.ExecuteReader();

                while (reader9.Read())
                {

                    price25 = (int)reader9["FoodPrice"];
                    name25 = reader9["FoodName"].ToString();
                    pic25 = reader9["FoodPic"].ToString();



                }
                connection9.Close();
                pictureBox26.ImageLocation = pic25;
                button28.Text = "Update " + name25;
                textBox27.Text = name25 + " " + price25 + " tk";
            }
            else if (add.ElementAt(25) == "not")
            {
                panel33.Visible = false;
            }

            panel34.Visible = false;
            if (add.ElementAt(26) == "added")
            {
                panel34.Visible = true;
                SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection9.Open();
                string sq9 = "SELECT * FROM Food Where Id=26";
                SqlCommand command9 = new SqlCommand(sq9, connection9);
                SqlDataReader reader9 = command9.ExecuteReader();

                while (reader9.Read())
                {

                    price26 = (int)reader9["FoodPrice"];
                    name26 = reader9["FoodName"].ToString();
                    pic26 = reader9["FoodPic"].ToString();



                }
                connection9.Close();
                pictureBox27.ImageLocation = pic26;
                button29.Text = "Update " + name26;
                textBox28.Text = name26 + " " + price26 + " tk";
            }
            else if (add.ElementAt(26) == "not")
            {
                panel34.Visible = false;
            }

            panel35.Visible = false;
            if (add.ElementAt(27) == "added")
            {
                panel35.Visible = true;
                SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection9.Open();
                string sq9 = "SELECT * FROM Food Where Id=27";
                SqlCommand command9 = new SqlCommand(sq9, connection9);
                SqlDataReader reader9 = command9.ExecuteReader();

                while (reader9.Read())
                {

                    price27 = (int)reader9["FoodPrice"];
                    name27 = reader9["FoodName"].ToString();
                    pic27 = reader9["FoodPic"].ToString();



                }
                connection9.Close();
                pictureBox28.ImageLocation = pic27;
                button30.Text = "Update " + name27;
                textBox29.Text = name27 + " " + price27 + " tk";
            }
            else if (add.ElementAt(27) == "not")
            {
                panel35.Visible = false;
            }

            panel36.Visible = false;
            if (add.ElementAt(28) == "added")
            {
                panel36.Visible = true;
                SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection9.Open();
                string sq9 = "SELECT * FROM Food Where Id=28";
                SqlCommand command9 = new SqlCommand(sq9, connection9);
                SqlDataReader reader9 = command9.ExecuteReader();

                while (reader9.Read())
                {

                    price28 = (int)reader9["FoodPrice"];
                    name28 = reader9["FoodName"].ToString();
                    pic28 = reader9["FoodPic"].ToString();



                }
                connection9.Close();
                pictureBox29.ImageLocation = pic28;
                button31.Text = "Update " + name28;
                textBox30.Text = name28 + " " + price28 + " tk";
            }
            else if (add.ElementAt(28) == "not")
            {
                panel36.Visible = false;
            }

            panel37.Visible = false;
            if (add.ElementAt(29) == "added")
            {
                panel37.Visible = true;
                SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection9.Open();
                string sq9 = "SELECT * FROM Food Where Id=29";
                SqlCommand command9 = new SqlCommand(sq9, connection9);
                SqlDataReader reader9 = command9.ExecuteReader();

                while (reader9.Read())
                {

                    price29 = (int)reader9["FoodPrice"];
                    name29 = reader9["FoodName"].ToString();
                    pic29 = reader9["FoodPic"].ToString();



                }
                connection9.Close();
                pictureBox30.ImageLocation = pic29;
                button32.Text = "Update " + name29;
                textBox31.Text = name29 + " " + price29 + " tk";
            }
            else if (add.ElementAt(29) == "not")
            {
                panel37.Visible = false;
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
            pictureBox9.ImageLocation = pic1;
            textBox9.Text = name1;
            realname1 = name1;
            textBox10.Text = price1.ToString();
            powerid = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Namelab1.Visible = true;
            Pricelab1.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            Update1.Visible = true;
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
            textBox9.Text = name2;
            realname1 = name2;
            textBox10.Text = price2.ToString();
            pictureBox9.ImageLocation = pic2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = name3;
            realname1 = name3;
            textBox10.Text = price3.ToString();
            pictureBox9.ImageLocation = pic3; 
            powerid = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = name4;
            realname1 = name4;
            textBox10.Text = price4.ToString();
            pictureBox9.ImageLocation = pic4; 
            powerid = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = name5;
            realname1 = name5;
            textBox10.Text = price5.ToString();
            pictureBox9.ImageLocation = pic5; 
            powerid = 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = name6;
            realname1 = name6;
            textBox10.Text = price6.ToString();
            pictureBox9.ImageLocation = pic6; 
            powerid = 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = name7;
            realname1 = name7;
            textBox10.Text = price7.ToString();
            pictureBox9.ImageLocation = pic7; 
            powerid = 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = name8;
            realname1 = name8;
            textBox10.Text = price8.ToString();
            pictureBox9.ImageLocation = pic8; 
            powerid = 8;
        }
        List<int> slist = new List<int>();
        List<string> add = new List<string>();
        private void Update1_Click(object sender, EventArgs e)
        {
            

                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection.Open();
                string sql = "UPDATE Food SET FoodName='" + textBox9.Text + "',FoodPic='" + pictureBox9.ImageLocation + "',FoodPrice='" + textBox10.Text + "'WHERE Id=" + powerid;
                SqlCommand command = new SqlCommand(sql, connection);
                int diary = command.ExecuteNonQuery();

                if (diary > 0)
                {
                    MessageBox.Show("Updated");
                add.Clear();
                textBox9.Text = textBox10.Text = String.Empty;
                    groupbox1.Visible = false;
                    Namelab1.Visible = false;
                    Pricelab1.Visible = false;
                    textBox9.Visible = false;
                    textBox10.Visible = false;
                    Update1.Visible = false;
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

                SqlConnection connection555 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection555.Open();
                string sql555 = "SELECT * FROM Food";
                SqlCommand command555 = new SqlCommand(sql555, connection555);
                SqlDataReader reader555 = command555.ExecuteReader();

                while (reader555.Read())
                {

                    add.Add((string)reader555["Added"]);

                }
                connection555.Close();

                SqlConnection connection29 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection29.Open();
                string sql29 = "SELECT * FROM Food Where Id=1";
                SqlCommand command29 = new SqlCommand(sql29, connection29);
                SqlDataReader reader = command29.ExecuteReader();

                while (reader.Read())
                {


                    price1 = (int)reader["FoodPrice"];
                    name1 = reader["FoodName"].ToString();
                    pic1 = reader["FoodPic"].ToString();



                }
                connection29.Close();
                pictureBox1.ImageLocation = pic1;

                button1.Text = "Update " + name1;
                textBox1.Text = name1 + " " + price1 + " tk";

                SqlConnection connection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection2.Open();
                string sq2 = "SELECT * FROM Food Where Id=2";
                SqlCommand command2 = new SqlCommand(sq2, connection2);
                SqlDataReader reader2 = command2.ExecuteReader();

                while (reader2.Read())
                {

                    price2 = (int)reader2["FoodPrice"];
                    name2 = reader2["FoodName"].ToString();
                    pic2 = reader2["FoodPic"].ToString();



                }
                connection2.Close();
                pictureBox2.ImageLocation = pic2;
                button2.Text = "Update " + name2;
                textBox2.Text = name2 + " " + price2 + " tk";

                SqlConnection connection3 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection3.Open();
                string sq3 = "SELECT * FROM Food Where Id=3";
                SqlCommand command3 = new SqlCommand(sq3, connection3);
                SqlDataReader reader3 = command3.ExecuteReader();

                while (reader3.Read())
                {

                    price3 = (int)reader3["FoodPrice"];
                    name3 = reader3["FoodName"].ToString();
                    pic3 = reader3["FoodPic"].ToString();



                }
                connection3.Close();
                pictureBox3.ImageLocation = pic3;
                button3.Text = "Update " + name3;
                textBox3.Text = name3 + " " + price3 + " tk";

                SqlConnection connection4 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection4.Open();
                string sq4 = "SELECT * FROM Food Where Id=4";
                SqlCommand command4 = new SqlCommand(sq4, connection4);
                SqlDataReader reader4 = command4.ExecuteReader();

                while (reader4.Read())
                {

                    price4 = (int)reader4["FoodPrice"];
                    name4 = reader4["FoodName"].ToString();
                    pic4 = reader4["FoodPic"].ToString();



                }
                connection4.Close();
                pictureBox4.ImageLocation = pic4;
                button4.Text = "Update " + name4;
                textBox4.Text = name4 + " " + price4 + " tk";

                SqlConnection connection5 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection5.Open();
                string sq5 = "SELECT * FROM Food Where Id=5";
                SqlCommand command5 = new SqlCommand(sq5, connection5);
                SqlDataReader reader5 = command5.ExecuteReader();

                while (reader5.Read())
                {

                    price5 = (int)reader5["FoodPrice"];
                    name5 = reader5["FoodName"].ToString();
                    pic5 = reader5["FoodPic"].ToString();



                }
                connection5.Close();
                pictureBox5.ImageLocation = pic5;
                button5.Text = "Update " + name5;
                textBox5.Text = name5 + " " + price5 + " tk";

                SqlConnection connection6 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection6.Open();
                string sq6 = "SELECT * FROM Food Where Id=6";
                SqlCommand command6 = new SqlCommand(sq6, connection6);
                SqlDataReader reader6 = command6.ExecuteReader();

                while (reader6.Read())
                {

                    price6 = (int)reader6["FoodPrice"];
                    name6 = reader6["FoodName"].ToString();
                    pic6 = reader6["FoodPic"].ToString();



                }
                connection6.Close();
                pictureBox6.ImageLocation = pic6;
                button6.Text = "Update " + name6;
                textBox6.Text = name6 + " " + price6 + " tk";

                SqlConnection connection7 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection7.Open();
                string sq7 = "SELECT * FROM Food Where Id=7";
                SqlCommand command7 = new SqlCommand(sq7, connection7);
                SqlDataReader reader7 = command7.ExecuteReader();

                while (reader7.Read())
                {

                    price7 = (int)reader7["FoodPrice"];
                    name7 = reader7["FoodName"].ToString();
                    pic7 = reader7["FoodPic"].ToString();



                }
                connection7.Close();
                pictureBox7.ImageLocation = pic7;
                button7.Text = "Update " + name7;
                textBox7.Text = name7 + " " + price7 + " tk";

                SqlConnection connection8 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection8.Open();
                string sq8 = "SELECT * FROM Food Where Id=8";
                SqlCommand command8 = new SqlCommand(sq8, connection8);
                SqlDataReader reader8 = command8.ExecuteReader();

                while (reader8.Read())
                {

                    price8 = (int)reader8["FoodPrice"];
                    name8 = reader8["FoodName"].ToString();
                    pic8 = reader8["FoodPic"].ToString();



                }
                connection8.Close();
                pictureBox8.ImageLocation = pic8;
                button8.Text = "Update " + name8;
                textBox8.Text = name8 + " " + price8 + " tk";

                if (add.ElementAt(9) == "added")
                {
                    panel9.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=9";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price9 = (int)reader9["FoodPrice"];
                        name9 = reader9["FoodName"].ToString();
                        pic9 = reader9["FoodPic"].ToString();



                    }
                    connection8.Close();
                    pictureBox10.ImageLocation = pic9;
                    button12.Text = "Update " + name9;
                    textBox11.Text = name9 + " " + price9 + " tk";
                }
                else if (add.ElementAt(9) == "not")
                {
                    panel9.Visible = false;
                }

                if (add.ElementAt(10) == "added")
                {
                    panel10.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=10";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price10 = (int)reader9["FoodPrice"];
                        name10 = reader9["FoodName"].ToString();
                        pic10 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox11.ImageLocation = pic10;
                    button13.Text = "Update " + name10;
                    textBox12.Text = name10 + " " + price10 + " tk";
                }
                else if (add.ElementAt(10) == "not")
                {
                    panel10.Visible = false;
                }

                if (add.ElementAt(11) == "added")
                {
                    panel11.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=11";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price11 = (int)reader9["FoodPrice"];
                        name11 = reader9["FoodName"].ToString();
                        pic11 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox12.ImageLocation = pic11;
                    button14.Text = "Update " + name11;
                    textBox13.Text = name11 + " " + price11 + " tk";
                }
                else if (add.ElementAt(11) == "not")
                {
                    panel11.Visible = false;
                }

                if (add.ElementAt(12) == "added")
                {
                    panel12.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=12";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price12 = (int)reader9["FoodPrice"];
                        name12 = reader9["FoodName"].ToString();
                        pic12 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox13.ImageLocation = pic12;
                    button15.Text = "Update " + name12;
                    textBox14.Text = name12 + " " + price12 + " tk";
                }
                else if (add.ElementAt(12) == "not")
                {
                    panel12.Visible = false;
                }

                if (add.ElementAt(13) == "added")
                {
                    panel13.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=13";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price13 = (int)reader9["FoodPrice"];
                        name13 = reader9["FoodName"].ToString();
                        pic13 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox14.ImageLocation = pic13;
                    button16.Text = "Update " + name13;
                    textBox15.Text = name13 + " " + price13 + " tk";
                }
                else if (add.ElementAt(13) == "not")
                {
                    panel13.Visible = false;
                }

                if (add.ElementAt(14) == "added")
                {
                    panel14.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=14";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price14 = (int)reader9["FoodPrice"];
                        name14 = reader9["FoodName"].ToString();
                        pic14 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox15.ImageLocation = pic14;
                    button17.Text = "Update " + name14;
                    textBox16.Text = name14 + " " + price14 + " tk";
                }
                else if (add.ElementAt(14) == "not")
                {
                    panel14.Visible = false;
                }

                if (add.ElementAt(15) == "added")
                {
                    panel15.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=15";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price15 = (int)reader9["FoodPrice"];
                        name15 = reader9["FoodName"].ToString();
                        pic15 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox16.ImageLocation = pic15;
                    button18.Text = "Update " + name15;
                    textBox17.Text = name15 + " " + price15 + " tk";
                }
                else if (add.ElementAt(15) == "not")
                {
                    panel15.Visible = false;
                }

                if (add.ElementAt(16) == "added")
                {
                    panel16.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=16";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price16 = (int)reader9["FoodPrice"];
                        name16 = reader9["FoodName"].ToString();
                        pic16 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox17.ImageLocation = pic16;
                    button19.Text = "Update " + name16;
                    textBox18.Text = name16 + " " + price16 + " tk";
                }
                else if (add.ElementAt(16) == "not")
                {
                    panel16.Visible = false;
                }

                if (add.ElementAt(17) == "added")
                {
                    panel17.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=17";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price17 = (int)reader9["FoodPrice"];
                        name17 = reader9["FoodName"].ToString();
                        pic17 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox18.ImageLocation = pic17;
                    button20.Text = "Update " + name17;
                    textBox19.Text = name17 + " " + price17 + " tk";
                }
                else if (add.ElementAt(17) == "not")
                {
                    panel17.Visible = false;
                }


                if (add.ElementAt(18) == "added")
                {
                    panel21.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=18";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price18 = (int)reader9["FoodPrice"];
                        name18 = reader9["FoodName"].ToString();
                        pic18 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox19.ImageLocation = pic18;
                    button21.Text = "Update " + name18;
                    textBox20.Text = name18 + " " + price18 + " tk";
                }
                else if (add.ElementAt(18) == "not")
                {
                    panel21.Visible = false;
                }

                if (add.ElementAt(19) == "added")
                {
                    panel24.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=19";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price19 = (int)reader9["FoodPrice"];
                        name19 = reader9["FoodName"].ToString();
                        pic19 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox20.ImageLocation = pic19;
                    button22.Text = "Update " + name19;
                    textBox21.Text = name19 + " " + price19 + " tk";
                }
                else if (add.ElementAt(19) == "not")
                {
                    panel24.Visible = false;
                }

                if (add.ElementAt(20) == "added")
                {
                    panel25.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=20";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price20 = (int)reader9["FoodPrice"];
                        name20 = reader9["FoodName"].ToString();
                        pic20 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox21.ImageLocation = pic20;
                    button23.Text = "Update " + name20;
                    textBox22.Text = name20 + " " + price20 + " tk";
                }
                else if (add.ElementAt(20) == "not")
                {
                    panel25.Visible = false;
                }

                if (add.ElementAt(21) == "added")
                {
                    panel26.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=21";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price21 = (int)reader9["FoodPrice"];
                        name21 = reader9["FoodName"].ToString();
                        pic21 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox22.ImageLocation = pic21;
                    button24.Text = "Update " + name21;
                    textBox23.Text = name21 + " " + price21 + " tk";
                }
                else if (add.ElementAt(21) == "not")
                {
                    panel26.Visible = false;
                }

                if (add.ElementAt(22) == "added")
                {
                    panel27.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=22";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price22 = (int)reader9["FoodPrice"];
                        name22 = reader9["FoodName"].ToString();
                        pic22 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox23.ImageLocation = pic22;
                    button25.Text = "Update " + name22;
                    textBox24.Text = name22 + " " + price22 + " tk";
                }
                else if (add.ElementAt(22) == "not")
                {
                    panel27.Visible = false;
                }

                if (add.ElementAt(23) == "added")
                {
                    panel28.Visible = true;

                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=23";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price23 = (int)reader9["FoodPrice"];
                        name23 = reader9["FoodName"].ToString();
                        pic23 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox24.ImageLocation = pic23;
                    button26.Text = "Update " + name23;
                    textBox25.Text = name23 + " " + price23 + " tk";
                }
                else if (add.ElementAt(23) == "not")
                {
                    panel28.Visible = false;
                }

                if (add.ElementAt(24) == "added")
                {
                    panel32.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=24";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price24 = (int)reader9["FoodPrice"];
                        name24 = reader9["FoodName"].ToString();
                        pic24 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox25.ImageLocation = pic24;
                    button27.Text = "Update " + name24;
                    textBox26.Text = name24 + " " + price24 + " tk";
                }
                else if (add.ElementAt(24) == "not")
                {
                    panel32.Visible = false;
                }

                if (add.ElementAt(25) == "added")
                {
                    panel33.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=25";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price25 = (int)reader9["FoodPrice"];
                        name25 = reader9["FoodName"].ToString();
                        pic25 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox26.ImageLocation = pic25;
                    button28.Text = "Update " + name25;
                    textBox27.Text = name25 + " " + price25 + " tk";
                }
                else if (add.ElementAt(25) == "not")
                {
                    panel33.Visible = false;
                }

                if (add.ElementAt(26) == "added")
                {
                    panel34.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=26";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price26 = (int)reader9["FoodPrice"];
                        name26 = reader9["FoodName"].ToString();
                        pic26 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox27.ImageLocation = pic26;
                    button29.Text = "Update " + name26;
                    textBox28.Text = name26 + " " + price26 + " tk";
                }
                else if (add.ElementAt(26) == "not")
                {
                    panel34.Visible = false;
                }

                if (add.ElementAt(27) == "added")
                {
                    panel35.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=27";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price27 = (int)reader9["FoodPrice"];
                        name27 = reader9["FoodName"].ToString();
                        pic27 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox28.ImageLocation = pic27;
                    button30.Text = "Update " + name27;
                    textBox29.Text = name27 + " " + price27 + " tk";
                }
                else if (add.ElementAt(27) == "not")
                {
                    panel35.Visible = false;
                }

                if (add.ElementAt(28) == "added")
                {
                    panel36.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=28";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price28 = (int)reader9["FoodPrice"];
                        name28 = reader9["FoodName"].ToString();
                        pic28 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox29.ImageLocation = pic28;
                    button31.Text = "Update " + name28;
                    textBox30.Text = name28 + " " + price28 + " tk";
                }
                else if (add.ElementAt(28) == "not")
                {
                    panel36.Visible = false;
                }

                if (add.ElementAt(29) == "added")
                {
                    panel37.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=29";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price29 = (int)reader9["FoodPrice"];
                        name29 = reader9["FoodName"].ToString();
                        pic29 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox30.ImageLocation = pic29;
                    button32.Text = "Update " + name29;
                    textBox31.Text = name29 + " " + price29 + " tk";
                }
                else if (add.ElementAt(29) == "not")
                {
                    panel37.Visible = false;
                }

            }
                else
                {
                    MessageBox.Show("Error");
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

                SqlConnection connection555 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection555.Open();
                string sql555 = "SELECT * FROM Food";
                SqlCommand command555 = new SqlCommand(sql555, connection555);
                SqlDataReader reader555 = command555.ExecuteReader();

                while (reader555.Read())
                {

                    add.Add((string)reader555["Added"]);

                }
                connection555.Close();

                SqlConnection connection29 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection29.Open();
                string sql29 = "SELECT * FROM Food Where Id=1";
                SqlCommand command29 = new SqlCommand(sql29, connection29);
                SqlDataReader reader = command29.ExecuteReader();

                while (reader.Read())
                {


                    price1 = (int)reader["FoodPrice"];
                    name1 = reader["FoodName"].ToString();
                    pic1 = reader["FoodPic"].ToString();



                }
                connection29.Close();
                pictureBox1.ImageLocation = pic1;

                button1.Text = "Update " + name1;
                textBox1.Text = name1 + " " + price1 + " tk";

                SqlConnection connection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection2.Open();
                string sq2 = "SELECT * FROM Food Where Id=2";
                SqlCommand command2 = new SqlCommand(sq2, connection2);
                SqlDataReader reader2 = command2.ExecuteReader();

                while (reader2.Read())
                {

                    price2 = (int)reader2["FoodPrice"];
                    name2 = reader2["FoodName"].ToString();
                    pic2 = reader2["FoodPic"].ToString();



                }
                connection2.Close();
                pictureBox2.ImageLocation = pic2;
                button2.Text = "Update " + name2;
                textBox2.Text = name2 + " " + price2 + " tk";

                SqlConnection connection3 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection3.Open();
                string sq3 = "SELECT * FROM Food Where Id=3";
                SqlCommand command3 = new SqlCommand(sq3, connection3);
                SqlDataReader reader3 = command3.ExecuteReader();

                while (reader3.Read())
                {

                    price3 = (int)reader3["FoodPrice"];
                    name3 = reader3["FoodName"].ToString();
                    pic3 = reader3["FoodPic"].ToString();



                }
                connection3.Close();
                pictureBox3.ImageLocation = pic3;
                button3.Text = "Update " + name3;
                textBox3.Text = name3 + " " + price3 + " tk";

                SqlConnection connection4 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection4.Open();
                string sq4 = "SELECT * FROM Food Where Id=4";
                SqlCommand command4 = new SqlCommand(sq4, connection4);
                SqlDataReader reader4 = command4.ExecuteReader();

                while (reader4.Read())
                {

                    price4 = (int)reader4["FoodPrice"];
                    name4 = reader4["FoodName"].ToString();
                    pic4 = reader4["FoodPic"].ToString();



                }
                connection4.Close();
                pictureBox4.ImageLocation = pic4;
                button4.Text = "Update " + name4;
                textBox4.Text = name4 + " " + price4 + " tk";

                SqlConnection connection5 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection5.Open();
                string sq5 = "SELECT * FROM Food Where Id=5";
                SqlCommand command5 = new SqlCommand(sq5, connection5);
                SqlDataReader reader5 = command5.ExecuteReader();

                while (reader5.Read())
                {

                    price5 = (int)reader5["FoodPrice"];
                    name5 = reader5["FoodName"].ToString();
                    pic5 = reader5["FoodPic"].ToString();



                }
                connection5.Close();
                pictureBox5.ImageLocation = pic5;
                button5.Text = "Update " + name5;
                textBox5.Text = name5 + " " + price5 + " tk";

                SqlConnection connection6 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection6.Open();
                string sq6 = "SELECT * FROM Food Where Id=6";
                SqlCommand command6 = new SqlCommand(sq6, connection6);
                SqlDataReader reader6 = command6.ExecuteReader();

                while (reader6.Read())
                {

                    price6 = (int)reader6["FoodPrice"];
                    name6 = reader6["FoodName"].ToString();
                    pic6 = reader6["FoodPic"].ToString();



                }
                connection6.Close();
                pictureBox6.ImageLocation = pic6;
                button6.Text = "Update " + name6;
                textBox6.Text = name6 + " " + price6 + " tk";

                SqlConnection connection7 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection7.Open();
                string sq7 = "SELECT * FROM Food Where Id=7";
                SqlCommand command7 = new SqlCommand(sq7, connection7);
                SqlDataReader reader7 = command7.ExecuteReader();

                while (reader7.Read())
                {

                    price7 = (int)reader7["FoodPrice"];
                    name7 = reader7["FoodName"].ToString();
                    pic7 = reader7["FoodPic"].ToString();



                }
                connection7.Close();
                pictureBox7.ImageLocation = pic7;
                button7.Text = "Update " + name7;
                textBox7.Text = name7 + " " + price7 + " tk";

                SqlConnection connection8 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection8.Open();
                string sq8 = "SELECT * FROM Food Where Id=8";
                SqlCommand command8 = new SqlCommand(sq8, connection8);
                SqlDataReader reader8 = command8.ExecuteReader();

                while (reader8.Read())
                {

                    price8 = (int)reader8["FoodPrice"];
                    name8 = reader8["FoodName"].ToString();
                    pic8 = reader8["FoodPic"].ToString();



                }
                connection8.Close();
                pictureBox8.ImageLocation = pic8;
                button8.Text = "Update " + name8;
                textBox8.Text = name8 + " " + price8 + " tk";

                if (add.ElementAt(9) == "added")
                {
                    panel9.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=9";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price9 = (int)reader9["FoodPrice"];
                        name9 = reader9["FoodName"].ToString();
                        pic9 = reader9["FoodPic"].ToString();



                    }
                    connection8.Close();
                    pictureBox10.ImageLocation = pic9;
                    button12.Text = "Update " + name9;
                    textBox11.Text = name9 + " " + price9 + " tk";
                }
                else if (add.ElementAt(9) == "not")
                {
                    panel9.Visible = false;
                }

                if (add.ElementAt(10) == "added")
                {
                    panel10.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=10";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price10 = (int)reader9["FoodPrice"];
                        name10 = reader9["FoodName"].ToString();
                        pic10 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox11.ImageLocation = pic10;
                    button13.Text = "Update " + name10;
                    textBox12.Text = name10 + " " + price10 + " tk";
                }
                else if (add.ElementAt(10) == "not")
                {
                    panel10.Visible = false;
                }

                if (add.ElementAt(11) == "added")
                {
                    panel11.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=11";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price11 = (int)reader9["FoodPrice"];
                        name11 = reader9["FoodName"].ToString();
                        pic11 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox12.ImageLocation = pic11;
                    button14.Text = "Update " + name11;
                    textBox13.Text = name11 + " " + price11 + " tk";
                }
                else if (add.ElementAt(11) == "not")
                {
                    panel11.Visible = false;
                }

                if (add.ElementAt(12) == "added")
                {
                    panel12.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=12";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price12 = (int)reader9["FoodPrice"];
                        name12 = reader9["FoodName"].ToString();
                        pic12 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox13.ImageLocation = pic12;
                    button15.Text = "Update " + name12;
                    textBox14.Text = name12 + " " + price12 + " tk";
                }
                else if (add.ElementAt(12) == "not")
                {
                    panel12.Visible = false;
                }

                if (add.ElementAt(13) == "added")
                {
                    panel13.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=13";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price13 = (int)reader9["FoodPrice"];
                        name13 = reader9["FoodName"].ToString();
                        pic13 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox14.ImageLocation = pic13;
                    button16.Text = "Update " + name13;
                    textBox15.Text = name13 + " " + price13 + " tk";
                }
                else if (add.ElementAt(13) == "not")
                {
                    panel13.Visible = false;
                }

                if (add.ElementAt(14) == "added")
                {
                    panel14.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=14";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price14 = (int)reader9["FoodPrice"];
                        name14 = reader9["FoodName"].ToString();
                        pic14 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox15.ImageLocation = pic14;
                    button17.Text = "Update " + name14;
                    textBox16.Text = name14 + " " + price14 + " tk";
                }
                else if (add.ElementAt(14) == "not")
                {
                    panel14.Visible = false;
                }

                if (add.ElementAt(15) == "added")
                {
                    panel15.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=15";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price15 = (int)reader9["FoodPrice"];
                        name15 = reader9["FoodName"].ToString();
                        pic15 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox16.ImageLocation = pic15;
                    button18.Text = "Update " + name15;
                    textBox17.Text = name15 + " " + price15 + " tk";
                }
                else if (add.ElementAt(15) == "not")
                {
                    panel15.Visible = false;
                }

                if (add.ElementAt(16) == "added")
                {
                    panel16.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=16";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price16 = (int)reader9["FoodPrice"];
                        name16 = reader9["FoodName"].ToString();
                        pic16 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox17.ImageLocation = pic16;
                    button19.Text = "Update " + name16;
                    textBox18.Text = name16 + " " + price16 + " tk";
                }
                else if (add.ElementAt(16) == "not")
                {
                    panel16.Visible = false;
                }

                if (add.ElementAt(17) == "added")
                {
                    panel17.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=17";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price17 = (int)reader9["FoodPrice"];
                        name17 = reader9["FoodName"].ToString();
                        pic17 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox18.ImageLocation = pic17;
                    button20.Text = "Update " + name17;
                    textBox19.Text = name17 + " " + price17 + " tk";
                }
                else if (add.ElementAt(17) == "not")
                {
                    panel17.Visible = false;
                }


                if (add.ElementAt(18) == "added")
                {
                    panel21.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=18";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price18 = (int)reader9["FoodPrice"];
                        name18 = reader9["FoodName"].ToString();
                        pic18 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox19.ImageLocation = pic18;
                    button21.Text = "Update " + name18;
                    textBox20.Text = name18 + " " + price18 + " tk";
                }
                else if (add.ElementAt(18) == "not")
                {
                    panel21.Visible = false;
                }

                if (add.ElementAt(19) == "added")
                {
                    panel24.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=19";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price19 = (int)reader9["FoodPrice"];
                        name19 = reader9["FoodName"].ToString();
                        pic19 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox20.ImageLocation = pic19;
                    button22.Text = "Update " + name19;
                    textBox21.Text = name19 + " " + price19 + " tk";
                }
                else if (add.ElementAt(19) == "not")
                {
                    panel24.Visible = false;
                }

                if (add.ElementAt(20) == "added")
                {
                    panel25.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=20";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price20 = (int)reader9["FoodPrice"];
                        name20 = reader9["FoodName"].ToString();
                        pic20 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox21.ImageLocation = pic20;
                    button23.Text = "Update " + name20;
                    textBox22.Text = name20 + " " + price20 + " tk";
                }
                else if (add.ElementAt(20) == "not")
                {
                    panel25.Visible = false;
                }

                if (add.ElementAt(21) == "added")
                {
                    panel26.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=21";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price21 = (int)reader9["FoodPrice"];
                        name21 = reader9["FoodName"].ToString();
                        pic21 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox22.ImageLocation = pic21;
                    button24.Text = "Update " + name21;
                    textBox23.Text = name21 + " " + price21 + " tk";
                }
                else if (add.ElementAt(21) == "not")
                {
                    panel26.Visible = false;
                }

                if (add.ElementAt(22) == "added")
                {
                    panel27.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=22";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price22 = (int)reader9["FoodPrice"];
                        name22 = reader9["FoodName"].ToString();
                        pic22 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox23.ImageLocation = pic22;
                    button25.Text = "Update " + name22;
                    textBox24.Text = name22 + " " + price22 + " tk";
                }
                else if (add.ElementAt(22) == "not")
                {
                    panel27.Visible = false;
                }

                if (add.ElementAt(23) == "added")
                {
                    panel28.Visible = true;

                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=23";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price23 = (int)reader9["FoodPrice"];
                        name23 = reader9["FoodName"].ToString();
                        pic23 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox24.ImageLocation = pic23;
                    button26.Text = "Update " + name23;
                    textBox25.Text = name23 + " " + price23 + " tk";
                }
                else if (add.ElementAt(23) == "not")
                {
                    panel28.Visible = false;
                }

                if (add.ElementAt(24) == "added")
                {
                    panel32.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=24";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price24 = (int)reader9["FoodPrice"];
                        name24 = reader9["FoodName"].ToString();
                        pic24 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox25.ImageLocation = pic24;
                    button27.Text = "Update " + name24;
                    textBox26.Text = name24 + " " + price24 + " tk";
                }
                else if (add.ElementAt(24) == "not")
                {
                    panel32.Visible = false;
                }

                if (add.ElementAt(25) == "added")
                {
                    panel33.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=25";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price25 = (int)reader9["FoodPrice"];
                        name25 = reader9["FoodName"].ToString();
                        pic25 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox26.ImageLocation = pic25;
                    button28.Text = "Update " + name25;
                    textBox27.Text = name25 + " " + price25 + " tk";
                }
                else if (add.ElementAt(25) == "not")
                {
                    panel33.Visible = false;
                }

                if (add.ElementAt(26) == "added")
                {
                    panel34.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=26";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price26 = (int)reader9["FoodPrice"];
                        name26 = reader9["FoodName"].ToString();
                        pic26 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox27.ImageLocation = pic26;
                    button29.Text = "Update " + name26;
                    textBox28.Text = name26 + " " + price26 + " tk";
                }
                else if (add.ElementAt(26) == "not")
                {
                    panel34.Visible = false;
                }

                if (add.ElementAt(27) == "added")
                {
                    panel35.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=27";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price27 = (int)reader9["FoodPrice"];
                        name27 = reader9["FoodName"].ToString();
                        pic27 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox28.ImageLocation = pic27;
                    button30.Text = "Update " + name27;
                    textBox29.Text = name27 + " " + price27 + " tk";
                }
                else if (add.ElementAt(27) == "not")
                {
                    panel35.Visible = false;
                }

                if (add.ElementAt(28) == "added")
                {
                    panel36.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=28";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price28 = (int)reader9["FoodPrice"];
                        name28 = reader9["FoodName"].ToString();
                        pic28 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox29.ImageLocation = pic28;
                    button31.Text = "Update " + name28;
                    textBox30.Text = name28 + " " + price28 + " tk";
                }
                else if (add.ElementAt(28) == "not")
                {
                    panel36.Visible = false;
                }

                if (add.ElementAt(29) == "added")
                {
                    panel37.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=29";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price29 = (int)reader9["FoodPrice"];
                        name29 = reader9["FoodName"].ToString();
                        pic29 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox30.ImageLocation = pic29;
                    button32.Text = "Update " + name29;
                    textBox31.Text = name29 + " " + price29 + " tk";
                }
                else if (add.ElementAt(29) == "not")
                {
                    panel37.Visible = false;
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
                add.Clear();
                textBox32.Text = String.Empty;
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

                SqlConnection connection555 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection555.Open();
                string sql555 = "SELECT * FROM Food";
                SqlCommand command555 = new SqlCommand(sql555, connection555);
                SqlDataReader reader555 = command555.ExecuteReader();

                while (reader555.Read())
                {

                    add.Add((string)reader555["Added"]);

                }
                connection555.Close();

                SqlConnection connection29 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection29.Open();
                string sql29 = "SELECT * FROM Food Where Id=1";
                SqlCommand command29 = new SqlCommand(sql29, connection29);
                SqlDataReader reader = command29.ExecuteReader();

                while (reader.Read())
                {


                    price1 = (int)reader["FoodPrice"];
                    name1 = reader["FoodName"].ToString();
                    pic1 = reader["FoodPic"].ToString();



                }
                connection29.Close();
                pictureBox1.ImageLocation = pic1;

                button1.Text = "Update " + name1;
                textBox1.Text = name1 + " " + price1 + " tk";

                SqlConnection connection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection2.Open();
                string sq2 = "SELECT * FROM Food Where Id=2";
                SqlCommand command2 = new SqlCommand(sq2, connection2);
                SqlDataReader reader2 = command2.ExecuteReader();

                while (reader2.Read())
                {

                    price2 = (int)reader2["FoodPrice"];
                    name2 = reader2["FoodName"].ToString();
                    pic2 = reader2["FoodPic"].ToString();



                }
                connection2.Close();
                pictureBox2.ImageLocation = pic2;
                button2.Text = "Update " + name2;
                textBox2.Text = name2 + " " + price2 + " tk";

                SqlConnection connection3 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection3.Open();
                string sq3 = "SELECT * FROM Food Where Id=3";
                SqlCommand command3 = new SqlCommand(sq3, connection3);
                SqlDataReader reader3 = command3.ExecuteReader();

                while (reader3.Read())
                {

                    price3 = (int)reader3["FoodPrice"];
                    name3 = reader3["FoodName"].ToString();
                    pic3 = reader3["FoodPic"].ToString();



                }
                connection3.Close();
                pictureBox3.ImageLocation = pic3;
                button3.Text = "Update " + name3;
                textBox3.Text = name3 + " " + price3 + " tk";

                SqlConnection connection4 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection4.Open();
                string sq4 = "SELECT * FROM Food Where Id=4";
                SqlCommand command4 = new SqlCommand(sq4, connection4);
                SqlDataReader reader4 = command4.ExecuteReader();

                while (reader4.Read())
                {

                    price4 = (int)reader4["FoodPrice"];
                    name4 = reader4["FoodName"].ToString();
                    pic4 = reader4["FoodPic"].ToString();



                }
                connection4.Close();
                pictureBox4.ImageLocation = pic4;
                button4.Text = "Update " + name4;
                textBox4.Text = name4 + " " + price4 + " tk";

                SqlConnection connection5 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection5.Open();
                string sq5 = "SELECT * FROM Food Where Id=5";
                SqlCommand command5 = new SqlCommand(sq5, connection5);
                SqlDataReader reader5 = command5.ExecuteReader();

                while (reader5.Read())
                {

                    price5 = (int)reader5["FoodPrice"];
                    name5 = reader5["FoodName"].ToString();
                    pic5 = reader5["FoodPic"].ToString();



                }
                connection5.Close();
                pictureBox5.ImageLocation = pic5;
                button5.Text = "Update " + name5;
                textBox5.Text = name5 + " " + price5 + " tk";

                SqlConnection connection6 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection6.Open();
                string sq6 = "SELECT * FROM Food Where Id=6";
                SqlCommand command6 = new SqlCommand(sq6, connection6);
                SqlDataReader reader6 = command6.ExecuteReader();

                while (reader6.Read())
                {

                    price6 = (int)reader6["FoodPrice"];
                    name6 = reader6["FoodName"].ToString();
                    pic6 = reader6["FoodPic"].ToString();



                }
                connection6.Close();
                pictureBox6.ImageLocation = pic6;
                button6.Text = "Update " + name6;
                textBox6.Text = name6 + " " + price6 + " tk";

                SqlConnection connection7 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection7.Open();
                string sq7 = "SELECT * FROM Food Where Id=7";
                SqlCommand command7 = new SqlCommand(sq7, connection7);
                SqlDataReader reader7 = command7.ExecuteReader();

                while (reader7.Read())
                {

                    price7 = (int)reader7["FoodPrice"];
                    name7 = reader7["FoodName"].ToString();
                    pic7 = reader7["FoodPic"].ToString();



                }
                connection7.Close();
                pictureBox7.ImageLocation = pic7;
                button7.Text = "Update " + name7;
                textBox7.Text = name7 + " " + price7 + " tk";

                SqlConnection connection8 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection8.Open();
                string sq8 = "SELECT * FROM Food Where Id=8";
                SqlCommand command8 = new SqlCommand(sq8, connection8);
                SqlDataReader reader8 = command8.ExecuteReader();

                while (reader8.Read())
                {

                    price8 = (int)reader8["FoodPrice"];
                    name8 = reader8["FoodName"].ToString();
                    pic8 = reader8["FoodPic"].ToString();



                }
                connection8.Close();
                pictureBox8.ImageLocation = pic8;
                button8.Text = "Update " + name8;
                textBox8.Text = name8 + " " + price8 + " tk";

                if (add.ElementAt(9) == "added")
                {
                    panel9.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=9";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price9 = (int)reader9["FoodPrice"];
                        name9 = reader9["FoodName"].ToString();
                        pic9 = reader9["FoodPic"].ToString();



                    }
                    connection8.Close();
                    pictureBox10.ImageLocation = pic9;
                    button12.Text = "Update " + name9;
                    textBox11.Text = name9 + " " + price9 + " tk";
                }
                else if (add.ElementAt(9) == "not")
                {
                    panel9.Visible = false;
                }

                if (add.ElementAt(10) == "added")
                {
                    panel10.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=10";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price10 = (int)reader9["FoodPrice"];
                        name10 = reader9["FoodName"].ToString();
                        pic10 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox11.ImageLocation = pic10;
                    button13.Text = "Update " + name10;
                    textBox12.Text = name10 + " " + price10 + " tk";
                }
                else if (add.ElementAt(10) == "not")
                {
                    panel10.Visible = false;
                }

                if (add.ElementAt(11) == "added")
                {
                    panel11.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=11";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price11 = (int)reader9["FoodPrice"];
                        name11 = reader9["FoodName"].ToString();
                        pic11 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox12.ImageLocation = pic11;
                    button14.Text = "Update " + name11;
                    textBox13.Text = name11 + " " + price11 + " tk";
                }
                else if (add.ElementAt(11) == "not")
                {
                    panel11.Visible = false;
                }

                if (add.ElementAt(12) == "added")
                {
                    panel12.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=12";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price12 = (int)reader9["FoodPrice"];
                        name12 = reader9["FoodName"].ToString();
                        pic12 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox13.ImageLocation = pic12;
                    button15.Text = "Update " + name12;
                    textBox14.Text = name12 + " " + price12 + " tk";
                }
                else if (add.ElementAt(12) == "not")
                {
                    panel12.Visible = false;
                }

                if (add.ElementAt(13) == "added")
                {
                    panel13.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=13";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price13 = (int)reader9["FoodPrice"];
                        name13 = reader9["FoodName"].ToString();
                        pic13 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox14.ImageLocation = pic13;
                    button16.Text = "Update " + name13;
                    textBox15.Text = name13 + " " + price13 + " tk";
                }
                else if (add.ElementAt(13) == "not")
                {
                    panel13.Visible = false;
                }

                if (add.ElementAt(14) == "added")
                {
                    panel14.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=14";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price14 = (int)reader9["FoodPrice"];
                        name14 = reader9["FoodName"].ToString();
                        pic14 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox15.ImageLocation = pic14;
                    button17.Text = "Update " + name14;
                    textBox16.Text = name14 + " " + price14 + " tk";
                }
                else if (add.ElementAt(14) == "not")
                {
                    panel14.Visible = false;
                }

                if (add.ElementAt(15) == "added")
                {
                    panel15.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=15";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price15 = (int)reader9["FoodPrice"];
                        name15 = reader9["FoodName"].ToString();
                        pic15 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox16.ImageLocation = pic15;
                    button18.Text = "Update " + name15;
                    textBox17.Text = name15 + " " + price15 + " tk";
                }
                else if (add.ElementAt(15) == "not")
                {
                    panel15.Visible = false;
                }

                if (add.ElementAt(16) == "added")
                {
                    panel16.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=16";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price16 = (int)reader9["FoodPrice"];
                        name16 = reader9["FoodName"].ToString();
                        pic16 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox17.ImageLocation = pic16;
                    button19.Text = "Update " + name16;
                    textBox18.Text = name16 + " " + price16 + " tk";
                }
                else if (add.ElementAt(16) == "not")
                {
                    panel16.Visible = false;
                }

                if (add.ElementAt(17) == "added")
                {
                    panel17.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=17";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price17 = (int)reader9["FoodPrice"];
                        name17 = reader9["FoodName"].ToString();
                        pic17 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox18.ImageLocation = pic17;
                    button20.Text = "Update " + name17;
                    textBox19.Text = name17 + " " + price17 + " tk";
                }
                else if (add.ElementAt(17) == "not")
                {
                    panel17.Visible = false;
                }


                if (add.ElementAt(18) == "added")
                {
                    panel21.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=18";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price18 = (int)reader9["FoodPrice"];
                        name18 = reader9["FoodName"].ToString();
                        pic18 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox19.ImageLocation = pic18;
                    button21.Text = "Update " + name18;
                    textBox20.Text = name18 + " " + price18 + " tk";
                }
                else if (add.ElementAt(18) == "not")
                {
                    panel21.Visible = false;
                }

                if (add.ElementAt(19) == "added")
                {
                    panel24.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=19";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price19 = (int)reader9["FoodPrice"];
                        name19 = reader9["FoodName"].ToString();
                        pic19 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox20.ImageLocation = pic19;
                    button22.Text = "Update " + name19;
                    textBox21.Text = name19 + " " + price19 + " tk";
                }
                else if (add.ElementAt(19) == "not")
                {
                    panel24.Visible = false;
                }

                if (add.ElementAt(20) == "added")
                {
                    panel25.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=20";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price20 = (int)reader9["FoodPrice"];
                        name20 = reader9["FoodName"].ToString();
                        pic20 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox21.ImageLocation = pic20;
                    button23.Text = "Update " + name20;
                    textBox22.Text = name20 + " " + price20 + " tk";
                }
                else if (add.ElementAt(20) == "not")
                {
                    panel25.Visible = false;
                }

                if (add.ElementAt(21) == "added")
                {
                    panel26.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=21";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price21 = (int)reader9["FoodPrice"];
                        name21 = reader9["FoodName"].ToString();
                        pic21 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox22.ImageLocation = pic21;
                    button24.Text = "Update " + name21;
                    textBox23.Text = name21 + " " + price21 + " tk";
                }
                else if (add.ElementAt(21) == "not")
                {
                    panel26.Visible = false;
                }

                if (add.ElementAt(22) == "added")
                {
                    panel27.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=22";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price22 = (int)reader9["FoodPrice"];
                        name22 = reader9["FoodName"].ToString();
                        pic22 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox23.ImageLocation = pic22;
                    button25.Text = "Update " + name22;
                    textBox24.Text = name22 + " " + price22 + " tk";
                }
                else if (add.ElementAt(22) == "not")
                {
                    panel27.Visible = false;
                }

                if (add.ElementAt(23) == "added")
                {
                    panel28.Visible = true;

                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=23";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price23 = (int)reader9["FoodPrice"];
                        name23 = reader9["FoodName"].ToString();
                        pic23 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox24.ImageLocation = pic23;
                    button26.Text = "Update " + name23;
                    textBox25.Text = name23 + " " + price23 + " tk";
                }
                else if (add.ElementAt(23) == "not")
                {
                    panel28.Visible = false;
                }

                if (add.ElementAt(24) == "added")
                {
                    panel32.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=24";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price24 = (int)reader9["FoodPrice"];
                        name24 = reader9["FoodName"].ToString();
                        pic24 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox25.ImageLocation = pic24;
                    button27.Text = "Update " + name24;
                    textBox26.Text = name24 + " " + price24 + " tk";
                }
                else if (add.ElementAt(24) == "not")
                {
                    panel32.Visible = false;
                }

                if (add.ElementAt(25) == "added")
                {
                    panel33.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=25";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price25 = (int)reader9["FoodPrice"];
                        name25 = reader9["FoodName"].ToString();
                        pic25 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox26.ImageLocation = pic25;
                    button28.Text = "Update " + name25;
                    textBox27.Text = name25 + " " + price25 + " tk";
                }
                else if (add.ElementAt(25) == "not")
                {
                    panel33.Visible = false;
                }

                if (add.ElementAt(26) == "added")
                {
                    panel34.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=26";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price26 = (int)reader9["FoodPrice"];
                        name26 = reader9["FoodName"].ToString();
                        pic26 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox27.ImageLocation = pic26;
                    button29.Text = "Update " + name26;
                    textBox28.Text = name26 + " " + price26 + " tk";
                }
                else if (add.ElementAt(26) == "not")
                {
                    panel34.Visible = false;
                }

                if (add.ElementAt(27) == "added")
                {
                    panel35.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=27";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price27 = (int)reader9["FoodPrice"];
                        name27 = reader9["FoodName"].ToString();
                        pic27 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox28.ImageLocation = pic27;
                    button30.Text = "Update " + name27;
                    textBox29.Text = name27 + " " + price27 + " tk";
                }
                else if (add.ElementAt(27) == "not")
                {
                    panel35.Visible = false;
                }

                if (add.ElementAt(28) == "added")
                {
                    panel36.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=28";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price28 = (int)reader9["FoodPrice"];
                        name28 = reader9["FoodName"].ToString();
                        pic28 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox29.ImageLocation = pic28;
                    button31.Text = "Update " + name28;
                    textBox30.Text = name28 + " " + price28 + " tk";
                }
                else if (add.ElementAt(28) == "not")
                {
                    panel36.Visible = false;
                }

                if (add.ElementAt(29) == "added")
                {
                    panel37.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=29";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price29 = (int)reader9["FoodPrice"];
                        name29 = reader9["FoodName"].ToString();
                        pic29 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox30.ImageLocation = pic29;
                    button32.Text = "Update " + name29;
                    textBox31.Text = name29 + " " + price29 + " tk";
                }
                else if (add.ElementAt(29) == "not")
                {
                    panel37.Visible = false;
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
                add.Clear();
                textBox32.Text = String.Empty;
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

                SqlConnection connection555 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection555.Open();
                string sql555 = "SELECT * FROM Food";
                SqlCommand command555 = new SqlCommand(sql555, connection555);
                SqlDataReader reader555 = command555.ExecuteReader();

                while (reader555.Read())
                {

                    add.Add((string)reader555["Added"]);

                }
                connection555.Close();

                SqlConnection connection29 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection29.Open();
                string sql29 = "SELECT * FROM Food Where Id=1";
                SqlCommand command29 = new SqlCommand(sql29, connection29);
                SqlDataReader reader = command29.ExecuteReader();

                while (reader.Read())
                {


                    price1 = (int)reader["FoodPrice"];
                    name1 = reader["FoodName"].ToString();
                    pic1 = reader["FoodPic"].ToString();



                }
                connection29.Close();
                pictureBox1.ImageLocation = pic1;

                button1.Text = "Update " + name1;
                textBox1.Text = name1 + " " + price1 + " tk";

                SqlConnection connection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection2.Open();
                string sq2 = "SELECT * FROM Food Where Id=2";
                SqlCommand command2 = new SqlCommand(sq2, connection2);
                SqlDataReader reader2 = command2.ExecuteReader();

                while (reader2.Read())
                {

                    price2 = (int)reader2["FoodPrice"];
                    name2 = reader2["FoodName"].ToString();
                    pic2 = reader2["FoodPic"].ToString();



                }
                connection2.Close();
                pictureBox2.ImageLocation = pic2;
                button2.Text = "Update " + name2;
                textBox2.Text = name2 + " " + price2 + " tk";

                SqlConnection connection3 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection3.Open();
                string sq3 = "SELECT * FROM Food Where Id=3";
                SqlCommand command3 = new SqlCommand(sq3, connection3);
                SqlDataReader reader3 = command3.ExecuteReader();

                while (reader3.Read())
                {

                    price3 = (int)reader3["FoodPrice"];
                    name3 = reader3["FoodName"].ToString();
                    pic3 = reader3["FoodPic"].ToString();



                }
                connection3.Close();
                pictureBox3.ImageLocation = pic3;
                button3.Text = "Update " + name3;
                textBox3.Text = name3 + " " + price3 + " tk";

                SqlConnection connection4 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection4.Open();
                string sq4 = "SELECT * FROM Food Where Id=4";
                SqlCommand command4 = new SqlCommand(sq4, connection4);
                SqlDataReader reader4 = command4.ExecuteReader();

                while (reader4.Read())
                {

                    price4 = (int)reader4["FoodPrice"];
                    name4 = reader4["FoodName"].ToString();
                    pic4 = reader4["FoodPic"].ToString();



                }
                connection4.Close();
                pictureBox4.ImageLocation = pic4;
                button4.Text = "Update " + name4;
                textBox4.Text = name4 + " " + price4 + " tk";

                SqlConnection connection5 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection5.Open();
                string sq5 = "SELECT * FROM Food Where Id=5";
                SqlCommand command5 = new SqlCommand(sq5, connection5);
                SqlDataReader reader5 = command5.ExecuteReader();

                while (reader5.Read())
                {

                    price5 = (int)reader5["FoodPrice"];
                    name5 = reader5["FoodName"].ToString();
                    pic5 = reader5["FoodPic"].ToString();



                }
                connection5.Close();
                pictureBox5.ImageLocation = pic5;
                button5.Text = "Update " + name5;
                textBox5.Text = name5 + " " + price5 + " tk";

                SqlConnection connection6 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection6.Open();
                string sq6 = "SELECT * FROM Food Where Id=6";
                SqlCommand command6 = new SqlCommand(sq6, connection6);
                SqlDataReader reader6 = command6.ExecuteReader();

                while (reader6.Read())
                {

                    price6 = (int)reader6["FoodPrice"];
                    name6 = reader6["FoodName"].ToString();
                    pic6 = reader6["FoodPic"].ToString();



                }
                connection6.Close();
                pictureBox6.ImageLocation = pic6;
                button6.Text = "Update " + name6;
                textBox6.Text = name6 + " " + price6 + " tk";

                SqlConnection connection7 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection7.Open();
                string sq7 = "SELECT * FROM Food Where Id=7";
                SqlCommand command7 = new SqlCommand(sq7, connection7);
                SqlDataReader reader7 = command7.ExecuteReader();

                while (reader7.Read())
                {

                    price7 = (int)reader7["FoodPrice"];
                    name7 = reader7["FoodName"].ToString();
                    pic7 = reader7["FoodPic"].ToString();



                }
                connection7.Close();
                pictureBox7.ImageLocation = pic7;
                button7.Text = "Update " + name7;
                textBox7.Text = name7 + " " + price7 + " tk";

                SqlConnection connection8 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                connection8.Open();
                string sq8 = "SELECT * FROM Food Where Id=8";
                SqlCommand command8 = new SqlCommand(sq8, connection8);
                SqlDataReader reader8 = command8.ExecuteReader();

                while (reader8.Read())
                {

                    price8 = (int)reader8["FoodPrice"];
                    name8 = reader8["FoodName"].ToString();
                    pic8 = reader8["FoodPic"].ToString();



                }
                connection8.Close();
                pictureBox8.ImageLocation = pic8;
                button8.Text = "Update " + name8;
                textBox8.Text = name8 + " " + price8 + " tk";

                if (add.ElementAt(9) == "added")
                {
                    panel9.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=9";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price9 = (int)reader9["FoodPrice"];
                        name9 = reader9["FoodName"].ToString();
                        pic9 = reader9["FoodPic"].ToString();



                    }
                    connection8.Close();
                    pictureBox10.ImageLocation = pic9;
                    button12.Text = "Update " + name9;
                    textBox11.Text = name9 + " " + price9 + " tk";
                }
                else if (add.ElementAt(9) == "not")
                {
                    panel9.Visible = false;
                }

                if (add.ElementAt(10) == "added")
                {
                    panel10.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=10";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price10 = (int)reader9["FoodPrice"];
                        name10 = reader9["FoodName"].ToString();
                        pic10 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox11.ImageLocation = pic10;
                    button13.Text = "Update " + name10;
                    textBox12.Text = name10 + " " + price10 + " tk";
                }
                else if (add.ElementAt(10) == "not")
                {
                    panel10.Visible = false;
                }

                if (add.ElementAt(11) == "added")
                {
                    panel11.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=11";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price11 = (int)reader9["FoodPrice"];
                        name11 = reader9["FoodName"].ToString();
                        pic11 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox12.ImageLocation = pic11;
                    button14.Text = "Update " + name11;
                    textBox13.Text = name11 + " " + price11 + " tk";
                }
                else if (add.ElementAt(11) == "not")
                {
                    panel11.Visible = false;
                }

                if (add.ElementAt(12) == "added")
                {
                    panel12.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=12";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price12 = (int)reader9["FoodPrice"];
                        name12 = reader9["FoodName"].ToString();
                        pic12 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox13.ImageLocation = pic12;
                    button15.Text = "Update " + name12;
                    textBox14.Text = name12 + " " + price12 + " tk";
                }
                else if (add.ElementAt(12) == "not")
                {
                    panel12.Visible = false;
                }

                if (add.ElementAt(13) == "added")
                {
                    panel13.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=13";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price13 = (int)reader9["FoodPrice"];
                        name13 = reader9["FoodName"].ToString();
                        pic13 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox14.ImageLocation = pic13;
                    button16.Text = "Update " + name13;
                    textBox15.Text = name13 + " " + price13 + " tk";
                }
                else if (add.ElementAt(13) == "not")
                {
                    panel13.Visible = false;
                }

                if (add.ElementAt(14) == "added")
                {
                    panel14.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=14";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price14 = (int)reader9["FoodPrice"];
                        name14 = reader9["FoodName"].ToString();
                        pic14 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox15.ImageLocation = pic14;
                    button17.Text = "Update " + name14;
                    textBox16.Text = name14 + " " + price14 + " tk";
                }
                else if (add.ElementAt(14) == "not")
                {
                    panel14.Visible = false;
                }

                if (add.ElementAt(15) == "added")
                {
                    panel15.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=15";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price15 = (int)reader9["FoodPrice"];
                        name15 = reader9["FoodName"].ToString();
                        pic15 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox16.ImageLocation = pic15;
                    button18.Text = "Update " + name15;
                    textBox17.Text = name15 + " " + price15 + " tk";
                }
                else if (add.ElementAt(15) == "not")
                {
                    panel15.Visible = false;
                }

                if (add.ElementAt(16) == "added")
                {
                    panel16.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=16";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price16 = (int)reader9["FoodPrice"];
                        name16 = reader9["FoodName"].ToString();
                        pic16 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox17.ImageLocation = pic16;
                    button19.Text = "Update " + name16;
                    textBox18.Text = name16 + " " + price16 + " tk";
                }
                else if (add.ElementAt(16) == "not")
                {
                    panel16.Visible = false;
                }

                if (add.ElementAt(17) == "added")
                {
                    panel17.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=17";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price17 = (int)reader9["FoodPrice"];
                        name17 = reader9["FoodName"].ToString();
                        pic17 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox18.ImageLocation = pic17;
                    button20.Text = "Update " + name17;
                    textBox19.Text = name17 + " " + price17 + " tk";
                }
                else if (add.ElementAt(17) == "not")
                {
                    panel17.Visible = false;
                }


                if (add.ElementAt(18) == "added")
                {
                    panel21.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=18";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price18 = (int)reader9["FoodPrice"];
                        name18 = reader9["FoodName"].ToString();
                        pic18 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox19.ImageLocation = pic18;
                    button21.Text = "Update " + name18;
                    textBox20.Text = name18 + " " + price18 + " tk";
                }
                else if (add.ElementAt(18) == "not")
                {
                    panel21.Visible = false;
                }

                if (add.ElementAt(19) == "added")
                {
                    panel24.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=19";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price19 = (int)reader9["FoodPrice"];
                        name19 = reader9["FoodName"].ToString();
                        pic19 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox20.ImageLocation = pic19;
                    button22.Text = "Update " + name19;
                    textBox21.Text = name19 + " " + price19 + " tk";
                }
                else if (add.ElementAt(19) == "not")
                {
                    panel24.Visible = false;
                }

                if (add.ElementAt(20) == "added")
                {
                    panel25.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=20";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price20 = (int)reader9["FoodPrice"];
                        name20 = reader9["FoodName"].ToString();
                        pic20 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox21.ImageLocation = pic20;
                    button23.Text = "Update " + name20;
                    textBox22.Text = name20 + " " + price20 + " tk";
                }
                else if (add.ElementAt(20) == "not")
                {
                    panel25.Visible = false;
                }

                if (add.ElementAt(21) == "added")
                {
                    panel26.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=21";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price21 = (int)reader9["FoodPrice"];
                        name21 = reader9["FoodName"].ToString();
                        pic21 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox22.ImageLocation = pic21;
                    button24.Text = "Update " + name21;
                    textBox23.Text = name21 + " " + price21 + " tk";
                }
                else if (add.ElementAt(21) == "not")
                {
                    panel26.Visible = false;
                }

                if (add.ElementAt(22) == "added")
                {
                    panel27.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=22";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price22 = (int)reader9["FoodPrice"];
                        name22 = reader9["FoodName"].ToString();
                        pic22 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox23.ImageLocation = pic22;
                    button25.Text = "Update " + name22;
                    textBox24.Text = name22 + " " + price22 + " tk";
                }
                else if (add.ElementAt(22) == "not")
                {
                    panel27.Visible = false;
                }

                if (add.ElementAt(23) == "added")
                {
                    panel28.Visible = true;

                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=23";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price23 = (int)reader9["FoodPrice"];
                        name23 = reader9["FoodName"].ToString();
                        pic23 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox24.ImageLocation = pic23;
                    button26.Text = "Update " + name23;
                    textBox25.Text = name23 + " " + price23 + " tk";
                }
                else if (add.ElementAt(23) == "not")
                {
                    panel28.Visible = false;
                }

                if (add.ElementAt(24) == "added")
                {
                    panel32.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=24";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price24 = (int)reader9["FoodPrice"];
                        name24 = reader9["FoodName"].ToString();
                        pic24 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox25.ImageLocation = pic24;
                    button27.Text = "Update " + name24;
                    textBox26.Text = name24 + " " + price24 + " tk";
                }
                else if (add.ElementAt(24) == "not")
                {
                    panel32.Visible = false;
                }

                if (add.ElementAt(25) == "added")
                {
                    panel33.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=25";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price25 = (int)reader9["FoodPrice"];
                        name25 = reader9["FoodName"].ToString();
                        pic25 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox26.ImageLocation = pic25;
                    button28.Text = "Update " + name25;
                    textBox27.Text = name25 + " " + price25 + " tk";
                }
                else if (add.ElementAt(25) == "not")
                {
                    panel33.Visible = false;
                }

                if (add.ElementAt(26) == "added")
                {
                    panel34.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=26";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price26 = (int)reader9["FoodPrice"];
                        name26 = reader9["FoodName"].ToString();
                        pic26 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox27.ImageLocation = pic26;
                    button29.Text = "Update " + name26;
                    textBox28.Text = name26 + " " + price26 + " tk";
                }
                else if (add.ElementAt(26) == "not")
                {
                    panel34.Visible = false;
                }

                if (add.ElementAt(27) == "added")
                {
                    panel35.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=27";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price27 = (int)reader9["FoodPrice"];
                        name27 = reader9["FoodName"].ToString();
                        pic27 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox28.ImageLocation = pic27;
                    button30.Text = "Update " + name27;
                    textBox29.Text = name27 + " " + price27 + " tk";
                }
                else if (add.ElementAt(27) == "not")
                {
                    panel35.Visible = false;
                }

                if (add.ElementAt(28) == "added")
                {
                    panel36.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=28";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price28 = (int)reader9["FoodPrice"];
                        name28 = reader9["FoodName"].ToString();
                        pic28 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox29.ImageLocation = pic28;
                    button31.Text = "Update " + name28;
                    textBox30.Text = name28 + " " + price28 + " tk";
                }
                else if (add.ElementAt(28) == "not")
                {
                    panel36.Visible = false;
                }

                if (add.ElementAt(29) == "added")
                {
                    panel37.Visible = true;
                    SqlConnection connection9 = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
                    connection9.Open();
                    string sq9 = "SELECT * FROM Food Where Id=29";
                    SqlCommand command9 = new SqlCommand(sq9, connection9);
                    SqlDataReader reader9 = command9.ExecuteReader();

                    while (reader9.Read())
                    {

                        price29 = (int)reader9["FoodPrice"];
                        name29 = reader9["FoodName"].ToString();
                        pic29 = reader9["FoodPic"].ToString();



                    }
                    connection9.Close();
                    pictureBox30.ImageLocation = pic29;
                    button32.Text = "Update " + name29;
                    textBox31.Text = name29 + " " + price29 + " tk";
                }
                else if (add.ElementAt(29) == "not")
                {
                    panel37.Visible = false;
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
            textBox9.Text = name9;
            realname1 = name9;
            textBox11.Text = price9.ToString();
            pictureBox10.ImageLocation = pic9;
            powerid =9;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = name10;
            realname1 = name10;
            textBox12.Text = price10.ToString();
            pictureBox11.ImageLocation = pic10;
            powerid = 10;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = name11;
            realname1 = name11;
            textBox12.Text = price11.ToString();
            pictureBox11.ImageLocation = pic11;
            powerid = 11;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            groupbox1.Visible = true;
            textBox9.Text = name12;
            realname1 = name12;
            textBox12.Text = price12.ToString();
            pictureBox11.ImageLocation = pic12;
            powerid = 11;
        }
    }
}
