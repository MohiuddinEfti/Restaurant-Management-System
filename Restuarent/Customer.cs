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
            int cash = it.ElementAt(0) * prices.ElementAt(0) + it.ElementAt(1) * prices.ElementAt(1) + it.ElementAt(2) * prices.ElementAt(2) + it.ElementAt(3) * prices.ElementAt(3) + it.ElementAt(4) * prices.ElementAt(4) + it.ElementAt(5) * prices.ElementAt(5) + it.ElementAt(6) * prices.ElementAt(6) + it.ElementAt(7) * prices.ElementAt(7) + it.ElementAt(8) * prices.ElementAt(8) + it.ElementAt(9) * prices.ElementAt(9) + it.ElementAt(10) * prices.ElementAt(10) + it.ElementAt(11) * prices.ElementAt(11) + it.ElementAt(12) * prices.ElementAt(12) + it.ElementAt(13) * prices.ElementAt(13) + it.ElementAt(14) * prices.ElementAt(14) + it.ElementAt(15) * prices.ElementAt(15) + it.ElementAt(16) * prices.ElementAt(16) + it.ElementAt(17) * prices.ElementAt(17) + it.ElementAt(18) * prices.ElementAt(18) + it.ElementAt(19) * prices.ElementAt(19) + it.ElementAt(20) * prices.ElementAt(20) + it.ElementAt(21) * prices.ElementAt(21) + it.ElementAt(22) * prices.ElementAt(22) + it.ElementAt(23) * prices.ElementAt(23) + it.ElementAt(24) * prices.ElementAt(24) + it.ElementAt(25) * prices.ElementAt(25) + it.ElementAt(26) * prices.ElementAt(26) + it.ElementAt(27) * prices.ElementAt(27) + it.ElementAt(28) * prices.ElementAt(28) + it.ElementAt(29) * prices.ElementAt(29) + it.ElementAt(30) * prices.ElementAt(30) + it.ElementAt(31) * prices.ElementAt(31) + it.ElementAt(32) * prices.ElementAt(32) + it.ElementAt(33) * prices.ElementAt(33) + it.ElementAt(34) * prices.ElementAt(34) + it.ElementAt(35) * prices.ElementAt(35) + it.ElementAt(36) * prices.ElementAt(36) + it.ElementAt(37) * prices.ElementAt(37) + it.ElementAt(38) * prices.ElementAt(38) + it.ElementAt(39) * prices.ElementAt(39);


            if (cash==0)
            {
                MessageBox.Show("You did not order anything can't take order");
            }
            else
            {
                flowLayoutPanel1.Visible = false;
                flowLayoutPanel2.Visible = false;
                flowLayoutPanel3.Visible = false;
                flowLayoutPanel4.Visible = false;
                label89.Visible = false;
                label90.Visible = false;
                label91.Visible = false;
                label92.Visible = false;
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
            pics.Clear();
            prices.Clear();
            names.Clear();
            status.Clear();
            type.Clear();
            DATA.Clear();
            ADDorder.Clear();
            it.Clear();
        }



       

        private void Form1_Load(object sender, EventArgs e)
        {

            label8.Text =tbno.ToString();
            ;label4.Visible = false;
            pics.Clear();
            prices.Clear();
            names.Clear();
            status.Clear();
            type.Clear();
            DATA.Clear();
            ADDorder.Clear();
            it.Clear();


            button330.Visible = false;
            panel1.Visible = false;
            label9.Visible = false;
            richTextBox1.Visible = false;
            groupBox1.Visible = false;
            pictureBox2.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label13.Visible = false;
            button22.Visible = false;
           

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
            for(int te=0;te<=39;te++)
            {
                it.Insert(te, 0);
                DATA.Insert(te, "");
                ADDorder.Insert(te, "");
                
                
            }

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
                label88.Text = names.ElementAt(20);
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
                panel120.Visible = true;
                label131.Text = names.ElementAt(30);
                pictureBox113.ImageLocation = pics.ElementAt(30);
            }
            else
            {
                panel120.Visible = false;
            }
            if (status.ElementAt(31) == "active" && type.ElementAt(31) == "Starter")
            {
                panel124.Visible = true;
                label135.Text = names.ElementAt(31);
                pictureBox117.ImageLocation = pics.ElementAt(31);
            }
            else
            {
                panel124.Visible = false;
            }
            if (status.ElementAt(32) == "active" && type.ElementAt(32) == "Starter")
            {
                panel128.Visible = true;
                label139.Text = names.ElementAt(32);
                pictureBox121.ImageLocation = pics.ElementAt(32);
            }
            else
            {
                panel128.Visible = false;
            }
            if (status.ElementAt(33) == "active" && type.ElementAt(33) == "Starter")
            {
                panel132.Visible = true;
                label143.Text = names.ElementAt(33);
                pictureBox125.ImageLocation = pics.ElementAt(33);
            }
            else
            {
                panel132.Visible = false;
            }
            if (status.ElementAt(34) == "active" && type.ElementAt(34) == "Starter")
            {
                panel136.Visible = true;
                label147.Text = names.ElementAt(34);
                pictureBox129.ImageLocation = pics.ElementAt(34);
            }
            else
            {
                panel136.Visible = false;
            }
            if (status.ElementAt(35) == "active" && type.ElementAt(35) == "Starter")
            {
                panel140.Visible = true;
                label151.Text = names.ElementAt(35);
                pictureBox133.ImageLocation = pics.ElementAt(35);
            }
            else
            {
                panel140.Visible = false;
            }
            if (status.ElementAt(36) == "active" && type.ElementAt(36) == "Starter")
            {
                panel144.Visible = true;
                label155.Text = names.ElementAt(36);
                pictureBox137.ImageLocation = pics.ElementAt(36);
            }
            else
            {
                panel144.Visible = false;
            }
            if (status.ElementAt(37) == "active" && type.ElementAt(37) == "Starter")
            {
                panel148.Visible = true;
                label159.Text = names.ElementAt(37);
                pictureBox141.ImageLocation = pics.ElementAt(37);
            }
            else
            {
                panel148.Visible = false;
            }
            if (status.ElementAt(38) == "active" && type.ElementAt(38) == "Starter")
            {
                panel152.Visible = true;
                label163.Text = names.ElementAt(38);
                pictureBox145.ImageLocation = pics.ElementAt(38);
            }
            else
            {
                panel152.Visible = false;
            }
            if (status.ElementAt(39) == "active" && type.ElementAt(39) == "Starter")
            {
                panel156.Visible = true;
                label167.Text = names.ElementAt(39);
                pictureBox149.ImageLocation = pics.ElementAt(39);
            }
            else
            {
                panel156.Visible = false;
            }


            
            


            //2nd row*****************************
            if (status.ElementAt(0) == "active" && type.ElementAt(0) == "Main course")
            {
                panel155.Visible = true;
                label166.Text = names.ElementAt(0);
                pictureBox148.ImageLocation = pics.ElementAt(0);
            }
            else
            {
                panel155.Visible = false;
            }
            if (status.ElementAt(1) == "active" && type.ElementAt(1) == "Main course")
            {
                panel159.Visible = true;
                label170.Text = names.ElementAt(1);
                pictureBox152.ImageLocation = pics.ElementAt(1);
            }
            else
            {
                panel159.Visible = false;
            }
            if (status.ElementAt(2) == "active" && type.ElementAt(2) == "Main course")
            {
                panel151.Visible = true;
                label162.Text = names.ElementAt(2);
                pictureBox144.ImageLocation = pics.ElementAt(2);
            }
            else
            {
                panel151.Visible = false;
            }
            if (status.ElementAt(3) == "active" && type.ElementAt(3) == "Main course")
            {
                panel147.Visible = true;
                label158.Text = names.ElementAt(3);
                pictureBox140.ImageLocation = pics.ElementAt(3);
            }
            else
            {
                panel147.Visible = false;
            }
            if (status.ElementAt(4) == "active" && type.ElementAt(4) == "Main course")
            {
                panel143.Visible = true;
                label154.Text = names.ElementAt(4);
                pictureBox136.ImageLocation = pics.ElementAt(4);
            }
            else
            {
                panel143.Visible = false;
            }
            if (status.ElementAt(5) == "active" && type.ElementAt(5) == "Main course")
            {
                panel139.Visible = true;
                label150.Text = names.ElementAt(5);
                pictureBox132.ImageLocation = pics.ElementAt(5);
            }
            else
            {
                panel139.Visible = false;
            }
            if (status.ElementAt(6) == "active" && type.ElementAt(6) == "Main course")
            {
                panel135.Visible = true;
                label146.Text = names.ElementAt(6);
                pictureBox128.ImageLocation = pics.ElementAt(6);
            }
            else
            {
                panel135.Visible = false;
            }
            if (status.ElementAt(7) == "active" && type.ElementAt(7) == "Main course")
            {
                panel131.Visible = true;
                label142.Text = names.ElementAt(7);
                pictureBox124.ImageLocation = pics.ElementAt(7);
            }
            else
            {
                panel131.Visible = false;
            }
            if (status.ElementAt(8) == "active" && type.ElementAt(8) == "Main course")
            {
                panel127.Visible = true;
                label138.Text = names.ElementAt(8);
                pictureBox120.ImageLocation = pics.ElementAt(8);
            }
            else
            {
                panel127.Visible = false;
            }
            if (status.ElementAt(9) == "active" && type.ElementAt(9) == "Main course")
            {
                panel123.Visible = true;
                label134.Text = names.ElementAt(9);
                pictureBox116.ImageLocation = pics.ElementAt(9);
            }
            else
            {
                panel123.Visible = false;
            }
            if (status.ElementAt(10) == "active" && type.ElementAt(10) == "Main course")
            {
                panel115.Visible = true;
                label126.Text = names.ElementAt(10);
                pictureBox108.ImageLocation = pics.ElementAt(10);
            }
            else
            {
                panel115.Visible = false;
            }
            if (status.ElementAt(11) == "active" && type.ElementAt(11) == "Main course")
            {
                panel111.Visible = true;
                label122.Text = names.ElementAt(11);
                pictureBox104.ImageLocation = pics.ElementAt(11);
            }
            else
            {
                panel111.Visible = false;
            }
            if (status.ElementAt(12) == "active" && type.ElementAt(12) == "Main course")
            {
                panel107.Visible = true;
                label118.Text = names.ElementAt(12);
                pictureBox100.ImageLocation = pics.ElementAt(12);
            }
            else
            {
                panel107.Visible = false;
            }
            if (status.ElementAt(13) == "active" && type.ElementAt(13) == "Main course")
            {
                panel103.Visible = true;
                label114.Text = names.ElementAt(13);
                pictureBox96.ImageLocation = pics.ElementAt(13);
            }
            else
            {
                panel103.Visible = false;
            }
            if (status.ElementAt(14) == "active" && type.ElementAt(14) == "Main course")
            {
                panel99.Visible = true;
                label110.Text = names.ElementAt(14);
                pictureBox92.ImageLocation = pics.ElementAt(14);
            }
            else
            {
                panel99.Visible = false;
            }
            if (status.ElementAt(15) == "active" && type.ElementAt(15) == "Main course")
            {
                panel95.Visible = true;
                label106.Text = names.ElementAt(15);
                pictureBox88.ImageLocation = pics.ElementAt(15);
            }
            else
            {
                panel95.Visible = false;
            }
            if (status.ElementAt(16) == "active" && type.ElementAt(16) == "Main course")
            {
                panel91.Visible = true;
                label102.Text = names.ElementAt(16);
                pictureBox84.ImageLocation = pics.ElementAt(16);
            }
            else
            {
                panel91.Visible = false;
            }
            if (status.ElementAt(17) == "active" && type.ElementAt(17) == "Main course")
            {
                panel87.Visible = true;
                label98.Text = names.ElementAt(16);
                pictureBox80.ImageLocation = pics.ElementAt(16);
            }
            else
            {
                panel87.Visible = false;
            }
            if (status.ElementAt(18) == "active" && type.ElementAt(18) == "Main course")
            {
                panel83.Visible = true;
                label94.Text = names.ElementAt(18);
                pictureBox76.ImageLocation = pics.ElementAt(18);
            }
            else
            {
                panel83.Visible = false;
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
                panel75.Visible = true;
                label82.Text = names.ElementAt(20);
                pictureBox68.ImageLocation = pics.ElementAt(20);
            }
            else
            {
                panel75.Visible = false;
            }
            if (status.ElementAt(21) == "active" && type.ElementAt(21) == "Main course")
            {
                panel71.Visible = true;
                label78.Text = names.ElementAt(21);
                pictureBox64.ImageLocation = pics.ElementAt(21);
            }
            else
            {
                panel71.Visible = false;
            }
            if (status.ElementAt(22) == "active" && type.ElementAt(22) == "Main course")
            {
                panel67.Visible = true;
                label74.Text = names.ElementAt(21);
                pictureBox60.ImageLocation = pics.ElementAt(22);
            }
            else
            {
                panel67.Visible = false;
            }
            if (status.ElementAt(23) == "active" && type.ElementAt(23) == "Main course")
            {
                panel63.Visible = true;
                label70.Text = names.ElementAt(23);
                pictureBox56.ImageLocation = pics.ElementAt(23);
            }
            else
            {
                panel63.Visible = false;
            }
            if (status.ElementAt(24) == "active" && type.ElementAt(24) == "Main course")
            {
                panel59.Visible = true;
                label66.Text = names.ElementAt(24);
                pictureBox52.ImageLocation = pics.ElementAt(24);
            }
            else
            {
                panel59.Visible = false;
            }
            if (status.ElementAt(25) == "active" && type.ElementAt(25) == "Main course")
            {
                panel55.Visible = true;
                label62.Text = names.ElementAt(25);
                pictureBox48.ImageLocation = pics.ElementAt(25);
            }
            else
            {
                panel55.Visible = false;
            }
            if (status.ElementAt(26) == "active" && type.ElementAt(26) == "Main course")
            {
                panel51.Visible = true;
                label58.Text = names.ElementAt(26);
                pictureBox44.ImageLocation = pics.ElementAt(26);
            }
            else
            {
                panel51.Visible = false;
            }
            if (status.ElementAt(27) == "active" && type.ElementAt(27) == "Main course")
            {
                panel47.Visible = true;
                label54.Text = names.ElementAt(27);
                pictureBox40.ImageLocation = pics.ElementAt(27);
            }
            else
            {
                panel47.Visible = false;
            }
            if (status.ElementAt(28) == "active" && type.ElementAt(28) == "Main course")
            {
                panel43.Visible = true;
                label50.Text = names.ElementAt(27);
                pictureBox36.ImageLocation = pics.ElementAt(28);
            }
            else
            {
                panel43.Visible = false;
            }
            if (status.ElementAt(29) == "active" && type.ElementAt(29) == "Main course")
            {
                panel39.Visible = true;
                label46.Text = names.ElementAt(29);
                pictureBox32.ImageLocation = pics.ElementAt(29);
            }
            else
            {
                panel39.Visible = false;
            }
            if (status.ElementAt(30) == "active" && type.ElementAt(30) == "Main course")
            {
                panel35.Visible = true;
                label42.Text = names.ElementAt(30);
                pictureBox28.ImageLocation = pics.ElementAt(30);
            }
            else
            {
                panel35.Visible = false;
            }
            if (status.ElementAt(31) == "active" && type.ElementAt(31) == "Main course")
            {
                panel27.Visible = true;
                label34.Text = names.ElementAt(31);
                pictureBox20.ImageLocation = pics.ElementAt(31);
            }
            else
            {
                panel27.Visible = false;
            }           
            if (status.ElementAt(32) == "active" && type.ElementAt(32) == "Main course")
            {
                panel23.Visible = true;
                label30.Text = names.ElementAt(32);
                pictureBox16.ImageLocation = pics.ElementAt(32);
            }
            else
            {
                panel23.Visible = false;
            }
            if (status.ElementAt(33) == "active" && type.ElementAt(33) == "Main course")
            {
                panel19.Visible = true;
                label26.Text = names.ElementAt(33);
                pictureBox12.ImageLocation = pics.ElementAt(33);
            }
            else
            {
                panel19.Visible = false;
            }
            if (status.ElementAt(34) == "active" && type.ElementAt(34) == "Main course")
            {
                panel15.Visible = true;
                label22.Text = names.ElementAt(34);
                pictureBox8.ImageLocation = pics.ElementAt(34);
            }
            else
            {
                panel15.Visible = false;
            }
            if (status.ElementAt(35) == "active" && type.ElementAt(35) == "Main course")
            {
                panel11.Visible = true;
                label18.Text = names.ElementAt(35);
                pictureBox4.ImageLocation = pics.ElementAt(35);
            }
            else
            {
                panel11.Visible = false;
            }
            if (status.ElementAt(36) == "active" && type.ElementAt(36) == "Main course")
            {
                panel7.Visible = true;
                Pastrylab.Text = names.ElementAt(36);
                Pastrypic.ImageLocation = pics.ElementAt(36);
            }
            else
            {
                panel7.Visible = false;
            }
            if (status.ElementAt(37) == "active" && type.ElementAt(37) == "Main course")
            {
                panel2.Visible = true;
                RicebowlLab.Text = names.ElementAt(37);
                pictureBox1.ImageLocation = pics.ElementAt(37);
            }
            else
            {
                panel2.Visible = false;
            }
            if (status.ElementAt(38) == "active" && type.ElementAt(38) == "Main course")
            {
                panel160.Visible = true;
                label171.Text = names.ElementAt(38);
                pictureBox153.ImageLocation = pics.ElementAt(38);
            }
            else
            {
                panel160.Visible = false;
            }
            if (status.ElementAt(39) == "active" && type.ElementAt(39) == "Main course")
            {
                panel70.Visible = true;
                label77.Text = names.ElementAt(39);
                pictureBox63.ImageLocation = pics.ElementAt(39);
            }
            else
            {
                panel70.Visible = false;
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
            if (status.ElementAt(8) == "active" && type.ElementAt(8) == "Dessert")
            {
                panel129.Visible = true;
                label140.Text = names.ElementAt(8);
                pictureBox122.ImageLocation = pics.ElementAt(8);
            }
            else
            {
                panel129.Visible = false;
            }
            if (status.ElementAt(9) == "active" && type.ElementAt(9) == "Dessert")
            {
                panel125.Visible = true;
                label136.Text = names.ElementAt(9);
                pictureBox118.ImageLocation = pics.ElementAt(9);
            }
            else
            {
                panel125.Visible = false;
            }
            if (status.ElementAt(10) == "active" && type.ElementAt(10) == "Dessert")
            {
                panel121.Visible = true;
                label132.Text = names.ElementAt(10);
                pictureBox114.ImageLocation = pics.ElementAt(10);
            }
            else
            {
                panel121.Visible = false;
            }
            if (status.ElementAt(11) == "active" && type.ElementAt(11) == "Dessert")
            {
                panel118.Visible = true;
                label129.Text = names.ElementAt(11);
                pictureBox111.ImageLocation = pics.ElementAt(11);
            }
            else
            {
                panel118.Visible = false;
            }
            if (status.ElementAt(12) == "active" && type.ElementAt(12) == "Dessert")
            {
                panel114.Visible = true;
                label125.Text = names.ElementAt(12);
                pictureBox107.ImageLocation = pics.ElementAt(12);
            }
            else
            {
                panel114.Visible = false;
            }
            if (status.ElementAt(13) == "active" && type.ElementAt(13) == "Dessert")
            {
                panel110.Visible = true;
                label121.Text = names.ElementAt(13);
                pictureBox103.ImageLocation = pics.ElementAt(13);
            }
            else
            {
                panel110.Visible = false;
            }
            if (status.ElementAt(14) == "active" && type.ElementAt(14) == "Dessert")
            {
                panel106.Visible = true;
                label117.Text = names.ElementAt(14);
                pictureBox99.ImageLocation = pics.ElementAt(14);
            }
            else
            {
                panel106.Visible = false;
            }
            if (status.ElementAt(15) == "active" && type.ElementAt(15) == "Dessert")
            {
                panel102.Visible = true;
                label113.Text = names.ElementAt(15);
                pictureBox95.ImageLocation = pics.ElementAt(15);
            }
            else
            {
                panel102.Visible = false;
            }
            if (status.ElementAt(16) == "active" && type.ElementAt(16) == "Dessert")
            {
                panel98.Visible = true;
                label109.Text = names.ElementAt(16);
                pictureBox91.ImageLocation = pics.ElementAt(16);
            }
            else
            {
                panel98.Visible = false;
            }
            if (status.ElementAt(17) == "active" && type.ElementAt(17) == "Dessert")
            {
                panel94.Visible = true;
                label105.Text = names.ElementAt(17);
                pictureBox87.ImageLocation = pics.ElementAt(17);
            }
            else
            {
                panel94.Visible = false;
            }
            if (status.ElementAt(18) == "active" && type.ElementAt(18) == "Dessert")
            {
                panel90.Visible = true;
                label101.Text = names.ElementAt(18);
                pictureBox83.ImageLocation = pics.ElementAt(18);
            }
            else
            {
                panel90.Visible = false;
            }
            if (status.ElementAt(19) == "active" && type.ElementAt(19) == "Dessert")
            {
                panel86.Visible = true;
                label97.Text = names.ElementAt(19);
                pictureBox79.ImageLocation = pics.ElementAt(19);
            }
            else
            {
                panel86.Visible = false;
            }
            if (status.ElementAt(20) == "active" && type.ElementAt(20) == "Dessert")
            {
                panel82.Visible = true;
                label93.Text = names.ElementAt(20);
                pictureBox75.ImageLocation = pics.ElementAt(20);
            }
            else
            {
                panel82.Visible = false;
            }
            if (status.ElementAt(21) == "active" && type.ElementAt(21) == "Dessert")
            {
                panel78.Visible = true;
                label85.Text = names.ElementAt(21);
                pictureBox71.ImageLocation = pics.ElementAt(21);
            }
            else
            {
                panel78.Visible = false;
            }
            if (status.ElementAt(22) == "active" && type.ElementAt(22) == "Dessert")
            {
                panel74.Visible = true;
                label81.Text = names.ElementAt(22);
                pictureBox67.ImageLocation = pics.ElementAt(22);
            }
            else
            {
                panel74.Visible = false;
            }           
            if (status.ElementAt(23) == "active" && type.ElementAt(23) == "Dessert")
            {
                panel66.Visible = true;
                label73.Text = names.ElementAt(23);
                pictureBox59.ImageLocation = pics.ElementAt(23);
            }
            else
            {
                panel66.Visible = false;
            }
            if (status.ElementAt(24) == "active" && type.ElementAt(24) == "Dessert")
            {
                panel62.Visible = true;
                label69.Text = names.ElementAt(24);
                pictureBox55.ImageLocation = pics.ElementAt(24);
            }
            else
            {
                panel62.Visible = false;
            }
            if (status.ElementAt(25) == "active" && type.ElementAt(25) == "Dessert")
            {
                panel58.Visible = true;
                label65.Text = names.ElementAt(25);
                pictureBox51.ImageLocation = pics.ElementAt(25);
            }
            else
            {
                panel58.Visible = false;
            }
            if (status.ElementAt(26) == "active" && type.ElementAt(26) == "Dessert")
            {
                panel54.Visible = true;
                label61.Text = names.ElementAt(26);
                pictureBox47.ImageLocation = pics.ElementAt(26);
            }
            else
            {
                panel54.Visible = false;
            }
            if (status.ElementAt(27) == "active" && type.ElementAt(27) == "Dessert")
            {
                panel50.Visible = true;
                label57.Text = names.ElementAt(27);
                pictureBox43.ImageLocation = pics.ElementAt(27);
            }
            else
            {
                panel50.Visible = false;
            }
            if (status.ElementAt(28) == "active" && type.ElementAt(28) == "Dessert")
            {
                panel46.Visible = true;
                label53.Text = names.ElementAt(28);
                pictureBox39.ImageLocation = pics.ElementAt(28);
            }
            else
            {
                panel46.Visible = false;
            }
            if (status.ElementAt(29) == "active" && type.ElementAt(29) == "Dessert")
            {
                panel42.Visible = true;
                label49.Text = names.ElementAt(29);
                pictureBox35.ImageLocation = pics.ElementAt(29);
            }
            else
            {
                panel42.Visible = false;
            }
            if (status.ElementAt(30) == "active" && type.ElementAt(30) == "Dessert")
            {
                panel38.Visible = true;
                label45.Text = names.ElementAt(30);
                pictureBox31.ImageLocation = pics.ElementAt(30);
            }
            else
            {
                panel38.Visible = false;
            }
            if (status.ElementAt(31) == "active" && type.ElementAt(31) == "Dessert")
            {
                panel34.Visible = true;
                label41.Text = names.ElementAt(31);
                pictureBox27.ImageLocation = pics.ElementAt(31);
            }
            else
            {
                panel34.Visible = false;
            }
            if (status.ElementAt(32) == "active" && type.ElementAt(32) == "Dessert")
            {
                panel31.Visible = true;
                label38.Text = names.ElementAt(32);
                pictureBox24.ImageLocation = pics.ElementAt(32);
            }
            else
            {
                panel31.Visible = false;
            }
            if (status.ElementAt(33) == "active" && type.ElementAt(33) == "Dessert")
            {
                panel20.Visible = true;
                label27.Text = names.ElementAt(33);
                pictureBox13.ImageLocation = pics.ElementAt(33);
            }
            else
            {
                panel20.Visible = false;
            }
            if (status.ElementAt(34) == "active" && type.ElementAt(34) == "Dessert")
            {
                panel16.Visible = true;
                label23.Text = names.ElementAt(34);
                pictureBox9.ImageLocation = pics.ElementAt(34);
            }
            else
            {
                panel16.Visible = false;
            }
            if (status.ElementAt(35) == "active" && type.ElementAt(35) == "Dessert")
            {
                panel12.Visible = true;
                label19.Text = names.ElementAt(35);
                pictureBox5.ImageLocation = pics.ElementAt(35);
            }
            else
            {
                panel12.Visible = false;
            }
            if (status.ElementAt(36) == "active" && type.ElementAt(36) == "Dessert")
            {
                panel8.Visible = true;
                Cokelab.Text = names.ElementAt(36);
                Cokepic.ImageLocation = pics.ElementAt(36);
            }
            else
            {
                panel8.Visible = false;
            }
            if (status.ElementAt(37) == "active" && type.ElementAt(37) == "Dessert")
            {
                panel4.Visible = true;
                Pizzalab.Text = names.ElementAt(37);
                pizzapic.ImageLocation = pics.ElementAt(37);
            }
            else
            {
                panel4.Visible = false;
            }
            if (status.ElementAt(38) == "active" && type.ElementAt(38) == "Dessert")
            {
                panel24.Visible = true;
                label31.Text = names.ElementAt(38);
                pictureBox17.ImageLocation = pics.ElementAt(38);
            }
            else
            {
                panel24.Visible = false;
            }
            if (status.ElementAt(39) == "active" && type.ElementAt(39) == "Dessert")
            {
                panel5.Visible = true;
                label35.Text = names.ElementAt(39);
                pictureBox21.ImageLocation = pics.ElementAt(39);
            }
            else
            {
                panel5.Visible = false;
            }




            //4th row*****************************
            if (status.ElementAt(0) == "active" && type.ElementAt(0) == "Drinks")
            {
                panel158.Visible = true;
                label169.Text = names.ElementAt(0);
                pictureBox151.ImageLocation = pics.ElementAt(0);
            }//
            else
            {
                panel158.Visible = false;
            }
            if (status.ElementAt(1) == "active" && type.ElementAt(1) == "Drinks")
            {
                panel154.Visible = true;
                label165.Text = names.ElementAt(1);
                pictureBox147.ImageLocation = pics.ElementAt(1);
            }//
            else
            {
                panel154.Visible = false;
            }
            if (status.ElementAt(2) == "active" && type.ElementAt(2) == "Drinks")
            {
                panel150.Visible = true;
                label161.Text = names.ElementAt(2);
                pictureBox143.ImageLocation = pics.ElementAt(2);
            }//
            else
            {
                panel150.Visible = false;
            }
            if (status.ElementAt(3) == "active" && type.ElementAt(3) == "Drinks")
            {
                panel146.Visible = true;
                label157.Text = names.ElementAt(3);
                pictureBox139.ImageLocation = pics.ElementAt(3);
            }//
            else
            {
                panel146.Visible = false;
            }
            if (status.ElementAt(4) == "active" && type.ElementAt(4) == "Drinks")
            {
                panel142.Visible = true;
                label153.Text = names.ElementAt(4);
                pictureBox135.ImageLocation = pics.ElementAt(4);
            }//
            else
            {
                panel142.Visible = false;
            }
            if (status.ElementAt(5) == "active" && type.ElementAt(5) == "Drinks")
            {
                panel138.Visible = true;
                label149.Text = names.ElementAt(5);
                pictureBox131.ImageLocation = pics.ElementAt(5);
            }//
            else
            {
                panel138.Visible = false;
            }
            if (status.ElementAt(6) == "active" && type.ElementAt(6) == "Drinks")
            {
                panel134.Visible = true;
                label145.Text = names.ElementAt(6);
                pictureBox127.ImageLocation = pics.ElementAt(6);
            }//
            else
            {
                panel134.Visible = false;
            }
            if (status.ElementAt(7) == "active" && type.ElementAt(7) == "Drinks")
            {
                panel130.Visible = true;
                label141.Text = names.ElementAt(7);
                pictureBox123.ImageLocation = pics.ElementAt(7);
            }//
            else
            {
                panel130.Visible = false;
            }
            if (status.ElementAt(8) == "active" && type.ElementAt(8) == "Drinks")
            {
                panel126.Visible = true;
                label137.Text = names.ElementAt(8);
                pictureBox119.ImageLocation = pics.ElementAt(8);
            }//
            else
            {
                panel126.Visible = false;
            }
            if (status.ElementAt(9) == "active" && type.ElementAt(9) == "Drinks")
            {
                panel122.Visible = true;
                label133.Text = names.ElementAt(9);
                pictureBox115.ImageLocation = pics.ElementAt(9);
            }//
            else
            {
                panel122.Visible = false;
            }
            if (status.ElementAt(10) == "active" && type.ElementAt(10) == "Drinks")
            {
                panel119.Visible = true;
                label30.Text = names.ElementAt(10);
                pictureBox112.ImageLocation = pics.ElementAt(10);
            }//
            else
            {
                panel119.Visible = false;
            }
            if (status.ElementAt(11) == "active" && type.ElementAt(11) == "Drinks")
            {
                panel116.Visible = true;
                label127.Text = names.ElementAt(11);
                pictureBox109.ImageLocation = pics.ElementAt(11);
            }//
            else
            {
                panel116.Visible = false;
            }
            if (status.ElementAt(12) == "active" && type.ElementAt(12) == "Drinks")
            {
                panel32.Visible = true;
                label39.Text = names.ElementAt(12);
                pictureBox25.ImageLocation = pics.ElementAt(12);
            }//
            else
            {
                panel32.Visible = false;
            }
            if (status.ElementAt(13) == "active" && type.ElementAt(13) == "Drinks")
            {
                panel36.Visible = true;
                label43.Text = names.ElementAt(13);
                pictureBox29.ImageLocation = pics.ElementAt(13);
            }//
            else
            {
                panel36.Visible = false;
            }
            if (status.ElementAt(14) == "active" && type.ElementAt(14) == "Drinks")
            {
                panel40.Visible = true;
                label47.Text = names.ElementAt(14);
                pictureBox33.ImageLocation = pics.ElementAt(14);
            }//
            else
            {
                panel40.Visible = false;
            }
            if (status.ElementAt(15) == "active" && type.ElementAt(15) == "Drinks")
            {
                panel44.Visible = true;
                label51.Text = names.ElementAt(15);
                pictureBox37.ImageLocation = pics.ElementAt(15);
            }//
            else
            {
                panel44.Visible = false;
            }
            if (status.ElementAt(16) == "active" && type.ElementAt(16) == "Drinks")
            {
                panel48.Visible = true;
                label55.Text = names.ElementAt(16);
                pictureBox41.ImageLocation = pics.ElementAt(16);
            }//
            else
            {
                panel48.Visible = false;
            }
            if (status.ElementAt(17) == "active" && type.ElementAt(17) == "Drinks")
            {
                panel52.Visible = true;
                label59.Text = names.ElementAt(17);
                pictureBox45.ImageLocation = pics.ElementAt(17);
            }//
            else
            {
                panel52.Visible = false;
            }
            if (status.ElementAt(18) == "active" && type.ElementAt(18) == "Drinks")
            {
                panel56.Visible = true;
                label63.Text = names.ElementAt(18);
                pictureBox49.ImageLocation = pics.ElementAt(18);
            }//
            else
            {
                panel56.Visible = false;
            }
            if (status.ElementAt(19) == "active" && type.ElementAt(19) == "Drinks")
            {
                panel60.Visible = true;
                label67.Text = names.ElementAt(19);
                pictureBox53.ImageLocation = pics.ElementAt(19);
            }//
            else
            {
                panel60.Visible = false;
            }
            if (status.ElementAt(20) == "active" && type.ElementAt(20) == "Drinks")
            {
                panel64.Visible = true;
                label71.Text = names.ElementAt(20);
                pictureBox57.ImageLocation = pics.ElementAt(20);
            }//
            else
            {
                panel64.Visible = false;
            }
            if (status.ElementAt(21) == "active" && type.ElementAt(21) == "Drinks")
            {
                panel68.Visible = true;
                label75.Text = names.ElementAt(21);
                pictureBox61.ImageLocation = pics.ElementAt(21);
            }//
            else
            {
                panel68.Visible = false;
            }
            if (status.ElementAt(22) == "active" && type.ElementAt(22) == "Drinks")
            {
                panel72.Visible = true;
                label79.Text = names.ElementAt(23);
                pictureBox65.ImageLocation = pics.ElementAt(23);
            }//
            else
            {
                panel72.Visible = false;
            }
            if (status.ElementAt(23) == "active" && type.ElementAt(23) == "Drinks")
            {
                panel76.Visible = true;
                label83.Text = names.ElementAt(23);
                pictureBox69.ImageLocation = pics.ElementAt(23);
            }//
            else
            {
                panel76.Visible = false;
            }
            if (status.ElementAt(24) == "active" && type.ElementAt(24) == "Drinks")
            {
                panel80.Visible = true;
                label87.Text = names.ElementAt(24);
                pictureBox73.ImageLocation = pics.ElementAt(24);
            }//
            else
            {
                panel80.Visible = false;
            }
            if (status.ElementAt(25) == "active" && type.ElementAt(25) == "Drinks")
            {
                panel84.Visible = true;
                label95.Text = names.ElementAt(25);
                pictureBox77.ImageLocation = pics.ElementAt(25);
            }//
            else
            {
                panel84.Visible = false;
            }
            if (status.ElementAt(26) == "active" && type.ElementAt(26) == "Drinks")
            {
                panel88.Visible = true;
                label99.Text = names.ElementAt(26);
                pictureBox81.ImageLocation = pics.ElementAt(26);
            }//
            else
            {
                panel88.Visible = false;
            }
            if (status.ElementAt(27) == "active" && type.ElementAt(27) == "Drinks")
            {
                panel92.Visible = true;
                label103.Text = names.ElementAt(27);
                pictureBox85.ImageLocation = pics.ElementAt(27);
            }//
            else
            {
                panel92.Visible = false;
            }
            if (status.ElementAt(28) == "active" && type.ElementAt(28) == "Drinks")
            {
                panel96.Visible = true;
                label107.Text = names.ElementAt(28);
                pictureBox89.ImageLocation = pics.ElementAt(28);
            }//
            else
            {
                panel96.Visible = false;
            }
            if (status.ElementAt(29) == "active" && type.ElementAt(29) == "Drinks")
            {
                panel100.Visible = true;
                label111.Text = names.ElementAt(29);
                pictureBox93.ImageLocation = pics.ElementAt(29);
            }//
            else
            {
                panel100.Visible = false;
            }
            if (status.ElementAt(30) == "active" && type.ElementAt(30) == "Drinks")
            {
                panel104.Visible = true;
                label115.Text = names.ElementAt(30);
                pictureBox97.ImageLocation = pics.ElementAt(30);
            }//
            else
            {
                panel104.Visible = false;
            }
            if (status.ElementAt(31) == "active" && type.ElementAt(31) == "Drinks")
            {
                panel108.Visible = true;
                label119.Text = names.ElementAt(31);
                pictureBox101.ImageLocation = pics.ElementAt(31);
            }//
            else
            {
                panel108.Visible = false;
            }
            if (status.ElementAt(32) == "active" && type.ElementAt(32) == "Drinks")
            {
                panel112.Visible = true;
                label123.Text = names.ElementAt(32);
                pictureBox105.ImageLocation = pics.ElementAt(32);
            }//
            else
            {
                panel112.Visible = false;
            }
            if (status.ElementAt(33) == "active" && type.ElementAt(33) == "Drinks")
            {
                panel21.Visible = true;
                label28.Text = names.ElementAt(33);
                pictureBox14.ImageLocation = pics.ElementAt(33);
            }//
            else
            {
                panel21.Visible = false;
            }
            if (status.ElementAt(34) == "active" && type.ElementAt(34) == "Drinks")
            {
                panel25.Visible = true;
                label32.Text = names.ElementAt(34);
                pictureBox18.ImageLocation = pics.ElementAt(34);
            }//
            else
            {
                panel25.Visible = false;
            }
            if (status.ElementAt(35) == "active" && type.ElementAt(35) == "Drinks")
            {
                panel29.Visible = true;
                label36.Text = names.ElementAt(35);
                pictureBox22.ImageLocation = pics.ElementAt(35);
            }//
            else
            {
                panel29.Visible = false;
            }
            if (status.ElementAt(36) == "active" && type.ElementAt(36) == "Drinks")
            {
                panel17.Visible = true;
                label24.Text = names.ElementAt(36);
                pictureBox10.ImageLocation = pics.ElementAt(36);
            }//
            else
            {
                panel17.Visible = false;
            }
            if (status.ElementAt(37) == "active" && type.ElementAt(37) == "Drinks")
            {
                panel13.Visible = true;
                label20.Text = names.ElementAt(37);
                pictureBox6.ImageLocation = pics.ElementAt(37);
            }//
            else
            {
                panel13.Visible = false;
            }
            if (status.ElementAt(38) == "active" && type.ElementAt(38) == "Drinks")
            {
                panel9.Visible = true;
                Waterlab.Text = names.ElementAt(38);
                Waterpic.ImageLocation = pics.ElementAt(38);
            }//
            else
            {
                panel9.Visible = false;
            }
            if (status.ElementAt(39) == "active" && type.ElementAt(39) == "Drinks")
            {
                panel28.Visible = true;
                label174.Text = names.ElementAt(39);
                pictureBox155.ImageLocation = pics.ElementAt(39);
            }//
            else
            {
                panel28.Visible = false;
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

                pics.Clear();
                prices.Clear();
                names.Clear();
                status.Clear();
                type.Clear();
                DATA.Clear();
                ADDorder.Clear();
                it.Clear();
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
            Plus(1, 0,"plus");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Plus(1, 0,"minus");
        }

        

        

       

        

        private void button12_Click(object sender, EventArgs e)
        {
           
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
            Plus(1, 1, "plus");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Plus(1, 1, "minus");
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
            //richTextBox1.Text = ADDorder.ElementAt(0) + ADDorder.ElementAt(1) + ADDorder.ElementAt(2) + ADDorder.ElementAt(3) + ADDorder.ElementAt(4) + ADDorder.ElementAt(5) + ADDorder.ElementAt(6) + ADDorder.ElementAt(7) + ADDorder.ElementAt(8) + ADDorder.ElementAt(9) + ADDorder.ElementAt(10) + ADDorder.ElementAt(11) + ADDorder.ElementAt(12) + ADDorder.ElementAt(13) + ADDorder.ElementAt(14) + ADDorder.ElementAt(15) + ADDorder.ElementAt(16) + ADDorder.ElementAt(17) + ADDorder.ElementAt(18) + ADDorder.ElementAt(19) + ADDorder.ElementAt(20) + ADDorder.ElementAt(21) + ADDorder.ElementAt(22) + ADDorder.ElementAt(23) + ADDorder.ElementAt(24) + ADDorder.ElementAt(25) + ADDorder.ElementAt(26) + ADDorder.ElementAt(27) + ADDorder.ElementAt(28) + ADDorder.ElementAt(29) + ADDorder.ElementAt(30) + ADDorder.ElementAt(31) + ADDorder.ElementAt(32) + ADDorder.ElementAt(33) + ADDorder.ElementAt(34) + ADDorder.ElementAt(35) + ADDorder.ElementAt(36) + ADDorder.ElementAt(37) + ADDorder.ElementAt(38) + ADDorder.ElementAt(39) + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

            /*orders= addorder1 + addorder2 + addorder3 + addorder4 + addorder5 + addorder6 + addorder7 + addorder8 + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();
        */
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
            flowLayoutPanel1.Visible = true;
            flowLayoutPanel2.Visible = true;
            flowLayoutPanel3.Visible = true;
            flowLayoutPanel4.Visible = true;
            label89.Visible = true;
            label90.Visible = true;
            label91.Visible = true;
            label92.Visible = true;
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
            int tk = it.ElementAt(0) * prices.ElementAt(0) + it.ElementAt(1) * prices.ElementAt(1) + it.ElementAt(2) * prices.ElementAt(2) + it.ElementAt(3) * prices.ElementAt(3) + it.ElementAt(4) * prices.ElementAt(4) + it.ElementAt(5) * prices.ElementAt(5) + it.ElementAt(6) * prices.ElementAt(6) + it.ElementAt(7) * prices.ElementAt(7) + it.ElementAt(8) * prices.ElementAt(8) + it.ElementAt(9) * prices.ElementAt(9) + it.ElementAt(10) * prices.ElementAt(10) + it.ElementAt(11) * prices.ElementAt(11) + it.ElementAt(12) * prices.ElementAt(12) + it.ElementAt(13) * prices.ElementAt(13) + it.ElementAt(14) * prices.ElementAt(14) + it.ElementAt(15) * prices.ElementAt(15) + it.ElementAt(16) * prices.ElementAt(16) + it.ElementAt(17) * prices.ElementAt(17) + it.ElementAt(18) * prices.ElementAt(18) + it.ElementAt(19) * prices.ElementAt(19) + it.ElementAt(20) * prices.ElementAt(20) + it.ElementAt(21) * prices.ElementAt(21) + it.ElementAt(22) * prices.ElementAt(22) + it.ElementAt(23) * prices.ElementAt(23) + it.ElementAt(24) * prices.ElementAt(24) + it.ElementAt(25) * prices.ElementAt(25) + it.ElementAt(26) * prices.ElementAt(26) + it.ElementAt(27) * prices.ElementAt(27) + it.ElementAt(28) * prices.ElementAt(28) + it.ElementAt(29) * prices.ElementAt(29) + it.ElementAt(30) * prices.ElementAt(30) + it.ElementAt(31) * prices.ElementAt(31) + it.ElementAt(32) * prices.ElementAt(32) + it.ElementAt(33) * prices.ElementAt(33) + it.ElementAt(34) * prices.ElementAt(34) + it.ElementAt(35) * prices.ElementAt(35) + it.ElementAt(36) * prices.ElementAt(36) + it.ElementAt(37) * prices.ElementAt(37) + it.ElementAt(38) * prices.ElementAt(38) + it.ElementAt(39) * prices.ElementAt(39);
            string data = DATA.ElementAt(0) + DATA.ElementAt(1) + DATA.ElementAt(2) + DATA.ElementAt(3) + DATA.ElementAt(4) + DATA.ElementAt(5) + DATA.ElementAt(6) + DATA.ElementAt(7) + DATA.ElementAt(8) + DATA.ElementAt(9) + DATA.ElementAt(10) + DATA.ElementAt(11) + DATA.ElementAt(12) + DATA.ElementAt(13) + DATA.ElementAt(14) + DATA.ElementAt(15) + DATA.ElementAt(16) + DATA.ElementAt(17) + DATA.ElementAt(18) + DATA.ElementAt(19) + DATA.ElementAt(20) + DATA.ElementAt(21) + DATA.ElementAt(22) + DATA.ElementAt(23) + DATA.ElementAt(24) + DATA.ElementAt(25) + DATA.ElementAt(26) + DATA.ElementAt(27) + DATA.ElementAt(28) + DATA.ElementAt(29) + DATA.ElementAt(30) + DATA.ElementAt(31) + DATA.ElementAt(32) + DATA.ElementAt(33) + DATA.ElementAt(34) + DATA.ElementAt(35) + DATA.ElementAt(36) + DATA.ElementAt(37) + DATA.ElementAt(38) + DATA.ElementAt(39);
            string Today = DateTime.Today.ToString("dddd , MMM dd yyyy");
             DateTime time = DateTime.Now;
             string ab =grab= time.ToString("h:mm:ss tt");
             SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
             connection.Open();
             string sq1 = "INSERT INTO CustomerOrders(CustomerName,TableNo,TotalOrder,OrderTime,Price,Date,Payment,Reference) VALUES('" + textBox2.Text + "','" + tbno + "','" + data + "','" + ab + "','" + tk + "','" + Today + "','" +bkash+ "','" + textBox1.Text.ToString() + "')";

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

                label4.Visible = true;
                 richTextBox1.Text = String.Empty;
                 flowLayoutPanel1.Visible = true;
                 flowLayoutPanel2.Visible = true;
                 flowLayoutPanel3.Visible = true;
                 flowLayoutPanel4.Visible = true;
                 label89.Visible = true;
                 label90.Visible = true;
                 label91.Visible = true;
                 label92.Visible = true;




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
        public string grab;
        private void Cash_Click(object sender, EventArgs e)
        {
            string bkash = "Cash Payment";
            int tk = it.ElementAt(0) * prices.ElementAt(0) + it.ElementAt(1) * prices.ElementAt(1) + it.ElementAt(2) * prices.ElementAt(2) + it.ElementAt(3) * prices.ElementAt(3) + it.ElementAt(4) * prices.ElementAt(4) + it.ElementAt(5) * prices.ElementAt(5) + it.ElementAt(6) * prices.ElementAt(6) + it.ElementAt(7) * prices.ElementAt(7) + it.ElementAt(8) * prices.ElementAt(8) + it.ElementAt(9) * prices.ElementAt(9) + it.ElementAt(10) * prices.ElementAt(10) + it.ElementAt(11) * prices.ElementAt(11) + it.ElementAt(12) * prices.ElementAt(12) + it.ElementAt(13) * prices.ElementAt(13) + it.ElementAt(14) * prices.ElementAt(14) + it.ElementAt(15) * prices.ElementAt(15) + it.ElementAt(16) * prices.ElementAt(16) + it.ElementAt(17) * prices.ElementAt(17) + it.ElementAt(18) * prices.ElementAt(18) + it.ElementAt(19) * prices.ElementAt(19) + it.ElementAt(20) * prices.ElementAt(20) + it.ElementAt(21) * prices.ElementAt(21) + it.ElementAt(22) * prices.ElementAt(22) + it.ElementAt(23) * prices.ElementAt(23) + it.ElementAt(24) * prices.ElementAt(24) + it.ElementAt(25) * prices.ElementAt(25) + it.ElementAt(26) * prices.ElementAt(26) + it.ElementAt(27) * prices.ElementAt(27) + it.ElementAt(28) * prices.ElementAt(28) + it.ElementAt(29) * prices.ElementAt(29) + it.ElementAt(30) * prices.ElementAt(30) + it.ElementAt(31) * prices.ElementAt(31) + it.ElementAt(32) * prices.ElementAt(32) + it.ElementAt(33) * prices.ElementAt(33) + it.ElementAt(34) * prices.ElementAt(34) + it.ElementAt(35) * prices.ElementAt(35) + it.ElementAt(36) * prices.ElementAt(36) + it.ElementAt(37) * prices.ElementAt(37) + it.ElementAt(38) * prices.ElementAt(38) + it.ElementAt(39) * prices.ElementAt(39);
            string data = DATA.ElementAt(0) + DATA.ElementAt(1) + DATA.ElementAt(2) + DATA.ElementAt(3) + DATA.ElementAt(4) + DATA.ElementAt(5) + DATA.ElementAt(6) + DATA.ElementAt(7) + DATA.ElementAt(8) + DATA.ElementAt(9) + DATA.ElementAt(10) + DATA.ElementAt(11) + DATA.ElementAt(12) + DATA.ElementAt(13) + DATA.ElementAt(14) + DATA.ElementAt(15) + DATA.ElementAt(16) + DATA.ElementAt(17) + DATA.ElementAt(18) + DATA.ElementAt(19) + DATA.ElementAt(20) + DATA.ElementAt(21) + DATA.ElementAt(22) + DATA.ElementAt(23) + DATA.ElementAt(24) + DATA.ElementAt(25) + DATA.ElementAt(26) + DATA.ElementAt(27) + DATA.ElementAt(28) + DATA.ElementAt(29) + DATA.ElementAt(30) + DATA.ElementAt(31) + DATA.ElementAt(32) + DATA.ElementAt(33) + DATA.ElementAt(34) + DATA.ElementAt(35) + DATA.ElementAt(36) + DATA.ElementAt(37) + DATA.ElementAt(38) + DATA.ElementAt(39);
            string Today = DateTime.Today.ToString("dddd , MMM dd yyyy");
            DateTime time = DateTime.Now;
            string ab =grab= time.ToString("h:mm:ss tt ");
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
            connection.Open();
            string sq1 = "INSERT INTO CustomerOrders(CustomerName,TableNo,TotalOrder,OrderTime,Price,Date,Payment,Reference) VALUES('" + textBox2.Text + "','" + tbno + "','" + data + "','" + ab + "','" + tk + "','" + Today + "','" + bkash + "','" + textBox1.Text.ToString() + "')";
            SqlCommand command = new SqlCommand(sq1, connection);
             int diary = command.ExecuteNonQuery();
             connection.Close();
             if (diary > 0)
             {
                 MessageBox.Show("Clear Payment When Order Is Ready");
                 timer1.Enabled = true;
                label4.Visible = true;
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
                  flowLayoutPanel2.Visible = true;
                  flowLayoutPanel3.Visible = true;
                  flowLayoutPanel4.Visible = true;
                  label89.Visible = true;
                  label90.Visible = true;
                  label91.Visible = true;
                  label92.Visible = true;
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
        

       

        private void button27_Click(object sender, EventArgs e)
        {            
            Plus(1, 2, "plus");
        }

        private void button35_Click(object sender, EventArgs e)
        {        
            Plus(1, 3, "plus");
        }

        private void button43_Click(object sender, EventArgs e)
        {          
            Plus(1, 4, "plus");
        }

        private void button51_Click(object sender, EventArgs e)
        {           
            Plus(1, 5, "plus");
        }

        private void button59_Click(object sender, EventArgs e)
        {     
            Plus(1, 6, "plus");
        }

        private void button67_Click(object sender, EventArgs e)
        {           
            Plus(1, 7, "plus");
        }

        private void button73_Click(object sender, EventArgs e)
        {           
            Plus(1, 8, "plus");
        }

        private void button81_Click(object sender, EventArgs e)
        {            
            Plus(1, 9, "plus");
        }

        private void button89_Click(object sender, EventArgs e)
        {           
            Plus(1, 10, "plus");
        }

        private void button97_Click(object sender, EventArgs e)
        {           
            Plus(1, 11, "plus");
        }

        private void button105_Click(object sender, EventArgs e)
        {           
            Plus(1, 12, "plus");
        }

        private void button113_Click(object sender, EventArgs e)
        {           
            Plus(1, 13, "plus");
        }

        private void button121_Click(object sender, EventArgs e)
        {          
            Plus(1, 14, "plus");
        }

        private void button129_Click(object sender, EventArgs e)
        {          
            Plus(1, 15, "plus");
        }

        private void button137_Click(object sender, EventArgs e)
        {            
            Plus(1, 16, "plus");
        }

        private void button145_Click(object sender, EventArgs e)
        {           
            Plus(1, 17, "plus");
        }

        private void button153_Click(object sender, EventArgs e)
        {          
            Plus(1, 18, "plus");
        }

        private void button161_Click(object sender, EventArgs e)
        {           
            Plus(1, 19, "plus");
        }

        private void button169_Click(object sender, EventArgs e)
        {  
            Plus(1, 20, "plus");
        }

        public void Plus(int row, int number,string sumtyp)
        {
                int op = number;
                int i = it.ElementAt(op);
                if(sumtyp=="plus")
                {
                    i++;
                }
                else if (sumtyp == "minus")
                {   if (i > 0)
                    {
                        i--;
                    }
                }
            
                it.RemoveAt(op);
            
                it.Insert(op, i);
                if (row == 1)
                {
                    if (number == 0)
                    {
                        Burgers.Text = i.ToString();
                    }
                    else if (number == 1)
                    {
                        Dumplings.Text = i.ToString();
                    }
                    else if (number == 2)
                    {
                        textBox4.Text = i.ToString();
                    }
                    else if (number == 3)
                    {
                        textBox8.Text = i.ToString();
                    }
                    else if (number == 4)
                    {
                        textBox12.Text = i.ToString();
                    }
                    else if (number == 5)
                    {
                        textBox16.Text = i.ToString();
                    }
                    else if (number == 6)
                    {
                        textBox20.Text = i.ToString();
                    }
                    else if (number == 7)
                    {
                        textBox24.Text = i.ToString();
                    }
                    else if (number == 8)
                    {
                        textBox27.Text = i.ToString();
                    }
                    else if (number == 9)
                    {
                        textBox31.Text = i.ToString();
                    }
                    else if (number == 10)
                    {
                        textBox35.Text = i.ToString();
                    }
                    else if (number == 11)
                    {
                        textBox39.Text = i.ToString();
                    }
                    else if (number == 12)
                    {
                        textBox43.Text = i.ToString();
                    }
                    else if (number == 13)
                    {
                        textBox47.Text = i.ToString();
                    }
                    else if (number == 14)
                    {
                        textBox51.Text = i.ToString();
                    }
                    else if (number == 15)
                    {
                        textBox55.Text = i.ToString();
                    }
                    else if (number == 16)
                    {
                        textBox59.Text = i.ToString();
                    }
                    else if (number == 17)
                    {
                        textBox63.Text = i.ToString();
                    }
                    else if (number == 18)
                    {
                        textBox67.Text = i.ToString();
                    }
                    else if (number == 19)
                    {
                        textBox71.Text = i.ToString();
                    }
                    else if (number == 20)
                    {
                        textBox75.Text = i.ToString();
                    }
                    else if (number == 21)
                    {
                        textBox79.Text = i.ToString();
                    }
                    else if (number == 22)
                    {
                        textBox83.Text = i.ToString();
                    }
                    else if (number == 23)
                    {
                        textBox87.Text = i.ToString();
                    }
                    else if (number == 24)
                    {
                        textBox91.Text = i.ToString();
                    }
                    else if (number == 25)
                    {
                        textBox95.Text = i.ToString();
                    }
                    else if (number == 26)
                    {
                        textBox99.Text = i.ToString();
                    }
                    else if (number == 27)
                    {
                        textBox103.Text = i.ToString();
                    }
                    else if (number == 28)
                    {
                        textBox107.Text = i.ToString();
                    }
                    else if (number == 29)
                    {
                        textBox111.Text = i.ToString();
                    }
                    else if (number == 30)
                    {
                        textBox114.Text = i.ToString();
                    }
                    else if (number == 31)
                    {
                        textBox118.Text = i.ToString();
                    }
                    else if (number == 32)
                    {
                        textBox122.Text = i.ToString();
                    }
                    else if (number == 33)
                    {
                        textBox126.Text = i.ToString();
                    }
                    else if (number == 34)
                    {
                        textBox130.Text = i.ToString();
                    }
                    else if (number == 35)
                    {
                        textBox134.Text = i.ToString();
                    }
                    else if (number == 36)
                    {
                        textBox138.Text = i.ToString();
                    }
                    else if (number == 37)
                    {
                        textBox142.Text = i.ToString();
                    }
                    else if (number == 38)
                    {
                        textBox146.Text = i.ToString();
                    }
                    else if (number == 39)
                    {
                        textBox150.Text = i.ToString();
                    }

                }
                else if (row == 2)
                {
                    if (number == 0)
                    {
                        textBox149.Text = i.ToString();
                    }
                    else if (number == 1)
                    {
                        textBox153.Text = i.ToString();
                    }
                    else if (number == 2)
                    {
                        textBox145.Text = i.ToString();
                    }
                    else if (number == 3)
                    {
                        textBox141.Text = i.ToString();
                    }
                    else if (number == 4)
                    {
                        textBox137.Text = i.ToString();
                    }
                    else if (number == 5)
                    {
                        textBox133.Text = i.ToString();
                    }
                    else if (number == 6)
                    {
                        textBox129.Text = i.ToString();
                    }
                    else if (number == 7)
                    {
                        textBox125.Text = i.ToString();
                    }
                    else if (number == 8)
                    {
                        textBox121.Text = i.ToString();
                    }
                    else if (number == 9)
                    {
                        textBox117.Text = i.ToString();
                    }
                    else if (number == 10)
                    {
                        textBox109.Text = i.ToString();
                    }
                    else if (number == 11)
                    {
                        textBox105.Text = i.ToString();
                    }
                    else if (number == 12)
                    {
                        textBox101.Text = i.ToString();
                    }
                    else if (number == 13)
                    {
                        textBox97.Text = i.ToString();
                    }
                    else if (number == 14)
                    {
                        textBox93.Text = i.ToString();
                    }
                    else if (number == 15)
                    {
                        textBox89.Text = i.ToString();
                    }
                    else if (number == 16)
                    {
                        textBox85.Text = i.ToString();
                    }
                    else if (number == 17)
                    {
                        textBox81.Text = i.ToString();
                    }
                    else if (number == 18)
                    {
                        textBox77.Text = i.ToString();
                    }
                    else if (number == 19)
                    {
                        textBox73.Text = i.ToString();
                    }
                    else if (number == 20)
                    {
                        textBox69.Text = i.ToString();
                    }
                    else if (number == 21)
                    {
                        textBox65.Text = i.ToString();
                    }
                    else if (number == 22)
                    {
                        textBox61.Text = i.ToString();
                    }
                    else if (number == 23)
                    {
                        textBox57.Text = i.ToString();
                    }
                    else if (number == 24)
                    {
                        textBox53.Text = i.ToString();
                    }
                    else if (number == 25)
                    {
                        textBox49.Text = i.ToString();
                    }
                    else if (number == 26)
                    {
                        textBox45.Text = i.ToString();
                    }
                    else if (number == 27)
                    {
                        textBox41.Text = i.ToString();
                    }
                    else if (number == 28)
                    {
                        textBox37.Text = i.ToString();
                    }
                    else if (number == 29)
                    {
                        textBox33.Text = i.ToString();
                    }
                    else if (number == 30)
                    {
                        textBox29.Text = i.ToString();
                    }
                    else if (number == 31)
                    {
                        textBox21.Text = i.ToString();
                    }
                    else if (number == 32)
                    {
                        textBox17.Text = i.ToString();
                    }
                    else if (number == 33)
                    {
                        textBox13.Text = i.ToString();
                    }
                    else if (number == 34)
                    {
                        textBox9.Text = i.ToString();
                    }
                    else if (number == 35)
                    {
                        textBox5.Text = i.ToString();
                    }
                    else if (number == 36)
                    {
                        Pastrys.Text = i.ToString();
                    }
                    else if (number == 37)
                    {
                        RiceBowls.Text = i.ToString();
                    }
                    else if (number == 38)
                    {
                        textBox154.Text = i.ToString();
                    }
                    else if (number == 39)
                    {
                        textBox64.Text = i.ToString();
                    }

                }
                else if (row == 3)
                {
                    if (number == 0)
                    {
                        textBox149.Text = i.ToString();
                    }
                    else if (number == 1)
                    {
                        textBox153.Text = i.ToString();
                    }
                    else if (number == 2)
                    {
                        textBox145.Text = i.ToString();
                    }
                    else if (number == 3)
                    {
                        textBox141.Text = i.ToString();
                    }
                    else if (number == 4)
                    {
                        textBox137.Text = i.ToString();
                    }
                    else if (number == 5)
                    {
                        textBox133.Text = i.ToString();
                    }
                    else if (number == 6)
                    {
                        textBox129.Text = i.ToString();
                    }
                    else if (number == 7)
                    {
                        textBox125.Text = i.ToString();
                    }
                    else if (number == 8)
                    {
                        textBox121.Text = i.ToString();
                    }
                    else if (number == 9)
                    {
                        textBox117.Text = i.ToString();
                    }
                    else if (number == 10)
                    {
                        textBox109.Text = i.ToString();
                    }
                    else if (number == 11)
                    {
                        textBox105.Text = i.ToString();
                    }
                    else if (number == 12)
                    {
                        textBox101.Text = i.ToString();
                    }
                    else if (number == 13)
                    {
                        textBox97.Text = i.ToString();
                    }
                    else if (number == 14)
                    {
                        textBox93.Text = i.ToString();
                    }
                    else if (number == 15)
                    {
                        textBox89.Text = i.ToString();
                    }
                    else if (number == 16)
                    {
                        textBox85.Text = i.ToString();
                    }
                    else if (number == 17)
                    {
                        textBox81.Text = i.ToString();
                    }
                    else if (number == 18)
                    {
                        textBox77.Text = i.ToString();
                    }
                    else if (number == 19)
                    {
                        textBox73.Text = i.ToString();
                    }
                    else if (number == 20)
                    {
                        textBox69.Text = i.ToString();
                    }
                    else if (number == 21)
                    {
                        textBox65.Text = i.ToString();
                    }
                    else if (number == 22)
                    {
                        textBox61.Text = i.ToString();
                    }
                    else if (number == 23)
                    {
                        textBox57.Text = i.ToString();
                    }
                    else if (number == 24)
                    {
                        textBox53.Text = i.ToString();
                    }
                    else if (number == 25)
                    {
                        textBox49.Text = i.ToString();
                    }
                    else if (number == 26)
                    {
                        textBox45.Text = i.ToString();
                    }
                    else if (number == 27)
                    {
                        textBox41.Text = i.ToString();
                    }
                    else if (number == 28)
                    {
                        textBox37.Text = i.ToString();
                    }
                    else if (number == 29)
                    {
                        textBox33.Text = i.ToString();
                    }
                    else if (number == 30)
                    {
                        textBox29.Text = i.ToString();
                    }
                    else if (number == 31)
                    {
                        textBox21.Text = i.ToString();
                    }
                    else if (number == 32)
                    {
                        textBox17.Text = i.ToString();
                    }
                    else if (number == 33)
                    {
                        textBox13.Text = i.ToString();
                    }
                    else if (number == 34)
                    {
                        textBox9.Text = i.ToString();
                    }
                    else if (number == 35)
                    {
                        textBox5.Text = i.ToString();
                    }
                    else if (number == 36)
                    {
                        Pastrys.Text = i.ToString();
                    }
                    else if (number == 37)
                    {
                        RiceBowls.Text = i.ToString();
                    }
                    else if (number == 38)
                    {
                        textBox154.Text = i.ToString();
                    }
                    else if (number == 39)
                    {
                        textBox64.Text = i.ToString();
                    }

                }
                else if (row == 4)
                {
                    if (number == 0)
                    {
                        textBox152.Text = i.ToString();
                    }
                    else if (number == 1)
                    {
                        textBox148.Text = i.ToString();
                    }
                    else if (number == 2)
                    {
                        textBox144.Text = i.ToString();
                    }
                    else if (number == 3)
                    {
                        textBox140.Text = i.ToString();
                    }
                    else if (number == 4)
                    {
                        textBox136.Text = i.ToString();
                    }
                    else if (number == 5)
                    {
                        textBox132.Text = i.ToString();
                    }
                    else if (number == 6)
                    {
                        textBox128.Text = i.ToString();
                    }
                    else if (number == 7)
                    {
                        textBox124.Text = i.ToString();
                    }
                    else if (number == 8)
                    {
                        textBox120.Text = i.ToString();
                    }
                    else if (number == 9)
                    {
                        textBox116.Text = i.ToString();
                    }
                    else if (number == 10)
                    {
                        textBox113.Text = i.ToString();
                    }
                    else if (number == 11)
                    {
                        textBox110.Text = i.ToString();
                    }
                    else if (number == 12)
                    {
                        textBox106.Text = i.ToString();
                    }
                    else if (number == 13)
                    {
                        textBox102.Text = i.ToString();
                    }
                    else if (number == 14)
                    {
                        textBox98.Text = i.ToString();
                    }
                    else if (number == 15)
                    {
                        textBox94.Text = i.ToString();
                    }
                    else if (number == 16)
                    {
                        textBox90.Text = i.ToString();
                    }
                    else if (number == 17)
                    {
                        textBox86.Text = i.ToString();
                    }
                    else if (number == 18)
                    {
                        textBox82.Text = i.ToString();
                    }
                    else if (number == 19)
                    {
                        textBox78.Text = i.ToString();
                    }
                    else if (number == 20)
                    {
                        textBox74.Text = i.ToString();
                    }
                    else if (number == 21)
                    {
                        textBox70.Text = i.ToString();
                    }
                    else if (number == 22)
                    {
                        textBox66.Text = i.ToString();
                    }
                    else if (number == 23)
                    {
                        textBox62.Text = i.ToString();
                    }
                    else if (number == 24)
                    {
                        textBox58.Text = i.ToString();
                    }
                    else if (number == 25)
                    {
                        textBox54.Text = i.ToString();
                    }
                    else if (number == 26)
                    {
                        textBox50.Text = i.ToString();
                    }
                    else if (number == 27)
                    {
                        textBox46.Text = i.ToString();
                    }
                    else if (number == 28)
                    {
                        textBox42.Text = i.ToString();
                    }
                    else if (number == 29)
                    {
                        textBox38.Text = i.ToString();
                    }
                    else if (number == 30)
                    {
                        textBox34.Text = i.ToString();
                    }
                    else if (number == 31)
                    {
                        textBox30.Text = i.ToString();
                    }
                    else if (number == 32)
                    {
                        textBox26.Text = i.ToString();
                    }
                    else if (number == 33)
                    {
                        textBox23.Text = i.ToString();
                    }
                    else if (number == 34)
                    {
                        textBox19.Text = i.ToString();
                    }
                    else if (number == 35)
                    {
                        textBox15.Text = i.ToString();
                    }
                    else if (number == 36)
                    {
                        textBox11.Text = i.ToString();
                    }
                    else if (number == 37)
                    {
                        textBox7.Text = i.ToString();
                    }
                    else if (number == 38)
                    {
                        Waters.Text = i.ToString();
                    }
                    else if (number == 39)
                    {
                        textBox150.Text = i.ToString();
                    }

                }

            int cash = it.ElementAt(0) * prices.ElementAt(0) + it.ElementAt(1) * prices.ElementAt(1) + it.ElementAt(2) * prices.ElementAt(2) + it.ElementAt(3) * prices.ElementAt(3) + it.ElementAt(4) * prices.ElementAt(4) + it.ElementAt(5) * prices.ElementAt(5) + it.ElementAt(6) * prices.ElementAt(6) + it.ElementAt(7) * prices.ElementAt(7) + it.ElementAt(8) * prices.ElementAt(8) + it.ElementAt(9) * prices.ElementAt(9) + it.ElementAt(10) * prices.ElementAt(10) + it.ElementAt(11) * prices.ElementAt(11) + it.ElementAt(12) * prices.ElementAt(12) + it.ElementAt(13) * prices.ElementAt(13) + it.ElementAt(14) * prices.ElementAt(14) + it.ElementAt(15) * prices.ElementAt(15) + it.ElementAt(16) * prices.ElementAt(16) + it.ElementAt(17) * prices.ElementAt(17) + it.ElementAt(18) * prices.ElementAt(18) + it.ElementAt(19) * prices.ElementAt(19) + it.ElementAt(20) * prices.ElementAt(20) + it.ElementAt(21) * prices.ElementAt(21) + it.ElementAt(22) * prices.ElementAt(22) + it.ElementAt(23) * prices.ElementAt(23) + it.ElementAt(24) * prices.ElementAt(24) + it.ElementAt(25) * prices.ElementAt(25) + it.ElementAt(26) * prices.ElementAt(26) + it.ElementAt(27) * prices.ElementAt(27) + it.ElementAt(28) * prices.ElementAt(28) + it.ElementAt(29) * prices.ElementAt(29) + it.ElementAt(30) * prices.ElementAt(30) + it.ElementAt(31) * prices.ElementAt(31) + it.ElementAt(32) * prices.ElementAt(32) + it.ElementAt(33) * prices.ElementAt(33) + it.ElementAt(34) * prices.ElementAt(34) + it.ElementAt(35) * prices.ElementAt(35) + it.ElementAt(36) * prices.ElementAt(36) + it.ElementAt(37) * prices.ElementAt(37) + it.ElementAt(38) * prices.ElementAt(38) + it.ElementAt(39) * prices.ElementAt(39);
                taka.Text = cash.ToString();
                amount = cash;
                if (ADDorder.ElementAt(op) != names.ElementAt(op) + "**********" + 0 + " Quantity, Price: " + 0 + "\n"&&i>0)
                {

                ADDorder.RemoveAt(op);
                DATA.RemoveAt(op);
                ADDorder.Insert(op, names.ElementAt(op) + "**********" + it.ElementAt(op) + " Quantity, Price: " + (it.ElementAt(op) * prices.ElementAt(op)).ToString() + "\n");
                    DATA.Insert(op, names.ElementAt(op) + "**********" + i.ToString() + "\n");
                    richTextBox1.Text = ADDorder.ElementAt(0) + ADDorder.ElementAt(1) + ADDorder.ElementAt(2) + ADDorder.ElementAt(3) + ADDorder.ElementAt(4) + ADDorder.ElementAt(5) + ADDorder.ElementAt(6) + ADDorder.ElementAt(7) + ADDorder.ElementAt(8) + ADDorder.ElementAt(9) + ADDorder.ElementAt(10) + ADDorder.ElementAt(11) + ADDorder.ElementAt(12) + ADDorder.ElementAt(13) + ADDorder.ElementAt(14) + ADDorder.ElementAt(15) + ADDorder.ElementAt(16) + ADDorder.ElementAt(17) + ADDorder.ElementAt(18) + ADDorder.ElementAt(19) + ADDorder.ElementAt(20) + ADDorder.ElementAt(21) + ADDorder.ElementAt(22) + ADDorder.ElementAt(23) + ADDorder.ElementAt(24) + ADDorder.ElementAt(25) + ADDorder.ElementAt(26) + ADDorder.ElementAt(27) + ADDorder.ElementAt(28) + ADDorder.ElementAt(29) + ADDorder.ElementAt(30) + ADDorder.ElementAt(31) + ADDorder.ElementAt(32) + ADDorder.ElementAt(33) + ADDorder.ElementAt(34) + ADDorder.ElementAt(35) + ADDorder.ElementAt(36) + ADDorder.ElementAt(37) + ADDorder.ElementAt(38) + ADDorder.ElementAt(39) + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();
                    


                }
                else
                {
                ADDorder.RemoveAt(op);
                DATA.RemoveAt(op);
                ADDorder.Insert(op, "");
                DATA.Insert(op, "");
                richTextBox1.Text = ADDorder.ElementAt(0) + ADDorder.ElementAt(1) + ADDorder.ElementAt(2) + ADDorder.ElementAt(3) + ADDorder.ElementAt(4) + ADDorder.ElementAt(5) + ADDorder.ElementAt(6) + ADDorder.ElementAt(7) + ADDorder.ElementAt(8) + ADDorder.ElementAt(9) + ADDorder.ElementAt(10) + ADDorder.ElementAt(11) + ADDorder.ElementAt(12) + ADDorder.ElementAt(13) + ADDorder.ElementAt(14) + ADDorder.ElementAt(15) + ADDorder.ElementAt(16) + ADDorder.ElementAt(17) + ADDorder.ElementAt(18) + ADDorder.ElementAt(19) + ADDorder.ElementAt(20) + ADDorder.ElementAt(21) + ADDorder.ElementAt(22) + ADDorder.ElementAt(23) + ADDorder.ElementAt(24) + ADDorder.ElementAt(25) + ADDorder.ElementAt(26) + ADDorder.ElementAt(27) + ADDorder.ElementAt(28) + ADDorder.ElementAt(29) + ADDorder.ElementAt(30) + ADDorder.ElementAt(31) + ADDorder.ElementAt(32) + ADDorder.ElementAt(33) + ADDorder.ElementAt(34) + ADDorder.ElementAt(35) + ADDorder.ElementAt(36) + ADDorder.ElementAt(37) + ADDorder.ElementAt(38) + ADDorder.ElementAt(39) + "\n" + "\n" + "Total Price*****************" + taka.Text.ToString();

                }

        }

        private void button177_Click(object sender, EventArgs e)
        {
            Plus(1, 21, "plus");
        }

        private void button185_Click(object sender, EventArgs e)
        {
            Plus(1, 22, "plus");
        }

        private void button193_Click(object sender, EventArgs e)
        {       
            Plus(1, 23, "plus");
        }

        private void button201_Click(object sender, EventArgs e)
        {    
            Plus(1, 24, "plus");
        }

        private void button209_Click(object sender, EventArgs e)
        {     
            Plus(1, 25, "plus");
        }

        private void button217_Click(object sender, EventArgs e)
        {            
            Plus(1, 26, "plus");
        }

        private void button225_Click(object sender, EventArgs e)
        {         
            Plus(1, 27, "plus");
        }

        private void button233_Click(object sender, EventArgs e)
        {          
            Plus(1, 28, "plus");
        }

        private void button241_Click(object sender, EventArgs e)
        {           
            Plus(1, 29, "plus");
        }

        private void button247_Click(object sender, EventArgs e)
        {            
            Plus(1, 30, "plus");
        }

        private void button255_Click(object sender, EventArgs e)
        {            
            Plus(1, 31, "plus");
        }

        private void button263_Click(object sender, EventArgs e)
        {            
            Plus(1, 32, "plus");
        }

        private void button271_Click(object sender, EventArgs e)
        {          
            Plus(1, 33, "plus");
        }

        private void button279_Click(object sender, EventArgs e)
        {           
            Plus(1, 34, "plus");
        }

        private void button287_Click(object sender, EventArgs e)
        {          
            Plus(1, 35, "plus");
        }

        private void button295_Click(object sender, EventArgs e)
        {           
            Plus(1, 36, "plus");
        }

        private void button303_Click(object sender, EventArgs e)
        {        
            Plus(1, 37, "plus");
        }

        private void button311_Click(object sender, EventArgs e)
        {
            Plus(1, 38, "plus");
        }

        private void button319_Click(object sender, EventArgs e)
        {
            Plus(1, 39, "plus");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Plus(1, 2, "minus");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Plus(1, 3, "minus");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Plus(1, 4, "minus");
        }

        private void button50_Click(object sender, EventArgs e)
        {
            Plus(1, 5, "minus");
        }

        private void button58_Click(object sender, EventArgs e)
        {
            Plus(1, 6, "minus");
        }

        private void button66_Click(object sender, EventArgs e)
        {
            Plus(1, 7, "minus");
        }

        private void button72_Click(object sender, EventArgs e)
        {
            Plus(1, 8, "minus");
        }

        private void button80_Click(object sender, EventArgs e)
        {
            Plus(1, 9, "minus");
        }

        private void button88_Click(object sender, EventArgs e)
        {
            Plus(1, 10, "minus");
        }

        private void button96_Click(object sender, EventArgs e)
        {
            Plus(1, 11, "minus");
        }

        private void button104_Click(object sender, EventArgs e)
        {
            Plus(1, 12, "minus");
        }

        private void button112_Click(object sender, EventArgs e)
        {
            Plus(1, 13, "minus");
        }

        private void button120_Click(object sender, EventArgs e)
        {
            Plus(1, 14, "minus");
        }

        private void button128_Click(object sender, EventArgs e)
        {
            Plus(1, 15, "minus");
        }

        private void button136_Click(object sender, EventArgs e)
        {
            Plus(1, 16, "minus");
        }

        private void button144_Click(object sender, EventArgs e)
        {
            Plus(1, 17, "minus");
        }

        private void button152_Click(object sender, EventArgs e)
        {
            Plus(1, 18, "minus");
        }

        private void button160_Click(object sender, EventArgs e)
        {
            Plus(1, 19, "minus");
        }

        private void button168_Click(object sender, EventArgs e)
        {
            Plus(1, 20, "minus");
        }

        private void button176_Click(object sender, EventArgs e)
        {
            Plus(1, 21, "minus");
        }

        private void button184_Click(object sender, EventArgs e)
        {
            Plus(1, 22, "minus");
        }

        private void button192_Click(object sender, EventArgs e)
        {
            Plus(1, 23, "minus");
        }

        private void button200_Click(object sender, EventArgs e)
        {
            Plus(1, 24, "minus");
        }

        private void button208_Click(object sender, EventArgs e)
        {
            Plus(1, 25, "minus");
        }

        private void button216_Click(object sender, EventArgs e)
        {
            Plus(1, 26, "minus");
        }

        private void button224_Click(object sender, EventArgs e)
        {
            Plus(1, 27, "minus");
        }

        private void button232_Click(object sender, EventArgs e)
        {
            Plus(1, 28, "minus");
        }

        private void button240_Click(object sender, EventArgs e)
        {
            Plus(1, 29, "minus");
        }

        private void button246_Click(object sender, EventArgs e)
        {
            Plus(1, 30, "minus");
        }

        private void button254_Click(object sender, EventArgs e)
        {
            Plus(1, 31, "minus");
        }

        private void button262_Click(object sender, EventArgs e)
        {
            Plus(1, 32, "minus");
        }

        private void button270_Click(object sender, EventArgs e)
        {
            Plus(1, 33, "minus");
        }

        private void button278_Click(object sender, EventArgs e)
        {
            Plus(1, 34, "minus");
        }

        private void button286_Click(object sender, EventArgs e)
        {
            Plus(1, 35, "minus");
        }

        private void button294_Click(object sender, EventArgs e)
        {
            Plus(1, 36, "minus");
        }

        private void button302_Click(object sender, EventArgs e)
        {
            Plus(1, 37, "minus");
        }

        private void button310_Click(object sender, EventArgs e)
        {
            Plus(1, 38, "minus");
        }

        private void button318_Click(object sender, EventArgs e)
        {
            Plus(1, 39, "minus");
        }

        private void button317_Click(object sender, EventArgs e)
        {
            Plus(2, 0, "plus");
        }

        private void button325_Click(object sender, EventArgs e)
        {
            Plus(2, 1, "plus");
        }

        private void button309_Click(object sender, EventArgs e)
        {
            Plus(2, 2, "plus");
        }

        private void button301_Click(object sender, EventArgs e)
        {
            Plus(2, 3, "plus");
        }

        private void button293_Click(object sender, EventArgs e)
        {
            Plus(2, 4, "plus");
        }

        private void button285_Click(object sender, EventArgs e)
        {
            Plus(2, 5, "plus");
        }
        private void button277_Click(object sender, EventArgs e)
        {
            Plus(2, 6, "plus");
        }
        private void button269_Click(object sender, EventArgs e)
        {
            Plus(2, 7, "plus");
        }

        private void button261_Click(object sender, EventArgs e)
        {
            Plus(2, 8, "plus");
        }

        private void button253_Click(object sender, EventArgs e)
        {
            Plus(2, 9, "plus");
        }

        private void button237_Click(object sender, EventArgs e)
        {
            Plus(2, 10, "plus");
        }

        private void button229_Click(object sender, EventArgs e)
        {
            Plus(2, 11, "plus");
        }

        private void button221_Click(object sender, EventArgs e)
        {
            Plus(2, 12, "plus");

        }

        private void button213_Click(object sender, EventArgs e)
        {
            Plus(2, 13, "plus");
        }

        private void button205_Click(object sender, EventArgs e)
        {
            Plus(2, 14, "plus");
        }

        private void button197_Click(object sender, EventArgs e)
        {
            Plus(2, 15, "plus");
        }

        private void button189_Click(object sender, EventArgs e)
        {
            Plus(2, 16, "plus");
        }

        private void button181_Click(object sender, EventArgs e)
        {
            Plus(2, 17, "plus");
        }

        private void button173_Click(object sender, EventArgs e)
        {
            Plus(2, 18, "plus");
        }

        private void button165_Click(object sender, EventArgs e)
        {
            Plus(2, 19, "plus");
        }

        private void button157_Click(object sender, EventArgs e)
        {
            Plus(2, 20, "plus");
        }

        private void button149_Click(object sender, EventArgs e)
        {
            Plus(2, 21, "plus");
        }

        private void button141_Click(object sender, EventArgs e)
        {
            Plus(2, 22, "plus");
        }

        private void button133_Click(object sender, EventArgs e)
        {
            Plus(2, 23, "plus");
        }

        private void button125_Click(object sender, EventArgs e)
        {
            Plus(2, 24, "plus");
        }

        private void button117_Click(object sender, EventArgs e)
        {
            Plus(2, 25, "plus");
        }

        private void button109_Click(object sender, EventArgs e)
        {
            Plus(2, 26, "plus");
        }

        private void button101_Click(object sender, EventArgs e)
        {
            Plus(2, 27, "plus");
        }

        private void button93_Click(object sender, EventArgs e)
        {
            Plus(2, 28, "plus");
        }

        private void button85_Click(object sender, EventArgs e)
        {
            Plus(2, 29, "plus");
        }

        private void button77_Click(object sender, EventArgs e)
        {
            Plus(2, 30, "plus");
        }

        private void button61_Click(object sender, EventArgs e)
        {
            Plus(2, 31, "plus");
        }

        private void button53_Click(object sender, EventArgs e)
        {
            Plus(2, 32, "plus");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Plus(2, 33, "plus");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Plus(2, 34, "plus");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Plus(2, 35, "plus");
        }
        private void button17_Click(object sender, EventArgs e)
        {
            Plus(2, 36, "plus");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Plus(2, 37, "plus");

        }
        private void button327_Click(object sender, EventArgs e)
        {
            Plus(2, 38, "plus");
        }

        private void button147_Click(object sender, EventArgs e)
        {
            Plus(2, 39, "plus");
        }

        private void button316_Click(object sender, EventArgs e)
        {
            Plus(2, 0, "minus");
        }

        private void button324_Click(object sender, EventArgs e)
        {
            Plus(2, 1, "minus");
        }

        private void button308_Click(object sender, EventArgs e)
        {
            Plus(2, 2, "minus");
        }

        private void button300_Click(object sender, EventArgs e)
        {
            Plus(2, 3, "minus");
        }

        private void button292_Click(object sender, EventArgs e)
        {
            Plus(2, 4, "minus");
        }

        private void button284_Click(object sender, EventArgs e)
        {
            Plus(2, 5, "minus");
        }

        private void button276_Click(object sender, EventArgs e)
        {
            Plus(2, 6, "minus");
        }

        private void button268_Click(object sender, EventArgs e)
        {
            Plus(2, 7, "minus");
        }

        private void button260_Click(object sender, EventArgs e)
        {
            Plus(2, 8, "minus");
        }

        private void button252_Click(object sender, EventArgs e)
        {
            Plus(2, 9, "minus");
        }

        private void button236_Click(object sender, EventArgs e)
        {
            Plus(2, 10, "minus");
        }

        private void button228_Click(object sender, EventArgs e)
        {
            Plus(2, 11, "minus");
        }

        private void button220_Click(object sender, EventArgs e)
        {
            Plus(2, 12, "minus");
        }

        private void button212_Click(object sender, EventArgs e)
        {
            Plus(2, 13, "minus");
        }

        private void button204_Click(object sender, EventArgs e)
        {
            Plus(2, 14, "minus");
        }

        private void button196_Click(object sender, EventArgs e)
        {
            Plus(2, 15, "minus");
        }

        private void button188_Click(object sender, EventArgs e)
        {
            Plus(2, 16, "minus");
        }

        private void button180_Click(object sender, EventArgs e)
        {
            Plus(2, 17, "minus");
        }

        private void button172_Click(object sender, EventArgs e)
        {
            Plus(2, 18, "minus");
        }

        private void button164_Click(object sender, EventArgs e)
        {
            Plus(2, 19, "minus");
        }

        private void button156_Click(object sender, EventArgs e)
        {
            Plus(2, 20, "minus");
        }

        private void button148_Click(object sender, EventArgs e)
        {
            Plus(2,21, "minus");
        }

        private void button140_Click(object sender, EventArgs e)
        {
            Plus(2, 22, "minus");
        }

        private void button132_Click(object sender, EventArgs e)
        {
            Plus(2, 23, "minus");
        }

        private void button124_Click(object sender, EventArgs e)
        {
            Plus(2, 24, "minus");

        }

        private void button116_Click(object sender, EventArgs e)
        {
            Plus(2,25, "minus");
        }

        private void button108_Click(object sender, EventArgs e)
        {
            Plus(2, 26, "minus");
        }

        private void button100_Click(object sender, EventArgs e)
        {
            Plus(2, 27, "minus");
        }

        private void button92_Click(object sender, EventArgs e)
        {
            Plus(2, 28, "minus");
        }

        private void button84_Click(object sender, EventArgs e)
        {
            Plus(2, 29, "minus");
        }

        private void button76_Click(object sender, EventArgs e)
        {
            Plus(2, 30, "minus");
        }

        private void button60_Click(object sender, EventArgs e)
        {
            Plus(2, 31, "minus");
        }

        private void button52_Click(object sender, EventArgs e)
        {
            Plus(2, 32, "minus");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Plus(2, 33, "minus");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Plus(2, 34, "minus");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Plus(2, 35, "minus");
        }
        private void button18_Click(object sender, EventArgs e)
        {
            Plus(2, 36, "minus");
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            Plus(2, 37, "minus");
        }
        private void button326_Click(object sender, EventArgs e)
        {
            Plus(2, 38, "minus");
        }

        private void button146_Click(object sender, EventArgs e)
        {
            Plus(2, 39, "minus");
        }

        private void button321_Click(object sender, EventArgs e)
        {
            Plus(3, 0, "plus");
        }

        private void button329_Click(object sender, EventArgs e)
        {
            Plus(3, 1, "plus");
        }

        private void button313_Click(object sender, EventArgs e)
        {
            Plus(3, 2, "plus");
        }

        private void button305_Click(object sender, EventArgs e)
        {
            Plus(3, 3, "plus");
        }

        private void button297_Click(object sender, EventArgs e)
        {
            Plus(3, 4, "plus");
        }

        private void button289_Click(object sender, EventArgs e)
        {
            Plus(3, 5, "plus");
        }

        private void button281_Click(object sender, EventArgs e)
        {
            Plus(3, 6, "plus");
        }

        private void button273_Click(object sender, EventArgs e)
        {
            Plus(3,7, "plus");
        }

        private void button265_Click(object sender, EventArgs e)
        {
            Plus(3, 8, "plus");
        }

        private void button257_Click(object sender, EventArgs e)
        {
            Plus(3, 9, "plus");
        }

        private void button249_Click(object sender, EventArgs e)
        {
            Plus(3, 10, "plus");
        }

        private void button243_Click(object sender, EventArgs e)
        {
            Plus(3, 11, "plus");
        }

        private void button235_Click(object sender, EventArgs e)
        {
            Plus(3, 12, "plus");
        }

        private void button227_Click(object sender, EventArgs e)
        {
            Plus(3, 13, "plus");
        }

        private void button219_Click(object sender, EventArgs e)
        {
            Plus(3, 14, "plus");
        }

        private void button211_Click(object sender, EventArgs e)
        {
            Plus(3, 15, "plus");
        }

        private void button203_Click(object sender, EventArgs e)
        {
            Plus(3, 16, "plus");
        }

        private void button195_Click(object sender, EventArgs e)
        {
            Plus(3, 17, "plus");
        }

        private void button187_Click(object sender, EventArgs e)
        {
            Plus(3, 18, "plus");
        }

        private void button179_Click(object sender, EventArgs e)
        {
            Plus(3, 19, "plus");
        }

        private void button171_Click(object sender, EventArgs e)
        {
            Plus(3, 20, "plus");
        }

        private void button163_Click(object sender, EventArgs e)
        {
            Plus(3, 21, "plus");
        }

        private void button155_Click(object sender, EventArgs e)
        {
            Plus(3, 22, "plus");
        }

        private void button139_Click(object sender, EventArgs e)
        {
            Plus(3, 23, "plus");
        }

        private void button131_Click(object sender, EventArgs e)
        {
            Plus(3, 24, "plus");
        }

        private void button123_Click(object sender, EventArgs e)
        {
            Plus(3, 25, "plus");
        }

        private void button115_Click(object sender, EventArgs e)
        {
            Plus(3, 26, "plus");
        }

        private void button107_Click(object sender, EventArgs e)
        {
            Plus(3, 27, "plus");
        }

        private void button99_Click(object sender, EventArgs e)
        {
            Plus(3, 28, "plus");
        }

        private void button91_Click(object sender, EventArgs e)
        {
            Plus(3, 29, "plus");
        }

        private void button83_Click(object sender, EventArgs e)
        {
            Plus(3, 30, "plus");
        }

        private void button75_Click(object sender, EventArgs e)
        {
            Plus(3, 31, "plus");
        }

        private void button69_Click(object sender, EventArgs e)
        {
            Plus(3, 32, "plus");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Plus(3, 33, "plus");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Plus(3, 34, "plus");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Plus(3, 35, "plus");
        }
        private void button15_Click(object sender, EventArgs e)
        {
            Plus(3, 36, "plus");
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            Plus(3, 37, "plus");
        }

        private void button55_Click(object sender, EventArgs e)
        {
            Plus(3, 38, "plus");
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            Plus(3, 39, "plus");
        }

        private void button320_Click(object sender, EventArgs e)
        {
            Plus(3, 0, "minus");
        }

        private void button328_Click(object sender, EventArgs e)
        {
            Plus(3, 1, "minus");
        }

        private void button312_Click(object sender, EventArgs e)
        {
            Plus(3, 2, "minus");
        }

        private void button304_Click(object sender, EventArgs e)
        {
            Plus(3, 3, "minus");
        }

        private void button296_Click(object sender, EventArgs e)
        {
            Plus(3, 4, "minus");
        }

        private void button288_Click(object sender, EventArgs e)
        {
            Plus(3, 5, "minus");
        }

        private void button280_Click(object sender, EventArgs e)
        {
            Plus(3, 6, "minus");
        }

        private void button272_Click(object sender, EventArgs e)
        {
            Plus(3, 7, "minus");
        }

        private void button264_Click(object sender, EventArgs e)
        {
            Plus(3, 8, "minus");
        }

        private void button256_Click(object sender, EventArgs e)
        {
            Plus(3, 9, "minus");
        }

        private void button248_Click(object sender, EventArgs e)
        {
            Plus(3, 10, "minus");
        }

        private void button242_Click(object sender, EventArgs e)
        {
            Plus(3,11, "minus");
        }

        private void button234_Click(object sender, EventArgs e)
        {
            Plus(3, 12, "minus");
        }

        private void button226_Click(object sender, EventArgs e)
        {
            Plus(3, 13, "minus");
        }

        private void button218_Click(object sender, EventArgs e)
        {
            Plus(3, 14, "minus");
        }

        private void button210_Click(object sender, EventArgs e)
        {
            Plus(3, 15, "minus");
        }

        private void button202_Click(object sender, EventArgs e)
        {
            Plus(3, 16, "minus");
        }

        private void button194_Click(object sender, EventArgs e)
        {
            Plus(3, 17, "minus");
        }

        private void button186_Click(object sender, EventArgs e)
        {
            Plus(3, 18, "minus");
        }

        private void button178_Click(object sender, EventArgs e)
        {
            Plus(3, 19, "minus");
        }

        private void button170_Click(object sender, EventArgs e)
        {
            Plus(3, 20, "minus");
        }

        private void button162_Click(object sender, EventArgs e)
        {
            Plus(3,21, "minus");
        }

        private void button154_Click(object sender, EventArgs e)
        {
            Plus(3, 22, "minus");
        }

        private void button138_Click(object sender, EventArgs e)
        {
            Plus(3, 23, "minus");
        }

        private void button130_Click(object sender, EventArgs e)
        {
            Plus(3, 24, "minus");
        }

        private void button122_Click(object sender, EventArgs e)
        {
            Plus(3, 25, "minus");
        }

        private void button114_Click(object sender, EventArgs e)
        {
            Plus(3, 26, "minus");
        }

        private void button106_Click(object sender, EventArgs e)
        {
            Plus(3, 27, "minus");
        }

        private void button98_Click(object sender, EventArgs e)
        {
            Plus(3, 28, "minus");
        }

        private void button90_Click(object sender, EventArgs e)
        {
            Plus(3, 29, "minus");
        }

        private void button82_Click(object sender, EventArgs e)
        {
            Plus(3,30, "minus");
        }

        private void button74_Click(object sender, EventArgs e)
        {
            Plus(3, 31, "minus");
        }

        private void button68_Click(object sender, EventArgs e)
        {
            Plus(3, 32, "minus");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Plus(3, 33, "minus");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Plus(3, 34, "minus");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Plus(3, 35, "minus");
        }
        private void button16_Click(object sender, EventArgs e)
        {
            Plus(3, 36, "minus");
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            Plus(3, 37, "minus");
        }

        private void button54_Click(object sender, EventArgs e)
        {
            Plus(3, 38, "minus");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Plus(3, 39, "minus");
        }

        private void button323_Click(object sender, EventArgs e)
        {
            Plus(4, 0, "plus");
        }

        private void button315_Click(object sender, EventArgs e)
        {
            Plus(4, 1, "plus");
        }

        private void button307_Click(object sender, EventArgs e)
        {
            Plus(4, 2, "plus");
        }

        private void button299_Click(object sender, EventArgs e)
        {
            Plus(4, 3, "plus");
        }

        private void button291_Click(object sender, EventArgs e)
        {
            Plus(4, 4, "plus");
        }

        private void button283_Click(object sender, EventArgs e)
        {
            Plus(4, 5, "plus");
        }

        private void button275_Click(object sender, EventArgs e)
        {
            Plus(4, 6, "plus");
        }

        private void button267_Click(object sender, EventArgs e)
        {
            Plus(4, 7, "plus");
        }

        private void button259_Click(object sender, EventArgs e)
        {
            Plus(4, 8, "plus");
        }

        private void button251_Click(object sender, EventArgs e)
        {
            Plus(4, 9, "plus");
        }

        private void button245_Click(object sender, EventArgs e)
        {
            Plus(4, 10, "plus");
        }

        private void button239_Click(object sender, EventArgs e)
        {
            Plus(4, 11, "plus");
        }

        private void button231_Click(object sender, EventArgs e)
        {
            Plus(4, 12, "plus");
        }

        private void button223_Click(object sender, EventArgs e)
        {
            Plus(4, 13, "plus");
        }

        private void button215_Click(object sender, EventArgs e)
        {
            Plus(4, 14, "plus");
        }

        private void button207_Click(object sender, EventArgs e)
        {
            Plus(4,15, "plus");
        }

        private void button199_Click(object sender, EventArgs e)
        {
            Plus(4, 16, "plus");
        }

        private void button191_Click(object sender, EventArgs e)
        {
            Plus(4, 17, "plus");
        }

        private void button183_Click(object sender, EventArgs e)
        {
            Plus(4, 18, "plus");
        }

        private void button175_Click(object sender, EventArgs e)
        {
            Plus(4, 19, "plus");
        }

        private void button167_Click(object sender, EventArgs e)
        {
            Plus(4, 20, "plus");
        }

        private void button159_Click(object sender, EventArgs e)
        {
            Plus(4, 21, "plus");
        }

        private void button151_Click(object sender, EventArgs e)
        {
            Plus(4, 22, "plus");
        }

        private void button143_Click(object sender, EventArgs e)
        {
            Plus(4, 23, "plus");
        }

        private void button135_Click(object sender, EventArgs e)
        {
            Plus(4, 24, "plus");
        }

        private void button127_Click(object sender, EventArgs e)
        {
            Plus(4, 25, "plus");
        }

        private void button119_Click(object sender, EventArgs e)
        {
            Plus(4, 26, "plus");
        }

        private void button111_Click(object sender, EventArgs e)
        {
            Plus(4, 27, "plus");
        }

        private void button103_Click(object sender, EventArgs e)
        {
            Plus(4, 28, "plus");
        }

        private void button95_Click(object sender, EventArgs e)
        {
            Plus(4, 29, "plus");
        }

        private void button87_Click(object sender, EventArgs e)
        {
            Plus(4, 30, "plus");
        }

        private void button79_Click(object sender, EventArgs e)
        {
            Plus(4, 31, "plus");
        }

        private void button71_Click(object sender, EventArgs e)
        {
            Plus(4, 32, "plus");
        }

        private void button65_Click(object sender, EventArgs e)
        {
            Plus(4, 33, "plus");
        }

        private void button57_Click(object sender, EventArgs e)
        {
            Plus(4, 34, "plus");
        }

        private void button49_Click(object sender, EventArgs e)
        {
            Plus(4, 35, "plus");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Plus(4, 36, "plus");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Plus(4, 37, "plus");
        }
        private void button13_Click(object sender, EventArgs e)
        {
            Plus(4, 38, "plus");

        }

        private void button63_Click(object sender, EventArgs e)
        {
            Plus(4, 39, "plus");
        }

        private void button322_Click(object sender, EventArgs e)
        {
            Plus(4, 0, "minus");
        }

        private void button314_Click(object sender, EventArgs e)
        {
            Plus(4, 1, "minus");
        }

        private void button306_Click(object sender, EventArgs e)
        {
            Plus(4, 2, "minus");
        }

        private void button298_Click(object sender, EventArgs e)
        {
            Plus(4, 3, "minus");
        }

        private void button290_Click(object sender, EventArgs e)
        {
            Plus(4, 4, "minus");
        }

        private void button282_Click(object sender, EventArgs e)
        {
            Plus(4, 5, "minus");
        }

        private void button274_Click(object sender, EventArgs e)
        {
            Plus(4, 6, "minus");
        }

        private void button266_Click(object sender, EventArgs e)
        {
            Plus(4, 7, "minus");
        }

        private void button258_Click(object sender, EventArgs e)
        {
            Plus(4, 8, "minus");
        }

        private void button250_Click(object sender, EventArgs e)
        {
            Plus(4, 9, "minus");
        }

        private void button244_Click(object sender, EventArgs e)
        {
            Plus(4, 10, "minus");
        }

        private void button238_Click(object sender, EventArgs e)
        {
            Plus(4, 11, "minus");
        }

        private void button230_Click(object sender, EventArgs e)
        {
            Plus(4, 12, "minus");
        }

        private void button222_Click(object sender, EventArgs e)
        {
            Plus(4, 13, "minus");
        }

        private void button214_Click(object sender, EventArgs e)
        {
            Plus(4, 14, "minus");
        }

        private void button206_Click(object sender, EventArgs e)
        {
            Plus(4, 15, "minus");
        }

        private void button198_Click(object sender, EventArgs e)
        {
            Plus(4, 16, "minus");
        }

        private void button190_Click(object sender, EventArgs e)
        {
            Plus(4, 17, "minus");
        }

        private void button182_Click(object sender, EventArgs e)
        {
            Plus(4, 18, "minus");
        }

        private void button174_Click(object sender, EventArgs e)
        {
            Plus(4, 19, "minus");
        }

        private void button166_Click(object sender, EventArgs e)
        {
            Plus(4, 20, "minus");
        }

        private void button158_Click(object sender, EventArgs e)
        {
            Plus(4, 21, "minus");
        }

        private void button150_Click(object sender, EventArgs e)
        {
            Plus(4, 22, "minus");
        }

        private void button142_Click(object sender, EventArgs e)
        {
            Plus(4, 23, "minus");
        }

        private void button134_Click(object sender, EventArgs e)
        {
            Plus(4, 24, "minus");
        }

        private void button126_Click(object sender, EventArgs e)
        {
            Plus(4, 25, "minus");
        }

        private void button118_Click(object sender, EventArgs e)
        {
            Plus(4, 26, "minus");
        }

        private void button110_Click(object sender, EventArgs e)
        {
            Plus(4, 27, "minus");
        }

        private void button102_Click(object sender, EventArgs e)
        {
            Plus(4, 28, "minus");
        }

        private void button94_Click(object sender, EventArgs e)
        {
            Plus(4, 29, "minus");
        }

        private void button86_Click(object sender, EventArgs e)
        {
            Plus(4, 30, "minus");
        }

        private void button78_Click(object sender, EventArgs e)
        {
            Plus(4, 31, "minus");
        }

        private void button70_Click(object sender, EventArgs e)
        {
            Plus(4, 32, "minus");
        }

        private void button64_Click(object sender, EventArgs e)
        {
            Plus(4, 33, "minus");
        }
        private void button56_Click(object sender, EventArgs e)
        {
            Plus(4, 34, "minus");

        }
        private void button48_Click(object sender, EventArgs e)
        {
            Plus(4, 35, "minus");
        }
        private void button40_Click(object sender, EventArgs e)
        {
            Plus(4, 36, "minus");
        }
       
        private void button32_Click(object sender, EventArgs e)
        {
            Plus(4, 37, "minus");
        }
        private void button14_Click(object sender, EventArgs e)
        {
            Plus(4, 38, "minus");
        }
        private void button62_Click(object sender, EventArgs e)
        {
            Plus(4, 39, "minus");
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if(textBox2.Text=="Customer Name")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Customer Name";
                textBox2.ForeColor = Color.LightGray;
            }
        }

        private void button330_Click(object sender, EventArgs e)
        {
            button330.Visible = false;
            label4.Visible = false;
            timer1.Enabled = false;
            textBox2.Text = String.Empty;
            ADDorder.Clear();
            it.Clear();
            DATA.Clear();
            for (int te = 0; te <= 39; te++)
            {
                it.Insert(te, 0);
                DATA.Insert(te, "");
                ADDorder.Insert(te, "");


            }
        }
        
        public string value="not";
        public string chef;
        public string waiter;
        private void timer2_Tick(object sender, EventArgs e)
        { 
           
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerOrders"].ConnectionString);
            
            string sql = "SELECT * FROM CustomerOrders Where TableNo='" + label8.Text + "' AND OrderTime ='" + grab + "'";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                value=reader["CustomerRecieved"].ToString();
                chef= reader["ChefOrderDoneTime"].ToString();
               


            }
            connection.Close();

            if (timer1.Enabled == true)
            {
                label4.Text = "Processing";
            }
            else if(chef!=null)
            {
                label4.Text = "Processing------Preparing";
            }
            else if (value == "Ready")
            {
                label4.Text = "Processing------Preparing------Ready";
            }

            if (value=="Ready")
            {
               
                button330.Visible = true;

            }
            else
            {
                button330.Visible = false;
            }

            if (button330.BackColor == Color.Red)
            {
                button330.BackColor = Color.PaleGreen;

            }
            else if (button330.BackColor == Color.PaleGreen)
            {
                button330.BackColor = Color.Red;

            }
        }

    }
}
