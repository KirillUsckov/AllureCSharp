using Allure.Commons;
using LittleFramework.Objects.Pages;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Allure.Steps;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllureTask.Steps
{
    [AllureNUnit]
    public class SearchingSteps : NUnitAllureProject.Tests.Steps.BaseSteps
    {
        private AllureLifecycle lifecycle;
        private readonly SearchingPagePart searchingPagePart;
        public SearchingSteps()
        {
            searchingPagePart = new SearchingPagePart();
            lifecycle = AllureLifecycle.Instance;
        }

        [AllureStep("Search item")]
        public void SearchItem(string text)
        {
            searchingPagePart.AssertIsVisible();
            searchingPagePart.TypeTextInSearchingTextBox(text);
            searchingPagePart.ClickSearchButton();
        }


    }
}
