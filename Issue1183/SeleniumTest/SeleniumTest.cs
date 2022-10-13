using NUnit.Framework;
using System.Security.Cryptography;
using System;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    public class SeleniumTest
    {
        [Test]
        public void TestHang()
        {
            var driver = new ChromeDriver(@"C:\Users\charlie\dev\NUnit\nunit-console.issues\Issue1183");
            driver.Url = "https://google.com";
            //driver.Close();
            //driver.Quit();
        }
    }
}