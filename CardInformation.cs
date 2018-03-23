using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class CardInformation
    {
        // Class Variables //
        private string cardName { get; set; }
        private int secuirtyNumber { get; set; }
        private int cardNumber { get; set; }
        private string cardType { get; set; }
        private string address { get; set; }
        private int zipCode { get; set; }

        // Class Constructoer //
        public CardInformation()
        {
            this.cardName = "";
            this.secuirtyNumber = 0;
            this.cardNumber = 0;
            this.cardType = "";
            this.address = "";
            this.zipCode = 0;
        }

        public CardInformation(string cName, int sNumber, int cNumber, string cType, string a, int zCode)
        {
            this.cardName = cName;
            this.secuirtyNumber = sNumber;
            this.cardNumber = cNumber;
            this.cardType = cType;
            this.address = a;
            this.zipCode = zCode;
        }

        // Class Functions //


    }
}
