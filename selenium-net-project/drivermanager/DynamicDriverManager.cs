using OpenQA.Selenium;
using System;
using System.Configuration;

namespace selenium_net_project.drivermanager
{
    public class DynamicDriverManager : IDriverManager
    {
        private IDriverManager driverManager;

        public DynamicDriverManager()
        {
            string browserType = ConfigurationManager.AppSettings["Browser"];
            switch (browserType)
            {
                case "firefox":
                    driverManager = new FirefoxDriverManager();
                    break;
                case "chrome":
                    driverManager = new ChromeDriverManager();
                    break;
                default:
                    throw new PlatformNotSupportedException("Browser type: " + browserType + " is not supported");
            }
        }
        public IWebDriver Driver => DriverManager.Driver;

        public IDriverManager DriverManager { get => driverManager; set => driverManager = value; }

        public void CreateDriver()
        {
            DriverManager.CreateDriver();
        }

        public void QuitDriver()
        {
            DriverManager.QuitDriver();
        }
    }
}
