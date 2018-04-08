using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6270PersonalAttempt
{
    /// <summary>
    /// Need to make sure this is only called when on uniform prints.
    /// </summary>
    class PromoDiscount : Discount
    {
        public void CalculateDiscount(PhotoLineItem lineItem, string promoCode)
        {
            if (lineItem.Quantity == 100 && promoCode.ToUpper().Equals("N56M2"))
            {
                amount = 2M;
            }
        }
    }
}
