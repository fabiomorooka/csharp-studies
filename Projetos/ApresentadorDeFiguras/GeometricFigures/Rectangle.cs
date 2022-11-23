namespace FigureDisplayer.GeometricFigures
{
    public class Rectangle : BaseFigure
    {
        public double height { get; private set; }
        public double width { get; private set; }

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public override void CalculateArea()
        {
            this.Area = this.height * this.width;
        }

        public override void CalculatePerimeter()
        {
            this.Perimeter = 2 * (this.height + this.width);
        }
    }
}