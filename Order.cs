using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Order
    {
        // Class Variables //
        private string productName { get; set; }
        private int orderNumber { get; set; }
        private int modelNumber { get; set; }
        private bool orderType { get; set; }
        private string status { get; set; }
        private string productState { get; set; }
        private int accountID { get; set; }
        private int serialNumber { get; set; }
        private string color { get; set; }
        private string type { get; set; }
        private string brand { get; set; }
        private double price { get; set; }
        private int quantity { get; set; }

        // Class Constructor //
        public Order()
        {
            this.productName = "";
            this.orderNumber = 0;
            this.modelNumber = 0;
            this.orderType = true;
            this.status = "";
            this.productState = "";
            this.accountID = 0;
            this.serialNumber = 0;
            this.color = "";
            this.type = "";
            this.brand = "";
            this.price = 0.00;
            this.quantity = 0;
        }

        public Order( string pName, int oNumber, int mNumber, bool oType, string s, string pState, int aID, int sNumber, string c, string t, string b, double p, int q)
        {
            this.productName = pName;
            this.orderNumber = oNumber;
            this.modelNumber = mNumber;
            this.orderType = oType;
            this.status = s;
            this.productState = pState;
            this.accountID = aID;
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
