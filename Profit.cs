using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Profit
    {
        // Class Variables //
        private double profit { get; set; }
        private double revenue { get; set; }
        private double cost { get; set; }

        // Class constructor //
        public Profit()
        {
            this.profit = 0.00;
            this.revenue = 0.00;
            this.cost = 0.00;
        }

        public Profit(double p, double r, double c)
        {
            this.profit = p;
            this.revenue = r;
            this.cost = c;
        }

        // Class Functions //
        public void calculateProfit()
        {

        }
        
        public void calculateRevenue()
        {

        }

        public void calculateCost()
        {

        }

    }
}
