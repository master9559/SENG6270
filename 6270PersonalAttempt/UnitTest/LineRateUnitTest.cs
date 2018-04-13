using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6270PersonalAttempt.UnitTest
{
    [TestFixture]
    class LineRateUnitTest
    {

        [TestCase]
        public void standard_rate_equivelance_tests()
        {
            //Working Through 4x6 Base Rate
            Assert.AreEqual(.14M, getLineRate(PhotoTypeChoices.fourbysix, 15, FinishTypeChoices.glossy));
            Assert.AreEqual(.12M, getLineRate(PhotoTypeChoices.fourbysix, 65, FinishTypeChoices.glossy));
            Assert.AreEqual(.10M, getLineRate(PhotoTypeChoices.fourbysix, 95, FinishTypeChoices.glossy));
            //Working Through 5x7 Base Rate
            Assert.AreEqual(.34M, getLineRate(PhotoTypeChoices.fivebyseven, 15, FinishTypeChoices.glossy));
            Assert.AreEqual(.31M, getLineRate(PhotoTypeChoices.fivebyseven, 65, FinishTypeChoices.glossy));
            Assert.AreEqual(.28M, getLineRate(PhotoTypeChoices.fivebyseven, 95, FinishTypeChoices.glossy));
            //Working Through 8X10 Base Rate
            Assert.AreEqual(.68M, getLineRate(PhotoTypeChoices.eightbyten, 15, FinishTypeChoices.glossy));
            Assert.AreEqual(.64M, getLineRate(PhotoTypeChoices.eightbyten, 65, FinishTypeChoices.glossy));
            Assert.AreEqual(.60M, getLineRate(PhotoTypeChoices.eightbyten, 95, FinishTypeChoices.glossy));

            //Working Through 4x6 Matte Rate
            Assert.AreEqual(.16M, getLineRate(PhotoTypeChoices.fourbysix, 15, FinishTypeChoices.matte));
            Assert.AreEqual(.14M, getLineRate(PhotoTypeChoices.fourbysix, 65, FinishTypeChoices.matte));
            Assert.AreEqual(.12M, getLineRate(PhotoTypeChoices.fourbysix, 95, FinishTypeChoices.matte));
            //Working Through 5x7 Glossy Rate
            Assert.AreEqual(.37M, getLineRate(PhotoTypeChoices.fivebyseven, 15, FinishTypeChoices.matte));
            Assert.AreEqual(.34M, getLineRate(PhotoTypeChoices.fivebyseven, 65, FinishTypeChoices.matte));
            Assert.AreEqual(.31M, getLineRate(PhotoTypeChoices.fivebyseven, 95, FinishTypeChoices.matte));
            //Working Through 8X10 Glossy Rate
            Assert.AreEqual(.72M, getLineRate(PhotoTypeChoices.eightbyten, 15, FinishTypeChoices.matte));
            Assert.AreEqual(.68M, getLineRate(PhotoTypeChoices.eightbyten, 65, FinishTypeChoices.matte));
            Assert.AreEqual(.64M, getLineRate(PhotoTypeChoices.eightbyten, 95, FinishTypeChoices.matte));

        }

        [TestCase]
        public void one_hour_processing_tests()
        {
            //Standard Order, all one size
            PhotoLineItem lineItem = new PhotoLineItem(PhotoTypeChoices.fourbysix, 15, FinishTypeChoices.glossy, OrderType.standard);
            LineRate lineRate = new LineRatesStandard(lineItem);
            DeliveryRateFee deliveryFee = new DeliveryRateFee();
            deliveryFee.setFee(new List<PhotoLineItem> { lineItem }, DeliveryTypeChoices.oneHour, OrderType.standard);
            Assert.AreEqual(1, deliveryFee.Amount);
        }

        private decimal getLineRate(PhotoTypeChoices photoType, int qty, FinishTypeChoices finish)
        {
            return new LineRatesStandard(new PhotoLineItem(photoType, qty, finish, OrderType.standard)).getLineRate();
        }
    }
}
