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
    class SeleniumGetMethods
    {

        public static string GetText(IWebElement element)
        {
            return element.GetAttribute("value");
   
        }

        public static string GetTextDDL(IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;

        }

    }
}
