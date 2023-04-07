using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SampleProject.GenericMethods;
using TechTalk.SpecFlow;

namespace SampleProject.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        
        string url = CommonSteps.configData("appUrl");
        string browser = CommonSteps.configData("browser");

        public IWebDriver _driver;



        [BeforeScenario]
        public void BeforeScenario()
        {
            if(browser.Equals("Chrome"))
            {
                _driver = new ChromeDriver();
            }
            else if(browser.Equals("Firefox"))
            {
                _driver = new FirefoxDriver();
            }
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(url);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }


    }
}