using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGenerics
{
    class Repository
    {
        private DataBase _db;

        public Repository()
        {
            _db = new DataBase();
        }

        public List<TEntity> GetItemsBy<TEntity>() 
            where TEntity : class
        {
            //Один з варіантів
            //var table = _db.GetTable<TEntity>();
            //return table;

            return _db.GetTable<TEntity>();
        }

        public List<TEntity> GetItemsBy<TEntity>(string brand)
            where TEntity : class, IEntityBrand
        {
            var table = _db.GetTable<TEntity>();
            var items = table.Where(it => it.Brand.Equals(brand));

            return items.ToList();
        }

        public void AddItem<TEntity>(TEntity item)
            where TEntity : class
        {
            _db.GetTable<TEntity>().Add(item);
        }
    }
}

