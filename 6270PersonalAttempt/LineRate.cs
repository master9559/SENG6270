using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6270PersonalAttempt
{

    abstract class LineRate
    {
        protected PhotoLineItem lineItem;

        public LineRate(PhotoLineItem lineItem)
        {
            this.lineItem = lineItem;
        }
        public abstract decimal getBaseRate();
        public abstract decimal getFinishTypeUpcharge();

        public decimal getLineRate()
        {
            return getBaseRate() + getFinishTypeUpcharge();
        }
    }
}

