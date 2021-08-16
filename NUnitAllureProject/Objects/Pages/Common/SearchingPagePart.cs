using LittleFramework.Objects.Base;
using LittleFramework.Objects.Locators;
using NLog;
using NLog.Fluent;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LittleFramework.Objects.Pages
{
    public class SearchingPagePart : BasePage
    {
        private readonly Logger log = LogManager.GetCurrentClassLogger();
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
            log.Info("Type text in searching textbox");
            app.TextBox(SearchingPagePartElements.SearchTextBox).ClearAndSetText(text);
        }

        public void ClickSearchButton()
        {
            log.Info("Click search button");
            FindElement(SearchingPagePartElements.SerachButton).Click();
        }
    }
}
