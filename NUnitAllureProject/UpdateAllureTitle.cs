using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NUnitAllureProject
{

    public static class UpdateAllureTitle
    {
        [Test]
        public static void Update()
        {
            var url = "P:\\VisualStudio\\CSharpAllureNunit\\NUnitAllureProject\\allure-report\\widgets\\summary.json";
            var title = "A1QA Allure Report";
            string str = File.ReadAllText(url);
            str = str.Replace("Allure Report", title);
            File.Delete(url);
            File.WriteAllText(url, str);
        }
    }
}
