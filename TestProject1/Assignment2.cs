using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using TestProject1.BaseClasss;

namespace TestProject1
{
    [TestFixture]
    public class Assignment2 : Base
    {
        public void AddReceipt()
        {
            driver.Url = "https://invoice-smash-master-test.coupadev.com";
            driver.FindElement(By.CssSelector(".dz-default.dz-message>span")).SendKeys("C:\\Users\\Amitesh\\Downloads\\Untitled document.pdf");
            
        }
    }
}
