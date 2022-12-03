namespace FigureDisplayerApp.GeometricFigures
{
    public class IsoscelesTriangle : BaseFigure
    {
        public double equalSide { get; private set; }

        public double differentSide { get; private set; }

        public IsoscelesTriangle(double equalSide, double differentSide)
        {
            this.equalSide = equalSide;
            this.differentSide = differentSide;
        }

        public IsoscelesTriangle(string color, double equalSide, double differentSide)
        {
            this.color = color;
            this.equalSide = equalSide;
            this.differentSide = differentSide;
        }

        public override void CalculateArea()
        {
            Area = Math.Sqrt(Math.Pow(this.equalSide, 2) - (Math.Pow(this.differentSide, 2) / 4)) * (this.differentSide/2);
        }

        public override void CalculatePerimeter()
        {
            Perimeter = 2 * this.equalSide + this.differentSide;
        }
    }
}