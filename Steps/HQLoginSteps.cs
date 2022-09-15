using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using SpecFlow_MSTestFrameWork.PageObjects;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlow_MSTestFrameWork.StepDefinitions
{
    [Binding]
    public class HQLoginSteps
    {
        private readonly DriverHelper _driverHelper;
        HQLoginPage hQLoginPage;

        public HQLoginSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            hQLoginPage = new HQLoginPage(_driverHelper.driver);
        }

        /// <summary>
        /// Enter the application Url for HQ Application. Common for all tests
        /// </summary>
        [Given(@"user navigates to HQ application")]
        public void GivenUserNavigatesToHQApplication()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsetting.json").Build();
            var initialurl = config["hqappUrl"];
            _driverHelper.driver.Navigate().GoToUrl(initialurl);
        }

        /// <summary>
        /// Enter the url for SR application
        /// </summary>
        [Then(@"user navigates to SR application")]
    public void ThenUserNavigatesToSRApplication()
    {
        var config = new ConfigurationBuilder().AddJsonFile("appsetting.json").Build();
        var initialurl = config["srappUrl"];
        ((IJavaScriptExecutor)_driverHelper.driver).ExecuteScript("window.open();");
        _driverHelper.driver.SwitchTo().Window(_driverHelper.driver.WindowHandles.Last());
        _driverHelper.driver.Navigate().GoToUrl(initialurl);
    }
        /// <summary>
        /// Click on Login Buuton in SR App. Common for tests requireng verification in SR
        /// </summary>

        [When(@"Clicks on Login button of SR app")]
        public void WhenClicksOnLoginButtonOfSRApp()
        {
            Thread.Sleep(4000);
            hQLoginPage.ClickSRBtnSignIn();
            Thread.Sleep(8000);
            hQLoginPage.UserLoginAvailable();
        }

        /// <summary>
        /// Entering Login credentials for HQ Application
        /// </summary>
        /// <param name="username"></Automation>
        /// <param name="hqpassword"></Automation>

        [When(@"enter valid '(.*)', '(.*)'")]
        public void WhenEnterValid(string username, string hqpassword)
        {
            hQLoginPage.EnterCredentials(username, hqpassword);
        }   

        /// <summary>
        /// Click on button Login in HQ Appliation. Common for all tests
        /// </summary>
        [When(@"Clicks on Log In button")]
        public void WhenClicksOnLogInButton()
        {
            hQLoginPage.ClickBtnSignIn();
            Thread.Sleep(1000);
            hQLoginPage.UserLoginAvailable(); 
        }

        /// <summary>
        /// Asserting for Home page in HQ application. Common Function for all test cases
        /// </summary>
        [Then(@"HQ homepage should be displayed")]
        public void ThenHQHomepageShouldBeDisplayed()
        {
            hQLoginPage.UserVerification();
        }

        /// <summary>
        /// Cilck on Logout From HQ application. Common function for all the tests 
        /// </summary>
        [Then(@"User is able to logout")]
        public void ThenUserIsAbleToLogout()
        {
            hQLoginPage.UserLogout();
        }



    }
}
