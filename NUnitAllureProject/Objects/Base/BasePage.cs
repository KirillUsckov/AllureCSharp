using LittleFramework.Objects.Constants;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace LittleFramework.Objects.Base
{
    public class BasePage
    {
        protected readonly Application app;

        public BasePage()
        {
            app = Application.GetInstance();
        }
        public virtual By VisibilityLocator
        {
            get
            {
                return null;
            }
        }
        public void AssertIsVisible()
        {
            try
            {
                new WebDriverWait(app.Driver, Timeout.Seconds.OneHundred)
                                                                .Until(ExpectedConditions.ElementIsVisible(VisibilityLocator));
            }
            catch(WebDriverTimeoutException e)
            {
                throw new Exception("Page wasn't opened.", e);
            }
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

        public IReadOnlyCollection<IWebElement> FindElements(By locator, TimeSpan timeout)
        {
            try
            {
                new WebDriverWait(app.Driver, timeout).Until(ExpectedConditions.ElementIsVisible(locator));
                return app.Driver.FindElements(locator);
            }
            catch (WebDriverTimeoutException e)
            {
                return app.Driver.FindElements(locator);
            }
        }

        public IReadOnlyCollection<IWebElement> FindElements(By locator)
        {
            return FindElements(locator, Timeout.DefaultElementWaitTimeout);
        }
    }
}
