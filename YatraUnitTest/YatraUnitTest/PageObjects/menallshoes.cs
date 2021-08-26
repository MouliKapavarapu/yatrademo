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
   public class menallshoes : PageBases
    {
        private Global global;
        public menallshoes(Global global) : base(global)
        {
            this.global = global;
        }

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Sort By']")]
        public IWebElement sort;

        [FindsBy(How = How.XPath, Using = "//button[text()='Price: High-Low']")]
        public IWebElement hightolow;

        [FindsBy(How = How.XPath, Using = "(//a[@aria-label='Nike Air Zoom Alphafly NEXT%'])[2]")]
        public IWebElement selectshoes;

        [FindsBy(How = How.XPath, Using = "//label[text()='UK 4.5']")]
        public IWebElement selectsize;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Add to Bag']")]
        public IWebElement addtobag;

        [FindsBy(How = How.XPath, Using = "//span[@class='pre-jewel pre-cart-jewel text-color-primary-dark']")]
        public IWebElement cart;

        [FindsBy(How = How.XPath, Using = "//p[@data-automation='cart-item-product-name']")]
        public IWebElement verifycart;

        public void verifymenpage()
        {
           string s= Driver.Title;
            Console.WriteLine(s);
            Console.WriteLine("Page is displayed");
            Thread.Sleep(2000);
        }
        public void sortightolow()
        {
            sort.Click();
            Thread.Sleep(2000);
            hightolow.Click();
            Thread.Sleep(7000);
        }

        public void scrollandselectshoe()
        {
            selectshoes.Click();
        }
        public void selectsizeaddtobag()
        {
            selectsize.Click();
            Thread.Sleep(2000);
            addtobag.Click();
            Thread.Sleep(5000);
        }
        public void verifyitemincart()
        {
            cart.Click();
           string s= verifycart.Text;
            try
            {
                Assert.AreEqual(s, "Nike Air Zoom Alphafly NEXT%");
                Console.WriteLine("---Nike Air Zoom Alphafly NEXT% is added to cart successfully---");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

        }

    }
}
