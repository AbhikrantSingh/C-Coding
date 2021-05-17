using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;
using TestProject1.BaseClasss;
using TestProject1.PageObject;

namespace TestProject1.TestScripts
{
    [TestFixture]
    public class Module : Base
    {
        [Test]
        public void TestMethod()
        {
            searchPage search = new searchPage(driver);
            search.NavigateToResult();
            Thread.Sleep(5000);
            ResultPage res = new ResultPage(driver);
            res.NavigateToChannel();
            Thread.Sleep(5000);
            ChannelPage page = new ChannelPage(driver);

            var text = page.getChannelName();
            Console.WriteLine(text);

            
        }
       


    }
}
