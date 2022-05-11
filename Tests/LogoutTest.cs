using NUnit.Framework;
using SeleniumAppCiechanMateuszOKR.Pages;
using SeleniumAppCiechanMateuszOKR.Steps;

namespace SeleniumAppCiechanMateuszOKR.Tests
{
    public class LogoutTest : BaseTest
    {
        EnterCredentialsSteps EnterCredentialsSteps => new EnterCredentialsSteps(Driver);
        SauceDemoMainPage SauceDemoMainPage => new SauceDemoMainPage(Driver);
        SauceDemoInventoryPage SauceDemoInventoryPage => new SauceDemoInventoryPage(Driver);
        [Test]
        public void LogoutFromPageTest()
        {
            EnterCredentialsSteps.EnterValidCredentials();
            SauceDemoMainPage.ClickLogin();
            SauceDemoInventoryPage.ClickLogoutButton();
            Assert.AreEqual(Driver.Url, "https://www.saucedemo.com/", "There is invalid page url. Actual: "
                + Driver.Url + "but should be https://www.saucedemo.com/");
        }
    }
}
