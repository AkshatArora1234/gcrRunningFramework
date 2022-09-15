using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SpecFlow_MSTestFrameWork.PageObjects
{
    class ConfigurationPage
    {
        private IWebDriver Driver;
        Scaleconfig scaleConfigurationPage;

        public ConfigurationPage(IWebDriver driver)
        {
            Driver = driver;
            scaleConfigurationPage = new Scaleconfig(driver);
        }

        IWebElement ScaleConfigurationTab => Driver.FindElement(By.XPath("(//span[text()='Scale Configuration'])[2]"));
        IWebElement ConfigurationTab => Driver.FindElement(By.XPath("//a/uib-tab-heading[text()='Configuration']"));
        IWebElement ContentCodeSearch => Driver.FindElement(By.XPath("(//input[@class='dx-texteditor-input'])[5]"));
        IWebElement SRTareCodeSearch => Driver.FindElement(By.XPath("(//input[@class='dx-texteditor-input'])[5]"));
        IWebElement SRPresetCodeSearch => Driver.FindElement(By.XPath("(//input[@class='dx-texteditor-input'])[7]"));
        IWebElement pfcodesearch => Driver.FindElement(By.XPath("(//input[@class='dx-texteditor-input'])[11]"));
        IWebElement FontSearch => Driver.FindElement(By.XPath("(//input[@class='dx-texteditor-input'])[1]"));
        IWebElement EditContentSymbol => Driver.FindElement(By.XPath("(//div[@ng-click='ctrl.toggleEditMode(false)'])[2]"));
        IWebElement EditFont => Driver.FindElement(By.XPath("(//div[@ng-click='ctrl.toggleEditMode(false)'])[1]"));
        IWebElement NewContentSymbolName => Driver.FindElement(By.XPath("//*[@id='gridCONTSYM']/div/div[6]/div/div/div[1]/div/table/tbody/tr[1]/td[2]"));
        IWebElement ClearContentSymbolName => Driver.FindElement(By.XPath("//*[@id='gridCONTSYM']/div/div[6]/div/div/div[1]/div/table/tbody/tr[1]/td[2]/div/div/div[1]/input"));
        private CustomControls NewContentSymbolNameEdit => new CustomControls(Driver, By.XPath("//*[@id='gridCONTSYM']/div/div[6]/div/div/div[1]/div/table/tbody/tr[1]/td[2]/div/div/div[1]/input"));
        IWebElement ContentSymbolSave => Driver.FindElement(By.XPath("(//span[text()='Save'])[1]"));
        IWebElement ContentSymbolSaveYes => Driver.FindElement(By.Id("submitButton"));
        IWebElement NutriSearch => Driver.FindElement(By.XPath("(//input[@class='dx-texteditor-input'])[17]"));
        IWebElement DeleteNutriPanel => Driver.FindElement(By.XPath("//*[@id='gridSCALENP']/div/div[6]/div[1]/div/div/div/table/tbody/tr[1]/td/div/div/div[@class='action-delete ng-scope']"));
        IWebElement DeleteNutriYes => Driver.FindElement(By.Id("submitButton"));
        IWebElement NutriDeletemessage => Driver.FindElement(By.XPath("//p[@class='ng-binding']"));
        IWebElement LinkNutriNo => Driver.FindElement(By.XPath("//button[@ng-click='ctrl.deleteWithoutLinking()']"));
        IWebElement SelectNutriClick => Driver.FindElement(By.XPath("//*[@id='gridSCALEFONT']/div/div[6]/div/div/div[1]/div/table/tbody/tr[1]/td[3]"));
        IWebElement FontCheckbox => Driver.FindElement(By.XPath("//*[@id='gridSCALEFONT']/div/div[6]/div/div/div[1]/div/table/tbody/tr[1]/td[3]/div/div/span"));
        IWebElement FontSave => Driver.FindElement(By.XPath("(//span[text()='Save'])[1]"));
        IWebElement FontSaveYes => Driver.FindElement(By.Id("submitButton"));

      
        public void PageNavigationToScaleConfigPage() => ScaleConfigurationTab.Click();
        public void PageNavigationToConfigPage() => ConfigurationTab.Click();
        public void SearchFont(string text) => FontSearch.SendKeys(text);
        public void FontEditClick() => EditFont.Click();
        public void SearchContentSymbol(string text)
        {
            ContentCodeSearch.Clear();
            Thread.Sleep(10000);
            ContentCodeSearch.SendKeys(text);  
        }

        public void Printformat(string text)
        {
            Thread.Sleep(5000);
            pfcodesearch.Clear();
            Thread.Sleep(4000);
            pfcodesearch.SendKeys(text);
            Thread.Sleep(4000);
        }
        public void Tare(string text)
        {
            SRTareCodeSearch.Clear();
            SRTareCodeSearch.SendKeys(text);
        }
        public void PM(string text)
        {
            SRPresetCodeSearch.Clear();
            Thread.Sleep(10000);
            SRPresetCodeSearch.SendKeys(text);
        }
        public void EditContent(string text)
        {
            EditContentSymbol.Click();
            Thread.Sleep(3000);
            NewContentSymbolName.Click();
            ClearContentSymbolName.Clear();
            Thread.Sleep(5000);
            scaleConfigurationPage.TabPrintFormatClick();
            scaleConfigurationPage.TabConfiGrationClick();
            NewContentSymbolNameEdit.FillUsingJavascipt(text);
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.Enter);
            action.Perform();
            scaleConfigurationPage.TabPrintFormatClick();
            scaleConfigurationPage.TabConfiGrationClick();
            ContentSymbolSave.Click();
            ContentSymbolSaveYes.Click();
            Thread.Sleep(10000);
        }

        public void EditNutrionalFont()
        {
            SelectNutriClick.Click();
            FontCheckbox.Click();
            scaleConfigurationPage.TabPrintFormatClick();
            scaleConfigurationPage.TabConfiGrationClick();
            FontSave.Click();
            FontSaveYes.Click();
        }

        public void NutriPanelSearch(string text) => NutriSearch.SendKeys(text);
        public void DeleteNutrionalPanel()
        {
            Actions action = new Actions(Driver);
            action.Click(DeleteNutriPanel);
            action.Perform();
            Thread.Sleep(3000);
            if (NutriDeletemessage.Text.Equals("Nutritional panel 'Coco cola' is in use. Link items to another nutritional panel?"))
            {
                LinkNutriNo.Click();
            }
            else
            {
                DeleteNutriYes.Click();
            }
        }
    }
}
