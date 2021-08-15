using LittleFramework.Objects.Base;
using LittleFramework.Objects.Locators;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LittleFramework.Objects.Pages
{
    public class SearchingPagePart : BasePage
    {
        public SearchingPagePart() : base()
        {
        }

        public override By VisibilityLocator
        {
            get
            {
                return SearchingPagePartElements.SearchTextBox;
            }
        }

        public void TypeTextInSearchingTextBox(string text)
        {
            app.TextBox(SearchingPagePartElements.SearchTextBox).ClearAndSetText(text);
        }

        public void ClickSearchButton()
        {
            FindElement(SearchingPagePartElements.SerachButton).Click();
        }
    }
}
