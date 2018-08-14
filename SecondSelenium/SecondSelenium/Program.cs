using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace SecondSelenium
{
    public class Program
    {
        
        static void Main(string[] args)
        {
        
            
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
      
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.ebay.com/sch/i.html?_nkw=e-bay");
        }

        [Test]
        public void prueba()
        {
            
            LoginPageObject pageLogin = new LoginPageObject();
            pageLogin.prueba("shoes");
                      
        }

        [TearDown]
        public void cleanUP()
        {
            //System.Threading.Thread.Sleep(6000);
            //driver2.Close();
        }
    }
}
