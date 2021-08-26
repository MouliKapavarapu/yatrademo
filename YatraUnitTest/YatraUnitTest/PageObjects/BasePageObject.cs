using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YatraUnitTest.Utilss;

namespace YatraUnitTest.PageObjects
{
    public class BasePageObject
    {
        private readonly Global browser;
        public YatraHomePage yhp;
        public Verifylinksinarm vla;
        public Verifytiltleofarm vta;
        public airasiahomepage ah;
        public searchflights sf;
        public nikehomepage nh;
        public menallshoes ms;
        public BasePageObject(Global browser)
        {
            this.browser = browser;
            yhp = new YatraHomePage(browser);
            vla = new Verifylinksinarm(browser);
            vta = new Verifytiltleofarm(browser);
            ah = new airasiahomepage(browser);
            sf = new searchflights(browser);
            nh = new nikehomepage(browser);
            ms = new menallshoes(browser);
        }
    }
}
