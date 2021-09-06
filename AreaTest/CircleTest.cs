using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureArea;

namespace AreaTest
{
    public class CircleTest
    {
        public Сircle Сircle { get; set; }
        [SetUp]
        public void Setup()
        {
            Сircle = new Сircle(1.784);
        }

        [Test]
        public void CalculatingAare_forParams_AreEqual()
        {
            Сircle.CalculatingAare();
            Assert.AreEqual(Сircle.Area, 10);
        }
    }
}
