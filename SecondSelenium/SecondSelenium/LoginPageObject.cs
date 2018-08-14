using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Events;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Interactions;

namespace SecondSelenium
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "_nkw")]

        public IWebElement txtbusqueda { get; set; }

        [FindsBy(How = How.Id, Using = "gh-btn")]

        public IWebElement btnbuscar { get; set; }
            
        [FindsBy(How = How.XPath, Using = "//input[@aria-label='PUMA'][@aria-label='PUMA']")]

        public IWebElement checkbox_puma { get; set; }


        [FindsBy(How = How.XPath, Using = "//input[@aria-label='10']")]

        public IWebElement checkbox_size { get; set; }

        [FindsBy(How = How.XPath, Using = "//h1[@class='srp-controls__count-heading']")]

        public IWebElement txt_cant_resultados { get; set; }


        [FindsBy(How = How.Id, Using = "srp-river-results-SEARCH_STATUS_MODEL_V2-w0-w1_btn")]

        public IWebElement btnordenar { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@class='srp-sort__menu']/li[4]/a")]
        
        public IWebElement orden_precio_asc { get; set; }

        //PRODUCTOS
        [FindsBy(How = How.XPath, Using = "//div[@id='srp-river-results']/ul/li[1]/div/div[2]/a/h3")]        
     
        public IWebElement txt_producto1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='srp-river-results']/ul/li[1]/div/div[2]/div[3]/div[1]/span/span")]

        public IWebElement txt_precio1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='srp-river-results']/ul/li[2]/div/div[2]/a/h3")]

        public IWebElement txt_producto2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='srp-river-results']/ul/li[2]/div/div[2]/div[3]/div[1]/span")]

        public IWebElement txt_precio2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='srp-river-results']/ul/li[3]/div/div[2]/a/h3")]

        public IWebElement txt_producto3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='srp-river-results']/ul/li[3]/div/div[2]/div[3]/div[1]/span/span")]

        public IWebElement txt_precio3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='srp-river-results']/ul/li[4]/div/div[2]/a/h3")]

        public IWebElement txt_producto4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='srp-river-results']/ul/li[4]/div/div[2]/div[3]/div[1]/span")]

        public IWebElement txt_precio4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='srp-river-results']/ul/li[5]/div/div[2]/a/h3")]

        public IWebElement txt_producto5 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='srp-river-results']/ul/li[5]/div/div[2]/div[3]/div[1]/span")]

        public IWebElement txt_precio5 { get; set; }

        
        public void prueba(string busqueda)
        {
            PropertiesCollection.driver.Manage().Window.Maximize();
            txtbusqueda.Clear();
            txtbusqueda.SendKeys(busqueda);
            btnbuscar.Submit();
            
            checkbox_puma.Click();
            
            checkbox_size.Click();

            Console.WriteLine("Se obtuvieron: " + txt_cant_resultados.Text);

            new Actions(PropertiesCollection.driver).MoveToElement(PropertiesCollection.driver.FindElement(By.Id("srp-river-results-SEARCH_STATUS_MODEL_V2-w0-w1_btn"))).Perform();
           
            orden_precio_asc.Click();


            //Impresion de detalle de productos
            Console.WriteLine("");
            Console.WriteLine("Nombre: " + txt_producto1.Text);          
            Console.WriteLine("Precio: " + txt_precio1.Text);
            Console.WriteLine("Nombre: " + txt_producto2.Text);
            Console.WriteLine("Precio: " + txt_precio2.Text);
            Console.WriteLine("Nombre: " + txt_producto3.Text);
            Console.WriteLine("Precio: " + txt_precio3.Text);
            Console.WriteLine("Nombre: " + txt_producto4.Text);
            Console.WriteLine("Precio: " + txt_precio4.Text);
            Console.WriteLine("Nombre: " + txt_producto5.Text);
            Console.WriteLine("Precio: " + txt_precio5.Text);

            Console.WriteLine("");
            Console.WriteLine("Orden por Nombre (Ascendente)");

            String[] words = { txt_producto1.Text, txt_producto2.Text, txt_producto3.Text, txt_producto4.Text, txt_producto5.Text };

            IEnumerable<string> query = from word in words
                                        orderby word.Substring(0, 2) ascending
                                        select word;

            foreach (string str in query)
                Console.WriteLine(str);


            Console.WriteLine("");
            Console.WriteLine("Orden por Precio (Descendente)");


            String[] precioscom = { txt_precio1.Text, txt_precio2.Text, txt_precio3.Text, txt_precio4.Text, txt_precio5.Text };
            
            IEnumerable<string> query3 = from word in precioscom
                                        orderby Convert.ToDouble(word.Substring(4, word.Length - 4)) descending
                                        select word;

           
            foreach (String str in query3)                             
                Console.WriteLine(str);

         
           
        }

    }
}
