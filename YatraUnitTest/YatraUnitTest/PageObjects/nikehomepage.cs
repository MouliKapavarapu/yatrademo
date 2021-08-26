using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium.Support.PageObjects;
using System.Text;
using System.Threading.Tasks;
using YatraUnitTest.Utilss;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;

namespace YatraUnitTest.PageObjects
{
   public class nikehomepage : PageBases
    {
        private Global global;
        public nikehomepage(Global global) : base(global)
        {
            this.global = global;
        }

        [FindsBy(How = How.XPath, Using = "//a[@aria-label='Men']")]
        public IWebElement men;

        [FindsBy(How = How.XPath, Using = "//a[@data-path='men:shoes:all shoes']")]
        public IWebElement allshoes;

        public void tonikehomepage()
        {
            var url = GlobalVariables.YatraUrl;
            Driver.Navigate().GoToUrl(url);
            Driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
        }
        public void toallshoesinmen()
        {
            Actions a = new Actions(Driver);
           // Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            a.MoveToElement(men).Build().Perform();
            a.Click(allshoes).Build().Perform();
            Thread.Sleep(5000);
        }

    }
}
