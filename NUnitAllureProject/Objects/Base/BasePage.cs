using LittleFramework.Objects.Constants;
using NLog;
using NLog.Fluent;
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
        private readonly Logger log = LogManager.GetCurrentClassLogger();

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
            log.Info("Assert is visible");
            try
            {
                new WebDriverWait(app.Driver, Timeout.Seconds.OneHundred)
                                                                .Until(ExpectedConditions.ElementIsVisible(VisibilityLocator));
            }
            catch(WebDriverTimeoutException e)
            {
                log.Error("Page wasn't opened:\n" + e);
                throw new Exception("Page wasn't opened.", e);
            }
        }

        public IWebElement FindElement(By locator, TimeSpan timeout)
        {
            log.Info("Find element with locator: " + locator);
            try
            {
                new WebDriverWait(app.Driver, timeout).Until(ExpectedConditions.ElementIsVisible(locator));
                return app.Driver.FindElement(locator);
            }
            catch (WebDriverTimeoutException e)
            {
                log.Error("Error while element searching:\n" + e);
                return app.Driver.FindElement(locator);
            }
        }

        public IWebElement FindElement(By locator)
        {
            return FindElement(locator, Timeout.DefaultElementWaitTimeout);
        }

        public IReadOnlyCollection<IWebElement> FindElements(By locator, TimeSpan timeout)
        {
            log.Info("Find elements with locator: " + locator);
            try
            {
                new WebDriverWait(app.Driver, timeout).Until(ExpectedConditions.ElementIsVisible(locator));
                return app.Driver.FindElements(locator);
            }
            catch (WebDriverTimeoutException e)
            {
                log.Error("Error while elements searching:\n" + e);
                return app.Driver.FindElements(locator);
            }
        }

        public IReadOnlyCollection<IWebElement> FindElements(By locator)
        {
            return FindElements(locator, Timeout.DefaultElementWaitTimeout);
        }
    }
}
