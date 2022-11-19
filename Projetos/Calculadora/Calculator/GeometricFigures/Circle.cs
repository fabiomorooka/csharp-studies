namespace Calculator.GeometricFigures
{
    public class Circle : BaseFigure
    {

        private const double _pi = Math.PI;
        public double radius { get; set; }

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