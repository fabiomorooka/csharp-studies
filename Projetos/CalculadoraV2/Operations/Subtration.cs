﻿using CalculatorV2.Interfaces.Operations;

namespace CalculatorV2.Helpers
{
    public class Subtraction : ISubtraction
    {
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
    }
}