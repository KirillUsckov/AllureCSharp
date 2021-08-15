using LittleFramework.Objects.Base;
using NUnit.Framework;
using NUnitAllureProject.Tests.Steps;
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

        public BaseTest() : base()
        {
            navigation = new Navigation();
        }
    }
}
