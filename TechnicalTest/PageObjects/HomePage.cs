using OpenQA.Selenium;
using System.Configuration;
using TechnicalTest.Extensions;

namespace TechnicalTest.PageObjects
{
    public class HomePage : BasePage
    {
        private string homePageUrl = ConfigurationManager.AppSettings["WebsiteUrl"];
        private IWebElement signupButton => ngDriver.FindElement(By.XPath("//a[contains(text(),'Sign up')]"));
        private IWebElement signinButton => ngDriver.FindElement(By.XPath("//a[contains(text(),'Sign in')]"));
        
        public HomePage(IWebDriver driver) : base(driver)
        {
            
        }

        public void GoTo()
        {
            ngDriver.Url = homePageUrl;            
        }
        
        public bool NotLoggedIn()
        {
            return signinButton.Exists();
        }

        public void OpenSignUpPage()
        {
            signupButton.Click();
        }
    }
}
