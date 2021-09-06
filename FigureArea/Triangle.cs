using System;

namespace FigureArea
{
    public class Triangle : Figure
    {
        public double FirstSide { get; private set; }
        public double SecondSide { get; private set; }
        public double ThirdSide { get; private set; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }
        public double CalculatingAare()
        {
            var semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
            var valueUnderSqrt = semiPerimeter * (semiPerimeter - FirstSide) * (semiPerimeter - SecondSide) * (semiPerimeter - ThirdSide);
            Area = Math.Sqrt(valueUnderSqrt);
            return Area;
        }
        public bool IsRightAngled()
        {
            if (FirstSide > SecondSide)
            {
                if (FirstSide > ThirdSide)
                {

                    return Math.Pow(FirstSide, 2) == (Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2));
                }
                else
                {
                    return Math.Pow(ThirdSide, 2) == (Math.Pow(SecondSide, 2) + Math.Pow(FirstSide, 2));

                }
            }
            else
            {
                if (SecondSide > ThirdSide)
                {
                    return Math.Pow(SecondSide, 2) == (Math.Pow(FirstSide, 2) + Math.Pow(ThirdSide, 2));

                }
                else
                {
                    return Math.Pow(ThirdSide, 2) == (Math.Pow(SecondSide, 2) + Math.Pow(FirstSide, 2));

                }

            }

        }


    }
}
