using FigureDisplayer.Helpers;

namespace FigureDisplayer.GeometricFigures
{
    public class Circle : BaseFigure
    {
        private double _pi = MathHelper.GetPiValue();
        public double radius { get; private set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override void CalculateArea()
        {
            this.Area = _pi * Math.Pow(radius, 2);
        }

        public override void CalculatePerimeter()
        {
            this.Perimeter = 2 * _pi * radius;
        }
    }
}