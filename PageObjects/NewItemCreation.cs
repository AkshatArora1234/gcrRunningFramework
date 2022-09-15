using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;

namespace SpecFlow_MSTestFrameWork.PageObjects
{
    public class NewItemCreation
    {

        private IWebDriver Driver;

        public NewItemCreation(IWebDriver driver) : base()
        {
            Driver = driver;
        }

        IWebElement SideMenu => Driver.FindElement(By.XPath("//div[@class='SideMenuWrapper SideMenuWrapperSmall']"));
        IWebElement Searchbar => Driver.FindElement(By.XPath("//input[@id='search-text']"));
        IWebElement ElementClick => Driver.FindElement(By.XPath("//span/strong[text()='Item Maintenance in HQ mode']"));
        IWebElement NewItembutton => Driver.FindElement(By.XPath("(//span[text()='New'])[1]"));
        IWebElement EnterBarcode => Driver.FindElement(By.XPath("//input[@name='barcode']"));
        IWebElement EnterItemDescription => Driver.FindElement(By.XPath("//input[@name='itemDescription']"));

        private CustomControls EnterDropDown => new CustomControls(Driver, By.XPath("(//div[@class='selectize-input items not-full ng-valid ng-pristine has-options'])[1]"));
        private CustomControls EnterDropDown1 => new CustomControls(Driver, By.XPath("(//div[@class='selectize-input items not-full ng-valid ng-pristine has-options'])[1]"));
        private CustomControls EnterDropDown2 => new CustomControls(Driver, By.XPath("(//div[@class='selectize-input items not-full ng-valid ng-pristine has-options'])[1]"));
        private CustomControls EnterDropDown3 => new CustomControls(Driver, By.XPath("(//div[@class='col-sm-8 N_P_A'])[6]"));
        private CustomControls EnterDropDown4 => new CustomControls(Driver, By.XPath("(//div[@class='col-sm-8 N_P_A'])[7]"));
        
        IWebElement ItemCode => Driver.FindElement(By.XPath("(//input[@class='form-control common-text-feild ng-pristine ng-untouched ng-valid ng-not-empty'])[1]"));
        IWebElement ItemDescription => Driver.FindElement(By.Name("itemDescription"));
        IWebElement BatchLink => Driver.FindElement(By.XPath("//div [@class='app-l-item-batch__right']"));
        IWebElement MoreDetails => Driver.FindElement(By.XPath("//span[text()='More Details']"));
        IWebElement NewItemsTab => Driver.FindElement(By.XPath("(//a[@class='nav-link ng-binding'])[11]"));
        IWebElement ComparisonRow => Driver.FindElement(By.XPath("//*[@id='gridBPITNEW']/div/div[6]/div/div/div[1]/div/table/tbody/tr[1]/td[1]"));
        IWebElement ComparisonRow2 => Driver.FindElement(By.XPath("//*[@id='gridBPITNEW']/div/div[6]/div/div/div[1]/div/table/tbody/tr[1]/td[3]"));
        IWebElement Options => Driver.FindElement(By.XPath("/html/body/div[1]/div/span/div[2]/div[1]/div/div/gm-appbar/div/div[2]/div[4]/div/div/form/div[1]/div/div/ul/li/a/span/span"));
        IWebElement PublishButton => Driver.FindElement(By.XPath("/html/body/div[1]/div/span/div[2]/div[1]/div/div/gm-appbar/div/div[2]/div[4]/div/div/form/div[1]/div/div/ul/li/ul/li[2]/a/span/span"));
        IWebElement PublishYes => Driver.FindElement(By.Id("submitButton"));
        IWebElement Save => Driver.FindElement(By.XPath("//button[@class='button-save']"));


        public void SearchForKeyword()
        {
            Thread.Sleep(8000);
            SideMenu.Click();
            Searchbar.Clear();
            Searchbar.SendKeys("Item Maintenance in HQ mode");
            ElementClick.Click();
        }

        public void CreateNewItem()
        {
            Thread.Sleep(5000);
            NewItembutton.Click();
            Random rand = new Random();
            int number = rand.Next(0, 9999);
            EnterBarcode.SendKeys("1" + number);
            EnterItemDescription.SendKeys("Test" + number);
            Thread.Sleep(5000);
            EnterDropDown.SelectType("GENERAL MERCH (12)");
            EnterDropDown1.SelectType("GENERAL MERCH (12)");
            EnterDropDown2.SelectType("NEWSPAPERS (26)");
            EnterDropDown3.SelectType("1-AHM (1-AHM)");
            Thread.Sleep(5000);
            EnterDropDown4.SelectType("00000000-9-WHS (00000000))");
            Save.Click();
        }

        public void GetItemDetailsAndPublish()
        {
            Thread.Sleep(10000);
            string value1 = ItemCode.GetAttribute("value").ToString();
            string value2 = ItemDescription.GetAttribute("value").ToString();
            BatchLink.Click();
            Thread.Sleep(5000);
            MoreDetails.Click();
            Thread.Sleep(8000);
            NewItemsTab.Click();
            Thread.Sleep(5000);
            string row1 = ComparisonRow.Text;
            string row2 = ComparisonRow2.Text;
            Debug.Assert(row1 == value1);
            Debug.Assert(row2 == value2);
            Options.Click();
            PublishButton.Click();
            Thread.Sleep(1000);
            PublishYes.Click();
        }


    }
}
