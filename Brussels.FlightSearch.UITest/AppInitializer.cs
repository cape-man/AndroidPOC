using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Brussels.FlightSearch.UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .ApkFile(@"D:\MyProjects\ABG\MDMS\POC_Working\NewSajitTest.git\trunk\Brussels.FlightSearch\Brussels.FlightSearch.Android\bin\Release\Brussels.FlightSearch.Android-Signed.apk")
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                .StartApp();
        }
    }
}

