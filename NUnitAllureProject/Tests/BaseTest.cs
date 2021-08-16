using Allure.Commons;
using LittleFramework;
using LittleFramework.Objects.Base;
using NUnit.Framework;
using NUnitAllureProject.Tests.Steps;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitAllureProject.Tests
{
    public class BaseTest : Hooks
    {
        private readonly Navigation navigation;
        private readonly Application application;

        public BaseTest() : base()
        {
            navigation = new Navigation();
            application = Application.GetInstance();
        }
    }
}
