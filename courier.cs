using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodDeliveryApp
{
    internal class courier
    {
        public string id;
        public string type;
        
        public courier(string id, string type)
        {
            this.id = id;
            this.type = type;
        }
    }
}
