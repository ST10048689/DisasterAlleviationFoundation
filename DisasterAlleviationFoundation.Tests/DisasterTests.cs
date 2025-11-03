using Microsoft.VisualStudio.TestTools.UnitTesting;
using DisasterAlleviationFoundation.Models;
using System;

namespace DisasterAlleviationFoundation.Tests
{
    [TestClass]
    public class DisasterTests
    {
        [TestMethod]
        public void Disaster_Creation_ShouldSetProperties()
        {
            var disaster = new Disaster
            {
                Name = "Flood",
                Description = "Severe flooding in town",
                Location = "Cape Town",
                IsActive = true,
                StartDate = new DateTime(2025, 10, 1)
            };

            Assert.AreEqual("Flood", disaster.Name);
            Assert.AreEqual("Severe flooding in town", disaster.Description);
            Assert.AreEqual("Cape Town", disaster.Location);
            Assert.IsTrue(disaster.IsActive);
            Assert.AreEqual(new DateTime(2025, 10, 1), disaster.StartDate);
        }
    }
}
