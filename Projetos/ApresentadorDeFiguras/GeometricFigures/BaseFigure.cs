namespace FigureDisplayerApp.GeometricFigures
{
    public abstract class BaseFigure
    {
        public string? color { get; set; }
        public double Area { get; set; }

        public double Perimeter { get; set; }

        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();
    }
}