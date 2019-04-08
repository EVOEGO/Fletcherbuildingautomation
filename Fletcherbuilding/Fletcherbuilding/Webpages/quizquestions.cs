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
    class quizquestions
    {
        String[] agreeids = new string[]{ "QID11-34-label", "QID13-34-label", "QID14-34-label", "QID16-34-label"
        ,"QID12-34-label", "QID17-34-label", "QID20-34-label", "QID15-34-label", "QID21-34-label", "QID18-34-label", "QID19-34-label", "QID22-34-label"
        , "QID23-34-label", "QID24-34-label", "QID25-34-label", "QID26-34-label", "QID27-34-label", "QID28-34-label", ""};

        String[] question1 = new string[] { "QID9-36-label", "QID9-37-label", "QID9-38-label", "QID9-40-label", "QID9-39-label" };
        String[] question2 = new string[] { "QID10-31-label", "QID10-32-label", "QID10-33-label", "QID10-34-label", "QID10-35-label" };
        String[] question3 = new string[] { "QID11-31-label", "QID11-32-label", "QID11-33-label", "QID11-34-label", "QID11-35-label" };
        String[] question4 = new string[] { "QID13-31-label", "QID13-32-label", "QID13-33-label", "QID13-34-label", "QID13-35-label" };
        String[] question5 = new string[] { "QID14-31-label", "QID14-32-label", "QID14-33-label", "QID14-34-label", "QID14-35-label" };
        String[] question6 = new string[] { "QID16-31-label", "QID16-32-label", "QID16-33-label", "QID16-34-label", "QID16-35-label" };
        String[] question7 = new string[] { "QID12-31-label", "QID12-32-label", "QID12-33-label", "QID12-34-label", "QID12-35-label" };
        String[] question8 = new string[] { "QID17-31-label", "QID17-32-label", "QID17-33-label", "QID17-34-label", "QID17-35-label" };
        String[] question9 = new string[] { "QID20-31-label", "QID20-32-label", "QID20-33-label" , "QID20-34-label" , "QID20-35-label" };
        String[] question10 = new string[] { "QID15-31-label", "QID15-32-label", "QID15-33-label", "QID15-34-label", "QID15-35-label" };
        String[] question11 = new string[] { "QID21-31-label", "QID21-32-label", "QID21-33-label", "QID21-34-label", "QID21-35-label" };
        String[] question12 = new string[] { "QID18-31-label", "QID18-32-label", "QID18-33-label", "QID18-34-label" , "QID18-35-label"};
        String[] question13 = new string[] { "QID19-31-label", "QID19-32-label", "QID19-33-label", "QID19-34-label", "QID19-35-label" };
        String[] question14 = new string[] { "QID22-31-label", "QID22-32-label", "QID22-33-label", "QID22-34-label", "QID22-35-label" };
        String[] question15 = new string[] { "QID23-31-label", "QID23-32-label", "QID23-33-label", "QID23-34-label", "QID23-35-label" };
        String[] question16 = new string[] { "QID24-31-label", "QID24-32-label", "QID24-33-label", "QID24-34-label", "QID24-35-label" };
        String[] question17 = new string[] { "QID25-31-label", "QID25-32-label", "QID25-33-label" , "QID25-34-label" , "QID25-35-label" };
        String[] question18 = new string[] { "QID26-31-label", "QID26-32-label", "QID26-33-label" , "QID26-34-label", "QID26-35-label" };
        String[] question19 = new string[] { "QID27-31-label", "QID27-32-label", "QID27-33-label", "QID27-34-label", "QID27-35-label" };
        String[] question20 = new string[] { "QID28-31-label", "QID28-32-label", "QID28-33-label", "QID28-34-label", "QID28-35-label" };
        String[] ages = new string[] { "QID1-7-label", "QID1-8-label", "QID1-9-label", "QID1-10-label", "QID1-11-label", "QID1-12-label" };
        String[] genders = new string[] { "QID2-13-label", "QID2-14-label", "QID2-15-label", "QID2-16-label" };

        String[] answers = new string[31];
        String[] choices = new string[] { "Strongly disagree", "Disagree", "Neither agree nor disagree", "Agree", "Strongly agree" };

        By inputfield1 = By.Id("QR~QID29");
        By inputfield2 = By.Id("QR~QID30");

        
        By positionarea = By.Id("QID37-243-label");
      
       
        By ethnic = By.Id("QID7-82-label");

        public void Clickagree(IWebDriver driver, int number)
        {
            By agreebutton1 = By.Id(agreeids[number]);
            driver.FindElement(agreebutton1).Click();
        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public void clickquestion(IWebDriver driver, int number)
        {
            if(number == 0)
            {
                int value = RandomNumber(0, 5);
              
                By choice = By.Id(question1[value]);
                int select = number + 1;
                answers[number] = "Question" + select + ") " + choices[value];
                driver.FindElement(choice).Click();
            }
            if(number == 1)
            {
                int value = RandomNumber(0, 5);
                By choice = By.Id(question2[value]);
                int select = number + 1;
                answers[number] = "Question" + select + ") " + choices[value];
                driver.FindElement(choice).Click();
            }
            if (number == 2)
            {
                int value = RandomNumber(0, 5);
                By choice = By.Id(question3[value]);
                int select = number + 1;
                answers[number] = "Question" + select + ") " + choices[value];
                driver.FindElement(choice).Click();
            }
            if (number == 3)
            {
                int value = RandomNumber(0, 5);
                By choice = By.Id(question4[value]);
                int select = number + 1;
                answers[number] = "Question" + select + ") " + choices[value];
                driver.FindElement(choice).Click();
            }
            if (number == 4)
            {
                int value = RandomNumber(0, 5);
                By choice = By.Id(question5[value]);
                int select = number + 1;
                answers[number] = "Question" + select + ") " + choices[value];
                driver.FindElement(choice).Click();
            }
            if (number == 5)
            {
                int value = RandomNumber(0, 5);
                By choice = By.Id(question6[value]);
                int select = number + 1;
                answers[number] = "Question" + select + ") " + choices[value];
                driver.FindElement(choice).Click();
            }
            if (number == 6)
            {
                int value = RandomNumber(0, 5);
                By choice = By.Id(question7[value]);
                int select = number + 1;
                answers[number] = "Question" + select + ") " + choices[value];
                driver.FindElement(choice).Click();
            }
            if (number == 7)
            {
                int value = RandomNumber(0, 5);
                By choice = By.Id(question8[value]);
                int select = number + 1;
                answers[number] = "Question" + select + ") " + choices[value];
                driver.FindElement(choice).Click();
            }
            if (number == 8)
            {
                int value = RandomNumber(0, 5);
                By choice = By.Id(question9[value]);
                int select = number + 1;
                answers[number] = "Question" + select + ") " + choices[value];
                driver.FindElement(choice).Click();
            }
            if (number == 9)
            {
                int value = RandomNumber(0, 5);
                By choice = By.Id(question10[value]);
                int select = number + 1;
                answers[number] = "Question" + select + ") " + choices[value];
                driver.FindElement(choice).Click();
            }
            if (number == 10)
            {
                int value = RandomNumber(0, 5);
                By choice = By.Id(question11[value]);
                int select = number + 1;
                answers[number] = "Question" + select + ") " + choices[value];
                driver.FindElement(choice).Click();
            }
            if (number == 11)
            {
                int value = RandomNumber(0, 5);
                By choice = By.Id(question12[value]);
                int select = number + 1;
                answers[number] = "Question" + select + ") " + choices[value];
                driver.FindElement(choice).Click();
            }
            if (number == 12)
            {
                int value = RandomNumber(0, 5);
                By choice = By.Id(question13[value]);
                int select = number + 1;
                answers[number] = "Question" + select + ") " + choices[value];
                driver.FindElement(choice).Click();
            }
            if (number == 13)
            {
                int value = RandomNumber(0, 5);
                By choice = By.Id(question14[value]);
                int select = number + 1;
                answers[number] = "Question" + select + ") " + choices[value];
                driver.FindElement(choice).Click();
            }
            if (number == 14)
            {
                int value = RandomNumber(0, 5);
                By choice = By.Id(question15[value]);
                int select = number + 1;
                answers[number] = "Question" + select + ") " + choices[value];
                driver.FindElement(choice).Click();
            }
            if (number == 15)
            {
                int value = RandomNumber(0, 5);
                By choice = By.Id(question16[value]);
                int select = number + 1;
                answers[number] = "Question" + select + ") " + choices[value];
                driver.FindElement(choice).Click();

            }
            if (number == 16)
            {
                int value = RandomNumber(0, 5);
                By choice = By.Id(question17[value]);
                int select = number + 1;
                answers[number] = "Question" + select + ") " + choices[value];
                driver.FindElement(choice).Click();
            }
            if (number == 17)
            {
                int value = RandomNumber(0, 5);
                By choice = By.Id(question18[value]);
                int select = number + 1;
                answers[number] = "Question" + select + ") " + choices[value];
                driver.FindElement(choice).Click();

            }
            if (number == 18)
            {
                int value = RandomNumber(0, 5);
                By choice = By.Id(question19[value]);
                int select = number + 1;
                answers[number] = "Question" + select + ") " + choices[value];
                driver.FindElement(choice).Click();
            }
            if (number == 19)
            {
                int value = RandomNumber(0, 5);
                By choice = By.Id(question20[value]);
                int select = number + 1;
                answers[number] = "Question" + select + ") " + choices[value];
                driver.FindElement(choice).Click();

            }
        }

        public void fillinputfields(IWebDriver driver)
        {
            driver.FindElement(inputfield1).Click();
            driver.FindElement(inputfield1).SendKeys("Test");
            answers[20] = "Input Field 1) " + " Test";
            driver.FindElement(inputfield2).Click();
            driver.FindElement(inputfield2).SendKeys("Test");
            answers[21] = "Input Field 2) " + " Test";

        }
        public void clickagefield(IWebDriver driver)
        {

            String[] agechoices = new string[] { "Less than 20 years", "20 to 29 years", "30 to 39 years", "40 to 49 years", "50 to 59 years", "60 years and over"};
           
            int value = RandomNumber(0, 6);
            By agegroup = By.Id(ages[value]);
            answers[22] = "Age) " + agechoices[value];

            driver.FindElement(agegroup).Click();

        }
        public void clickgenderfield(IWebDriver driver)
        {
            String[] genderchoices = new string[] { "Male", "Female", "Gender Diverse", "Prefer not to answer"};
           
            int value = RandomNumber(0, 4);
            By gendertype = By.Id(genders[value]);
            answers[23] = "Gender) " + genderchoices[value];

            driver.FindElement(gendertype).Click();

            
        }
        public void clickemploymenttype(IWebDriver driver)
        {
            String[] employmenttypes = new string[] { "Permanant", "Other" };
            String[] employmentoptions = new string[] { "QID3-17-label", "QID3-18-label" };
            int value = RandomNumber(0, 1);

            By employmenttype = By.Id(employmentoptions[value]);
            answers[24] = "Employement type1) " + employmenttypes[value];
            driver.FindElement(employmenttype).Click();
        }
        public void clickfulltime(IWebDriver driver)
        {
            String[] typeofemployment = new string[] { "Full-time", "Part-time/casual"};
            String[] typesofemploymentids = new string[] { "QID4-17-label", "QID4-18-label" };
            int value = RandomNumber(0, 1);

            By fulltime = By.Id(typesofemploymentids[value]);
            answers[25] = "Employement type2) " + typeofemployment[value];
            driver.FindElement(fulltime).Click();
        }
        public void clickpositionheld(IWebDriver driver)
        {
            String[] positionlevels = new string[] { "Chief Executive Officer", "Chief Executive", "General Manager", "Leaders of Leaders", "Frontline Leader", "Individual Contributor"};
            String[] positionlevelsid = new string[] { "QID5-23-label" , "QID5-24-label", "QID5-25-label" , "QID5-26-label", "QID5-27-label", "QID5-28-label" };
            int value = RandomNumber(0, 5);

            By positionheld = By.Id(positionlevelsid[value]);
            answers[26] = "Position Held) " + positionlevels[value];
            driver.FindElement(positionheld).Click();
        }
        public void clickpositionarea(IWebDriver driver)
        {
            answers[27] = "Functional Area) Advisory/Professional";
            driver.FindElement(positionarea).Click();
        }
        public void clickpositionlength(IWebDriver driver)
        {
            String[] joblength = new string[] { "Less than 12 months", "1 to 2 years", "3 to 4 years", "5 to 9 years", "10 to 14 years", "15 to 19 years", "20 to 24 years", "25 years and over" };
            String[] joblengthid = new string[] { "QID6-17-label", "QID6-18-label", "QID6-19-label", "QID6-20-label", "QID6-21-label", "QID6-22-label", "QID6-23-label", "QID6-24-label" };
            int value = RandomNumber(0, 7);

            By positonlength = By.Id(joblengthid[value]);
            answers[27] = "Length of time in job) " + joblength[value];
            driver.FindElement(positonlength).Click();
        }
        public void clickrainbow(IWebDriver driver)
        {
            String[] rainbowoptions = new string[] { "Yes", "No", "Prefer not to answer"};
            String[] rainbowoptionsid = new string[] {"QID8-20-label", "QID8-21-label", "QID8-22-label" };
            int value = RandomNumber(0, 2);

            By rainbow = By.Id(rainbowoptionsid[value]);
            answers[28] = "Part of LGBTQI+) " + rainbowoptions[value];
            driver.FindElement(rainbow).Click();
        }
        public void clickethnicgroup(IWebDriver driver)
        {
            answers[29] = "Ehtnic Group) NZ European";
            driver.FindElement(ethnic).Click();
        }
        public void writeanswerstodocument(string name)
        {
            answers[30] = "Time Test was executed: " +  DateTime.Now.ToString("h:mm:ss tt");
            System.IO.File.WriteAllLines(name, answers);


        }

    }
}
    