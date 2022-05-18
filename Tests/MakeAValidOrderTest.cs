using NUnit.Framework;
using SeleniumAppCiechanMateuszOKR.Pages;
using SeleniumAppCiechanMateuszOKR.Steps;

namespace SeleniumAppCiechanMateuszOKR.Tests
{
    public class MakeAValidOrderTest : BaseTest
    {
        SauceDemoMainPage SauceDemoMainPage => new SauceDemoMainPage(Driver);
        EnterCredentialsSteps EnterCredentialsSteps => new EnterCredentialsSteps(Driver);
        SauceDemoInventoryPage SauceDemoInventoryPage => new SauceDemoInventoryPage(Driver);
        SauceDemoCartPage SauceDemoCartPage => new SauceDemoCartPage(Driver);
        SauceDemoCheckoutStepOne SauceDemoCheckoutStepOne => new SauceDemoCheckoutStepOne(Driver);
        SauceDemoCheckoutStepTwo SauceDemoCheckoutStepTwo => new SauceDemoCheckoutStepTwo(Driver);
        EnterPersonalData EnterPersonalData => new EnterPersonalData(Driver);

        [Test]
        public void ValidOrderTest()
        {
            EnterCredentialsSteps.EnterValidCredentials();
            SauceDemoMainPage.ClickLogin();
            SauceDemoInventoryPage.ClickBackpackAddToCart();
            SauceDemoInventoryPage.ClickLightAddToCart();
            SauceDemoInventoryPage.ClickShoppingCartButton();
            SauceDemoCartPage.ClickCheckoutButton();
            EnterPersonalData.EnterValidPersonalDataToTheOrder("Mateusz", "Ciechan", "01-001");
            SauceDemoCheckoutStepTwo.ClickFinishButton();
            Assert.AreEqual(Driver.Url, "https://www.saucedemo.com/checkout-complete.html", "Something went wrong, you didn't complete an order succesfully" +
                ", Actual Url is: " + Driver.Url + " but should be https://www.saucedemo.com/checkout-complete.html");
        }
    }

    
}
