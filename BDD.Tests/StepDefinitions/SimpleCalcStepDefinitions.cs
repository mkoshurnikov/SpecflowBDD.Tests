using NUnit.Framework;

namespace BDD.Tests.StepDefinitions
{
    [Binding]
    public class SimpleCalcStepDefinitions
    {
        private readonly ScenarioContext scenarioContext;
        public SimpleCalcStepDefinitions(ScenarioContext context)
        {
            scenarioContext = context;
        }

        [Given(@"the first num is (.*)")]
        public void GivenTheFirstNumIs(int num1)
        {
            scenarioContext["FirstNumber"] = num1;
        }

        [Given(@"the second num is (.*)")]
        public void GivenTheSecondNumIs(int num2)
        {
            scenarioContext["SecondNumber"] = num2;
        }

        [When(@"the two nums are added")]
        public void WhenTheTwoNumsAreAdded()
        {
            var result = SimpleCalc.SumTwoNumbers((int)scenarioContext["FirstNumber"],
                (int)scenarioContext["SecondNumber"]);
            scenarioContext["SumOfTwoNumsResult"] = result;
        }

        [Then(@"the result of sum should be (.*)")]
        public void ThenTheResultOfSumShouldBe(int result)
        {
            Assert.IsTrue(result == (int)scenarioContext["SumOfTwoNumsResult"]);
        }
        [When(@"the two nums are substracted")]
        public void WhenTheTwoNumsAreSubstracted()
        {
            var result = SimpleCalc.SubtractTwoNumbers((int)scenarioContext["FirstNumber"],
                (int)scenarioContext["SecondNumber"]);
            scenarioContext["SubstractOfTwoNumsResult"] = result;
        }

        [Then(@"the result of substract should be (.*)")]
        public void ThenTheResultOfSubstractShouldBe(int result)
        {
            Assert.IsTrue(result == (int)scenarioContext["SubstractOfTwoNumsResult"]);
        }

    }
}
