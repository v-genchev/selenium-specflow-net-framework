using selenium_net_project.drivermanager;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace selenium_net_project.steps
{
    [Binding]
    class Hooks
    {
        public ScenarioContext scenarioContext;
        public DynamicDriverManager driverManager;
        public Hooks(ScenarioContext scenarioContext, DynamicDriverManager driverManager)
        {
            this.scenarioContext = scenarioContext;
            this.driverManager = driverManager;
        }
        [AfterScenario]
        public void AfterScenario()
        {
           if(scenarioContext.ScenarioExecutionStatus.Equals(ScenarioExecutionStatus.TestError))
            {
                driverManager.QuitDriver();
            }
        }

    }
}
