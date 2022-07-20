using GeometryLibrary;

namespace GeometryTestProject
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void ZeroRadiusTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(0));
        }

        [TestMethod]
        public void MinusRadiusTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-1));
        }

        [TestMethod]
        public void GetSquareTest()
        {
            var radius = 10;
            var circle = new Circle(radius);
            var expectedValue = Math.PI * Math.Pow(radius, 2);

            var square = circle.Square();

            Assert.AreEqual(square, expectedValue);
        }
    }
}