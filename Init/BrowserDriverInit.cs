using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Init
{
    //@Autor Gerardo.Ferreyra SDETCourse 08-Agosto-2022
    public class BrowserDriverInit
    {
        IWebDriver driver;
        
        public void Init_Browser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://es-la.facebook.com/");
        }
       //encapsulamiento
        public string Title{ get { return driver.Title; }}    
       
        public void Test_Case1()
        {
            Thread.Sleep(10000);
            IWebElement logoFace = driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[1]/div/img"));
            Assert.IsTrue(logoFace.Displayed);
            Console.WriteLine("DONE");
        }

        public void Close()
        {
            driver.Quit();
        }

        //encapsulamiento
        public IWebDriver getDriver{ get { return driver; }}
    }
}
