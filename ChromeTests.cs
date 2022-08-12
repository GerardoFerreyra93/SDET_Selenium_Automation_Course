using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumTest.Accions;

namespace SeleniumTest
{
    public class ChromeTests : FacebookLogginAccions
    {

        [SetUp]
        public void Setup()
        {
            InitBrowser();
        }

        [Test]
        public void Test1()
        {
        }


        [Test]
        public void Test2()
        {
            ValidateFacebookLogo();
        }

        [TearDown]
        public void closeBrowser()
        {
            CloseBrowser();
        }
    }
}