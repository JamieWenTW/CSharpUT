using System;
using NUnit.Framework;

namespace HolidayTests
{
    [TestFixture]
    public class HolidayTest
    {
        [Test]
        public void Today_Is_Xmas()
        {
            var hoilday = new HolidayForTest();
            hoilday.Today = new DateTime(DateTime.Now.Year, 12, 25);
            Assert.AreEqual("Merry Xmas", hoilday.IsXmas());

        }

        [Test]
        public void Today_Is_Not_Xmas()
        {
            var hoilday = new Lib.HoildayService();
            Assert.AreEqual("Today is not Xmas", hoilday.IsXmas());
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