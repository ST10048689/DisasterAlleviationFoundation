using Microsoft.VisualStudio.TestTools.UnitTesting;
using DisasterAlleviationFoundation.Models;
using System;

namespace DisasterAlleviationFoundation.Tests
{
    [TestClass]
    public class GoodsDonationTests
    {
        [TestMethod]
        public void GoodsDonation_Creation_ShouldSetProperties()
        {
            var donation = new GoodsDonation
            {
                DonorName = "John Doe",
                Description = "Blankets",
                Category = "Essential",
                Quantity = 50,
                DonationDate = DateTime.Now
            };

            Assert.AreEqual("John Doe", donation.DonorName);
            Assert.AreEqual("Blankets", donation.Description);
            Assert.AreEqual("Essential", donation.Category);
            Assert.AreEqual(50, donation.Quantity);
        }
    }
}
