using System;
using BikeRental.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BikeRentalTest
{
    [TestClass]
    public class UnitTest1
    {
        Rental r;
        public UnitTest1()
        {
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException),
         "A hour value was inappropriately allowed.")]
        public void HourInvalid()
        {
            r = new HourRental(2, 0, "John", "Doe", 4545454, 35645987);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException),
       "A day value was inappropriately allowed.")]
        public void DayInvalid()
        {
            r = new DayRental(2, 9, "John", "Doe", 4545454, 35645987);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException),
         "A bike value was inappropriately allowed.")]
        public void BikeInvalid()
        {
            r = new DayRental(0, 2, "John", "Doe", 4545454, 35645987);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException),
         "Rents number was inappropriately allowed.")]
        public void TestByFamilyRentalInvalid()
        {
            FamilyRental rf = new FamilyRental();
            rf.AddRental(CreateHourRental());
            rf.AddRental(CreateDayRental());
            rf.AddRental(CreateWeekRental());
            Assert.AreEqual(rf.Rent(), 63);
        }

        [TestMethod]
        public void TestByHourRental()
        {
            r = CreateHourRental();
            Assert.AreEqual(r.Rent(), 30);
        }

        [TestMethod]
        public void TestByDayRental()
        {
            r = CreateDayRental();
            Assert.AreEqual(r.Rent(), 60);
        }


        [TestMethod]
        public void TestByWeekRental()
        {
            r = CreateWeekRental();
            Assert.AreEqual(r.Rent(), 240);
        }


        [TestMethod]
        public void TestByFamilyRental()
        {
            FamilyRental fr = new FamilyRental();
            fr.AddRental(CreateHourRental());
            fr.AddRental(CreateDayRental());
            Assert.AreEqual(fr.Rent(), 63);
        }

        private Rental CreateHourRental()
        {
            return new HourRental(2, 3, "John", "Doe", 4545454, 35645987);
        }

        private Rental CreateDayRental()
        {
            return new DayRental(3, 1, "Jane", "Doe", 4545454, 35645988);
        }

        private Rental CreateWeekRental()
        {
            return new WeekRental(1, 4, "Bruce", "Wayne", 4545454, 35645989);
        }
    }
}
