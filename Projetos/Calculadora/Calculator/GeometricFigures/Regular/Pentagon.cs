namespace Calculator.GeometricFigures.Regular
{
    public class Pentagon : BaseFigure
    {
        private const double _pi = Math.PI;
        public double Side { get; set; }

        public override void CalculateArea()
        {
            Area = 5 * (Math.Pow(Side, 2)/(4*Math.Tan(TransformDegreeInRadians(36))));
        }

        public override void CalculatePerimeter()
        {
            Perimeter = 5 * Side;
        }

        private double TransformDegreeInRadians(double angleInDegree)
        {
            return angleInDegree * (_pi / 180);
        }
    }
}