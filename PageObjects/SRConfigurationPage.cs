using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace SpecFlow_MSTestFrameWork.PageObjects
{
    class SRConfigurationPage
    {
        private IWebDriver Driver;
        HomePage homePage;
        Scaleconfig scaleConfigurationPage;
        ConfigurationPage configurationPage;
        String VerifyText;
        public SRConfigurationPage(IWebDriver driver)
        {
            Driver = driver;
            scaleConfigurationPage = new Scaleconfig(driver);
            homePage = new HomePage(Driver);
            configurationPage = new ConfigurationPage(Driver);

        }
  
       
        IWebElement SRcodeverification() => Driver.FindElement(By.XPath($"//*[text()='{VerifyText}']"));

        public void ComparePrintFormat(string searchcode, string verifytext)
        {
            VerifyText = verifytext;
            Thread.Sleep(3000);
            string printformattext = searchcode;
            configurationPage.Printformat(printformattext);
            Thread.Sleep(3000);
            string textvalue = SRcodeverification().Text;
            Assert.AreEqual(textvalue, verifytext);
        }

       

        public void CompareTare(string searchcode, string verifytext)
        {
            VerifyText = verifytext;
            Thread.Sleep(3000);
            string text = searchcode;
            configurationPage.Tare(text);
            string textvalue = SRcodeverification().Text;
            Assert.AreEqual(textvalue, verifytext);

        }
        public void CompareContentSymbol(string searchcode, string verifytext)
        {
            VerifyText = verifytext;
            Thread.Sleep(3000);
            string text = searchcode;
            configurationPage.SearchContentSymbol(text);
            string textvalue = SRcodeverification().Text;
            Assert.AreEqual(textvalue, verifytext);

        }
        public void ComparePresetMsg(string searchcode, string verifytext)
        {
            VerifyText = verifytext;
            Thread.Sleep(3000);
            string text = searchcode;
            configurationPage.PM(text);
            Thread.Sleep(5000);
            string textvalue = SRcodeverification().Text;
            Assert.AreEqual(textvalue, verifytext);

        }
    }
}
