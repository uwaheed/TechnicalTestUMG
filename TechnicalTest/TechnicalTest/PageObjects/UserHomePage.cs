using OpenQA.Selenium;
using TechnicalTest.Extensions;

namespace TechnicalTest.PageObjects
{
    public class UserHomePage : BasePage
    {
        private IWebElement settingsLink => ngDriver.FindElement(By.CssSelector("a[ui-sref='app.settings']"));
        private IWebElement userName => ngDriver.FindElement(By.CssSelector("a.nav-link.ng-binding"));
        public UserHomePage(IWebDriver driver) : base(driver)
        {

        }

        public bool IsLoggedIn()
        {
            return settingsLink.Exists();
        }

        public string GetUserName()
        {
            return userName.Text;
        }
    }
}
