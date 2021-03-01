using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearnTest.Pages
{
    class GotoLastpage
    {

        public void goToLastpage(IWebDriver driver)
        {
            /********************paginaation.....
            * 

           ******************************/
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/TimeMaterial");
            driver.Manage().Window.Maximize();

            //    IWebElement pageLinks = driver.FindElement(By.XPath("//div[contains(@class,'k-pager-wrap')]//a[contains(@class, 'k-pager-last')]"));


            IWebElement findlastPage = driver.FindElement(By.CssSelector(".k-i-seek-e"));
            Console.WriteLine("Click pagination links....");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Actions actions1 = new Actions(driver);

            actions1.MoveToElement(findlastPage).Perform();
            findlastPage.Click();
            Console.WriteLine("Last Page found");




            
            }
        }

    }



