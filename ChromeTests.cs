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
        public void PlayGroundTest1()
        {
            ValidateDynamicIdElement();
            
        }


        [Test]
        public void PlayGroundTest2()
        {

            ValidateClassAttribute();
        }

        [Test]
        public void PlayGroundTest3()
        {

            ValidateHiddenLayers();
        }

        [Test]
        public void PlayGroundTest4()
        {

            ValidateLoadDelay();
        }

        [Test]
        public void PlayGroundTest5()
        {

            ValidateClick();
        }

        [Test]
        public void PlayGroundTest6()
        {

            ButtonClick();
        }

        [Test]
        public void PlayGroundTest7()
        {

            ValidateTextInput();
        }
        


        [TearDown]
        public void closeBrowser()
        {
            CloseBrowser();
        }
    }
}