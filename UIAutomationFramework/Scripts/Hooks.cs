using NUnit.Framework;
using OpenQA.Selenium;
using UIAutomationFramework.Utils;
using UIAutomationFramework.Pages;

namespace UIAutomationFramework.Scripts
{
    public class Hooks
    {
        public static IWebDriver? driver;
        public HomePage? homePage;

        [SetUp]
        public void SetUp()
        {
            driver = Driver.GetDriver();
        }

        [TearDown]
        public void QuitDriver()
        {
            Driver.QuitDriver();
        }

    }
}

