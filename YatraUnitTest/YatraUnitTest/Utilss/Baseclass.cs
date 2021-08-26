using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YatraUnitTest.Utilss
{
    public class Baseclass
    {
        public Baseclass(IWebDriver Driver)
        {
            this.Driver = Driver;
        }
        public IWebDriver Driver { get; set; }
    }
}
