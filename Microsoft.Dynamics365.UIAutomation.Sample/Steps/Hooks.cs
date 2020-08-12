using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Microsoft.Dynamics365.UIAutomation.Sample.Steps
{
    [Binding]
    public sealed class Hooks
    {
        private readonly ScenarioContext scenarioContext;
        public Hooks(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void SetUp(FeatureContext featureContext)
        {
        }

        [AfterScenario]
        public void CleanUp(FeatureContext featureContext)
        {

        }

        [AfterStep]
        public void LogStepResult()
        {
        }    }
}
