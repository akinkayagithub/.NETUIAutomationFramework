using OpenQA.Selenium;
using UIAutomationFramework.Configurations;

namespace UIAutomationFramework.Pages
{
	public class BasePage : EnvironmentSettings
	{
        public IWebElement logo => driver.FindElement(By.Id("logo"));
    }
}

