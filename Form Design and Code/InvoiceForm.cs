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
using System.Drawing.Printing;

namespace Meme_L_O_R_D_Z___Forms
{
    public partial class InvoiceForm : Form
    {
        private string documentContents;
        private string stringToPrint;

        public InvoiceForm()
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
            TextWriter writer = new StreamWriter(@"C:\Users\joe_c\Documents\Visual Studio 2015\Projects\Meme!L O R D Z - Forms\MyTest.txt");

            writer.WriteLine("\tProduct Name\t|\tSerial Number\t|\tBrand\t|\tColor\t|\tPrice\t|\tItem Type\t|\tQuantity\t|");
            writer.WriteLine("");

            for (int i = 0; i < ViewInvoice.Rows.Count; i++)
            {
                for(int j = 0; j < ViewInvoice.Columns.Count; j++)
                {
                    writer.Write("\t" + ViewInvoice.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
                writer.WriteLine("");
                writer.WriteLine("---------------------------------------------------------------------------------------------");
            }
            writer.Close();
            this.printPreviewDialog1.ShowDialog();           
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            string docName = "MyTest.txt";
            string docPath = @"C:\Users\joe_c\Documents\Visual Studio 2015\Projects\Meme!L O R D Z - Forms\";
            printDocument1.DocumentName = docName;
            using (FileStream stream = new FileStream(docPath + docName, FileMode.Open))
            using (StreamReader reader = new StreamReader(stream))
            {
                documentContents = reader.ReadToEnd();
            }
            stringToPrint = documentContents;


            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int charactersOnPage = 5;
            int linesPerPage = 10;

            // Sets the value of charactersOnPage to the number of characters 
            // of stringToPrint that will fit within the bounds of the page.
            e.Graphics.MeasureString(stringToPrint, this.Font,e.MarginBounds.Size, StringFormat.GenericTypographic, out charactersOnPage, out linesPerPage);

            // Draws the string within the bounds of the page.
            e.Graphics.DrawString(stringToPrint, this.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);

            // Remove the portion of the string that has been printed.
            stringToPrint = stringToPrint.Substring(charactersOnPage);

            // Check to see if more pages are to be printed.
            e.HasMorePages = (stringToPrint.Length > 0);
        }
    }
}
