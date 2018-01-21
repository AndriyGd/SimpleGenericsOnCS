using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGenerics
{
    class DataBase
    {
        private List<Phone> _phones;
        private List<Notebook> _notebooks;

        public DataBase()
        {
            _phones = new List<Phone>();
            _notebooks = new List<Notebook>();
        }
    }
}
