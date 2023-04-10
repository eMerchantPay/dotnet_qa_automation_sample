using System;
using TechTalk.SpecFlow;
using SampleLib;
using NUnit.Framework;

namespace SpecflowAutomationTest
{
    [Binding]
    public class CalculatorSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public CalculatorSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        decimal a;
        decimal b;
        CalculationResult _result;
       

        [Given(@"first number is (.*)")]
        public void GivenFirstNumberIs(decimal firstNumber)
        {
            a = firstNumber;
        }
        
        [Given(@"second number is (.*)")]
        public void GivenSecondNumberIs(decimal secondNumber)
        {
            b = secondNumber;
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {

            _result = Calculator.Calculate(a, b, MathOperatorType.Add);
        }

        [When(@"the two numbers are substracted")]
        public void WhenTheTwoNumbersAreSubstracted()
        {
            _result = Calculator.Calculate(a, b, MathOperatorType.Substract);
        }

        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = Calculator.Calculate(a, b, MathOperatorType.Multiply);
        }

        [When(@"the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            _result = Calculator.Calculate(a, b, MathOperatorType.Divide);
        }
        [When(@"the two numbers are powered")]
        public void WhenTheTwoNumbersArePowered()
        {
            _result = Calculator.Calculate(a, b, MathOperatorType.Power);
        }
       
        
        [Then(@"the result is (.*)")]
        public void ThenTheResultIs(decimal result)
        {
            Assert.AreEqual(result, _result.DecimalResult);
        }

        [When(@"adding an unknown operator")]
        public void WhenAddingAnUnknownOperator()
        {
            _result = Calculator.Calculate(a, b, MathOperatorType.Unknown);
        }

        [Then(@"result is equals an unknown operator")]
        public void ThenResultIsEqualsAnUnknownOperator()
        {
            Assert.AreEqual(_result.Message, "Unknown operator");
        }

        [Then(@"the result equals an error message")]
        public void ThenTheResultEqualsAnErrorMessage()
        {
            Assert.AreEqual(_result.Message, "Cannot divide by 0");
        }
    }
}
