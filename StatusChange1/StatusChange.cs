using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderStatusEnum1;

namespace StatusChange1
{
    public class StatusChange
    {
        public DateTime Date { get; }    
        public OrderStatus Status { get; }
        public int ActorId { get; }
        public StatusChange(DateTime date, OrderStatus status, int actorId)
        {
            Date = date;
            Status = status;
            ActorId = actorId;
        }
    }
}
