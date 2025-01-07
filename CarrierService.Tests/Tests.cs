using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarrierService.Tests
{
    [TestClass]
    public sealed class Tests
    {
        [TestMethod]
        public void TestGetMockRates()
        {
            // Arrange
            var expectedRates = new List<DTORate>
            {
                new DTORate
                {
                    ServiceName = "canadapost-overnight",
                    ServiceCode = "ON",
                    TotalPrice = "1295",
                    Description = "This is the fastest option by far",
                    Currency = "CAD",
                    MinDeliveryDate = DateTime.Parse("2013-04-12 14:48:45 -0400"),
                    MaxDeliveryDate = DateTime.Parse("2013-04-12 14:48:45 -0400")
                },
                new DTORate
                {
                    ServiceName = "fedex-2dayground",
                    ServiceCode = "2D",
                    TotalPrice = "2934",
                    Currency = "USD",
                    MinDeliveryDate = DateTime.Parse("2013-04-12 14:48:45 -0400"),
                    MaxDeliveryDate = DateTime.Parse("2013-04-12 14:48:45 -0400")
                },
                new DTORate
                {
                    ServiceName = "fedex-priorityovernight",
                    ServiceCode = "1D",
                    TotalPrice = "3587",
                    Currency = "USD",
                    MinDeliveryDate = DateTime.Parse("2013-04-12 14:48:45 -0400"),
                    MaxDeliveryDate = DateTime.Parse("2013-04-12 14:48:45 -0400")
                }
            };

            var rateFactory = new RateFactory(new RateRequestDetails());

            // Act
            var actualRates = rateFactory.GetMockRates().Select(rate => (DTORate)rate).ToList();

            // Assert
            Assert.AreEqual(expectedRates.Count, actualRates.Count);

            for (int i = 0; i < expectedRates.Count; i++)
            {
                Assert.AreEqual(expectedRates[i].ServiceName, actualRates[i].ServiceName);
                Assert.AreEqual(expectedRates[i].ServiceCode, actualRates[i].ServiceCode);
                Assert.AreEqual(expectedRates[i].TotalPrice, actualRates[i].TotalPrice);
                Assert.AreEqual(expectedRates[i].Description, actualRates[i].Description);
                Assert.AreEqual(expectedRates[i].Currency, actualRates[i].Currency);
                Assert.AreEqual(expectedRates[i].MinDeliveryDate, actualRates[i].MinDeliveryDate);
                Assert.AreEqual(expectedRates[i].MaxDeliveryDate, actualRates[i].MaxDeliveryDate);
            }
        }
    }
}