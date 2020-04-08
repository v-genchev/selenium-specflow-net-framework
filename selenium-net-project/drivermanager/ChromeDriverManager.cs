using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace selenium_net_project.drivermanager
{
    class ChromeDriverManager : IDriverManager
    {
        public IWebDriver Driver { get; private set; }

        public void CreateDriver() => Driver = new ChromeDriver(ConfigurationManager.AppSettings["DriversDir"]);
    }
}
