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

        public Configuration()
        {
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var id = baseDir.IndexOf("\\bin\\Debug");
            var lenght = "\\bin\\Debug".Length;
            baseDir = baseDir.Substring(0, id - lenght);
            baseDir = baseDir.Replace("LittleFramework", string.Empty);
            var fullPath = baseDir + confUrl;
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
