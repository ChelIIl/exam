using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class Products
    {
        string fishtype = "";
        string proiz = "";
        double price;

        public string SetFishType
        {
            get { return fishtype; }
            set { fishtype = value; }
        }

        public string SetProiz
        {
            get { return proiz; }
            set { proiz = value; }
        }

        public double SetPrice
        {
            get { return price; }
            set { price = value; }
        }
    }
}
