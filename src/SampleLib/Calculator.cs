using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLib
{
    public enum MathOperatorType : int
    {
        Add = 1,
        Substract = 2,
        Devide = 3,
        Multiply = 4,
        Power = 5
    }

    public class CalculationResult
    {
        public bool isSuccessful { get; set; }
        public decimal DecimalResult { get; set; }
        public string Message { get; set; }
    }

    public static class Calculator
    {
        public static CalculationResult Calculate(decimal a, decimal b, MathOperatorType mathOperator)
        {
            var result = new CalculationResult();
            try
            {
                switch (mathOperator)
                {
                    case MathOperatorType.Add:
                        result.DecimalResult = a + b;
                        result.isSuccessful = true;
                        return result;

                    case MathOperatorType.Substract:
                        result.DecimalResult = a - b;
                        result.isSuccessful = true;
                        return result;
                    case MathOperatorType.Devide:
                        result.DecimalResult = a - b;
                        result.isSuccessful = true;
                        return result;
                    case MathOperatorType.Multiply:
                        result.DecimalResult = a - b;
                        result.isSuccessful = true;
                        return result;
                    default:
                        result.isSuccessful = false;
                        result.Message = "Unknown operator";
                        return result;
                }
            }
            catch (Exception ex)
            {

                result.isSuccessful = false;
                result.Message = ex.Message;
                return result;
            }
        }
    }

}
