using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodDeliveryApp
{
    internal class food
    {
        public string name;
        public string description;
        public string type;
        public double price;

        public food(string name, string description, string type, double price)
        {
            this.name = name;
            this.description = description;
            this.type = type;
            this.price = price;
        }
    }
}
