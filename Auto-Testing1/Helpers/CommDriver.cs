using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTesting1.Helpers
{
    class CommDriver
    {
        // Inititalize driver- Common object for all the class in this project
        // Define driver in Program.cs [Tests]
        public static IWebDriver driver { set; get; }
    }
}
