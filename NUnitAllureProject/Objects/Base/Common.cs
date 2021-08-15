using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace LittleFramework.Objects.Base
{
    public class Common
    {
        private readonly Application application;
        public Common()
        {
            application = Application.GetInstance();
        }

        public void PressEnter()
        {
            var builder = new Actions(application.Driver);
            builder.SendKeys(Keys.Enter);
            builder.Perform();
        }
    }
}
