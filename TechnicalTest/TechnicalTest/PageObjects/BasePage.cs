using OpenQA.Selenium;
using Protractor;

namespace TechnicalTest.PageObjects
{
    public class BasePage
    {
        protected IWebDriver Driver { get; set; }
        protected NgWebDriver ngDriver { get; set; }

        protected BasePage(IWebDriver driver)
        {
            this.Driver = driver;
            this.ngDriver = new NgWebDriver(driver);
        }

    }
}
