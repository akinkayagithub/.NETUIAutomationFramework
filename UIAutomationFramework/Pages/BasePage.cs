using OpenQA.Selenium;
using UIAutomationFramework.Configurations;

namespace UIAutomationFramework.Pages
{
	public class BasePage : EnvironmentSettings
	{
        public IWebElement logo => driver.FindElement(By.Id("logo"));
        public IWebElement headerDropdown => driver.FindElement(By.Id("dropdown-button"));
        public IList<IWebElement> dropdownItems => driver.FindElements(By.CssSelector(".dropdown-menu a"));
    }
}

