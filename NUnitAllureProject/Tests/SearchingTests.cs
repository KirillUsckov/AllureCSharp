using Allure.Commons;
using AllureTask.Steps;
using Autotests.Steps;
using LittleFramework.Objects.Pages;
using NLog;
using NLog.Fluent;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using NUnitAllureProject.Tests.Steps;
using System.Collections.Generic;

namespace NUnitAllureProject.Tests
{
    [AllureNUnit]
    public class SearchingTests : Hooks
    {
        private MainPageSteps mainPageSteps;
        private SearchingSteps searchingSteps;
        private SearchingResultsPageSteps searchingResultsPageSteps;
        private SearchingPagePart searchingPagePart;
        private readonly Logger log = LogManager.GetCurrentClassLogger();

        public SearchingTests() : base()
        {
        }

        [SetUp]
        public void InitPages()
        {
            mainPageSteps = new MainPageSteps();
            searchingSteps = new SearchingSteps();
            searchingResultsPageSteps = new SearchingResultsPageSteps();
            searchingPagePart = new SearchingPagePart();
        }


        private static IEnumerable<TestCaseData> AddQueryResultData()
        {
            yield return new TestCaseData("Google", "Google");
            yield return new TestCaseData("”бер", "”бер");
            yield return new TestCaseData("яндекс", "яндекс");
        }

        [Test, TestCaseSource("AddQueryResultData")]
        [Description("Is Infotable displayed after searching item")]
        [AllureTag("Regression")]
        [AllureFeature("Searching")]
        [AllureSuite("SearchingPage")]
        [AllureLink("https://yandex.ru")]
        public void CheckResultInfotableWasOpeneForSearchingItem(string query, string title)
        {
            log.Info("Test case CheckResultInfotableWasOpeneForSearchingItem");
            mainPageSteps.PageWasOpened();
            searchingSteps.SearchItem(query);
            searchingResultsPageSteps.CheckResultPageWithInfotable(title);
        }

        [Test]
        [Description("Is Searching result page displayed after searching item")]
        [AllureTag("Regression")]
        [AllureFeature("Searching")]
        [AllureSuite("SearchingPage")]
        [AllureLink("https://yandex.ru")]
        public void CheckSearchingPageWasOpened()
        {
            log.Info("Test case CheckSearchingPageWasOpened");
            mainPageSteps.PageWasOpened();
            searchingSteps.SearchItem("Google");
            searchingPagePart.AssertIsVisible();
        }
    }
}