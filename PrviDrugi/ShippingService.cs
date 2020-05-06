using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviDrugi
{
    class ShippingService
    {
        private double jcm;
        public ShippingService(double jcm)
        {
            this.jcm = jcm;
        }
        public double getPrice(double weight)
        {
            return jcm * weight;
        }

        public override string ToString()
        {
                return "Cijena paketa iznosi: ";
        }
    }
}


