using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureArea;

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
    }
}
