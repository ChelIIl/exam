using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class Products
    {
        public string fishtype = "";
        public string proiz = "";
        public double price;

        public string SetFishType
        {
            get { return this.fishtype; }
            set { this.fishtype = value; }
        }

        public string SetProiz
        {
            get { return this.proiz; }
            set { this.proiz = value; }
        }

        public double SetPrice
        {
            get { return this.price; }
            set { this.price = value; }
        }
    }
}
