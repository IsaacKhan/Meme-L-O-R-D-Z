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
    
    public partial class CreateOrderForm : Form
    {
        public CreateOrderForm()
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
            MySqlDataReader myReader;

            string query;
            bool inCart = false;


            if (ViewProducts.SelectedCells.Count > 0)
            {
                // update the products table
                try
                {
                    // This will get the Serial Number from the Selected Row.
                    int selectedrowindex = ViewProducts.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = ViewProducts.Rows[selectedrowindex];

                    // Here we get the serial number, which is unqiue to each item
                    string sNum = Convert.ToString(selectedRow.Cells[1].Value);


                    // Now we can use some mySQL statements to update our tables //


                    // First, check to see if this serial number exists in the customer's cart
                    query = "SELECT * FROM customer_cart WHERE serial_number = " + sNum;
                    MySqlCommand searchForCmd = new MySqlCommand(query, conn);

                    conn.Open();
                    myReader = searchForCmd.ExecuteReader();
                    while(myReader.Read())
                    {
                        if (myReader.HasRows == true)
                            inCart = true;
                    }
                    conn.Close();

                    if (inCart == true)
                    {
                        // If the item exists in the cart, just update the customer's cart by adding 1 of the chosen item.
                        query = "UPDATE customer_cart SET quantity = quantity + 1 WHERE serial_number = " + sNum;
                        MySqlCommand incrementCmd = new MySqlCommand(query, conn);

                        conn.Open();
                        myReader = incrementCmd.ExecuteReader();

                        while(myReader.Read())
                        {
                        }
                        conn.Close();

                        // Here, update the products table
                        query = "UPDATE product SET quantity = quantity - 1 WHERE serialnumber = " + sNum + " AND quantity > 0;";
                        MySqlCommand updateCmd = new MySqlCommand(query, conn);

                        conn.Open();
                        myReader = updateCmd.ExecuteReader();

                        while (myReader.Read())
                        {
                        }
                        conn.Close();
                    }
                    else
                    {
                        // If the item doesn't exists in the cart, we load the info from the products table into the customer_cart
                        // making sure we remove 1 of the selected item from the products table.

                        // Here, update the products table
                        query = "UPDATE product SET quantity = quantity - 1 WHERE serialnumber = " + sNum + " AND quantity > 0;";
                        MySqlCommand updateCmd = new MySqlCommand(query, conn);

                        conn.Open();
                        myReader = updateCmd.ExecuteReader();

                        while (myReader.Read())
                        {
                        }
                        conn.Close();

                        // Here, insert data into customer's cart
                        query = "INSERT INTO customer_cart SELECT * FROM product WHERE serialnumber = " + sNum + " AND quantity > 0;";
                        MySqlCommand inseretCmd = new MySqlCommand(query, conn);
                        conn.Open();
                        myReader = inseretCmd.ExecuteReader();

                        while (myReader.Read())
                        {
                        }
                        conn.Close();

                        // adjust the new item to be a quantity of 1
                        query = "UPDATE customer_cart SET quantity = 1 WHERE serial_number = " + sNum;
                        MySqlCommand adjustCmd = new MySqlCommand(query, conn);

                        conn.Open();
                        myReader = adjustCmd.ExecuteReader();

                        while (myReader.Read())
                        {
                        }
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                // refresh both DataGridViews //
                try
                {
                    // reload the data from products table into ViewProduct
                    query = "Select * from product where quantity > 0";

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
            InvoiceForm invoice = new InvoiceForm();

            invoice.Show();
        }

        private void cancelOrder_Click(object sender, EventArgs e)
        {
            string connString = "Server=simplemodes.cyqmaqudzup4.us-east-2.rds.amazonaws.com;port=3307;Database=SimpleModes;user=SimpleModes;password=simplemodes";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlDataReader myReader;
            string query;

            DialogResult dialogResult = MessageBox.Show("Are you done shopping?", "Are you done?", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                // arrays for storing serial numbers and quantities
                int[] sNumArray = new int[10];
                int[] qtyArray = new int[10];
                int position = 0;
                int iterationCount = 0;

                // mySQL block for getting all serial numbers
                query = "SELECT serial_number FROM customer_cart";
                MySqlCommand getSerialNumCmd = new MySqlCommand(query, conn);

                conn.Open();
                myReader = getSerialNumCmd.ExecuteReader();
                while(myReader.Read())
                {
                    sNumArray[position] = myReader.GetInt32("serial_number");
                    position++;
                }
                conn.Close();

                // reset counter for next array and get number of iterations/rows were selected
                iterationCount = position;
                position = 0;

                // mySQL block for getting all quantities
                query = "SELECT quantity FROM customer_cart";
                MySqlCommand getQtyCmd = new MySqlCommand(query, conn);

                conn.Open();
                myReader = getQtyCmd.ExecuteReader();
                while (myReader.Read())
                {
                    qtyArray[position] = myReader.GetInt32("quantity");
                    position++;
                }
                conn.Close();

                // mySQL block for restoring poduct table
                for(int i = 0; i < iterationCount; i++)
                {
                    int sNum = sNumArray[i];
                    int qty = qtyArray[i];

                    query = "UPDATE product SET quantity = quantity + " + qty + " WHERE serialnumber = " + sNum;
                    MySqlCommand restoreProdsCmd = new MySqlCommand(query, conn);

                    conn.Open();
                    myReader = restoreProdsCmd.ExecuteReader();

                    while (myReader.Read())
                    {
                    }
                    conn.Close();

                }

                // Remove items from cart
                query = "DELETE FROM customer_cart";
                MySqlCommand deleteCmd = new MySqlCommand(query, conn);

                conn.Open();
                myReader = deleteCmd.ExecuteReader();

                while (myReader.Read())
                {
                }
                conn.Close();
                this.Close();
            }

        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            string connString = "Server=simplemodes.cyqmaqudzup4.us-east-2.rds.amazonaws.com;port=3307;Database=SimpleModes;user=SimpleModes;password=simplemodes";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlDataReader myReader;
            string query;
            int sNumQty = 0;


            // This will get the Serial Number from the Selected Row.
            int selectedrowindex = ViewCart.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = ViewCart.Rows[selectedrowindex];

            string sNum = Convert.ToString(selectedRow.Cells[1].Value);


            // mySQL block for getting all quantities
            query = "SELECT quantity FROM customer_cart WHERE serial_number = " + sNum;
            MySqlCommand getQtyCmd = new MySqlCommand(query, conn);

            conn.Open();
            myReader = getQtyCmd.ExecuteReader();
            while (myReader.Read())
            {
                sNumQty = myReader.GetInt32("quantity");
            }
            conn.Close();

            // Block for resoring the products quantity
            query = "UPDATE product SET quantity = quantity + " + sNumQty + " WHERE serialnumber = " + sNum;
            MySqlCommand restoreProdsCmd = new MySqlCommand(query, conn);

            conn.Open();
            myReader = restoreProdsCmd.ExecuteReader();

            while (myReader.Read())
            {
            }
            conn.Close();

            query = "DELETE FROM customer_cart WHERE serial_number = " + sNum;
            MySqlCommand deleteCmd = new MySqlCommand(query, conn);

            conn.Open();
            myReader = deleteCmd.ExecuteReader();

            while (myReader.Read())
            {
            }

            conn.Close();

            // reload the data from products table into ViewProduct
            query = "Select * from product where quantity > 0";

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
    }
}
