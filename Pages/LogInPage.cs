﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;


namespace LearnTest.Pages
{
    class LogInPage
    {
        public void logInTM(IWebDriver driver)
        {
            // browse to create page
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();
            // identify username textbox and input username
            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");
            // identify password textbox and input password
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");
            // identify login buton and click on the login button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();
            // verify home page
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Test Passed, Logged-in successfully");
            }
            else
            {
                Console.WriteLine("Test Failed, Login failed");
            }
        }
    }
}
