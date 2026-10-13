using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovementTypeEnum1;

namespace StockMovement1
{
    public class StockMovement
    {
        public DateTime Date {  get; set; }
        public int ClothingId { get; set; }
        public MovementType Type { get; set; }
        public int Quantity { get; set; }
        public int UserId { get; set; }
        public string Comment { get; set; }
        public StockMovement(DateTime date, int clothingId, MovementType type, int quantity, int userId, string com)
        {
            Date = date;
            ClothingId = clothingId;
            Type = type;
            Quantity = quantity;
            UserId = userId;
            Comment = com;
        }
    }
}
