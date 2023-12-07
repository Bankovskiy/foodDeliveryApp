using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodDeliveryApp
{
    internal class point
    {
        public string type;
        public int value;

        public point(string type)
        {
            this.type = type;
            this.value = 0;
        }
    }
}
