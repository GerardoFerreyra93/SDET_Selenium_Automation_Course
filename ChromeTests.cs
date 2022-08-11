using OpenQA.Selenium;
using SeleniumTest.Init;

namespace SeleniumTest
{
    public class ChromeTest : BrowserDriverInit
    {

        BrowserDriverInit browser = new BrowserDriverInit();
        string url = "https://es-la.facebook.com/";
        IWebDriver driver;



        [SetUp]
        public void Setup()
        {
            browser.Init_Browser();
        }

        [Test]
        public void Test1()
        {
            browser.GoTo(url);
            driver = browser.getDriver;

            Thread.Sleep(10000);

            IWebElement logoFace = driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[1]/div/img"));

            Assert.IsTrue(logoFace.Displayed);

        }

        public void closeBrowse()
        {
            driver.Close();
        }

    }
}