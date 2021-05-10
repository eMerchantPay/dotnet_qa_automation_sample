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
        Divide = 3,
        Multiply = 4,
        Power = 5
    }

    public class CalculationResult
    {
        public bool Successful { get; set; }
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
                        result.Successful = true;
                        return result;

                    case MathOperatorType.Substract:
                        result.DecimalResult = a - b;
                        result.Successful = true;
                        return result;
                    case MathOperatorType.Divide:
                        result.DecimalResult = a / b;
                        result.Successful = true;
                        return result;
                    case MathOperatorType.Multiply:
                        result.DecimalResult = a * b;
                        result.Successful = true;
                        return result;
                    default:
                        result.Successful = false;
                        result.Message = "Unknown operator";
                        return result;
                }
            }
            catch (Exception ex)
            {

                result.Successful = false;
                result.Message = ex.Message;
                return result;
            }
        }
    }

}
