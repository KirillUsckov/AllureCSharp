using LittleFramework.Objects.Pages;
using NUnit.Allure.Core;
using NUnit.Allure.Steps;
using NUnit.Framework;
using NUnitAllureProject.Objects.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AllureTask.Steps
{
    [AllureNUnit]
    public class MainPageSteps : NUnitAllureProject.Tests.Steps.BaseSteps
    {
        public readonly MainPage mainPage;

        public MainPageSteps()
        {
            mainPage = new MainPage();
        }

        [AllureStep("Check is main page opened")]
        public void PageWasOpened()
        {
            mainPage.AssertIsVisible();
        }

    }
}
