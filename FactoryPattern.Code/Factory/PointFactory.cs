using System;

namespace FactoryPattern.Code.Factory
{
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