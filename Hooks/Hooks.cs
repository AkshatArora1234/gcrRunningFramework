using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SpecFlow_MSTestFrameWork.PageObjects;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

//[assembly: Parallelizable(ParallelScope.Fixtures)]

namespace SpecFlow_MSTestFrameWork.Hooks
{
    [Binding]
    
    public class Hooks 
    {
        //Global Variable for Extend report
        private readonly FeatureContext _featureContext;
        private readonly ScenarioContext _scenarioContext;
        private static ExtentTest _currentScenarioName;
        private static DriverHelper _driverHelper;
        public static HQLoginPage hq;
        public static Scaleconfig scale;
        public static Scaleconfig scaleConfigurationPage;


        public Hooks(DriverHelper driverHelper, FeatureContext featureContext, ScenarioContext scenarioContext) : base()
        {
            _driverHelper = driverHelper;
            _featureContext = featureContext;
            _scenarioContext = scenarioContext;
            hq = new HQLoginPage(_driverHelper.driver);
            scaleConfigurationPage = new Scaleconfig(_driverHelper.driver);
        }

        
        private static ExtentTest featureName;
        private static AventStack.ExtentReports.ExtentReports extent;
      

        [AfterStep]
        public void AfterEachStep()
        {
            var stepType = _scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();

            if (_scenarioContext.TestError == null)
            {
                if (stepType == "Given")
                    _currentScenarioName.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "When")
                    _currentScenarioName.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "Then")
                    _currentScenarioName.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "And")
                    _currentScenarioName.CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text);
            }

            else if (_scenarioContext.TestError != null)
            {
                //Capture screenshot in Base64 format
                var screenshotPath = Capture(_scenarioContext.ScenarioInfo.Title.Trim());

                if (stepType == "Given")
                    _currentScenarioName.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message, screenshotPath);
                else if (stepType == "When")
                    _currentScenarioName.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message, screenshotPath);
                else if (stepType == "Then")
                    _currentScenarioName.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message, screenshotPath);
            }

            else if (_scenarioContext.ScenarioExecutionStatus.ToString() == "StepDefinitionPending")
            {
                if (stepType == "Given")
                    _currentScenarioName.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "When")
                    _currentScenarioName.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "Then")
                    _currentScenarioName.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
            }
        }


    [BeforeTestRun]
        public static void InitializeReport()
        {
            //Initialize Extent report before test starts
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;
            var htmlReporter = new ExtentHtmlReporter(projectPath + "Reports\\TestRunReport.html"); //generalized path
           //var htmlReporter = new ExtentHtmlReporter(@"C:\Users\akshat.arora\Desktop\seleniumframework\SpecFlow_MSTestFrameWork\Extentreport.html"); //generalized path
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            //Attach report to reporter
            extent = new AventStack.ExtentReports.ExtentReports();
            extent.AttachReporter(htmlReporter);
        }


        public string browsername;

    [BeforeScenario]
        public void BeforeScenario()
        {
            testinitialize(browsername);

            //create dynamic feature and scenario name for Extent Report
            featureName = extent.CreateTest<Feature>(_featureContext.FeatureInfo.Title);
            _currentScenarioName = featureName.CreateNode<Scenario>(_scenarioContext.ScenarioInfo.Title);
        }
        public void setup(string browsername)
        {
            string browser = "Chrome";
            switch (browser)
            {
                case "Chrome":
                    var chromeOptions = new ChromeOptions();

                    ChromeOptions option = new ChromeOptions();
                    option.AddArguments("start-maximized");
                    option.AddArguments("--disable-gpu");
                    // option.AddArguments("--headless");

                    new DriverManager().SetUpDriver(new ChromeConfig());
                    Console.WriteLine("Setup");
                    _driverHelper.driver = new ChromeDriver(option);
                    break;
                case "Firefox":
                    _driverHelper.driver = new FirefoxDriver();
                    break;
                case "IE":
                    _driverHelper.driver = new InternetExplorerDriver();
                    break;
                default:
                    _driverHelper.driver = new ChromeDriver();
                    break;

            }
        }

    [AfterTestRun]
        public static void TearDownReport()
        {
            //Flush report once test completes
            extent.Flush();
        }

        public void testinitialize(string browsername)
        {
            setup(browsername);    
        }

        IWebElement DeletePF => _driverHelper.driver.FindElement(By.XPath("(//i[@ng-click='ctrl.actions.deletePrintFormat(row.data)'])[1]"));
        IWebElement Deletebutton => _driverHelper.driver.FindElement(By.Id("submitButton"));
        IWebElement ProfileIcon => _driverHelper.driver.FindElement(By.XPath("//button[@class='dropdown-toggle']"));
        IWebElement LogOut => _driverHelper.driver.FindElement(By.XPath("//*[contains(text(),'Logout')]"));
        IWebElement submitbutton => _driverHelper.driver.FindElement(By.Id("submitButton"));

        [AfterStep]
        public void AfterStep()
        {
            if (_scenarioContext.TestError != null)
            {
                try
                {
                    if (_featureContext.FeatureInfo.Title.Equals("PublishPrintFormatWithExistingCode"))
                    {
                        _driverHelper.driver.SwitchTo().Window(_driverHelper.driver.WindowHandles[0]);
                        Actions action = new Actions(_driverHelper.driver);
                        action.Click(DeletePF);
                        action.Perform();
                        Thread.Sleep(3000);
                        Deletebutton.Click();
                    }
                }
                finally
                {
                    //Logout
                    _driverHelper.driver.SwitchTo().Window(_driverHelper.driver.WindowHandles[0]);
                    _driverHelper.driver.Navigate().Refresh();
                    Thread.Sleep(4000);
                    ProfileIcon.Click();
                    Thread.Sleep(2000);
                    LogOut.Click();
                    submitbutton.Click();

                    //Quit Driver
                    _driverHelper.driver.Quit();
                }
            }
        
        }


        [AfterScenario]
        public void AfterScenario()
        {
            if (_scenarioContext.TestError == null)
            {
                //DeletePF
                if (_featureContext.FeatureInfo.Title.Equals("PublishPrintFormatWithExistingCode"))
                {
                    Actions action = new Actions(_driverHelper.driver);
                    action.Click(DeletePF);
                    action.Perform();
                    Thread.Sleep(3000);
                    Deletebutton.Click();
                }

                //Logout
                Thread.Sleep(4000);
                ProfileIcon.Click();
                Thread.Sleep(2000);
                LogOut.Click();
                submitbutton.Click();

                //Quit Driver
                _driverHelper.driver.Quit();
            }
        }

  
        public MediaEntityModelProvider Capture(string Name)
        {
            var screenshot = ((ITakesScreenshot)_driverHelper.driver).GetScreenshot().AsBase64EncodedString;
            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, Name).Build();
        }
    }
}