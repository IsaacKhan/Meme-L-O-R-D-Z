using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Cost
    {
        // Class Variables //
        private double itemPrice { get; set; }
        private double costOfOperation { get; set; }
        
        // Class Constructors //
        public Cost()
        {
            this.itemPrice = 0.00;
            this.costOfOperation = 0.00;
        }

        public Cost(double iPrice, double cOfOperations)
        {
            this.itemPrice = iPrice;
            this.costOfOperation = cOfOperations;
        }

        // Class Functions //
        private void calculateCostOfOperations()
        {

        }
    }
}
