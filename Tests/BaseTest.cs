using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.IO;

namespace SeleniumAppCiechanMateuszOKR.Tests
{
    public class BaseTest
    {
        public IWebDriver Driver;

        [SetUp]
        public void LaunchChromeDriver()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://www.saucedemo.com");
        }

        [TearDown]
        public void CloseChromeDriver()
        {
            Driver.Quit();
        }
    }
}
