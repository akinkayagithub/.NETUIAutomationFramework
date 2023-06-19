using NUnit.Framework;
using UIAutomationFramework.Utils;
using UIAutomationFramework.Pages;
using UIAutomationFramework.Configurations;
using OpenQA.Selenium.Interactions;

namespace UIAutomationFramework.Scripts
{
    public class Hooks : EnvironmentSettings
    {
        public HomePage homePage;
        public MockInterviewsPage mockInterviewsPage;

        [SetUp]
        public void SetUp()
        {
            driver = Driver.GetDriver();
            driver.Navigate().GoToUrl("https://techglobal-training.com/");
            actions = new Actions(driver);
        }

        [TearDown]
        public void QuitDriver()
        {
            Driver.QuitDriver();
        }

    }
}

