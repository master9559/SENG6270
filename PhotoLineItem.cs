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
        private DeliveryTypeChoices deliveryType;
        private decimal lineRate = -1M;
        private decimal lineRate2 = -1m;

        public PhotoLineItem(PhotoTypeChoices photoType, int quantity, FinishTypeChoices finishType, DeliveryTypeChoices deliveryType)
        {
            this.photoType = photoType;
            this.quantity = quantity;
            this.finishType = finishType;
            this.deliveryType = deliveryType;
        }

        public decimal LineRate
        {
            get { return lineRate; }
            set { lineRate = value; }
        }

        public decimal LineRate2
        {
            get { return lineRate2; }
            set { lineRate2 = value; }
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
        public DeliveryTypeChoices DeliveryType
        {
            get { return deliveryType; }
            set { deliveryType = value; }
        }

    }
 
}
