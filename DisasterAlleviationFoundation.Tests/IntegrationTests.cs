using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;
using DisasterAlleviationFoundation.Data;
using DisasterAlleviationFoundation.Models;
using System.Linq;

namespace DisasterAlleviationFoundation.Tests
{
    [TestClass]
    public class IntegrationTests
    {
        private ApplicationDbContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb_" + System.Guid.NewGuid())
                .Options;

            return new ApplicationDbContext(options);
        }

        [TestMethod]
        public void CanAddDisaster()
        {
            using var context = GetDbContext();
            var disaster = new Disaster
            {
                Name = "Flood",
                Description = "Severe flooding in region",
                Location = "Johannesburg",
                IsActive = true
            };
            context.Disasters.Add(disaster);
            context.SaveChanges();

            Assert.AreEqual(1, context.Disasters.Count());
            Assert.AreEqual("Flood", context.Disasters.First().Name);
        }

        [TestMethod]
        public void CanAddGoodsDonation()
        {
            using var context = GetDbContext();
            var donation = new GoodsDonation
            {
                DonorName = "John Smith",
                Description = "Clothes and blankets",
                Category = "Clothing",
                Quantity = 10
            };
            context.GoodsDonations.Add(donation);
            context.SaveChanges();

            Assert.AreEqual(1, context.GoodsDonations.Count());
            Assert.AreEqual("John Smith", context.GoodsDonations.First().DonorName);
        }

        [TestMethod]
        public void CanAddVolunteer()
        {
            using var context = GetDbContext();
            var volunteer = new Volunteer
            {
                FirstName = "Jane",
                LastName = "Doe",
                Email = "jane@example.com",
                Phone = "1234567890",
                Skills = "First Aid, Logistics"
            };
            context.Volunteers.Add(volunteer);
            context.SaveChanges();

            Assert.AreEqual(1, context.Volunteers.Count());
            Assert.AreEqual("Jane", context.Volunteers.First().FirstName);
        }
    }
}
