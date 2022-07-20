using GeometryLibrary;

namespace GeometryTestProject
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void ZeroSideTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(6, 8, 0));
        }
        [TestMethod]
        public void UncorrectSideTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 8, 10));
        }

        [TestMethod]
        public void MinusSideTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-6, 8, 10));
        }

        [TestMethod]
        public void GetRightSquareTest()
        {
            double a = 6, b = 8, c = 10;
            var triangle = new Triangle(a, b, c);
            double expectedValue = 24;

            var square = triangle.Square();
            bool isRight = triangle.IsRightTriangle;

            Assert.AreEqual(square, expectedValue);
            Assert.AreEqual(isRight, true);
        }
    }
}
