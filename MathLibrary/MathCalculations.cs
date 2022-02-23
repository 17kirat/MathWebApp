using System;

namespace MathLibrary
{
    public class MathCalculations
    {
        
        public double Calculate(int lVal, int rVal, string operation)
        {
            double result = 0;

            switch (operation)
            {
                case "Add":
                    result = lVal + rVal;
                    break;

                case "Subtract":
                    result = lVal - rVal;
                    break;

                case "Divide":
                    result = lVal / rVal;
                    break;

                case "Multiply":
                    result = lVal * rVal;
                    break;

                default:
                    break;
            }
            return result;
        }
    }
}
