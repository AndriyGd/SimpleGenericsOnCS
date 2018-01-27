using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGenerics
{
    class Notebook: IEntityBrand
    {
        public string Brand { get; set; }
        public double ScreenSize { get; set; }

        /// <inheritdoc />
        public override string ToString()
        {
            return $"Brand: {Brand}\nScreenSize: {ScreenSize}";
        }
    }
}
