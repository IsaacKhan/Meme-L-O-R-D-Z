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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Login //
            string username;
            string password;
            bool flag = false; 
            username = emailtb.Text;
            password = passwordtb.Text;
            //Connects to the database
            string connString = "Server=simplemodes.cyqmaqudzup4.us-east-2.rds.amazonaws.com;port=3307;Database=SimpleModes;user=SimpleModes;password=simplemodes";
            MySqlConnection conn = new MySqlConnection(connString);
           
            string query = "SELECT emailAddress from customer WHERE customerpassword ='" + password + "'";
            MySqlCommand updateCmd = new MySqlCommand(query, conn);
            MySqlDataReader myReader;

            conn.Open();
            myReader = updateCmd.ExecuteReader();

            while (myReader.Read())
            {
                flag = true;
            }
                conn.Close();

            if (flag)
            {
                CreateOrderForm f4 = new CreateOrderForm();
                f4.ShowDialog();

                this.Hide();

                emailtb.Clear();
                passwordtb.Clear();
            }
            else
                MessageBox.Show("Wrong username or password");

        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            AccountCreationForm f3 = new AccountCreationForm();
            f3.ShowDialog();
        }

        private void emailtb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
