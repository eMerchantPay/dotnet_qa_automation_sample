using NUnit.Framework;
using SampleLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecflowAutomationTest
{
    [Binding]
    public class Steps
    {

        decimal a;
        decimal b;
        SampleLib.CalculationResult result;

        [Given(@"a digit is (.*)")]
        public void Givenadigitis(decimal p0)
        {
            a = p0;
        }

        [Given(@"b digit is (.*)")]
        public void Givenbdigitis(decimal p0)
        {
            b = p0;
        }

        [When(@"Sum them")]
        public void WhenSumthem()
        {
            result = SampleLib.Calculator.Calculate(a, b, MathOperatorType.Add);

        }

        [When(@"Substract them")]
        public void WhenSubstractthem()
        {
            result = SampleLib.Calculator.Calculate(a, b, MathOperatorType.Substract);

        }

        [When(@"Divide them")]
        public void WhenDividethem()
        {
            result = SampleLib.Calculator.Calculate(a, b, MathOperatorType.Divide);

        }

        [When(@"Multiply them")]
        public void WhenMultiplythem()
        {
            result = SampleLib.Calculator.Calculate(a, b, MathOperatorType.Multiply);

        }

        [Then(@"the result is (.*)")]
        public void Thentheresultis(decimal p0)
        {
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Successful);
            Assert.AreEqual(p0, result.DecimalResult);
        }

    }
}


