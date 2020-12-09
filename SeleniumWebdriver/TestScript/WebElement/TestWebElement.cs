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
                ObjectRepository.Driver.FindElements(By.TagName("input"));

                // var byCss = ObjectRepository.Driver.FindElement(By.CssSelector("#find"));
                //var byBlass = ObjectRepository.Driver.FindElement(By.ClassName("btn"));
                //ObjectRepository.Driver.FindElement(By.PartialLinkText("Gmail"));
                //ObjectRepository.Driver.FindElement(By.Name("Gmail"));
                //ObjectRepository.Driver.FindElement(By.XPath("Gmail"));

                //var byTag = ObjectRepository.Driver.FindElement(By.TagName("input"));
                //var byId = ObjectRepository.Driver.FindElement(By.Id("footcnt"));
                //var byLink = ObjectRepository.Driver.FindElement(By.LinkText("Gmail"));
                //IList<string> list = new List<string>();
                //list.Add("Task 1");
                //list.Add("Task 2");
                //list.Add("Task 3");
                //Console.WriteLine($"size {list.Count}");
                //list.Remove("Task 2");
                //Console.WriteLine($"size {list.Count}");
                //Console.WriteLine($"Value {list[0]}");
                //list.Clear();
                //Console.WriteLine($"size {list.Count}");


            }
            catch (NoSuchElementException e)
            {

                Console.WriteLine(e);
            }

        }
    }
}
