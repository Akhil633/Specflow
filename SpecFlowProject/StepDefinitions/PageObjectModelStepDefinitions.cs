using NUnit.Framework;
using NUnit.Framework.Internal.Commands;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProject.Pages;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class PageObjectModelStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private IWebDriver driver;
        SearchPage objSearchPage;
        ResultPage objResultPage;
        ChannelPage objChannelPage;

       public PageObjectModelStepDefinitions(IWebDriver driver) 
        {
            this.driver = driver;
        }

        [Given(@"Enter the youtube URL")]
        public void GivenEnterTheYoutubeURL()
        {
            driver.Url = "https://www.youtube.com/";
            Thread.Sleep(5000);
        }

        [When(@"Search for the testers talk in youtube")]
        public void WhenSearchForTheTestersTalkInYoutube()
        {
            objSearchPage = new SearchPage(driver);
            objResultPage = objSearchPage.searchText("testers talk");
        }

        [When(@"Navigate to channel")]
        public void WhenNavigateToChannel()
        {

            objChannelPage = objResultPage.clickOnChannel();
            Thread.Sleep(5000);
            


        }

        [Then(@"Verify title of the page")]
        public void ThenVerifyTitleOfThePage()
        {
            Assert.AreEqual("Testers Talk - YouTubes", objChannelPage.getTitle());
        }


    }
}