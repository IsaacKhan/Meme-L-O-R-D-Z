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
    
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ViewProducts.ReadOnly = true;
            

            string connString = "Server=simplemodes.cyqmaqudzup4.us-east-2.rds.amazonaws.com;port=3307;Database=SimpleModes;user=SimpleModes;password=simplemodes";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();

            try
            {
                // load the data from products table into ViewProduct
                string query = "Select * from product where quantity > 0";

                using (MySqlDataAdapter adpt = new MySqlDataAdapter(query, conn))
                {
                    DataSet dSet = new DataSet();
                    adpt.Fill(dSet);
                    ViewProducts.DataSource = dSet.Tables[0];
                }


                // load the customer cart from table into ViewCart
                query = "select * from customer_cart";

                using (MySqlDataAdapter adpt = new MySqlDataAdapter(query, conn))
                {
                    DataSet dset = new DataSet();
                    adpt.Fill(dset);
                    ViewCart.DataSource = dset.Tables[0];
                }
            }

            catch
            {

                MessageBox.Show("could not connect to DB.");

            }
        }


        private void AddToCardButton_Click(object sender, EventArgs e)
        {
            string connString = "Server=simplemodes.cyqmaqudzup4.us-east-2.rds.amazonaws.com;port=3307;Database=SimpleModes;user=SimpleModes;password=simplemodes";
            MySqlConnection conn = new MySqlConnection(connString);

            if (ViewProducts.SelectedCells.Count > 0)
            {
                // update the products table
                try
                {
                    // This will get the Serial Number from the Selected Row.
                    int selectedrowindex = ViewProducts.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = ViewProducts.Rows[selectedrowindex];

                    string sNum = Convert.ToString(selectedRow.Cells[1].Value);

                    // Now we can use some mySQL statements to update our tables

                    // This is for debugging.
                    // MessageBox.Show(pName);

                    // For now, we will only be updating one item at a time. Meaning, a customer has to click 
                    // "add to cart" however many times they want to represent the amount of the item they are getting.

                    string query = "UPDATE product SET quantity = quantity - 1 WHERE serialnumber = " + sNum + " AND quantity > 0;";
                    MySqlCommand updateCmd = new MySqlCommand(query, conn);

                    MySqlDataReader myReader;
                    conn.Open();
                    myReader = updateCmd.ExecuteReader();

                    while (myReader.Read())
                    {
                    }
                    conn.Close();

                    // insert data into customer's cart
                    query = "INSERT INTO customer_cart SELECT * FROM product WHERE serialnumber = " + sNum + " AND quantity > 0;";
                    MySqlCommand inseretCmd = new MySqlCommand(query, conn);
                    MySqlDataReader myReader2;
                    conn.Open();
                    myReader2 = inseretCmd.ExecuteReader();

                    while (myReader2.Read())
                    {
                    }
                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                // refresh both DataGridViews //
                try
                {
                    // reload the data from products table into ViewProduct
                    string query = "Select * from product where quantity > 0";

                    using (MySqlDataAdapter adpt = new MySqlDataAdapter(query, conn))
                    {
                        DataSet dSet = new DataSet();
                        adpt.Fill(dSet);
                        ViewProducts.DataSource = dSet.Tables[0];
                    }

                    // reload the customer cart from table into ViewCart
                    query = "select * from customer_cart";

                    using (MySqlDataAdapter adpt = new MySqlDataAdapter(query, conn))
                    {
                        DataSet dset = new DataSet();
                        adpt.Fill(dset);
                        ViewCart.DataSource = dset.Tables[0];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }



        }

        private void ViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void confirmOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 invoice = new Form7();

            invoice.Show();
        }

        private void cancelOrder_Click(object sender, EventArgs e)
        {
            string connString = "Server=simplemodes.cyqmaqudzup4.us-east-2.rds.amazonaws.com;port=3307;Database=SimpleModes;user=SimpleModes;password=simplemodes";
            MySqlConnection conn = new MySqlConnection(connString);

            DialogResult dialogResult = MessageBox.Show("Are you done shopping?", "Are you done?", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                string query = "DELETE FROM customer_cart";
                MySqlCommand deleteCmd = new MySqlCommand(query, conn);

                MySqlDataReader myReader;
                conn.Open();
                myReader = deleteCmd.ExecuteReader();

                while (myReader.Read())
                {
                }
                conn.Close();
            }

            this.Close();
        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            string connString = "Server=simplemodes.cyqmaqudzup4.us-east-2.rds.amazonaws.com;port=3307;Database=SimpleModes;user=SimpleModes;password=simplemodes";
            MySqlConnection conn = new MySqlConnection(connString);


            // This will get the Serial Number from the Selected Row.
            int selectedrowindex = ViewCart.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = ViewCart.Rows[selectedrowindex];

            string sNum = Convert.ToString(selectedRow.Cells[1].Value);

            string query = "DELETE FROM customer_cart WHERE serial_number = " + sNum;
            MySqlCommand deleteCmd = new MySqlCommand(query, conn);

            MySqlDataReader myReader;
            conn.Open();
            myReader = deleteCmd.ExecuteReader();

            while (myReader.Read())
            {
            }

            conn.Close();

            // reload the customer cart from table into ViewCart
            query = "select * from customer_cart";

            using (MySqlDataAdapter adpt = new MySqlDataAdapter(query, conn))
            {
                DataSet dset = new DataSet();
                adpt.Fill(dset);
                ViewCart.DataSource = dset.Tables[0];
            }
        }
    }
}
