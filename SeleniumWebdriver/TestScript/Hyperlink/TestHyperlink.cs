using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.TestScript.Hyperlink
{
    [TestClass]
    class TestHyperlink
    {
        public void clickLink() { 
             ObjectRepository.Driver.FindElement(By.LinkText("https://www.google.com.ar/imghp?hl=es-419&amp;tab=wi&amp;ogbl"))
        }
    }
}
