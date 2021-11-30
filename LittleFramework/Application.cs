using LittleFramework.Elements;
using LittleFramework.Objects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace LittleFramework
{
    public class Application
    {
        public IWebDriver Driver { get; private set; }

        private static Application application;

        public Configuration Configuration
        {
            get
            {
                return new Configuration();
            }
        }

        public TextBox TextBox(By locator)
        {
            return new TextBox(application, locator);
        }

        private Application()
        {
            ChromeOptions options = new ChromeOptions();

            options.AcceptInsecureCertificates = true;
            options.AddArgument("no-sandbox");
            options.AddUserProfilePreference("profile.default_content_setting_values.automatic_downloads", 1);
            options.AddUserProfilePreference("download.prompt_for_download", false);
            options.AddArgument("--disable-popup-blocking");
            options.AddArgument("--disable-web-security");
            options.AddArgument("--allow-running-insecure-content");
            options.AddArgument("--ignore-certificate-errors");
            options.AddArgument("disable-infobars");
            options.AddArgument("--disable-extensions");
            options.AddAdditionalCapability("useAutomationExtension", false);
            Driver = new ChromeDriver(options);
            Driver.Manage().Window.Maximize();
        }

        public static Application GetInstance()
        {
            if (application == null)
            {
                application = new Application();
            }
            return application;
        }

        public void CloseDriver()
        {
            Driver.Quit();
            application = null;
        }

    }
}
