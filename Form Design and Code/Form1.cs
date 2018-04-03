using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
using MySql.Data.MySqlClient;


namespace Meme_L_O_R_D_Z___Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Login //
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create Account//
            string username;
            string password;

            username = emailtb.Text;
            password = passwordtb.Text;

            //Connects to the database
            string connString = "Server=simplemodes.cyqmaqudzup4.us-east-2.rds.amazonaws.com;Port=3306;Database=SimpleModes;password=UsmStudent";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();

            try
            {
                //checks to see if the username and password appear in the accounttable
              command.CommandText = "Select" + username + " from accounttable where password = " + password;
            }

            catch
            {

                MessageBox.Show("Either wrong password or wrong username, brudda");

            }


        }
    }
}
