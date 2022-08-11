using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Init
{
    public class BrowserDriverInit
    {
        IWebDriver driver;

        //

        public void Init_Browser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public string Title
        {
            get { return driver.Title; }
        }    

        public void GoTo(string url)
        {
            driver.Url = url;
        }

        public void Close()
        {
            driver.Quit();
        }

        public IWebDriver getDriver
        {
            get { return driver; }
        }
    }
}
