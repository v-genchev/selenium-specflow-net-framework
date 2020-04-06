using NUnit.Framework;
using selenium_net_project.drivermanager;
using System;
using TechTalk.SpecFlow;

namespace selenium_net_project.steps
{
    [Binding]
    public class CommonSteps
    {
        public DynamicDriverManager driverManager;
        public CommonSteps(DynamicDriverManager driverManager)
        {
            this.driverManager = driverManager;
        }

        [StepDefinition(@"I start the browser")]
        public void StartBrowser()
        {
            driverManager.CreateDriver();
            driverManager.DriverManager.MaximizeDriverWindow();
        }

        [StepDefinition(@"I stop the browser")]
        public void StopBrowser()
        {
            driverManager.QuitDriver();
        }

        [StepDefinition(@"I verify current page title contains (.*)")]
        public void VerifyPageTitleContains(String pageTitle)
        {
            Assert.That(condition: driverManager.Driver.Title.Contains(pageTitle),
                message: "Expected page title to contain " + pageTitle);
        }
    }
}
