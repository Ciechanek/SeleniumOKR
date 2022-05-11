using NUnit.Framework;
using SeleniumAppCiechanMateuszOKR.Pages;
using SeleniumAppCiechanMateuszOKR.Steps;

namespace SeleniumAppCiechanMateuszOKR.Tests
{
    class ValidLoginTest : BaseTest
    {
        SauceDemoMainPage SauceDemoMainPage => new SauceDemoMainPage(Driver);
        EnterCredentialsSteps EnterCredentialsSteps => new EnterCredentialsSteps(Driver);
        SauceDemoInventoryPage SauceDemoInventoryPage => new SauceDemoInventoryPage(Driver);
        
        [Test]
        public void LoginWithValidData()
        {
            EnterCredentialsSteps.EnterValidCredentials();
            SauceDemoMainPage.ClickLogin();
            Assert.AreEqual(Driver.Url, "https://www.saucedemo.com/inventory.html", "There is invalid page url. Actual: "
                + Driver.Url + "but should be https://www.saucedemo.com/inventory.html");
            SauceDemoInventoryPage.ClickShoppingCartButton();
           
        }
    }
}