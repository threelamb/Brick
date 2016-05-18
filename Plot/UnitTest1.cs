using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Plot
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string a = string.Empty;
            Type t = typeof(string);
            if (t.IsPrimitive)
            {

            }
        }

        [TestMethod]
        public void TestLocalTimeToUTC()
        {
            DateTime now = DateTime.Now;
            DateTime start = new DateTime(now.Year, now.Month, now.Day, 23, 00, 0);
            DateTime end = new DateTime(now.Year, now.Month, now.Day, 3, 30, 0);
            DateTime utcStart = start.ToUniversalTime();
            DateTime utcEnd = end.ToUniversalTime();
            string utcStartString = utcStart.ToString("hh:mm");
            string utcEndString = utcEnd.ToString("hh:mm");
        }

        [TestMethod]
        public void TestUTCTimeToLocal()
        {
            DateTime now = DateTime.Now;
            DateTime start = new DateTime(now.Year, now.Month, now.Day, 23, 00, 0, DateTimeKind.Utc);
            DateTime end = new DateTime(now.Year, now.Month, now.Day + 1, 3, 30, 0, DateTimeKind.Utc);
            DateTime localStart = start.ToLocalTime();
            DateTime localEnd = end.ToLocalTime();
            string localStartString = localStart.ToString("hh:mm");
            string localEndString = localEnd.ToString("hh:mm");
        }
    }
}
