using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Collections;

namespace TestProject1
{

    [TestFixture]
    public class Assignment
    {
        IWebDriver driver;
       [Test] 
        public void login()
        {

             driver = new ChromeDriver();
            driver.Manage().Window.Maximize();  
            driver.Url = "https://invoicesmash-staging.com/logon";
            IWebElement EmailElement = driver.FindElement(By.Id("UserName"));
            EmailElement.SendKeys("abhikrant.com");
            IWebElement PasswordElement = driver.FindElement(By.Id("Password"));
            PasswordElement.SendKeys("********");
            IWebElement loginButton = driver.FindElement(By.XPath(".//*[@class='btn btn-lg btn-primary btn-block']"));
              loginButton.Click();
            Thread.Sleep(5000);
            IWebElement userSession = driver.FindElement(By.XPath(".//*[@href='/AppAdmin/Admin/TakeOverUserSession']"));
            userSession.Click();
            Thread.Sleep(2000);
         
            IWebElement dropdown = driver.FindElement(By.CssSelector(".chosen-single>span"));
            dropdown.Click();
          //  dropdown.GetAttribute("invove");
            Thread.Sleep(2000);
           IWebElement ele= driver.FindElement(By.CssSelector(".chosen-search>input"));
            ele.SendKeys("invoice-smash-master.coupadev.com");
            ele.SendKeys(Keys.Enter);
            Thread.Sleep(5000);
           // dropdown.Click();
           
//            dropdown.Click();

            IWebElement takeOverButton = driver.FindElement(By.XPath(".//*[@class='btn btn-primary']"));
            takeOverButton.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@class='navbar-brand']")));

            Thread.Sleep(2000);
            IWebElement homeElement = driver.FindElement(By.XPath(".//*[@href='/Account/ISAdmin']"));
            homeElement.Click();
            Thread.Sleep(2000);
            driver.Close();


                 
        
        
        }
        public void uploadingReceipt()
        {
            login();
            driver.Url = "https://invoice-smash-master-test.coupadev.com";
            driver.FindElement(By.Id("user_login")).SendKeys("CustomerSupport");
            driver.FindElement(By.Id("user_password")).SendKeys("CustomerSupport");
            driver.FindElement(By.Id("login_button")).Click();
            driver.FindElement(By.CssSelector(".dz-default.dz-message>span")).SendKeys("C:\\Users\\Amitesh\\Downloads\\Untitled document.pdf");

        }
    }
}
/*
 * 
 All the trash nd heat and trail methods i tried.
 IWebElement options = driver.FindElement(By.CssSelector(".container.ng-scope>div>div>div>select"));
            var selectElement = new SelectElement(options);
            Console.WriteLine(selectElement.Options);
            //    selectElement.SelectByIndex(10);
            //  ArrayList list = new ArrayList();
            selectElement.SelectByValue("10");
         //   list.Add(selectElement.AllSelectedOptions);
           // Console.WriteLine(list);
s
   //IWebElement options = driver.FindElement(By.CssSelector(".input-group>select"));
//            options.Click();            
           // var selectElement = new SelectElement(options);
            //selectElement.SelectByIndex(2);

          //  selectElement.SelectByValue("1");







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
 
 
 */
