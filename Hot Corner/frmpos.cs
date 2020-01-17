using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hot_Corner
{
    public partial class frmpos : Form
    {
        Connection cs = new Connection();//referencing connection class
        public frmpos()
        {
            InitializeComponent();

        }
    
    


        private void btnmain_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                panel1.Controls.Clear();
                MySqlConnection myconn1 = new MySqlConnection(cs.myconnection1);
                myconn1.Open();
                string query = "SELECT food_name FROM food WHERE category_id=(SELECT category_id FROM food_category WHERE category_name='MAIN DISHES') ORDER BY category_id ASC";
                MySqlCommand mycommand1 = new MySqlCommand(query, myconn1);
                MySqlDataReader myReader;
                List<string> names = new List<string>();
                myReader = mycommand1.ExecuteReader();
                while (myReader.Read())
                {
                   names.Add( myReader.GetString("food_name"));
                }
                           

           /***/
                int xPos =60;
                int yPos =20;
                // Declare and assign number of buttons =  
                System.Windows.Forms.Button[] btnArray = new System.Windows.Forms.Button[names.Count];
                // Create  Buttons: 
                for (int i = 0; i < names.Count; i++)
                {
                    // Initialize one variable 
                    btnArray[i] = new System.Windows.Forms.Button();
                }
                int n = 0;

                while (n < names.Count)
                {
                   btnArray[n].Tag = n + 1; // Tag of button 
                    btnArray[n].Width = 170; // Width of button 
                    btnArray[n].Height = 100; // Height of button 
                    if (n ==4) // Location of second line of buttons: 
                    {
                        xPos =60;
                        yPos = 120;
                    }
                    if (n == 8) // Location of 3rd line of buttons: 
                    {
                        xPos = 60;
                        yPos = 220;
                    }
                    if (n == 12) // Location of 4th line of buttons: 
                    {
                        xPos = 60;
                        yPos = 320;
                    }
                    if (n == 16) // Location of 5th  line of buttons: 
                    {
                        xPos =60;
                        yPos = 420;
                    }
                    if (n == 20) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 520;
                    }
                    if (n == 24) // Location of second line of buttons: 
                    {
                        xPos =60;
                        yPos = 620;
                    }
                    if (n == 28) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 720;
                    }
                    if (n == 32) // Location of second line of buttons: 
                    {
                        xPos =60;
                        yPos = 820;
                    }
                    if (n == 36) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 920;
                    }
                    if (n == 40) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 1020;
                    }
                    if (n == 44) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 1120;
                    }
                    if (n == 48) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 1220;
                    }
                    if (n == 52) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 1320;
                    }

                    // Location of button: 
                    btnArray[n].Left = xPos;
                    btnArray[n].Top = yPos;
                    // Add buttons to a Panel: 
                    panel1.Controls.Add(btnArray[n]); // Let panel hold the Buttons 
                    xPos = xPos + btnArray[n].Width; // Left of next button 
                    // Write English Character: 
                    btnArray[n].Text = names[n].ToString();


                    btnArray[n].Click += new System.EventHandler(Clickpanelbutton);
                    n++;
                }
           
                /*****/
           
            }

            catch (Exception ex)
            {
                MessageBox.Show("DATABASE ERROR TRY AGAIN");
            }

        }
        private void Clickpanelbutton(object sender, EventArgs e)
        {

            if (sender is Button)
            {
                Button btn = (Button)sender;                
               
                try
                {
                    
                        string input = "1";
                        MySqlConnection con = new MySqlConnection(cs.myconnection1);

                        string Query2 = "select food_name,food_cost from  food where food_name='" + btn.Text.ToString() + "'";
                        con.Open();
                        MySqlCommand mycommand1 = new MySqlCommand(Query2, con);
                        MySqlDataAdapter myadapter = new MySqlDataAdapter();//for offline connection we use mysqldataadapter
                        myadapter.SelectCommand = mycommand1;
                        DataSet ds2 = new DataSet();
                        myadapter.Fill(ds2);
                        int s = (myadapter.Fill(ds2));

                        if (s < 1)
                        {

                            MessageBox.Show("No such product", "No such product in Database", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            return;

                        }
                        if (ListView1.Items.Count == 0)
                        {

                            ListViewItem item = new ListViewItem();
                            item.SubItems.Add(input);
                            item.SubItems.Add(ds2.Tables[0].Rows[0][0].ToString());
                            item.SubItems.Add(ds2.Tables[0].Rows[0][1].ToString());

                            ListView1.Items.Add(item);

                           lbltotal.Text = subtot().ToString();



                            return;
                        }
                        /*******************another*************************/
                        for (int j = 0; j <= ListView1.Items.Count - 1; j++)
                        {
                            if (ListView1.Items[j].SubItems[2].Text == ds2.Tables[0].Rows[0][0].ToString())
                            {
                                ListView1.Items[j].SubItems[1].Text = (Convert.ToInt32(ListView1.Items[j].SubItems[1].Text) + Convert.ToInt32(input)).ToString();
                                ListView1.Items[j].SubItems[2].Text = ds2.Tables[0].Rows[0][0].ToString();
                                double x = Convert.ToDouble(ListView1.Items[j].SubItems[3].Text) + Convert.ToDouble(ds2.Tables[0].Rows[0][1].ToString());
                                ListView1.Items[j].SubItems[3].Text = x.ToString();

                               lbltotal.Text = subtot().ToString();



                                return;

                            }
                        }
                        /*******************another********************************/
                        ListViewItem lst1 = new ListViewItem();
                        lst1.SubItems.Add(input);
                        lst1.SubItems.Add(ds2.Tables[0].Rows[0][0].ToString());
                        lst1.SubItems.Add(ds2.Tables[0].Rows[0][1].ToString());
                        ListView1.Items.Add(lst1);
                      lbltotal.Text = subtot().ToString();


                        
                        return;
                        con.Close();
                       
                }
                catch (Exception ec)
                {
                    MessageBox.Show("Error" + ec);
                }
              
                
            }
        }


        public double subtot()
        {
            int i = 0;
            int j = 0;
            int k = 0;
            i = 0;
            j = 0;
            k = 0;


            try
            {

                j = ListView1.Items.Count;
                for (i = 0; i <= j - 1; i++)
                {
                    k = k + Convert.ToInt32(ListView1.Items[i].SubItems[3].Text);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return k;

        }

     

       

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {

            try
            {
                panel1.Controls.Clear();
                MySqlConnection myconn1 = new MySqlConnection(cs.myconnection1);
                myconn1.Open();
                string query = "SELECT food_name FROM food WHERE category_id=(SELECT category_id FROM food_category WHERE category_name='LIGHT DISHES SNACKS') ORDER BY category_id ASC";
                MySqlCommand mycommand1 = new MySqlCommand(query, myconn1);
                MySqlDataReader myReader;
                List<string> names = new List<string>();
                myReader = mycommand1.ExecuteReader();
                while (myReader.Read())
                {
                    names.Add(myReader.GetString("food_name"));
                }


                /***/
                int xPos = 60;
                int yPos = 20;
                // Declare and assign number of buttons =  
                System.Windows.Forms.Button[] btnArray = new System.Windows.Forms.Button[names.Count];
                // Create  Buttons: 
                for (int i = 0; i < names.Count; i++)
                {
                    // Initialize one variable 
                    btnArray[i] = new System.Windows.Forms.Button();
                }
                int n = 0;

                while (n < names.Count)
                {
                     btnArray[n].Tag = n + 1; // Tag of button 
                    btnArray[n].Width = 170; // Width of button 
                    btnArray[n].Height = 100; // Height of button 
                    if (n == 4) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 120;
                    }
                    if (n == 8) // Location of 3rd line of buttons: 
                    {
                        xPos = 60;
                        yPos = 220;
                    }
                    if (n == 12) // Location of 4th line of buttons: 
                    {
                        xPos = 60;
                        yPos = 320;
                    }
                    if (n == 16) // Location of 5th  line of buttons: 
                    {
                        xPos = 60;
                        yPos = 420;
                    }
                    if (n == 20) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 520;
                    }
                    if (n == 24) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 620;
                    }
                    if (n == 28) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 720;
                    }
                    if (n == 32) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 820;
                    }
                    if (n == 36) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 920;
                    }
                    if (n == 40) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 1020;
                    }
                    if (n == 44) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 1120;
                    }
                    if (n == 48) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 1220;
                    }
                    if (n == 52) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 1320;
                    }

                    // Location of button: 
                    btnArray[n].Left = xPos;
                    btnArray[n].Top = yPos;
                    // Add buttons to a Panel: 
                    panel1.Controls.Add(btnArray[n]); // Let panel hold the Buttons 
                    xPos = xPos + btnArray[n].Width; // Left of next button 
                    // Write English Character: 
                    btnArray[n].Text = names[n].ToString();


                    btnArray[n].Click += new System.EventHandler(Clickpanelbutton);
                    n++;
                }

                /*****/

            }

            catch (Exception ex)
            {
                MessageBox.Show("DATABASE ERROR TRY AGAIN");
            }
        }

        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                panel1.Controls.Clear();
                MySqlConnection myconn1 = new MySqlConnection(cs.myconnection1);
                myconn1.Open();
                string query = "SELECT food_name FROM food WHERE category_id=(SELECT category_id FROM food_category WHERE category_name='BEVERAGES') ORDER BY category_id ASC";
                MySqlCommand mycommand1 = new MySqlCommand(query, myconn1);
                MySqlDataReader myReader;
                List<string> names = new List<string>();
                myReader = mycommand1.ExecuteReader();
                while (myReader.Read())
                {
                    names.Add(myReader.GetString("food_name"));
                }


                /***/
                int xPos = 60;
                int yPos = 20;
                // Declare and assign number of buttons =  
                System.Windows.Forms.Button[] btnArray = new System.Windows.Forms.Button[names.Count];
                // Create  Buttons: 
                for (int i = 0; i < names.Count; i++)
                {
                    // Initialize one variable 
                    btnArray[i] = new System.Windows.Forms.Button();
                }
                int n = 0;

                while (n < names.Count)
                {
                    btnArray[n].Tag = n + 1; // Tag of button 
                    btnArray[n].Width = 170; // Width of button 
                    btnArray[n].Height = 100; // Height of button 
                    if (n == 4) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 120;
                    }
                    if (n == 8) // Location of 3rd line of buttons: 
                    {
                        xPos = 60;
                        yPos = 220;
                    }
                    if (n == 12) // Location of 4th line of buttons: 
                    {
                        xPos = 60;
                        yPos = 320;
                    }
                    if (n == 16) // Location of 5th  line of buttons: 
                    {
                        xPos = 60;
                        yPos = 420;
                    }
                    if (n == 20) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 520;
                    }
                    if (n == 24) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 620;
                    }
                    if (n == 28) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 720;
                    }
                    if (n == 32) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 820;
                    }
                    if (n == 36) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 920;
                    }
                    if (n == 40) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 1020;
                    }
                    if (n == 44) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 1120;
                    }
                    if (n == 48) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 1220;
                    }
                    if (n == 52) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 1320;
                    }

                    // Location of button: 
                    btnArray[n].Left = xPos;
                    btnArray[n].Top = yPos;
                    // Add buttons to a Panel: 
                    panel1.Controls.Add(btnArray[n]); // Let panel hold the Buttons 
                    xPos = xPos + btnArray[n].Width; // Left of next button 
                    // Write English Character: 
                    btnArray[n].Text = names[n].ToString();


               btnArray[n].Click += new System.EventHandler(Clickpanelbutton);
                    n++;
                }

                /*****/

            }

            catch (Exception ex)
            {
                MessageBox.Show("DATABASE ERROR TRY AGAIN");
            }
        }

        private void button9_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                panel1.Controls.Clear();
                MySqlConnection myconn1 = new MySqlConnection(cs.myconnection1);
                myconn1.Open();
                string query = "SELECT food_name FROM food WHERE category_id=(SELECT category_id FROM food_category WHERE category_name='WATER') ORDER BY category_id ASC";
                MySqlCommand mycommand1 = new MySqlCommand(query, myconn1);
                MySqlDataReader myReader;
                List<string> names = new List<string>();
                myReader = mycommand1.ExecuteReader();
                while (myReader.Read())
                {
                    names.Add(myReader.GetString("food_name"));
                }


                /***/
                int xPos = 60;
                int yPos = 20;
                // Declare and assign number of buttons =  
                System.Windows.Forms.Button[] btnArray = new System.Windows.Forms.Button[names.Count];
                // Create  Buttons: 
                for (int i = 0; i < names.Count; i++)
                {
                    // Initialize one variable 
                    btnArray[i] = new System.Windows.Forms.Button();
                }
                int n = 0;

                while (n < names.Count)
                {
                    btnArray[n].Tag = n + 1; // Tag of button 
                    btnArray[n].Width = 170; // Width of button 
                    btnArray[n].Height = 100; // Height of button 
                    if (n == 4) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 120;
                    }
                    if (n == 8) // Location of 3rd line of buttons: 
                    {
                        xPos = 60;
                        yPos = 220;
                    }
                    if (n == 12) // Location of 4th line of buttons: 
                    {
                        xPos = 60;
                        yPos = 320;
                    }
                    if (n == 16) // Location of 5th  line of buttons: 
                    {
                        xPos = 60;
                        yPos = 420;
                    }
                    if (n == 20) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 520;
                    }
                    if (n == 24) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 620;
                    }
                    if (n == 28) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 720;
                    }
                    if (n == 32) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 820;
                    }
                    if (n == 36) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 920;
                    }
                    if (n == 40) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 1020;
                    }
                    if (n == 44) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 1120;
                    }
                    if (n == 48) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 1220;
                    }
                    if (n == 52) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 1320;
                    }

                    // Location of button: 
                    btnArray[n].Left = xPos;
                    btnArray[n].Top = yPos;
                    // Add buttons to a Panel: 
                    panel1.Controls.Add(btnArray[n]); // Let panel hold the Buttons 
                    xPos = xPos + btnArray[n].Width; // Left of next button 
                    // Write English Character: 
                    btnArray[n].Text = names[n].ToString();


                   btnArray[n].Click += new System.EventHandler(Clickpanelbutton);
                    n++;
                }

                /*****/

            }

            catch (Exception ex)
            {
                MessageBox.Show("DATABASE ERROR TRY AGAIN");
            }
        }

        private void button13_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                panel1.Controls.Clear();
                MySqlConnection myconn1 = new MySqlConnection(cs.myconnection1);
                myconn1.Open();
                string query = "SELECT food_name FROM food WHERE category_id=(SELECT category_id FROM food_category WHERE category_name='HOTCORNER SPECIALS') ORDER BY category_id ASC";
                MySqlCommand mycommand1 = new MySqlCommand(query, myconn1);
                MySqlDataReader myReader;
                List<string> names = new List<string>();
                myReader = mycommand1.ExecuteReader();
                while (myReader.Read())
                {
                    names.Add(myReader.GetString("food_name"));
                }


                /***/
                int xPos = 60;
                int yPos = 20;
                // Declare and assign number of buttons =  
                System.Windows.Forms.Button[] btnArray = new System.Windows.Forms.Button[names.Count];
                // Create  Buttons: 
                for (int i = 0; i < names.Count; i++)
                {
                    // Initialize one variable 
                    btnArray[i] = new System.Windows.Forms.Button();
                }
                int n = 0;

                while (n < names.Count)
                {
                     btnArray[n].Tag = n + 1; // Tag of button 
                    btnArray[n].Width = 170; // Width of button 
                    btnArray[n].Height = 100; // Height of button 
                    if (n == 4) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 120;
                    }
                    if (n == 8) // Location of 3rd line of buttons: 
                    {
                        xPos = 60;
                        yPos = 220;
                    }
                    if (n == 12) // Location of 4th line of buttons: 
                    {
                        xPos = 60;
                        yPos = 320;
                    }
                    if (n == 16) // Location of 5th  line of buttons: 
                    {
                        xPos = 60;
                        yPos = 420;
                    }
                    if (n == 20) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 520;
                    }
                    if (n == 24) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 620;
                    }
                    if (n == 28) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 720;
                    }
                    if (n == 32) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 820;
                    }
                    if (n == 36) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 920;
                    }
                    if (n == 40) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 1020;
                    }
                    if (n == 44) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 1120;
                    }
                    if (n == 48) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 1220;
                    }
                    if (n == 52) // Location of second line of buttons: 
                    {
                        xPos = 60;
                        yPos = 1320;
                    }

                    // Location of button: 
                    btnArray[n].Left = xPos;
                    btnArray[n].Top = yPos;
                    // Add buttons to a Panel: 
                    panel1.Controls.Add(btnArray[n]); // Let panel hold the Buttons 
                    xPos = xPos + btnArray[n].Width; // Left of next button 
                    // Write English Character: 
                    btnArray[n].Text = names[n].ToString();


                btnArray[n].Click += new System.EventHandler(Clickpanelbutton);
                    n++;
                }

                /*****/

            }

            catch (Exception ex)
            {
                MessageBox.Show("DATABASE ERROR TRY AGAIN");
            }
        }
       

       
        private void clr()
        {
            try
            {
                //reset the sale page
                panel1.Controls.Clear();
                ListView1.Items.Clear();
                ListView1.Update(); // In case there is databinding
                ListView1.Refresh(); // Redraw items
                btnorder.Text = "";
                lbltotal.Text = subtot().ToString();
            }
            catch
            {

            }
        }

        //below function return order
        private int  order()
        {
            MySqlConnection conn = new MySqlConnection(cs.myconnection1);
            conn.Open();
            string query = "select   max(order_id) from   food_order ";
            MySqlCommand mycommand1 = new MySqlCommand(query, conn);

            string x = mycommand1.ExecuteScalar().ToString();//execution command
            int y = Convert.ToInt32(x)+1;
            btnorder.Text = Convert.ToString(y);
            return y;
        }
       
        private int getorder()
        {
            MySqlConnection conn = new MySqlConnection(cs.myconnection1);
            conn.Open();
            string query = "select   max(order_id) from   food_order ";
            MySqlCommand mycommand1 = new MySqlCommand(query, conn);

            string x = mycommand1.ExecuteScalar().ToString();//execution command
            int y = Convert.ToInt32(x);           
            return y;
        }

      
        private void prinreceipt()
        {
            try
            {
                PrintDialog printdialog = new PrintDialog();
                PrintPreviewDialog PrevieDialog = new PrintPreviewDialog();
                PrintDocument printdocument = new PrintDocument();
                printdialog.Document = printdocument;
                PrevieDialog.Document = printdocument;
                printdocument.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);
                printdocument.Print();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            string kk = "       ";
            string kidogo = "    ";
            string push = "  ";
            string ssspace = "   ";
            string space = " ";
            string sspace = " ";
            string blankspace = "                                                                                             ";
            string blackspaceshort = "                          ";
            string underline = "---------------------------------------------------------------------------------------------";
            try
            {

                Graphics graphics = e.Graphics;
                Font font = new Font("Constantia", 10);
                float fontHeight = font.GetHeight();
                int startX = 5;
                int startY = 45;
                int Offset = 40;
                StringFormat str = new StringFormat();
                str.Alignment = StringAlignment.Near;
                str.LineAlignment = StringAlignment.Center;
                str.Trimming = StringTrimming.EllipsisCharacter;
                Pen p = new Pen(Color.White, 2.5f);
                graphics.DrawString(sspace + " HOT CORNER DELICACIES", new Font("Constantia", 14), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString(sspace + " Good Food,Good Price", new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString(sspace + "TEL NO:" + " 0722788311 " + "MACHAKOS" + " ", new Font("Constantia", 8), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString(sspace + "DateTime:".PadRight(10) + DateTime.Now.ToShortDateString().PadRight(10) + DateTime.Now.ToShortTimeString(), new Font("Constantia", 8), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString(sspace + "WAITER NO." + userid.Text+ "TABLE NO:", new Font("Constantia", 8), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString(blankspace, new Font("Constantia", 8), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString(kidogo + "ORDER RECEIPT FOR  ORDER NO:" + space + btnorder.Text, new Font("Constantia", 8), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString(underline, new Font("Constantia", 8), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString("ORDER QTY " + ssspace + "FOOD ORDERED" + ssspace + "QTY" , new Font("Constantia", 8), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
               
                for (int i = 0; i <= ListView1.Items.Count - 1; i++)
                {
                    graphics.DrawString(kidogo + ListView1.Items[i].SubItems[1].Text + ssspace + sspace + ListView1.Items[i].SubItems[2].Text + ssspace + sspace + sspace + ListView1.Items[i].SubItems[3].Text + kidogo, new Font("Constantia", 8), new SolidBrush(Color.Black), startX, startY + Offset);
                    Offset = Offset + 20;

                }
                Offset = Offset + 20;
                graphics.DrawString(underline, new Font("Constantia", 8), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString(blankspace, new Font("Constantia", 8), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString("TOTAL:" + blackspaceshort + lbltotal.Text, new Font("Constantia", 8), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;

                graphics.DrawString("You were served by :" + space +lblFull_Name.Text, new Font("Constantia", 8), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString("ORDER No:" + btnorder.Text, new Font("Constantia", 8), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString(kk + "End of Legal Receipt" + space, new Font("Constantia", 8), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString(blankspace, new Font("Constantia", 8), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;


            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

      
        
        private void btnremove_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (ListView1.Items.Count == 0)
                {
                    MessageBox.Show("No items to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int itmCnt = 0;
                    int i = 0;
                    int t = 0;

                    ListView1.FocusedItem.Remove();
                    itmCnt = ListView1.Items.Count;
                    t = 1;

                    for (i = 1; i <= itmCnt + 1; i++)
                    {
                        //Dim lst1 As New ListViewItem(i)
                        //ListView1.Items(i).SubItems(0).Text = t
                        t = t + 1;

                    }
                 lbltotal.Text = subtot().ToString();

                }


                if (ListView1.Items.Count == 0)
                {
                   lbltotal.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnsub_MouseUp_1(object sender, MouseEventArgs e)
        {
            /////
            try
            {


                if (Convert.ToInt64(ListView1.FocusedItem.SubItems[1].Text) > 1)
                {
                    MySqlConnection con = new MySqlConnection(cs.myconnection1);

                    string Query2 = "select food_cost from  food where food_name='" + ListView1.FocusedItem.SubItems[2].Text + "'";
                    con.Open();
                    MySqlCommand mycommand1 = new MySqlCommand(Query2, con);
                    MySqlDataAdapter myadapter = new MySqlDataAdapter();//for offline connection we use mysqldataadapter
                    myadapter.SelectCommand = mycommand1;
                    DataSet ds2 = new DataSet();
                    myadapter.Fill(ds2);
                    int s = (myadapter.Fill(ds2));

                    //SUB quantity by one here up to the time is 1
                    int x = Convert.ToInt32(ListView1.FocusedItem.SubItems[1].Text);
                    ListView1.FocusedItem.SubItems[1].Text = Convert.ToString(x - 1);
                    double x1 = Convert.ToDouble(ListView1.FocusedItem.SubItems[3].Text) - Convert.ToDouble(ds2.Tables[0].Rows[0][0].ToString());
                    ListView1.FocusedItem.SubItems[3].Text = x1.ToString();
                   lbltotal.Text = subtot().ToString();
                }
                else
                {
                    MessageBox.Show("Please remove the product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch
            {

            }
        }

        private void btnadd_MouseUp_1(object sender, MouseEventArgs e)
        {
            ///
            try
            {
                MySqlConnection con = new MySqlConnection(cs.myconnection1);

                string Query2 = "select food_cost from  food where food_name='" + ListView1.FocusedItem.SubItems[2].Text + "'";
                con.Open();
                MySqlCommand mycommand1 = new MySqlCommand(Query2, con);
                MySqlDataAdapter myadapter = new MySqlDataAdapter();//for offline connection we use mysqldataadapter
                myadapter.SelectCommand = mycommand1;
                DataSet ds2 = new DataSet();
                myadapter.Fill(ds2);
                int s = (myadapter.Fill(ds2));


                //add quantity by one here
                int x = Convert.ToInt32(ListView1.FocusedItem.SubItems[1].Text);
                ListView1.FocusedItem.SubItems[1].Text = Convert.ToString(x + 1);
                double x1 = Convert.ToDouble(ListView1.FocusedItem.SubItems[3].Text) + Convert.ToDouble(ds2.Tables[0].Rows[0][0].ToString());
                ListView1.FocusedItem.SubItems[3].Text = x1.ToString();
                 lbltotal.Text = subtot().ToString();
            }
            catch
            {

            }
           
        }

        private void button11_MouseUp_1(object sender, MouseEventArgs e)
        {


            //save and print order
            try
            {
                try
                {
                    for (int j = 0; j <= ListView1.Items.Count - 1; j++)
                    {
                        MySqlConnection conn = new MySqlConnection(cs.myconnection1);
                        conn.Open();
                        string fquery = "select availablequantity from food where  food_name ='" + ListView1.Items[j].SubItems[2].Text + "'";
                        MySqlCommand mycommand11 = new MySqlCommand(fquery, conn);
                        string prev_value = mycommand11.ExecuteScalar().ToString();

                        if (Convert.ToInt32(prev_value) < 1)
                        {
                            MessageBox.Show("Food out of stock");
                            return;
                        }
                        else if (Convert.ToInt32(prev_value) < Convert.ToInt32(ListView1.Items[j].SubItems[1].Text))
                        {
                            MessageBox.Show("More products than the available quantity");
                            return;
                        }

                    }

                  
                    if (ListView1.Items.Count == 0)
                    {
                        MessageBox.Show("sorry no Food  selected", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                catch(Exception )
                {
                }

                q1();
                /********/
                q2();
                for (int j = 0; j <= ListView1.Items.Count - 1; j++)
                {

                    MySqlConnection conn = new MySqlConnection(cs.myconnection1);
                    conn.Open();
                    string fquery = "select availablequantity from food where  food_name ='" + ListView1.Items[j].SubItems[2].Text + "'";
                    MySqlCommand mycommand11 = new MySqlCommand(fquery, conn);
                    string prev_value = mycommand11.ExecuteScalar().ToString();

                    int x3 = Convert.ToInt32(prev_value);
                    int x1 = Convert.ToInt32(ListView1.Items[j].SubItems[1].Text);
                    int x4;
                    x4 = x3 - x1;

                    string Query2 = "UPDATE  food set  availablequantity='" + x4 + "' where  food_name='" + ListView1.Items[j].SubItems[2].Text + "'";

                    MySqlCommand mycommand2 = new MySqlCommand(Query2, conn);
                    MySqlDataReader myreader2;
                    myreader2 = mycommand2.ExecuteReader();//execution command
                    conn.Close();
                }
               
                prinreceipt();
                clr();
                frmscreenlogin fr = new frmscreenlogin();
                this.Hide();                
                fr.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error ocurrred while rtying to save, try again");
            }



        }

        private void q1()
        {
            MySqlConnection myconn1 = new MySqlConnection(cs.myconnection1);
            myconn1.Open();
            string Query1 = "insert into  food_order(user_id,order_cost,payment_status,	date_created) values('" + Convert.ToInt64(userid.Text) + "' ,'" + Convert.ToDouble(lbltotal.Text) + "','NOT PAID','" + DateTime.Now.ToString("yyy-MM-dd HH:mm:ss") + "')";

            MySqlCommand mycommand1 = new MySqlCommand(Query1, myconn1);

            MySqlDataReader myreader1;

            myreader1 = mycommand1.ExecuteReader();//execution command

            myconn1.Close();
        }
        private void q2()
        {
            for (int i = 0; i <= ListView1.Items.Count - 1; i++)
            {
                MySqlConnection con = new MySqlConnection(cs.myconnection1);
                string Query2 = "insert into  food_orderdetails(order_id,food_name,qty,cost,date) values('" + getorder() + "' ,'" + ListView1.Items[i].SubItems[2].Text + "','" + ListView1.Items[i].SubItems[1].Text + "','" + ListView1.Items[i].SubItems[3].Text + "','" + DateTime.Now.ToString("yyy-MM-dd HH:mm:ss") + "')";
                con.Open();
                MySqlCommand mycommand2 = new MySqlCommand(Query2, con);
                MySqlDataReader myreader2;
                myreader2 = mycommand2.ExecuteReader();//execution command                          

                con.Close();
            }
        }

        private void button12_MouseUp(object sender, MouseEventArgs e)
        {
            clr();
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {

            try
            {
               // ListView1.VerticalScroll.Value = vScrollBar1.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("");
            }
        }

        private void lbltotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                order();
            }
            catch
            {

            }
        }

       

     

    }
}
