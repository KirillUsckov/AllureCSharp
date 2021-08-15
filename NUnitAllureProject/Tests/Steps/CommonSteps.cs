using LittleFramework.Objects.Base;
using NUnit.Allure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllureTask.Steps
{
    [AllureNUnit]
    public class CommonSteps : NUnitAllureProject.Tests.Steps.BaseSteps
    {

        private readonly Common common;

        public CommonSteps()
        {
            common = new Common();
        }

       
    }
}
