using System;
using NUnit.Framework;

namespace HolidayTests
{
    [TestFixture]
    public class HolidayTest
    {
        private HolidayForTest _holiday;

        [SetUp]
        public void SetUp()
        {
            _holiday = new HolidayForTest();
        }

        private void GivenToday(int month, int day) {
            _holiday.Today = new DateTime(DateTime.Now.Year, month, day);
        }

        private void ResponseShouldBe(string expected)
        {
            Assert.AreEqual(expected, _holiday.IsXmas());
        }

        [Test]
        public void Today_Is_Xmas()
        {
            GivenToday(12, 25);
            ResponseShouldBe("Merry Xmas");

        }

        [Test]
        public void Today_Is_Not_Xmas()
        {
            GivenToday(11, 25);
            ResponseShouldBe("Today is not Xmas");
        }

        private class HolidayForTest : Lib.HoildayService
        {
            private DateTime _today;
            protected override DateTime GetToday()
            {
                return _today;
            }

            public DateTime Today { set => _today = value; }


        }
    }
}