using NUnit.Framework;
using SeleniumAppCiechanMateuszOKR.Pages;
using SeleniumAppCiechanMateuszOKR.Steps;

namespace SeleniumAppCiechanMateuszOKR.Tests
{
    class InvalidPasswordTest : BaseTest
    {
        SauceDemoMainPage SauceDemoMainPage => new SauceDemoMainPage(Driver);
        EnterCredentialsSteps EnterCredentialsSteps => new EnterCredentialsSteps(Driver);

        [Test]
        public void LoginWithInvalidPassword()
        {
            EnterCredentialsSteps.EnterInvalidPassword();
            SauceDemoMainPage.ClickLogin();
            Assert.That(SauceDemoMainPage.GetLoginErrorText().Contains("Epic sadface"), "message");
        }
    }
}