namespace FigureDisplayer.GeometricFigures
{
    public class Rhombus : BaseFigure
    {
        public double majorDiagonal { get; private set; }
        public double minorDiagonal { get; private set; }

        public Rhombus(double majorDiagonal, double minorDiagonal)
        {
            this.majorDiagonal = majorDiagonal;
            this.minorDiagonal = minorDiagonal;
        }

        public Rhombus(string color, double majorDiagonal, double minorDiagonal)
        {
            this.color = color;
            this.majorDiagonal = majorDiagonal;
            this.minorDiagonal = minorDiagonal;
        }

        public override void CalculateArea()
        {
            this.Area = (this.majorDiagonal * this.minorDiagonal) / 2;
        }

        public override void CalculatePerimeter()
        {
            this.Perimeter = 4 * (Math.Sqrt(Math.Pow((this.majorDiagonal) / 2, 2) + Math.Pow((this.minorDiagonal) / 2, 2)));
        }
    }
}