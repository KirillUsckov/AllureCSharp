using LittleFramework.Objects.Base;
using LittleFramework.Objects.Locators;
using OpenQA.Selenium;

namespace NUnitAllureProject.Objects.Pages
{
    public class MainPage : BasePage
    {
        public MainPage() : base()
        {
        }

        public override By VisibilityLocator
        {
            get
            {
                return MainPageElements.Form;
            }
        }
    }
}
