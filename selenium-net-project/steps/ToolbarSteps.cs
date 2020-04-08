using selenium_net_project.drivermanager;
using selenium_net_project.pageobjects;
using System;
using TechTalk.SpecFlow;

namespace selenium_net_project.steps
{
    [Binding]
    public class ToolbarSteps
    {
        public DynamicDriverManager driverManager;
        public ToolbarSteps(DynamicDriverManager driverManager) => this.driverManager = driverManager;

        [StepDefinition(@"I hover over (.*) menu")]
        public void HoverOverMenu(String menu)
        {
            new ToolbarComponent(driverManager).
                HoverOverMenu(menu);
        }

        [StepDefinition(@"I select (.*) submenu")]
        public void SelectSubmenu(String submenu)
        {
            new ToolbarComponent(driverManager)
                .SelectSubmenu(submenu);
        }
    }
}
