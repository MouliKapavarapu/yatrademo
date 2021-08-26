using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using YatraUnitTest.PageObjects;
using YatraUnitTest.Utilss;

namespace YatraUnitTest.Stepdefinitions
{
    [Binding]
    public sealed class HomePageDefinition : BasePageObject
    {
        Global DriverContext;
        public HomePageDefinition(Global DriverContext) : base(DriverContext)
        {
            this.DriverContext = DriverContext;
        }

        [Given(@"User Launched airasia portal")]
        public void GivenUserLaunchedAirasiaPortal()
        {
            ah.toairasiahomepage();
        }

        [When(@"User selects To and From destination")]
        public void WhenUserSelectsToAndFromDestination()
        {
            ah.makedestination();
        }

        [When(@"User search for Flights")]
        public void WhenUserSearchForFlights()
        {
            ah.searchforflight();
        }

        [When(@"User selects any flight")]
        public void WhenUserSelectsAnyFlight()
        {
            sf.selectflight();
        }

        [When(@"User click on continue")]
        public void WhenUserClickOnContinue()
        {
            sf.clickoncontinue();
        }

        [Then(@"Verify user redirect to guest details page")]
        public void ThenVerifyUserRedirectToGuestDetailsPage()
        {
            sf.verifyguestdetailspae();
        }


    }
}
