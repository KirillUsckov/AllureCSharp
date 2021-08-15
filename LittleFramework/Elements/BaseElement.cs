using LittleFramework.Objects.Constants;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace LittleFramework.Elements
{
    public class BaseElement
    {
        protected readonly By locator;
        private readonly Application app;

        public BaseElement(Application application, By locator)
        {
            this.locator = locator;
            app = application;
        }

        public IWebElement FindElement(By locator, TimeSpan timeout)
        {
            try
            {
                new WebDriverWait(app.Driver, timeout).Until(ExpectedConditions.ElementIsVisible(locator));
                return app.Driver.FindElement(locator);
            }
            catch (WebDriverTimeoutException e)
            {
                return app.Driver.FindElement(locator);
            }
        }

        public IWebElement FindElement(By locator)
        {
            return FindElement(locator, Timeout.DefaultElementWaitTimeout);
        }
    }
}
