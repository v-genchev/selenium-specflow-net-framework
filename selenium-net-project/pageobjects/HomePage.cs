using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using selenium_net_project.drivermanager;
using System.Configuration;

namespace selenium_net_project.pageobjects
{
    class HomePage : Page
    {
        [FindsBy(How = How.Id, Using = "progress")]
        public IWebElement PageBody { get; set; }

        private readonly string baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
        public HomePage(DynamicDriverManager driverManager) : this(driverManager, false)
        {
        }

        public HomePage(DynamicDriverManager driverManager, bool navigateToUrl) : base(driverManager)
        {
            if (navigateToUrl)
            {
                NavigateTo(baseUrl);
            }
            WaitForPage(PageBody);
        }
    }
}
