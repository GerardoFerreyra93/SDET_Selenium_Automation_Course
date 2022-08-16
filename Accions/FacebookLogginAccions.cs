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
using System.Drawing;


namespace SeleniumTest.Accions
{
    public class FacebookLogginAccions : BrowserDriverInit
    {
        BrowserDriverInit browser;
        Click c = new Click();
        
       
        private IWebElement DynamicId => browser.getDriver.FindElement(By.XPath("//a[@href='/dynamicid']"));
        private IWebElement DynamicIdTitle => browser.getDriver.FindElement(By.XPath("//h3"));
        private IWebElement DynamicIdButton => browser.getDriver.FindElement(By.XPath("//button[@class='btn btn-primary']"));
        private IWebElement ClassAttributeId => browser.getDriver.FindElement(By.XPath("//a[@href='/classattr']"));
        private IWebElement ClassAttributeButton => browser.getDriver.FindElement(By.XPath("/html/body/section/div/button[1]"));
        private IWebElement HiddenLayersId => browser.getDriver.FindElement(By.XPath("//a[@href='/hiddenlayers']"));
        private IWebElement HiddenLayersTitle => browser.getDriver.FindElement(By.XPath("//h3"));
        private IWebElement LoadDelayId => browser.getDriver.FindElement(By.XPath("//a[@href='/loaddelay']"));
        private IWebElement LoadDelayButton => browser.getDriver.FindElement(By.XPath("//button[@class='btn btn-primary']"));
        private IWebElement ClickId => browser.getDriver.FindElement(By.XPath("//a[@href='/click']"));
        private IWebElement ClickIdButton => browser.getDriver.FindElement(By.CssSelector("#badButton"));
        private IWebElement TextInputId => browser.getDriver.FindElement(By.XPath("//a[@href='/textinput']"));
        private IWebElement TextInputNewName => browser.getDriver.FindElement(By.XPath("//*[@id='newButtonName']"));
        private IWebElement TextInputButton => browser.getDriver.FindElement(By.XPath("//button[@class='btn btn-primary']"));




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

       
        internal void ValidateDynamicIdElement()
        {
            DynamicId.Click();         
            System.Threading.Thread.Sleep(5000);
            Assert.IsTrue(DynamicIdTitle.Displayed);
            Assert.IsTrue(DynamicIdButton.Displayed);


        }

        internal void ValidateClassAttribute()
        {

            ClassAttributeId.Click();           
            ClassAttributeButton.Click();
            System.Threading.Thread.Sleep(5000);
            //close popup windwos pending

        }

        internal void ValidateHiddenLayers()
        {
            HiddenLayersId.Click();
            System.Threading.Thread.Sleep(5000);
            Assert.IsTrue(HiddenLayersTitle.Displayed);
        }

        internal void ValidateLoadDelay()
        {
            LoadDelayId.Click();
            System.Threading.Thread.Sleep(5000);
            LoadDelayButton.Click();


        }

        internal void ValidateClick()
        {
            ClickId.Click();
            System.Threading.Thread.Sleep(10000);
            ClickIdButton.Click();    // se tiene que emular el click fisico     

        }

        internal void ButtonClick()
        {
            ClickId.Click();
            System.Threading.Thread.Sleep(10000);
            Point p = new Point();
            p.X = 50;
            p.Y = 50;
            c.leftClick(p);
        }



        internal void ValidateTextInput()
        {
            TextInputId.Click();
            System.Threading.Thread.Sleep(10000);
            TextInputNewName.SendKeys("GerardoFerreyra");//se tiene que emular
            TextInputButton.Click();

        }     



    }
}

