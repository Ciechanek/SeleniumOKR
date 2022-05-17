using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumAppCiechanMateuszOKR.Pages
{
    public class SauceDemoCheckoutStepOne : BasePage
    {
        #region Buttons
        IWebElement _cancelButton => Driver.FindElement(By.Id("cancel"));
        IWebElement _continueButton => Driver.FindElement(By.Id("continue"));
        IWebElement _firstNameInput => Driver.FindElement(By.Id("first-name"));
        IWebElement _lastNameInput => Driver.FindElement(By.Id("last-name"));
        IWebElement _postalCodeInput => Driver.FindElement(By.Id("postal-code"));
        #endregion

        public SauceDemoCheckoutStepOne (IWebDriver driver) : base (driver)
        {

        }

        public void ClickCancelButton()
        {
            _cancelButton.Click();
        }

        public void ClickContinueButton()
        {
            _continueButton.Click();
        }

        public void EnterFirstName(string firstName)
        {
            _firstNameInput.SendKeys(firstName);
        }
        public void EnterLastName(string lastName)
        {
            _firstNameInput.SendKeys(lastName);
        }

        public void EnterPostalCode(string postalCode)
        {
            _firstNameInput.SendKeys(postalCode);
        }
    }
}
