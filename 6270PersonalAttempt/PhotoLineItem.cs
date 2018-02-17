using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6270PersonalAttempt
{
    class PhotoLineItem
    {
        private int quantity;
        
        private PhotoTypeChoices photoType;
        private FinishTypeChoices finishType;
        private decimal lineRate = -1M;

        public PhotoLineItem(PhotoTypeChoices photoType, int quantity, FinishTypeChoices finishType)
        {
            this.photoType = photoType;
            this.quantity = quantity;
            this.finishType = finishType;
        }

        public decimal LineRate
        {
            get { return lineRate; }
            set { lineRate = value; }
        }

        public FinishTypeChoices FinishType
        {
            get { return finishType; }
            set { finishType = value; }
        }

        public PhotoTypeChoices PhotoType
        {
            get { return photoType; }
            set { photoType = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

    }
 
}
