using OpenQA.Selenium;
using Microsoft.Extensions.Configuration;

namespace SpecFlow_MSTestFrameWork.PageObjects
{
   public class HomePage
    {
        private IWebDriver Driver;
        public HomePage(IWebDriver driver)
        {
            Driver = driver;
        }
        public string getConfiguration(string fileName, string property)
        {
            var configBuilder = new ConfigurationBuilder().AddJsonFile(fileName);
            IConfiguration config = configBuilder.Build();
            return config[property];
        }

    }
}
