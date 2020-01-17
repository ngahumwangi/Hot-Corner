using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//mysql data connection namespace reference to .data dll 

namespace Hot_Corner
{
    public partial class frmscreenlogin : Form
    {
        Connection cs = new Connection();//referencing connection class
        Securitysha1 ss = new Securitysha1();// referenceing password encryption class
        public frmscreenlogin()
        {
            InitializeComponent();
        }

        private void btn1_MouseUp(object sender, MouseEventArgs e)
        {
            string data = "1";
            txtpass.Text += data;
        }

        private void btn2_MouseUp(object sender, MouseEventArgs e)
        {
            string data = "2";
            txtpass.Text += data;
        }

        private void btn3_MouseUp(object sender, MouseEventArgs e)
        {
            string data = "3";
            txtpass.Text += data;
        }

        private void btn4_MouseUp(object sender, MouseEventArgs e)
        {
            string data = "4";
            txtpass.Text += data;
        }

        private void btn5_MouseUp(object sender, MouseEventArgs e)
        {
            string data = "5";
            txtpass.Text += data;
        }

        private void btn6_MouseUp(object sender, MouseEventArgs e)
        {
            string data = "6";
            txtpass.Text += data;
        }

        private void btn7_MouseUp(object sender, MouseEventArgs e)
        {
            string data = "7";
            txtpass.Text += data;
        }

        private void btn8_MouseUp(object sender, MouseEventArgs e)
        {
            string data = "8";
            txtpass.Text += data;
        }

        private void btn9_MouseUp(object sender, MouseEventArgs e)
        {
            string data = "9";
            txtpass.Text += data;
        }

        private void btn0_MouseUp(object sender, MouseEventArgs e)
        {
            string data = "0";
            txtpass.Text += data;
        }

        private void btnx_MouseUp(object sender, MouseEventArgs e)
        {
            string data = "";
            txtpass.Text += data;
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
          
          
        }
        string userid = "";
        string username = "";
        string fullname = "";
        string role = "";
        string password = "";
        public bool validate_login(string pass)
        {
            string passsha = ss.GetSHA1(txtpass.Text);
            bool ret = false;
            try
            {

                //dbconnection();//reffering to connection function defined above
                DataSet ds2 = new DataSet();
                string query = "select userid,fname,othername,role,username,password from hotcorner_users where password='" + passsha + "'";//sql query to select from mysql databse
                MySqlConnection myconn1 = new MySqlConnection(cs.myconnection1);
                MySqlCommand mycommand1 = new MySqlCommand();
                MySqlDataAdapter myreader1 = new MySqlDataAdapter(query, myconn1);
                int s = (myreader1.Fill(ds2));
                if (s == 1)
                {

                    userid = ds2.Tables[0].Rows[0][0].ToString();//assign the first item in the array to user_id                  
                    fullname = ds2.Tables[0].Rows[0][1].ToString() + "  " + ds2.Tables[0].Rows[0][2].ToString();//Get full names
                    role = ds2.Tables[0].Rows[0][3].ToString();//assign the 2nd item in the array to user_id
                    username = ds2.Tables[0].Rows[0][4].ToString();



                    ret = true;

                }
                else if (s < 1)
                {
                    ret = false;
                    MessageBox.Show("no  such user found in the system, contact the admin");

                }
                else if (s > 1)
                {
                    ret = false;
                    MessageBox.Show("multiple  users found in the system contact the admin");

                }
                else
                {
                    ret = false;
                    MessageBox.Show("Invalid Password or Username", "pharmsoft", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    txtpass.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "pharmsoft", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return ret;
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtpass.Text = "";
            //this code deactivate all other code aprt from numeric only
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnarrow_MouseUp(object sender, MouseEventArgs e)
        {
            //validation
            if (txtpass.Text == "")
            {
                MessageBox.Show("Your password is required");
                txtpass.Focus();

            }
            else
            {
                bool r = validate_login(txtpass.Text);
                if (r == true)
                {
                    frmpos cs = new frmpos();
                    this.Hide();
                    cs.userid.Text = userid;
                    cs.lblUsername.Text = username;
                    cs.lblRole.Text = role;
                    cs.lblFull_Name.Text = fullname;                   
                    cs.Show();
                }

                else
                {
                    MessageBox.Show("incorrect login credentials");
                    txtpass.Text = "";




                }
            }
        }

        private void frmscreenlogin_Load(object sender, EventArgs e)
        {

        }

       
    }
}
