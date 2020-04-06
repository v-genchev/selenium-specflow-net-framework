using selenium_net_project.drivermanager;
using selenium_net_project.pageobjects;
using TechTalk.SpecFlow;

namespace selenium_net_project.steps
{
    [Binding]
    public class HomePageSteps
    {
        public DynamicDriverManager driverManager;
        public HomePageSteps(DynamicDriverManager driverManager)
        {
            this.driverManager = driverManager;
        }

        [StepDefinition(@"I navigate to Progress home page")]
        public void NavigateToHomePage() => new HomePage(driverManager, true);

    }
}
