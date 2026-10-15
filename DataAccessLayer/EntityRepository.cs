using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingStore.Core;
using ClothingCategory1;
using ClothingSize1;

namespace DataAccessLayer
{
    public class EntityRepository : IRepository <Clothing>
    {
        private StoreContext _context = new StoreContext();
        public void Add(Clothing item)
        {
            _context.Clothes.Add(item);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var foundItem = _context.Clothes.Find(id);
            _context.Clothes.Remove(foundItem);
            _context.SaveChanges();
        }
        public List<Clothing> ReadAll()
        {
            return _context.Clothes.ToList();
        }
        public Clothing ReadById(int id)
        {
            var foundItem = _context.Clothes.Find(id);
            return foundItem;
        }
        public void Update(Clothing item)
        {
            var foundItem = _context.Clothes.Find(item.Id);
            foundItem.Category = item.Category;
            foundItem.Size = item.Size;
            foundItem.Price = item.Price;
            foundItem.Name = item.Name;
            _context.SaveChanges();
        }
    }
}
