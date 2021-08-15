using LittleFramework.Objects.Base;
using LittleFramework.Objects.Locators;
using OpenQA.Selenium;

namespace LittleFramework.Objects.Pages
{
    public class SearchingResultsPage : BasePage
    {

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
            return FindElements(SearchingResultPageElements.PreviewCard(title)).Count > 0;
        }
    }
}
