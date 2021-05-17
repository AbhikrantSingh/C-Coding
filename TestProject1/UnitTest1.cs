using System.Threading.Tasks;
using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TestProject1.BaseClasss;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace TestProject1
{
    [TestFixture]
    public class Tests
        : Base
    {
        

        [Test,Category("Smoke Testing")]
        public void Test1()
        {
            System.Console.WriteLine("sdanla");
           IWebElement emailFeilds= driver.FindElement(By.XPath(".//*[@id='email']"));
            IWebElement newId = driver.FindElement(By.XPath(".//*[@class='_42ft _4jy0 _6lti _4jy6 _4jy2 selected _51sy']"));
            newId.Click();
        //   emailFeilds.SendKeys("dassaasd");
          IWebElement monthDrop=  driver.FindElement(By.XPath(".//*[id='month']"));
            SelectElement element = new SelectElement(monthDrop);
            element.SelectByValue("1");//Select by Value,we can do it via text nd index also.
            element.SelectByIndex(2);
        
        }

        [Test, Category("Regression Testing")]
        public void Test3()      
        {
            IWebElement emailFeilds = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailFeilds.SendKeys("monuabhikrant@gmail.com");
            IWebElement password = driver.FindElement(By.XPath(".//*[@id='password']"));
            password.SendKeys("Ec1505451@");
        
        }

        [Test, Category("Smoke Testing")]
        public void Test2()
        {
            System.Console.WriteLine("sdanla");
            IWebElement emailFeilds = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailFeilds.SendKeys("dassaasd");
            Thread.Sleep(5000);
        }

    }
}