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
        Order listorder = new Order();

        public Form1()
        {
            InitializeComponent();
            setOriginalSettings();
            orderListView.Visible = false;
            placeOrderByPiece.Visible = false;
            Height = 410;
        }

        private void setOriginalSettings()
        {
            photoTypeStandard.SelectedIndex = 0;
            deliveryTypeStandard.SelectedIndex = 1;
            photoSizeByPrint.SelectedIndex = 0;
            deliveryTypeByPrint.SelectedIndex = 1;
            finishStandard.SelectedIndex = 0;
            printTypePiece.SelectedIndex = 0;
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
            PhotoLineItem lineItem = new PhotoLineItem(
                (PhotoTypeChoices)photoTypeStandard.SelectedIndex, 
                (int)qtyStandard.Value,
                (FinishTypeChoices)finishStandard.SelectedIndex,
                OrderType.byPiece);
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

        private void placeOrderByPiece_Click(object sender, EventArgs e)
        {
            //Add fee here first...
            DeliveryRateFee deliveryFee = new DeliveryRateFee();
            deliveryFee.setFee(listorder.Lines, (DeliveryTypeChoices)deliveryTypeByPrint.SelectedIndex, OrderType.byPiece);
            listorder.addFee(deliveryFee);
            
            MessageBox.Show(listorder.GetReceipt());
            //clear();
        }

        private void clearOrder_Click(object sender, EventArgs e)
        {
            clear();
            
        }

        private void clear()
        {
            listorder = new Order();
            orderListView.Items.Clear();
            addLineButton.Enabled = true;
            qtyByPrint.Maximum = 100;
            qtyByPrint.Minimum = 1;
            qtyByPrint.Value = 1;
        }

        private void addLineButton_Click(object sender, EventArgs e)
        {
            PhotoLineItem lineItem = new PhotoLineItem(
                (PhotoTypeChoices)photoSizeByPrint.SelectedIndex,
                (int)qtyByPrint.Value,
                (FinishTypeChoices)printTypePiece.SelectedIndex,
                OrderType.byPiece);

            //deliveryTypeByPrint
            listorder.addLine(lineItem);
            
            orderListView.Items.Add(new ListViewItem(new string[] {
                lineItem.PhotoType.ToString(),
                lineItem.FinishType.ToString(),
                lineItem.LineRate.ToString(),
                lineItem.Quantity.ToString()}));

            qtyByPrint.Maximum = 100 - listorder.getTotalQuantity();
            if (qtyByPrint.Maximum <= 0)
            {
                addLineButton.Enabled = false;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            bool vis = tabControl1.SelectedIndex == 1;

            orderListView.Visible = vis;
            placeOrderByPiece.Visible = vis;
            Height = vis ? 675 : 410;
        }
    }
}
