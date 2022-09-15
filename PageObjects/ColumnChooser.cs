using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;
using System.Threading;

namespace SpecFlow_MSTestFrameWork.PageObjects
{
    public class ColumnChooser
    {

        private IWebDriver Driver;
        HomePage homePage;
        public ColumnChooser(IWebDriver driver)
        {
            Driver = driver;
            homePage = new HomePage(driver);
        }

        IWebElement ShowColumnChooser => Driver.FindElement(By.XPath("(//div[@aria-label='Show Column Chooser'])[8]"));
        IWebElement Search => Driver.FindElement(By.XPath("//input[@aria-label='Search']"));
        IWebElement DDFrom => Driver.FindElement(By.XPath("//div[text()='Scale Item']"));
        IWebElement DDTo => Driver.FindElement(By.XPath("//*[@id='gridITEMHQ']/div/div[5]/div/table/tbody/tr[1]"));
        IWebElement ScaleItemDropDown => Driver.FindElement(By.XPath("(//div[@class='dx-dropdowneditor-icon'])[5]"));
        IWebElement FirstScaleElement => Driver.FindElement(By.XPath("//*[@id='gridITEMHQ']/div/div[6]/div/div/div[1]/div/table/tbody/tr[1]/td[1]"));
        IWebElement ClickScaleTab => Driver.FindElement(By.XPath("(//a[@ng-click='select($event)'])[11]"));
        IWebElement SaveItem => Driver.FindElement(By.XPath("//button[@ng-click='ctrl.savePFChanges()']"));
        IWebElement PFDropDownValue => Driver.FindElement(By.XPath("//span[text()=' Popcorn']"));
        private CustomControls PFDropDown => new CustomControls(Driver, By.XPath("//div[@class='selectize-input items ng-valid full has-options has-items']"));
        private CustomControls ContentSymbolDropdown => new CustomControls(Driver, By.XPath("//select[@name='contentSymbol']"));
        IWebElement NutriData => Driver.FindElement(By.XPath("(//input[@ng-model='pFSections.scaleItemNutriInfo.servingSize'])[1]"));
        IWebElement NutriData2 => Driver.FindElement(By.XPath("(//input[@ng-model='pFSections.scaleItemNutriInfo.servingSize'])[2]"));
        IWebElement NavigateToItem => Driver.FindElement(By.XPath("//*[contains(text(),'Item (HQ):')]"));

        public void ChooseAColumn()
        {
            Actions actions = new Actions(Driver);
            string scaleColumn = homePage.getConfiguration("TestData.json", "ColumnName");
            Thread.Sleep(3000);
            ShowColumnChooser.Click();
            Search.SendKeys(scaleColumn);
            actions.DragAndDrop(DDFrom, DDTo).Perform();
            Thread.Sleep(3000);
            actions.DragAndDrop(DDFrom, DDTo).Perform();
            actions.Release();
        }
        

        public void SelectScaleValue()
        {
            Actions actions = new Actions(Driver);
            ScaleItemDropDown.Click();
            actions.SendKeys(Keys.Down).SendKeys(Keys.Down).SendKeys(Keys.Enter).Build().Perform();     
        }

        public void SelectFirstScaleRecord()
        {
            Actions actions = new Actions(Driver);
            actions.DoubleClick(FirstScaleElement).Perform();
            Thread.Sleep(5000);
        }

        public void ClickScaleTabInItems() => ClickScaleTab.Click();

        public void SelectPFForItem()
        {
            Thread.Sleep(5000);
            PFDropDown.SelectType("Popcorn");
            Actions actions = new Actions(Driver);
            actions.MoveToElement((IWebElement)PFDropDownValue);
            actions.Perform();
            PFDropDownValue.Click();
        }

        public void AddContentSymbol(string text)
        {
            ContentSymbolDropdown.SelectByText(text);
        }

        public void NutritionalData(string a, string b)
        {
            NutriData.SendKeys(a);
            NutriData2.SendKeys(b);
        }

        public void SaveItemPF() => SaveItem.Click();

        public void NavigateToItemDetailPage() => NavigateToItem.Click();

        public void AssertContentsymbol()
        {
            string ContentSymbol = homePage.getConfiguration("TestData.json", "NewContentSymbol2.0.2");
            Thread.Sleep(6000);
            SelectElement oSelection = new SelectElement(Driver.FindElement(By.XPath("//select[@name='contentSymbol']")));
            string element = oSelection.SelectedOption.Text;
            Assert.AreEqual(element,ContentSymbol);        
        }
    }
}
