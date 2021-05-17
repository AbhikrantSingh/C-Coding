using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration.Assemblies;
using System.Collections.Generic;
using System.Text;
using System.Web.Razor;
//using System.Configuration;

namespace TestProject1
{
    [TestFixture]
    public class SeleniumCSharp2
    {
        IWebDriver driver=null;

        ExtentReports extent=null;
        [OneTimeSetUp]
        public void ExtendStart() {
            Console.WriteLine("start up");

            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\Amitesh\source\repos\TestProject1\TestProject1\ExtentReports\demo.html");
            extent.AttachReporter(htmlReporter);

        
        }

        [OneTimeTearDown]
        public void ExtendClose() {
            extent.Flush();
        }






        [Test]
        public void Test1()
        {
            ExtentTest test = null;

            try
            {
                test= extent.CreateTest("Test1").Info("Test Started");
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                test.Log(Status.Info, "Chrome Browser LAunched");
                 driver.Url = "https://www.facebook.com";

              //  driver.Url = UrlName;
                IWebElement emailfeilds = driver.FindElement(By.XPath(".//*[@id='email']"));
                emailfeilds.SendKeys("abhikrant");
                test.Log(Status.Info, "email entered");
                IWebElement newid = driver.FindElement(By.XPath(".//*[@class='_42ft _4jy0 _6lti _4jy6 _4jy2 selected _51sy']"));
                newid.Click();
                driver.Quit();
                test.Log(Status.Pass, "TEst1 passed");


            }
            catch (Exception e)
            {
                test.Log(Status.Error, "TEst1 failed");
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
             //   if (driver != null) driver.Quit();
            }



        }
    }
}
