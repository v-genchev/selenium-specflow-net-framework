using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using selenium_net_project.drivermanager;
using OpenQA.Selenium.Support.UI;
using selenium_net_project.helpers;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Interactions;

namespace selenium_net_project.pageobjects
{
    abstract class Component
    {
        public DynamicDriverManager driverManager;
        private readonly IWebDriver _driver;
        private readonly TimeSpan _waitIntervalElement = TimeSpan.FromSeconds(5);

        public Component(DynamicDriverManager driverManager)
        {
            this.driverManager = driverManager;
            _driver = driverManager.Driver;
            PageFactory.InitElements(_driver, this);
        }

        public void WaitForElement(IWebElement element) => WaitForElement(element, _waitIntervalElement);

        public void WaitForElement(IWebElement element, TimeSpan waitIntervalTime)
        {
            WebDriverWait wait = new WebDriverWait(_driver, waitIntervalTime);
            wait.Until(CustomWaitingConditions.VisibilityOf(element));
        }

        public List<string> GetElementsText(IList<IWebElement> elements) => (elements.Select(element => element.Text)).ToList();

        public void HoverOverElement(IWebElement element) => new Actions(_driver).MoveToElement(element).Perform();
    }
}
