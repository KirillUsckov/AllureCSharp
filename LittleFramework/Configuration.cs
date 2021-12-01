using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace LittleFramework.Objects
{
    public class Configuration
    {

        private ConfModel configuration;

        private string confUrl = @"\conf.json";

        public string DirPath { get; private set; }

        public string LogsPath
        {
            get
            {
                if (Directory.GetCurrentDirectory().Contains("\\bin\\Debug"))
                {
                    return Path.Combine(Directory.GetCurrentDirectory(), "logs");
                }
                else
                {
                    return Path.Combine(Directory.GetCurrentDirectory(), "bin", "Debug", "netcoreapp3.1", "logs");
                }
            }
        }

        public Configuration()
        {
            //var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            
            var baseDir = Directory.GetCurrentDirectory();
            baseDir = baseDir.Contains("NUnitAllureProject") ? baseDir : baseDir + "\\NUnitAllureProject";
            var id = baseDir.IndexOf("\\bin\\Debug");
            DirPath = baseDir.Contains("\\bin\\Debug") ? baseDir.Substring(0, id) : baseDir;
            var fullPath = DirPath + confUrl;
            configuration = JsonConvert.DeserializeObject<ConfModel>(File.ReadAllText(fullPath));
        }        

        public string GetUrl()
        {
            return configuration.Url;
        }

        private class ConfModel
        {
            public string Url { get; set; }
        }

    }

}
