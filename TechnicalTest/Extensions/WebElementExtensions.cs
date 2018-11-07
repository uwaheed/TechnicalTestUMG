using OpenQA.Selenium;

namespace TechnicalTest.Extensions
{
    public static class WebElementExtensions
    {
        public static bool Exists(this IWebElement element)
        {

            try
            {
                return element.Displayed && element.Enabled;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
