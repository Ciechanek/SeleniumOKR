using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumAppCiechanMateuszOKR.Pages;
using SeleniumAppCiechanMateuszOKR.Steps;
using SeleniumAppCiechanMateuszOKR.Tests;

namespace SeleniumAppCiechanMateuszOKR.Tests
{
    public class CheckOrderValueTest : BaseTest
    {
        SauceDemoMainPage SauceDemoMainPage => new SauceDemoMainPage(Driver);
        EnterCredentialsSteps EnterCredentialsSteps => new EnterCredentialsSteps(Driver);
        SauceDemoInventoryPage SauceDemoInventoryPage => new SauceDemoInventoryPage(Driver);
        SauceDemoCartPage SauceDemoCartPage => new SauceDemoCartPage(Driver);
        SauceDemoCheckoutStepOne SauceDemoCheckoutStepOne => new SauceDemoCheckoutStepOne(Driver);
        SauceDemoCheckoutStepTwo SauceDemoCheckoutStepTwo => new SauceDemoCheckoutStepTwo(Driver);
        EnterPersonalData EnterPersonalData => new EnterPersonalData(Driver);

        [Test]
        public void CheckOrderValue()
        {
            EnterCredentialsSteps.EnterValidCredentials();
            SauceDemoMainPage.ClickLogin();
            SauceDemoInventoryPage.ClickBackpackAddToCart();
            SauceDemoInventoryPage.ClickLightAddToCart();
            SauceDemoInventoryPage.ClickShoppingCartButton();
            double orderValue = SauceDemoCartPage.GetSumOfProductsValueInCart();
            EnterPersonalData.EnterValidPersonalDataToTheOrder("Mateusz", "Ciechan", "00-001");
        }
    }
}
