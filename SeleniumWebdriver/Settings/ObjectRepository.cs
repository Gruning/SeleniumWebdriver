﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.Settings
{
    public class ObjectRepository
    {
        public IConfig Config{ get; set; }
        public IWebDriver Driver{ get; set; }

    }
}