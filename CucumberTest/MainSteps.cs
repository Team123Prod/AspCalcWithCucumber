using System;
using TechTalk.SpecFlow;

namespace CucumberTest
{
    [Binding]
    public class MainSteps
    {
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
