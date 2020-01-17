using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hot_Corner
{
    public partial class frmmain : Form
    {
        Timer timer1 = new Timer();
        public frmmain()
        {
            InitializeComponent();
            try
            {
                this.lbldate.Text = DateTime.Now.ToString();
                this.lbltime.Text = DateTime.Now.ToString(); 
                timer1.Tick += new EventHandler(timer1_Tick);
                this.timer1.Interval = 1000;
                this.timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        Connection cs = new Connection();//referencing connection class
        private void timer1_Tick(Object sender, EventArgs e)
        {
            this.lbldate.Text = DateTime.Now.ToLongDateString();
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }
        private void btnlogout_MouseUp(object sender, MouseEventArgs e)
        {
            ///this code exit the running windows and open the login windows
            frmwelcome frm = new frmwelcome();
            this.Hide();
            frm.Show();
        }

      

     

        private void btnpos_MouseUp(object sender, MouseEventArgs e)
        {
            frmscreenlogin fr = new frmscreenlogin();
            fr.Show();
        }

       
    }
}
