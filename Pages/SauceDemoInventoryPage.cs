using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAppCiechanMateuszOKR.Pages
{
    public class SauceDemoInventoryPage : BasePage
    {
        #region Buttons
        IWebElement _backpackAddToCartButton => Driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        IWebElement _backpackRemoveCartButton => Driver.FindElement(By.Id("remove-sauce-labs-backpack"));
        IWebElement _lightAddToCartButton => Driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
        IWebElement _lightRemoveCartButton => Driver.FindElement(By.Id("remove-sauce-labs-bike-light"));
        IWebElement _sortContainer => Driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[2]/div[2]/span/select"));
        IWebElement _shoppingCartButton => Driver.FindElement(By.ClassName("shopping_cart_link"));
        IWebElement _leftMenuShowButton => Driver.FindElement(By.Id("react-burger-menu-btn"));
        IWebElement _leftMenuHideButton => Driver.FindElement(By.Id("react-burger-cross-btn"));
        IWebElement _logoutButton => Driver.FindElement(By.Id("logout_sidebar_link"));
        IWebElement _aboutButton => Driver.FindElement(By.Id("about_sidebar_link"));
        IWebElement _numberOfItemsInCardIndicator => Driver.FindElement(By.ClassName("shopping_cart_badge"));
        IWebElement _sortingDropdown => Driver.FindElement(By.ClassName("product_sort_container"));
        SelectElement sortingDropdownElement => new SelectElement(_sortingDropdown);
        #endregion

        #region Constructor
        public SauceDemoInventoryPage(IWebDriver driver) : base(driver)
        {

        }
        #endregion

        #region Methods
        public void ClickBackpackAddToCart()
        {
            _backpackAddToCartButton.Click();
        }
        public void ClickBackpackRemoveFromCart()
        {
            _backpackRemoveCartButton.Click();
        }
        public void ClickLightAddToCart()
        {
            _lightAddToCartButton.Click();
        }
        public void ClickLightRemoveFromCart()
        {
            _lightRemoveCartButton.Click();
        }
        public void ClickSortContainer()
        {
            _sortContainer.Click();
        }
        public void ClickShoppingCartButton()
        {
            _shoppingCartButton.Click();
        }
        public void ClickLeftMenuShowButton()
        {
            _leftMenuShowButton.Click();
        }
        public void ClickLeftMenuHideButton()
        {
            _leftMenuHideButton.Click();
        }
        public void ClickLogoutButton()
        {
            _logoutButton.Click();
        }
        public void ClickAboutButton()
        {
            _aboutButton.Click();
        }
        public string GetNumberOfItemsIndicator()
        {
            return _numberOfItemsInCardIndicator.Text;
        }
        public void SelectOption(int optionNumber)
        {
            sortingDropdownElement.SelectByIndex(optionNumber);
        }
        #endregion
    }
}