namespace CalculatorV2.Interfaces
{
    public interface IIOHelper
    {
        string ReadInput(string message);

        void ShowOperationOptions();
        
        void ShowCloseOptions();
    }
}