using Allure.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitAllureProject.Tests.Steps
{
    public class BaseSteps
    {
        protected readonly AllureLifecycle lifecycle;
        public BaseSteps()
        {
            lifecycle = AllureLifecycle.Instance;
        }
    }
}
