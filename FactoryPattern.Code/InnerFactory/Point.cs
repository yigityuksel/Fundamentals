using System;

namespace FactoryPattern.Code.InnerFactory
{
    public class Point
    {

        private double x, y;

        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
        }

        public static Point Origin => new Point(0, 0);
        public static Point Origin2 = new Point(0, 0); // better

        public static class PointFactory
        {
            public static Point NewCartesianPoint(double a, double b)
            {
                return new Point(a, b);
            }

            public static Point NewPolarPoint(double rho, double theta)
            {
                return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
            }
        }

    }
}