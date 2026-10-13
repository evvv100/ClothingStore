using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderStatusEnum1;
using OrderItem1;
using StatusChange1;


namespace Order1
{
    public class Order
    {
        private static Random rnd = new Random();
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public OrderStatus Status { get; set; }
        public List <OrderItem> Items { get; set; }
        public List <StatusChange> History { get; set; }
        public int Total {  get; set; }

        public Order (DateTime date, int customerId, List<OrderItem> items)
        {
            Id = rnd.Next(100, 1000);
            Date = date;
            CustomerId = customerId;
            Status = OrderStatus.Создан;
            Items = items;
            History.Add(new StatusChange(date, OrderStatus.Создан, customerId));
            Total = 0;
            for(int i = 0; i < Items.Count; i++)
            {
                Total += Items[i].Price * Items[i].Quantity;
            }
        }
    }
}
