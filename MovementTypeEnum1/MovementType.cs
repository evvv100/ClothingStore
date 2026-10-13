using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementTypeEnum1
{
    /// <summary>
    /// приемка, списание, резервирование, отмена заказа, заказ передан в доставку, возврат
    /// </summary>
    public enum MovementType
    {
        Receipt,
        WriteOff,
        Reserve,
        Release,
        Shipment,
        Return
    }
}
