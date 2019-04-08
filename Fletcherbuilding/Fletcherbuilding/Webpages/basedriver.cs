using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using NUnit.Framework; 


namespace Fletcherbuilding.Webpages
{
    class Basedriver
    {
        public static IWebDriver driver;

        [SetUp]
        public void setup()
        {
            ChromeDriver driver1 = new ChromeDriver();
            driver = driver1;
            driver.Manage().Window.Maximize();
        }
        [TearDown]
        public void teardown()
        {
            driver.Dispose();
            driver.Quit();
        }
    }
}
