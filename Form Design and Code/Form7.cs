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
using System.IO;

namespace Meme_L_O_R_D_Z___Forms
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            string connString = "Server=simplemodes.cyqmaqudzup4.us-east-2.rds.amazonaws.com;port=3307;Database=SimpleModes;user=SimpleModes;password=simplemodes";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                // reload the data from products table into ViewProduct
                string query = "Select * from customer_cart ";

                using (MySqlDataAdapter adpt = new MySqlDataAdapter(query, conn))
                {
                    DataSet dSet = new DataSet();
                    adpt.Fill(dSet);
                    ViewInvoice.DataSource = dSet.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CloseWindowButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void PrintInvoiceButton_Click(object sender, EventArgs e)
        {

            this.printPreviewDialog1.Show();           
        }


        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}