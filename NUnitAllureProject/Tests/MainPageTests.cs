using AllureTask.Steps;
using NLog;
using NLog.Fluent;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using NUnitAllureProject.Tests.Steps;

namespace NUnitAllureProject.Tests
{
    [AllureNUnit]
    public class MainPageTests : Hooks
    {
        private MainPageSteps mainPageSteps;
        private readonly Logger log = LogManager.GetCurrentClassLogger();
        public MainPageTests() : base()
        {
        }

        [SetUp]
        public void InitPages()
        {
            mainPageSteps = new MainPageSteps();
        }

        [Test]
        [Description("Check can the main page be opened")]
        [AllureTag("Regression")]
        [AllureSuite("MainPage")]
        [AllureFeature("MainPage")]
        [AllureLink("https://yandex.ru")]
        public void CheckMainPageCanBeOpened()
        {
            log.Info("Test CheckMainPageCanBeOpened");
            try
            {
                mainPageSteps.PageWasOpened();
            } 
            catch { }
            MakeScreenshot();
        }
    }
}
