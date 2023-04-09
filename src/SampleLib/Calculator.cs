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
        
        public bool IsSuccessful { get; set; }
        public decimal DecimalResult { get; set; }
        public double DoubleResult { get; set; }

        public string Message { get; set; }
    }

    public class Calculator
    {
        public decimal FirstNumber { get; set; }
        public decimal SecondNumber { get; set; }

        public static CalculationResult Calculate(decimal FirstNumber, decimal SecondNumber, MathOperatorType mathOperator)
        {
            var result = new CalculationResult();
            try
            {
                switch (mathOperator)
                {
                    case MathOperatorType.Add:
                        result.DecimalResult = FirstNumber + SecondNumber;
                        result.IsSuccessful = true;
                        return result;
                    case MathOperatorType.Substract:
                        result.DecimalResult = FirstNumber - SecondNumber; ;
                        result.IsSuccessful = true;
                        return result;
                    case MathOperatorType.Divide:
                        result.DecimalResult = FirstNumber / SecondNumber; ;
                        result.IsSuccessful = true;
                        return result;
                    case MathOperatorType.Multiply:
                        result.DecimalResult = FirstNumber * SecondNumber; ;
                        result.IsSuccessful = true;
                        return result;
                    case MathOperatorType.Power:
                        result.DoubleResult = Math.Pow(Convert.ToDouble(FirstNumber), Convert.ToDouble(SecondNumber));
                        result.IsSuccessful = true;
                        return result;
                    default:
                        result.IsSuccessful = false;
                        result.Message = "Unknown operator";
                        return result;
                }
            }
            catch (Exception ex)
            {

                result.IsSuccessful = false;
                result.Message = ex.Message;
                return result;
            }
        }
    }

}
