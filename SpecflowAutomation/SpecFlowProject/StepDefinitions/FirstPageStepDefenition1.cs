using NUnit.Framework.Internal.Commands;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class FirstPageStepDefenition1
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private IWebDriver driver;
       public FirstPageStepDefenition1(IWebDriver driver) 
        {
            this.driver = driver;
        }

        [Then(@"say something that fils")]
        public void ThenSaySomethingThatFils()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@name='earch_query']")).SendKeys("Testers");
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(Keys.Enter);
            Thread.Sleep(5000);
        }


    }
}