using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6270PersonalAttempt
{
    /// <summary>
    /// Basically Fee and Discount Classes were separated out
    /// in case he makes us add more later.  Probably wasn't 
    /// needed...
    /// </summary>
    class Fee
    {
        protected decimal amount;

        public Fee()
        {
            this.amount = 0;
        }

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

    }
}
