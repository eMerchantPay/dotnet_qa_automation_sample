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

        [Then(@"the result is (.*)")]
        public void ThenTheResultIs(decimal result)
        {
            Assert.AreEqual(result, _result.DecimalResult);
        }
    }
}
