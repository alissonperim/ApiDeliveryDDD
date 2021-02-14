using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDeliveryDDD.Domain.Entities.Enums
{
    public enum DeliveryStatus : int
    {
        Preparing = 1,
        WaitingDerliverer = 2,
        OnDelivery = 3,
        Delivered = 4
    }
}
