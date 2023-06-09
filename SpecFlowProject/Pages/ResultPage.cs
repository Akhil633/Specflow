﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.Pages
{
    public class ResultPage
    {
        private IWebDriver driver;
        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        By channelName = By.LinkText("Testers Talk");
        public ChannelPage clickOnChannel()
        {
            driver.FindElement(channelName).Click();
            Thread.Sleep(3000); 
            return new ChannelPage(driver);
        }

    }
}
