using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
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
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebSite());
            try
            {

                ObjectRepository.Driver.FindElement(By.TagName("input"));
                ObjectRepository.Driver.FindElement(By.ClassName("btn"));
                ObjectRepository.Driver.FindElement(By.CssSelector("#find"));
                ObjectRepository.Driver.FindElement(By.LinkText("Gmail"));
                //ObjectRepository.Driver.FindElement(By.PartialLinkText("Gmail"));
                //ObjectRepository.Driver.FindElement(By.Name("Gmail"));
                ObjectRepository.Driver.FindElement(By.Id("footcnt"));
                //ObjectRepository.Driver.FindElement(By.XPath("Gmail"));
            }
            catch (NoSuchElementException e)
            {

                Console.WriteLine(e);
            }

        }
    }
}
