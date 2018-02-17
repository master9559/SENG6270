using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6270PersonalAttempt
{
    class LineRatesStandard
    {
        PhotoLineItem lineItem;

        public LineRatesStandard(PhotoLineItem lineItem)
        {
            this.lineItem = lineItem;
        }

        public decimal getBaseRate()
        {
            decimal amount = 0.14M;

            switch (lineItem.PhotoType)
            {
                case PhotoTypeChoices.fourbysix:
                    if (lineItem.Quantity <= 50) amount = .14M;
                    else if (lineItem.Quantity <= 75) amount = .12M;
                    else amount = .10M;
                    break;
                case PhotoTypeChoices.fivebyseven:
                    if (lineItem.Quantity <= 50) amount = .34M;
                    else if (lineItem.Quantity <= 75) amount = .31M;
                    else amount = .28M;
                    break;
                case PhotoTypeChoices.eightbyten:
                    if (lineItem.Quantity <= 50) amount = .68M;
                    else if (lineItem.Quantity <= 75) amount = .64M;
                    else amount = .60M;
                    break;
            }
            return amount;
        }

        public decimal getFinishTypeUpcharge()
        {
            decimal amount = 0M;
            if (lineItem.FinishType == FinishTypeChoices.matte) {
                switch (lineItem.PhotoType)
                {
                    case PhotoTypeChoices.fourbysix:
                        amount = .02M;
                        break;
                    case PhotoTypeChoices.fivebyseven:
                        amount = .03M;
                        break;
                    case PhotoTypeChoices.eightbyten:
                        amount = .04M;
                        break;

                    default:
                        break;
                }
            }
            return amount;
        }

        public decimal getLineRate()
        {
            return getBaseRate() + getFinishTypeUpcharge();
        }
    }
}
