using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6270PersonalAttempt
{
    class DeliveryRateFee : Fee
    {
        public void setFee(List<PhotoLineItem> lines, DeliveryTypeChoices deliveryType, OrderType orderType)
        {
            if (deliveryType == DeliveryTypeChoices.nextDay)
            {
                amount = 0;
                return;
            }

            int quanity = 0;
            foreach (var line in lines)
            {
                quanity += line.Quantity;
            }
            if (orderType == OrderType.standard)
            {
                amount = (quanity <= 60) ? 1M : 1.5M;
            } else
            {
                amount = (quanity <= 60) ? 2M : 2.5M;
            }


        }
    }
}
