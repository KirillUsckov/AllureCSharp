using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LittleFramework.Elements
{
    public class TextBox : BaseElement
    {
        public TextBox(Application application, By locator) : base(application, locator)
        {
        }

        public void ClearAndSetText(string text)
        {
            var element = FindElement(locator);
            element.Clear();
            element.SendKeys(text);
        }
    }
}
