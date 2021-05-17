using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace TestProject1
{
    [TestFixture]
    public class Assignment
    {
        [Test]
        public void login()
        {
           
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();  
            driver.Url = "https://invoicesmash-staging.com/logon";
            // IWebElement EmailElement=driver.FindElement(By.XPath(".//*[@class='form-control ng-isolate-scope ng-valid-email ng-valid-maxlength ng-dirty ng-valid ng-valid-required ng-touched'"));
            IWebElement EmailElement = driver.FindElement(By.Id("UserName"));
            EmailElement.SendKeys("abhikran@gmail.com");
            // IWebElement PasswordElement = driver.FindElement(By.XPath(".//*[@class='form-control ng-isolate-scope ng-dirty ng-valid-parse ng-valid ng-valid-required ng-touched']"));
            IWebElement PasswordElement = driver.FindElement(By.Id("Password"));
            PasswordElement.SendKeys("*************");
            IWebElement loginButton = driver.FindElement(By.XPath(".//*[@class='btn btn-lg btn-primary btn-block']"));
            //driver.FindElement(By.ClassName("btn btn-lg btn-primary btn-block")).Click();
              loginButton.Click();
        //    Thread.Sleep(5000);
            Thread.Sleep(5000);
            IWebElement userSession = driver.FindElement(By.XPath(".//*[@href='/AppAdmin/Admin/TakeOverUserSession']"));
            userSession.Click();
            Thread.Sleep(2000);
            // IWebElement subscriptionelement = driver.FindElement(By.XPath(".//*[@class='chosen-single chosen-default']"));
            //            subscriptionelement.SendKeys("invoicesmash");
            //            subscriptionelement.Click();
            //        IWebElement ui = driver.FindElement(By.XPath(".//*[@class='chosen-results']"));
            //          ui.Click();
            //            ui.FindElement(By.CssSelector("li[data-option-array-index=" +5+ "]")).Click();

            //IWebElement dropdown = driver.FindElement(By.CssSelector(".chosen-container.chosen-container-single.chosen-with-drop"));
          //  dropdown.Click();
            Thread.Sleep(2000);
            IWebElement options = driver.FindElement(By.CssSelector(".input-group>select"));
            var selectElement = new SelectElement(options);
            selectElement.SelectByValue("1");






            // Thread.Sleep(4000);
            // IWebElement instanceELement = driver.FindElement(By.ClassName("chosen-search"));
            // instanceELement.Click();
            //            IWebElement ele = driver.FindElement(By.XPath(".//*[@class='form-control ng-pristine ng-untouched ng-valid localytics-chosen']"));

            //subscriptionElement.SendKeys("invoice-smash-master.coupadev.com");
            //      Thread.Sleep(2000);
            // IWebElement element = driver.FindElement(By.CssSelector("1015"));
            //  element.Click();

            //   IWebElement instanceELement = driver.FindElement(By.ClassName("chosen-search"));
            //  selectElement.SelectByIndex(3);
            //            Thread.Sleep(4000);
            //           selectElement.SelectByText("invoice-smash-master.coupadev.com");
            //      Thread.Sleep(5000);
            //selectElement.SelectByValue("invoice-smash-master.coupadev.com");

            //instanceELement.SendKeys("invoice-smash-master.coupadev.com");

            IWebElement takeOverButton = driver.FindElement(By.XPath(".//*[@class='btn btn-primary']"));
            takeOverButton.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@class='navbar-brand']")));

            IWebElement homeElement = driver.FindElement(By.XPath(".//*[@href='/Account/ISAdmin']"));
            homeElement.Click();
            Thread.Sleep(2000);
            driver.Close();


                 
        
        
        }
    }
}
