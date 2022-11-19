namespace Calculator.GeometricFigures
{
    public abstract class BaseFigure
    {
        public double Area { get; set; }

        public double Perimeter { get; set; }

        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();
    }
}