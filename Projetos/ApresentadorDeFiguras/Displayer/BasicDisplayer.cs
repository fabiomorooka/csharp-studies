using FigureDisplayerApp.Enums;

namespace FigureDisplayerApp.System
{
    public class BasicDisplayer
    {
        public static double CalculateDimensions(string figure)
        {
            double result = double.NaN;

            switch ((FiguresEnum)(int.Parse(figure)))
            {
                case FiguresEnum.Circle:

                    break;
                case FiguresEnum.Hexagon:

                    break;
                case FiguresEnum.EquilateralTriangle:

                    break;
                case FiguresEnum.Rhombus:

                    break;
                case FiguresEnum.Rectangle:

                    break;
                case FiguresEnum.Square:

                    break;
                default:
                    break;
            }
            return result;
        }
    }
}