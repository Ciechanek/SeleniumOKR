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
        public SauceDemoCheckoutStepTwo(IWebDriver driver) : base(driver)
        {
            
        }
       
    }
}
