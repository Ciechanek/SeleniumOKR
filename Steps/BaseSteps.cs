using OpenQA.Selenium;

namespace SeleniumAppCiechanMateuszOKR.Steps
{
    public class BaseSteps
    {
        public IWebDriver Driver;

        public BaseSteps(IWebDriver driver)
        {
            Driver = driver;
        }

    }
}
