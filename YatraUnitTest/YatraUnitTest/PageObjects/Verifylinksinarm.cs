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
    public class Verifylinksinarm : PageBases
    {
        private Global global;
        public Verifylinksinarm(Global global) : base(global)
        {
            this.global = global;
        }
        //links
        [FindsBy(How = How.XPath, Using = "(//li[@class='o-list__item c-footer__legal-link'])[1]")]
        public IWebElement cookiepolicy;

        [FindsBy(How = How.XPath, Using = "(//li[@class='o-list__item c-footer__legal-link'])[2]")]
        public IWebElement termsofuse;

        [FindsBy(How = How.XPath, Using = "(//li[@class='o-list__item c-footer__legal-link'])[3]")]
        public IWebElement privacypolicy;
        //verifyxpath
        [FindsBy(How = How.XPath, Using = "//div[@class='c-masthead__slider__item__content__theme__title']")]
        public IWebElement verifylink;

        public void verifylinkcookiepolicy()
        {
            cookiepolicy.Click();
            Thread.Sleep(2000);
            string t = verifylink.Text;
            try
            {
                Assert.AreEqual(t, "COOKIE POLICY");
                Console.WriteLine("---Verified COOKIE POLICY LINK---");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Thread.Sleep(3000);
        }
        public void verifylinktermsofuse()
        {
            termsofuse.Click();
            Thread.Sleep(2000);
            string t = verifylink.Text;
            try
            {
                Assert.AreEqual(t, "TERMS AND CONDITIONS");
                Console.WriteLine("---Verified TERMS AND CONDITIONS LINK---");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Thread.Sleep(3000);
        }
        public void verifylinkprivacypolicy()
        {
            privacypolicy.Click();
            Thread.Sleep(2000);
            string t = verifylink.Text;
            try
            {
                Assert.AreEqual(t, "PRIVACY POLICY");
                Console.WriteLine("---Verified PRIVACY POLICY LINK---");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
