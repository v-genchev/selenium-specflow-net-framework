using OpenQA.Selenium;
using selenium_net_project.drivermanager;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace selenium_net_project.pageobjects
{
    class ToolbarComponent : Component
    {
        [FindsBy(How = How.Id, Using = "js-drawer")]
        public IWebElement Toolbar { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='PRGS-Bar-nav']//div[contains(@class,'Bar-dropdown')]")]
        public IList<IWebElement> DropdownMenuItems { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='PRGS-Bar-nav']//div[contains(@class, 'PRGS-Bar-dropdown') and child::a[not(contains(@class,'disabled'))]]//a")]
        public IList<IWebElement> ActiveSubmenuItems { get; set; }
        public ToolbarComponent(DynamicDriverManager driverManager) : base(driverManager)
        {
            WaitForElement(Toolbar);
        }

        public void HoverOverMenu(string menuName)
        {
            List<string> menuItemsText = GetElementsText(DropdownMenuItems);
            HoverOverElement(DropdownMenuItems[menuItemsText.IndexOf(menuName)]);
        }

        public void SelectSubmenu(string submenuName)
        {
            List<string> activeSubmenusText = GetElementsText(ActiveSubmenuItems);
            ActiveSubmenuItems[activeSubmenusText.IndexOf(submenuName)].Click();
        }


    }
}
