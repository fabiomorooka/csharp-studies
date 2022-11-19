namespace Calculator.GeometricFigures
{
    public class Rectangle : BaseFigure
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public override void CalculateArea()
        {
            this.Area = Height * Width;
        }

        public override void CalculatePerimeter()
        {
            this.Perimeter = 2 * (Width + Height);
        }
    }
}