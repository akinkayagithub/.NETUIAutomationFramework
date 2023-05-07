using OpenQA.Selenium;
using UIAutomationFramework.Utils;

namespace UIAutomationFramework.Pages
{
	public class BasePage
	{
		public static IWebDriver driver = Driver.GetDriver();

        public IWebElement logo => driver.FindElement(By.Id("logo"));
    }
}

