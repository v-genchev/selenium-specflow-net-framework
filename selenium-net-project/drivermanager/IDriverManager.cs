using OpenQA.Selenium;

namespace selenium_net_project.drivermanager
{
    public interface IDriverManager
    {
        public IWebDriver Driver { get; }

        public void CreateDriver();

        public void QuitDriver()
        {
            if (Driver is object)
            {
                Driver.Quit();
            }
        }

        public void MaximizeDriverWindow() => Driver.Manage().Window.Maximize();

    }

}
