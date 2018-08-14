using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using NUnit.Framework;

namespace SecondSelenium
{
    class SeleniumSetMethods
    {
        
        public static void EnterText(IWebElement element, string value)
        {
            element.SendKeys(value);
         
        }

        
        public static void click(IWebElement element)
        {
            element.Click();
           
        }

        
        public static void SelectDropDown(IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
            
            
        }
    }
}
