using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearnTest.Pages
{
    class TnMPage
    {
          // Functionality to go to last page
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








        public void CreateTnM(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/TimeMaterial/Create");

            // clicking the dropdown arrow

            IWebElement dropdownOption = driver.FindElement(By.CssSelector(".k-select > .k-icon"));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            dropdownOption.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> dropdownItems = driver.FindElements(By.XPath("//*[@id='TypeCode_listbox']/li"));
            foreach (IWebElement item in dropdownItems)
            {
                if (item.Text == "Time")
                {
                    Console.WriteLine("click time...");
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                    OpenQA.Selenium.Interactions.Actions actions = new Actions(driver);
                    actions.MoveToElement(item).Perform();
                    item.Click();
                }

            }




            //find code
            IWebElement code = driver.FindElement(By.Id("Code"));
            code.SendKeys("12345");

            //find description and input value
            IWebElement description = driver.FindElement(By.Id("Description"));

            description.SendKeys("RajniDesc");

            //find price per unit
            IWebElement price = driver.FindElement(By.Id("Price"));

            //find select file button and select a file
            IWebElement fileUpload = driver.FindElement(By.Id("files"));
            fileUpload.SendKeys("C:\\raman\\Selenium\\test.rtf");


            // find save button and click it

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
             saveButton.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            
            goToLastpage(driver);




            IWebElement tbody = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody"));


            var rows = tbody.FindElements(By.TagName("tr"));
            Console.WriteLine(rows);

            foreach (var row in rows)
            {
                if (row.Text.Contains("Rajni"))
                {
                    Console.WriteLine("yipee");

                    var tds = row.FindElements(By.TagName("td"));

                    foreach (var entry in tds)
                    {

                        if (entry.Text == "secret")
                        {
                            Console.WriteLine("Record created successfully");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Record creation failed");
                            break;
                        }

                        //entry.Click();
                    }



                }

            }
        }


        public void EditTnM(IWebDriver driver)
        {
            /*
             * Edit Record...
             */

            IWebElement recordRow = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[last()]//a[contains(@class, 'k-grid-Edit')]"));
            Console.WriteLine(recordRow);

            OpenQA.Selenium.Interactions.Actions actionEdit = new Actions(driver);
            actionEdit.MoveToElement(recordRow).Perform();
            recordRow.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //find description and input value
            IWebElement editDescription = driver.FindElement(By.Id("Description"));
            editDescription.Clear();
            editDescription.SendKeys("RajniDesc_changeDescription123");
            IWebElement editSave = driver.FindElement(By.Id("SaveButton"));
            editSave.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            ////*[@id="tmsGrid"]/div[3]/table/tbody/tr[last()]/td[last()]/a[2]
            // OpenQA.Selenium.Interactions.Actions actions1 = new Actions(driver);

        }

        public void DeleteTnM(IWebDriver driver)
        {
            //Deleting the last record

            goToLastpage(driver);
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[last()]//a[contains(@class, 'k-grid-Delete')]"));

            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[last()]//a[contains(@class, 'k-grid-Edit')]"));
            OpenQA.Selenium.Interactions.Actions actionDelete = new Actions(driver);
            actionDelete.MoveToElement(deleteButton).Perform();
            deleteButton.Click();


            IAlert simpleAlert = driver.SwitchTo().Alert();
            simpleAlert.Accept();

            //Console.WriteLine("Last Record in first page deleted");


            //recordRow.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //clicking the delete button



        }
    }

}
    