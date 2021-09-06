using FigureArea;
using NUnit.Framework;

namespace AreaTest
{
    public class TriangleTest
    {
        public Triangle Triangle { get; set; }
        [SetUp]
        public void Setup()
        {
            Triangle = new Triangle(5, 4, 3);
        }

        [Test]
        public void CalculatingAare_forParams_AreEqual()
        {
            Triangle.CalculatingAare();

            Assert.AreEqual(Triangle.Area, 6);
        }
        [Test]
        public void IsRightAngled_forParams_AreEqual()
        {
            Assert.IsTrue(Triangle.IsRightAngled());
        }
    }
}
