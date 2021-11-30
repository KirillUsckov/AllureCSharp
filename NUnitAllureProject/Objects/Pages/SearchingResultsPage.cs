using LittleFramework.Objects.Base;
using LittleFramework.Objects.Locators;
using NLog;
using NLog.Fluent;
using OpenQA.Selenium;

namespace LittleFramework.Objects.Pages
{
    public class SearchingResultsPage : BasePage
    {
        private readonly Logger log =  LogManager.GetCurrentClassLogger();

        public SearchingResultsPage() : base()
        {

        }

        public override By VisibilityLocator
        {
            get
            {
                return SearchingResultPageElements.Form;
            }
        }

        public bool IsTableWithTitlePresent(string title)
        {
            log.Info($"Check is table with title '{title}' exist");
            return FindElements(SearchingResultPageElements.PreviewCard(title)).Count > 0;
        }
    }
}
