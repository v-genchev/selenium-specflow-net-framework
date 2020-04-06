﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
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
        private IWebDriver driver;
        private readonly TimeSpan waitIntervalElement = TimeSpan.FromSeconds(5);
        public Component(DynamicDriverManager driverManager)
        {
            this.driverManager = driverManager;
            driver = driverManager.Driver;
            PageFactory.InitElements(driver, this);
        }

        public void WaitForElement(IWebElement element)
        {
            WaitForElement(element, waitIntervalElement);
        }

        public void WaitForElement(IWebElement element, TimeSpan waitIntervalTime)
        {
            WebDriverWait wait = new WebDriverWait(driver, waitIntervalTime);
            wait.Until(CustomWaitingConditions.VisibilityOf(element));
        }

        public List<string> GetElementsText(IList<IWebElement> elements)
        {
            return (elements.Select(element => element.Text)).ToList();
        }

        public void HoverOverElement(IWebElement element)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(element).Perform();
        }
    }
}
