using FigureDisplayer.Enums;
using FigureDisplayer.GeometricFigures;
using FigureDisplayer.Helpers;
using System.Reflection;

namespace FigureDisplayer.Services
{
    internal class ColorBuilder
    {
        public static BaseFigure BuildFigure(string figureNumber)
        {
            BaseFigure? result = null;
            Type? figureType = GetTypeFromClassName(Enum.GetName(typeof(FiguresEnum), Convert.ToInt32(figureNumber)));
            object[] paramArray = Array.Empty<object>();
            int numberOfparams = 1;
            List<string> attributes = new List<string>() { "color" };

            switch ((FiguresEnum)int.Parse(figureNumber))
            {
                case FiguresEnum.Circle:
                    attributes.Add("radius");
                    numberOfparams++;
                    break;
                case FiguresEnum.Rectangle:
                    attributes.Add("height");
                    numberOfparams++;
                    attributes.Add("width" );
                    numberOfparams++;
                    break;
                case FiguresEnum.EquilateralTriangle:
                case FiguresEnum.Square:
                case FiguresEnum.Pentagon:
                case FiguresEnum.Hexagon:
                    attributes.Add("side");
                    numberOfparams++;
                    break;
                case FiguresEnum.Rhombus:
                    attributes.Add("majorDiagonal");
                    numberOfparams++;
                    attributes.Add("minorDiagonal");
                    numberOfparams++;
                    break;
                default:
                    break;
            }
            paramArray = GetParametersArray(figureType, numberOfparams, attributes);
            return (BaseFigure)Activator.CreateInstance(figureType, args: paramArray);
        }
        private static object[] AddInArray(object[] array, object newValue)
        {
            int newLength = array.Length + 1;

            object[] result = new object[newLength];

            for (int i = 0; i < array.Length; i++)
                result[i] = array[i];

            result[newLength - 1] = newValue;

            return result;
        }

        private static Type? GetTypeFromClassName(string name)
        {
            Type classType = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(asm => asm.GetTypes())
            .FirstOrDefault(type => type.Name == name);

            return classType;
        }

        private static object[] GetParametersArray(Type figureType, int numberOfparams, List<string> atributes)
        {
            object[] results = Array.Empty<object>();

            foreach (ConstructorInfo constrInfo in figureType.GetConstructors())
            {
                if (constrInfo.GetParameters().Length != numberOfparams)
                    continue;
                var information = constrInfo.GetParameters().Where(p => atributes.Contains(p.Name)).ToList();
                foreach (var info in information)
                {
                    string variable = IOHelper.ReadInput($"Please insert the value of {info.Name} [in meters]: ");
                    results = AddInArray(results, Convert.ChangeType(variable, info.ParameterType));
                }
            }
            return results;
        }
    }
}
