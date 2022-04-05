using FluentAssertions;
using NUnit.Framework;


namespace MarsRovers.UnitTest
{
     public static class PointTest
    {
        [Test]
        public static void PointShouldBeSame()
        {
            Point p1 = new Point(1, 2);
            Point p2 = new Point(1, 2);
            Assert.AreEqual(p1, p2);
        }

    }
}
