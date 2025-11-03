using Microsoft.VisualStudio.TestTools.UnitTesting;
using DisasterAlleviationFoundation.Models;
using System;

namespace DisasterAlleviationFoundation.Tests
{
    [TestClass]
    public class VolunteerTests
    {
        [TestMethod]
        public void Volunteer_Creation_ShouldSetProperties()
        {
            var volunteer = new Volunteer
            {
                FirstName = "Jane",
                LastName = "Doe",
                Email = "jane.doe@example.com",
                Phone = "0812345678",
                Skills = "First Aid",
                RegistrationDate = DateTime.Now
            };

            Assert.AreEqual("Jane", volunteer.FirstName);
            Assert.AreEqual("Doe", volunteer.LastName);
            Assert.AreEqual("jane.doe@example.com", volunteer.Email);
            Assert.AreEqual("0812345678", volunteer.Phone);
            Assert.AreEqual("First Aid", volunteer.Skills);
        }
    }
}
