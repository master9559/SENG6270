using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6270PersonalAttempt
{
    /// <summary>
    /// Processing totals here..
    /// </summary>
    class Order
    {
        private List<PhotoLineItem> lines;
        private List<Discount> discounts;
        private List<Fee> fees;
        public Order()
        {
            lines = new List<PhotoLineItem>();
            discounts = new List<Discount>();
            fees = new List<Fee>();
        }

        public List<PhotoLineItem> Lines
        {
            get { return lines; }
        }

        public List<Discount> Discount
        {
            get { return discounts; }
        }

        public List<Fee> Fee
        {
            get { return fees; }
        }

        //tried using :base() but it still gave an error so i took the lazy (bad) way out and copied the constructor.
        public Order(PhotoLineItem line, Discount discount, Fee fee)
        {
            lines = new List<PhotoLineItem>();
            discounts = new List<Discount>();
            fees = new List<Fee>();
            lines.Add(line);
            discounts.Add(discount);
            fees.Add(fee);
        }
        public void addLine(PhotoLineItem item)
        {
            if (item.LineRate <= 0)
            {
                throw new System.ArgumentException("Parameter not entered", "lineRate");
            }
            lines.Add(item);
        }
        public void addDiscount(Discount discount)
        {
            if (discount.getTotalDiscount() > 0)
            {
                discounts.Add(discount);
            }
        }
        public void addFee(Fee fee)
        {
            if (fee.Amount > 0)
                fees.Add(fee);
        }

        public void addFee(DeliveryTypeChoices deliveryType, OrderType orderType)
        {
            addFee(new DeliveryRateFee(lines, deliveryType, orderType));
        }
        public decimal getCurrentTotal()
        {
            decimal total = getLinesTotal();
            total += getFees();
            return total;
        }
        public decimal getTotal()
        {
            decimal total = getLinesTotal();
            total += getFees();
            total -= getDiscountTotal(total);
            

            return total;
        }

        public string GetReceipt() {
            return Receipt.buildReceipt(this);
        }

        private decimal getLinesTotal()
        {
            decimal total = 0;
            foreach (var line in lines)
            {
                total += line.Quantity * line.LineRate;
            }
            return total;
        }
        private decimal getFees()
        {
            decimal total = 0;
            foreach (var fee in fees)
            {
                total += fee.Amount;
            }
            return total;
        }
        public decimal getDiscountTotal(decimal currentTotal)
        {
            decimal total = 0;
            decimal otherDiscounts = getTotalDiscounts();
            if (currentTotal <= 35)
            {
                total += otherDiscounts;
            } else
            {
                decimal orderSizeDiscount = currentTotal * .05M;
                if (orderSizeDiscount > otherDiscounts)
                {
                    total += orderSizeDiscount;
                } else
                {
                    total += otherDiscounts;
                }
            }
            return total;
        }

        private decimal getTotalDiscounts()
        {
            decimal total = 0M;
            foreach (var discount in discounts)
            {
                total += discount.getTotalDiscount();
            }
            return total;

        } 
    }
}
