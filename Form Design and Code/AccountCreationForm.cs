using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Meme_L_O_R_D_Z___Forms
{
    public partial class AccountCreationForm : Form
    {
        public AccountCreationForm()
        {
            InitializeComponent();
        }

        private void createaccbt_Click(object sender, EventArgs e)
        {
            string email = emailtb.Text;
            string password = passwordtb.Text;
            string firstname = firsttb.Text;
            string lastname = lastnametb.Text;
            string phone = phonenumbertb.Text;
            string cardnumber = cardnumbertb.Text;
            string city = citytb.Text;
            string state = statetb.Text;
            string street = streettb.Text;
            string securitynumber = securitynumbertb.Text;
            //string userExist;
            string zipcode = zipcodetb.Text;
            string cardtype = "";
            bool doesExist = false;

            if (amerexp.Checked == true)
            {
                cardtype = "American Express";
            }

            if (ebt.Checked == true)
            {
                cardtype = "EBT";
            }

            if (visa.Checked == true)
            {
                cardtype = "Visa";
            }

            if (master.Checked == true)
            {
                cardtype = "Master";
            }

            //connects to database pretty straight forward 
            string connString = "Server=simplemodes.cyqmaqudzup4.us-east-2.rds.amazonaws.com;Port=3307;Database=SimpleModes;User=SimpleModes;password=simplemodes";
            MySqlConnection conn = new MySqlConnection(connString);

            //creates a string to do mySQL commands and stuff
            MySqlCommand insertUserInfo = conn.CreateCommand();
            MySqlCommand checkIfExist = conn.CreateCommand();

            //used to see if the username chosen exists obviously 
            conn.Open();
            checkIfExist.CommandText = "Select '" + email + "' from customer where customerpassword = '" + password + "'";
            MySqlDataReader dr = checkIfExist.ExecuteReader();

            while (dr.Read())
            {
                doesExist = true;
            }
            conn.Close();

            if (doesExist)
            {
                MessageBox.Show("Try to be more original as your username already exist. Normie.");
                createaccbt_Click(sender, e);
            }

            else if (doesExist == false)
            {
                insertUserInfo.CommandText = "Insert into customer (emailAddress, customerpassword, firstname, lastname, phonenumber, city, state, street, zipcode, cardnumber, securitynumber, cardtype)" + "values('" + email + "','" + password + "','" + firstname + "','" + lastname + "','" + phone + "','" + city + "','" + state + "','" + street + "','" + zipcodetb + "','" + cardnumber + "','" + securitynumber + "','" + cardtype + "')";
                conn.Open();

                MySqlDataReader dr2 = insertUserInfo.ExecuteReader();

                while (dr2.Read())
                {
                }

                conn.Close();
                this.Close();

                //LoginForm f1 = new LoginForm();
                //f1.ShowDialog();
            }


        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
