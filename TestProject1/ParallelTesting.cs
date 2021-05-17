using System.Threading.Tasks;
using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TestProject1.BaseClasss;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using TestProject1.Utilities;

namespace TestProject1
{
    [TestFixture]
    public class ParallelTesting
    { 
        IWebDriver driver;
        [Test, Category("UAT Testing"),Category("Module1")]
        public void Test1()
        {
            var Driver=new BrowserUtility().Init(driver);
            
            
            IWebElement emailFeilds = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailFeilds.SendKeys("monuabhikrant@gmail.com");
            IWebElement password = driver.FindElement(By.XPath(".//*[@id='password']"));
            password.SendKeys("Ec1505451@");
            Driver.Close();

        }
        [Test, Category("UAT Testing"), Category("Module1")]

        public void Test2()
        {
            var Driver = new BrowserUtility().Init(driver);


            IWebElement emailFeilds = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailFeilds.SendKeys("monuabhikrant@gmail.com");
            IWebElement password = driver.FindElement(By.XPath(".//*[@id='password']"));
            password.SendKeys("Ec1505451@");
            Driver.Close();

        }
        [Test, Category("UAT Testing"), Category("Module1")]

        public void Test10()
        {
            var Driver = new BrowserUtility().Init(driver);


            IWebElement emailFeilds = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailFeilds.SendKeys("monuabhikrant@gmail.com");
            IWebElement password = driver.FindElement(By.XPath(".//*[@id='password']"));
            password.SendKeys("Ec1505451@");
            Driver.Close();

        }
        [Test, Category("UAT Testing"), Category("Module1")]

        public void Test9()
        {
            var Driver = new BrowserUtility().Init(driver);


            IWebElement emailFeilds = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailFeilds.SendKeys("monuabhikrant@gmail.com");
            IWebElement password = driver.FindElement(By.XPath(".//*[@id='password']"));
            password.SendKeys("Ec1505451@");
            Driver.Close();

        }
        [Test, Category("UAT Testing"), Category("Module1")]

        public void Test8()
        {
            var Driver = new BrowserUtility().Init(driver);


            IWebElement emailFeilds = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailFeilds.SendKeys("monuabhikrant@gmail.com");
            IWebElement password = driver.FindElement(By.XPath(".//*[@id='password']"));
            password.SendKeys("Ec1505451@");
            Driver.Close();

        }
        [Test, Category("UAT Testing"), Category("Module1")]

        public void Test7()
        {
            var Driver = new BrowserUtility().Init(driver);


            IWebElement emailFeilds = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailFeilds.SendKeys("monuabhikrant@gmail.com");
            IWebElement password = driver.FindElement(By.XPath(".//*[@id='password']"));
            password.SendKeys("Ec1505451@");
            Driver.Close();

        }
        [Test, Category("UAT Testing"), Category("Module1")]

        public void Test6()
        {
            var Driver = new BrowserUtility().Init(driver);


            IWebElement emailFeilds = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailFeilds.SendKeys("monuabhikrant@gmail.com");
            IWebElement password = driver.FindElement(By.XPath(".//*[@id='password']"));
            password.SendKeys("Ec1505451@");
            Driver.Close();

        }
        [Test, Category("UAT Testing"), Category("Module1")]

        public void Test5()
        {
            var Driver = new BrowserUtility().Init(driver);


            IWebElement emailFeilds = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailFeilds.SendKeys("monuabhikrant@gmail.com");
            IWebElement password = driver.FindElement(By.XPath(".//*[@id='password']"));
            password.SendKeys("Ec1505451@");
            Driver.Close();

        }
        [Test, Category("UAT Testing"), Category("Module1")]

        public void Test4()
        {
            var Driver = new BrowserUtility().Init(driver);


            IWebElement emailFeilds = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailFeilds.SendKeys("monuabhikrant@gmail.com");
            IWebElement password = driver.FindElement(By.XPath(".//*[@id='password']"));
            password.SendKeys("Ec1505451@");
            Driver.Close();

        }
        [Test, Category("UAT Testing"), Category("Module1")]

        public void Test3()
        {
            var Driver = new BrowserUtility().Init(driver);


            IWebElement emailFeilds = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailFeilds.SendKeys("monuabhikrant@gmail.com");
            IWebElement password = driver.FindElement(By.XPath(".//*[@id='password']"));
            password.SendKeys("Ec1505451@");
            Driver.Close();

        }

    }
}