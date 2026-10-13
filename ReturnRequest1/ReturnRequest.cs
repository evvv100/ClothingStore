using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReturnStatusEnum1;

namespace ReturnRequest1
{
    public class ReturnRequest
    {
        private static Random rnd = new Random();
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ClothingId { get; set; }
        public int Quantity { get; set; }
        public string Reason { get; set; }
        public ReturnStatus Status { get; set; }
        public ReturnRequest(int orderId, int clothingId, int quantity, string reason)
        {
            Id = rnd.Next(100, 1000);
            OrderId = orderId;
            ClothingId = clothingId;
            Quantity = quantity;
            Reason = reason;
        }
    }
}
