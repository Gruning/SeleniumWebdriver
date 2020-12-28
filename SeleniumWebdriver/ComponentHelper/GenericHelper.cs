using OpenQA.Selenium;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.ComponentHelper
{
    public class GenericHelper
    {
        public static bool isElementPresent(By Locator) {
            try{
                return ObjectRepository.Driver.FindElements(Locator).Count == 1;
            } catch (Exception) {
                return false;
            }
        }
        public static IWebElement GetElement(By Locator)
        {
            if (isElementPresent(Locator))
                return ObjectRepository.Driver.FindElement(Locator);
            else
                throw new NoSuchElementException($"Element not found:{Locator.ToString()}");
        }
    }
}
