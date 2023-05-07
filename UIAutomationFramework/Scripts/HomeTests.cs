using NUnit.Framework;
using OpenQA.Selenium;
using UIAutomationFramework.Pages;

namespace UIAutomationFramework.Scripts
{
	[TestFixture]
	public class HomeTests : Hooks
	{

        [SetUp]
        public void SetUpPage()
        {
			homePage = new HomePage();
        }

        [Test]
		public void validateLogo()
		{
            driver.Navigate().GoToUrl("https://techglobal-training.com/");

			Thread.Sleep(1000);

			Assert.IsTrue(homePage.logo.Displayed);

			Console.WriteLine(driver.FindElement(By.TagName("h1")).Text);
		}
	}
}

