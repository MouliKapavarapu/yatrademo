using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YatraUnitTest.Utilss
{
   public class PageBases : Baseclass
    {
        private Global global;

        public PageBases(Global global) : base(global.Driver)
        {
            this.global = global;
            PageFactory.InitElements(Driver, this);
        }
    }
}
