using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    [TestFixture]
   public class SeleniumCS 
    {
        IWebDriver driver;
        [Test]
        [Author("abhikrant", "abhi@gmail.com")]
        [Description("facebooklogin check")]
        [TestCaseSource("DataDrivenTesting")]
           public void Test1(String UrlName)
        {

            try
            {
                 driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                // driver.Url = "https://www.facebook.com";

                driver.Url = UrlName;
                IWebElement emailfeilds = driver.FindElement(By.XPath(".//*[@id='email']"));
                emailfeilds.SendKeys("abhikrant");
                IWebElement newid = driver.FindElement(By.XPath(".//*[@class='_42ft _4jy0 _6lti _4jy6 _4jy2 selected _51sy']"));
               // IWebElement newid = driver.FindElement(By.XPath(".//*[@class='_42ft 4jy0 _6lti _4jy6 _4jy2 selected _51sy']"));
                newid.Click();
                emailfeilds.SendKeys("dassaasd");
               
            }
            catch (Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();

                screenshot.SaveAsFile("C:\\Users\\Amitesh\\Desktop\\s1.png", ScreenshotImageFormat
                    .Png);

                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if (driver != null) driver.Quit();
            }


           
        }
        //[Test]
        //[Author("abhikrant", "abhi@gmail.com")]
        //[Description("facebooklogin check")]
        //public void Test2()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Url = "https://www.facebook.com";
        //    IWebElement emailFeilds = driver.FindElement(By.XPath(".//*[@id='email']"));
        //    emailFeilds.SendKeys("abhikrant");
        //    IWebElement newId = driver.FindElement(By.XPath(".//*[@class='_42ft _4jy0 _6lti _4jy6 _4jy2 selected _51sy']"));
        //    newId.Click();
        //    //   emailFeilds.SendKeys("dassaasd");
        //    driver.Quit();
        //}
        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.facebook.com");
           // list.Add("https://www.youtube.com");
            //list.Add("https://www.gmail.com");
            //list.Add("https://www.yahoo.com");


            return list;
        }
        [Test]
        public void test3()        
        {
            driver = new ChromeDriver();
            driver.Url = "https://web.whatsapp.com/";
           // IWebElement element= driver.FindElement(By.XPath(".//*(@id='')"))
        }
    }
}
