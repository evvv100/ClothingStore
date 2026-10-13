using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingSize1;

namespace OrderItem1
{
    public class OrderItem
    {
        public int ClothingId { get; set; }
        public string Name { get; set; }
        public ClothingSize Size { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public OrderItem (int clothingId, string name, ClothingSize size, int price, int quantity)
        {
            ClothingId = clothingId;
            Name = name;
            Size = size;
            Price = price;
            Quantity = quantity;
        }
    }
}
