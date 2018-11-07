using OpenQA.Selenium;
using Protractor;
using TechnicalTest.Extensions;
using TechnicalTest.Models;

namespace TechnicalTest.PageObjects
{
    public class SignUpPage : BasePage
    {
        private IWebElement userName => ngDriver.FindElement(NgBy.Model("$ctrl.formData.username"));
        private IWebElement email => ngDriver.FindElement(NgBy.Model("$ctrl.formData.email"));
        private IWebElement password => ngDriver.FindElement(NgBy.Model("$ctrl.formData.password"));
        private IWebElement signupButton => ngDriver.FindElement(By.CssSelector("button[type='submit']"));
        public SignUpPage(IWebDriver webDriver) : base (webDriver)
        {

        }

        public void CompleteSignUp(SignupDetails signupDetails)
        {
            userName.SendKeys(signupDetails.UserName);
            email.SendKeys(signupDetails.Email);
            password.SendKeys(signupDetails.Password);
            signupButton.Click();            
        }
            
        public bool SignUpPending()
        {
            return signupButton.Exists();
        }
    }
}
