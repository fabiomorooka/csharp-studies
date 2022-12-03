namespace FigureDisplayer.GeometricFigures.Regular
{
    public class EquilateralTriangle : BaseFigure
    {
        public double side { get; private set; }

        public EquilateralTriangle(double side)
        {
            this.side = side;
        }

        public EquilateralTriangle(string color, double side)
        {
            this.color = color;
            this.side = side;
        }

        public override void CalculateArea()
        {
            Area = (this.side * (this.side * Math.Sqrt(3))) / 4;
        }

        public override void CalculatePerimeter()
        {
            Perimeter = 3 * this.side;
        }
    }
}