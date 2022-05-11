using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumAppCiechanMateuszOKR.Pages;

namespace SeleniumAppCiechanMateuszOKR.Tests
{
    public class AddTwoItemsToCardTest : BaseTest
    {
        SauceDemoInventoryPage SauceDemoInventoryPage => new SauceDemoInventoryPage(Driver);
        SauceDemoMainPage SauceDemoMainPage => new SauceDemoMainPage(Driver);
    }
}
