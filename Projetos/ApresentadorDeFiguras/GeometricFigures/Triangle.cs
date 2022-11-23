namespace FigureDisplayer.GeometricFigures
{
    public class Triangle : BaseFigure
    {
        public double Base { get; private set; }

        public double height { get; private set; }

        public Triangle(double triBase, double height)
        {
            Base = triBase;
            this.height = height;
        }

        public override void CalculateArea()
        {
            Area = Base * height / 2;
        }

        public override void CalculatePerimeter()
        {
            Perimeter = 3 * Base;
        }
    }
}