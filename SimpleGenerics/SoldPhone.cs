using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGenerics
{
    class SoldPhone: IPhone
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public double Price { get; set; }
    }
}
