using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoTesting1.Page
{
    class TMPages
    {
        public object GCDriver { get; private set; }

        //Function to create new data
        public void CreateRecord(IWebDriver driver)
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

            //Check last data entry //*[@id="tmsGrid"]/div[3]/table/tbody/tr[3]
            IWebElement NewRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[6]"));

            if (NewRecord.Text == "Auto Test")
            {
                Console.WriteLine("New Record has been added!");
            }
            else
            {
                Console.WriteLine("No new record!");
            }
        }
        //Function to Edit Record

        


        public void EditRecord(IWebDriver driver)
        {
            if (Helpers.Utilities.IsExistsRecord(driver) == true)
            {
                //Click on 'Edit' button 
                driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[1]")).Click();

                //Clear value in Code
                driver.FindElement(By.XPath("//*[@id='Code']")).Clear();

                // Change Data of Code
                driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("Auto");

                //Clear Discription
                driver.FindElement(By.XPath("//*[@id='Description']")).Clear();

                // Change Data of Discription
                driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("Discription");

                //Clear price per unit //*[@id="TimeMaterialEditForm"]/div/div[4]/div/span[1]/span
                // driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Clear();

                // Change Data of price per unit 
                // driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("123");

                //Click "Save" Button
                driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();

                //Nevigate to last Page //*[@id="tmsGrid"]/div[4]/a[4]
                driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")).Click();

                //Verify Edited Data Entry 
                IWebElement EditRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[6]"));

                if (EditRecord.Text == "Auto")
                {
                    Console.WriteLine("Selected Record has been edited!");
                }
                else
                {
                    Console.WriteLine("Edit Failed!");
                }
            }
            else
            {
                Helpers.Utilities.AddTM(driver);
                //edit
            }


           
            
        }
        // Delete Record Function
        public void DeleteRecord(IWebDriver driver)
        {
            //Click Delete Button
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[6]/td[5]/a[2]")).Click();

            //Press 'OK' Button
        }
    }
}
