using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
namespace TestProject1.PageObject
{
    public class searchPage
    {
        IWebDriver driver;
        public searchPage(IWebDriver driver)
        {
            this.driver = driver;
            
        }
        //   [FindsBy(How = How.Id, Using = "search")]
        public IWebElement SearchTextBox()
        {
            IWebElement search= driver.FindElement(By.Id("search"));
            return search;
        }

        //[FindsBy(How = How.CssSelector, Using = "#search-icon-legacy")]
        public IWebElement SearchButton() {

            return driver.FindElement(By.CssSelector("#search-icon-legacy"));
        }

        public void NavigateToResult()
        {
            SearchTextBox().SendKeys("Selena Gomez");
            SearchButton().Click();
        }
    }
}
