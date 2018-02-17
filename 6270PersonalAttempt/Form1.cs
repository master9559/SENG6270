using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6270PersonalAttempt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setOriginalSettings();
           
        }

        private void setOriginalSettings()
        {
            photoTypeStandard.SelectedIndex = 0;
            deliveryTypeStandard.SelectedIndex = 1;
            photoSizeByPrint.SelectedIndex = 0;
            deliveryTypeByPrint.SelectedIndex = 1;
            finishStandard.SelectedIndex = 0;
        }
        /// <summary>
        /// I tried to build it in a way that much could be
        /// reused for the order by piece.  We didn't have
        /// the name uniform prints yet.  All of that can and
        /// should be refactored.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void placeOrderStandard_Click(object sender, EventArgs e)
        {
            //Get elements from form
            PhotoLineItem lineItem = new PhotoLineItem((PhotoTypeChoices)photoTypeStandard.SelectedIndex, (int)qtyStandard.Value,
                 (FinishTypeChoices)finishStandard.SelectedIndex);
            DeliveryTypeChoices deliveryChoice = (DeliveryTypeChoices)deliveryTypeStandard.SelectedIndex;
            
            //Get Line Rate, discounts and fees
            LineRatesStandard rate = new LineRatesStandard(lineItem);
            lineItem.LineRate = rate.getLineRate();

            PromoDiscount promoDiscount = new PromoDiscount();
            promoDiscount.CalculateDiscount(lineItem, promoCodeTxt.Text);

            DeliveryRateFee deliveryFee = new DeliveryRateFee();
            deliveryFee.setFee(new List<PhotoLineItem> { lineItem }, deliveryChoice, OrderType.standard);

            //build the order
            Order order = new Order(lineItem, promoDiscount, deliveryFee);

            MessageBox.Show(Receipt.buildReceipt(order));
            

            

            //Calculate Total


//            MessageBox.Show("BaseRate: " + rate.getBaseRate() + "\nDeliveryUpcharge: " + rate.getDeliveryRateUpcharge() +
//                "\nFinishUpcarge: " + rate.getFinishTypeUpcharge());
        }
    }
}
