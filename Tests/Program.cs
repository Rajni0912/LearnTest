using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;


namespace LearnTest
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver(@"C:\raman\chromrdrv");

            Pages.HomePage homePageObj = new Pages.HomePage();
            Pages.LogInPage logInpageObj = new Pages.LogInPage();
            Pages.TnMPage tnmObj = new Pages.TnMPage();


            logInpageObj.logInTM(driver);

            // creating TnM


            tnmObj.CreateTnM(driver);

            //editing TnM

            tnmObj.EditTnM(driver);

            //deleting TnM
            tnmObj.DeleteTnM(driver);
        }


























    }
}
