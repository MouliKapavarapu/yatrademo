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
   public class Verifytiltleofarm : PageBases
    {
        private Global global;
        public Verifytiltleofarm(Global global) : base(global)
        {
            this.global = global;
        }
        public void titleofarmpage()
        {
            string s = Driver.Title;
            Console.WriteLine(s);
        }
    }
}
