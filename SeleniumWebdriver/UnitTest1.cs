using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWebdriver.Configuration;
using SeleniumWebdriver.Interfaces;

namespace SeleniumWebdriver
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("www.google.com");//GoToUrl("https://localhost:44339/");
            driver.Close();
            driver.Quit();
        }
        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Browser"));
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Username"));
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Password"));
            Console.WriteLine((int)BrowserType.Chrome);
        }
        [TestMethod]
        public void TestMethod3()
        {
            IConfig config = new XmlReader();
            Console.WriteLine($"Browser {config.GetBrowser()}");
            Console.WriteLine($"Password {config.GetPassword()}");
            Console.WriteLine($"Username {config.GetUsername()}");

        }
    }
}
