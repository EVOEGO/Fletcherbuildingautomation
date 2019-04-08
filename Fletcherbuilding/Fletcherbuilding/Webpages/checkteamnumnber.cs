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
    class checkteamnumnber
    {
        public void checknumber(IWebDriver driver, string codename)
        {
            By teamname = By.XPath("//*[@class='QuestionText BorderColor']/b[contains(text(), '" + codename + "')]");
            driver.FindElement(teamname);
        }
    }
}
