using System;

namespace FactoryPattern.Code.FactoryMethod.Good
{
    public class Point
    {
        //factory method
        public static Point NewCartesianPoint(double a, double b)
        {
            return new Point(a, b);
        }

        public static Point NewPolarPoint(double rho, double theta)
        {
            return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
        }

        private double x, y;

        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}