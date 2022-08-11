using OpenQA.Selenium;
using SeleniumTest.Init;

namespace SeleniumTest
{
    public class ChromeTest : BrowserDriverInit
    {
        BrowserDriverInit browser = new BrowserDriverInit();

        [SetUp]
        public void Setup()
        {            
            browser.Init_Browser();

        }

        [Test]
        public void Test()
        {
            browser.Test_Case1(); 
            
        }

        [TearDown]
        public void closeBrowse()
        {
            browser.Close();

        }

    }
}