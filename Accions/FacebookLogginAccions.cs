using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumTest.Init;
using SeleniumTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeleniumTest.Accions
{
    public class FacebookLogginAccions : BrowserDriverInit
    {
        BrowserDriverInit browser;

        private IWebElement FaceLogo => browser.getDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[1]/div/img"));
        private IWebElement ASD => browser.getDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[1]/div/img"));
        private IWebElement sad => browser.getDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[1]/div/img"));
        private IWebElement dasda => browser.getDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[1]/div/img"));
        private IWebElement FaceLogasdao => browser.getDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[1]/div/img"));
        private IWebElement adsad => browser.getDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[1]/div/img"));
        private IWebElement asddas => browser.getDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[1]/div/img"));
        public FacebookLogginAccions()
        {
            browser = new BrowserDriverInit();
        }
        internal void InitBrowser()
        {
            browser.Init_Browser();
        }

        internal void CloseBrowser()
        {
            browser.Close();
        }

        internal void GoToFacebookLogin(string url)
        {
            browser.GoTo(url);
            System.Threading.Thread.Sleep(10000);
        }

        internal void ValidateFacebookLogo()
        {
            GoToFacebookLogin("https://www.facebook.com");

            for (int i = 0; i > 4; i++)
            {
                try
                {
                    if (FaceLogo.Displayed) Console.WriteLine("Is Displayed");
                }
                catch (ElementNotVisibleException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Assert.IsTrue(FaceLogo.Displayed);
         

        }

        //explicit wait
        internal void ValidateMessageDescription()
        {
            using(IWebDriver driver = new ChromeDriver())
            {
                driver.Url = "https://www.facebook.com";
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                IWebElement btnLogin = wait.Until<IWebElement>(d => d.FindElement(By.XPath("//*[@id='content']/div/div/div/div[1]/h2")));
                Console.WriteLine("Explicit Wait DONE");
            }
        }
    }
}

