using FigureDisplayer.Helpers;

namespace FigureDisplayer.GeometricFigures.Regular
{
    public class Pentagon : BaseFigure
    {
        public double side { get; private set; }

        public Pentagon(double side)
        {
            this.side = side;
        }
        public Pentagon(string color, double side)
        {
            this.color = color;
            this.side = side;
        }


        public override void CalculateArea()
        {
            Area = 5 * (Math.Pow(this.side, 2) / (4 * Math.Tan(MathHelper.TransformDegreeInRadians(36))));
        }

        public override void CalculatePerimeter()
        {
            Perimeter = 5 * this.side;
        }
    }
}