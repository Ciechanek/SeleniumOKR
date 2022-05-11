using NUnit.Framework;
using SeleniumAppCiechanMateuszOKR.Pages;
using SeleniumAppCiechanMateuszOKR.Steps;

namespace SeleniumAppCiechanMateuszOKR.Tests
{
    class InvalidLoginTest : BaseTest
    {
        SauceDemoMainPage SauceDemoMainPage => new SauceDemoMainPage(Driver);
        EnterCredentialsSteps EnterCredentialsSteps => new EnterCredentialsSteps(Driver);

        [Test]
        public void LoginWithInvalidLogin()
        {
            EnterCredentialsSteps.EnterInvalidLogin();
            SauceDemoMainPage.ClickLogin();
            Assert.That(SauceDemoMainPage.GetLoginErrorText().Contains("Epic sadface"), "message");
        }
    }
}