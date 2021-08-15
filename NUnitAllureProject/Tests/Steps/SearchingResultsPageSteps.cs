using LittleFramework.Objects.Pages;
using NUnit.Allure.Core;
using NUnit.Allure.Steps;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Autotests.Steps
{
    [AllureNUnit]
    public class SearchingResultsPageSteps : NUnitAllureProject.Tests.Steps.BaseSteps
    {
        public readonly SearchingResultsPage searchingResultsPage;

        public SearchingResultsPageSteps()
        {
            searchingResultsPage = new SearchingResultsPage();
        }

        [AllureStep("Check is infotable for current searching exist")]
        public void CheckResultPageWithInfotable(string title)
        {
            searchingResultsPage.AssertIsVisible();
            var isTablePresent = searchingResultsPage.IsTableWithTitlePresent(title);
            Assert.IsTrue(isTablePresent, $"Table with title '{title}' should exist on the searching result page, but it doesn't.");
        }

    }
}
