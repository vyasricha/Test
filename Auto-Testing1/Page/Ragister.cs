using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTesting1.Page
{
    class Ragister
    {
            public void Login(IWebDriver driver)
            {
                // Enter the URL
#pragma warning disable CA2234 // Pass system uri objects instead of strings
                driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login");
#pragma warning restore CA2234 // Pass system uri objects instead of strings

                //Maximise the window
                driver.Manage().Window.Maximize();

                //Enter UserName
                IWebElement user = driver.FindElement(By.Id("UserName"));
                user.SendKeys("hari");

                //Enter PassWord
                IWebElement Password = driver.FindElement(By.Id("Password"));
                Password.SendKeys("123123");

                //Click on Login Button
                IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                LoginButton.Click();

                //Verify if user login sucessfully
                IWebElement helloHariHome = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

                if (helloHariHome.Text == "Hello hari!")
                {
                    Console.WriteLine("Test Passed, login successfully!");
                }
                else
                {
                    Console.WriteLine("Test Failed, login unsuccessful...");
                }
            }
    }
}

