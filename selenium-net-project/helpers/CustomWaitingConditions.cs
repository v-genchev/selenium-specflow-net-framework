using OpenQA.Selenium;
using System;

namespace selenium_net_project.helpers
{
    class CustomWaitingConditions
    {
        public CustomWaitingConditions()
        {
        }

        public static Func<IWebDriver, IWebElement> VisibilityOf(IWebElement element)
        {
            return (driver) =>
            {
                try
                {
                    return element.Displayed ? element : null;
                }
                catch (StaleElementReferenceException)
                {
                    return null;
                }
            };
               
        }
    }
}
