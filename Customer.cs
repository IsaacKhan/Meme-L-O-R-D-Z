using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        // Class Variables //
        private int c_ID { get; set; }
        private string firstName { get; set; }
        private string middleName { get; set; }
        private string lastName { get; set; }
        private string emailAddress { get; set; } 
        private string phoneNumber { get; set; }
        private string password { get; set; }

        // Class Constructor //
        public Customer()
        {
            this.c_ID = 0;
            this.firstName = "";
            this.middleName = "";
            this.lastName = "";
            this.emailAddress = "";
            this.phoneNumber = "";
            this.password = "GrandSlavePump";
        }

        public Customer (int id, string fName, string mName, string lName, string email, string pNumber, string pword)
        {
            this.c_ID = id;
            this.firstName = fName;
            this.middleName = mName;
            this.lastName = lName;
            this.emailAddress = email;
            this.phoneNumber = pNumber;
            this.password = pword;
        }

        // Class Functions //
        public void removeCustomerInfo()
        {

        }

        public void cancelOrder()
        {

        }
    }
}
