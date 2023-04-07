using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BDD.Tests.StepDefinitions
{
    [Binding]
    public class StringsCounterStepDefinitions
    {
        private readonly ScenarioContext scenarioContext;
        public StringsCounterStepDefinitions(ScenarioContext context)
        {
            scenarioContext = context;
        }

        [When(@"the phrase is (.*)")]
        public void WhenThePhraseIs(string phrase)
        {
            scenarioContext["Phrase"] = phrase;
        }

        [Then(@"the word count is (.*)")]
        public void ThenTheWordCountIs(int count)
        {
            var _count = ((string)scenarioContext["Phrase"]).GetWordCount();
            Assert.IsTrue(count == _count);
        }

        [Then(@"the char count is (\d+)")]
        public void ThenTheCharCountIs(int count)
        {
            var _count = ($"{(string)scenarioContext["Prefix"]}{(string)scenarioContext["Phrase"]}")
                   .GetCharCount();
            Assert.IsTrue(count == _count);
        }

        [Given(@"the phrase prefix is (.*).")]
        public void GivenThePhrasePrefixIsPhrase(string prefix)
        {
            scenarioContext["Prefix"] = prefix;
        }
    }
}
