using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWebdriver.Configuration;
using SeleniumWebdriver.CustomException;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.BaseClasses
{
    [TestClass]
    public class BaseClass
    {
        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }
        [AssemblyInitialize]
        public static void InitWebDriver(TestContext tc){
            ObjectRepository.Config = AppConfigReader();
            switch (ObjectRepository.Config.GetBrowser)
            {
                case BreowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;
                default:
                    throw new NoSuitableDirverFound("Driver not found : {0}", ObjectRepository.Config.GetBrowser().ToString());
            }
        }
    }
}
