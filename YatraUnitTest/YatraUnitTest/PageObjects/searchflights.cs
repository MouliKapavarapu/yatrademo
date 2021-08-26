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
   public class searchflights : PageBases
    {
        private Global global;
        public searchflights(Global global) : base(global)
        {
            this.global = global;
        }

        [FindsBy(How = How.XPath, Using = "(//span[@class='input-box'])[1]")]
        public IWebElement flight;

        [FindsBy(How = How.XPath, Using = "//button[@class='continue-btn']")]
        public IWebElement cont1;

        [FindsBy(How = How.XPath, Using = "//span[text()='Guest Details']")]
        public IWebElement guestdetails;

        public void selectflight()
        {
            flight.Click();
            Thread.Sleep(2000);
        }
        public void clickoncontinue()
        {
            cont1.Click();
            Thread.Sleep(3000);
        }
        public void verifyguestdetailspae()
        {
           string s= guestdetails.Text;
            try
            {
                Assert.AreEqual(s, "Guest Details");
                Console.WriteLine("User successfully reirected to guest details page");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
