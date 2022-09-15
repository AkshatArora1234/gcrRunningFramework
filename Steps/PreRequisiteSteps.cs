using SpecFlow_MSTestFrameWork.PageObjects;
using TechTalk.SpecFlow;
using System.Threading;

namespace SpecFlow_MSTestFrameWork.Steps
{

    [Binding]
    public class PreRequisite
    {
        private readonly DriverHelper _driverHelper;
        Scaleconfig scaleConfigurationPage;
        HomePage homePage;
        ConfigurationPage configurationPage;

        public PreRequisite(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            scaleConfigurationPage = new Scaleconfig(_driverHelper.driver);
            homePage = new HomePage(_driverHelper.driver);
            configurationPage = new ConfigurationPage(_driverHelper.driver);
        }

        /// <summary>
        /// Click on Tab Config
        /// </summary>
        [When(@"User clicks on Tab Config page")]
        public void WhenUserClicksOnTabConfigration()
        {
            scaleConfigurationPage.TabConfiGrationClick();
        }

        /// <summary>
        /// Click Font New Button
        /// </summary>
        [When(@"User clicks on Font New Button")]
        public void UserClickonFontNewButton()
        {
            Thread.Sleep(5000);
            scaleConfigurationPage.ClickFontNewButton();
        }

        /// <summary>
        /// Click on button Tare New
        /// </summary>
        [When(@"User clicks on Tare New Button")]
        public void WhenUserClicksOnTareNewButton()
        {
            scaleConfigurationPage.ClickTareNewButton();
        }

        /// <summary>
        /// Click on Preset New
        /// </summary>
        [When(@"User clicks on Preset New Button")]
        public void WhenUserClicksOnPresetNewButton()
        {
           scaleConfigurationPage.ClickPresetNewButton();
        }

        /// <summary>
        /// Click on button Content Symbol
        /// </summary>
        [When(@"User clicks on ContentSymbol Button")]
        public void WhenUserClicksOnContentSymbolButton()
        {
            scaleConfigurationPage.ClickContentSymbolNewButton();
        }

        /// <summary>
        /// Enter Code Content Symbol and Description
        /// </summary>
        [When(@"Enter Code ContentSymbol & Description")]
        public void WhenEnterCodeContentSymbolDescription()
        {
            string ContentCode = homePage.getConfiguration("TestData.json", "ContentSymbolCode2.0");
            string ContentSymbol = homePage.getConfiguration("TestData.json", "ContentSymbol2.0");
            string ContentDescription = homePage.getConfiguration("TestData.json", "ContentSymbolDescription2.0");
            scaleConfigurationPage.EnterContentCodeNameDescription(ContentCode, ContentSymbol, ContentDescription);
            Thread.Sleep(5000);

        }

        /// <summary>
        /// Click on button Edit in Nutritional Panel Two Zero One
        /// </summary>

        [When(@"Enter Code ContentSymbol & Description TwoZeroOne")]
        public void WhenEnterCodeContentSymbolDescriptionTwoZeroOne()
        {
            string ContentCode = homePage.getConfiguration("TestData.json", "ContentSymbolCode2.0.1");
            string ContentSymbol = homePage.getConfiguration("TestData.json", "ContentSymbol2.0.1");
            string ContentDescription = homePage.getConfiguration("TestData.json", "ContentSymbolDescription2.0.1");
            scaleConfigurationPage.EnterContentCodeNameDescription(ContentCode, ContentSymbol, ContentDescription);
            Thread.Sleep(5000);
        }



        /// <summary>
        /// Click on button New in Nutritional Panel. 
        /// </summary>
        [When(@"User clicks on Nutritional Panel New Button")]
        public void UserClickonNutritionalPanelNewButton()
        {
            Thread.Sleep(5000);
            scaleConfigurationPage.ClickNutritionalNewButton();
        }

        /// <summary>
        /// Enter Code Name and Nutritional Panel
        /// </summary>
        [When(@"Enter CodeName and Nutritional Panel")]
        public void WhenEnterCodeNameAndNutritionalPanel()
        {
            string printCode1 = homePage.getConfiguration("TestData.json", "NutritionalCode2.0");
            string printFormat1 = homePage.getConfiguration("TestData.json", "NutritionalName2.0");
            scaleConfigurationPage.EnterNutritionalCodeandName(printCode1, printFormat1);
            Thread.Sleep(5000);
        }

        /// <summary>
        /// Enter Code Name and Nutritional Panel
        /// </summary>

        [When(@"Enter CodeName and Nutritional Panel TwoZeroOne")]
        public void WhenEnterCodeNameAndNutritionalPanelTwoZeroOne()
        {
            string printCode1 = homePage.getConfiguration("TestData.json", "NutritionalCode2.0.1");
            string printFormat1 = homePage.getConfiguration("TestData.json", "NutritionalName2.0.1");
            scaleConfigurationPage.EnterNutritionalCodeandName(printCode1, printFormat1);
            Thread.Sleep(5000);
        }

        /// <summary>
        /// Search for Nutritional Panel By Name
        /// </summary>
        [When(@"i search the Nutrional Panel by Name")]
        public void WhenISearchTheNutrionalPanelByName()
        {
            string NutritionalPanelName = homePage.getConfiguration("TestData.json", "NutritionalPanelName2.0");
            scaleConfigurationPage.NutrionalPanelNam2(NutritionalPanelName);
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Search for Nutritional Panel by Name Two Zero One
        /// </summary>
        [When(@"i search the Nutrional Panel by Name TwoZeroOne")]
        public void WhenISearchTheNutrionalPanelByNameTwoZeroOne()
        {
            string NutritionalPanelName = homePage.getConfiguration("TestData.json", "NutritionalPanelName2.0.1");
            scaleConfigurationPage.NutrionalPanelNam2(NutritionalPanelName);
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Click on button Edit in Nutritional Panel Section
        /// </summary>
        [Then(@"Click on Edit Button NutritionalPanel")]
        public void ThenClickOnEditButtonNutritionalPanel()
        {
            scaleConfigurationPage.EditNutritionalPanel();
            Thread.Sleep(5000);           
        }

        /// <summary>
        /// Click on button Edit in Nutritional Panel Two Zero One
        /// </summary>
        [Then(@"Click on Edit Button NutritionalPanel TwoZeroOne")]
        public void ThenClickOnEditButtonNutritionalPanelTwoZeroOne()
        {

            scaleConfigurationPage.EditNutritionalPanelTwoZeroOne();
            Thread.Sleep(5000);
        }

        /// <summary>
        /// Click on Button New in Nutritional Panel
        /// </summary>
        [Then(@"Click on the New NutritionalPanel Element Button")]
        public void ThenClickOnTheNewNutritionalPanelElementButton()
        {
            Thread.Sleep(3000);
            scaleConfigurationPage.ClickNew();
        }

        /// <summary>
        /// Click on Nutritional Element Dropdown to Select a Font. Prerequisite for all PF related tests
        /// </summary>
        [Then(@"Click on Nutritional Element dropdown")]
        public void ThenClickOnNutritionalElementDropdown()
        {
            string selectfont = homePage.getConfiguration("TestData.json", "NonNutritionalValueDropdwon2.0");
            scaleConfigurationPage.ClickonNutritionalElementtDropdown(selectfont);
            Thread.Sleep(5000);
        }
        /// <summary>
        /// Select Font from Nutritional Element Dropdown in FOnt Section
        /// </summary>
        [Then(@"Click on Nutritional Element dropdown TwoZeroOne")]
        public void ThenClickOnNutritionalElementDropdownTwoZeroOne()
        {
            string selectfont = homePage.getConfiguration("TestData.json", "NonNutritionalValueDropdwon2.0.1");
            scaleConfigurationPage.ClickonNutritionalElementtDropdown(selectfont);
            Thread.Sleep(5000);
        }

        /// <summary>
        /// Select Font from measurement dropdown
        /// </summary>
        [When(@"Enter the value in MeasurementsUnit")]
        public void SelectValueMeasurementsUnit()
        {
            string selectfont = homePage.getConfiguration("TestData.json", "Measureunit2.0");
            scaleConfigurationPage.SelectMeasurementDropdown(selectfont);
            Thread.Sleep(5000);
        }
        /// <summary>
        /// Select unit for measurement from Select measurement dropdown
        /// </summary>
        [When(@"Enter the value in MeasurementsUnit Mg")]
        public void WhenEnterTheValueInMeasurementsUnitMg()
        {
            string selectfont = homePage.getConfiguration("TestData.json", "Measureunit2.0.1");
            scaleConfigurationPage.SelectMeasurementDropdown(selectfont);
            Thread.Sleep(5000);
        }
        /// <summary>
        /// Entering Print Format Code and Font Name. Common function in all Create and Edit Print Format tests
        /// </summary>
        [When(@"Enter CodeName and Font Name")]
        public void WhenEnterCodeNameAndFontName()
        {
            string printCode1 = homePage.getConfiguration("TestData.json", "FontCode2.0");
            string printFormat1 = homePage.getConfiguration("TestData.json", "Fontname2.0");
            scaleConfigurationPage.EnterFontCodeandName(printCode1, printFormat1);
            Thread.Sleep(5000);
        }

        /// <summary>
        /// Enter FOnt Code and Name. Common function for tests with create Font
        /// </summary>
        [When(@"Enter Code and Name with Nutritional Font")]
        public void WhenEnterCodeAndNameWithNutritionalFont()
        {
            string FontCode = homePage.getConfiguration("TestData.json", "FontCode2.1");
            string FontName = homePage.getConfiguration("TestData.json", "Fontname2.1");
            scaleConfigurationPage.EnterFontCodeandName(FontCode, FontName);
            Thread.Sleep(5000);
        }

        /// <summary>
        /// Enter Tarecode and Name and Value. Prerequisite
        /// </summary>

        [When(@"Enter TareCode and Name")]
        public void WhenEnterTareCodeAndName()
        {
            string TareCode = homePage.getConfiguration("TestData.json", "TareCode2.0");
            string TareName = homePage.getConfiguration("TestData.json", "TareName2.0");
            string TareValue = homePage.getConfiguration("TestData.json", "TareValue2.0");
            scaleConfigurationPage.EnterTaretCodeNameValue(TareCode, TareName, TareValue);
            Thread.Sleep(5000);
        }

        /// <summary>
        /// Enter Tare Code, Tare Name and Tare Value
        /// </summary>
        [When(@"Enter TareCode and Name TwoZeroOne")]
        public void WhenEnterTareCodeAndNameTwoZeroOne()
        {
            string TareCode = homePage.getConfiguration("TestData.json", "TareCode2.0.1");
            string TareName = homePage.getConfiguration("TestData.json", "TareName2.0.1");
            string TareValue = homePage.getConfiguration("TestData.json", "TareValue2.0.1");
            scaleConfigurationPage.EnterTaretCodeNameValue(TareCode, TareName, TareValue);
            Thread.Sleep(5000);
        }

        /// <summary>
        /// Enter Preset Coed and Preset message
        /// </summary>
        [When(@"Enter PresetMessageCode Name & List")]
        public void WhenEnterPresetMessageCodeNameList()
        {
            string PresetCode = homePage.getConfiguration("TestData.json", "PresetCode2.0");
            string PresetMessage = homePage.getConfiguration("TestData.json", "PresetMessage2.0");
            scaleConfigurationPage.EnterPresetCodeNameValue(PresetCode, PresetMessage);
            Thread.Sleep(5000);
        }
        /// <summary>
        /// Enter Preset Code and Preset Message. Prerequisite for all the Create and Edit Print Format
        /// </summary>
        [When(@"Enter PresetMessageCode Name & List TwoZeroOne")]
        public void WhenEnterPresetMessageCodeNameListTwoZeroOne()
        {
            string PresetCode = homePage.getConfiguration("TestData.json", "PresetCode2.0.1");
            string PresetMessage = homePage.getConfiguration("TestData.json", "PresetMessage2.0.1");
            scaleConfigurationPage.EnterPresetCodeNameValue(PresetCode, PresetMessage);
            Thread.Sleep(5000);
        }

        /// <summary>
        /// Click on Save button. Common Function in Edit and Create PF Tests
        /// </summary>

        [Then(@"click on save button")]
        public void ThenClickOnSaveButton()
        {
            Thread.Sleep(3000);
            scaleConfigurationPage.ClickonSave();
        }

        /// <summary>
        /// Click on New Save button 
        /// </summary>
        [Then(@"click on new save button")]
        public void ThenClickOnnewSaveButton()
        {
            scaleConfigurationPage.ClickonSaveclass();
        }

        /// <summary>
        /// Click on button Save
        /// </summary>
        [Then(@"Search Nutritional Panel by Name")]
        public void SearchNutritionalPanelbyName()
        {
            scaleConfigurationPage.ClickonSave();
        }

        /// <summary>
        /// Enter Value in Masked field
        /// </summary>
        [Then(@"Enter Value in Mask Field")]
        public void EnterValueinMaskField()
        {
            string valueinmask = homePage.getConfiguration("TestData.json", "MaskFieldValue2.0");
            scaleConfigurationPage.EnterValueinMaskfield(valueinmask);
            Thread.Sleep(5000);

        }

        /// <summary>
        /// Enter updated value in Masked field
        /// </summary>
        [Then(@"Enter Value in Mask Field Updated Value")]
        public void ThenEnterValueInMaskFieldUpdatedValue()
        {
            string valueinmask = homePage.getConfiguration("TestData.json", "MaskFieldValue2.0.1");
            scaleConfigurationPage.EnterValueinMaskfield(valueinmask);
            Thread.Sleep(5000);
        }


        //TestData 2.0.2
        /// <summary>
        /// Click on Scale Configuration Menu. Common function for all scale configuration tests
        /// </summary>

        [Then(@"User click on Scale Configuration Item should be displayed on the Menu")]
        public void ThenUserClickOnScaleConfigurationItemShouldBeDisplayedOnTheMenu()
        {
            scaleConfigurationPage.MenuScaleConfigurationClick();
        }

        /// <summary>
        /// Enter Font COde and Font Name. Prerequisite for Print Format tests
        /// </summary>

        [When(@"Enter the Code and Name for Testdata TwoZeroTwo")]
        public void WhenEnterTheCodeAndNameForTestdataTwoZeroTwo()
        {
            string fontCode = homePage.getConfiguration("TestData.json", "FontCode2.0.2");
            string fontName = homePage.getConfiguration("TestData.json", "Fontname2.0.2");
            scaleConfigurationPage.EnterFontCodeandName(fontCode, fontName);
            Thread.Sleep(5000);
        }

        /// <summary>
        /// Search for Font. Common Function for Print Format tests
        /// </summary>
        [Then(@"search for the font")]
        public void ThenSearchForTheFont()
        {
            string fontCode = homePage.getConfiguration("TestData.json", "FontCode2.0.2");
            configurationPage.FontEditClick();
            Thread.Sleep(3000);
            configurationPage.SearchFont(fontCode);
        }

        /// <summary>
        /// Click on the checkbox Nutritional Font and Click on button Save. common Function in Edit PF Tests 
        /// </summary>
        [Then(@"click the Nutritional Font as yes")]
        public void ThenClickTheNutritionalFontAsYes()
        {
            Thread.Sleep(3000);
            configurationPage.EditNutrionalFont();
        }

        /// <summary>
        /// Search for the Second Font
        /// </summary>

        [Then(@"search for the second font entered")]
        public void ThenSearchForTheSecondFontEntered()
        {
            string fontCode = homePage.getConfiguration("TestData.json", "SecondFontCode2.0.2");
            configurationPage.FontEditClick();
            Thread.Sleep(2000);
            configurationPage.SearchFont(fontCode);
        }


        [When(@"Enter the Code and Name for second font Testdata TwoZeroTwo")]
        public void WhenEnterTheCodeAndNameForSecondFontTestdataTwoZeroTwo()
        {
            string fontCode = homePage.getConfiguration("TestData.json", "SecondFontCode2.0.2");
            string fontName = homePage.getConfiguration("TestData.json", "SecondFontname2.0.2");
            Thread.Sleep(5000);
            scaleConfigurationPage.EnterFontCodeandName(fontCode, fontName);
        }


        [When(@"Enter ContentSymbol & Description for Testdata TwoZeroTwo")]
        public void WhenEnterContentSymbolDescriptionForTestdataTwoZeroTwo()
        {
            string ContentCode = homePage.getConfiguration("TestData.json", "ContentSymbolCode2.0.2");
            string ContentSymbol = homePage.getConfiguration("TestData.json", "ContentSymbol2.0.2");
            string ContentDescription = homePage.getConfiguration("TestData.json", "ContentSymbolDescrition2.0.2");
            scaleConfigurationPage.EnterContentCodeNameDescription(ContentCode, ContentSymbol, ContentDescription);
            Thread.Sleep(5000);
        }

        [When(@"Enter CodeName and Nutritional Panel for Testdata TwoZeroTwo")]
        public void WhenEnterCodeNameAndNutritionalPanelForTestdataTwoZeroTwo()
        {
            string nutriCode = homePage.getConfiguration("TestData.json", "NutritionalCode2.0.2");
            string nutriName = homePage.getConfiguration("TestData.json", "NutritionalName2.0.2");
            scaleConfigurationPage.EnterNutritionalCodeandName(nutriCode, nutriName);
            Thread.Sleep(5000);
        }

        [When(@"Enter CodeName and Nutritional Panel for second Testdata TwoZeroTwo")]
        public void WhenEnterCodeNameAndNutritionalPanelForSecondTestdataTwoZeroTwo()
        {
            string nutriCode = homePage.getConfiguration("TestData.json", "SecondNutritionalCode2.0.2");
            string nutriName = homePage.getConfiguration("TestData.json", "SecondNutritionalName2.0.2");
            scaleConfigurationPage.EnterNutritionalCodeandName(nutriCode, nutriName);
            Thread.Sleep(5000);
        }

        [When(@"I search the Nutrional Panel by Name Testdata TwoZeroTwo")]
        public void WhenISearchTheNutrionalPanelByNameTestdataTwoZeroTwo()
        {
            string NutritionalName = homePage.getConfiguration("TestData.json", "NutritionalName2.0.2");
            scaleConfigurationPage.NutrionalPanelNam2(NutritionalName);
            Thread.Sleep(3000);
        }

        [When(@"I search the second Nutrional Panel by Name Testdata TwoZeroTwo")]
        public void WhenISearchTheSecondNutrionalPanelByNameTestdataTwoZeroTwo()
        {
            Thread.Sleep(3000);
            string NutritionalName = homePage.getConfiguration("TestData.json", "SecondNutritionalName2.0.2");
            scaleConfigurationPage.NutrionalPanelNam2(NutritionalName);
            Thread.Sleep(3000);
        }

        [Then(@"Click on second Nutritional Element dropdown Testdata TwoZeroTwo")]
        public void ThenClickOnSecondNutritionalElementDropdownTestdataTwoZeroTwo()
        {
            string NutritionalName = homePage.getConfiguration("TestData.json", "SecondNonNutritionalValueDropdwon2.0.2");
            scaleConfigurationPage.ClickonNutritionalElementtDropdown(NutritionalName);
            Thread.Sleep(5000);
        }

        [When(@"Enter the value in MeasurementsUnit g")]
        public void WhenEnterTheValueInMeasurementsUnitG()
        {
            string unit = homePage.getConfiguration("TestData.json", "SecondMeasureunit2.0.2");
            scaleConfigurationPage.SelectMeasurementDropdown(unit);
            Thread.Sleep(5000);
        }
        [Then(@"Enter Value in second Mask Field")]
        public void ThenEnterValueInSecondMaskField()
        {
            string valueinmask = homePage.getConfiguration("TestData.json", "SecondMaskFieldValue2.0.2");
            scaleConfigurationPage.EnterValueinMaskfield(valueinmask);
            Thread.Sleep(5000);
        }
        [Then(@"click on save and close button Nutritional Panel Element")]
        public void ThenClickOnSaveAndCloseButtonNutritionalPanelElement()
        {
            scaleConfigurationPage.ClickonSaveclass();
            scaleConfigurationPage.SaveAndCloseNutriPanelElement();
        }

        [When(@"Enter TareCode and Name for TwoZeroTwo")]
        public void WhenEnterTareCodeAndNameForTwoZeroTwo()
        {
            string TareCode = homePage.getConfiguration("TestData.json", "TareCode2.0.2");
            string TareName = homePage.getConfiguration("TestData.json", "TareName2.0.2");
            string TareValue = homePage.getConfiguration("TestData.json", "TareValue2.0.2");

            scaleConfigurationPage.EnterTaretCodeNameValue(TareCode, TareName, TareValue);
            Thread.Sleep(5000);
        }

        [When(@"Enter PresetMessageCode Name & List for TwoZeroTwo")]
        public void WhenEnterPresetMessageCodeNameListForTwoZeroTwo()
        {
            string PresetCode = homePage.getConfiguration("TestData.json", "PresetCode2.0.2");
            string PresetMessage = homePage.getConfiguration("TestData.json", "PresetMessage2.0.2");
            scaleConfigurationPage.EnterPresetCodeNameValue(PresetCode, PresetMessage);
            scaleConfigurationPage.EnterPresetListValue();
            Thread.Sleep(5000);
        }


    }
}
