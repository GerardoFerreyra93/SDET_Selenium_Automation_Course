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
        public void Test1_DynamicID()
        {
            ValidateDynamicIdElement();
            
        }


        [Test]
        public void Test2_ClassAttribute()
        {

            ValidateClassAttribute();
        }

        [Test]
        public void Test3_HiddenLayers()
        {

            ValidateHiddenLayers();
        }

        [Test]
        public void Test4_LoadDelay()
        {

            ValidateLoadDelay();
        }

        [Test]
        public void Test5_Click()
        {

            ValidateClick();
        }

        [Test]
        public void Test6_TextInput()
        {

            ValidateTextInput();
        }
        

        [Test]
        public void Test7_Scrollbars()
        {

            ValidateScrollbars();
        }

        [Test]
        public void Test8_DynamicTable()
        {

            ValidateDynamicTable();
        }

        [Test]
        public void Test9_VerifyText()
        {

            ValidateVerifyText();
        }

        [Test]
        public void Test10_ProgressBar()
        {

            ValidateProgressBar();
       
        }
        




        [TearDown]
        public void closeBrowser()
        {
            CloseBrowser();
        }
    }
}