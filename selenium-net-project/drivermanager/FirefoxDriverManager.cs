using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace selenium_net_project.drivermanager
{
    class FirefoxDriverManager : IDriverManager
    {
        public IWebDriver Driver { get; private set; }

        public void CreateDriver() => Driver = new FirefoxDriver(ConfigurationManager.AppSettings["DriversDir"]);
    }
}
