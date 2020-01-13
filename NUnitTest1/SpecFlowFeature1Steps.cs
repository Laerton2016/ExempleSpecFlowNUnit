using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace NUnitTest1
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private int num;
        private int sum;

        [BeforeScenario]
        public void Init()
        {
            num = 0;
            sum = 0;
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            num = p0;
        }

     
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            sum += num;
            num = 0;
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(p0, sum);
        }
    }
}
