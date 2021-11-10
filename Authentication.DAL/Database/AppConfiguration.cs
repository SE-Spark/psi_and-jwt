using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Authentication.DAL.Database
{
    public class AppConfiguration
    {
        //public AppConfiguration()//on production
        //{
        //    var builder = new ConfigurationBuilder()
        //        .SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location))
        //        .AddJsonFile("appsettings.json");

        //    var configuration = builder.Build();
        //    var appSetting = configuration.GetSection("ConnectionStrings:DefaultConnection");
        //    connstring = appSetting.Value;
        //}
        public string connstring { get; set; }
        public AppConfiguration() //on local machine
        {
            var configBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configBuilder.AddJsonFile(path, false);
            var root = configBuilder.Build();
            var appSetting = root.GetSection("ConnectionStrings:DefaultConnection");
            connstring = appSetting.Value;
        }
    }
}
