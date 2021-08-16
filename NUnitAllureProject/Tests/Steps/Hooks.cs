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

        [TearDown, Order(0)]
        public void TearDown()
        {
            application.CloseDriver();
        }

        [TearDown, Order(1)]
        public void AddLog()
        {
            var path = Path.Combine(application.Configuration.DirPath + "\\logs\\testLogs.log");


            AllureLifecycle.Instance.AddAttachment(path);

        }
    }
}
