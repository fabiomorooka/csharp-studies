namespace Calculator.GeometricFigures
{
    public class Rhombus : BaseFigure
    {
        public double MajorDiagonal { get; set; }
        public double MinorDiagonal { get; set; }

        public override void CalculateArea()
        {
            this.Area = (MajorDiagonal * MinorDiagonal)/2;
        }

        public override void CalculatePerimeter()
        {
            this.Perimeter = 4 * (Math.Sqrt(Math.Pow(MajorDiagonal, 2) + Math.Pow(MinorDiagonal, 2)));
        }
    }
}