using NUnit.Framework;
using UIAutomationFramework.Pages;

namespace UIAutomationFramework.Scripts
{
	public class MockInterviewsTests : Hooks
	{
        [SetUp]
        public void SetPage()
        {
            homePage = new HomePage();
            mockInterviewsPage = new MockInterviewsPage();
            homePage.selectPracticesDropDownOption("Mock Interviews");
        }

        [Test]
        public void ValidateMockInterviewsLoginForm()
        {
            Assert.True(mockInterviewsPage.loginFormTitle.Displayed);
            Assert.That(mockInterviewsPage.loginFormTitle.Text.Equals("Designed for TechGlobal Students"));
            Assert.True(mockInterviewsPage.loginFormUserNameLabel.Displayed);
            Assert.That(mockInterviewsPage.loginFormUserNameLabel.Text.Equals("Please enter your username"));
            Assert.True(mockInterviewsPage.loginFormUserNameInput.Displayed);
            Assert.True(mockInterviewsPage.loginFormUserNameInput.Enabled);

            Assert.True(mockInterviewsPage.loginFormPasswordLabel.Displayed);
            Assert.That(mockInterviewsPage.loginFormPasswordLabel.Text.Equals("Please enter your password"));
            Assert.True(mockInterviewsPage.loginFormPasswordInput.Displayed);
            Assert.True(mockInterviewsPage.loginFormPasswordInput.Enabled);

            Assert.True(mockInterviewsPage.loginFormLoginButton.Displayed);
            Assert.True(mockInterviewsPage.loginFormLoginButton.Enabled);
            Assert.That(mockInterviewsPage.loginFormLoginButton.Text.Equals("LOGIN"));
        }

        [Test]
        [TestCase("john", "password1")]
        [TestCase("jane", "password2")]
        [TestCase("adam", "password3")]
        public void ValidateMockInterviewsLoginFormWithInvalidCreds(string username, string password)
        {
            mockInterviewsPage.FillOutLoginForm(username, password);
            mockInterviewsPage.loginFormLoginButton.Click();

            Assert.True(mockInterviewsPage.loginFormErrorMessage.Displayed);
            Assert.That(mockInterviewsPage.loginFormErrorMessage.Text, Is.EqualTo("Email or Password does not match!"));
        }
    }
}