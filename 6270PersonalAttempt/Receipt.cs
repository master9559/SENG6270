using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6270PersonalAttempt
{
    class Receipt
    {
        /// <summary>
        /// I remember that C# has a some nice string formatting
        /// syntax, but I haven't used it in a couple years, so 
        /// that is more work to be done.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public static string buildReceipt(Order order)
        {
            string receiptText = "Receipt:\n";

            foreach (PhotoLineItem line in order.Lines)
            {
                receiptText += "\n " + line.Quantity + "\t" + line.PhotoType + "\t\t" + line.LineRate;
            }

            foreach (Fee fee in order.Fee)
            {
                receiptText += "\nFees      " + fee.Amount;
            }

            

            foreach (Discount discount in order.Discount)
            {
                receiptText += "\n\tDiscounts\t-" + discount.getTotalDiscount();
            }

            receiptText += "\nOrder Total: " + order.getTotal();

            return receiptText;
        }
    }
}
