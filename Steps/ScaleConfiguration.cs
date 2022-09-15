using Microsoft.Extensions.Configuration;
using SpecFlow_MSTestFrameWork.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SpecFlow_MSTestFrameWork.Steps
{

    [Binding]
    public class ScaleConfiguration
    {
        private readonly DriverHelper _driverHelper;
        NewItemCreation newItemCreation;
        HQLoginPage hQLoginPage;
        Scaleconfig scaleConfigurationPage;
        HomePage homePage;
        ColumnChooser columnChooser;
        NewBatch newBatch;
        ConfigurationPage configurationPage;
        SRConfigurationPage sRConfigurationPage;

        public ScaleConfiguration(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            newItemCreation = new NewItemCreation(_driverHelper.driver);
            hQLoginPage = new HQLoginPage(_driverHelper.driver);
            scaleConfigurationPage = new Scaleconfig(_driverHelper.driver);
            homePage = new HomePage(_driverHelper.driver);
            columnChooser = new ColumnChooser(_driverHelper.driver);
            newBatch = new NewBatch(_driverHelper.driver);
            configurationPage = new ConfigurationPage(_driverHelper.driver);
            sRConfigurationPage = new SRConfigurationPage(_driverHelper.driver);
        }


        /// <summary>
        /// Common Function for all test cases, click on Left Menu
        /// </summary>

        [When(@"User clicks on the Left Menu")]
        public void WhenUserClicksOnTheLeftMenu()
        {
            Thread.Sleep(4000);
            scaleConfigurationPage.ClickLeftMenu();
        }

        [Then(@"menu should be displayed")]
        public void ThenMenuShouldBeDisplayed()
        {

        }

        /// <summary>
        /// Common Function for all test cases, enter text scale Configuration in the text field
        /// </summary>
        [When(@"User enters Scale Configuration in the Search Box")]
        public void WhenUserEntersScaleConfigurationInTheSearchBox()
        {
            scaleConfigurationPage.ScaleConfiguration();
        }

        /// <summary>
        /// Common Function for all test cases, Scale Configuration should be displayed on the Menu and click on Scale Configuration
        /// </summary>
        [Then(@"Scale Configuration Item should be displayed on the Menu")]
        public void ThenScaleConfigurationItemShouldBeDisplayedOnTheMenu()
        {
            scaleConfigurationPage.MenuScaleConfigurationClick();
        }

        [When(@"User Selects the Scale Configuration")]
        public void WhenUserSelectsTheScaleConfiguration()
        {

        }

        [Then(@"Scale Configuration Page should be displayed")]
        public void ThenScaleConfigurationPageShouldBeDisplayed()
        {

        }

        [When(@"User click s on the Add New from Font Section")]
        public void WhenUserClickSOnTheAddNewFromFontSection()
        {

        }

        [Then(@"Create New Font Pop up should appear")]
        public void ThenCreateNewFontPopUpShouldAppear()
        {

        }

        [When(@"User enters the '(.*)', '(.*)'")]
        public void WhenUserEntersThe(string p0, string p1)
        {

        }

        [Then(@"the save button should be enabled")]
        public void ThenTheSaveButtonShouldBeEnabled()
        {

        }

        [When(@"User clicks on button Save")]
        public void WhenUserClicksOnButtonSave()
        {

        }

        [Then(@"Font should get saved and a '(.*)' should be displayed for the same")]
        public void ThenFontShouldGetSavedAndAShouldBeDisplayedForTheSame(string p0)
        {

        }

        [When(@"user Looks Font table")]
        public void WhenUserLooksFontTable()
        {

        }

        [Then(@"the recently created Font should be displayed")]
        public void ThenTheRecentlyCreatedFontShouldBeDisplayed()
        {

        }


        // Step Definitions for Edit Print Format
        [When(@"User clicks on Tab Print Format")]
        public void WhenUserClicksOnTabPrintFormat()
        {
            scaleConfigurationPage.TabPrintFormatClick();
        }

        [Then(@"Print Format Page should be displayed")]
        public void ThenPrintFormatPageShouldBeDisplayed()
        {

        }

        [When(@"user clicks on the Print Format Code")]
        public void WhenUserClicksOnThePrintFormatCode()
        {

        }

        [Then(@"the Selected Print Format Code should be displayed in tab")]
        public void ThenTheSelectedPrintFormatCodeShouldBeDisplayedInTab()
        {

        }

        /// <summary>
        /// Common Function for Scale Configuration tests, Click on button New for Create Print Format
        /// </summary>
        [Then(@"Click on the New Button")]
        public void ClickonNewButton()
        {
            scaleConfigurationPage.ClickNewButton();
        }

        /// <summary>
        /// Common Function for Scale Configuration tests, For enering PF COde and Name
        /// </summary>
        [When(@"Enter the CodeName and PrintFormat")]
        public void EnterCodeNameandPrintFormat()
        {
            string printCode = homePage.getConfiguration("TestData.json", "PrintCode2.0");
            string printFormat = homePage.getConfiguration("TestData.json", "PrintFormat2.0");
            scaleConfigurationPage.EnterCodeandName(printCode, printFormat);
            Thread.Sleep(5000);
        }

        /// <summary>
        /// Common Function for Scale Configuration tests, enter Value for searching PF
        /// </summary>
        [When(@"Enter the Value of Print Name")]
        public void EnterValueofsearchcode()
        {

            string printFormat = homePage.getConfiguration("TestData.json", "PrintFormat2.0");
            scaleConfigurationPage.SeachPFname(printFormat);
            Thread.Sleep(5000);
        }

        /// <summary>
        /// Common Function for Scale Configuration tests, enter Value for searching PF
        /// </summary>
        [When(@"Searches for PrintFormat")]
        public void WhenSearchesForPrintFormat()
        {
            string printFormat = homePage.getConfiguration("TestData.json", "PrintFormat2.3");
            scaleConfigurationPage.SeachPFname(printFormat);
            Thread.Sleep(5000);
        }

        /// <summary>
        /// Common Function for Scale Configuration tests, click on Edit button against the searched Print Format
        /// </summary>

        [Then(@"Click on Edit Button")]
        public void ClickonEditButton()
        {

            scaleConfigurationPage.EditCode();
            Thread.Sleep(5000);
        }

        /// <summary>
        /// In Edit PF, selecting check boxes CheckProductlife, CheckTare, CheckPresetmessages, CheckPrintdateformat, CheckContent
        /// </summary>
        [When(@"Check the required text boxes")]
        public void CheckRequiredTextBoxes()
        {
            scaleConfigurationPage.Checkboxes();
        }

        /// <summary>
        /// Assert Content Symbol
        /// </summary>
        [Then(@"Check the Content Symbol")]
        public void CheckContentSymbol()
        {
            scaleConfigurationPage.VerifyContentSymbol();
        }

        /// <summary>
        /// Click on button Add Section, in Font Section- Common Function in Edit PF-FOnt Section
        /// </summary>
        [When(@"Click on Add Section")]
        public void ClickonAddSections()
        {
            scaleConfigurationPage.ClickonAddSection();
        }

        /// <summary>
        /// Font Dropdown in Edit PF. Common Function
        /// </summary>
        [Then(@"Click on Font Dropdown")]
        public void ClickOnFontDropDowns()
        {
            string selectfont = homePage.getConfiguration("TestData.json", "Fontname2.0");
            scaleConfigurationPage.ClickonFontDropdown(selectfont);
            Thread.Sleep(5000);
        }

        /// <summary>
        /// Adding Description to the Font. Common Functions used in Edit Print Format Tests
        /// </summary>
        [Then(@"Add Desc to font")]
        public void AddDescription()
        {
            string Adddesc = homePage.getConfiguration("TestData.json", "NonNutritionalDesc");
            scaleConfigurationPage.AddDiscription(Adddesc);
            Thread.Sleep(5000);
        }

        /// <summary>
        /// Click on Save button. Common Function used in Edit PF Testcases
        /// </summary>
        [Then(@"Save the font with data")]
        public void SaveFont()
        {
            scaleConfigurationPage.SavetheFontwithData();
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Click on button Close. Common Function in Edit FOnt Page
        /// </summary>
        [Then(@"Close the font")]
        public void CloseFont()
        {
            scaleConfigurationPage.ClosePF();
            Thread.Sleep(4000);
        }

        /// <summary>
        /// Click on Cloud Icon, Publish PF. In Print Format Page
        /// </summary>

        [Then(@"Publish the PF")]
        public void PublishthePF()
        {
             scaleConfigurationPage.PublishPrint();
            Thread.Sleep(5000);
        }

        /// <summary>
        /// Selecting a store from the Stores Tab
        /// </summary>

        [Then(@"Select the Store")]
        public void SelectStore()
        {
            scaleConfigurationPage.SelectStoreLatest();
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Click on Delete button against every PF. Common Function used in Delete PF Tests
        /// </summary>
        [Then(@"Delete the PF")]
        public void DeletePF()
        {
            //scaleConfigurationPage.DeletePrint();
            Thread.Sleep(5000);
        }

        /// <summary>
        /// Entering New Code Name and PF Code. Common Function used to edit the PF
        /// </summary>
        [When(@"Enter the CodeName and PrintFormat new")]
        public void EnterCodeNameandPrintFormat1()
        {
            string printCode1 = homePage.getConfiguration("TestData.json", "PrintCode3.0");
            string printFormat1 = homePage.getConfiguration("TestData.json", "PrintFormat3.0");
            scaleConfigurationPage.EnterCodeandName(printCode1, printFormat1);
            Thread.Sleep(5000);
        }

        /// <summary>
        /// Edit PF Name and COde used in Edit PF Tests
        /// </summary>
        [When(@"Enter the Value of Print Name OpenSanBiscuit1")]
        public void EnterValueoOfpenSanBiscuit1()
        {
            string printFormat = homePage.getConfiguration("TestData.json", "PrintFormat3.0");
            scaleConfigurationPage.SeachPFname(printFormat);
            Thread.Sleep(5000);
        }

        /// <summary>
        /// Edit PF 
        /// </summary>
        [Then(@"Click on Edit Button new PF")]
        public void ClickonEditButtonNEWPF()
        {

            scaleConfigurationPage.EditCode2();
            Thread.Sleep(5000);
        }

        /// <summary>
        /// click on checkboxes Mandatory and Fixed Width in Font Section
        /// </summary>
        [Then(@"check the Manadatory & Fixed Width check box")]
        public void ThenCheckTheManadatoryFixedWidthCheckBox()
        {
            scaleConfigurationPage.ManadatoryFixedWidthCheckBoxCheckboxes();
        }

        /// <summary>
        /// Entering Row and Character Values
        /// </summary>
        [Then(@"configure the row & Characters values")]
        public void ThenConfigureTheRowCharactersValues()
        {
            scaleConfigurationPage.ConfigureTheRowCharactersValues();
        }

        /// <summary>
        /// click on checkboxes Mandatory and Fixed Width in Font Section for Second Font
        /// </summary>
        [Then(@"check the Manadatory & Fixed Width check box font2")]
        public void ThenCheckTheManadatoryFixedWidthCheckBoxFont2()
        {
            scaleConfigurationPage.ManadatoryFixedWidthCheckBoxCheckboxes2();
        }

        /// <summary>
        /// Entering Description to Second Font. Common Function in Edit PF Test Cases
        /// </summary>
        [Then(@"Add Desc to font2")]
        public void AddDescription2()
        {
            string Adddesc1 = homePage.getConfiguration("TestData.json", "NutritionalDesc");
            scaleConfigurationPage.AddDiscription2(Adddesc1);
            Thread.Sleep(5000);
        }

        /// <summary>
        /// entering values for Row and Character values for Font2
        /// </summary>
        [Then(@"configure the row & Characters values Font2")]
        public void ThenConfigureTheRowCharactersValuesFont()
        {
            scaleConfigurationPage.ConfigureTheRowCharactersValuesFont();
        }

        /// <summary>
        /// To check Nutritional panel can be added to another section
        /// </summary>
        [Then(@"check a new nutritional Panel can be added to another section")]
        public void ThenCheckANewNutritionalPanelCanBeAddedToAnotherSection()
        {
            scaleConfigurationPage.ClickonAddSection();
            string selectfont = homePage.getConfiguration("TestData.json", "Fontname2.1");
            scaleConfigurationPage.ClickonFontDropdown2(selectfont);
            Thread.Sleep(5000);
            string Adddesc = homePage.getConfiguration("TestData.json", "NutritionalDesc");
            scaleConfigurationPage.AddDiscription2(Adddesc);
            Thread.Sleep(5000);
            scaleConfigurationPage.FetchValueForNutritionalSection();
        }

        /// <summary>
        /// Entering values in TR and HR
        /// </summary>
        [Then(@"Click Support Basic Mode Header and Table")]
        public void ClickSupportBasicModeHeaderandTable()
        {
            string HR = homePage.getConfiguration("TestData.json", "HRows");


            string TR = homePage.getConfiguration("TestData.json", "TRows");
            scaleConfigurationPage.ClickSupportBasicMode(HR, TR);
            //  scaleConfigurationPage.ClickSupportBasicMode(string HRows);
            Thread.Sleep(3000);
        }


        //Step Definition for Publish a PF, Exist with same name as in store.

        [When(@"user enter new PF code and name and Publish PF")]
        public void WhenUserEnterNewPFCodeAndNameAndPublishPF()
        {
            string pfCode = homePage.getConfiguration("TestData.json", "PrintCode2.0.2");
            string pfName = homePage.getConfiguration("TestData.json", "ChangedPFName");
            scaleConfigurationPage.EnterCodeandName(pfCode, pfName);
            Thread.Sleep(8000);
            scaleConfigurationPage.SearchPF(pfCode);
            Thread.Sleep(3000);
            scaleConfigurationPage.EditCode3();
            Thread.Sleep(8000);
            scaleConfigurationPage.UpdatePF();
            scaleConfigurationPage.ClickonAddSection();
            ClickOnFontDropDowns();
            AddDescription();
            SaveFont();
            CloseFont();
            Thread.Sleep(5000);
            PublishthePF();
            Thread.Sleep(3000);
            SelectStore();
        }

        /// <summary>
        /// Function to Search and Select the Print Format for Edit 
        /// </summary>

        [When(@"user search and select the printformat code")]
        public void WhenUserSearchAndSelectThePrintformatCode()
        {
            Thread.Sleep(3000);
            scaleConfigurationPage.EditCode3();
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Function for updating the PF Code. Common Function in Edit PF Test cases
        /// </summary>
        [Then(@"user change the PF code and update the checkboxes")]
        public void ThenUserChangeThePFCodeAndUpdateTheCheckboxes()
        {
            string NewPFCode = homePage.getConfiguration("TestData.json", "ChangedPFCOde");
            scaleConfigurationPage.ChangePFCode(NewPFCode);
        }

        /// <summary>
        /// Function to verify the Content Symbol is checked on Checking the Content
        /// </summary>
        [Then(@"verify Content Symbol is automatically checked on checking Content")]
        public void ThenVerifyContentSymbolIsAutomaticallyCheckedOnCheckingContent()
        {
            scaleConfigurationPage.VerifyContentSymbol();
        }

        /// <summary>
        /// Function to select a Non Nutrional Font from the Dropdown and change to Nutritional Section. By Adding Description and Save
        /// </summary>
        [Then(@"verify user can Change non nutritional section to the nutritional by adding a nutritional font and description")]
        public void ThenVerifyUserCanChangeNonNutritionalSectionToTheNutritionalByAddingANutritionalFontAndDescription()
        {
            string selectfont = homePage.getConfiguration("TestData.json", "Fontname2.0.2");
            scaleConfigurationPage.ClickonFontDropdown(selectfont);
            Thread.Sleep(5000);
            string Adddesc = homePage.getConfiguration("TestData.json", "NutritionalDesc");
            scaleConfigurationPage.AddDiscription(Adddesc);
            Thread.Sleep(5000);
            string NutriTemplate = homePage.getConfiguration("TestData.json", "NutritionalName2.0.2");
            scaleConfigurationPage.FetchValueForNutritionalSection1(NutriTemplate);
        }

        /// <summary>
        /// Function to select a Nutritional Font and change it to Non Nutritional Font, by adding description and save 
        /// </summary>
        [Then(@"Change Nutritional to Non Nutritional")]
        public void ChangeNutritionaltononnutritional()
        {

            string selectfont = homePage.getConfiguration("TestData.json", "Fontname2.0");
            scaleConfigurationPage.ClickonFontDropdown2(selectfont);
            Thread.Sleep(5000);
            string Adddesc = homePage.getConfiguration("TestData.json", "NutritionalDesc");
            scaleConfigurationPage.AddDiscription2(Adddesc);
            Thread.Sleep(5000);

        }

        /// <summary>
        /// Function to clear the Text field Print Format
        /// </summary>
        [When(@"Clear the PrintformatName")]
        public void ClearThePrintFormatName()
        {


            scaleConfigurationPage.ClearSearchBox();
            System.Threading.Thread.Sleep(5000);
        }

        /// <summary>
        /// Function to Add Nutritional Panel to Another section. COmmon Function in eDIT pf Test Cases
        /// </summary>

        [Then(@"Add another new nutritional Panel to another section")]
        public void ThenAddAnotherNewNutritionalPanelToAnotherSection()
        {
            ClickonAddSections();
            string selectfont = homePage.getConfiguration("TestData.json", "SecondFontname2.0.2");
            scaleConfigurationPage.ClickonFontDropdown2(selectfont);
            //  Thread.Sleep(5000);
            string Adddesc = homePage.getConfiguration("TestData.json", "NutritionalDesc");
            scaleConfigurationPage.AddDiscription2(Adddesc);
            // Thread.Sleep(5000);
            string NutriTemplate = homePage.getConfiguration("TestData.json", "SecondNutritionalName2.0.2");
            scaleConfigurationPage.FetchValueForNutritionalSection(NutriTemplate);
        }

        /// <summary>
        /// Function to Add Another(second) Nutritional Panel
        /// </summary>
        [Then(@"Add another new nutritional Panel to another section latest")]
        public void ThenAddAnotherNewNutritionalPanelToAnotherSectionLatest()
        {
            ClickonAddSections();
            string selectfont = homePage.getConfiguration("TestData.json", "SecondFontname2.0.2");
            scaleConfigurationPage.ClickonFontDropdown2(selectfont);
            //  Thread.Sleep(5000);
            string Adddesc = homePage.getConfiguration("TestData.json", "NutritionalDesc");
            scaleConfigurationPage.AddDiscription2(Adddesc);
            // Thread.Sleep(5000);
            string NutriTemplate = homePage.getConfiguration("TestData.json", "SecondNutritionalName2.0.2");
            scaleConfigurationPage.FetchValueForNutritionalSection1(NutriTemplate);
        }

        /// <summary>
        /// Click on Button Save and Click on button Save. Common Function for Edit PF test cases
        /// </summary>
        [Then(@"Save and close the PF")]
        public void ThenSaveAndCloseThePF()
        {
            Thread.Sleep(3000);
            scaleConfigurationPage.SavetheFontwithData();
            Thread.Sleep(5000);
            scaleConfigurationPage.ClosePF();
        }

        /// <summary>
        /// column Chooser- Search and select Scale Value
        /// </summary>
        [Then(@"select a scale item")]
        public void ThenSelectAScaleItem()
        {
            newItemCreation.SearchForKeyword();
            Thread.Sleep(8000);
            columnChooser.ChooseAColumn();
            columnChooser.SelectScaleValue();
            Thread.Sleep(5000);
            columnChooser.SelectFirstScaleRecord();
            Thread.Sleep(10000);
            columnChooser.ClickScaleTabInItems();
        }

        /// <summary>
        /// Select a PF from the dropdown for Item and Add Content Symbol from ContentSymbolDropdown. Common Function in Item Creation Test Case
        /// </summary>
        [Then(@"add the PF and ContentSymbol")]
        public void ThenAddThePFAndContentSymbol()
        {
            columnChooser.SelectPFForItem();
            string ContentSymbol = homePage.getConfiguration("TestData.json", "ContSymbol");
            columnChooser.AddContentSymbol(ContentSymbol);
            // columnChooser.AddContentSymbol("KG");

            string a = homePage.getConfiguration("TestData.json", "a");
            string b = homePage.getConfiguration("TestData.json", "b");
            columnChooser.NutritionalData(a, b);
        }

        /// <summary>
        /// Save the Item. Common Function in Item Creation Test Case
        /// </summary>
        [Then(@"Save item")]
        public void ThenSaveItem() => columnChooser.SaveItemPF();

        /// <summary>
        /// Click on configuration Tab. Eidt the Content Symbol assigned to Item. Common Function for Create Item Test case
        /// </summary>
        [Then(@"navigate to the configuration page to edit the content symbol assigned to item")]
        public void ThenNavigateToTheConfigurationPageToEditTheContentSymbolAssignedToItem()
        {
            Thread.Sleep(4000);
            configurationPage.PageNavigationToScaleConfigPage();
            configurationPage.PageNavigationToConfigPage();
            string SearchContentSymbol = homePage.getConfiguration("TestData.json", "SrchContentSymbol");
            configurationPage.SearchContentSymbol(SearchContentSymbol);

            string ContentSymbol = homePage.getConfiguration("TestData.json", "NewContentSymbol2.0.2");
            configurationPage.EditContent(ContentSymbol);
        }

        /// <summary>
        /// Verify Change is Reflected in Item Scale Tab. Common Function in Item Creation Test Cases
        /// </summary>
        [Then(@"Verify that the change is reflected in Item's scale tab")]
        public void ThenVerifyThatTheChangeIsReflectedInItemSScaleTab()
        {
            columnChooser.NavigateToItemDetailPage();
            _driverHelper.driver.Navigate().Refresh();
            Thread.Sleep(8000);
            columnChooser.ClickScaleTabInItems();
            columnChooser.AssertContentsymbol();
        }

        /// <summary>
        /// Delete the Scond Panel added from the configuration page
        /// </summary>
        [Then(@"Delete the second panel added from the configuration page")]
        public void ThenDeleteTheSecondPanelAddedFromTheConfigurationPage()
        {
            Thread.Sleep(5000);
            configurationPage.PageNavigationToScaleConfigPage();
            configurationPage.PageNavigationToConfigPage();
            Thread.Sleep(3000);
            configurationPage.NutriPanelSearch("Coco cola");
            configurationPage.PageNavigationToScaleConfigPage();
            configurationPage.PageNavigationToConfigPage();
            Thread.Sleep(3000);
            configurationPage.DeleteNutrionalPanel();
        }

        /// <summary>
        /// Publish the PF to a second store where PF with same name is available
        /// </summary>
        [Then(@"Publish the PF to a second store where PF exists with same name")]
        public void ThenPublishThePFToASecondStoreWherePFExistsWithSameName()
        {
            Thread.Sleep(3000);
            configurationPage.PageNavigationToScaleConfigPage();
            scaleConfigurationPage.TabPrintFormatClick();
            Thread.Sleep(5000);
            scaleConfigurationPage.SearchPF("21");
            Thread.Sleep(3000);
            PublishthePF();
            Thread.Sleep(3000);
            SelectStore();
        }

        /*/// <summary>
        /// Verifying the Tares, Content Symbols and Preset messages in SR is as that in HQ 
        /// </summary>
        [Then(@"navigate to verify Tare '(.*)' and '(.*)'")]
        public void ThenNavigateToVerifyTareAnd(string searchcode, string verifytext)
        {
            Thread.Sleep(3000);
            scaleConfigurationPage.srTare();
            sRConfigurationPage.CompareTare(searchcode, verifytext);
            Thread.Sleep(3000);
            _driverHelper.driver.SwitchTo().Window(_driverHelper.driver.WindowHandles[0]);
        }

        [Then(@"navigate to verify Content Symbol '(.*)' , '(.*)'and '(.*)'")]
        public void ThenNavigateToVerifyContentSymbolAnd(string searchcode, string verifytext,string contentsymbolvalues)
        {
            Thread.Sleep(3000);
            scaleConfigurationPage.srContentSymbol();
            sRConfigurationPage.CompareContentSymbol(searchcode, verifytext, contentsymbolvalues);
            Thread.Sleep(3000);
        //    _driverHelper.driver.SwitchTo().Window(_driverHelper.driver.WindowHandles[0]);
        }

        /// <summary>
        /// Verifying the Tare
        /// </summary>
        [Then(@"navigate to Tare '(.*)' ,'(.*)' and '(.*)'")]
        public void NavigardVerifyTare(string searchcode, string verifytext, string tarevaluesg)
        {

            Thread.Sleep(3000);
            scaleConfigurationPage.srTare();
            sRConfigurationPage.CompareTare(searchcode, verifytext, tarevaluesg);
            Thread.Sleep(3000);

            // _driverHelper.driver.SwitchTo().Window(_driverHelper.driver.WindowHandles[0]);
        }

        [Then(@"navigate to verify Preset Messages '(.*)' and '(.*)'")]
        public void ThenNavigateToVerifyPresetMessagesAnd(string searchcode, string verifytext)
        {
            Thread.Sleep(3000);
            scaleConfigurationPage.srPresetMessage();
            sRConfigurationPage.ComparePresetMsg(searchcode, verifytext);
            Thread.Sleep(7000);
            _driverHelper.driver.SwitchTo().Window(_driverHelper.driver.WindowHandles[0]);
        }*/

        /// <summary>
        /// Verifying the Tares, Content Symbols and Preset messages in SR is as that in HQ 
        /// </summary>
        [Then(@"navigate to verify Tare '(.*)' and '(.*)'")]
        public void ThenNavigateToVerifyTareAnd(string searchcodeTare, string verifytextTare)
        {
            Thread.Sleep(3000);
            scaleConfigurationPage.srTare();
            sRConfigurationPage.CompareTare(searchcodeTare, verifytextTare);
            Thread.Sleep(3000);
        }

        [Then(@"navigate to verify Content Symbol '(.*)' and '(.*)'")]
        public void ThenNavigateToVerifyContentSymbolAnd(string searchcodeCS, string verifytextCS)
        {
            Thread.Sleep(3000);
            scaleConfigurationPage.srContentSymbol();
            sRConfigurationPage.CompareContentSymbol(searchcodeCS, verifytextCS);
            Thread.Sleep(3000);
        }


        [Then(@"navigate to verify Preset Messages '(.*)' and '(.*)'")]
        public void ThenNavigateToVerifyPresetMessagesAnd(string searchcodePM, string verifytextPM)
        {
            Thread.Sleep(3000);
            scaleConfigurationPage.srPresetMessage();
            sRConfigurationPage.ComparePresetMsg(searchcodePM, verifytextPM);
            Thread.Sleep(3000);
        }


        /// <summary>
        /// Verifying the Print Format on SR
        /// </summary>
        [Then(@"navigate to verify Print Format '(.*)' and '(.*)'")]
        public void NavigareandverifyPF(string searchcode, string verifytext)
        {

            Thread.Sleep(3000);
            scaleConfigurationPage.srPrintFormat1();
            sRConfigurationPage.ComparePrintFormat(searchcode, verifytext);
            Thread.Sleep(3000);
            _driverHelper.driver.SwitchTo().Window(_driverHelper.driver.WindowHandles[0]);
            Thread.Sleep(2000);
        }

        /// <summary>
        /// Click on Configuration page to change the content symbol
        /// </summary>
        [Then(@"navigate back to configuration page to change the contentSymbol back")]
        public void ThenNavigateBackToConfigurationPageToChangeTheContentSymbolBack()
        {
            Thread.Sleep(3000);
            configurationPage.PageNavigationToConfigPage();
            configurationPage.SearchContentSymbol("18");
            string ContentSymbol = homePage.getConfiguration("TestData.json", "ContentSymbol2.0.2");
            Thread.Sleep(5000);
            configurationPage.EditContent(ContentSymbol);
        }

        /// <summary>
        /// Click on Tab Print Format Tab. Common Function for PF related tests
        /// </summary>
        [Then(@"Navigate to PF tab")]
        public void ThenNavigateToPFTab()
        {
            Thread.Sleep(3000);
            scaleConfigurationPage.TabPrintFormatClick();
        }


        //Step Definitions TC2
        /// <summary>
        /// In create PF enter Code and PrintFormat. Common Function in create PF Tests
        /// </summary>

        [When(@"User Enters the Code and PrintFormat")]
        public void WhenUserEntersTheCodeAndPrintFormat()
        {
            string printCode = homePage.getConfiguration("TestData.json", "PrintCode2.2");
            string printFormat = homePage.getConfiguration("TestData.json", "PrintFormat2.2");
            scaleConfigurationPage.EnterCodeandName(printCode, printFormat);
            System.Threading.Thread.Sleep(5000);


        }

        /// <summary>
        /// Search for PF and Select a PF. Common Function in Edit PF Tests
        /// </summary>
        [When(@"Enter the Value of Print Name Nicebiscits")]
        public void EnterValueofPrintNameNiceBiscuits()
        {

            string printFormat = homePage.getConfiguration("TestData.json", "PrintFormat2.2");
            scaleConfigurationPage.SeachPFname(printFormat);
            System.Threading.Thread.Sleep(5000);
        }

        /// <summary>
        /// Click on button Eidt against a selected PF. Common Function for Edit testcases
        /// </summary>
        [When(@"Click on Edit Button")]
        public void WhenClickOnEditButton()
        {
            scaleConfigurationPage.EditRow();
            System.Threading.Thread.Sleep(5000);

        }

        /// <summary>
        /// Change the PF Name by entering new PF Name, Take any nutritional Font uncheck and Check the Product Life. Common Function in Eidt PF Test cases
        /// </summary>
        /// <param name="p0"></param>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        [When(@"Change the PF name to Popcorn, also uncheck '(.*)' only\.Take any nutritional font and uncheck '(.*)' and check '(.*)'\.")]
        public void WhenChangeThePFNameToPopcornAlsoUncheckOnly_TakeAnyNutritionalFontAndUncheckAndCheck_(string p0, string p1, string p2)
        {

            System.Threading.Thread.Sleep(15000);
            scaleConfigurationPage.PFClear();
            string printFormat = homePage.getConfiguration("TestData.json", "PrintFormat2.3");

            scaleConfigurationPage.EditPrintFormatName(printFormat);

            System.Threading.Thread.Sleep(2000);

            // Uncheck the Product Life
            scaleConfigurationPage.CheckProductLife();
        }

        /// <summary>
        /// Click on Delete button against the Font in PF
        /// </summary>
        [When(@"User Deletes the font added to PF")]
        public void WhenUserDeletesTheFontAddedToPF()
        {
            scaleConfigurationPage.DeleteFont();
        }

        [Then(@"Verifies the Toast is displayed")]
        public void ThenVerifiesTheToastIsDisplayed()
        {

        }

        [Then(@"a message'(.*)' should be displayed")]
        public void ThenAMessageShouldBeDisplayed(string p0)
        {

        }

        [When(@"User Pubilsh the PF to a Second Store where PF exists with the same Code")]
        public void WhenUserPubilshThePFToASecondStoreWherePFExistsWithTheSameCode()
        {

        }

        [When(@"Verify that at store, all the Tares, Content Symbols and Preset messages of HQ are published and the PF at store with same code is updated with values from HQ in Configuration\.")]
        public void WhenVerifyThatAtStoreAllTheTaresContentSymbolsAndPresetMessagesOfHQArePublishedAndThePFAtStoreWithSameCodeIsUpdatedWithValuesFromHQInConfiguration_()
        {

        }

        /// <summary>
        /// Click Edit against New PF
        /// </summary>
        [When(@"Click on Edit")]
        public void WhenClickOnEdit()
        {
            scaleConfigurationPage.EditPopCorn1();
        }

        /// <summary>
        /// Click on button Save
        /// </summary>
        [When(@"click on buttonSave")]
        public void WhenClickOnButtonSave()
        {
            scaleConfigurationPage.ButtonSaveClick();
        }

        /// <summary>
        /// Search Font
        /// </summary>
        [When(@"i search the Font by name")]
        public void WhenISearchFontByName()
        {
            string NutritionalPanelName = homePage.getConfiguration("TestData.json", "Fontname2.1");
            scaleConfigurationPage.FontName(NutritionalPanelName);
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Verify FOnt message. Common in Create PF Test
        /// </summary>
        [When(@"User Verify the font message")]
        public void UserVerifythefontmessage()
        {
            scaleConfigurationPage.Verifymessage();
        }








    }
}
