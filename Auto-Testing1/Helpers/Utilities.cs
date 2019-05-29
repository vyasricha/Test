using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoTesting1.Helpers
{
    class Utilities
    {
        //Function to validate if the table contains a record
        public static bool IsExistsRecord(IWebDriver driver)
        {
            //Validate if a record is present in the table
            IWebElement firstElementInTable = driver.FindElement(By.XPath(""));

            if (firstElementInTable.Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Fuction to add TM
        public static void AddTM(IWebDriver driver)
        {
            //Click on 'Create New' button
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();

            //Enter Code
            driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("Auto Test");

            //Enter Discription
            driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("Auto Description");

            //Enter Price per unit
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("7878");

            //Click "Save" Button
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();

            //For Waiting to load Page
            Thread.Sleep(1000);

            //Verify the new data entry

            //Nevigate to last Page 
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
        }
    }
}
