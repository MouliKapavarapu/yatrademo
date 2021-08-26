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
    public sealed class nikepageDefinition : BasePageObject
    {
        Global DriverContext;
        public nikepageDefinition(Global DriverContext) : base(DriverContext)
        {
            this.DriverContext = DriverContext;
        }

        [Given(@"User launched Nike portal")]
        public void GivenUserLaunchedNikePortal()
        {
            nh.tonikehomepage();
        }

        [When(@"User Navigate to All Shoes from Men")]
        public void WhenUserNavigateToAllShoesFromMen()
        {
            nh.toallshoesinmen();
        }

        [Then(@"Verify the Men shoes page is Displayed")]
        public void ThenVerifyTheMenShoesPageIsDisplayed()
        {
            ms.verifymenpage();
        }

        [When(@"User sort the shoes from High to Low")]
        public void WhenUserSortTheShoesFromHighToLow()
        {
            ms.sortightolow();
        }

        [When(@"User selects Nike React Infinity Run Flyknit (.*) By You shoe")]
        public void WhenUserSelectsNikeReactInfinityRunFlyknitByYouShoe(int p0)
        {
            ms.scrollandselectshoe();
        }

        [When(@"User select the size and click on Add to Bag")]
        public void WhenUserSelectTheSizeAndClickOnAddToBag()
        {
            ms.selectsizeaddtobag();
        }

        [Then(@"verify if selected product has been added to cart successfully")]
        public void ThenVerifyIfSelectedProductHasBeenAddedToCartSuccessfully()
        {
            ms.verifyitemincart();
        }

    }
}
