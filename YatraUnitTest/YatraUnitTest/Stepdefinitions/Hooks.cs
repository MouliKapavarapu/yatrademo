using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using YatraUnitTest.Utilss;

namespace YatraUnitTest.Stepdefinitions
{
    [Binding]
       public class Hooks
        {
            private Global browser;

            public Hooks(Global browser)
            {
                this.browser = browser;
            }

            [BeforeScenario]
            public void BeforeScenario(FeatureContext fcontext, ScenarioContext scontext)
            {
                browser.Driver = Browsersupport.Initialize();
                browser.FeatureName = fcontext.FeatureInfo.Title;
            }

            [AfterScenario]
            public void AfterScenario()
            {
                browser.Driver?.Quit();
            }
        }
    }
