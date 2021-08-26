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
    public class YatraHomePage : PageBases
    {
        private Global global;
        public YatraHomePage(Global global) : base(global)
        {
            this.global = global;
        }

        [FindsBy(How = How.XPath, Using = "//a[@title = 'Accept and hide this message ']")]
        public IWebElement acceptcookie;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Copyright')]")]
        public IWebElement copyright;
        
        public void toarmhomepage()
        {
            var url = GlobalVariables.YatraUrl;
            Driver.Navigate().GoToUrl(url);
            Driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
        }
        public void acceptcookies()
        {
            acceptcookie.Click();
            Thread.Sleep(3000);
        }
        public void verifycopyrighttext()
        {
            string s= copyright.Text;
            try
            {
                Assert.AreEqual(s, "Copyright © 1995-2021 Arm Limited (or its affiliates). All rights reserved.");
                Console.WriteLine("-----The Copyright text is Verigied Successfully-----");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            } 
        }

        

    }
}
