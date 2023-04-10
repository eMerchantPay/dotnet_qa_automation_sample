using System;

namespace SampleLib
{
    public enum MathOperatorType : int
    {
        Add = 1,
        Substract = 2,
        Divide = 3,
        Multiply = 4,
        Power = 5,
        Unknown = 6
    }

    public class CalculationResult
    {
        
        public bool IsSuccessful { get; set; }
        public decimal DecimalResult { get; set; }
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
                        result.DecimalResult = FirstNumber - SecondNumber; 
                        result.IsSuccessful = true;
                        return result;
                    case MathOperatorType.Divide:
                        if (FirstNumber == 0 && SecondNumber == 0 || FirstNumber == 0 || SecondNumber == 0)
                        {
                            result.IsSuccessful = false;
                            result.Message = "Cannot divide by 0";
                            return result;
                        }
                        else
                        {
                            result.DecimalResult = FirstNumber / SecondNumber;
                            result.IsSuccessful = true;
                            return result;
                        }
                    case MathOperatorType.Multiply:
                        result.DecimalResult = FirstNumber * SecondNumber; 
                        result.IsSuccessful = true;
                        return result;
                    case MathOperatorType.Power:
                        double doubleResult = Math.Pow(Convert.ToDouble(FirstNumber), Convert.ToDouble(SecondNumber));
                        result.DecimalResult = Convert.ToDecimal(doubleResult);
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
