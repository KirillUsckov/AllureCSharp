using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace LittleFramework.Objects.Base
{
    public class Navigation
    {
        private readonly Application app;

        public Navigation()
        {
            app = Application.GetInstance();
        }

        public void ToBaseUrl()
        {
            var url = app.Configuration.GetUrl();
            app.Driver.Navigate().GoToUrl(url);
        }
    }
}
