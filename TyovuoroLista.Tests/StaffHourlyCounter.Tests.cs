using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TyovuoroLista;

namespace TyovuoroLista.Tests
{
	[TestFixture]
    public class StaffHourlyCounterTests
    {
        [TestCase]
        public void TestShiftDayChanging()
        {
            StaffHourlyCounter staffCounter = new StaffHourlyCounter();

            List<int> expectedHours = new List<int>() { 18, 19, 20, 21, 22, 23, 0, 1 };
            List<int> actualHours = staffCounter.GetHoursOfShift("18:00 - 01:30");

            Assert.AreEqual(expectedHours, actualHours);
        }

        [TestCase]
        public void TestShiftHours()
        {
            StaffHourlyCounter staffCounter = new StaffHourlyCounter();

            List<int> expectedHours = new List<int>() { 14, 15, 16, 17, 18, 19, 20, 21 };
            List<int> actualHours = staffCounter.GetHoursOfShift("14:00 - 22:00");

            Assert.AreEqual(expectedHours, actualHours);
        }

        [TestCase]
        public void TestShiftStartingAfterHalfPast()
        {
            StaffHourlyCounter staffCounter = new StaffHourlyCounter();

            List<int> expectedHours = new List<int>() { 16, 17, 18, 19, 20 };
            List<int> actualHours = staffCounter.GetHoursOfShift("15:30 - 21:00");

            Assert.AreEqual(expectedHours, actualHours);
        }

        [TestCase]
        public void TestShiftStartingBeforeHalfPast()
        {
            StaffHourlyCounter staffCounter = new StaffHourlyCounter();

            List<int> expectedHours = new List<int>() { 15, 16, 17, 18, 19, 20 };
            List<int> actualHours = staffCounter.GetHoursOfShift("15:29 - 21:00");

            Assert.AreEqual(expectedHours, actualHours);
        }

        [TestCase]
        public void TestGetShiftDurationDayChanging()
        {
            StaffHourlyCounter staffCounter = new StaffHourlyCounter();

            double expected = 8;
            double actual = staffCounter.GetShiftDuration("22:00 - 06:00");

            Assert.AreEqual(expected, actual);
        }

        [TestCase]
        public void TestGetShiftDurationSevenAndHalfEqualsEightHours()
        {
            StaffHourlyCounter staffCounter = new StaffHourlyCounter();

            double expected = 8;
            double actual = staffCounter.GetShiftDuration("18:00 - 01:30");

            Assert.AreEqual(expected, actual);
        }

        [TestCase]
        public void TestGetShiftDuration()
        {
            StaffHourlyCounter staffCounter = new StaffHourlyCounter();

            double expected = 5;
            double actual = staffCounter.GetShiftDuration("17:00 - 22:00");

            Assert.AreEqual(expected, actual);
        }
    }
}
