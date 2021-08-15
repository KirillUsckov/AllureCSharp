using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LittleFramework.Objects.Locators
{
    public static class SearchingPagePartElements
    {
        public static By SearchTextBox => By.XPath("//*[contains(.,'search')]//input[contains(@class,'control')]");

        public static By SerachButton => By.XPath("//*[contains(@class,'button') and contains(@class,'search') and @type='submit']");
    }
}
