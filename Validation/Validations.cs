using OpenQA.Selenium;
using SeleniumTest.Accions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Pages
{
    public class Validations : FacebookLogginAccions
    {
        public Validations()
        {
        }

        internal void ValidateElementIsDisplayed(IWebElement element)
        {
            Assert.True(element.Displayed);
        }

    }
}