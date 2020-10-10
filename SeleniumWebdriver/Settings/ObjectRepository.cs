using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumWebdriver.Interfaces;

namespace SeleniumWebdriver.Settings
{
    public class ObjectRepository
    {
        public static IConfig Config{ get; set; }
        public static IWebDriver Driver{ get; set; }

    }
}
