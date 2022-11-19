namespace Calculator.GeometricFigures.Regular
{
    public class Hexagon : BaseFigure
    {
        public double Side { get; set; }

        public override void CalculateArea()
        {
            Area = 1.5 * Math.Pow(Side, 2) * Math.Sqrt(3);
        }

        public override void CalculatePerimeter()
        {
            Perimeter = 6 * Side;
        }
    }
}