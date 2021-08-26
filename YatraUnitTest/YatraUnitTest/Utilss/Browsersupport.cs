using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YatraUnitTest.Utilss
{
   public class Browsersupport
    {
        public static IWebDriver Initialize()
        {
            IWebDriver Driver = new ChromeDriver();
            return Driver;
        }
    }
}
