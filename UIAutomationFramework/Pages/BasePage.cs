using OpenQA.Selenium;
using UIAutomationFramework.Configurations;
using UIAutomationFramework.Utils;

namespace UIAutomationFramework.Pages
{
	public class BasePage : EnvironmentSettings
	{
        public IWebElement logo => driver.FindElement(By.Id("logo"));
        public IWebElement headerDropdown => driver.FindElement(By.Id("dropdown-button"));
        public IList<IWebElement> dropdownItems => driver.FindElements(By.CssSelector(".dropdown-menu a"));

        public void selectPracticesDropDownOption(string optionText)
        {
            headerDropdown.Click();
            ElementHandler.ClickListElement(dropdownItems, optionText);
        }

        public void selectPracticesDropDownOption(int index)
        {
            headerDropdown.Click();
            ElementHandler.ClickListElement(dropdownItems, index);
        }
    }
}

