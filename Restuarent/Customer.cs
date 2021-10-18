using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Restuarent
{
    public partial class Customer : Form
    {
        public int tbno;
        public Customer(int a)
        {
            tbno = a;
            InitializeComponent();
        }
        
        
        //1st row
        


       
        private void taka_Click(object sender, EventArgs e)
        {
            
        }
        int amount;



        List<string> pics = new List<string>();
        List<int> prices = new List<int>();
        List<string> names = new List<string>();
        List<string> status = new List<string>();
        List<string> type = new List<string>();

        List<string> DATA = new List<string>();
        List<string> ADDorder = new List<string>();
        List<int> it = new List<int>();

        public string orders;
        public bool its;
        private void button9_Click(object sender, EventArgs e)
        {
            
            
            if(Int32.Parse(taka.Text)>0)
            {
                MessageBox.Show("You did not order anything can't take order");
            }
            else
            {
                flowLayoutPanel1.Visible = false;
                panel1.Visible = true;
                orders= DATA.ElementAt(0) + DATA.ElementAt(1) + DATA.ElementAt(2) + DATA.ElementAt(3) + DATA.ElementAt(4) + DATA.ElementAt(5) + DATA.ElementAt(6) + DATA.ElementAt(7);
 
            }

        }
        public void DoEnable()
        {
            this.Enabled = true;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }



       

        private void Form1_Load(object sender, EventArgs e)
        {
           
            button25.Visible = false;
            panel1.Visible = false;
            label9.Visible = false;
            richTextBox1.Visible = false;
            groupBox1.Visible = false;
            pictureBox2.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label13.Visible = false;
            button22.Visible = false;
            label8.Text = tbno.ToString();
            Burgers.Text = 0.ToString();
            RiceBowls.Text = 0.ToString();
            Pizzas.Text = 0.ToString();
            Sawrmas.Text = 0.ToString();
            Dumplings.Text = 0.ToString();
            Pastrys.Text = 0.ToString();
            Cokes.Text = 0.ToString();
            Waters.Text = 0.ToString();
            textBox4.Text= 0.ToString();
            textBox5.Text = 0.ToString();
            textBox6.Text = 0.ToString();
            textBox7.Text = 0.ToString();
            textBox8.Text = 0.ToString();
            textBox9.Text = 0.ToString();
            textBox10.Text = 0.ToString();
            textBox11.Text = 0.ToString();
            textBox12.Text = 0.ToString();
            textBox13.Text = 0.ToString();
            textBox14.Text = 0.ToString();
            textBox15.Text = 0.ToString();
            textBox16.Text = 0.ToString();
            textBox17.Text = 0.ToString();
            textBox18.Text = 0.ToString();
            textBox19.Text = 0.ToString();
            textBox20.Text = 0.ToString();
            textBox21.Text = 0.ToString();
            textBox22.Text = 0.ToString();
            textBox23.Text = 0.ToString();
            textBox24.Text = 0.ToString();
            textBox25.Text = 0.ToString();
            textBox26.Text = 0.ToString();
            textBox27.Text = 0.ToString();
            textBox28.Text = 0.ToString();
            textBox29.Text = 0.ToString();
            textBox30.Text = 0.ToString();
            textBox31.Text = 0.ToString();
            textBox32.Text = 0.ToString();
            textBox33.Text = 0.ToString();
            textBox34.Text = 0.ToString();
            textBox35.Text = 0.ToString();
            textBox36.Text = 0.ToString();
            textBox37.Text = 0.ToString();
            textBox38.Text = 0.ToString();
            textBox39.Text = 0.ToString();
            textBox40.Text = 0.ToString();
            textBox41.Text = 0.ToString();
            textBox42.Text = 0.ToString();
            textBox43.Text = 0.ToString();
            textBox44.Text = 0.ToString();
            textBox45.Text = 0.ToString();
            textBox46.Text = 0.ToString();
            textBox47.Text = 0.ToString();
            textBox48.Text = 0.ToString();
            textBox49.Text = 0.ToString();
            textBox50.Text = 0.ToString();
            textBox51.Text = 0.ToString();
            textBox52.Text = 0.ToString();
            textBox53.Text = 0.ToString();
            textBox54.Text = 0.ToString();
            textBox55.Text = 0.ToString();
            textBox56.Text = 0.ToString();
            textBox57.Text = 0.ToString();
            textBox58.Text = 0.ToString();
            textBox59.Text = 0.ToString();
            textBox60.Text = 0.ToString();
            textBox61.Text = 0.ToString();
            textBox62.Text = 0.ToString();
            textBox63.Text = 0.ToString();
            textBox64.Text = 0.ToString();
            textBox65.Text = 0.ToString();
            textBox66.Text = 0.ToString();
            textBox67.Text = 0.ToString();
            textBox68.Text = 0.ToString();
            textBox69.Text = 0.ToString();
            textBox70.Text = 0.ToString();
            textBox71.Text = 0.ToString();
            textBox72.Text = 0.ToString();
            textBox73.Text = 0.ToString();
            textBox74.Text = 0.ToString();
            textBox75.Text = 0.ToString();

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM Food";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {


                prices.Add((int)reader["FoodPrice"]);
                names.Add( reader["FoodName"].ToString());
                pics.Add(reader["FoodPic"].ToString());
                status.Add(reader["FoodStatus"].ToString());
                type.Add(reader["FoodType"].ToString());
               


            }
            connection.Close();
            

            //1st row*****************************
            if (status.ElementAt(0)=="active"&&type.ElementAt(0)=="Starter")
            {   
                panel3.Visible = true;
                BurgerLab.Text = names.ElementAt(0);
                Burgerpic.ImageLocation = pics.ElementAt(0); 
            }
            else
            {
                panel3.Visible = false;
            }
            if (status.ElementAt(1) == "active" && type.ElementAt(1) == "Starter")
            {
                panel6.Visible = true;
                Dumplinglab.Text = names.ElementAt(1);
                Dumplingpic.ImageLocation = pics.ElementAt(1); 
            }
            else
            {
                panel6.Visible = false;
            }
            if (status.ElementAt(2) == "active" && type.ElementAt(2) == "Starter")
            {
                panel10.Visible = true;
                label17.Text = names.ElementAt(2);
                pictureBox3.ImageLocation = pics.ElementAt(2);
            }
            else
            {
                panel10.Visible = false;
            }
            if (status.ElementAt(3) == "active" && type.ElementAt(3) == "Starter")
            {
                panel14.Visible = true;
                label21.Text = names.ElementAt(3);
                pictureBox7.ImageLocation = pics.ElementAt(3);
            }
            else
            {
                panel14.Visible = false;
            }
            if (status.ElementAt(4) == "active" && type.ElementAt(4) == "Starter")
            {
                panel18.Visible = true;
                label25.Text = names.ElementAt(4);
                pictureBox11.ImageLocation = pics.ElementAt(4);
            }
            else
            {
                panel18.Visible = false;
            }
            if (status.ElementAt(5) == "active" && type.ElementAt(5) == "Starter")
            {
                panel22.Visible = true;
                label29.Text = names.ElementAt(5);
                pictureBox15.ImageLocation = pics.ElementAt(5);
            }
            else
            {
                panel22.Visible = false;
            }
            if (status.ElementAt(6) == "active" && type.ElementAt(6) == "Starter")
            {
                panel26.Visible = true;
                label33.Text = names.ElementAt(6);
                pictureBox19.ImageLocation = pics.ElementAt(6);
            }
            else
            {
                panel26.Visible = false;
            }
            if (status.ElementAt(7) == "active" && type.ElementAt(7) == "Starter")
            {
                panel30.Visible = true;
                label37.Text = names.ElementAt(7);
                pictureBox23.ImageLocation = pics.ElementAt(7);
            }
            else
            {
                panel30.Visible = false;
            }
            if (status.ElementAt(8) == "active" && type.ElementAt(8) == "Starter")
            {
                panel33.Visible = true;
                label40.Text = names.ElementAt(8);
                pictureBox26.ImageLocation = pics.ElementAt(8);
            }
            else
            {
                panel33.Visible = false;
            }
            if (status.ElementAt(9) == "active" && type.ElementAt(9) == "Starter")
            {
                panel37.Visible = true;
                label44.Text = names.ElementAt(9);
                pictureBox30.ImageLocation = pics.ElementAt(9);
            }
            else
            {
                panel37.Visible = false;
            }
            if (status.ElementAt(10) == "active" && type.ElementAt(10) == "Starter")
            {
                panel41.Visible = true;
                label48.Text = names.ElementAt(10);
                pictureBox34.ImageLocation = pics.ElementAt(10);
            }
            else
            {
                panel41.Visible = false;
            }
            if (status.ElementAt(11) == "active" && type.ElementAt(11) == "Starter")
            {
                panel45.Visible = true;
                label52.Text = names.ElementAt(11);
                pictureBox38.ImageLocation = pics.ElementAt(11);
            }
            else
            {
                panel45.Visible = false;
            }
            if (status.ElementAt(12) == "active" && type.ElementAt(12) == "Starter")
            {
                panel49.Visible = true;
                label56.Text = names.ElementAt(12);
                pictureBox42.ImageLocation = pics.ElementAt(12);
            }
            else
            {
                panel49.Visible = false;
            }
            if (status.ElementAt(13) == "active" && type.ElementAt(13) == "Starter")
            {
                panel53.Visible = true;
                label60.Text = names.ElementAt(13);
                pictureBox46.ImageLocation = pics.ElementAt(13);
            }
            else
            {
                panel53.Visible = false;
            }
            if (status.ElementAt(14) == "active" && type.ElementAt(14) == "Starter")
            {
                panel57.Visible = true;
                label64.Text = names.ElementAt(14);
                pictureBox50.ImageLocation = pics.ElementAt(14);
            }
            else
            {
                panel57.Visible = false;
            }
            if (status.ElementAt(15) == "active" && type.ElementAt(15) == "Starter")
            {
                panel61.Visible = true;
                label68.Text = names.ElementAt(15);
                pictureBox54.ImageLocation = pics.ElementAt(15);
            }
            else
            {
                panel61.Visible = false;
            }
            if (status.ElementAt(16) == "active" && type.ElementAt(16) == "Starter")
            {
                panel65.Visible = true;
                label72.Text = names.ElementAt(16);
                pictureBox58.ImageLocation = pics.ElementAt(16);
            }
            else
            {
                panel65.Visible = false;
            }
            if (status.ElementAt(17) == "active" && type.ElementAt(17) == "Starter")
            {
                panel69.Visible = true;
                label76.Text = names.ElementAt(16);
                pictureBox62.ImageLocation = pics.ElementAt(16);
            }
            else
            {
                panel69.Visible = false;
            }
            if (status.ElementAt(18) == "active" && type.ElementAt(18) == "Starter")
            {
                panel73.Visible = true;
                label80.Text = names.ElementAt(18);
                pictureBox66.ImageLocation = pics.ElementAt(18);
            }
            else
            {
                panel73.Visible = false;
            }
            if (status.ElementAt(19) == "active" && type.ElementAt(19) == "Starter")
            {
                panel77.Visible = true;
                label84.Text = names.ElementAt(19);
                pictureBox70.ImageLocation = pics.ElementAt(19);
            }
            else
            {
                panel77.Visible = false;
            }////////////////////////////////////////
            if (status.ElementAt(20) == "active" && type.ElementAt(20) == "Starter")
            {
                panel81.Visible = true;
                label92.Text = names.ElementAt(20);
                pictureBox74.ImageLocation = pics.ElementAt(20);
            }
            else
            {
                panel81.Visible = false;
            }
            if (status.ElementAt(21) == "active" && type.ElementAt(21) == "Starter")
            {
                panel85.Visible = true;
                label96.Text = names.ElementAt(21);
                pictureBox78.ImageLocation = pics.ElementAt(21);
            }
            else
            {
                panel85.Visible = false;
            }
            if (status.ElementAt(22) == "active" && type.ElementAt(22) == "Starter")
            {
                panel89.Visible = true;
                label100.Text = names.ElementAt(21);
                pictureBox82.ImageLocation = pics.ElementAt(22);
            }
            else
            {
                panel89.Visible = false;
            }
            if (status.ElementAt(23) == "active" && type.ElementAt(23) == "Starter")
            {
                panel93.Visible = true;
                label104.Text = names.ElementAt(23);
                pictureBox86.ImageLocation = pics.ElementAt(23);
            }
            else
            {
                panel93.Visible = false;
            }
            if (status.ElementAt(24) == "active" && type.ElementAt(24) == "Starter")
            {
                panel97.Visible = true;
                label108.Text = names.ElementAt(24);
                pictureBox90.ImageLocation = pics.ElementAt(24);
            }
            else
            {
                panel97.Visible = false;
            }
            if (status.ElementAt(25) == "active" && type.ElementAt(25) == "Starter")
            {
                panel101.Visible = true;
                label112.Text = names.ElementAt(25);
                pictureBox94.ImageLocation = pics.ElementAt(25);
            }
            else
            {
                panel101.Visible = false;
            }
            if (status.ElementAt(26) == "active" && type.ElementAt(26) == "Starter")
            {
                panel105.Visible = true;
                label116.Text = names.ElementAt(26);
                pictureBox98.ImageLocation = pics.ElementAt(26);
            }
            else
            {
                panel105.Visible = false;
            }
            if (status.ElementAt(27) == "active" && type.ElementAt(27) == "Starter")
            {
                panel109.Visible = true;
                label120.Text = names.ElementAt(27);
                pictureBox102.ImageLocation = pics.ElementAt(27);
            }
            else
            {
                panel109.Visible = false;
            }
            if (status.ElementAt(28) == "active" && type.ElementAt(28) == "Starter")
            {
                panel113.Visible = true;
                label124.Text = names.ElementAt(28);
                pictureBox106.ImageLocation = pics.ElementAt(28);
            }
            else
            {
                panel113.Visible = false;
            }
            if (status.ElementAt(29) == "active" && type.ElementAt(29) == "Starter")
            {
                panel117.Visible = true;
                label128.Text = names.ElementAt(29);
                pictureBox110.ImageLocation = pics.ElementAt(29);
            }
            else
            {
                panel117.Visible = false;
            }
            if (status.ElementAt(30) == "active" && type.ElementAt(30) == "Starter")
            {
                panel20.Visible = true;
                label27.Text = names.ElementAt(30);
                pictureBox13.ImageLocation = pics.ElementAt(30);
            }
            else
            {
                panel20.Visible = false;
            }
            if (status.ElementAt(31) == "active" && type.ElementAt(31) == "Starter")
            {
                panel24.Visible = true;
                label31.Text = names.ElementAt(31);
                pictureBox17.ImageLocation = pics.ElementAt(31);
            }
            else
            {
                panel24.Visible = false;
            }
            if (status.ElementAt(32) == "active" && type.ElementAt(32) == "Starter")
            {
                panel28.Visible = true;
                label35.Text = names.ElementAt(32);
                pictureBox21.ImageLocation = pics.ElementAt(32);
            }
            else
            {
                panel28.Visible = false;
            }
            if (status.ElementAt(33) == "active" && type.ElementAt(33) == "Starter")
            {
                panel32.Visible = true;
                label39.Text = names.ElementAt(33);
                pictureBox25.ImageLocation = pics.ElementAt(33);
            }
            else
            {
                panel32.Visible = false;
            }
            if (status.ElementAt(34) == "active" && type.ElementAt(34) == "Starter")
            {
                panel36.Visible = true;
                label43.Text = names.ElementAt(34);
                pictureBox29.ImageLocation = pics.ElementAt(34);
            }
            else
            {
                panel36.Visible = false;
            }
            if (status.ElementAt(35) == "active" && type.ElementAt(35) == "Starter")
            {
                panel40.Visible = true;
                label47.Text = names.ElementAt(35);
                pictureBox33.ImageLocation = pics.ElementAt(35);
            }
            else
            {
                panel40.Visible = false;
            }
            if (status.ElementAt(36) == "active" && type.ElementAt(36) == "Starter")
            {
                panel44.Visible = true;
                label51.Text = names.ElementAt(36);
                pictureBox37.ImageLocation = pics.ElementAt(36);
            }
            else
            {
                panel44.Visible = false;
            }
            if (status.ElementAt(37) == "active" && type.ElementAt(37) == "Starter")
            {
                panel48.Visible = true;
                label55.Text = names.ElementAt(37);
                pictureBox41.ImageLocation = pics.ElementAt(37);
            }
            else
            {
                panel48.Visible = false;
            }
            if (status.ElementAt(38) == "active" && type.ElementAt(38) == "Starter")
            {
                panel52.Visible = true;
                label59.Text = names.ElementAt(38);
                pictureBox45.ImageLocation = pics.ElementAt(38);
            }
            else
            {
                panel52.Visible = false;
            }
            if (status.ElementAt(39) == "active" && type.ElementAt(39) == "Starter")
            {
                panel56.Visible = true;
                label63.Text = names.ElementAt(39);
                pictureBox49.ImageLocation = pics.ElementAt(39);
            }
            else
            {
                panel56.Visible = false;
            }


            
            


            //2nd row*****************************
            if (status.ElementAt(0) == "active" && type.ElementAt(0) == "Main course")
            {
                panel2.Visible = true;
                RicebowlLab.Text = names.ElementAt(0);
                pictureBox1.ImageLocation = pics.ElementAt(0);
            }
            else
            {
                panel2.Visible = false;
            }
            if (status.ElementAt(1) == "active" && type.ElementAt(1) == "Main course")
            {
                panel7.Visible = true;
                Pastrylab.Text = names.ElementAt(1);
                Pastrypic.ImageLocation = pics.ElementAt(1);
            }
            else
            {
                panel7.Visible = false;
            }
            if (status.ElementAt(2) == "active" && type.ElementAt(2) == "Main course")
            {
                panel11.Visible = true;
                label18.Text = names.ElementAt(2);
                pictureBox4.ImageLocation = pics.ElementAt(2);
            }
            else
            {
                panel11.Visible = false;
            }
            if (status.ElementAt(3) == "active" && type.ElementAt(3) == "Main course")
            {
                panel15.Visible = true;
                label22.Text = names.ElementAt(3);
                pictureBox8.ImageLocation = pics.ElementAt(3);
            }
            else
            {
                panel15.Visible = false;
            }
            if (status.ElementAt(4) == "active" && type.ElementAt(4) == "Main course")
            {
                panel19.Visible = true;
                label26.Text = names.ElementAt(4);
                pictureBox12.ImageLocation = pics.ElementAt(4);
            }
            else
            {
                panel19.Visible = false;
            }
            if (status.ElementAt(5) == "active" && type.ElementAt(5) == "Main course")
            {
                panel23.Visible = true;
                label30.Text = names.ElementAt(5);
                pictureBox16.ImageLocation = pics.ElementAt(5);
            }
            else
            {
                panel23.Visible = false;
            }
            if (status.ElementAt(6) == "active" && type.ElementAt(6) == "Main course")
            {
                panel27.Visible = true;
                label34.Text = names.ElementAt(6);
                pictureBox20.ImageLocation = pics.ElementAt(6);
            }
            else
            {
                panel27.Visible = false;
            }
            if (status.ElementAt(7) == "active" && type.ElementAt(7) == "Main course")
            {
                panel31.Visible = true;
                label38.Text = names.ElementAt(7);
                pictureBox24.ImageLocation = pics.ElementAt(7);
            }
            else
            {
                panel31.Visible = false;
            }
            if (status.ElementAt(8) == "active" && type.ElementAt(8) == "Main course")
            {
                panel35.Visible = true;
                label42.Text = names.ElementAt(8);
                pictureBox28.ImageLocation = pics.ElementAt(8);
            }
            else
            {
                panel35.Visible = false;
            }
            if (status.ElementAt(9) == "active" && type.ElementAt(9) == "Main course")
            {
                panel39.Visible = true;
                label46.Text = names.ElementAt(9);
                pictureBox32.ImageLocation = pics.ElementAt(9);
            }
            else
            {
                panel39.Visible = false;
            }
            if (status.ElementAt(10) == "active" && type.ElementAt(10) == "Main course")
            {
                panel43.Visible = true;
                label50.Text = names.ElementAt(10);
                pictureBox36.ImageLocation = pics.ElementAt(10);
            }
            else
            {
                panel43.Visible = false;
            }
            if (status.ElementAt(11) == "active" && type.ElementAt(11) == "Main course")
            {
                panel47.Visible = true;
                label54.Text = names.ElementAt(11);
                pictureBox40.ImageLocation = pics.ElementAt(11);
            }
            else
            {
                panel47.Visible = false;
            }
            if (status.ElementAt(12) == "active" && type.ElementAt(12) == "Main course")
            {
                panel51.Visible = true;
                label58.Text = names.ElementAt(12);
                pictureBox44.ImageLocation = pics.ElementAt(12);
            }
            else
            {
                panel51.Visible = false;
            }
            if (status.ElementAt(13) == "active" && type.ElementAt(13) == "Main course")
            {
                panel55.Visible = true;
                label62.Text = names.ElementAt(13);
                pictureBox48.ImageLocation = pics.ElementAt(13);
            }
            else
            {
                panel55.Visible = false;
            }
            if (status.ElementAt(14) == "active" && type.ElementAt(14) == "Main course")
            {
                panel59.Visible = true;
                label66.Text = names.ElementAt(14);
                pictureBox52.ImageLocation = pics.ElementAt(14);
            }
            else
            {
                panel59.Visible = false;
            }
            if (status.ElementAt(15) == "active" && type.ElementAt(15) == "Main course")
            {
                panel63.Visible = true;
                label70.Text = names.ElementAt(15);
                pictureBox56.ImageLocation = pics.ElementAt(15);
            }
            else
            {
                panel63.Visible = false;
            }
            if (status.ElementAt(16) == "active" && type.ElementAt(16) == "Main course")
            {
                panel67.Visible = true;
                label74.Text = names.ElementAt(16);
                pictureBox60.ImageLocation = pics.ElementAt(16);
            }
            else
            {
                panel67.Visible = false;
            }
            if (status.ElementAt(17) == "active" && type.ElementAt(17) == "Main course")
            {
                panel71.Visible = true;
                label78.Text = names.ElementAt(16);
                pictureBox64.ImageLocation = pics.ElementAt(16);
            }
            else
            {
                panel71.Visible = false;
            }
            if (status.ElementAt(18) == "active" && type.ElementAt(18) == "Main course")
            {
                panel75.Visible = true;
                label82.Text = names.ElementAt(18);
                pictureBox68.ImageLocation = pics.ElementAt(18);
            }
            else
            {
                panel75.Visible = false;
            }
            if (status.ElementAt(19) == "active" && type.ElementAt(19) == "Main course")
            {
                panel79.Visible = true;
                label86.Text = names.ElementAt(19);
                pictureBox72.ImageLocation = pics.ElementAt(19);
            }
            else
            {
                panel79.Visible = false;
            }
            if (status.ElementAt(20) == "active" && type.ElementAt(20) == "Main course")
            {
                panel83.Visible = true;
                label94.Text = names.ElementAt(20);
                pictureBox76.ImageLocation = pics.ElementAt(20);
            }
            else
            {
                panel83.Visible = false;
            }
            if (status.ElementAt(21) == "active" && type.ElementAt(21) == "Main course")
            {
                panel87.Visible = true;
                label98.Text = names.ElementAt(21);
                pictureBox80.ImageLocation = pics.ElementAt(21);
            }
            else
            {
                panel87.Visible = false;
            }
            if (status.ElementAt(22) == "active" && type.ElementAt(22) == "Main course")
            {
                panel91.Visible = true;
                label102.Text = names.ElementAt(21);
                pictureBox84.ImageLocation = pics.ElementAt(22);
            }
            else
            {
                panel91.Visible = false;
            }
            if (status.ElementAt(23) == "active" && type.ElementAt(23) == "Main course")
            {
                panel95.Visible = true;
                label106.Text = names.ElementAt(23);
                pictureBox88.ImageLocation = pics.ElementAt(23);
            }
            else
            {
                panel95.Visible = false;
            }
            if (status.ElementAt(24) == "active" && type.ElementAt(24) == "Main course")
            {
                panel99.Visible = true;
                label110.Text = names.ElementAt(24);
                pictureBox92.ImageLocation = pics.ElementAt(24);
            }
            else
            {
                panel99.Visible = false;
            }
            if (status.ElementAt(25) == "active" && type.ElementAt(25) == "Main course")
            {
                panel103.Visible = true;
                label114.Text = names.ElementAt(25);
                pictureBox96.ImageLocation = pics.ElementAt(25);
            }
            else
            {
                panel103.Visible = false;
            }
            if (status.ElementAt(26) == "active" && type.ElementAt(26) == "Main course")
            {
                panel107.Visible = true;
                label118.Text = names.ElementAt(26);
                pictureBox100.ImageLocation = pics.ElementAt(26);
            }
            else
            {
                panel107.Visible = false;
            }
            if (status.ElementAt(27) == "active" && type.ElementAt(27) == "Main course")
            {
                panel111.Visible = true;
                label122.Text = names.ElementAt(27);
                pictureBox104.ImageLocation = pics.ElementAt(27);
            }
            else
            {
                panel111.Visible = false;
            }
            if (status.ElementAt(28) == "active" && type.ElementAt(28) == "Main course")
            {
                panel115.Visible = true;
                label126.Text = names.ElementAt(27);
                pictureBox108.ImageLocation = pics.ElementAt(28);
            }
            else
            {
                panel115.Visible = false;
            }
            if (status.ElementAt(29) == "active" && type.ElementAt(29) == "Main course")
            {
                panel119.Visible = true;
                label130.Text = names.ElementAt(29);
                pictureBox112.ImageLocation = pics.ElementAt(29);
            }
            else
            {
                panel119.Visible = false;
            }
            if (status.ElementAt(30) == "active" && type.ElementAt(30) == "Main course")
            {
                panel123.Visible = true;
                label134.Text = names.ElementAt(30);
                pictureBox116.ImageLocation = pics.ElementAt(30);
            }
            else
            {
                panel123.Visible = false;
            }
            if (status.ElementAt(31) == "active" && type.ElementAt(31) == "Main course")
            {
                panel127.Visible = true;
                label138.Text = names.ElementAt(31);
                pictureBox120.ImageLocation = pics.ElementAt(31);
            }
            else
            {
                panel127.Visible = false;
            }           
            if (status.ElementAt(32) == "active" && type.ElementAt(32) == "Main course")
            {
                panel135.Visible = true;
                label146.Text = names.ElementAt(32);
                pictureBox128.ImageLocation = pics.ElementAt(32);
            }
            else
            {
                panel135.Visible = false;
            }
            if (status.ElementAt(33) == "active" && type.ElementAt(33) == "Main course")
            {
                panel139.Visible = true;
                label150.Text = names.ElementAt(33);
                pictureBox132.ImageLocation = pics.ElementAt(33);
            }
            else
            {
                panel139.Visible = false;
            }
            if (status.ElementAt(34) == "active" && type.ElementAt(34) == "Main course")
            {
                panel143.Visible = true;
                label154.Text = names.ElementAt(34);
                pictureBox136.ImageLocation = pics.ElementAt(34);
            }
            else
            {
                panel143.Visible = false;
            }
            if (status.ElementAt(35) == "active" && type.ElementAt(35) == "Main course")
            {
                panel147.Visible = true;
                label158.Text = names.ElementAt(35);
                pictureBox140.ImageLocation = pics.ElementAt(35);
            }
            else
            {
                panel147.Visible = false;
            }
            if (status.ElementAt(36) == "active" && type.ElementAt(36) == "Main course")
            {
                panel151.Visible = true;
                label162.Text = names.ElementAt(36);
                pictureBox144.ImageLocation = pics.ElementAt(36);
            }
            else
            {
                panel151.Visible = false;
            }
            if (status.ElementAt(37) == "active" && type.ElementAt(37) == "Main course")
            {
                panel155.Visible = true;
                label166.Text = names.ElementAt(37);
                pictureBox148.ImageLocation = pics.ElementAt(37);
            }
            else
            {
                panel155.Visible = false;
            }
            if (status.ElementAt(38) == "active" && type.ElementAt(38) == "Main course")
            {
                panel159.Visible = true;
                label170.Text = names.ElementAt(38);
                pictureBox152.ImageLocation = pics.ElementAt(38);
            }
            else
            {
                panel159.Visible = false;
            }
            if (status.ElementAt(39) == "active" && type.ElementAt(39) == "Main course")
            {
                panel60.Visible = true;
                label67.Text = names.ElementAt(39);
                pictureBox53.ImageLocation = pics.ElementAt(39);
            }
            else
            {
                panel60.Visible = false;
            }


            //3rd row*****************************
            if (status.ElementAt(0) == "active" && type.ElementAt(0) == "Dessert")
            {
                panel157.Visible = true;
                label168.Text = names.ElementAt(0);
                pictureBox150.ImageLocation = pics.ElementAt(0);
            }
            else
            {
                panel157.Visible = false;
            }
            if (status.ElementAt(1) == "active" && type.ElementAt(1) == "Dessert")
            {
                panel161.Visible = true;
                label172.Text = names.ElementAt(1);
                pictureBox154.ImageLocation = pics.ElementAt(1);
            }
            else
            {
                panel161.Visible = false;
            }
            if (status.ElementAt(2) == "active" && type.ElementAt(2) == "Dessert")
            {
                panel153.Visible = true;
                label164.Text = names.ElementAt(2);
                pictureBox146.ImageLocation = pics.ElementAt(2);
            }
            else
            {
                panel153.Visible = false;
            }
            if (status.ElementAt(3) == "active" && type.ElementAt(3) == "Dessert")
            {
                panel149.Visible = true;
                label160.Text = names.ElementAt(3);
                pictureBox142.ImageLocation = pics.ElementAt(3);
            }
            else
            {
                panel149.Visible = false;
            }
            if (status.ElementAt(3) == "active" && type.ElementAt(3) == "Dessert")
            {
                panel149.Visible = true;
                label160.Text = names.ElementAt(3);
                pictureBox142.ImageLocation = pics.ElementAt(3);
            }
            else
            {
                panel149.Visible = false;
            }
            if (status.ElementAt(4) == "active" && type.ElementAt(4) == "Dessert")
            {
                panel145.Visible = true;
                label156.Text = names.ElementAt(4);
                pictureBox138.ImageLocation = pics.ElementAt(4);
            }
            else
            {
                panel145.Visible = false;
            }
            if (status.ElementAt(5) == "active" && type.ElementAt(5) == "Dessert")
            {
                panel141.Visible = true;
                label152.Text = names.ElementAt(5);
                pictureBox134.ImageLocation = pics.ElementAt(5);
            }
            else
            {
                panel141.Visible = false;
            }
            if (status.ElementAt(6) == "active" && type.ElementAt(6) == "Dessert")
            {
                panel137.Visible = true;
                label148.Text = names.ElementAt(6);
                pictureBox130.ImageLocation = pics.ElementAt(6);
            }
            else
            {
                panel137.Visible = false;
            }
            if (status.ElementAt(7) == "active" && type.ElementAt(7) == "Dessert")
            {
                panel133.Visible = true;
                label144.Text = names.ElementAt(7);
                pictureBox126.ImageLocation = pics.ElementAt(7);
            }
            else
            {
                panel133.Visible = false;
            }





            //4th row*****************************
            if (status.ElementAt(0) == "active" && type.ElementAt(0) == "Drinks")
            {
                panel158.Visible = true;
                label169.Text = names.ElementAt(0);
                pictureBox151.ImageLocation = pics.ElementAt(0);
            }
            else
            {
                panel158.Visible = false;
            }
            if (status.ElementAt(1) == "active" && type.ElementAt(1) == "Drinks")
            {
                panel154.Visible = true;
                label165.Text = names.ElementAt(1);
                pictureBox147.ImageLocation = pics.ElementAt(1);
            }
            else
            {
                panel154.Visible = false;
            }
            if (status.ElementAt(2) == "active" && type.ElementAt(2) == "Drinks")
            {
                panel150.Visible = true;
                label161.Text = names.ElementAt(2);
                pictureBox143.ImageLocation = pics.ElementAt(2);
            }
            else
            {
                panel150.Visible = false;
            }
            if (status.ElementAt(3) == "active" && type.ElementAt(3) == "Drinks")
            {
                panel146.Visible = true;
                label157.Text = names.ElementAt(3);
                pictureBox139.ImageLocation = pics.ElementAt(3);
            }
            else
            {
                panel146.Visible = false;
            }
            if (status.ElementAt(4) == "active" && type.ElementAt(4) == "Drinks")
            {
                panel142.Visible = true;
                label153.Text = names.ElementAt(4);
                pictureBox135.ImageLocation = pics.ElementAt(4);
            }
            else
            {
                panel142.Visible = false;
            }
            if (status.ElementAt(5) == "active" && type.ElementAt(5) == "Drinks")
            {
                panel138.Visible = true;
                label149.Text = names.ElementAt(5);
                pictureBox131.ImageLocation = pics.ElementAt(5);
            }
            else
            {
                panel138.Visible = false;
            }
            if (status.ElementAt(6) == "active" && type.ElementAt(6) == "Drinks")
            {
                panel134.Visible = true;
                label145.Text = names.ElementAt(6);
                pictureBox127.ImageLocation = pics.ElementAt(6);
            }
            else
            {
                panel134.Visible = false;
            }
            if (status.ElementAt(7) == "active" && type.ElementAt(7) == "Drinks")
            {
                panel130.Visible = true;
                label141.Text = names.ElementAt(7);
                pictureBox123.ImageLocation = pics.ElementAt(7);
            }
            else
            {
                panel130.Visible = false;
            }
            if (status.ElementAt(8) == "active" && type.ElementAt(8) == "Drinks")
            {
                panel126.Visible = true;
                label137.Text = names.ElementAt(8);
                pictureBox119.ImageLocation = pics.ElementAt(8);
            }
            else
            {
                panel126.Visible = false;
            }
            if (status.ElementAt(9) == "active" && type.ElementAt(9) == "Drinks")
            {
                panel122.Visible = true;
                label133.Text = names.ElementAt(9);
                pictureBox115.ImageLocation = pics.ElementAt(9);
            }
            else
            {
                panel122.Visible = false;
            }
            if (status.ElementAt(10) == "active" && type.ElementAt(10) == "Drinks")
            {
                panel9.Visible = true;
                Waterlab.Text = names.ElementAt(10);
                Waterpic.ImageLocation = pics.ElementAt(10);
            }
            else
            {
                panel9.Visible = false;
            }
            if (status.ElementAt(11) == "active" && type.ElementAt(11) == "Drinks")
            {
                panel116.Visible = true;
                label127.Text = names.ElementAt(11);
                pictureBox109.ImageLocation = pics.ElementAt(11);
            }
            else
            {
                panel116.Visible = false;
            }
            if (status.ElementAt(12) == "active" && type.ElementAt(12) == "Drinks")
            {
                panel32.Visible = true;
                label39.Text = names.ElementAt(12);
                pictureBox25.ImageLocation = pics.ElementAt(12);
            }
            else
            {
                panel32.Visible = false;
            }
            if (status.ElementAt(13) == "active" && type.ElementAt(13) == "Drinks")
            {
                panel36.Visible = true;
                label43.Text = names.ElementAt(13);
                pictureBox29.ImageLocation = pics.ElementAt(13);
            }
            else
            {
                panel36.Visible = false;
            }
            if (status.ElementAt(14) == "active" && type.ElementAt(14) == "Drinks")
            {
                panel40.Visible = true;
                label47.Text = names.ElementAt(14);
                pictureBox33.ImageLocation = pics.ElementAt(14);
            }
            else
            {
                panel40.Visible = false;
            }
            if (status.ElementAt(15) == "active" && type.ElementAt(15) == "Drinks")
            {
                panel44.Visible = true;
                label51.Text = names.ElementAt(15);
                pictureBox37.ImageLocation = pics.ElementAt(15);
            }
            else
            {
                panel44.Visible = false;
            }
            if (status.ElementAt(16) == "active" && type.ElementAt(16) == "Drinks")
            {
                panel48.Visible = true;
                label55.Text = names.ElementAt(16);
                pictureBox41.ImageLocation = pics.ElementAt(16);
            }
            else
            {
                panel48.Visible = false;
            }
            if (status.ElementAt(17) == "active" && type.ElementAt(17) == "Drinks")
            {
                panel52.Visible = true;
                label59.Text = names.ElementAt(17);
                pictureBox45.ImageLocation = pics.ElementAt(17);
            }
            else
            {
                panel52.Visible = false;
            }
            if (status.ElementAt(18) == "active" && type.ElementAt(18) == "Drinks")
            {
                panel56.Visible = true;
                label63.Text = names.ElementAt(18);
                pictureBox49.ImageLocation = pics.ElementAt(18);
            }
            else
            {
                panel56.Visible = false;
            }
            if (status.ElementAt(19) == "active" && type.ElementAt(19) == "Drinks")
            {
                panel60.Visible = true;
                label67.Text = names.ElementAt(19);
                pictureBox53.ImageLocation = pics.ElementAt(19);
            }
            else
            {
                panel60.Visible = false;
            }
            if (status.ElementAt(20) == "active" && type.ElementAt(20) == "Drinks")
            {
                panel64.Visible = true;
                label71.Text = names.ElementAt(20);
                pictureBox57.ImageLocation = pics.ElementAt(20);
            }
            else
            {
                panel64.Visible = false;
            }
            if (status.ElementAt(21) == "active" && type.ElementAt(21) == "Drinks")
            {
                panel68.Visible = true;
                label75.Text = names.ElementAt(21);
                pictureBox61.ImageLocation = pics.ElementAt(21);
            }
            else
            {
                panel68.Visible = false;
            }
            if (status.ElementAt(22) == "active" && type.ElementAt(22) == "Drinks")
            {
                panel72.Visible = true;
                label79.Text = names.ElementAt(23);
                pictureBox65.ImageLocation = pics.ElementAt(23);
            }
            else
            {
                panel72.Visible = false;
            }
            if (status.ElementAt(24) == "active" && type.ElementAt(24) == "Drinks")
            {
                panel76.Visible = true;
                label83.Text = names.ElementAt(24);
                pictureBox69.ImageLocation = pics.ElementAt(24);
            }
            else
            {
                panel76.Visible = false;
            }
            if (status.ElementAt(25) == "active" && type.ElementAt(25) == "Drinks")
            {
                panel80.Visible = true;
                label87.Text = names.ElementAt(25);
                pictureBox73.ImageLocation = pics.ElementAt(25);
            }
            else
            {
                panel80.Visible = false;
            }
            if (status.ElementAt(26) == "active" && type.ElementAt(26) == "Drinks")
            {
                panel84.Visible = true;
                label95.Text = names.ElementAt(26);
                pictureBox77.ImageLocation = pics.ElementAt(26);
            }
            else
            {
                panel84.Visible = false;
            }
            if (status.ElementAt(27) == "active" && type.ElementAt(27) == "Drinks")
            {
                panel88.Visible = true;
                label99.Text = names.ElementAt(27);
                pictureBox81.ImageLocation = pics.ElementAt(27);
            }
            else
            {
                panel88.Visible = false;
            }
            if (status.ElementAt(28) == "active" && type.ElementAt(28) == "Drinks")
            {
                panel92.Visible = true;
                label103.Text = names.ElementAt(28);
                pictureBox85.ImageLocation = pics.ElementAt(28);
            }
            else
            {
                panel92.Visible = false;
            }
            if (status.ElementAt(29) == "active" && type.ElementAt(29) == "Drinks")
            {
                panel96.Visible = true;
                label107.Text = names.ElementAt(29);
                pictureBox89.ImageLocation = pics.ElementAt(29);
            }
            else
            {
                panel96.Visible = false;
            }
            if (status.ElementAt(30) == "active" && type.ElementAt(30) == "Drinks")
            {
                panel100.Visible = true;
                label111.Text = names.ElementAt(30);
                pictureBox93.ImageLocation = pics.ElementAt(30);
            }
            else
            {
                panel100.Visible = false;
            }
            if (status.ElementAt(31) == "active" && type.ElementAt(31) == "Drinks")
            {
                panel104.Visible = true;
                label115.Text = names.ElementAt(31);
                pictureBox97.ImageLocation = pics.ElementAt(31);
            }
            else
            {
                panel104.Visible = false;
            }
            if (status.ElementAt(32) == "active" && type.ElementAt(32) == "Drinks")
            {
                panel108.Visible = true;
                label119.Text = names.ElementAt(33);
                pictureBox101.ImageLocation = pics.ElementAt(33);
            }
            else
            {
                panel108.Visible = false;
            }
            if (status.ElementAt(34) == "active" && type.ElementAt(34) == "Drinks")
            {
                panel112.Visible = true;
                label123.Text = names.ElementAt(34);
                pictureBox105.ImageLocation = pics.ElementAt(34);
            }
            else
            {
                panel112.Visible = false;
            }
            if (status.ElementAt(35) == "active" && type.ElementAt(35) == "Dessert")
            {
                panel21.Visible = true;
                label28.Text = names.ElementAt(35);
                pictureBox14.ImageLocation = pics.ElementAt(35);
            }
            else
            {
                panel21.Visible = false;
            }
            if (status.ElementAt(36) == "active" && type.ElementAt(36) == "Dessert")
            {
                panel25.Visible = true;
                label32.Text = names.ElementAt(36);
                pictureBox18.ImageLocation = pics.ElementAt(36);
            }
            else
            {
                panel25.Visible = false;
            }
            if (status.ElementAt(37) == "active" && type.ElementAt(37) == "Dessert")
            {
                panel29.Visible = true;
                label36.Text = names.ElementAt(37);
                pictureBox22.ImageLocation = pics.ElementAt(37);
            }
            else
            {
                panel29.Visible = false;
            }
            if (status.ElementAt(38) == "active" && type.ElementAt(38) == "Dessert")
            {
                panel17.Visible = true;
                label24.Text = names.ElementAt(38);
                pictureBox10.ImageLocation = pics.ElementAt(38);
            }
            else
            {
                panel17.Visible = false;
            }
            if (status.ElementAt(39) == "active" && type.ElementAt(39) == "Dessert")
            {
                panel13.Visible = true;
                label20.Text = names.ElementAt(39);
                pictureBox6.ImageLocation = pics.ElementAt(39);
            }
            else
            {
                panel13.Visible = false;
            }




           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            
        }

        private void Signinbutton_Click(object sender, EventArgs e)
        {
           
            DialogResult dialogResult = MessageBox.Show("Are You Sure", "Log Out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
               
                Burgers.Text = Pizzas.Text = RiceBowls.Text = Sawrmas.Text = Dumplings.Text = Pastrys.Text = Cokes.Text = Waters.Text = textBox2.Text = textBox3.Text = taka.Text = String.Empty;
                i = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                ye = 0;
                f = 0;
                timer1.Enabled = false;
                LogIn lg = new LogIn();
                lg.Show();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
            i++;
            Burgers.Text = i.ToString();
            int cash =  i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
            taka.Text = cash.ToString();
            amount = cash;
            if (i > 0)
            {


                addorder1 = name1 + "**********" + i.ToString() + " Quantity, Price: " + (i * price1).ToString() + "\n";
                Data1 = name1 + "**********" + i.ToString() + "\n";
                richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();



            }
            else
            {
                addorder1 = "";
                Data1 = "";
                richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Int32.Parse(Burgers.Text) > 0)
            {

                
                i--;
                Burgers.Text = i.ToString();
                int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
                taka.Text = cash.ToString();
                amount = cash;
                if (i > 0)
                {
                    

                    addorder1 = name1 + "**********" + i.ToString() + " Quantity, Price: " + (i * price1).ToString() + "\n";
                    Data1 = name1 + "**********" + i.ToString() + "\n";
                    richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();


                }
                else
                {
                    addorder1 = "";
                    Data1 = "";
                    richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

                }

            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
            n++;
            RiceBowls.Text = n.ToString();
            int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
            taka.Text = cash.ToString();
            amount = cash;
            if (n > 0)
            {


                addorder2 = name2 + "**********" + n.ToString() + " Quantity, Price: " + (n * price2).ToString() + "\n";
                Data2 = name2 + "**********" + n.ToString() + "\n";
                richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

            }
            else
            {
                addorder2 = "";
                Data2 = "";
                richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (Int32.Parse(RiceBowls.Text) > 0)
            {
                
                n--;
                RiceBowls.Text = n.ToString();
                int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
                taka.Text = cash.ToString();
                amount = cash;
                if (n > 0)
                {
                  

                    addorder2 = name2 + "**********" + n.ToString() + " Quantity, Price: " + (n * price2).ToString() + "\n";
                    Data2 = name2 + "**********" + n.ToString() + "\n";
                    richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

                }
                else
                {
                    addorder2 = "";
                    Data2 = "";
                    richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

                }
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            
            a++;
            Pizzas.Text = a.ToString();
            int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
            taka.Text = cash.ToString();
            amount = cash;
            if (a > 0)
            {


                addorder3 = name3 + "**********" + a.ToString() + " Quantity, Price: " + (a * price2).ToString() + "\n";
                Data3= name3 + "**********" + a.ToString() + "\n";
                richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

            }
            else
            {
                addorder3 = "";
                Data3 = "";
                richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (Int32.Parse(Pizzas.Text) > 0)
            {
               
                a--;
                Pizzas.Text = a.ToString();
                int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
                taka.Text = cash.ToString();
                amount = cash;
                if (a > 0)
                {
                    

                    addorder3 = name3 + "**********" + a.ToString() + " Quantity, Price: " + (a * price2).ToString() + "\n";
                    Data3 = name3 + "**********" + a.ToString() + "\n";
                    richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

                }
                else
                {
                    addorder3 = "";
                    Data3 = "";
                    richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

                }
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
           
            b++;
            Sawrmas.Text = b.ToString();
            int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
            taka.Text = cash.ToString();
            amount = cash;
            if (b > 0)
            {


                addorder4 = name4 + "**********" + b.ToString() + " Quantity, Price: " + (b * price4).ToString() + "\n";
                Data4= name4 + "**********" + b.ToString() + "\n";
                richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

            }
            else
            {
                addorder4 = "";
                Data4 = "";
                richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(Sawrmas.Text) > 0 )
            {
                
                b--;
                Sawrmas.Text = b.ToString();
                int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
                taka.Text = cash.ToString();
                amount = cash;
                if (b > 0)
                {
                  

                    addorder4 = name4 + "**********" + b.ToString() + " Quantity, Price: " + (b * price4).ToString() + "\n";
                    Data4 = name4 + "**********" + b.ToString() + "\n";
                    richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

                }
                else
                {
                    addorder4 = "";
                    Data4 ="";
                    richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
            c++;
            Dumplings.Text = c.ToString();
            int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
            taka.Text = cash.ToString();
            amount = cash;
            if (c > 0)
            {


                addorder5 = name5 + "**********" + c.ToString() + " Quantity, Price: " + (c * price5).ToString() + "\n";
                Data5= name5 + "**********" + c.ToString() + "\n";
                richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

            }
            else
            {
                addorder5 = "";
                Data5 = "";
                richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(Dumplings.Text) > 0 )
            {
               
                c--;
                Dumplings.Text = c.ToString();
                int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
                taka.Text = cash.ToString();
                amount = cash;
                if (c > 0)
                {
                   

                    addorder5 = name5 + "**********" + c.ToString() + " Quantity, Price: " + (c * price5).ToString() + "\n";
                    Data5 = name5 + "**********" + c.ToString() + "\n";
                    richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

                }
                else
                {
                    addorder5 = "";
                    Data5 = "";
                    richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            d++;
            Pastrys.Text = d.ToString();
            int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
            taka.Text = cash.ToString();
            amount = cash;
            if (d > 0)
            {


                addorder6 = name6 + "**********" + d.ToString() + " Quantity, Price: " + (d * price6).ToString() + "\n";
                Data6= name6 + "**********" + d.ToString() + "\n";
                richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

            }
            else
            {
                addorder6 = "";
                Data6 = "";
                richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(Pastrys.Text) > 0)
            {
                
                d--;
                Pastrys.Text = d.ToString();
                int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
                taka.Text = cash.ToString();
                amount = cash;
                if (d > 0)
                {
                    

                    addorder6 = name6 + "**********" + d.ToString() + " Quantity, Price: " + (d * price6).ToString() + "\n";
                    Data6 = name6 + "**********" + d.ToString() + "\n";
                    richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

                }
                else
                {
                    addorder6 = "";
                    Data6 = "";
                    richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
            f++;
            Waters.Text = f.ToString();
            int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
            taka.Text = cash.ToString();
            amount = cash;
            if (f > 0)
            {


                addorder8 = name8 + "**********" + f.ToString() + " Quantity, Price: " + (f * price8).ToString() + "\n";
                Data8= name8 + "**********" + f.ToString() + "\n";
                richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

            }
            else
            {
                addorder8 = "";
                Data8 = "";
                richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(Waters.Text) > 0 )
            {
                f--;
                Waters.Text = f.ToString();
                int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
                taka.Text = cash.ToString();
                amount = cash;
                if (f > 0)
                {
                   

                    addorder8 = name8 + "**********" + f.ToString() + " Quantity, Price: " + (f * price8).ToString() + "\n";
                    Data8 = name8 + "**********" + f.ToString() + "\n";
                    richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

                }
                else
                {
                    addorder8 = "";
                    Data8 = "";
                    richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
           
            ye++;
            Cokes.Text = ye.ToString();
            int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
            taka.Text = cash.ToString();
            amount = cash;
            if (ye > 0)
            {
                

                addorder7 = name7 + "**********" + ye.ToString() + " Quantity, Price: " + (ye * price7).ToString() + "\n";
                Data7= name7 + "**********" + ye.ToString() + "\n";
                richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

            }
            else
            {
                addorder7 = "";
                Data7 = "";
                richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(Cokes.Text) > 0 )
            {
               
                ye--;
                Cokes.Text = ye.ToString();
                int cash = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
                taka.Text = cash.ToString();
                amount = cash;
                if (ye > 0)
                {
                  

                    addorder7 = name7 + "**********" + ye.ToString() +" Quantity, Price: "+ (ye * price7).ToString() + "\n";
                    Data7 = name7 + "**********" + ye.ToString() + "\n";
                    richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

                }
                else
                {
                    addorder7 = "";
                    Data7 = "";
                    richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

                }
            }
        }

        private void Burgers_TextChanged(object sender, EventArgs e)
        {

        }

        private void Burgerpic_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void RiceBowls_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            label9.Visible = true;
            richTextBox1.Text = addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();
            orders= addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Entertainment en = new Entertainment();
            en.Show();
        }
        public string picture;
        public int number;
        public int id = 1;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Bkash"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM Bkash WHERE Id=" + id;
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                number = (int)reader["Phone"];
                picture = reader["QR"].ToString();


            }
            connection.Close();
            label13.Text = number.ToString();
            pictureBox2.ImageLocation = picture;
            
        }

        private void button21_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
            panel1.Visible = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 11)
            {

                MessageBox.Show("Phone number must be 11 digits");
            }
            else
            {
                pictureBox2.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label13.Visible = true;
                button22.Visible = true;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string bkash = "Bkash Paid Not Confirmed";
            int tk = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
            string Today = DateTime.Today.ToString("dddd , MMM dd yyyy");
            DateTime time = DateTime.Now;
            string ab = time.ToString("h:mm:ss tt ");
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
            connection.Open();
            string sq1 = "INSERT INTO CustomerOrders(CustomerName,TableNo,AddOn,Burger,RiceBowl,Pizza,Sawrma,Dumplings,Pastry,Coke,Water,TotalOrder,OrderTime,Price,Date,Payment,Reference) VALUES('" + textBox2.Text + "','" + tbno + "','" + textBox3.Text + "','" + i.ToString() + "','" + n.ToString() + "','" + a.ToString() + "','" + b.ToString() + "','" + c.ToString() + "','" + d.ToString() + "','" + ye.ToString() + "','" + f.ToString() + "','" + orders + "','" + ab + "','" + tk + "','" + Today + "','" +bkash+ "','" + textBox1.Text.ToString() + "')";

            SqlCommand command = new SqlCommand(sq1, connection);
            int diary = command.ExecuteNonQuery();
            connection.Close();
            if (diary > 0)
            {
                timer1.Enabled = true;
                
                textBox1.Text = string.Empty;
                groupBox1.Visible = false;
                pictureBox2.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label13.Visible = false;
                button22.Visible = false;
                panel1.Visible = false;
                string to = textBox1.Text;
                flowLayoutPanel1.Visible = true;
                richTextBox1.Text = String.Empty;
                




            }
            else
            {
                MessageBox.Show("Error");
            }
            
        }

        

        private void Bkash_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Cash_Click(object sender, EventArgs e)
        {
            string bkash = "Cash Payment";
            int tk = i * price1 + n * price2 + a * price3 + b * price4 + c * price5 + d * price6 + ye * price7 + f * price8;
            string Today = DateTime.Today.ToString("dddd , MMM dd yyyy");
            DateTime time = DateTime.Now;
            string ab = time.ToString("h:mm:ss tt ");
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
            connection.Open();
            string sq1 = "INSERT INTO CustomerOrders(CustomerName,TableNo,AddOn,Burger,RiceBowl,Pizza,Sawrma,Dumplings,Pastry,Coke,Water,TotalOrder,OrderTime,Price,Date,Payment,Reference) VALUES('" + textBox2.Text + "','" + tbno + "','" + textBox3.Text + "','" + i.ToString() + "','" + n.ToString() + "','" + a.ToString() + "','" + b.ToString() + "','" + c.ToString() + "','" + d.ToString() + "','" + ye.ToString() + "','" + f.ToString() + "','" + orders + "','" + ab + "','" + tk + "','" + Today + "','" + bkash + "','" + textBox1.Text.ToString() + "')";

            SqlCommand command = new SqlCommand(sq1, connection);
            int diary = command.ExecuteNonQuery();
            connection.Close();
            if (diary > 0)
            {
                MessageBox.Show("Clear Payment When Order Is Ready");
                timer1.Enabled = true;
                textBox1.Text = string.Empty;
                groupBox1.Visible = false;
                pictureBox2.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label13.Visible = false;
                button22.Visible = false;
                panel1.Visible = false;
                string to = textBox1.Text;
                flowLayoutPanel1.Visible = true;
                richTextBox1.Text = String.Empty;


            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            groupBox1.Visible = false;
            pictureBox2.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label13.Visible = false;
            button22.Visible = false;
            
        }
        public string mynoti;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            SqlConnection connection7 = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
            connection7.Open();
            string sq7 = "SELECT CustomerRecieved FROM CustomerOrders Where TableNo='" + label8.Text+ "' AND TotalOrder='"+orders+ "'AND CustomerName='"+textBox2.Text+"'";
            SqlCommand command7 = new SqlCommand(sq7, connection7);
            SqlDataReader reader7 = command7.ExecuteReader();

            while (reader7.Read())
            {

                
                mynoti = reader7["CustomerRecieved"].ToString();
               



            }
            if(mynoti=="Ready")
            {
                button25.Visible = true;
               
            }
            else
            {
                button25.Visible = false;
            }

            if(button25.BackColor == Color.Red)
            {
                button25.BackColor = Color.PaleGreen;
               
            }
            else if(button25.BackColor == Color.PaleGreen)
            {
                button25.BackColor = Color.Red;
                
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.Visible = false;
            timer1.Enabled = false;
            i = 0;
            n = 0;
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            ye = 0;
            f = 0;
            label8.Text = tbno.ToString();
            Burgers.Text = 0.ToString();
            RiceBowls.Text = 0.ToString();
            Pizzas.Text = 0.ToString();
            Sawrmas.Text = 0.ToString();
            Dumplings.Text = 0.ToString();
            Pastrys.Text = 0.ToString();
            Cokes.Text = 0.ToString();
            Waters.Text = 0.ToString();
            taka.Text = 0.ToString();
            textBox2.Text = textBox3.Text = String.Empty;
            addorder1 = addorder2 = addorder3 = addorder4 = addorder5 = addorder6 = addorder7 = addorder8 = "";



        }

        
        
    }
}
