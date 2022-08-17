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
using OpenQA.Selenium.Interactions;

namespace SeleniumTest.Accions
{
    public class FacebookLogginAccions : BrowserDriverInit
    {
        BrowserDriverInit browser;
               
       
        private IWebElement DynamicId => browser.getDriver.FindElement(By.XPath("//a[@href='/dynamicid']"));
        private IWebElement DynamicIdTitle => browser.getDriver.FindElement(By.XPath("//h3"));
        private IWebElement DynamicIdButton => browser.getDriver.FindElement(By.XPath("//button[@class='btn btn-primary']"));
        private IWebElement ClassAttributeId => browser.getDriver.FindElement(By.XPath("//a[@href='/classattr']"));
        private IWebElement ClassAttributeButton => browser.getDriver.FindElement(By.XPath("//button[contains(@class, ' btn-primary ')]"));
        private IWebElement HiddenLayersId => browser.getDriver.FindElement(By.XPath("//a[@href='/hiddenlayers']"));
        private IWebElement HiddenLayersTitle => browser.getDriver.FindElement(By.XPath("//h3"));
        private IWebElement LoadDelayId => browser.getDriver.FindElement(By.XPath("//a[@href='/loaddelay']"));
        private IWebElement LoadDelayButton => browser.getDriver.FindElement(By.XPath("//button[@class='btn btn-primary']"));
        private IWebElement ClickId => browser.getDriver.FindElement(By.XPath("//a[@href='/click']"));
        private IWebElement ClickIdButton => browser.getDriver.FindElement(By.XPath("//button[@class='btn btn-primary']"));
        private IWebElement TextInputId => browser.getDriver.FindElement(By.XPath("//a[@href='/textinput']"));
        private IWebElement TextInputNewName => browser.getDriver.FindElement(By.XPath("//*[@id='newButtonName']"));
        private IWebElement TextInputButton => browser.getDriver.FindElement(By.XPath("//button[@class='btn btn-primary']")); 
        private IWebElement ScrollbarsId => browser.getDriver.FindElement(By.XPath("//a[@href='/scrollbars']"));        
        private IWebElement DynamicTableId => browser.getDriver.FindElement(By.XPath("//a[@href='/dynamictable']"));
        private IWebElement VerifyTextId => browser.getDriver.FindElement(By.XPath("//a[@href='/verifytext']"));
        private IWebElement ProgressBarId => browser.getDriver.FindElement(By.XPath("//a[@href='/progressbar']"));
       







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
            System.Threading.Thread.Sleep(5000);

        }

        internal void ValidateClassAttribute()
        {

            ClassAttributeId.Click();           
            ClassAttributeButton.Click();
            System.Threading.Thread.Sleep(5000); // cambiar por implicit                    
            IAlert alert = browser.getDriver.SwitchTo().Alert();//cerrar pop-ups
            alert.Accept();
            System.Threading.Thread.Sleep(5000);
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
            System.Threading.Thread.Sleep(5000);
        }

        internal void ValidateClick()
        {
            ClickId.Click();
            System.Threading.Thread.Sleep(10000);
            ClickIdButton.Click();
            System.Threading.Thread.Sleep(10000);
        }

    
        internal void ValidateTextInput()
        {
            TextInputId.Click();
            System.Threading.Thread.Sleep(10000);
            TextInputNewName.SendKeys("GerardoFerreyra");
            TextInputButton.Click();
            System.Threading.Thread.Sleep(10000);            

        }     

        internal void ValidateScrollbars()
        {
            ScrollbarsId.Click();
            System.Threading.Thread.Sleep(10000);      
            
            IWebElement s = browser.getDriver.FindElement(By.XPath("//button[@class='btn btn-primary']")); ;
            IJavaScriptExecutor je = (IJavaScriptExecutor)browser.getDriver;
            je.ExecuteScript("arguments[0].scrollIntoView(true);", s);
            System.Threading.Thread.Sleep(10000);              

        }

        internal void ValidateDynamicTable()
        {
            DynamicTableId.Click();
            System.Threading.Thread.Sleep(10000);


        }

        internal void ValidateVerifyText()
        {
            VerifyTextId.Click();
            System.Threading.Thread.Sleep(10000);
            
        }

        internal void ValidateProgressBar()
        {
            ProgressBarId.Click();
            System.Threading.Thread.Sleep(10000);
        }


    }
}

