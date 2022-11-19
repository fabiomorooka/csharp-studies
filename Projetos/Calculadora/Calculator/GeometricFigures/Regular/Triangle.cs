namespace Calculator.GeometricFigures.Regular
{
    public class Triangle : BaseFigure
    {
        public double Base { get; set; }

        public double Height { get; set; }

        public override void CalculateArea()
        {
            Area = (Base * Height)/2;
        }

        public override void CalculatePerimeter()
        {
            Perimeter = 3 * Base;
        }
    }
}