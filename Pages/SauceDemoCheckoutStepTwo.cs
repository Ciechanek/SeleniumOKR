using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAppCiechanMateuszOKR.Pages
{
    public class SauceDemoCheckoutStepTwo : BasePage
    {
        IWebElement _cancelButton => Driver.FindElement(By.Id("cancel"));
        IWebElement _finishButton => Driver.FindElement(By.Id("finish"));
        IWebElement _itemTotalPrice => Driver.FindElement(By.XPath("//div[@class='summary_subtotal_label']"));
        public SauceDemoCheckoutStepTwo(IWebDriver driver) : base(driver)
        {
            
        }      

        public void ClickFinishButton()
        {
            _finishButton.Click();
        }

        public void ClickCancelButton()
        {
            _cancelButton.Click();
        }
        public double GetTotalItemsPrice()
        {
            string price = _itemTotalPrice.Text.ToString().Remove(1, 1);
            return double.Parse(price);
        }
    }
}
