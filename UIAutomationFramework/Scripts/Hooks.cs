using NUnit.Framework;
using UIAutomationFramework.Utils;
using UIAutomationFramework.Pages;
using UIAutomationFramework.Configurations;

namespace UIAutomationFramework.Scripts
{
    public class Hooks : EnvironmentSettings
    { 
        public HomePage homePage;

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

