using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGenerics
{
    class DataBase
    {
        public List<Phone> Phones { get; }
        public List<Notebook> Notebooks { get; }

        public DataBase()
        {
            Phones = new List<Phone>();
            Notebooks = new List<Notebook>();

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                Phones.Add(new Phone{Brand = "Zxcv", ManagerId = 1, Model = "FV-90", Price = 250.99});

                Phones.Add(new Phone { Brand = "fgh", ManagerId = 6, Model = "KV-920", Price = 350.99 });

                Phones.Add(new Phone { Brand = "qqq", ManagerId = 1, Model = "MNj-80", Price = 550.99 });

                Notebooks.Add(new Notebook{Brand = "qqq", ScreenSize = 21});

                Notebooks.Add(new Notebook { Brand = "kjh", ScreenSize = 11.5 });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public List<TEntity> GetTable<TEntity>() where TEntity : class
        {
            
            if (typeof(TEntity).Name.Equals(nameof(Phone)))
            {
                return Phones as List<TEntity>;
            }

            if (typeof(TEntity).Name.Equals(nameof(Notebook)))
            {
                return Notebooks as List<TEntity>;
            }

            throw new InvalidCastException();
        }
    }
}
