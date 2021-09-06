using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class Сircle:Figure
    {
        public double Radius { get; private set; }
        private const double pi = 3.14;
        public Сircle(double radius)
        {
            Radius = radius;
        }
        public double CalculatingAare()
        {
            Area = Math.Round(Math.Pow(Radius, 2)  * pi);
            return Area;
        }
    }
}
