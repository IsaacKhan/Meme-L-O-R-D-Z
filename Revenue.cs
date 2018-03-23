using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Revenue
    {
        // Class Variables // 
        private double money { get; set; }
        private int quantity { get; set; }
        private int totalNumberOfOrders { get; set; }
        private double monthlyProfit { get; set; }
        private double weeklyProfit { get; set; }
        private int amountSold { get; set; }

        // Class Constructor //
        public Revenue()
        {
            this.money = 0.00;
            this.quantity = 0;
            this.totalNumberOfOrders = 0;
            this.monthlyProfit = 0.00;
            this.weeklyProfit = 0.00;
            this.amountSold = 0;
        }

        public Revenue(double m, int q, int numOfOrders, double mProfit, double wProfit, int aSold)
        {
            this.money = m;
            this.quantity = q;
            this.totalNumberOfOrders = numOfOrders;
            this.monthlyProfit = mProfit;
            this.weeklyProfit = wProfit;
            this.amountSold = aSold;
        }

        // Class Functions //
        private void calculateMonthlyProfit()
        {

        }

        private void calculateWeeklyProfit()
        {

        }

        private void calculateAmountSold()
        {

        }

        private void calculateTotalOrders()
        {

        }

    }
}
