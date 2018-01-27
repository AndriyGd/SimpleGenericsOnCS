using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGenerics
{
    class Phone: IEntityBrand
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public double Price { get; set; }
        public int ManagerId { get; set; }

        public override string ToString()
        {
            return $"Brand: {Brand}\nModel: {Model}\nPrice: {Price}";
        }
    }
}
