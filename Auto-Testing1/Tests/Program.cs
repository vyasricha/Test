using AutoTesting1.Helpers;
using AutoTesting1.Page;
using OpenQA.Selenium.Chrome;

namespace AutoTesting1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lunch Chrome Browser
            // Define driver Object of CommDriver Class [Helper]
            CommDriver.driver = new ChromeDriver();

            //Step to Login
            Ragister LoginObj = new Ragister();
            LoginObj.Login(CommDriver.driver);

            //Step to Nevigate to TM
            HomePage NeviObj = new HomePage();
            NeviObj.NavigatetoTM(CommDriver.driver);

            //Step to Create New Record in TM 
            TMPages TMObj = new TMPages();
            TMObj.CreateRecord(CommDriver.driver);

            TMObj.EditRecord(CommDriver.driver);

            TMObj.DeleteRecord(CommDriver.driver);
        }
    }
}
