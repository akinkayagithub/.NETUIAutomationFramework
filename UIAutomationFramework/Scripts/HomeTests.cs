using NUnit.Framework;
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

		[Test, Category("Smoke")]
		public void validateLogo()
		{
            driver.Navigate().GoToUrl("https://techglobal-training.com/");

			Thread.Sleep(2000);

			Assert.True(homePage.logo.Displayed);

		}

        [Test, Category("Regression")]
        public void validateHeader()
        {
            driver.Navigate().GoToUrl("https://techglobal-training.com/");

            Thread.Sleep(2000);

            Assert.True(homePage.logo.Displayed);
        }
    }
}

