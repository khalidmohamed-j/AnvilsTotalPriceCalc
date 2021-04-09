using Microsoft.VisualStudio.TestTools.UnitTesting;
using SUT = CorrectedAnvilsTotalPriceCalc.PriceCalc;
using System;

namespace AcmeAnvilsTest
{
    [TestClass]
    public class CalcPricePerAnvil_Should
    {
        [DataTestMethod]
        [DataRow(0, 20, 0)]
        [DataRow(5, 0, 0)]
        [DataRow(9, 20, 20)]
        [DataRow(10, 20, 18)]
        [DataRow(19, 20, 18)]
        [DataRow(20, 20, 16)]
        [DataRow(200, 20, 16)]
        public void ReturnVolumeDiscounts_WhenVolumeDiscountQuantityIsMet(int quantity, double regPrice, double expected)
        {
            //Arrange
            double actual;

            //Act
            actual = SUT.CalcPricePerAnvil(quantity, regPrice);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }

    [TestClass]
    public class CalcShippingCostPerAnvil_Should
    {
        [DataTestMethod]
        [DataRow(1, 10)]
        [DataRow(2, 20)]
        [DataRow(3, 30)]
        public void ReturnCostForRequestedShippingZone_WhenZoneNumberIsSelected(int zone, double expected)
        {
            //Arrange
            double actual;

            //Act
            actual = SUT.CalcShippingCostPerAnvil(zone);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(4)]
        public void ReturnIndexOutOfRangeException_WhenAValueLessThanOneOrAValueGreaterThan3IsPutIn(int zone)
        {
            //Arrange, Act and Arrange
            Assert.ThrowsException<IndexOutOfRangeException>(() => SUT.CalcShippingCostPerAnvil(zone));
            
        }
    }
}
