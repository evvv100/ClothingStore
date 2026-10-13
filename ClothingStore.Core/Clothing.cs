using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ClothingCategory1;
using ClothingSize1;

namespace ClothingStore.Core
{
    public class Clothing
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public ClothingCategory Category { get; set; }
        public ClothingSize Size { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int Reserved { get; set; }
        public int Available { get; set; }
        public Clothing(int iD, string name, ClothingCategory category, ClothingSize size, int price, int quantity)
        {
            ID = iD;
            Name = name;
            Category = category;
            Size = size;
            Price = price;
            Quantity = quantity;
            Reserved = 0;
            Available = quantity - Reserved;
        }
    }
}
