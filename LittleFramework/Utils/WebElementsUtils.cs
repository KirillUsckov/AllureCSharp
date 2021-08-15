using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestAutomationSolution.Utils
{
    public static class WebElementsUtils
    {

        public static string MakeScreenshot(IWebDriver driver, string testName = "screen")
        {
            string projectPath = Path.GetDirectoryName(GetTestAssemblyFolder());
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            string fileLocation = $"{projectPath}/{testName}.png";
            ss.SaveAsFile(fileLocation, ScreenshotImageFormat.Png);
            return fileLocation;
        }

        private static string GetTestAssemblyFolder()
        {
            return Assembly.GetExecutingAssembly().Location;
        }
    }
}