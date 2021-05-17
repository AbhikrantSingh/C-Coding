using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TestProject1.PageObject
{
    [TestFixture]
    public class ChannelPage
    {
        IWebDriver driver;
        public ChannelPage(IWebDriver driver)
        {
            this.driver = driver;

        }
        //   [FindsBy(How = How.Id, Using = "search")]
        public IWebElement ChannelName()
        {
            IWebElement channel = driver.FindElement(By.CssSelector("#channel-title-container>span"));
            return channel;
        }
        public String getChannelName()
        {
            return ChannelName().Text;

        }
    }
}
