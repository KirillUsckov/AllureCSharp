using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Allure.Commons;
using LittleFramework;
using LittleFramework.Objects.Base;
using NLog.Fluent;
using NUnit.Allure.Core;
using NUnit.Allure.Steps;
using NUnit.Framework;
using OpenQA.Selenium;

namespace NUnitAllureProject.Tests.Steps
{
    [AllureNUnit]
    public class Hooks
    {
        private Application application;
        private Navigation navigation;

        public Hooks()
        {
        }

        [OneTimeSetUp, Order(0)]
        public void AllureSetUp()
        {
            application = Application.GetInstance();
            Environment.CurrentDirectory = application.Configuration.DirPath;
            //AllureLifecycle.Instance.CleanupResultDirectory();
        }

        [SetUp, Order(0)]
        public void Init()
        {
            navigation = new Navigation();
            application = Application.GetInstance();
        }

        [SetUp, Order(1)]
        [AllureStep("Go to base URL")]
        public void GoToBaseUrl()
        {
            navigation.ToBaseUrl();
        }

        [TearDown]
        public void TearDown()
        {
            /*Screenshot ss = ((ITakesScreenshot)application.Driver).GetScreenshot();
            var path = application.Configuration.DirPath + "\\screenshots\\" + DateTime.Now.Ticks + ".png";
            ss.SaveAsFile(path, ScreenshotImageFormat.Png);
            AllureLifecycle.Instance.AddAttachment(path);*/
            application.CloseDriver();
        }

        [OneTimeTearDown]
        public void Finally()
        {
            var path = Path.Combine(application.Configuration.DirPath + "\\screenshots");

            DirectoryInfo di = new DirectoryInfo(path);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            
        }

        public void MakeScreenshot()
        {
            Screenshot ss = ((ITakesScreenshot)application.Driver).GetScreenshot();
            var path = application.Configuration.DirPath + "\\screenshots\\" + DateTime.Now.Ticks + ".png";
            ss.SaveAsFile(path, ScreenshotImageFormat.Png);
            AllureLifecycle.Instance.AddAttachment(path);
        }
    }
}
