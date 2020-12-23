using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.TestScript.Hyperlink
{
    [TestClass]
    public class TestHyperlink
    {
        [TestMethod]
        public void clickLink() {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebSite());
            //IWebElement element = ObjectRepository.Driver.FindElement(By.LinkText("Imágenes"));
            //element.Click();

            IWebElement pelement = ObjectRepository.Driver.FindElement(By.PartialLinkText("Gma"));
            pelement.Click();
        }
    }
}
