using NUnit.Framework.Internal.Commands;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class FirstPageStepDefenition
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private IWebDriver driver;
       public FirstPageStepDefenition(IWebDriver driver) 
        {
            this.driver = driver;
        }
        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
 //moved
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://www.youtube.com";
        }

        [Then(@"search for the video testing")]
        public void ThenSearchForTheVideoTesting()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys("Testers");
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(Keys.Enter);
            Thread.Sleep(5000);
        }

        [Then(@"say something")]
        public void ThenSaySomething()
        {
            driver.Quit();
        }

    }
}