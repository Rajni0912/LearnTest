using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;


namespace LearnTest
{
    [TestFixture]
    class Program
    {
       /* static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver(@"C:\raman\chromrdrv");

            
            Pages.LogInPage logInpageObj = new Pages.LogInPage();
            Pages.TnMPage tnmObj = new Pages.TnMPage();


            //login test
             void LogIn(IWebDriver driver)
            {
                Pages.HomePage homePageObj = new Pages.HomePage();
                logInpageObj.logInTM(driver);
            }
       */

            // creating TnM
         [Test]
            void  CreateTnM(IWebDriver driver)
            {
                Pages.TnMPage tnmObj = new Pages.TnMPage();
                tnmObj.CreateTnM(driver);

            }

            //editing TnM
            [Test]
            void EditTnM(IWebDriver driver)
            {
                Pages.TnMPage tnmObj = new Pages.TnMPage();
                tnmObj.EditTnM(driver);
            }


            //deleting TnM
            [Test]
            void DeleteTnM(IWebDriver driver)
            {
                Pages.TnMPage tnmObj = new Pages.TnMPage();
                tnmObj.DeleteTnM(driver);
            }
        }


























    }
//}
