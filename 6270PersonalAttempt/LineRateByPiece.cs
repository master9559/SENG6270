using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6270PersonalAttempt
{
    class LineRateByPiece : LineRate
    {
        public LineRateByPiece(PhotoLineItem lineItem) : base(lineItem)
        {
        }

        override
        public decimal getBaseRate()
        {
            decimal amount = 0.16M;

            switch (lineItem.PhotoType)
            {
                case PhotoTypeChoices.fourbysix:
                    amount = .19M;
                    break;
                case PhotoTypeChoices.fivebyseven:
                    amount = .39M;
                    break;
                case PhotoTypeChoices.eightbyten:
                    amount = .79M;
                    break;
            }
            return amount;
        }

        override
        public decimal getFinishTypeUpcharge()
        {
            decimal amount = 0M;
            if (lineItem.FinishType == FinishTypeChoices.matte)
            {
                switch (lineItem.PhotoType)
                {
                    case PhotoTypeChoices.fourbysix:
                        amount = .04M;
                        break;
                    case PhotoTypeChoices.fivebyseven:
                        amount = .06M;
                        break;
                    case PhotoTypeChoices.eightbyten:
                        amount = .08M;
                        break;

                    default:
                        break;
                }
            }
            return amount;
        }


    }
}
