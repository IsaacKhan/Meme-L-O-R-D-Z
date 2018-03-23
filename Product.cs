using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Product
    {
        // Class Variables //
        private string productName { get; set; }
        private int modelNumber { get; set; }
        private bool availability { get; set; }
        private int serialNumber { get; set; }
        private string color { get; set; }
        private string type { get; set; }
        private string brand { get; set; }
        private double price { get; set; }
        private int quantity { get; set; }
    
        // Class Constructor //
        public Product()
        {
            this.productName = "";
            this.modelNumber = 0;
            this.availability = true;
            this.serialNumber = 0;
            this.color = "";
            this.type = "";
            this.brand = "";
            this.price = 0.00;
            this.quantity = 0;
        }

        public Product(string pName, int mNumber, bool a, int sNumber, string c, string t, string b, double p, int q)
        {
            this.productName = pName;
            this.modelNumber = mNumber;
            this.availability = a;
            this.serialNumber = sNumber;
            this.color = c;
            this.type = t;
            this.brand = b;
            this.price = p;
            this.quantity = q;
        }

        // Class Functions //

    }
}
