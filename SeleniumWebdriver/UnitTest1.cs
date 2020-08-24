using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebdriver
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://localhost:44339/");
            driver.Close();
            driver.Quit();
        }
        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Browser"));
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Username"));
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Password"));

        }
    }
}
