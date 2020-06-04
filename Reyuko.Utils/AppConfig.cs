using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace Reyuko.Utils
{
    public class AppConfig : IDisposable
    {
        private static List<AppConfig> _appConfigs;

        private AppConfig()
        {
            ApplicationName = ConfigurationManager.AppSettings["ApplicationName"];
            StorageType = ConfigurationManager.AppSettings["StorageType"];
            Environment = ConfigurationManager.AppSettings["Environment"];
            Trndate = DateTime.Now;
        }

        public static AppConfig Current
        {
            get
            {
                if (_appConfigs == null)
                    _appConfigs = new List<AppConfig>();

                var applicationName = ConfigurationManager.AppSettings["ApplicationName"];
                var contextName = ConfigurationManager.AppSettings["Context"];
                var appConfig = _appConfigs.Where(m => m.ApplicationName == applicationName).FirstOrDefault();
                if (appConfig == null)
                {
                    appConfig = new AppConfig();
                    appConfig.ApplicationName = applicationName;
                    appConfig.ContextName = contextName;
                    _appConfigs.Add(appConfig);
                }

                return appConfig;
            }
        }

        public string ContextName { get; set; }
        public string ApplicationName { get; set; }
        public string StorageType { get; set; }
        public string Environment { get; set; }
        public DateTime Trndate { get; set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
