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
namespace YatraUnitTest.PageObjects
{
    public class airasiahomepage : PageBases
    {
        private Global global;
        public airasiahomepage(Global global) : base(global)
        {
            this.global = global;
        }

        [FindsBy(How = How.XPath, Using = "(//div[@class='flight-search-source-code'])[2]")]
        public IWebElement to;

        [FindsBy(How = How.XPath, Using = "(//button[@id='list-item'])[1]")]
        public IWebElement tocity;

        [FindsBy(How = How.XPath, Using = "//div[@id='start-date-input-button']")]
        public IWebElement calender;

        [FindsBy(How = How.XPath, Using = "(//div[text()='26'])[2]")]
        public IWebElement date;
        
        [FindsBy(How =How.XPath,Using = "//button[@class='btn-flight']")]
        public IWebElement cont;

        public void toairasiahomepage()
        {
            var url = GlobalVariables.YatraUrl;
            Driver.Navigate().GoToUrl(url);
            Driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
        }

        public void makedestination()
        {
            to.Click();
            Thread.Sleep(2000);
            tocity.Click();
            calender.Click();
            Thread.Sleep(1000);
            date.Click();
            Thread.Sleep(2000);
        }

        public void searchforflight()
        {
            cont.Click();
            Thread.Sleep(5000);
          
        }

    }
}
