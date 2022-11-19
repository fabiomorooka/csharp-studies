namespace Calculator.GeometricFigures.Regular
{
    public class Square : BaseFigure
    {
        public double Side { get; set; }

        public override void CalculateArea()
        {
            Area = Side * Side;
        }

        public override void CalculatePerimeter()
        {
            Perimeter = 4 * Side;
        }
    }
}