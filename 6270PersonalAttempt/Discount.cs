using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6270PersonalAttempt
{
    abstract class Discount
    {
        protected decimal amount;
        protected bool exclusive;

        public Discount()
        {
            amount = 0M;
            exclusive = true;
        }

        public decimal getTotalDiscount()
        {
            return amount;
        }

        public bool isExclusive()
        {
            return exclusive;
        }
    }
}
