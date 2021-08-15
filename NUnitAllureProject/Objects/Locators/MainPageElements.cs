using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LittleFramework.Objects.Locators
{
    public class MainPageElements
    {
        public static By Form => By.XPath("//div[contains(@class,'body') and .//div[contains(@class,'search')] and .//*[contains(@class,'col widgets')]]");
    }
}
