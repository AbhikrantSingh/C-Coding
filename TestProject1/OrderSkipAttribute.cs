using System.Threading.Tasks;
using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TestProject1.BaseClasss;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.IE;

namespace TestProject1
{
    [TestFixture]
    public class OrderSkipAttribute
        : Base
    {
        

        [Test,Order(1),Category("OrderSkipAttribute")]
        public void Test1()
        {
            System.Console.WriteLine("sdanla");
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com";
            IWebElement email = driver.FindElement(By.XPath(".//*[@id='email']"));
            email.SendKeys("abhikrantSingh");
            driver.Close();
        
        
        
        }
        [Test,Order(0), Category("OrderSkipAttribute")]
        public void Test2()
        {
            Assert.Ignore("Defect 12345");            
            System.Console.WriteLine("sdanla");
            IWebDriver driver = new InternetExplorerDriver();
            driver.Url = "https://www.facebook.com";
            IWebElement email = driver.FindElement(By.XPath(".//*[@id='email']"));
            email.SendKeys("abhikrantSingh");
            driver.Close();



        }



    }
}