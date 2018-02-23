using System;

namespace FactoryPattern.Code.FactoryMethod.Bad
{
    public enum CoordinateSystem
    {
        Cartesian,
        Polar
    }

    public class Point
    {
        private double x, y;

        public Point(double a, double b, CoordinateSystem system = CoordinateSystem.Cartesian)
        {
            switch (system)
            {
                case CoordinateSystem.Cartesian:
                    x = a;
                    y = b;
                    break;
                case CoordinateSystem.Polar:
                    x = a * Math.Cos(b);
                    y = b * Math.Sin(b);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}