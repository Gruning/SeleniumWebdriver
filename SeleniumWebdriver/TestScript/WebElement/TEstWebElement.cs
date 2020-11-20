using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.TestScript.WebElement
{
    [TestClass]
    public class TestWebElement
    {
        [TestMethod]public void GetElement() {
            ObjectRepository.Driver.FindElement(By.TagName("input"));
            ObjectRepository.Driver.FindElement(By.ClassName("btn"));
            ObjectRepository.Driver.FindElement(By.CssSelector("#find"));
            ObjectRepository.Driver.FindElement(By.LinkText("Gmail"));

        }
    }
}
