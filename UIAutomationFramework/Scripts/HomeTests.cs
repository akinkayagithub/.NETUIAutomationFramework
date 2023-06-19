using NUnit.Framework;
using UIAutomationFramework.Pages;
using OpenQA.Selenium.Interactions;

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
			Thread.Sleep(2000);

			Assert.True(homePage.logo.Displayed);

		}

        [Test, Category("Regression")]
        public void validateHeaderDropdown()
        {
            Thread.Sleep(2000);
			
			actions.MoveToElement(homePage.headerDropdown).Perform();
            Thread.Sleep(2000);

            Assert.True(homePage.dropdownItems.Count > 0);

			string[] expectedTexts = {"Frontend Testing", "Backend Testing", "Java Exercises", "JS Exercises", "Mock Interviews"};

			for(int i = 0; i < homePage.dropdownItems.Count; i++)
			{
				Assert.True(homePage.dropdownItems[i].Displayed);
				Assert.That(homePage.dropdownItems[i].Text, Is.EqualTo(expectedTexts[i]));
			}
        }
    }
}

