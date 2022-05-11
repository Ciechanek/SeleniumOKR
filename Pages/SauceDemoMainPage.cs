using OpenQA.Selenium;

namespace SeleniumAppCiechanMateuszOKR.Pages
{
    public class SauceDemoMainPage : BasePage
    {
        IWebElement _loginField => Driver.FindElement(By.Id("user-name"));
        IWebElement _passwordField => Driver.FindElement(By.Id("password"));
        IWebElement _loginButton => Driver.FindElement(By.Id("login-button"));
        IWebElement _loginErrorMessage => Driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[1]/div[1]/div/form/div[3]/h3"));
        public SauceDemoMainPage(IWebDriver driver) : base(driver)
        {
            
        }

        public void EnterLogin(string login)
        {
            _loginField.SendKeys(login);
        }

        public void EnterPassword(string password)
        {
            _passwordField.SendKeys(password);
        }

        public void ClickLogin()
        {
            _loginButton.Click();
        }

        public string GetLogin()
        {            
            return _loginField.GetAttribute("value");
        }

        public string GetPassword()
        {
            return _passwordField.GetAttribute("value");
        }

        public string GetLoginErrorText()
        {
            return _loginErrorMessage.Text;
        }
    }
}