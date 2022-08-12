using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Init
{
    public class BrowserDriverInit
    {
        IWebDriver driver;

        public void Init_Browser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

        }

        private WebDriverWait _wait => new WebDriverWait(driver, TimeSpan.FromSeconds(2));
        public string Title { get { return driver.Title; } }

        public void GoTo(string url)
        {
            driver.Url = url;
        }

        public void Close()
        {
            driver.Quit();
        }
        public IWebElement WaitForElement(By locator)
        {
            return _wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public IWebDriver getDriver { get { return driver; } }

    }
}
