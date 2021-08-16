using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LittleFramework.Objects.Locators
{
    public static class SearchingResultPageElements
    {
        public static By PreviewCard(string title) => By.XPath(string.Format("//div[contains(@class,'entity-search__header')]//div[contains(@class,'entity-search__header')]//div[contains(text(),'{0}')]", title));

        public static By Form => By.XPath("//div[@class='main__content' and .//li[contains(@class,'serp-item')] and .//ul[contains(@id,'search-result')]]");
    }
}
