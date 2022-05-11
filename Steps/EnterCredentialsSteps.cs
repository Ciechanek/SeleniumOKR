using OpenQA.Selenium;
using SeleniumAppCiechanMateuszOKR.Pages;

namespace SeleniumAppCiechanMateuszOKR.Steps
{
    public class EnterCredentialsSteps : BaseSteps
    {
        SauceDemoMainPage SauceDemoMainPage => new SauceDemoMainPage(Driver);
        public EnterCredentialsSteps(IWebDriver driver) : base(driver)
        {

        }

        public void EnterValidCredentials()
        {
            SauceDemoMainPage.EnterLogin("standard_user");
            SauceDemoMainPage.EnterPassword("secret_sauce");          
        }

        public void EnterInvalidLogin()
        {
            SauceDemoMainPage.EnterLogin("invalid_login");
            SauceDemoMainPage.EnterPassword("secret_sauce");
        }

        public void EnterInvalidPassword()
        {
            SauceDemoMainPage.EnterLogin("standard_user");
            SauceDemoMainPage.EnterPassword("invalid_password");
        }

    }
}
