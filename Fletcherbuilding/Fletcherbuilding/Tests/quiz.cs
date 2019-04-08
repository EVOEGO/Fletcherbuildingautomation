using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using NUnit.Framework;
using Fletcherbuilding.Webpages;
using System.Threading;
using System.IO;

namespace Fletcherbuilding.Tests
{
    class quiz : Basedriver
    {
        [Test]
        public void testquiz()
        {
            string link = "https://fletcherbuilding.au1.qualtrics.com/jfe/form/SV_ekORIiO71GDwum9";
            string code = "TAU1122";
            string teamname = "Darra";
            String fileName = @"C: \Users\icrooke\Desktop\Quiz Results\" + code + "_" + teamname + ".txt";

            // Check if file already exists. If yes, delete it.     
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            FileStream fs = File.Create(fileName, 1024);
            fs.Close();

            teamnumber teamNumber = new teamnumber();
            teamNumber.GotoURL(driver, link);
            teamNumber.inputteamnumber(driver, code);
            teamNumber.clicknext(driver);
            checkteamnumnber checkTeamNumber = new checkteamnumnber();
            Thread.Sleep(1300);
            checkTeamNumber.checknumber(driver, teamname);
            teamNumber.clicknext(driver);
            Thread.Sleep(1300);
            teamNumber.clicknext(driver);
            Thread.Sleep(1300);
            teamNumber.clicknext(driver);
            Thread.Sleep(1300);
            quizquestions quizQuestions = new quizquestions();
            for(int x = 0; x < 20; x++)
            {
                quizQuestions.clickquestion(driver, x);
                Thread.Sleep(1300);
            }
            quizQuestions.fillinputfields(driver);
            teamNumber.clicknext(driver);
            Thread.Sleep(1000);
            teamNumber.clicknext(driver);
            Thread.Sleep(1000);
            quizQuestions.clickagefield(driver);
            Thread.Sleep(1000);
            quizQuestions.clickgenderfield(driver);
            Thread.Sleep(1000);
            quizQuestions.clickemploymenttype(driver);
            Thread.Sleep(1000);
            quizQuestions.clickfulltime(driver);
            Thread.Sleep(1000);
            quizQuestions.clickpositionheld(driver);
            Thread.Sleep(1000);
            quizQuestions.clickpositionarea(driver);
            Thread.Sleep(1000);
            quizQuestions.clickpositionlength(driver);
            Thread.Sleep(1000);
            quizQuestions.clickrainbow(driver);
            Thread.Sleep(1000);
            quizQuestions.clickethnicgroup(driver);
            teamNumber.clicknext(driver);
            Thread.Sleep(1000);
            quizQuestions.writeanswerstodocument(fileName);
        }
    }
}
