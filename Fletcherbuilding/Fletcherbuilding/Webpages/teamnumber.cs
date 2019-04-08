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
    class teamnumber
    {
        By teamcode = By.Id("QR~Authentication-FL_5~0");
        By nextbutton = By.Id("NextButton");

        public void inputteamnumber(IWebDriver driver, string chosencode)
        {
            driver.FindElement(teamcode).Click();
            driver.FindElement(teamcode).SendKeys(chosencode);
        }
        public void clicknext(IWebDriver driver)
        {
            driver.FindElement(nextbutton).Click();
        }
        public void GotoURL(IWebDriver driver, string link)
        {
            driver.Navigate().GoToUrl(link);
        }
        
    }
}
