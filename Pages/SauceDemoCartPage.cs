using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumAppCiechanMateuszOKR.Pages
{
    public class SauceDemoCartPage : BasePage
    {
        //gittest
        #region Buttons
        IWebElement _continueShoppingButton => Driver.FindElement(By.Id("continue-shopping"));
        IWebElement _checkoutButton => Driver.FindElement(By.Id("checkout"));
        ICollection<IWebElement> _removeButtons => Driver.FindElements(By.XPath("//div[@class='cart_item']//button[text()='Remove']"));
        //IList<IWebElement> _removeButtons2 => Driver.FindElements(By.XPath("//div[@class='cart_item']//button[text()='Remove']"));
        ICollection<IWebElement> _prices => Driver.FindElements(By.XPath("//div[@class='inventory_item_price']"));
        #endregion
        string[] pricesArray;

        public SauceDemoCartPage(IWebDriver driver) : base (driver)
        {

        }

        #region Methods
        public void ClickContinueShoppingButton()
        {
            _continueShoppingButton.Click();
        }
        public void ClickCheckoutButton()
        {
            _checkoutButton.Click();
        }
        public void RemoveItemFromCart(int itemNr)
        {
            _removeButtons.ToList()[itemNr].Click();
            //_removeButtons2[itemNr].Click();
        }
        public double GetSumOfProductsInCart()
        {
            double sum = 0;
            for (int i = 0; i < _prices.Count; i++)
            {
                pricesArray[i] = _prices.ToList()[i].Text.ToString().Remove(1, 1);
                sum += double.Parse(pricesArray[i]);
            }
            return sum;
        }
        #endregion
    }
}