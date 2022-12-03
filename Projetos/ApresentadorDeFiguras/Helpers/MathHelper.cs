namespace FigureDisplayerApp.Helpers
{
    public class MathHelper
    {
        private const double _pi = Math.PI;
        public static double GetPiValue()
        {
            return _pi;
        }
        public static double TransformDegreeInRadians(double angleInDegree)
        {
            return angleInDegree * (_pi / 180);
        }
    }
}