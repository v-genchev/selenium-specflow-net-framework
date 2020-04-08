using OpenQA.Selenium;
using System;
using System.Configuration;

namespace selenium_net_project.drivermanager
{
    public class DynamicDriverManager : IDriverManager
    {
        public IDriverManager DriverManager { get; private set; }
        public DynamicDriverManager()
        {
            string browserType = ConfigurationManager.AppSettings["Browser"];
            DriverManager = browserType switch
            {
                "firefox" => new FirefoxDriverManager(),
                "chrome" => new ChromeDriverManager(),
                _ => throw new PlatformNotSupportedException($"Browser type: {browserType} is not supported"),
            };
        }

        public IWebDriver Driver => DriverManager.Driver;

        public void CreateDriver() => DriverManager.CreateDriver();

        public void QuitDriver() => DriverManager.QuitDriver();
    }
}
