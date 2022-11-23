namespace FigureDisplayer.GeometricFigures.Regular
{
    public class Square : BaseFigure
    {
        public double side { get; private set; }

        public Square(double side)
        {
            this.side = side;
        }

        public override void CalculateArea()
        {
            Area = this.side * this.side;
        }

        public override void CalculatePerimeter()
        {
            Perimeter = 4 * this.side;
        }
    }
}