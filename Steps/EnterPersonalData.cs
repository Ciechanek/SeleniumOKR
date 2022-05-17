using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumAppCiechanMateuszOKR.Pages;

namespace SeleniumAppCiechanMateuszOKR.Steps
{
    
    public class EnterPersonalData : BaseSteps
    {
        SauceDemoCheckoutStepOne sauceDemoCheckoutStepOne => new SauceDemoCheckoutStepOne(Driver);
        public EnterPersonalData(IWebDriver driver) : base(driver)
        {

        }

        public void EnterValidPersonalDataToTheOrder(string firstName, string lastName, string postalCode)
        {
            sauceDemoCheckoutStepOne.EnterFirstName(firstName);
            sauceDemoCheckoutStepOne.EnterLastName(lastName);  
            sauceDemoCheckoutStepOne.EnterPostalCode(postalCode);
            sauceDemoCheckoutStepOne.ClickContinueButton();
        }

        public void EnterPersonalDataToTheOrderWithoutFirstName(string lastName, string postalCode)
        {
            sauceDemoCheckoutStepOne.EnterFirstName("");
            sauceDemoCheckoutStepOne.EnterLastName(lastName);
            sauceDemoCheckoutStepOne.EnterPostalCode(postalCode);
            sauceDemoCheckoutStepOne.ClickContinueButton();
        }
    }
}
