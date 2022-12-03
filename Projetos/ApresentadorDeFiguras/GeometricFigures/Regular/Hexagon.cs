namespace FigureDisplayerApp.GeometricFigures.Regular
{
    public class Hexagon : BaseFigure
    {
        public double side { get; private set; }

        public Hexagon(double side)
        {
            this.side = side;
        }

        public Hexagon(string color, double side)
        {
            this.color = color;
            this.side = side;
        }

        public override void CalculateArea()
        {
            Area = 1.5 * Math.Pow(this.side, 2) * Math.Sqrt(3);
        }

        public override void CalculatePerimeter()
        {
            Perimeter = 6 * this.side;
        }
    }
}