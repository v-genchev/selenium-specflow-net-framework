using OpenQA.Selenium;
using selenium_net_project.drivermanager;
using System;

namespace selenium_net_project.pageobjects
{
    abstract class Page : Component
    {
        private readonly TimeSpan _waitIntervalPage = TimeSpan.FromSeconds(20);

        public Page(DynamicDriverManager driverManager) : base(driverManager) { }

        public void NavigateTo(string url) => driverManager.Driver.Navigate().GoToUrl(url);

        public void WaitForPage(IWebElement element) => WaitForElement(element, _waitIntervalPage);
    }
}
